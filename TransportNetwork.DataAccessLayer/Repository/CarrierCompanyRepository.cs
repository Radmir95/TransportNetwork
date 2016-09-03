using Infrastructure.ILoggerManager;
using System;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;
using System.Collections.Generic;
using TransportNetwork.Domain.Factory;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class CarrierCompanyRepository : ICarrierCompanyRepository
    {

        private readonly ConnectionContext _context;
        private readonly ILogger _log;

        public void AddBus(Bus bus)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddBus = new SqlCommand("INSERT INTO Bus" +
            "(numberPlate, brand, model, numberOfSeats, carrierCompanyId) VALUES (@numberPlate, @brand, @model, @numberOfSeats, @carrierCompanyId)", conn);

            var param = new SqlParameter();

            param.ParameterName = "@numberPlate";
            param.Value = bus.NumberPlate;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@brand";
            param.Value = bus.Brand;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@model";
            param.Value = bus.Model;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@numberOfSeats";
            param.Value = bus.NumberOfSeats;
            param.SqlDbType = SqlDbType.Int;
            cmdAddBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@carrierCompanyId";
            param.Value = bus.CarrierCompanyId;
            param.SqlDbType = SqlDbType.Int;
            cmdAddBus.Parameters.Add(param);

            try
            {
                cmdAddBus.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                _log.AddExceptionError(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void AddBusDriver(BusDriver busDriver)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddBusDriver = new SqlCommand("INSERT INTO BusDriver" +
            "(firstName, surName, middleName, experience, city, street, house, room, telephone, passport, busId)"
            +" VALUES (@firstName, @surName, @middleName, @experience, @city, @street, @house, @room, @telephone, @passport, @busId)", conn);

            var param = new SqlParameter();

            param.ParameterName = "@firstName";
            param.Value = busDriver.FirstName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@surName";
            param.Value = busDriver.SurName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@middleName";
            param.Value = busDriver.MiddleName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@experience";
            param.Value = busDriver.Experience;
            param.SqlDbType = SqlDbType.Int;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@city";
            param.Value = busDriver.City;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@street";
            param.Value = busDriver.Street;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@house";
            param.Value = busDriver.House;
            param.SqlDbType = SqlDbType.Int;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@room";
            param.Value = busDriver.Room;
            param.SqlDbType = SqlDbType.Int;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@telephone";
            param.Value = busDriver.Telephone;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@passport";
            param.Value = busDriver.Passport;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddBusDriver.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@busId";
            param.Value = busDriver.BusId;
            param.SqlDbType = SqlDbType.Int;
            cmdAddBusDriver.Parameters.Add(param);

            try
            {
                cmdAddBusDriver.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                _log.AddExceptionError(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void AddNewCarrierCompany(CarrierCompany carrierCompany)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddCarrierCompany = new SqlCommand("INSERT INTO CarrierCompany" +
            "(name, city, street, house, telephone) VALUES (@name, @city, @street, @house, @telephone)", conn);

            var param = new SqlParameter();

            param.ParameterName = "@name";
            param.Value = carrierCompany.Name;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddCarrierCompany.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@city";
            param.Value = carrierCompany.City;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddCarrierCompany.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@street";
            param.Value = carrierCompany.Street;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddCarrierCompany.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@house";
            param.Value = carrierCompany.House;
            param.SqlDbType = SqlDbType.Int;
            cmdAddCarrierCompany.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@telephone";
            param.Value = carrierCompany.Telephone;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddCarrierCompany.Parameters.Add(param);

            try
            {
                cmdAddCarrierCompany.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                _log.AddExceptionError(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        public void DeleteBus(Bus bus)
        {
           



        }

        public void DeleteBusDriver(BusDriver busDriver)
        {
            



        }

        public void DeleteCarrierCompany(CarrierCompany carrierCompany)
        {
           



        }

        public List<Bus> GetAllBusses(Bus bus)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetBusses = new SqlCommand("SELECT numberPlate, brand, model, numberOfSeats, carrierCompanyId, busDriverId FROM Bus", conn);

            var busses = new List<Bus>();

            try
            {
                using (var dr = cmdGetBusses.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var busFactory = new BusFactory();
                        var _bus = busFactory.Create((string)dr["numberPlate"], (string)dr["brand"], (string)dr["model"], (int)dr["numberOfSeats"], (int)dr["carrierCompanyId"], (int)dr["busDriverId"]);
                        busses.Add(_bus);
                    }
                }
            }
            catch (SqlException ex)
            {
                _log.AddExceptionError(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return busses;

        }

        public List<CarrierCompany> GetAllCarrierCompanies()
        {

            

        }

        public void UpdateBus(Bus bus)
        {
         
            
            
               
        }

        public void UpdateBusDriver(BusDriver busDriver)
        {
           



        }

        public void UpdateCarrierCompany(CarrierCompany carrierCompany)
        {
           



        }
    }
}
