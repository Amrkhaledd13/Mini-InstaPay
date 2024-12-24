using Microsoft.VisualBasic.Logging;
using Mini_InstaPay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_mini_insta
{
    public partial class Register : Form
    {
        private readonly ProxyUser _proxyUser;

        public Register()
        {
            InitializeComponent();
            _proxyUser = new ProxyUser();  // Initialize ProxyUser instance
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get input values from the text boxes
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();

            try
            {
                // Call the Register method from ProxyUser
                _proxyUser.Register(name, email, password, address, phone);

                // Display success message
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Registration successful!";
                lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                // Display error message
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
                lblMessage.Visible = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            Login loginForm = new Login();

            // Show the LoginForm
            loginForm.Show();

            // Close or hide the current RegisterForm
            this.Hide();
        }
    }
}
