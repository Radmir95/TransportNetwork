﻿using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class TourRepository : ITourRepository
    {

        private readonly ConnectionContext _context;

        public TourRepository()
        {
            _context = new ConnectionContext();
        }

        public void AddTour(Tour tour)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddTour = new SqlCommand("INSERT INTO Tour" +
            "(timeOfDeparture, timeOfArrival, distance, pointOfDeparture)"
            + " VALUES (@timeOfDeparture, @timeOfArrival, @distance, @pointOfDeparture, @pointOfArrival)", conn);

            var param = new SqlParameter();

            param.ParameterName = "@timeOfDeparture";
            param.Value = tour.TimeOfDeparture;
            param.SqlDbType = SqlDbType.DateTime;
            cmdAddTour.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@timeOfArrival";
            param.Value = tour.TimeOfArrival;
            param.SqlDbType = SqlDbType.DateTime;
            cmdAddTour.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@distance";
            param.Value = tour.Distance;
            param.SqlDbType = SqlDbType.Int;
            cmdAddTour.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@pointOfDeparture";
            param.Value = tour.PointOfDeparture;
            param.SqlDbType = SqlDbType.Text;
            cmdAddTour.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@pointOfArrival";
            param.Value = tour.PointOfArrival;
            param.SqlDbType = SqlDbType.Text;
            cmdAddTour.Parameters.Add(param);

            try
            {
                cmdAddTour.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
               
            }
            finally
            {
                conn.Close();
            }

        }

        public void DeleteTour(Tour tour)
        {
            



        }

        public void UpdateTour(Tour tour)
        {
            



        }
    }
}
