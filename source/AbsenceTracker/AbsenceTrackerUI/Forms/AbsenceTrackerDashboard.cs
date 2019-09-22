using AbsenceTrackerLibrary.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class AbsenceTrackerDashboard : Form
    {
        private static readonly BindingList<AbsenceModel> AbsencesBindingList = new BindingList<AbsenceModel>(AbsenceTrackerLibrary.AbsenceTracker.CurrentUser.Absences);

        public AbsenceTrackerDashboard()
        {
            InitializeComponent();
        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AbsencesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var absencesGrid = (DataGridView)sender;
            var column = absencesGrid.Columns[e.ColumnIndex];
            var rowIndex = e.RowIndex;
            if (column is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if(column.Name == RemoveButtonColumn.Name)
                {
                    AbsenceTrackerLibrary.AbsenceTracker.RemoveAbsence(AbsencesBindingList[rowIndex]);
                    RefreshAbsencesDataGrid();
                }
                else if (column.Name == DetailsButtonColumn.Name)
                {
                    new AbsenceDetails(this, AbsencesBindingList[rowIndex]).Show();
                }
            }
        }

        private void EditPersonalDataButton_Click(object sender, EventArgs e)
        {
            new PersonalData(this).Show();
        }

        private void NewAbsenceButton_Click(object sender, EventArgs e)
        {
            new AbsenceDetails(this).Show();
        }

        private void AbsenceTrackerDashboard_Activated(object sender, EventArgs e)
        {
            RefreshAbsencesDataGrid();
        }

        private void AbsenceTrackerDashboard_Deactivated(object sender, EventArgs e)
        {
            Enabled = false;
        }

        private void AbsenceTrackerDashboard_Load(object sender, EventArgs e)
        {
            if (!(AbsenceTrackerLibrary.AbsenceTracker.CurrentUser is null))
            {
                FullNameTextBox.AppendText($"{AbsenceTrackerLibrary.AbsenceTracker.CurrentUser.FirstName} {AbsenceTrackerLibrary.AbsenceTracker.CurrentUser.LastName}");
                DaysOffBalanceTextBox.AppendText(AbsenceTrackerLibrary.AbsenceTracker.CurrentUser.DaysOffBalance.ToString());
                AbsencesDataGridView.DataSource = AbsencesBindingList;
            }
        }

        private void RefreshAbsencesDataGrid()
        {
            AbsencesDataGridView.DataSource = null;
            AbsencesDataGridView.DataSource = AbsencesBindingList;
        }
    }
}
