using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class PassengerFactory
    {

        public Passenger Create(int passengerId, string firstName, string surName, string middleName, string passport, string telephone)
        {

            var passenger = new Passenger(firstName, surName, middleName, passport, telephone);
            passenger.SetPassengerId(passengerId);
            return passenger;

        }

    }
}
