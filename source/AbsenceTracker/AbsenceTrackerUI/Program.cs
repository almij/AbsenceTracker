using AbsenceTrackerLibrary;
using AbsenceTrackerUI.Forms;
using System;
using System.Windows.Forms;

namespace AbsenceTrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// TODO look more into why in UI proj you had to add references at nugets that are already added as dependencies into referenced library
        /// this looks related: Issues with .NET Standard 2.0 with .NET Framework & NuGet #481
        /// https://github.com/dotnet/standard/issues/481 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config.Initialise(Properties.Settings.Default.DatabaseConnection, Properties.Settings.Default.DefaultUserId);
            Application.Run(new AbsenceTrackerDashboard());
        }
    }
}
