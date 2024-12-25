using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_mini_insta
{
    public partial class Admin : Form
    {
        Users user = Users.getUsers();
        Manager manager = Manager.getMan();
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void suspend_Click(object sender, EventArgs e)
        {
            string selectedText = comboBox1.SelectedItem.ToString();
            manager.Execute(user.UsersWithEmail[selectedText]);

        }

        private void view_Click(object sender, EventArgs e)
        {
            string selectedText = comboBox1.SelectedItem.ToString();
            UserProfile up = new UserProfile(selectedText);
            up.Show();
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Admin_Load(object sender, EventArgs e)
        {

            foreach (string email in user.UsersWithEmail.Keys)
            {
                comboBox1.Items.Add(email);
            }
            foreach (var issues in manager.issues)
            {
                for (int i = 0; i < issues.Value.Count; i++)
                {
                    listBox1.Items.Add($"[{issues.Key}]: {issues.Value[i]}");
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout clicked!");
            Login login = new Login();

            // Show the LoginForm
            login.Show();

            // Close or hide the current RegisterForm
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}