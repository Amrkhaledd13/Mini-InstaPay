﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    public class Transactions
    {
        public string senderEmail, receiverEmail;
        public DateTime dateTime;
        public int  amount;
        
        public Transactions( string _sender, string _receiver,int _amount)
        {
            dateTime = DateTime.Now;
            this.senderEmail = _sender;
            this.receiverEmail = _receiver;
            this.amount = _amount;
        }
    }
}
