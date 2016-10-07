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

            if (passengers == null) return;

            foreach (var passengerLoop in passengers)
            {
                listOfPassengers.Items.Add(passengerLoop.PassengerId);
            }

            var passenger = passengers[0];

            FillForm(passenger);


        }

        private void Exit_Click(object sender, EventArgs e)
        {

            Close();
            var cashierForm = new CashierForm();
            cashierForm.Show();

        }

        private void update_Click(object sender, EventArgs e)
        {



        }

        private void add_Click(object sender, EventArgs e)
        {



        }

        private void delete_Click(object sender, EventArgs e)
        {



        }

        private void listOfPassengers_SelectedIndexChanged(object sender, EventArgs e)
        {

            var passengers = PassengerRepository.GetAllPassengers();

            var passenger = passengers[listOfPassengers.SelectedIndex];

            FillForm(passenger);


        }

        private void FillForm(Passenger passenger)
        {

            nameTb.Text = passenger.FirstName;
            surnameTb.Text = passenger.SurName;
            middleTb.Text = passenger.MiddleName;
            telephoneTb.Text = passenger.Telephone;
            passportTb.Text = passenger.Passport;

        }

    }
}
