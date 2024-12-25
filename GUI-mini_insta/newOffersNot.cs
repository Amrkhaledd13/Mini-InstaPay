using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class newOffersNot : Notifications
    {
        public newOffersNot(string s, string m) : base(s, m) { }

        public override void sendnotification()
        {
            Users u = Users.getUsers();
            foreach (var key in u.UsersWithPhone.Keys)
            {
                //Console.WriteLine($"Key: {key}");
                u.UsersWithPhone[key].mynotifictions.Add(message);
            }
            
        }
    }
}
