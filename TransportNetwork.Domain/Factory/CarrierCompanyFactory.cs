using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class CarrierCompanyFactory
    {

        public CarrierCompany Create(int carrierCompanyId, string name, string city, string street, int house, string telephone)
        {

            CarrierCompany carrierCompany = new CarrierCompany(name, city, street, house, telephone);
            carrierCompany.SetCarrierCompanyId(carrierCompanyId);
            return carrierCompany;

        }

    }
}
