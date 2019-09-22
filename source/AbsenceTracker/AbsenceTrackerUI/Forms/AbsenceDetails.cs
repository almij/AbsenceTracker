using AbsenceTrackerLibrary;
using AbsenceTrackerLibrary.Models;
using System;
using System.Text;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class AbsenceDetails : Form
    {
        private Form ParentForm { get; set; }

        public AbsenceDetails(Form parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO add actual saving on absence details screen
            if (!ValidateForm()) return;
            AbsenceTracker.AddAbsence(
                new AbsenceModel()
                {
                    AbsenceType = (AbsenceTypeModel)AbsenceTypeComboBox.SelectedValue,
                    EffectiveFrom = EffectiveFromDateTimePicker.Value,
                    ExpiresOn = ExpiresOnDateTimePicker.Value,
                    DaysWorkedOnHolidays = int.Parse(DaysWorkedOnHolidaysTextBox.Text)
                });
            CloseForm();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private bool ValidateForm()
        {
            var isValid = true;
            var errorMessage = new StringBuilder("Ivalid values on form:");
            //if(AbsenceTypeComboBox.SelectedItem is null)
            //{
            //    errorMessage.Append("\nAbsence Type must be populated\n");
            //    isValid = false;
            //}
            if (!int.TryParse(DaysWorkedOnHolidaysTextBox.Text, out var number))
            {
                errorMessage.Append("\nDays worked on holidays must be a number");
                isValid = false;
            }
            if (EffectiveFromDateTimePicker.Text is null || ExpiresOnDateTimePicker.Text is null)
            {
                errorMessage.Append("\nEffective and expiration dates must be populated");
                isValid = false;
            }
            if (ExpiresOnDateTimePicker.Value.Date < EffectiveFromDateTimePicker.Value.Date)
            {
                errorMessage.Append("Effective date must be less or equal to the expiration date\n");
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Error");
            }
            return isValid;
        }

        private void AbsenceDetails_Load(object sender, EventArgs e)
        {
            DaysWorkedOnHolidaysTextBox.AppendText(0.ToString());
        }

        private void CloseForm()
        {
            ParentForm.Enabled = true;
            Close();
        }
    }
}
