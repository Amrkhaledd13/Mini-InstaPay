
using Mini_InstaPay;

public class Program
{
    public static void Main(string[] args)
    {
        RealUser userProxy = new ProxyUser();
        while (true)
        {
            string type;
            Console.WriteLine("if you want to Register type R \nif you want to Login type L \nif you want to update your data type U \nif you want to Quit type Q");
            type = Console.ReadLine();
            try
            {
                if (type.Equals("R"))
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
                    // Register User
                    // userProxy.Register(username, email, password, address, phone);
                    Console.Write(userProxy.Register(username, email, password, address, phone));

                }
                else if (type.Equals("L"))
                {
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    userProxy.Login(email, password);
                }
                else if (type.Equals("U"))
                {
                    Console.Write("Please enter your mail to update your data: ");
                    string email = Console.ReadLine();
                    string z;

                    Console.WriteLine("if you want to update your Name type N \nif you want to update your Phone type P \nif you want to update your Address type A ");
                    z = Console.ReadLine();
                    if (z.Equals("N"))
                    {
                        Console.Write("Please enter your new name: ");
                        string nname = Console.ReadLine();
                        userProxy.UpdateProfile(email, newName: nname);
                    }
                    else if (z.Equals("P"))
                    {
                        Console.Write("Please enter your new phone: ");
                        string nphone = Console.ReadLine();
                        userProxy.UpdateProfile(email, newPhone: nphone);
                    }
                    else if (z.Equals("A"))
                    {
                        Console.Write("Please enter your new address: ");
                        string nadd = Console.ReadLine();
                        userProxy.UpdateProfile(email, newAddress: nadd);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (type.Equals("Q"))
            {
                break;
            }
        }
    }
}