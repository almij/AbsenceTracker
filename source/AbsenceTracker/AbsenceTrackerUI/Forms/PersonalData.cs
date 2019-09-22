using System;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class PersonalData : Form
    {
        private Form ParentForm { get; set; }

        public PersonalData(Form parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
        }

        private void PersonalData_Load(object sender, EventArgs e)
        {

        }

        private void ProjectsInvolvedInLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO add actual saving on personal data screen
            CloseForm();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            ParentForm.Enabled = true;
            Close();
        }
    }
}
