using AbsenceTrackerLibrary;
using System;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class PersonalData : Form
    {
        private Form CallerForm { get; set; }

        public PersonalData(Form callerForm)
        {
            InitializeComponent();
            CallerForm = callerForm;
            CallerForm.Enabled = false;
            RefreshForm();
        }

        private void PersonalData_OnClosing(object sender, EventArgs e)
        {
            CallerForm.Enabled = true;
        }

        private void ProjectsInvolvedInLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO add validation
            AbsenceTracker.CurrentUser.Username = UsernameTextBox.Text;
            AbsenceTracker.CurrentUser.FirstName = FirstNameTextBox.Text;
            AbsenceTracker.CurrentUser.LastName = LastNameTextBox.Text;
            AbsenceTracker.CurrentUser.MiddleName = MiddleNameTextBox.Text;
            AbsenceTracker.CurrentUser.Patronymic = PatronymicTextBox.Text;
            AbsenceTracker.CurrentUser.Email = EmailTextBox.Text;
            AbsenceTracker.CurrentUser.FullNameForDocuments = FullnameForDocumentsTextBox.Text;
            AbsenceTracker.CurrentUser.StartedAt = StartedAtDateTimePicker.Value;
            AbsenceTracker.SaveCurrentUser();
            Close();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshForm()
        {
            UsernameTextBox.Text = AbsenceTracker.CurrentUser.Username;
            FirstNameTextBox.Text = AbsenceTracker.CurrentUser.FirstName;
            LastNameTextBox.Text = AbsenceTracker.CurrentUser.LastName;
            MiddleNameTextBox.Text = AbsenceTracker.CurrentUser.MiddleName;
            PatronymicTextBox.Text = AbsenceTracker.CurrentUser.Patronymic;
            EmailTextBox.Text = AbsenceTracker.CurrentUser.Email;
            FullnameForDocumentsTextBox.Text = AbsenceTracker.CurrentUser.FullNameForDocuments;
            StartedAtDateTimePicker.Value = AbsenceTracker.CurrentUser.StartedAt;
        }
    }
}
