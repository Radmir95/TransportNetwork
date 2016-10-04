using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;
using TransportNetwork.WebFormsApplication.Helpers;

namespace TransportNetwork.WebFormsApplication
{
    public partial class CreateTour : Form
    {

        private BusRepository BusRepository { get; set; }

        public CreateTour()
        {
            BusRepository = new BusRepository();
            InitializeComponent();
            InitializeBusForm();
        }

        private void InitializeBusForm()
        {
            var busses = BusRepository.GetAllBusses();

            if (busses.Count == 0)
                return;

            foreach (var bus in busses)
            {
                numberPlateTb.Items.Add(bus.NumberPlate);
            }
            numberPlateTb.Text = busses[0].NumberPlate;
            markTb.Text = busses[0].Brand;
            modelTb.Text = busses[0].Model;
            seatsTb.Text = busses[0].NumberOfSeats.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
            var waybillsForm = new WaybillsForm();
            waybillsForm.Show();
        }

        private void Ready_Click(object sender, EventArgs e)
        {

            var busses = BusRepository.GetAllBusses();
            var bus = busses[numberPlateTb.SelectedIndex];

            var tour = new Tour(Convert.ToDateTime(timeOfDepartureTb.Text), Convert.ToDateTime(timeOfArrivalTb.Text), Convert.ToInt32(distanceTb.Text), pointOfDepartureList.Text, pointOfArrivalList.Text);

            var tourRepository = new TourRepository();
            tourRepository.AddTour(tour);
            var tourId = tourRepository.GetTourId(tour);

            tour.SetTourId(tourId);

            var waybill = new Waybill(bus, tour);
            var waybillRepository = new WaybillRepository();
            for (var count = 0; count < bus.NumberOfSeats; count++)
                waybillRepository.AddWaybill(waybill);

            Close();
            var waybillForm = new WaybillsForm();
            waybillForm.Show();

        }

        private void numberPlateTb_SelectedIndexChanged(object sender, EventArgs e)
        {

            var busses = BusRepository.GetAllBusses();
            FillBusForm(busses[numberPlateTb.SelectedIndex]);

        }

        private void FillBusForm(Bus bus)
        {

            markTb.Text = bus.Brand;
            modelTb.Text = bus.Model;
            seatsTb.Text = bus.NumberOfSeats.ToString();

        }

        private void pointOfArrivalList_SelectedIndexChanged(object sender, EventArgs e)
        {

            var pointOfArrival = pointOfArrivalList.Text;
            var pointOfDeparture = pointOfDepartureList.Text;

            distanceTb.Text = DistanceBetweenCities.GetDistance(pointOfDeparture, pointOfArrival).ToString();

        }
    }
}
