using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.WebFormsApplication
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            IEmployeeRepository employeeRepository = new EmployeeRepository();
            var employees = employeeRepository.GetEmployee();
            foreach (var busDriver in employees)
            {

                listOfEmployees.Items.Add(busDriver.EmployeeId);
            }

            if (employees.Count == 0) return;
            {
                var employee = employees[0];
                listOfEmployees.Text = employee.EmployeeId.ToString();
                nameTb.Text = employee.FirstName;
                surnameTb.Text = employee.SurName;
                middleTb.Text = employee.MiddleName;
                experienceTb.Text = employee.Experience.ToString();
                roleTb.Text = employee.Role;
                cityTb.Text = employee.City;
                streetTb.Text = employee.Street;
                houseTb.Text = employee.House.ToString();
                roomTb.Text = employee.Room.ToString();
                telephoneTb.Text = employee.Telephone;
                passportTb.Text = employee.Passport;

            }
        }

        private void listOfEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            IEmployeeRepository employeeRepository = new EmployeeRepository();

            var name = nameTb.Text;
            var surname = surnameTb.Text;
            var middlename = middleTb.Text;
            var experience = Convert.ToInt32(experienceTb.Text);
            var role = roleTb.Text;
            var city = cityTb.Text;
            var street = streetTb.Text;
            var house = Convert.ToInt32(houseTb.Text);
            var room = Convert.ToInt32(roomTb.Text);
            var telephone = telephoneTb.Text;
            var passport = passportTb.Text;

            var employee = new Employee(name, surname, middlename, experience, role, city, street, house, room, telephone, passport);
            employeeRepository.AddEmployee(employee);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {



        }


    }
}
