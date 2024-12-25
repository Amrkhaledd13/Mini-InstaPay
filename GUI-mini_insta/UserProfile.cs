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
            x=user.UsersWithEmail[email];
            label1.Text = x.Name;
            label2.Text = x.Phone;
            label3.Text = x.Address;

        }
    }
}
