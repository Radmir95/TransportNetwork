using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.WebFormsApplication
{
    public partial class PassengerForm : Form
    {

        public PassengerRepository PassengerRepository { get; set; }

        public PassengerForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            PassengerRepository = new PassengerRepository();

            var passengers = PassengerRepository.GetAllPassengers();

            if (passengers.Count == 0) return;

            var passenger = passengers[0];

            FillForm(passenger);

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            Close();
            var cashierForm = new CashierForm();
            cashierForm.Show();

        }

        private void Add_Click(object sender, EventArgs e)
        {

            var passenger = GetPassengerFromForm();
            PassengerRepository.AddPassenger(passenger);
            UpdateForm();
        }

        private void FillForm(Passenger passenger)
        {

            nameTb.Text = passenger.FirstName;
            surnameTb.Text = passenger.SurName;
            middleTb.Text = passenger.MiddleName;
            telephoneTb.Text = passenger.Telephone;
            passportTb.Text = passenger.Passport;

        }

        private void UpdateForm()
        {

            Close();
            var form = new PassengerForm();
            form.Show();

        }

        private Passenger GetPassengerFromForm()
        {

            var firstName = nameTb.Text;
            var surName = surnameTb.Text;
            var middleName = middleTb.Text;
            var telephone = telephoneTb.Text;
            var passport = passportTb.Text;

            var passenger = new Passenger(firstName, surName, middleName, passport, telephone);

            return passenger;
        }

    }
}
