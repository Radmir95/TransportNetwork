using System;
using System.Windows.Forms;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.WebFormsApplication.Properties;

namespace TransportNetwork.WebFormsApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            var login = loginTb.Text;
            var password = passwordTb.Text;
            var userPermissionRepository = new UserPermissionRepository();
            var permission = userPermissionRepository.CheckUserLoginAndPassword(login, password);
            if (permission == null)
                err_label.Text = Resources.LoginForm_enterButton_Click_Error_Message;
            else
            {
                switch (permission)
                {
                    case "Administrator":
                        var administratiorForm = new AdministratorForm();
                        administratiorForm.Show();
                        break;
                    case "Cashier":
                        var cashierForm = new CashierForm();
                        cashierForm.Show();
                        break;

                    case "Hr":
                        var hrForm = new HrForm();
                        hrForm.Show();
                        break;
                }
            }
        }
    }
}
