using System;

namespace MiniInstaPay
{
        public class Transaction
    {
        public string TransactionId { get; set; }
        public double Amount { get; set; }
        public string Location { get; set; }

        public Transaction(string transactionId, double amount, string location)
        {
            TransactionId = transactionId;
            Amount = amount;
            Location = location;
        }
    }
}