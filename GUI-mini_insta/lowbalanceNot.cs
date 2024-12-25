using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class lowbalanceNot : Notifications
    {
        public lowbalanceNot(string s) : base(s) { }

        public override void sendnotification()
        {
            Users u = Users.getUsers();
            u.UsersWithPhone[phone].mynotifictions.Add("low amount of money, please charge your balance");
        }
    }
}
