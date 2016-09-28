using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;

namespace TransportNetwork.WebFormsApplication
{
    public partial class PassengerForm : Form
    {

        public PassengerRepository PassengerRepository { get; set; }

        public PassengerForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Close();
            var cashierForm = new CashierForm();
            cashierForm.Show();

        }

        private void update_Click(object sender, EventArgs e)
        {



        }

        private void add_Click(object sender, EventArgs e)
        {



        }

        private void delete_Click(object sender, EventArgs e)
        {



        }
    }
}
