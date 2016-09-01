using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface ICarrierCompanyRepository
    {

        void AddBus(Bus bus);
        void DeleteBus(Bus bus);
        void UpdateBus(Bus bus);

        void AddNewCarrierCompany(CarrierCompany carrierCompany);
        void DeleteCarrierCompany(CarrierCompany carrierCompany);

        void UpdateCarrierCompany(CarrierCompany carrierCompany);


        void AddBusDriver(BusDriver busDriver);
        void DeleteBusDriver(BusDriver busDriver);
        void UpdateBusDriver(BusDriver busDriver);
        
    }
}