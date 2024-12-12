using System;

namespace MiniInstaPay
{
    public class OtpGenerator
    {
        private static OtpGenerator? instance;

        private OtpGenerator() { }

        public static OtpGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OtpGenerator();
                }
                return instance;
            }
        }

        public string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}