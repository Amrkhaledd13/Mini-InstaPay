using Mini_InstaPay;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        RealUser userProxy = new ProxyUser();
        User loggedInUser = null;

        while (true)
        {
            if (loggedInUser == null)
            {
                // Login/Registration Menu
                Console.WriteLine("if you want to Register type R");
                Console.WriteLine("if you want to Login type L");
                Console.WriteLine("if you want to update your data type U");
                Console.WriteLine("if you want to Quit type Q");
                string type = Console.ReadLine()?.Trim();

                try
                {
                    if (type.Equals("R", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();
                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        string phone = Console.ReadLine();

                        Console.WriteLine(userProxy.Register(username, email, password, address, phone));
                    }
                    else if (type.Equals("L", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();

                        loggedInUser = userProxy.Login(email, password);

                        if (loggedInUser != null)
                        {
                            Console.WriteLine("Login successful!");
                        }
                    }
                    else if (type.Equals("U", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Please enter your email to update your data: ");
                        string email = Console.ReadLine();

                        Console.WriteLine("if you want to update your Name type N");
                        Console.WriteLine("if you want to update your Phone type P");
                        Console.WriteLine("if you want to update your Address type A");
                        string option = Console.ReadLine()?.Trim();

                        if (option.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Please enter your new name: ");
                            string newName = Console.ReadLine();
                            userProxy.UpdateProfile(email, newName: newName);
                        }
                        else if (option.Equals("P", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Please enter your new phone: ");
                            string newPhone = Console.ReadLine();
                            userProxy.UpdateProfile(email, newPhone: newPhone);
                        }
                        else if (option.Equals("A", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Please enter your new address: ");
                            string newAddress = Console.ReadLine();
                            userProxy.UpdateProfile(email, newAddress: newAddress);
                        }
                    }
                    else if (type.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                // User Logged In Menu
                Console.WriteLine($"Welcome, {loggedInUser.Name}! Select an option:");
                Console.WriteLine("A - Add Bank Account");
                Console.WriteLine("R - Remove Bank Account");
                Console.WriteLine("V - View All Bank Accounts");
                Console.WriteLine("T - View Total Money Amount");
                Console.WriteLine("S - Send Money");
                Console.WriteLine("Q - Logout");

                string option = Console.ReadLine()?.Trim();

                try
                {
                    if (option.Equals("A", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter Bank Name: ");
                        string bankName = Console.ReadLine();
                        Console.Write("Enter Account Number: ");
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter Initial Amount: ");
                        int initialAmount = int.Parse(Console.ReadLine());

                        BankAccounts newAccount = new BankAccounts(accountNumber, initialAmount, bankName);
                        loggedInUser.Addaccount(newAccount);
                        Console.WriteLine("Bank account added successfully.");
                    }
                    else if (option.Equals("R", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter Account Number to Remove: ");
                        string accountNumber = Console.ReadLine();
                        loggedInUser.Removeaccount(accountNumber);
                        Console.WriteLine("Bank account removed successfully.");
                    }
                    else if (option.Equals("V", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Your Accounts:");
                        loggedInUser.getallaccounts();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                    }
                    else if (option.Equals("T", StringComparison.OrdinalIgnoreCase))
                    {
                        double totalAmount = 0;

                        Console.WriteLine("Your Account Balances:");
                        foreach (var account in loggedInUser.myaccounts)
                        {
                            Console.WriteLine($"Bank: {account.getbankname()} | Account Number: {account.getaccountnumber()} | Balance: {account.getamount()}");
                            totalAmount += account.getamount();
                        }

                        Console.WriteLine($"Total Balance Across All Accounts: {totalAmount}");
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                    }
                    else if (option.Equals("S", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Send Money Options:");
                        Console.WriteLine("1 - Send using Phone Number");
                        Console.WriteLine("2 - Send using Account Number");
                        string method = Console.ReadLine()?.Trim();

                        if (method == "1")
                        {
                            Console.Write("Enter Recipient's Phone Number: ");
                            string phone = Console.ReadLine();
                            Console.Write("Enter Amount to Send: ");
                            int amount = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Bank Name: ");
                            string bankName = Console.ReadLine();

                            Sendmoney_Proxy.sendwithphoneproxy(loggedInUser, amount, bankName);
                        }
                        else if (method == "2")
                        {
                            Console.Write("Enter Recipient's Account Number: ");
                            string accountNumber = Console.ReadLine();
                            Console.Write("Enter Amount to Send: ");
                            int amount = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Bank Name: ");
                            string bankName = Console.ReadLine();

                            transferMoney transfer = transferMoney.getts();
                            transfer.sendwithaAccountnumber(loggedInUser, accountNumber, amount, bankName);
                        }

                        Console.WriteLine("Transaction completed successfully.");
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                    }
                    else if (option.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        loggedInUser = null;
                        Console.WriteLine("Logged out successfully.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}