using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;
using TransportNetwork.Domain.Factory;
using TransportNetwork.WebFormsApplication.Helpers;

namespace TransportNetwork.WebFormsApplication
{
    public partial class ChangeBusDriverForm : Form
    {

        public EmployeeRepository EmployeeRepository { get; set; }

        public ChangeBusDriverForm()
        {
            EmployeeRepository = new EmployeeRepository();
            InitializeComponent();
            ChangeBusDriverForm_Load();
        }

        private void ChangeBusDriverForm_Load()
        {

            Employee employee = null;

            var employees = EmployeeRepository.GetEmployee();
            foreach (var busDriver in employees)
            {
                if (busDriver.Role != "водитель") continue;
                listOfEmployees.Items.Add(busDriver.EmployeeId);
                employee = busDriver;
            }
            if (employee == null) return;
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


        private void Apply_Click(object sender, EventArgs e)
        {
            var busRepository = new BusRepository();

            var selectedDriver = Convert.ToInt32(listOfEmployees.SelectedItem);

            var busFactory = new BusFactory();
            var bus = busFactory.Create(EmployeeHelper.NumberPlate, EmployeeHelper.Mark, EmployeeHelper.Model, EmployeeHelper.NumberOfSeats, selectedDriver);

            busRepository.UpdateBus(bus);

            var form = new BussesForm();
            Close();
            form.Show();

        }
    }
}
