using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class BankAccounts
    {
        private string account_number,  Bank_Name, username, userphone, useremail , password;
        private int Amount;

        public  BankAccounts(string _accountnumber,int amount,string bankname) {
            account_number = _accountnumber;
            Amount = amount;
            Bank_Name = bankname;
        }  
        public string getaccountnumber()
        {
            return account_number;
        }
        public void recieveamout(int x)
        {
            Amount += x;
        } 

        public void setBankname(string x)
        {
            Bank_Name = x;
        }

        public void setpassword(string x)
        {
            password = x;
        }
        public string getphone()
        {
            return userphone;
        }
        public int getamount()
        {
            return Amount;
        }

        public string getbankname()
        {
            return Bank_Name;
        }

    }
}
