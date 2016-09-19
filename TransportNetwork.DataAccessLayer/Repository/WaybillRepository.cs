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

            param = new SqlParameter();
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
    }
}
