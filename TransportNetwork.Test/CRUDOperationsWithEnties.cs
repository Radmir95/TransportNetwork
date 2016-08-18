using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TransportNetwork.Test
{
    [TestFixture]
    public class CRUDOperationsWithEnties
    {
        [Test]
        public void AddingNewEmployeeInCarrierCompany()
        {

            Employee newEmployee = new Employee();
            Assert.That(newEmployee, Is.Not.Null);

        }



    }
}
