using System;

namespace TransportNetwork.Domain.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime? DateOfSale { get; private set; }
        public double Cost { get; private set; }
        public DateTime? DateOfDeparture { get; private set; }
        public Employee Employee { get; private set; }

        public Ticket(DateTime? dateOfSale, double cost, DateTime? dateOfDeparture, Employee employee)
        {
            
            if (DateOfSale == null)
                throw new ArgumentNullException("DateOfSale can't be null");
            DateOfSale = dateOfSale;
            if (DateOfDeparture == null)
                throw new ArgumentNullException("dateOfDeparture can't be null");
            DateOfDeparture = dateOfDeparture;
            if (employee == null)
                throw new ArgumentNullException("Employee can't be null");
            Employee = employee;
            Cost = cost;

        }

        internal void SetTicketId(int ticketId)
        {
            TicketId = ticketId;
        }

    }
}