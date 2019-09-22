using AbsenceTrackerLibrary;
using AbsenceTrackerLibrary.Models;
using System;
using System.Text;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class AbsenceDetails : Form
    {
        private Form CallerForm { get; set; }
        private AbsenceModel CurrentAbsence { get; set; }

        public AbsenceDetails(Form parentForm)
        {
            InitializeComponent();
            CurrentAbsence = new AbsenceModel();
            CallerForm = parentForm;
        }

        public AbsenceDetails(Form parentForm, AbsenceModel absence)
        {
            InitializeComponent();
            CurrentAbsence = absence;
            CallerForm = parentForm;
            AbsenceTypeComboBox.SelectedValue = CurrentAbsence.AbsenceType;
            EffectiveFromDateTimePicker.Value = CurrentAbsence.EffectiveFrom;
            ExpiresOnDateTimePicker.Value = CurrentAbsence.ExpiresOn;
            DaysWorkedOnHolidaysTextBox.Text = CurrentAbsence.DaysWorkedOnHolidays.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO add actual saving on absence details screen
            if (!ValidateForm()) return;
            CurrentAbsence.AbsenceType = (AbsenceTypeModel)AbsenceTypeComboBox.SelectedValue;
            CurrentAbsence.EffectiveFrom = EffectiveFromDateTimePicker.Value;
            CurrentAbsence.ExpiresOn = ExpiresOnDateTimePicker.Value;
            CurrentAbsence.DaysWorkedOnHolidays = int.Parse(DaysWorkedOnHolidaysTextBox.Text);
            AbsenceTracker.SaveAbsence(CurrentAbsence);
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

        private void CloseForm()
        {
            CallerForm.Enabled = true;
            Close();
        }
    }
}
