using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface ITicketRepository
    {

        void AddTicket(Ticket ticket);

    }
}
