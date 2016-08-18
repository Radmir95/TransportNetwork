using System;
using System.Collections.Generic;

namespace TransportNetwork.Domain.Entity
{
    public class CarrierCompany
    {
        private List<Employee> Employees { get; }
        private List<Bus> Busses { get; set; }

        public CarrierCompany()
        {
            Employees = Employees ?? new List<Employee>();
        }

        public void AddNewEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        public bool HasEmployee(Employee employee)
        {
            return Employees.Contains(employee);
        }

        public void FireEmployee(Employee fireEmployee)
        {
            Employees.Remove(fireEmployee);
        }

        
    }
}