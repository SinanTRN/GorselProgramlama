namespace Hafta2
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
            Form2 nesne=new Form2();
            nesne.Text = "Ana Pencere";
            Application.Run(nesne);
        }
    }
}