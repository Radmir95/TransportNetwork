using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class BusFactory
    {

        public Bus Create(string numberPlate, string brand, string model, int numberOfSeats)
        {
            Bus bus = new Bus(brand, model, numberOfSeats);
            bus.SetNumberPlate(numberPlate);
            return bus;
        }

    }
}
