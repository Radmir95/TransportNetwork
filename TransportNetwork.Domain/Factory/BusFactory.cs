using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class BusFactory
    {

        public Bus Create(string numberPlate, string brand, string model, int numberOfSeats, int employeeId)
        {
            var bus = new Bus(brand, model, numberOfSeats, employeeId);
            bus.SetNumberPlate(numberPlate);
            return bus;
        }

    }
}
