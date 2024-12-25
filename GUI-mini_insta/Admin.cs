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

namespace GUI_mini_insta
{
    public partial class Admin : Form
    {
        Users user = Users.getUsers();
        User s = new User("3","adw","ali@gmail.com","010","adsf","12345678");
        User z = new User("3", "zs", "op@gmail.com", "123", "cxv", "12345678");
        
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
            Manager manager = new Manager();
            manager.Execute(user.UsersWithEmail[selectedText]);

        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void transaction_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            user.UsersWithEmail.Add(s.Email,s);
            user.UsersWithEmail.Add(z.Email ,z);
            foreach (string email in user.UsersWithEmail.Keys)
            {
                comboBox1.Items.Add(email);
            }
        }
    }
}