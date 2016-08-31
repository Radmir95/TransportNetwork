﻿using System;
using System.Collections.Generic;

namespace TransportNetwork.Domain.Entity
{
    public class CarrierCompany
    {

        public List<Employee> Employees { get; }
        public List<Bus> Busses { get; }
        public int CarrierCompanyId { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int House { get; private set; }
        public string Telephone { get; set; }

        public CarrierCompany()
        {

            Employees = Employees ?? new List<Employee>();
            Busses = Busses ?? new List<Bus>();
        }

        public CarrierCompany(string name, string city, string street, int house, string telephone)
        {

            if (name == null)
                throw new ArgumentNullException("Name can't be null");
            Name = name;
            if (city == null)
                throw new ArgumentNullException("City can't be null");
            City = city;
            if (street == null)
                throw new ArgumentNullException("Street can't be null");
            Street = street;
            if (telephone == null)
                throw new ArgumentNullException("Telephone can't be null");
            Telephone = telephone;
            House = house;
            Employees = Employees ?? new List<Employee>();
            Busses = Busses ?? new List<Bus>();

        }

        internal void SetCarrierCompanyId(int carrierCompanyId)
        {
            CarrierCompanyId = carrierCompanyId;
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