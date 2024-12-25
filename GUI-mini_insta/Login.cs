using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_mini_insta
{

    public partial class Login : Form
    {
        private readonly ProxyUser _proxyUser;
        private TwoFactorAuthManager authManager;
        User loggedInUser;
        public Login()
        {
            InitializeComponent();
            _proxyUser = new ProxyUser();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            loggedInUser = _proxyUser.Login(email, password);  // Call your Login function

            if (loggedInUser != null)
            {
                if (loggedInUser.suspended)
                {
                    MessageBox.Show("You accont is suspended", "Error");
                    lblMessage.Text = "You accont is suspended";
                    return;
                }
                // OTP verification UI
                txtOtp.Visible = true;
                btnVerifyOtp.Visible = true;
                lblMessage.Text = "Enter OTP sent to your email.";
                lblMessage.Visible = true;
                authManager = new TwoFactorAuthManager();
                // Optionally, you can display or send the OTP here, e.g., via email
                string otp = authManager.GetOtp();
                lblMessage.Text = otp;
                Console.WriteLine($"OTP: {otp}"); // Just for debugging, remove in production
            }
            else
            {
                lblMessage.Text = "Invalid email or password.";
                lblMessage.Visible = true;
            }
        }

        private void btnVerifyOtp_Click(object sender, EventArgs e)
        {
            string enteredOtp = txtOtp.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            bool isOtpValid = authManager.VerifyOtp(enteredOtp);  // Use the VerifyOtp method

            if (isOtpValid)
            {
                if (email == "admin@gmail.com" && password == "admin12345")
                {
                    lblMessage.Text = "OTP verified successfully! You are logged in.";
                    lblMessage.Visible = true;

                    Admin adm = new Admin();

                    // Show the LoginForm
                    adm.Show();

                    // Close or hide the current RegisterForm
                    this.Hide();
                }
                else
                {
                    lblMessage.Text = "OTP verified successfully! You are logged in.";
                    lblMessage.Visible = true;
                    // Proceed with the logged-in user, e.g., show the dashboard
                    Dashboard dash = new Dashboard(loggedInUser);

                    // Show the LoginForm
                    dash.Show();

                    // Close or hide the current RegisterForm
                    this.Hide();
                }
            }
            else
            {
                lblMessage.Text = "Invalid OTP.";
                lblMessage.Visible = true;
            }
        }
        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            // Proceed with the logged-in user, e.g., show the dashboard
            Register register = new Register();

            // Show the LoginForm
            register.Show();

            // Close or hide the current RegisterForm
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}