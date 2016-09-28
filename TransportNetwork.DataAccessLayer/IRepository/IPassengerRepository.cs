
using System.Collections.Generic;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface IPassengerRepository
    {

        void AddPassenger(Passenger passenger);
        void DeletePassenger(Passenger passenger);
        List<Passenger> GetAllPassengers();
        void UpdatePassenger(Passenger passenger);

    }
}
