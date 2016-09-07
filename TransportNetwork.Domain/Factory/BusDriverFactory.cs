using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class BusDriverFactory
    {

        public BusDriver Create(int busDriverId, string firstName, string surName, string middleName, int experience, string city, string street, int house, int room, string telephone, string passport, int carrierCompanyId)
        {

            var busDriver = new BusDriver(firstName, surName, middleName, experience, city, street, house, room, telephone, passport, carrierCompanyId);
            busDriver.SetBusDriverId(busDriverId);
            return busDriver;

        }

    }
}
