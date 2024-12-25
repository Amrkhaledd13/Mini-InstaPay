using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_mini_insta
{
    public partial class UserProfile : Form
    {
        string email;
        Users user = Users.getUsers();
        User x;
        public UserProfile(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            x = user.UsersWithEmail[email];
            label1.Text = x.Name;
            label2.Text = x.Phone;
            label3.Text = x.Address;
            comboBox1.Items.Add("Choose your bank account name");
            for (int i = 0; i < x.myaccounts.Count; i++)
            {
                comboBox1.Items.Add(x.myaccounts[i].getbankname());
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += (s, ev) =>
            {
                string selectedRole = comboBox1.SelectedItem.ToString();
                string amountText = " ";

                // Determine amount based on the selected role
                amountText += (x.myaccounts.Find(a => a.getbankname() == selectedRole)?.getamount() ?? 0).ToString();


                label9.Text = amountText;
            };
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = user.UsersWithEmail[email];
            // Get the selected account name from the ComboBox
            string selectedAccount = comboBox1.SelectedItem.ToString();

            // Check if the selection is valid and not the default option
            if (selectedAccount != "Choose your bank account name")
            {
                // Find the account matching the selected name
                var selectedAccountDetails = x.myaccounts.Find(a => a.getbankname() == selectedAccount);

                // Update the amount label
                if (selectedAccountDetails != null)
                {
                    label9.Text = "Amount: " + selectedAccountDetails.getamount().ToString("C2");
                }
                else
                {
                    label9.Text = "Amount: $0.00";
                }
            }
            else
            {
                // Reset the amount label if the default option is selected
                label9.Text = "Amount: $0.00";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
