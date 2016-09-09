using System.Collections.Generic;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface IBusRepository
    {

        void AddBus(Bus bus);
        void DeleteBus(Bus bus);
        List<Bus> GetAllBusses();
        void UpdateBus(Bus bus);

    }
}
