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
                BankAccounts acc = new BankAccounts(txtCardNumber.Text, int.Parse(txtInitialMoney.Text), txtBankName.Text,loggedInUser.Phone);
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
            cmbCards.Items.Add("Choose your bank card number");
            for (int i = 0; i < loggedInUser.myaccounts.Count; i++)
            {
                cmbCards.Items.Add(loggedInUser.myaccounts[i].getaccountnumber());
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
            cmbCards.Items.Add("Choose your bank card number");
            for (int i = 0; i < loggedInUser.myaccounts.Count; i++)
            {
                cmbCards.Items.Add(loggedInUser.myaccounts[i].getaccountnumber());
            }
            /*cmbCards.Items.Add("1234-5678-9012-3456");
            cmbCards.Items.Add("9876-5432-1098-7654");
            cmbCards.Items.Add("4567-8901-2345-6789");*/
            cmbCards.SelectedIndex = 0; // Select the first item by default

            // Label for account number
            Label lblAccountNumber = new Label
            {
                Text = "Bank Name:",
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
                txtAccountNumber.Text = loggedInUser.myaccounts
    .Find(a => a.getaccountnumber() == cmbCards.SelectedItem.ToString())
    ?.getbankname() ?? "Bank Name";
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
                loggedInUser.updateaccount(cmbCards.SelectedItem.ToString(), newCard);
                MessageBox.Show($"Account updated from {oldCard} to {newCard}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, update the combo box item
                /*int selectedIndex = cmbCards.SelectedIndex;
                cmbCards.Items[selectedIndex] = newCard;*/
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
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "Send Money with Phone Number",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(400, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Label for ComboBox
            Label lblBankName = new Label
            {
                Text = "Select Bank:",
                Location = new Point(20, 70),
                Size = new Size(120, 30)
            };

            // ComboBox for bank names
            ComboBox cmbBanks = new ComboBox
            {
                Location = new Point(150, 70),
                Size = new Size(200, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add sample banks (replace with actual data)
            cmbBanks.Items.Add("Choose Your Phone connected with bank account");
            for (int i = 0; i < loggedInUser.myaccounts.Count; i++)
            {
                cmbBanks.Items.Add(loggedInUser.myaccounts[i].getbankname());
            }
            cmbBanks.SelectedIndex = 0; // Select the first item by default

            // Label for amount
            Label lblAmount = new Label
            {
                Text = "Amount to Send:",
                Location = new Point(20, 120),
                Size = new Size(120, 30)
            };

            // TextBox for amount
            TextBox txtAmount = new TextBox
            {
                Location = new Point(150, 120),
                Size = new Size(200, 30)
            };

            // Label for phone number
            Label lblPhoneNumber = new Label
            {
                Text = "Recipient's Phone:",
                Location = new Point(20, 170),
                Size = new Size(120, 30)
            };

            // TextBox for phone number
            TextBox txtPhoneNumber = new TextBox
            {
                Location = new Point(150, 170),
                Size = new Size(200, 30)
            };

            // Send Button
            Button btnSend = new Button
            {
                Text = "Send",
                Location = new Point(150, 220),
                Size = new Size(100, 40),
                BackColor = Color.LightSkyBlue,
                //FlatStyle = FlatStyle.Flat
            };

            // Add click event for the Send button
            btnSend.Click += (s, args) =>
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txtPhoneNumber.Text, out long phoneNumber) || txtPhoneNumber.Text.Length < 10)
                {
                    MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handle sending logic here
                string bankName = cmbBanks.SelectedItem.ToString();
                Sendmoney_Proxy.sendwithphoneproxy(loggedInUser, txtPhoneNumber.Text, int.Parse(txtAmount.Text), bankName, false);
                MessageBox.Show($"Money sent successfully!\n\nBank: {bankName}\nAmount: {amount}\nPhone: {txtPhoneNumber.Text}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show((loggedInUser.myaccounts.Find(a => a.getbankname() == bankName)?.getamount() ?? 0).ToString(), "Your new ammount of money");

            };

            // Add controls to the panel
            panelContent.Controls.Add(lblBankName);
            panelContent.Controls.Add(cmbBanks);
            panelContent.Controls.Add(lblAmount);
            panelContent.Controls.Add(txtAmount);
            panelContent.Controls.Add(lblPhoneNumber);
            panelContent.Controls.Add(txtPhoneNumber);
            panelContent.Controls.Add(btnSend);
        }


        private void BtnSendWithAccountNumber_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "Send Money with Account name",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(400, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Label for ComboBox
            Label lblBankName = new Label
            {
                Text = "Select Bank:",
                Location = new Point(20, 70),
                Size = new Size(120, 30)
            };

            // ComboBox for bank names
            ComboBox cmbBanks = new ComboBox
            {
                Location = new Point(150, 70),
                Size = new Size(200, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add sample banks (replace with actual data)
            cmbBanks.Items.Add("Choose your bank account name");
            for (int i = 0; i < loggedInUser.myaccounts.Count; i++)
            {
                cmbBanks.Items.Add(loggedInUser.myaccounts[i].getbankname());
            }
            cmbBanks.SelectedIndex = 0; // Select the first item by default

            // Label for amount
            Label lblAmount = new Label
            {
                Text = "Amount to Send:",
                Location = new Point(20, 120),
                Size = new Size(120, 30)
            };

            // TextBox for amount
            TextBox txtAmount = new TextBox
            {
                Location = new Point(150, 120),
                Size = new Size(200, 30)
            };

            Label lblAccount = new Label
            {
                Text = "Recipient's Account:",
                Location = new Point(20, 170),
                Size = new Size(120, 30)
            };

            TextBox txtAccount = new TextBox
            {
                Location = new Point(150, 170),
                Size = new Size(200, 30)
            };

            // Send Button
            Button btnSend = new Button
            {
                Text = "Send",
                Location = new Point(150, 220),
                Size = new Size(100, 40),
                BackColor = Color.LightSkyBlue,
                //FlatStyle = FlatStyle.Flat
            };

            // Add click event for the Send button
            btnSend.Click += (s, args) =>
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(txtAccount.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handle sending logic here
                string bankName = cmbBanks.SelectedItem.ToString();
                Sendmoney_Proxy.sendwithphoneproxy(loggedInUser, txtAccount.Text, int.Parse(txtAmount.Text), bankName, true);
                MessageBox.Show($"Money sent successfully!\n\nBank: {bankName}\nAmount: {amount}\nAccount: {txtAccount.Text}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show((loggedInUser.myaccounts.Find(a => a.getbankname() == bankName)?.getamount() ?? 0).ToString(), "Your new ammount of money");
            };

            // Add controls to the panel
            panelContent.Controls.Add(lblBankName);
            panelContent.Controls.Add(cmbBanks);
            panelContent.Controls.Add(lblAmount);
            panelContent.Controls.Add(txtAmount);
            panelContent.Controls.Add(lblAccount);
            panelContent.Controls.Add(txtAccount);
            panelContent.Controls.Add(btnSend);
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "My Profile",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(400, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Simulated user data (replace these with actual user data from your source)
            string userName = loggedInUser.Name;
            string userEmail = loggedInUser.Email;
            string userPhone = loggedInUser.Phone;
            string userAddress = loggedInUser.Address;

            // Display user information with TextBoxes
            int textBoxY = 70;
            string[] labels = { "Name:", "Email:", "Phone:", "Address:" };
            string[] values = { userName, userEmail, userPhone, userAddress };
            TextBox[] textBoxes = new TextBox[labels.Length];

            for (int i = 0; i < labels.Length; i++)
            {
                Label lblField = new Label
                {
                    Text = labels[i],
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(20, textBoxY),
                    Size = new Size(120, 30)
                };
                panelContent.Controls.Add(lblField);

                TextBox txtField = new TextBox
                {
                    Text = values[i],
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(150, textBoxY),
                    Size = new Size(300, 30),
                    ReadOnly = (i == 1 || i == 2) // Set ReadOnly to true for Email and Phone fields
                };
                textBoxes[i] = txtField; // Store text boxes for future updates
                panelContent.Controls.Add(txtField);

                textBoxY += 40;
            }

            // Add a ComboBox and a Label
            Label lblComboBox = new Label
            {
                Text = "Select Role:",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(20, textBoxY),
                Size = new Size(120, 30)
            };
            panelContent.Controls.Add(lblComboBox);

            ComboBox comboBox = new ComboBox
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                Location = new Point(150, textBoxY),
                Size = new Size(300, 30),
                DropDownStyle = ComboBoxStyle.DropDownList // Prevent user from typing custom values
            };
            comboBox.Items.Add("Choose your bank account name");
            for (int i = 0; i < loggedInUser.myaccounts.Count; i++)
            {
                comboBox.Items.Add(loggedInUser.myaccounts[i].getbankname());
            }
            comboBox.SelectedIndex = 0; // Set a default selection
            panelContent.Controls.Add(comboBox);

            textBoxY += 50; // Adjust for next control placement

            // Add a label to display the amount
            Label lblAmount = new Label
            {
                Text = "Amount: $0.00",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(20, textBoxY),
                Size = new Size(400, 30)
            };
            panelContent.Controls.Add(lblAmount);

            // Update the amount based on the ComboBox selection
            comboBox.SelectedIndexChanged += (s, ev) =>
            {
                string selectedRole = comboBox.SelectedItem.ToString();
                string amountText="Amount: ";
               
                // Determine amount based on the selected role
                        amountText += (loggedInUser.myaccounts.Find(a => a.getbankname() == selectedRole)?.getamount() ?? 0).ToString();
             

                lblAmount.Text = amountText;
            };

            textBoxY += 40; // Adjust for next control placement

            // Add an Update button
            Button btnUpdate = new Button
            {
                Text = "Update",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Location = new Point(150, textBoxY + 20),
                Size = new Size(100, 40),
            };
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Click += (s, ev) =>
            {
                // Update logic
                string updatedName = textBoxes[0].Text;
                string updatedAddress = textBoxes[3].Text;
                string selectedRole = comboBox.SelectedItem.ToString();
                loggedInUser.UpdateProfile(userEmail, updatedName, updatedAddress, userPhone);
                MessageBox.Show($"Updated Info:\nName: {updatedName}\nEmail: {userEmail}\nPhone: {userPhone}\nAddress: {updatedAddress}\nRole: {selectedRole}",
                    "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            panelContent.Controls.Add(btnUpdate);

            // Add a separator line
            Label lblSeparator = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                Location = new Point(20, textBoxY + 80),
                Size = new Size(400, 2)
            };
            panelContent.Controls.Add(lblSeparator);

            // Add a Notifications Section
            Label lblNotifications = new Label
            {
                Text = "Notifications:",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, textBoxY + 100),
                Size = new Size(200, 30)
            };
            panelContent.Controls.Add(lblNotifications);

            // Display notifications
            int notificationY = textBoxY + 140;
            foreach (string notification in loggedInUser.mynotifictions)
            {
                Label lblNotification = new Label
                {
                    Text = "- " + notification,
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(20, notificationY),
                    Size = new Size(400, 25)
                };
                panelContent.Controls.Add(lblNotification);

                notificationY += 30;
            }
        }



        private void BtnMyTransactions_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "My Transactions",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(400, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Simulated transactions data (replace with real data from the database)
            var transactions = new[]
            {
        new { Date = "2024-12-01", SenderEmail = "john.doe@example.com", Amount = "$500", ReceiverEmail = "jane.smith@example.com" },
        new { Date = "2024-12-05", SenderEmail = "john.doe@example.com", Amount = "$200", ReceiverEmail = "bob.brown@example.com" },
        new { Date = "2024-12-10", SenderEmail = "john.doe@example.com", Amount = "$300", ReceiverEmail = "alice.white@example.com" }
    };

            // Add column headers
            int startX = 20, startY = 70;
            string[] headers = { "Date", "Sender Email", "Amount", "Receiver Email" };
            int[] columnWidths = { 100, 200, 100, 200 };

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = new Label
                {
                    Text = headers[i],
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(startX, startY),
                    Size = new Size(columnWidths[i], 30),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panelContent.Controls.Add(lblHeader);

                startX += columnWidths[i] + 10; // Adjust position for the next header
            }

            // Reset startX and increase startY for data rows
            startX = 20;
            startY += 40;

            // Display transaction rows
            foreach (var transaction in loggedInUser.mytransactions)
            {
                string[] rowValues = { transaction.dateTime.ToString(), transaction.senderEmail, transaction.amount.ToString(), transaction.receiverEmail };

                for (int i = 0; i < rowValues.Length; i++)
                {
                    Label lblData = new Label
                    {
                        Text = rowValues[i],
                        Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                        ForeColor = Color.Black,
                        Location = new Point(startX, startY),
                        Size = new Size(columnWidths[i], 30),
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    panelContent.Controls.Add(lblData);

                    startX += columnWidths[i] + 10; // Adjust position for the next column
                }

                // Reset startX and move to the next row
                startX = 20;
                startY += 40;
            }
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out Successfully!");
            Login dash = new Login();

            // Show the LoginForm
            dash.Show();

            // Close or hide the current RegisterForm
            this.Hide();
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

        private void customer_Service_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelContent.Controls.Clear();

            // Add a title to the panel
            Label lblTitle = new Label
            {
                Text = "Customer Service",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };
            panelContent.Controls.Add(lblTitle);

            // Label for the TextBox
            Label lblDescription = new Label
            {
                Text = "Describe Your Issue:",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(20, 70),
                Size = new Size(200, 25)
            };
            panelContent.Controls.Add(lblDescription);

            // TextBox for user's problem
            TextBox txtProblem = new TextBox
            {
                Location = new Point(20, 100),
                Size = new Size(panelContent.Width - 300, 200), // Adjust size to fit panel width
                Multiline = true,
                ScrollBars = ScrollBars.Vertical, // Enable vertical scrolling
                Font = new Font("Segoe UI", 10F, FontStyle.Regular)
            };
            panelContent.Controls.Add(txtProblem);

            // Send Button
            Button btnSend = new Button
            {
                Text = "Send",
                Location = new Point(20, 320),
                Size = new Size(100, 40),
                BackColor = Color.LightSkyBlue,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                //FlatStyle = FlatStyle.Flat
            };
            Manager admin = Manager.getMan();
            // Add click event for the Send button
            btnSend.Click += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtProblem.Text))
                {
                    MessageBox.Show("Please describe your issue before sending.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handle sending the problem to the admin
                string userProblem = txtProblem.Text;
                MessageBox.Show("Your issue has been sent successfully.\n\nIssue Details:\n" + userProblem,
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!admin.issues.ContainsKey(loggedInUser.Email))
                {
                    admin.issues.Add(loggedInUser.Email, new List<string>());
                }
                admin.issues[loggedInUser.Email].Add(userProblem);
                // Optionally clear the TextBox after sending
                txtProblem.Clear();
            };

            panelContent.Controls.Add(btnSend);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
