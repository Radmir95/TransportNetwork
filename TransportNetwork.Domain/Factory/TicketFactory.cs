using System;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class TicketFactory
    {

        public Ticket Create(int ticketId, DateTime? dateOfSale, double cost, DateTime dateOfDeparture, Passenger passenger, Employee employee)
        {
            
            var ticket = new Ticket(dateOfSale, cost, dateOfDeparture, passenger, employee);
            ticket.SetTicketId(ticketId);
            return ticket;

        }

    }
}
