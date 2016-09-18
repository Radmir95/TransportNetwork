using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;
using TransportNetwork.Domain.Factory;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class BusRepository : IBusRepository
    {

        private readonly ConnectionContext _context;

        public BusRepository()
        {

            _context = new ConnectionContext();

        }

        public void AddBus(Bus bus)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddBus = new SqlCommand("INSERT INTO Bus" +
            "(numberPlate, brand, model, numberOfSeats, employeeId) VALUES (@numberPlate, @brand, @model, @numberOfSeats, @employeeId)", conn);

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
            param.ParameterName = "@employeeId";
            param.Value = bus.EmployeeId;
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

        public void UpdateBus(Bus bus)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdUpdateBus = new SqlCommand("UPDATE Bus" +
                                               " SET brand = @brand, model = @model, numberOfSeats = @numberOfSeats, employeeId = @employeeId WHERE numberPlate = @numberPlate",
                conn);

            var param = new SqlParameter();

            param.ParameterName = "@numberPlate";
            param.Value = bus.NumberPlate;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@brand";
            param.Value = bus.Brand;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@model";
            param.Value = bus.Model;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdUpdateBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@numberOfSeats";
            param.Value = bus.NumberOfSeats;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdateBus.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@employeeId";
            param.Value = bus.EmployeeId;
            param.SqlDbType = SqlDbType.Int;
            cmdUpdateBus.Parameters.Add(param);

            try
            {
                cmdUpdateBus.ExecuteNonQuery();
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        public List<Bus> GetAllBusses()
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetBusses = new SqlCommand("SELECT numberPlate, brand, model, numberOfSeats, employeeId FROM Bus", conn);

            var busses = new List<Bus>();

            try
            {
                using (var dr = cmdGetBusses.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var busFactory = new BusFactory();
                        var bus = busFactory.Create((string)dr["numberPlate"], (string)dr["brand"], (string)dr["model"], (int)dr["numberOfSeats"], (int)dr["employeeId"]);
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

        public void DeleteBus(Bus bus)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdDeleteBus = new SqlCommand("DELETE FROM Bus WHERE numberPlate = @numberPlate", conn);


            var param = new SqlParameter();

            param.ParameterName = "@numberPlate";
            param.Value = bus.NumberPlate;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdDeleteBus.Parameters.Add(param);

            try
            {
                cmdDeleteBus.ExecuteNonQuery();
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
