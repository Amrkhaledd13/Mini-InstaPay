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
            MessageBox.Show("Add Account clicked!");
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
