﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class WaybillRepository : IWaybillRepository
    {

        private readonly ConnectionContext _context;

        public WaybillRepository()
        {
            _context = new ConnectionContext();
        }

        public void AddWaybill(Waybill waybill)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;
            var tourRepository = new TourRepository();

            var tour = waybill.Tour;
            tourRepository.AddTour(tour);
            var bus = waybill.Bus;

            var cmdAddWaybill = new SqlCommand("INSERT INTO Waybill" +
                                                "(numberPlate, tourId)"
                                                +
                                                " VALUES (@numberPlate, @tourId)",
                conn);

            var param = new SqlParameter();
            param.ParameterName = "@numberPlate";
            param.Value = bus.NumberPlate;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddWaybill.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@tourId";
            param.Value = tour.TourId;
            param.SqlDbType = SqlDbType.Int;
            cmdAddWaybill.Parameters.Add(param);

            try
            {
                cmdAddWaybill.ExecuteNonQuery();
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        public List<Waybill> GetAllWaybills()
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetAllWaybills =
                new SqlCommand(
                    "SELECT waybillId, ticketId, numberPlate, tourId FROM Waybill",
                    conn);

            var waybills = new List<Waybill>();

            var tourRepository = new TourRepository();
            var busRepository = new BusRepository();

            try
            {
                using (var dr = cmdGetAllWaybills.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (dr["ticketId"] != DBNull.Value)
                        {
                            //
                        }
                        else
                        {
                            var waybillId = (int) dr["waybillId"];
                            var numberPlate = dr["numberPlate"].ToString();
                            var tourId = (int) dr["tourId"];
                            var tour = tourRepository.GetTourById(tourId);
                            tour.SetTourId(tourId);
                            var buses = busRepository.GetAllBusses();
                            Bus bus = null;
                            foreach (var busLoop in buses)
                            {
                                if (busLoop.NumberPlate == numberPlate)
                                    bus = busLoop;
                            }
                            var waybill = new Waybill(bus, tour);
                            waybill.SetWaybillId(waybillId);
                            waybills.Add(waybill);
                        }
                        
                    }
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }

            return waybills;

        }
    }
}
