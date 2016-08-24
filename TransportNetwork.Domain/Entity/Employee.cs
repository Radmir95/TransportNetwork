namespace TransportNetwork.Domain.Entity
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public int Experience { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int House { get; private set; }
        public int Room { get; private set; }
        public string Telephone { get; private set; }

        public Employee(string firstName, string lastName, string middleName, int experience, string city, string street,
            int house, int room, string telephone)
        {

            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Experience = experience;
            City = city;
            Street = street;
            House = house;
            Room = room;
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