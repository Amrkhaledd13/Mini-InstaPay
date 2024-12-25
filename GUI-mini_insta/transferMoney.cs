using Microsoft.VisualBasic.ApplicationServices;
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
         Manager ms = Manager.getMan();
        private transferMoney() { }

        public static transferMoney getts() {
            if (ts == null) ts = new transferMoney();
            return ts;
        }
        Users users = Users.getUsers();

        public void sendwithphonenumber(User sender, string phonenumber, int amount, string bankname)
        {
            EncryptionManager encryptionManager = new EncryptionManager();
            string encryptedAmount = encryptionManager.Encrypt(amount.ToString());
            string encryptedBankName = encryptionManager.Encrypt(bankname);

            User reciever = users.UsersWithPhone[phonenumber];
            MessageBox.Show(phonenumber, "transfer");
            BankAccounts account = reciever.getthedeafult();
            BankAccounts senderaccount = sender.myaccounts.Find(a => a.getbankname() == bankname);
            sender.mytransactions.Add(new Transactions(sender.Email, reciever.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            ms.transactions.Add(new Transactions(sender.Email, reciever.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            reciever.mytransactions.Add(new Transactions(sender.Email, reciever.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            senderaccount.recieveamout(-int.Parse(encryptionManager.Decrypt(encryptedAmount)));
            recieve(reciever, account, int.Parse(encryptionManager.Decrypt(encryptedAmount)), sender.Phone);
            Notifications notifications = notificationFactory.createnotifications("status", $"{amount} pounds were transferred to {phonenumber}", sender.Phone);
            notifications.sendnotification();
            if (senderaccount.getamount() <= 500)
            {
                Notifications notification = notificationFactory.createnotifications("low balance", $" ", sender.Phone);
                notification.sendnotification();
            }
        }
        public void sendwithaAccountnumber(User sender,string accountnumber,int amount,string bankname)
        {
            EncryptionManager encryptionManager = new EncryptionManager();
            string encryptedAmount = encryptionManager.Encrypt(amount.ToString());
            string encryptedBankName = encryptionManager.Encrypt(bankname);
            string accountnumbe = encryptionManager.Encrypt(accountnumber);
            MessageBox.Show(accountnumbe,"title");
            if (!System_BankAccounts.bnkacounts.ContainsKey(accountnumbe))
            {
               
                foreach (var s in System_BankAccounts.bnkacounts)
                {
                    MessageBox.Show(s.Key, "title");
                }
                return;
            }
            BankAccounts account = System_BankAccounts.bnkacounts[accountnumbe];
            User user = users.UsersWithPhone[account.getphone()];
            BankAccounts senderaccount = sender.myaccounts.Find(a => a.getbankname() == bankname);
            sender.mytransactions.Add(new Transactions(sender.Email, user.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            ms.transactions.Add(new Transactions(sender.Email, user.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            user.mytransactions.Add(new Transactions(sender.Email, user.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            senderaccount.recieveamout(-int.Parse(encryptionManager.Decrypt(encryptedAmount)));
            recieve(user, account, int.Parse(encryptionManager.Decrypt(encryptedAmount)), sender.Phone);
            Notifications notifications = notificationFactory.createnotifications("status", $"{amount} pounds were transferred to {user.Phone}", sender.Phone); 
            notifications.sendnotification();
            if (senderaccount.getamount() <= 500)
            {
                Notifications notification = notificationFactory.createnotifications("low balance", $" ", sender.Phone);
                notification.sendnotification();
            }
        }

        void recieve(User receiver,BankAccounts account,int amount,string phone) {
            System_BankAccounts.bnkacounts[account.getaccountnumber()].recieveamout(amount);
            Notifications notifications = notificationFactory.createnotifications("status", $"An amount of {amount} pounds was received from {phone}", receiver.Phone);
            notifications.sendnotification();
        }
    }
}
