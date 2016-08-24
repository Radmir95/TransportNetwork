using NUnit.Framework;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Test
{
    [TestFixture]
    public class CRUDOperationsWithEnties
    {
        [SetUp]
        public void SetUp()
        {
            carrierCompany = new CarrierCompany();
        }

        private CarrierCompany carrierCompany;

        [Test]
        public void AddingNewEmployeeInCarrierCompany()
        {
            var newEmployee = new Employee();
            carrierCompany.AddNewEmployee(newEmployee);
            Assert.That(carrierCompany.HasEmployee(newEmployee), Is.True);
        }

        [Test]
        public void AddNewBusInCarrierCompany()
        {
            var bus = new Bus();
            carrierCompany.AddNewBus(bus);
            Assert.That(carrierCompany.HasBus(bus), Is.True);
        }

        [Test]
        public void FireEmployeeFromCarrierCompany()
        {
            var fireEmployee = new Employee();
            carrierCompany.AddNewEmployee(fireEmployee);
            carrierCompany.FireEmployee(fireEmployee);
            Assert.That(carrierCompany.HasEmployee(fireEmployee), Is.False);
        }


    }
}