using System;
using System.Windows.Forms;

namespace TransportNetwork.WebFormsApplication
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnBusDrivers_Click(object sender, EventArgs e)
        {

            var busDriversForm = new BusDriversForm();
            busDriversForm.Show();

        }
    }
}