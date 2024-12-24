using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PasswordHash { get; set; }

        private int limit;

        public List<BankAccounts> myaccounts = new List<BankAccounts>();
        public List<Transactions> mytransactions = new List<Transactions>();

        public User(string _id, string _name, string _email, string _phone, string _address, string _password)
        {
            Id = _id;
            Name = _name;
            Email = _email;
            Phone = _phone;
            Address = _address;
            PasswordHash = _password;
            limit = 5000; // initial value of limit
        }

        public void Addaccount(BankAccounts account)
        {
            if (account == null || account.getaccountnumber == null) throw new ArgumentNullException();
            if (myaccounts.Exists(a => a.getaccountnumber() == account.getaccountnumber()))
            {
                Console.WriteLine("the account already linked");
                return;
            }
            myaccounts.Add(account);
            System_BankAccounts.bnkacounts[account.getaccountnumber()] = account;
            System_BankAccounts.Numberofaccounts++;
        }


        public void Removeaccount(string accountnum)
        {
            if (myaccounts.Exists(a => a.getaccountnumber() == accountnum))
            {

            }
            else
            {
                var account = myaccounts.Find(a => a.getaccountnumber() == accountnum);
                myaccounts.Remove(account);
                System_BankAccounts.Numberofaccounts++;
                System_BankAccounts.bnkacounts.Remove(account.getaccountnumber());

                Console.WriteLine("does not Exist");
            }
        }

        public void updateaccount(string accountnum, string newbankname, string newpassword)
        {
            var account = myaccounts.Find(a => a.getaccountnumber() == accountnum);
            if (account != null)
            {
                account.setpassword(newpassword);
                account.setBankname(newbankname);
            }
            else
            {
                Console.WriteLine("does not Exist");
            }

        }

        public BankAccounts getthedeafult()
        {
            return myaccounts.First();
        }

        public void getallaccounts()
        {
            foreach (var i in myaccounts)
            {
                Console.WriteLine($"number : {i.getaccountnumber()} :: {i.getamount()} :: {System_BankAccounts.bnkacounts[i.getaccountnumber()].getamount()} ");
            }
        }


        public void setlimit(int x)
        {
            limit = x;
        }

        public int getlimit()
        {
            return limit;
        }






    }
    
}
