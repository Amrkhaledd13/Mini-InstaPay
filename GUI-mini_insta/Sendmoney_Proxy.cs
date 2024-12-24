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
        public static void sendwithphoneproxy(User sender, string phone ,int amount,string bankname)
        {
            
            BankAccounts acc = sender.myaccounts.Find(a => a.getbankname() == bankname);
         
            if (acc != null) {
                if (acc.getamount() >= amount && sender.getlimit() >= amount)
                {
                    transferMoney ts = transferMoney.getts();
                    ts.sendwithphonenumber(sender, phone , amount, bankname);
                    return; 
                }
                else
                {
                    if (acc.getamount() < amount)
                    {
                        Console.WriteLine("you don't have enough amount");
                    }
                    else
                    {
                        Console.WriteLine("you have reach the daily limit");
                    }
                    
                }
            }
            else {
                Console.WriteLine("invalid bank name");
            }

        }

        
    }
}
