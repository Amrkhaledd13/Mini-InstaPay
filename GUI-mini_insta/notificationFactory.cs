using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class notificationFactory
    {
        public static Notifications createnotifications(string type ,string message,string phone)
        {
           if (type.Equals("status"))
            {
                return new statusOfNotification(message, phone);
            }
           else if (type.Equals("low balance"))
            {
                return new lowbalanceNot(phone);
            }
           else if (type.Equals("offer"))
            {
                return new newOffersNot(message, phone);
            }

            throw new Exception("wrong type");
        }
    }
}
