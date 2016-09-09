
namespace TransportNetwork.Domain.Entity
{
    public class Employee
    {

        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string SurName { get; private set; }
        public string MiddleName { get; private set; }
        public int Experience { get; private set; }
        public string Role { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int House { get; private set; }
        public int Room { get; private set; }
        public string Telephone { get; private set; }
        public string Passport { get; private set; }


        public Employee(string firstName, string surName, string middleName, int experience, string role, string city, string street, int house, int room, string telephone, string passport)
        {

            FirstName = firstName;
            SurName = surName;
            MiddleName = middleName;
            Experience = experience;
            Role = role;
            City = city;
            Street = street;
            House = house;
            Room = room;
            Telephone = telephone;
            Passport = passport;

        }

        internal void SetEmployeeId(int employeeId)
        {
            EmployeeId = employeeId;
        }

    }
}
