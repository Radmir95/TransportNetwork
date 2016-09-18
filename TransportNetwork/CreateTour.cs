using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.WebFormsApplication
{
    public partial class CreateTour : Form
    {

        private BusRepository BusRepository { get; set; }

        public CreateTour()
        {
            BusRepository = new BusRepository();
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            var busses = BusRepository.GetAllBusses();
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
            Bus bus = null;
            foreach (var busLoop in busses)
            {
                if (busLoop.NumberPlate == numberPlateTb.Text)
                {
                    bus = busLoop;
                }
            }

            var tour = new Tour(Convert.ToDateTime(timeOfDepartureTb.Text), Convert.ToDateTime(timeOfArrivalTb.Text), Convert.ToInt32(distanceTb.Text), pointOfDepartureTb.Text, pointOfArrivalTb.Text);
            var waybill = new Waybill(bus, tour);
            var waybillRepository = new WaybillRepository();
            waybillRepository.AddWaybill(waybill);

            Close();
            var waybillForm = new WaybillsForm();
            waybillForm.Show();

        }
    }
}
