using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class TicketRepository : ITicketRepository
    {

        private readonly ConnectionContext _context;

        public void AddTicket(Ticket ticket)
        {

            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdAddTicket = new SqlCommand("INSERT INTO Ticket" +
            "(dateOfSale, cost, dateOfDeparture, passengerId) VALUES (@dateOfSale, @cost, @dateOfDeparture, @passengerId)", conn);

            var param = new SqlParameter();

            param.ParameterName = "@dateOfSale";
            param.Value = ticket.DateOfSale;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddTicket.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@cost";
            param.Value = ticket.Cost;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddTicket.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@dateOfDeparture";
            param.Value = ticket.DateOfDeparture;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdAddTicket.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@passengerId";
            param.Value = ticket.Passenger.PassengerId;
            param.SqlDbType = SqlDbType.Int;
            cmdAddTicket.Parameters.Add(param);

            try
            {
                cmdAddTicket.ExecuteNonQuery();
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
