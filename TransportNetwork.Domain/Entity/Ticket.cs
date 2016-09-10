using System;

namespace TransportNetwork.Domain.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime? DateOfSale { get; }
        public double Cost { get; private set; }
        public Tour Tour { get; private set; }
        public Passenger Passenger { get; private set; }
        public Employee Employee { get; private set; }

        public Ticket(DateTime? dateOfSale, double cost, Tour tour, Passenger passenger, Employee employee)
        {
            
            if (dateOfSale == null)
                throw new ArgumentNullException("DateOfSale can't be null");
            DateOfSale = dateOfSale;
            if (tour == null)
                throw new ArgumentNullException("Tour can't be null");
            Tour = tour;
            if (passenger == null)
                throw new ArgumentNullException("Passenger can't be null");
            Passenger = passenger;
            if (employee == null)
                throw new  ArgumentNullException("Employee can't be null");
            Cost = cost;

        }

        internal void SetTicketId(int ticketId)
        {
            TicketId = ticketId;
        }

    }
}