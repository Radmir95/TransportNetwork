using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface IBusDriverRepository
    {

        void AddDriver(BusDriver busDriver);
        void DeleteDriver(BusDriver busDriver);
        void UpdateBusDriver(BusDriver busDriver);
        void GetAllBusDriversOfBus(Bus bus);

    }
}
