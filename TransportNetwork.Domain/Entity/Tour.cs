using System;

namespace TransportNetwork.Domain.Entity
{
    public class Tour
    {
        public int TourId { get; set; }
        public DateTime? TimeOfDeparture { get; set; }
        public DateTime? TimeOfArrival { get; set; }
        public int Distance { get; set; }
        public string PointOfDeparture { get; set; }
    }
}