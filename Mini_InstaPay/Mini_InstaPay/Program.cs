using System;


namespace MiniInstaPay
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoFactorAuthManager manager = new TwoFactorAuthManager();
            manager.Authenticate();
        }
    }
}