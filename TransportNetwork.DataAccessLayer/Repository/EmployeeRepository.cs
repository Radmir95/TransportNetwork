using System;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;
using System.Collections.Generic;
using TransportNetwork.Domain.Factory;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ConnectionContext _context;

        public EmployeeRepository()
        {

            _context = new ConnectionContext();

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

        public void AddEmployee(Employee busDriver)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddBusDriver = new SqlCommand("INSERT INTO BusDriver" +
            "(firstName, surName, middleName, experience, city, street, house, room, telephone, passport, carrierCompanyId)"
            + " VALUES (@firstName, @surName, @middleName, @experience, @city, @street, @house, @room, @telephone, @passport, @carrierCompanyId)", conn);

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
            param.ParameterName = "@carrierCompanyId";
            param.Value = busDriver.Passport;
            param.SqlDbType = SqlDbType.Int;
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


        public void DeleteBus(Bus bus)
        {




        }

        public void DeleteEmployee(Employee busDriver)
        {




        }

        public List<Employee> GetEmployee()
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetAllEmployee = new SqlCommand("SELECT employeeId, firstName, surName, middleName, experience, role, city, street, house, room, telephone, passport, carrierCompanyId FROM BusDriver", conn);

            var employees = new List<Employee>();

            try
            {
                using (var dr = cmdGetAllEmployee.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var employeeFactory = new EmployeeFactory();
                        var employee = employeeFactory.Create((int)dr["employeeId"], (string)dr["firstName"], (string)dr["surName"], (string)dr["middleName"], (int)dr["experience"], (string)dr["role"], (string)dr["city"], (string)dr["street"], (int)dr["house"], (int)dr["room"], (string)dr["telephone"], (string)dr["passport"]);
                        employees.Add(employee);
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

            return employees;

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


        public void UpdateBus(Bus bus)
        {




        }

        public void UpdateEmployee(Employee busDriver)
        {




        }

    }
}
