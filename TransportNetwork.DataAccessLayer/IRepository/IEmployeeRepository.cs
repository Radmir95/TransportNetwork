using System.Collections.Generic;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface IEmployeeRepository
    {

        void AddEmployee(Employee busDriver);
        void DeleteEmployee(Employee busDriver);
        void UpdateEmployee(Employee busDriver);
        List<Employee> GetEmployee();
        
    }
}