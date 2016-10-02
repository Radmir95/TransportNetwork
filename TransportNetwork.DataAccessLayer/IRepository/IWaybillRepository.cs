using System.Collections.Generic;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface IWaybillRepository
    {

        void AddWaybill(Waybill waybill);
        List<Waybill> GetAllWaybills();

    }
}
