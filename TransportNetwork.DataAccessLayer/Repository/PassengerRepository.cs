using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;
using TransportNetwork.Domain.Factory;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class PassengerRepository : IPassengerRepository
    {

        private readonly ConnectionContext _context;

        public PassengerRepository()
        {

            _context = new ConnectionContext();

        }

        public void AddPassenger(Passenger passenger)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddPassenger = new SqlCommand("INSERT INTO Passenger" +
                                                "(firstName, surName, middleName, passport, telephone)"
                                                +
                                                " VALUES (@firstName, @surName, @middleName, @telephone, @passport)",
                conn);

            var param = new SqlParameter();

            param.ParameterName = "@firstName";
            param.Value = passenger.FirstName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddPassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@surName";
            param.Value = passenger.SurName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddPassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@middleName";
            param.Value = passenger.MiddleName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddPassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@telephone";
            param.Value = passenger.Telephone;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddPassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@passport";
            param.Value = passenger.Passport;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddPassenger.Parameters.Add(param);

            try
            {
                cmdAddPassenger.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }

        }

        public void DeletePassenger(Passenger passenger)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdDeletePassenger = new SqlCommand("DELETE FROM Passenger WHERE passengerId = @passengerId", conn);


            var param = new SqlParameter();

            param.ParameterName = "@passengerId";
            param.Value = passenger.PassengerId;
            param.SqlDbType = SqlDbType.Int;
            cmdDeletePassenger.Parameters.Add(param);

            try
            {
                cmdDeletePassenger.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }

        }

        public List<Passenger> GetAllPassengers()
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetAllPassengers =
                new SqlCommand(
                    "SELECT passengerId, firstName, surName, middleName, telephone, passport FROM Passenger",
                    conn);

            var passengers = new List<Passenger>();

            try
            {
                using (var dr = cmdGetAllPassengers.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var passengerFacotory = new PassengerFactory();
                        var passenger = passengerFacotory.Create((int)dr["passengerId"], (string)dr["firstName"],
                            (string)dr["surName"], (string)dr["middleName"], (string)dr["telephone"], (string)dr["passport"]);
                        passengers.Add(passenger);
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

            return passengers;
        }

        public void UpdatePassenger(Passenger passenger)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdUpdatePassenger = new SqlCommand("UPDATE Passenger" +
                                               " SET firstName = @firstName, surName = @surName, middleName = @middleName, telephone = @telephone, passport = @passport WHERE passengerId = @passengerId",
                conn);

            var param = new SqlParameter();

            param.ParameterName = "@passengerId";
            param.Value = passenger.PassengerId;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdatePassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@firstName";
            param.Value = passenger.FirstName;
            param.SqlDbType = SqlDbType.Text;
            cmdUpdatePassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@surName";
            param.Value = passenger.SurName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdatePassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@middleName";
            param.Value = passenger.MiddleName;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdatePassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@telephone";
            param.Value = passenger.Telephone;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdatePassenger.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@passport";
            param.Value = passenger.Passport;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdatePassenger.Parameters.Add(param);

            try
            {
                cmdUpdatePassenger.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
