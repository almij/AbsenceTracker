using AbsenceTrackerLibrary;
using AbsenceTrackerLibrary.Models;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbsenceTrackerUI.Forms
{
    public partial class AbsenceDetails : Form
    {
        private Form CallerForm { get; set; }
        private AbsenceModel CurrentAbsence { get; set; }

        public AbsenceDetails(Form callerForm, AbsenceModel absence = null)
        {
            InitializeComponent();
            if(absence is null)
            {
                CurrentAbsence = new AbsenceModel();
            }
            else
            {
                CurrentAbsence = absence;
            }
            CallerForm = callerForm;
            CallerForm.Enabled = false;
            AbsenceTypeComboBox.DataSource = AbsenceTracker.AbsenceTypes;
            RefreshFormFields();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            CurrentAbsence.AbsenceType = (AbsenceTypeModel)AbsenceTypeComboBox.SelectedItem;
            CurrentAbsence.EffectiveFrom = EffectiveFromDateTimePicker.Value;
            CurrentAbsence.ExpiresOn = ExpiresOnDateTimePicker.Value;
            CurrentAbsence.DaysWorkedOnHolidays = int.Parse(DaysWorkedOnHolidaysTextBox.Text);
            AbsenceTracker.SaveAbsence(CurrentAbsence);
            Close();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateForm()
        {
            var isValid = true;
            var errorMessage = new StringBuilder("Ivalid values on form:");
            if (AbsenceTypeComboBox.SelectedItem is null)
            {
                errorMessage.Append("\nAbsence Type must be populated\n");
                isValid = false;
            }
            if (!int.TryParse(DaysWorkedOnHolidaysTextBox.Text, out var number))
            {
                errorMessage.Append("\nDays worked on holidays must be a number");
                isValid = false;
            }
            if (!AbsenceTracker.ValidateAbsenceForDublicateDatePeriod(
                    EffectiveFromDateTimePicker.Value,
                    ExpiresOnDateTimePicker.Value,
                    CurrentAbsence.Id))
            {
                errorMessage.Append("\nEffective and expiration dates must be unique in the absence list");
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

        private void AbsenceDetails_OnClosing(object sender, EventArgs e)
        {
            CallerForm.Enabled = true;
        }

        private void RefreshFormFields()
        {
            AbsenceTypeComboBox.SelectedItem = CurrentAbsence.AbsenceType;
            AbsenceTypeComboBox_SelectedIndexChanged(AbsenceTypeComboBox, null);
            EffectiveFromDateTimePicker.Value = CurrentAbsence.EffectiveFrom;
            ExpiresOnDateTimePicker.Value = CurrentAbsence.ExpiresOn;
            DaysWorkedOnHolidaysTextBox.Text = CurrentAbsence.DaysWorkedOnHolidays.ToString();
        }

        private void AbsenceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var absenceComboBox = (ComboBox)sender;
            var selectedItem = (AbsenceTypeModel)absenceComboBox.SelectedItem;
            if (!(selectedItem is null) &&
                (selectedItem.IsOvertime || selectedItem.IsDayOff))
            {
                DaysWorkedOnHolidaysTextBox.Visible = false;
                SingleDayCheckBox.Visible = true;
            }
            else
            {
                DaysWorkedOnHolidaysTextBox.Visible = true;
                SingleDayCheckBox.Visible = false;
            }
        }

        private void SingleDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                ExpiresOnDateTimePicker.Value = EffectiveFromDateTimePicker.Value;
                ExpiresOnDateTimePicker.Visible = false;
            }
            else
            {
                ExpiresOnDateTimePicker.Visible = true;
            }
        }

        private void EffectiveFromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (SingleDayCheckBox.Checked)
            {
                ExpiresOnDateTimePicker.Value = EffectiveFromDateTimePicker.Value;
            }
        }
    }
}
