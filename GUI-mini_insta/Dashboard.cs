using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_mini_insta
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "Add New Account",
                Font = new Font("Segoe UI", 14F, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Create input fields dynamically
            Label lblBankName = new Label
            {
                Text = "Bank Name:",
                Location = new Point(20, 70),
                Size = new Size(100, 30)
            };

            TextBox txtBankName = new TextBox
            {
                Location = new Point(150, 70),
                Size = new Size(200, 30)
            };

            Label lblCardNumber = new Label
            {
                Text = "Card Number:",
                Location = new Point(20, 120),
                Size = new Size(100, 30)
            };

            TextBox txtCardNumber = new TextBox
            {
                Location = new Point(150, 120),
                Size = new Size(200, 30)
            };

            Label lblInitialMoney = new Label
            {
                Text = "Initial Money:",
                Location = new Point(20, 170),
                Size = new Size(100, 30)
            };

            TextBox txtInitialMoney = new TextBox
            {
                Location = new Point(150, 170),
                Size = new Size(200, 30)
            };

            Button btnAdd = new Button
            {
                Text = "Add",
                Location = new Point(150, 230),
                Size = new Size(100, 40),
                BackColor = Color.LightBlue,
                //FlatStyle = FlatStyle.Flat
            };

            // Add a click event for the Add button
            btnAdd.Click += (s, args) =>
            {
                // Validate inputs and handle the logic for adding the account
                if (string.IsNullOrWhiteSpace(txtBankName.Text) ||
                    string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtInitialMoney.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal initialMoney;
                if (!decimal.TryParse(txtInitialMoney.Text, out initialMoney))
                {
                    MessageBox.Show("Invalid money amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Account Added:\nBank: {txtBankName.Text}\nCard Number: {txtCardNumber.Text}\nInitial Money: {initialMoney:C}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Add controls to the panel
            panelContent.Controls.Add(lblBankName);
            panelContent.Controls.Add(txtBankName);
            panelContent.Controls.Add(lblCardNumber);
            panelContent.Controls.Add(txtCardNumber);
            panelContent.Controls.Add(lblInitialMoney);
            panelContent.Controls.Add(txtInitialMoney);
            panelContent.Controls.Add(btnAdd);
        }


        private void BtnRemoveAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remove Account clicked!");
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Account clicked!");
        }

        private void BtnSendWithPhoneNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send with Phone Number clicked!");
        }

        private void BtnSendWithAccountNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send with Account Number clicked!");
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View My Profile clicked!");
        }

        private void BtnMyTransactions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Transactions clicked!");
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout clicked!");
        }

        private void BtnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
        }

        private void BtnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = SystemColors.Control;
            btnLogout.ForeColor = SystemColors.ControlText;
        }
    }
}
