using System;
using System.Windows.Forms;
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
