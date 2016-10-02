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
            foreach (var waybill in waybills)
            {
                listOfWaybills.Items.Add(waybill.WaybillId);
            }
            

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
