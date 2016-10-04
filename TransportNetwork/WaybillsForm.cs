using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.WebFormsApplication
{
    public partial class WaybillsForm : Form
    {

        private WaybillRepository _waybillRepository;

        public WaybillsForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {

            _waybillRepository = new WaybillRepository();
            var waybills = _waybillRepository.GetAllWaybills();

            if (waybills.Count == 0) return;

            var distinctWaybills = GetListOfDifferentWaybills(waybills);

            foreach (var waybillInLoop in distinctWaybills)
            {
                listOfWaybills.Items.Add(waybillInLoop);
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

        private List<int> GetListOfDifferentWaybills(IReadOnlyList<Waybill> waybills)
        {
            if (waybills.Count == 0) return null;

            var prevTour = waybills[0].Tour.TourId;

            var waybillId = new List<int>();

            foreach (var waybill in waybills)
            {

                if (waybill.Tour.TourId == prevTour) continue;
                prevTour = waybill.Tour.TourId;
                waybillId.Add(waybill.WaybillId);

            }
            return waybillId;

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

        private void listOfWaybills_SelectedIndexChanged(object sender, EventArgs e)
        {

            var waybills = _waybillRepository.GetAllWaybills();
            var waybill = waybills[listOfWaybills.SelectedIndex];
            //TODO

        }
    }
}