using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;

namespace TransportNetwork.WebFormsApplication
{
    public partial class WaybillsForm : Form
    {
        public WaybillsForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {

            var waybillRepository = new WaybillRepository();
            var waybills = waybillRepository.GetAllWaybills();

            foreach (var waybillInLoop in waybills)
            {
                listOfWaybills.Items.Add(waybillInLoop.WaybillId);
            }

            var waybill = waybills[0];
            var bus = waybill.Bus;
            var tour = waybill.Tour;

            listOfWaybills.Text = waybill.WaybillId.ToString();

            numberPlateTb.Text = bus.NumberPlate;
            markTb.Text = bus.Brand;
            modelTb.Text = bus.Model;
            numberOfSeatsTb.Text = bus.NumberOfSeats.ToString();

            dateOfArrivalTb.Text = tour.TimeOfArrival.Value.ToShortDateString();
            dataOfDepartureTb.Text = tour.TimeOfDeparture.Value.ToShortDateString();
            distanceTb.Text = tour.Distance.ToString();
            pointOfArrival.Text = tour.PointOfArrival;
            pointOfDepartureTb.Text = tour.PointOfDeparture;

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
            var administrationForm = new AdministratorForm();
            administrationForm.Show();
        }

        private void AddTour_Click(object sender, EventArgs e)
        {
            Close();
            var createTour = new CreateTour();
            createTour.Show();
        }
    }
}