using AbsenceTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class AbsenceTrackerDashboard : Form
    {
        public AbsenceTrackerDashboard()
        {
            InitializeComponent();
        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditPersonalDataButton_Click(object sender, EventArgs e)
        {
            new PersonalData().Show();
        }

        private void NewAbsenceButton_Click(object sender, EventArgs e)
        {
            new AbsenceDetails().Show();
        }

        private void AbsenceTrackerDashboard_Load(object sender, EventArgs e)
        {
            if(!(AbsenceTrackerUI.CurrentUser is null))
            {
                FullNameTextBox.AppendText($"{AbsenceTrackerUI.CurrentUser.FirstName} {AbsenceTrackerUI.CurrentUser.LastName}");
                DaysOffBalanceTextBox.AppendText(AbsenceTrackerUI.CurrentUser.DaysOffBalance.ToString());
                LoadAbsencesDataGrid(AbsenceTrackerUI.CurrentUser.Absences);
            }
        }

        private void LoadAbsencesDataGrid(List<AbsenceModel> absences)
        {
            AbsencesDataGridView = null;
            var bindingList = new BindingList<AbsenceModel>(absences);
            var source = new BindingSource(bindingList, null);
            AbsencesDataGridView.DataSource = source;
        }
    }
}
