using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_InstaPay
{
    internal class ProxyUser:RealUser
    {
        private static readonly Dictionary<string, User> RegisteredUsers = new Dictionary<string, User>();
        private static readonly Regex ValidEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        static string HashPassword(string password, byte[] salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenate password and salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                // Hash the concatenated password and salt
                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

                // Concatenate the salt and hashed password for storage
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
            }
        }
        static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16]; // Adjust the size based on your security requirements
                rng.GetBytes(salt);
                return salt;
            }
        }
        byte[] saltBytes = GenerateSalt();

        public void Register(string name, string email, string password, string address, string phone)
        {
            if (!ValidEmailRegex.IsMatch(email))
            {
                throw new Exception("Invalid email format.");
            }
            if (RegisteredUsers.ContainsKey(email))
            {
                throw new Exception("This email already exists.");
            }
            if (password.Length < 8)
            {
                throw new Exception("Password must be at least 8 characters long.");
            }

            byte[] salt = GenerateSalt();
            string hashedPassword = HashPassword(password, saltBytes);
            string userId = Guid.NewGuid().ToString(); // Generate a unique ID

            User newUser = new User
            (
                 userId,
                 name,
                email,
                phone,
                address,
                hashedPassword
               
            );
            // Console.WriteLine(hashedPassword);
            RegisteredUsers[email] = newUser; // Add to in-memory storage
            Console.WriteLine($"User registered successfully. User ID: {userId}");
        }

        public void Login(string email, string password)
        {
            if (!RegisteredUsers.ContainsKey(email))
            {
                Console.WriteLine("User not found.");
                return;
            }

            User user = RegisteredUsers[email];
            string computedHash = HashPassword(password, saltBytes);
            if (user.Suspended)
            {
                Console.WriteLine("This account is suspended");
            }
            else
            {
                //Console.WriteLine(computedHash);
                if (computedHash == user.PasswordHash)
                {
                    Console.WriteLine($"Login successful! Welcome, {user.Name}.");
                }
                else
                {
                    Console.WriteLine("Invalid email or password.");
                }
            }
        }
        public void UpdateProfile(string email, string? newName = null, string? newAddress = null, string? newPhone = null)
        {
            if (!RegisteredUsers.ContainsKey(email))
            {
                Console.WriteLine("User not found.");
                return;
            }

            User user = RegisteredUsers[email];

            // Update fields only if new values are provided
            if (!string.IsNullOrEmpty(newName))
            {
                user.Name = newName;
                Console.WriteLine($"Name updated to: {user.Name}");
            }

            if (!string.IsNullOrEmpty(newPhone))
            {
                user.Phone = newPhone;
                Console.WriteLine($"Phone updated to: {user.Phone}");
            }
            if (!string.IsNullOrEmpty(newAddress))
            {
                user.Address = newAddress;
                Console.WriteLine($"Phone updated to: {user.Address}");
            }
            if (string.IsNullOrEmpty(newName) && string.IsNullOrEmpty(newPhone) && string.IsNullOrEmpty(newAddress))
            {
                Console.WriteLine("No updates provided.");
            }
        }
    }
}
