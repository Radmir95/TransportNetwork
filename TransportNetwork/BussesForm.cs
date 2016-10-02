using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;
using TransportNetwork.Domain.Factory;
using TransportNetwork.WebFormsApplication.Helpers;

namespace TransportNetwork.WebFormsApplication
{
    public partial class BussesForm : Form
    {

        public IBusRepository BusRepository;

        public BussesForm()
        {

            BusRepository = new BusRepository();
            InitializeComponent();
            FillBusForm();

        }

        private void FillBusForm()
        {
            var busses = BusRepository.GetAllBusses();
            foreach (var bus in busses)
            {
                listOfBusses.Items.Add(bus.NumberPlate);
            }
            if (busses.Count <= 0) return;
            markTb.Text = busses[0].Brand;
            modelTb.Text = busses[0].Model;
            seatsTb.Text = busses[0].NumberOfSeats.ToString();
            driverTb.Text = busses[0].EmployeeId.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            var bus = GetBusModel();
            BusRepository.UpdateBus(bus);
            RefreshForm();

        }

        private void AddBus_Click(object sender, EventArgs e)
        {

            var mark = markTb.Text;
            var model = modelTb.Text;
            var numberOfSeats = seatsTb.Text;
            var employeeId = driverTb.Text;

            var bus = new Bus(mark, model, Convert.ToInt32(numberOfSeats), Convert.ToInt32(employeeId));
            BusRepository.AddBus(bus);

            RefreshForm();
        }


        public Bus GetBusModel()
        {

            var numberPlate = listOfBusses.SelectedItem;
            var mark = markTb.Text;
            var model = modelTb.Text;
            var numberOfSeats = seatsTb.Text;
            var employeeId = driverTb.Text;

            var busFactory = new BusFactory();
            var bus = busFactory.Create(numberPlate.ToString(), mark, model, Convert.ToInt32(numberOfSeats), Convert.ToInt32(employeeId));
            return bus;
        }

        public void RefreshForm()
        {

            Close();
            var bussesForm = new BussesForm();
            bussesForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            var bus = GetBusModel();
            BusRepository.DeleteBus(bus);
            RefreshForm();

        }

        private void Back_Click(object sender, EventArgs e)
        {

            Close();
            var administratorForm = new AdministratorForm();
            administratorForm.Show();

        }

        private void ChangeDriver_Click(object sender, EventArgs e)
        {

            EmployeeHelper.NumberPlate = listOfBusses.SelectedText;
            EmployeeHelper.Mark = markTb.Text;
            EmployeeHelper.Model = modelTb.Text;
            EmployeeHelper.NumberOfSeats = Convert.ToInt32(seatsTb.Text);

            Close();
            var changeBusDriverForm = new ChangeBusDriverForm();
            changeBusDriverForm.Show();

        }

        private void listOfBusses_SelectedIndexChanged(object sender, EventArgs e)
        {

            var busses = BusRepository.GetAllBusses();
            FillFields(busses[listOfBusses.SelectedIndex]);

        }


        private void FillFields(Bus bus)
        {

            markTb.Text = bus.Brand;
            modelTb.Text = bus.Model;
            seatsTb.Text = bus.NumberOfSeats.ToString();

        }

    }
}
