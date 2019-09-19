using AbsenceTrackerLibrary;
using AbsenceTrackerLibrary.Models;
using AbsenceTrackerUI.Forms;
using System;
using System.Windows.Forms;

namespace AbsenceTrackerUI
{
    static class AbsenceTrackerUI
    {
        public static PersonModel CurrentUser;

        /// <summary>
        /// The main entry point for the application.
        /// TODO look more into why in UI proj you had to add references at nugets that are already added as dependencies into referenced library
        /// I'm pretty sure ot's because I did smth wrong
        /// this looks related: Issues with .NET Standard 2.0 with .NET Framework & NuGet #481
        /// https://github.com/dotnet/standard/issues/481 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config.Initialise(Properties.Settings.Default.DatabaseConnection);
            CurrentUser = Config.Database.GetDefaultUser();
            Application.Run(new AbsenceTrackerDashboard());
        }
    }
}
