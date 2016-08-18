using NUnit.Framework;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Test
{
    [TestFixture]
    public class CRUDOperationsWithEnties
    {

        private CarrierCompany carrierCompany;

        [SetUp]
        public void SetUp()
        {

            carrierCompany = new CarrierCompany();

        }

        [Test]
        public void AddingNewEmployeeInCarrierCompany()
        {

            Employee newEmployee = new Employee();
            carrierCompany.AddNewEmployee(newEmployee);
            Assert.That(carrierCompany.HasEmployee(newEmployee), Is.True);

        }

        [Test]
        public void FireEmployeeFromCarrierCompany()
        {

            Employee fireEmployee = new Employee();
            carrierCompany.AddNewEmployee(fireEmployee);
            carrierCompany.FireEmployee(fireEmployee);
            Assert.That(carrierCompany.HasEmployee(fireEmployee), Is.False);

        }

        /*[Test]
        public void UpateInformationAboutEmployeeInCarrierCompany()
        {

            Employee employeeWithOldInformation = new Employee();
            Employee employeeWithNewInformation = new Employee();

            carrierCompany.AddNewEmployee(employeeWithOldInformation);
            carrierCompany.UpdateEmployeeInformation(employeeWithNewInformation);

            Assert.That(carrierCompany.HasEmployee(employeeWithNewInformation), Is.True);

        }*/


        

    }
}
