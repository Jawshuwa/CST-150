namespace Milestone_Project
{
    internal static class Program
    {
        // Creating a global InventoryManager variable accesible in any form
        public static InventoryManager InventoryManager { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}