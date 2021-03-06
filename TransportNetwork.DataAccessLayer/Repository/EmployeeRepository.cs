﻿using System;
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


        public void AddEmployee(Employee busDriver)
        {
            var context = _context.Create();
            var conn = (SqlConnection) context;

            var cmdAddEmployee = new SqlCommand("INSERT INTO Employee" +
                                                "(firstName, surName, middleName, experience, role, city, street, house, room, telephone, passport)"
                                                +
                                                " VALUES (@firstName, @surName, @middleName, @experience, @role, @city, @street, @house, @room, @telephone, @passport)",
                conn);

            var param = new SqlParameter();

            param.ParameterName = "@firstName";
            param.Value = busDriver.FirstName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@surName";
            param.Value = busDriver.SurName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@middleName";
            param.Value = busDriver.MiddleName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@experience";
            param.Value = busDriver.Experience;
            param.SqlDbType = SqlDbType.Int;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@role";
            param.Value = busDriver.Role;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@city";
            param.Value = busDriver.City;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@street";
            param.Value = busDriver.Street;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@house";
            param.Value = busDriver.House;
            param.SqlDbType = SqlDbType.Int;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@room";
            param.Value = busDriver.Room;
            param.SqlDbType = SqlDbType.Int;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@telephone";
            param.Value = busDriver.Telephone;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@passport";
            param.Value = busDriver.Passport;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddEmployee.Parameters.Add(param);

            try
            {
                cmdAddEmployee.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
        }


        public void DeleteEmployee(Employee employee)
        {
            var context = _context.Create();
            var conn = (SqlConnection) context;

            var cmdDeleteEmployee = new SqlCommand("DELETE FROM Employee WHERE employeeId = @employeeId", conn);


            var param = new SqlParameter();

            param.ParameterName = "@employeeId";
            param.Value = employee.EmployeeId;
            param.SqlDbType = SqlDbType.Int;
            cmdDeleteEmployee.Parameters.Add(param);

            try
            {
                cmdDeleteEmployee.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Employee> GetEmployee()
        {
            var context = _context.Create();
            var conn = (SqlConnection) context;

            var cmdGetAllEmployee =
                new SqlCommand(
                    "SELECT employeeId, firstName, surName, middleName, experience, role, city, street, house, room, telephone, passport FROM Employee",
                    conn);

            var employees = new List<Employee>();

            try
            {
                using (var dr = cmdGetAllEmployee.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var employeeFactory = new EmployeeFactory();
                        var employee = employeeFactory.Create((int) dr["employeeId"], (string) dr["firstName"],
                            (string) dr["surName"], (string) dr["middleName"], (int) dr["experience"],
                            (string) dr["role"], (string) dr["city"], (string) dr["street"], (int) dr["house"],
                            (int) dr["room"], (string) dr["telephone"], (string) dr["passport"]);
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


        public void UpdateEmployee(Employee employee)
        {
            var context = _context.Create();
            var conn = (SqlConnection) context;

            var cmdUpdateUser = new SqlCommand("UPDATE Employee" +
                                               " SET firstName = @firstName, surName = @surName, middleName = @middleName, experience = @experience, city = @city, street = @street, house = @house, room = @room, telephone = @telephone, passport = @passport, role = @role WHERE employeeId = @employeeId",
                conn);

            var param = new SqlParameter();

            param.ParameterName = "@employeeId";
            param.Value = employee.EmployeeId;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@firstName";
            param.Value = employee.FirstName;
            param.SqlDbType = SqlDbType.Text;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@surName";
            param.Value = employee.SurName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@middleName";
            param.Value = employee.MiddleName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@experience";
            param.Value = employee.Experience;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@role";
            param.Value = employee.Role;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@city";
            param.Value = employee.City;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@street";
            param.Value = employee.Street;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@house";
            param.Value = employee.House;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@room";
            param.Value = employee.Room;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@telephone";
            param.Value = employee.Telephone;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@passport";
            param.Value = employee.Passport;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateUser.Parameters.Add(param);

            try
            {
                cmdUpdateUser.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }
    }
}