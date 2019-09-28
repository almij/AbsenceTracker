using AbsenceTrackerLibrary;
using AbsenceTrackerLibrary.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class AbsenceTrackerDashboard : Form
    {
        private static BindingList<AbsenceModel> AbsencesBindingList = new BindingList<AbsenceModel>(AbsenceTracker.CurrentUser.Absences);

        public AbsenceTrackerDashboard()
        {
            InitializeComponent();
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
                    AbsenceTracker.RemoveAbsence(AbsencesBindingList[rowIndex]);
                    RefreshForm();
                }
                else if (column.Name == DetailsButtonColumn.Name)
                {
                    new AbsenceDetails(this, AbsencesBindingList[rowIndex]).Show();
                }
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            new PersonalData(this).Show();
        }

        private void NewAbsenceButton_Click(object sender, EventArgs e)
        {
            new AbsenceDetails(this).Show();
        }

        private void AbsenceTrackerDashboard_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void AbsenceTrackerDashboard_Load(object sender, EventArgs e)
        {
            if (!(AbsenceTracker.CurrentUser is null))
            {
                RefreshForm();
            }
        }

        private void RefreshForm()
        {
            if(AbsenceTracker.CurrentUser.Id is null)
            {
                NewAbsenceButton.Enabled = false;
                EditUserButton.Text = "Create user";
            }
            else
            {
                NewAbsenceButton.Enabled = true;
                EditUserButton.Text = "Edit user";
            }
            UsernameTextBox.Text = AbsenceTracker.CurrentUser.Username;
            FullNameTextBox.Text = $"{AbsenceTracker.CurrentUser.FirstName} {AbsenceTracker.CurrentUser.LastName}";
            DaysOffBalanceTextBox.Text = AbsenceTracker.CurrentUser.DaysOffBalance.ToString();
            AbsencesDataGridView.DataSource = null;
            AbsencesDataGridView.DataSource = AbsencesBindingList;
            AbsencesDataGridView.Refresh();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(!AbsenceTracker.Login(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("User not found");
            }
            AbsencesBindingList = new BindingList<AbsenceModel>(AbsenceTracker.CurrentUser.Absences);
            AbsencesDataGridView.DataSource = AbsencesBindingList; ;
            RefreshForm();
        }
    }
}
