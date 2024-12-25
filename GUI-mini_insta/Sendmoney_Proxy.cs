using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    internal class Sendmoney_Proxy
    {
        public static void sendwithphoneproxy(User sender, string phone_accnum ,int amount,string bankname,bool type)
        {
            
            BankAccounts acc = sender.myaccounts.Find(a => a.getbankname() == bankname);
         
            if (acc != null) {
                if (acc.getamount() >= amount && sender.getlimit() >= amount)
                {
                    transferMoney ts = transferMoney.getts();
                    if (!type)
                    ts.sendwithphonenumber(sender, phone_accnum , amount, bankname);
                    else
                    ts.sendwithaAccountnumber(sender, phone_accnum , amount, bankname);

                    return; 
                }
                else
                {
                    if (acc.getamount() < amount)
                    {
                        MessageBox.Show("you don't have enough amount","Low amount of money");
                        Notifications notification = notificationFactory.createnotifications("low balance", $" ", sender.Phone);
                        notification.sendnotification();
                    }
                    else
                    {
                        MessageBox.Show("you have reach the daily limit","Limit reached");

                    }
                    
                }
            }
            else {
                Console.WriteLine("invalid bank name");
            }

        }

       


    }
}
