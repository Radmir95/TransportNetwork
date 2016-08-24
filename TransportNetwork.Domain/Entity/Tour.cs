using System;

namespace TransportNetwork.Domain.Entity
{
    public class Tour
    {
        public int TourId { get; private set; }
        public DateTime? TimeOfDeparture { get; private set; }
        public DateTime? TimeOfArrival { get; private set; }
        public int Distance { get; private set; }
        public string PointOfDeparture { get; private set; }

        public Tour(DateTime? timeOfDeparture, DateTime? timeOfArrival, int distance, string pointOfDeparture)
        {
            
            if (timeOfDeparture == null)
                throw new ArgumentNullException("TimeOfDeparture can't be null");
            TimeOfDeparture = timeOfDeparture;
            if (timeOfArrival == null)
                throw new ArgumentNullException("Time of arrival can't be null");
            TimeOfArrival = timeOfArrival;
            Distance = distance;
            if (PointOfDeparture == null)
                throw new ArgumentNullException("PointOfDeparture can't be null");
            PointOfDeparture = pointOfDeparture;

        }

        internal void SetTourId(int tourId)
        {
            TourId = tourId;
        }
       
    }
}