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

        public CarrierCompanyRepository()
        {

            _context = new ConnectionContext("SqlConn");

        }

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
            catch (SqlException)
            {
                
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
            "(firstName, surName, middleName, experience, city, street, house, room, telephone, passport)"
            + " VALUES (@firstName, @surName, @middleName, @experience, @city, @street, @house, @room, @telephone, @passport)", conn);

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

            try
            {
                cmdAddBusDriver.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                
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
            catch (SqlException)
            {
                
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

        public List<BusDriver> GetAllBusDrivers()
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetAllBusDrivers = new SqlCommand("SELECT busDriverId, firstName, surName, middleName, experience, city, street, house, room, telephone, passport, carrierCompanyId FROM BusDriver", conn);

            var busDrivers = new List<BusDriver>();

            try
            {
                using (var dr = cmdGetAllBusDrivers.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var busDriverFactory = new BusDriverFactory();
                        var busDriver = busDriverFactory.Create((int)dr["busDriverId"], (string)dr["firstName"], (string)dr["surName"], (string)dr["middleName"], (int)dr["experience"], (string)dr["city"], (string)dr["street"], (int)dr["house"], (int)dr["room"], (string)dr["telephone"], (string)dr["passport"], (int)dr["carrierCompanyId"]);
                        busDrivers.Add(busDriver);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return busDrivers;


        }

        public List<Bus> GetAllBusses()
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
                        var bus = busFactory.Create((string)dr["numberPlate"], (string)dr["brand"], (string)dr["model"], (int)dr["numberOfSeats"], (int)dr["carrierCompanyId"], (int)dr["busDriverId"]);
                        busses.Add(bus);
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

            return busses;

        }

        public List<CarrierCompany> GetAllCarrierCompanies()
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetCarrierCompanies = new SqlCommand("SELECT carrierCompanyId, name, city, street, house, telephone FROM CarrierCompany", conn);

            var carrierCompanies = new List<CarrierCompany>();

            try
            {
                using (var dr = cmdGetCarrierCompanies.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var carrierCompanyFactory = new CarrierCompanyFactory();
                        var carrierCompany = carrierCompanyFactory.Create((int)dr["carrierCompanyId"], (string)dr["name"], (string)dr["city"], (string)dr["street"], (int)dr["house"], (string)dr["telephone"]);
                        carrierCompanies.Add(carrierCompany);
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

            return carrierCompanies;

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
