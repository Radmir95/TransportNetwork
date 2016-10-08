using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;
using TransportNetwork.WebFormsApplication.Helpers;

namespace TransportNetwork.WebFormsApplication
{
    public partial class TourForm : Form
    {
        public TourForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {

            IWaybillRepository waybillRepository = new WaybillRepository();
            var waybills = waybillRepository.GetAllWaybills();

            if (waybills.Count == 0) return;

            var firstTour = waybills.First().Tour;

            var listOfDifferentTours = new List<Tour>();
            listOfDifferentTours.Add(firstTour);

            var prevTour = firstTour;

            foreach (var waybill in waybills)
            {
                if (waybill.Tour == prevTour) continue;
                listOfDifferentTours.Add(waybill.Tour);
                prevTour = waybill.Tour;
            }

            foreach (var tour in listOfDifferentTours)
            {
                listOfTours.Items.Add(tour.TourId);
            }

            timeOfDepartureTb.Text = firstTour.TimeOfDeparture.Value.ToLongDateString();
            timeOfArrivalTb.Text = firstTour.TimeOfArrival.Value.ToLongDateString();
            distanceTb.Text = firstTour.Distance.ToString();
            pointOfArrivalTb.Text = firstTour.PointOfArrival;
            pointOfDepartureTb.Text = firstTour.PointOfDeparture;

            var numberOfSeats = waybills[0].Bus.NumberOfSeats;
            var numberOfSelledSeats = 0;

            foreach (var waybill in waybills)
            {
                if (waybill.Tour == firstTour && waybill.Ticket != null)
                {
                    numberOfSelledSeats += 1;
                }
            }
            freeSeatsTb.Text = (numberOfSeats - numberOfSelledSeats) + @"/" + numberOfSeats;


        }

        private void SellSeat_Click(object sender, EventArgs e)
        {

            var tourId = listOfTours.SelectedIndex + 1;
            
            var repository = new TourRepository();
            var tour = repository.GetTourById(tourId);

            var waybillRepository = new WaybillRepository();
            var waybills = waybillRepository.GetAllWaybills();

            Waybill waybill = null;

            foreach (var wayLoop in waybills)
            {

                if (wayLoop.Tour == tour)
                    waybill = wayLoop;
            }

            TourHelper.Waybill = waybill;
            Close();
            var passengerForm = new PassengerForm();
            passengerForm.Show();

        }
    }
}
