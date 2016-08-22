using System;

namespace TransportNetwork.Domain.Entity
{
    public class Ticket
    {

        public int TicketId { get; set; }
        public DateTime? DateOfSale { get; set; }
        public double Cost { get; set; }
        public DateTime? DateOfDeparture { get; set; }
        public int EmployeeId { get; set; }

    }
}