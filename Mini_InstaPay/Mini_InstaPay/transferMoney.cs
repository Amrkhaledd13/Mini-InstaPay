using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay
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
            EncryptionManager encryptionManager = new EncryptionManager();

              string encryptedAmount = encryptionManager.Encrypt(amount.ToString());
              string encryptedBankName = encryptionManager.Encrypt(bankname);

           User reciever = users.UsersWithPhone[phonenumber];
           BankAccounts account =  reciever.getthedeafult();
           BankAccounts senderaccount =  sender.myaccounts.Find(a => a.getbankname() == bankname);

           

            sender.mytransactions.Add(new Transactions(sender.Email, reciever.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            reciever.mytransactions.Add(new Transactions(sender.Email, reciever.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));


            senderaccount.recieveamout(-int.Parse(encryptionManager.Decrypt(encryptedAmount)));
            recieve(reciever, account, int.Parse(encryptionManager.Decrypt(encryptedAmount)));
        }
          public  void sendwithaAccountnumber(User sender,string accountnumber,int amount,string bankname)
        {
             EncryptionManager encryptionManager = new EncryptionManager();

              string encryptedAmount = encryptionManager.Encrypt(amount.ToString());
              string encryptedBankName = encryptionManager.Encrypt(bankname);


            BankAccounts account = System_BankAccounts.bnkacounts[accountnumber];
            User user = users.UsersWithPhone[account.getphone()];
            BankAccounts senderaccount = sender.myaccounts.Find(a => a.getbankname() == bankname);


            sender.mytransactions.Add(new Transactions(sender.Email, user.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));
            user.mytransactions.Add(new Transactions(sender.Email, user.Email, int.Parse(encryptionManager.Decrypt(encryptedAmount))));

            senderaccount.recieveamout(-int.Parse(encryptionManager.Decrypt(encryptedAmount)));
            recieve(user, account, int.Parse(encryptionManager.Decrypt(encryptedAmount)));
        }

        void recieve(User receiver,BankAccounts account,int amount) {
            System_BankAccounts.bnkacounts[account.getaccountnumber()].recieveamout(amount);
            var acc = receiver.myaccounts.Find(a => a.getaccountnumber() == account.getaccountnumber());
            acc.recieveamout(amount);
        }
    }
}
