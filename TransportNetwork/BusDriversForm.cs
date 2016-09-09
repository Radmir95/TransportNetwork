using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.WebFormsApplication
{
    public partial class BusDriversForm : Form
    {
        public BusDriversForm()
        {
            InitializeComponent();
        }

        private void BusDriversForm_Load(object sender, EventArgs e)
        {

            ICarrierCompanyRepository carrierCompany = new CarrierCompanyRepository();
            var busDrivers = carrierCompany.GetAllBusDrivers();
            foreach (var busDriver in busDrivers)
            {

                listOfBusDrivers.Items.Add(busDriver.BusDriverId);
            }

            if (busDrivers.Count <= 0) return;
            {
                var busDriver = busDrivers[0];
                nameTb.Text = busDriver.FirstName;
                surnameTb.Text = busDriver.SurName;
                middleTb.Text = busDriver.MiddleName;
                experienceTb.Text = busDriver.Experience.ToString();
                cityTb.Text = busDriver.City;
                streetTb.Text = busDriver.Street;
                houseTb.Text = busDriver.House.ToString();
                roomTb.Text = busDriver.Room.ToString();
                telephoneTb.Text = busDriver.Telephone;
                passportTb.Text = busDriver.Passport;
                companyTb.Text = busDriver.CarrierCompanyId.ToString();
            }
        }

        private void listOfBusDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            ICarrierCompanyRepository carrierCompany = new CarrierCompanyRepository();

            var name = nameTb.Text;
            var surname = surnameTb.Text;
            var middlename = middleTb.Text;
            var experience =Convert.ToInt32(experienceTb.Text);
            var city = cityTb.Text;
            var street = streetTb.Text;
            var house = Convert.ToInt32(houseTb.Text);
            var room = Convert.ToInt32(roomTb.Text);
            var telephone = telephoneTb.Text;
            var passport = passportTb.Text;
            var company = Convert.ToInt32(companyTb.Text);

            var busDriver = new BusDriver(name,surname,middlename,experience,city,street,house,room,telephone,passport,company);
            carrierCompany.AddBusDriver(busDriver);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {



        }
    }
}
