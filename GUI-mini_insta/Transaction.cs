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
    public partial class Transaction : Form
    {
        Manager manager = Manager.getMan();
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            foreach (var ts in manager.transactions)
            {
                listBox1.Items.Add($" {ts.dateTime.ToString()} - {ts.senderEmail} - {ts.receiverEmail} - {ts.amount} ");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
