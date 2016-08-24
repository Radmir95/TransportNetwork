using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class EmployeeFactory
    {

        public Employee Create(int employeeId, string firstName, string lastName, string middleName, int experience,
            string city, string street, int house, int room, string telephone)
        {
            Employee employee = new Employee(firstName, lastName, middleName, experience, city, street,
                house, room, telephone);
            employee.SetEmployeeId(employeeId);
            return employee;
        }

    }
}
