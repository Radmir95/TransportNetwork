using TransportNetwork.Domain.Entity;

namespace TransportNetwork.Domain.Factory
{
    public class EmployeeFactory
    {

        public Employee Create(int employeeId, string firstName, string surName, string middleName, int experience, string role, string city, string street, int house, int room, string telephone, string passport)
        {

            var employee = new Employee(firstName, surName, middleName, experience, role, city, street, house, room, telephone, passport);
            employee.SetEmployeeId(employeeId);
            return employee;

        }

    }
}
