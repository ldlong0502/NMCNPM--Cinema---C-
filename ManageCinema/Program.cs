using ManageCinema.Admin;

namespace ManageCinema
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
            ApplicationConfiguration.Initialize();
            Application.Run(Form_Store.admin);
            //Application.Run(Form_Store.homePage);
        }
    }
}