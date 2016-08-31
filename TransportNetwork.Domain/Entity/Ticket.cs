using System;

namespace TransportNetwork.Domain.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime? DateOfSale { get; }
        public double Cost { get; private set; }
        public DateTime? DateOfDeparture { get; }
        public Passenger Passenger { get; private set; }

        public Ticket(DateTime? dateOfSale, double cost, DateTime? dateOfDeparture, Passenger passenger)
        {
            
            if (DateOfSale == null)
                throw new ArgumentNullException("DateOfSale can't be null");
            DateOfSale = dateOfSale;
            if (DateOfDeparture == null)
                throw new ArgumentNullException("dateOfDeparture can't be null");
            DateOfDeparture = dateOfDeparture;
            if (passenger == null)
                throw new ArgumentNullException("Passenger can't be null");
            Passenger = passenger;
            Cost = cost;

        }

        internal void SetTicketId(int ticketId)
        {
            TicketId = ticketId;
        }

    }
}