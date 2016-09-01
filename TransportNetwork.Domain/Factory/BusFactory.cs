using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class BusFactory
    {

        public Bus Create(string numberPlate, string brand, string model, int numberOfSeats, int carrierCompanyId, int busDriverId)
        {
            Bus bus = new Bus(brand, model, numberOfSeats, carrierCompanyId, busDriverId);
            bus.SetNumberPlate(numberPlate);
            return bus;
        }

    }
}
