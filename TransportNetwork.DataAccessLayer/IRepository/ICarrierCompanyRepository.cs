using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface ICarrierCompanyRepository
    {
        void AddBus(Bus bus);
        void AddNewCarrierCompany(CarrierCompany carrierCompany);
        void AddNewEmployee(Employee employee);
        void AddWaybill(Waybill waybill);
        void AddTour(Tour tour);
        void AddTicket(Ticket ticket);
    }
}