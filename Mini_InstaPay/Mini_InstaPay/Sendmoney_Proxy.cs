﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay
{
    internal class Sendmoney_Proxy
    {
        public static void sendwithphoneproxy(User sender,int amount,string bankname)
        {
            
            BankAccounts acc = sender.myaccounts.Find(a => a.getbankname() == bankname);
         
            if (acc != null) {
                if (acc.getamount() >= amount || sender.getlimit() >= amount)
                {
                    transferMoney ts = transferMoney.getts();
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
