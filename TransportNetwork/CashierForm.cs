using System;
using System.Windows.Forms;

namespace TransportNetwork.WebFormsApplication
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            Close();
            var loginForm = new LoginForm();
            loginForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
            var tourForm = new TourForm();
            tourForm.Show();

        }

    }
}
