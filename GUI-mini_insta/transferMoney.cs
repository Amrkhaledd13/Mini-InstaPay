using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    internal class transferMoney
    {
       static private transferMoney ts;
        private transferMoney() { }

        public static transferMoney getts() {
            if (ts == null) ts = new transferMoney();
            return ts;
        }
        Users users = Users.getUsers();
        
        void sendwithphonenumber(User sender,string phonenumber ,int amount ,string bankname)
        {
           User reciever = users.UsersWithPhone[phonenumber];
           BankAccounts account =  reciever.getthedeafult();
           BankAccounts senderaccount =  sender.myaccounts.Find(a => a.getbankname() == bankname);
            sender.mytransactions.Add(new Transactions(sender.Email, reciever.Email, amount));
            reciever.mytransactions.Add(new Transactions(sender.Email, reciever.Email, amount));
            senderaccount.recieveamout(-amount);
           recieve(reciever,account,amount);
        }
        void sendwithaAccountnumber(User sender,string accountnumber,int amount,string bankname)
        {

            BankAccounts account = System_BankAccounts.bnkacounts[accountnumber];
            User user = users.UsersWithPhone[account.getphone()];
            BankAccounts senderaccount = sender.myaccounts.Find(a => a.getbankname() == bankname);
            sender.mytransactions.Add(new Transactions(sender.Email, user.Email, amount));
            user.mytransactions.Add(new Transactions(sender.Email, user.Email, amount));
            senderaccount.recieveamout(-amount);
            recieve(user,account,amount);
        }

        void recieve(User receiver,BankAccounts account,int amount) {
            System_BankAccounts.bnkacounts[account.getaccountnumber()].recieveamout(amount);
            var acc = receiver.myaccounts.Find(a => a.getaccountnumber() == account.getaccountnumber());
            acc.recieveamout(amount);
        }
    }
}
