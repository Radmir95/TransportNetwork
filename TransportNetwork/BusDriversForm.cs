using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

                comboBox1.Items.Add(busDriver.BusDriverId);
            }
            

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
