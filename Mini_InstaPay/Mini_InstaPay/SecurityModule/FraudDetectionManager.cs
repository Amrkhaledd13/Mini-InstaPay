using System;

namespace MiniInstaPay
{
    public class FraudDetectionManager
    {
        private const double MaxTransactionAmount = 1000000;

        public bool SUS_Transacion(string account, double amount)
        {
            if (amount > MaxTransactionAmount)
            {
                Console.WriteLine($"Transaction flagged: Amount exceeds limit of {MaxTransactionAmount}");
                return true;
            }

            return false;
        }
    }
}



