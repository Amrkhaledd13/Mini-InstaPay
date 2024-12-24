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
        User loggedInUser;
        public Dashboard(User l)
        {
            InitializeComponent();
            loggedInUser = l;
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
                BankAccounts acc = new BankAccounts(txtCardNumber.Text, int.Parse(txtInitialMoney.Text), txtBankName.Text);
                loggedInUser.Addaccount(acc);
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
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "Remove Account",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Label for ComboBox
            Label lblSelectCard = new Label
            {
                Text = "Select Card:",
                Location = new Point(20, 70),
                Size = new Size(100, 30)
            };

            // ComboBox for user cards
            ComboBox cmbCards = new ComboBox
            {
                Location = new Point(150, 70),
                Size = new Size(200, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add sample cards (you should replace this with actual data)
                cmbCards.Items.Add("amr");
            for (int i = 0;i < loggedInUser.myaccounts.Count; i++)
            {
                string s = loggedInUser.myaccounts[i].getaccountnumber();
                cmbCards.Items.Add(s);
            }
            
            cmbCards.SelectedIndex = 0; // Select the first item by default

            // Remove Button
            Button btnRemove = new Button
            {
                Text = "Remove",
                Location = new Point(150, 120),
                Size = new Size(100, 40),
                BackColor = Color.Red,
                //FlatStyle = FlatStyle.Flat
                ForeColor = Color.White,
            };

            // Add click event for the Remove button
            btnRemove.Click += (s, args) =>
            {
                if (cmbCards.SelectedItem == null)
                {
                    MessageBox.Show("Please select a card to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handle card removal logic here
                string selectedCard = cmbCards.SelectedItem.ToString();
                loggedInUser.Removeaccount(selectedCard);
                MessageBox.Show($"Card {selectedCard} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, remove the card from the ComboBox
                cmbCards.Items.Remove(selectedCard);
                if (cmbCards.Items.Count > 0)
                {
                    cmbCards.SelectedIndex = 0; // Set the first item as selected
                }
            };

            // Add controls to the panel
            panelContent.Controls.Add(lblSelectCard);
            panelContent.Controls.Add(cmbCards);
            panelContent.Controls.Add(btnRemove);
        }


        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "Update Account",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Label for ComboBox
            Label lblSelectCard = new Label
            {
                Text = "Select Card:",
                Location = new Point(20, 70),
                Size = new Size(100, 30)
            };

            // ComboBox for user cards
            ComboBox cmbCards = new ComboBox
            {
                Location = new Point(150, 70),
                Size = new Size(200, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add sample cards (replace with actual data)
            cmbCards.Items.Add("1234-5678-9012-3456");
            cmbCards.Items.Add("9876-5432-1098-7654");
            cmbCards.Items.Add("4567-8901-2345-6789");
            cmbCards.SelectedIndex = 0; // Select the first item by default

            // Label for account number
            Label lblAccountNumber = new Label
            {
                Text = "Card Number:",
                Location = new Point(20, 120),
                Size = new Size(120, 30)
            };

            // TextBox for account number (editable)
            TextBox txtAccountNumber = new TextBox
            {
                Location = new Point(150, 120),
                Size = new Size(200, 30),
                Text = cmbCards.SelectedItem.ToString() // Set initial text from the selected card
            };

            // Update TextBox placeholder on card selection change
            cmbCards.SelectedIndexChanged += (s, args) =>
            {
                txtAccountNumber.Text = cmbCards.SelectedItem.ToString();
            };

            // Update Button
            Button btnUpdate = new Button
            {
                Text = "Update",
                Location = new Point(150, 170),
                Size = new Size(100, 40),
                BackColor = Color.LightSkyBlue,
                //FlatStyle = FlatStyle.Flat
            };

            // Add click event for the Update button
            btnUpdate.Click += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
                {
                    MessageBox.Show("Account number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handle account update logic here
                string oldCard = cmbCards.SelectedItem.ToString();
                string newCard = txtAccountNumber.Text;
                MessageBox.Show($"Account updated from {oldCard} to {newCard}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, update the combo box item
                int selectedIndex = cmbCards.SelectedIndex;
                cmbCards.Items[selectedIndex] = newCard;
            };

            // Add controls to the panel
            panelContent.Controls.Add(lblSelectCard);
            panelContent.Controls.Add(cmbCards);
            panelContent.Controls.Add(lblAccountNumber);
            panelContent.Controls.Add(txtAccountNumber);
            panelContent.Controls.Add(btnUpdate);
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
