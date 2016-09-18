using System;
using System.Windows.Forms;

namespace TransportNetwork.WebFormsApplication
{
    public partial class WaybillsForm : Form
    {
        public WaybillsForm()
        {
            InitializeComponent();
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
