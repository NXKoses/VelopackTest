using Velopack;

namespace VelopackTest
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
            VelopackApp.Build().WithBeforeUninstallFastCallback((v) => { }).WithFirstRun((v) =>
            {
                // ‰‰ñ‹N“®‚Ìˆ—
                Form2 fm2 = new();
                fm2.ShowDialog();
            }).Run();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}