using System;
using System.Data;
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
            "(timeOfDeparture, timeOfArrival, distance, pointOfDeparture, pointOfArrival)"
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
               Console.WriteLine(ex.ToString());
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

        public int GetTourId(Tour tour)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetTourId =
                new SqlCommand(
                    "SELECT tourId FROM Tour WHERE distance = @distance",
                    conn);

            var param = new SqlParameter();

            param.ParameterName = "@distance";
            param.Value = tour.Distance;
            param.SqlDbType = SqlDbType.Int;
            cmdGetTourId.Parameters.Add(param);

            var tourId = 0;

            try
            {
                using (var dr = cmdGetTourId.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tourId = (int)dr["tourId"];
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

            return tourId;

        }

        public Tour GetTourById(int tourId)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetTour =
                new SqlCommand(
                    "SELECT tourId, timeOfDeparture, timeOfArrival, distance, pointOfDeparture, pointOfArrival FROM Tour WHERE tourId = @tourId",
                    conn);

            var param = new SqlParameter();

            param.ParameterName = "@tourId";
            param.Value = tourId;
            param.SqlDbType = SqlDbType.Int;
            cmdGetTour.Parameters.Add(param);

            Tour tour = null;

            try
            {
                using (var dr = cmdGetTour.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tour = new Tour((DateTime)dr["timeOfDeparture"], (DateTime)dr["timeOfArrival"], (int)dr["distance"], dr["pointOfDeparture"].ToString(), dr["pointOfArrival"].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return tour;
        }
    }
}
