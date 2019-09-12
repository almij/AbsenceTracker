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
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config.Initialise(Database.Sql, "1");
            Application.Run(new AbsenceTrackerDashboard());
        }
    }
}
