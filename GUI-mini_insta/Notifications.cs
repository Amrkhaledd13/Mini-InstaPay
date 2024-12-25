using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class Notifications
    {
        public string  message,phone;
        public Notifications() { }
        public Notifications(string m,string s)
        {
            message = m;
            phone = s;
        }
        public Notifications(string s)
        {
            phone = s;
        }
        public void sendnotification() { }

    }
}
