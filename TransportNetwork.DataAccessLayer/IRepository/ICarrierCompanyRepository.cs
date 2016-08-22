using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface ICarrierCompanyRepository
    {

        void AddNewBusInCarrierCompany(CarrierCompany carrierCompany, Bus bus);


    }
}
