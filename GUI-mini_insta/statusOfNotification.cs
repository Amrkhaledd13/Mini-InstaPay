using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_mini_insta
{
    public class statusOfNotification : Notifications
    {
        public statusOfNotification(string s,string m) : base(s,m) { }

        public void sendnotification() {
            Users u = Users.getUsers();
            u.UsersWithPhone[phone].mynotifictions.Add(message);
        }

    }
}
