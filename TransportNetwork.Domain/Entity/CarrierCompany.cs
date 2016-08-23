using System.Collections.Generic;

namespace TransportNetwork.Domain.Entity
{
    public class CarrierCompany
    {
        public CarrierCompany()
        {
            Employees = Employees ?? new List<Employee>();
            Busses = Busses ?? new List<Bus>();
        }

        private List<Employee> Employees { get; }
        private List<Bus> Busses { get; }

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

        public void AddNewBus(Bus bus)
        {
            Busses.Add(bus);
        }

        public bool HasBus(Bus bus)
        {
            return Busses.Contains(bus);
        }
    }
}