namespace Mini_InstaPay
{
    public class TwoFactorAuthManager
    {
        private string otp;

        public TwoFactorAuthManager()
        {
            // Generate OTP during initialization
            otp = OtpGenerator.Instance.GenerateOtp();
        }

        // Method to get the OTP (for sending to the user, like an email or SMS)
        public string GetOtp()
        {
            return otp;
        }

        // Method to verify OTP entered by the user
        public bool VerifyOtp(string enteredOtp)
        {
            return enteredOtp == otp; // Compare entered OTP with generated OTP
        }
    }
}