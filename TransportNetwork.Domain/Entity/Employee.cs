using System;

namespace TransportNetwork.Domain.Entity
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public string MiddleName { get; private set; }
        public int Experience { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int House { get; private set; }
        public int Room { get; private set; }
        public string Telephone { get; private set; }

        public Employee(string firstName, string surName, string middleName, int experience, string city, string street,
            int house, int room, string telephone)
        {
            if (firstName == null)
                throw new ArgumentNullException("First name can't be null");
            FirstName = firstName;
            if (surName == null)
                throw new ArgumentNullException("LastName can't be null");
            Surname = surName;
            if (middleName == null)
                throw new ArgumentNullException("Middle name can't be null");
            MiddleName = middleName;
            Experience = experience;
            if (city == null)
                throw new ArgumentNullException("City can't be null");
            City = city;
            if (street == null)
                throw new ArgumentNullException("Street can't be null");
            Street = street;
            House = house;
            Room = room;
            if (telephone == null)
                throw new ArgumentNullException("Telephone can't be null");
            Telephone = telephone;

        }

        public Employee()
        {
        }

        internal void SetEmployeeId(int employeeId)
        {
            EmployeeId = employeeId;
        }
       
    }
}