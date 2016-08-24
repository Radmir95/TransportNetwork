using System;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class TicketFactory
    {

        public Ticket Create(int ticketId, DateTime? dateOfSale, double cost, DateTime? dateOfDeparture, Employee employee)
        {
            
            Ticket ticket = new Ticket(dateOfSale, cost, dateOfDeparture, employee);
            ticket.SetTicketId(ticketId);
            return ticket;

        }

    }
}
