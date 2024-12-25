using Mini_InstaPay;

namespace GUI_mini_insta
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ProxyUser proxyUser = new ProxyUser();
            proxyUser.Register("Admin", "admin@gmail.com", "admin12345", "cairo", "0112726732");
            ApplicationConfiguration.Initialize();
            Application.Run(new Register());
        }
    }
}