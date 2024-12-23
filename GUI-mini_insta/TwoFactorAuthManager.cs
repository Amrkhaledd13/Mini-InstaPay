namespace Mini_InstaPay
{
    public class TwoFactorAuthManager
    {
        public void Authenticate()
        {
            string otp = OtpGenerator.Instance.GenerateOtp();

            Console.WriteLine($"Your OTP is: {otp}");

            Console.WriteLine("Enter the OTP you received:");
            string userOtp = Console.ReadLine() ?? "";

            if (userOtp == otp)
            {
                Console.WriteLine("OTP verified successfully! Authentication complete.");

                    EncryptionManager encryptionManager = new EncryptionManager();

                     Console.WriteLine("Enter sensitive data to encrypt : ");
                    string sensitiveData = Console.ReadLine() ?? "";

                      string encryptedData = encryptionManager.Encrypt(sensitiveData);
                      Console.WriteLine($"Encrypted Data: {encryptedData}");   

                      string decryptedData = encryptionManager.Decrypt(encryptedData);
                      Console.WriteLine($"Decrypted Data: {decryptedData}");   

    
            }
            else
            {
                Console.WriteLine("Invalid OTP. Authentication failed.");
            }
        }
    }
}