using System;
using System.Windows.Forms;

namespace TransportNetwork.WebFormsApplication
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void waybills_Click(object sender, EventArgs e)
        {
            Close();
            var form = new WaybillsForm();
            form.Show();
        }

        private void busses_Click(object sender, EventArgs e)
        {

            Close();
            var busses = new BussesForm();
            busses.Show();

        }

        private void Unlogin_Click(object sender, EventArgs e)
        {

            Close();
            var loginForm = new LoginForm();
            loginForm.Show();

        }

      
    }
}
