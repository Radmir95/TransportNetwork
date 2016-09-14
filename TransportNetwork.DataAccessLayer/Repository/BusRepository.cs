using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.Domain.Entity;
using TransportNetwork.Domain.Factory;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class BusRepository
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

        public void UpdateBus(Bus bus)
        {


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

        public void DeleteBus(Bus bus)
        {


        }

    }
}
