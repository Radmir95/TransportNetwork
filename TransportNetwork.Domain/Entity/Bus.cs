using System;

namespace TransportNetwork.Domain.Entity
{
    public class Bus
    {
        public string NumberPlate { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int NumberOfSeats { get; private set; }
        public int CarrierCompanyId { get; private set; }

        public Bus(string brand, string model, int numberOfSeats, int carrierCompanyId)
        {

            if (brand == null)
                throw new ArgumentNullException("Brand can't be null");
            Brand = brand;
            if (model == null)
                throw new ArgumentNullException("Model can't be null");
            Model = model;
            NumberOfSeats = numberOfSeats;
            CarrierCompanyId = carrierCompanyId;
        }

        public Bus()
        {
        }

        internal void SetNumberPlate(string numberPlate)
        {
            if (numberPlate == null)
                throw new ArgumentNullException("Number plate can't be null");
            NumberPlate = numberPlate;
        }

    }
}