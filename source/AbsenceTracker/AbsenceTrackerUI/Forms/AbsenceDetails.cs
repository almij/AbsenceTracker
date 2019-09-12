using AbsenceTrackerLibrary;
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
    public partial class AbsenceDetails : Form
    {
        public AbsenceDetails()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO add actual saving on absence details screen
            if(!ValidateForm()) return;
            Config.DatabaseConnector.SaveAbsence(new AbsenceModel());
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
            //if(AbsenceTypeComboBox.SelectedItem is null)
            //{
            //    errorMessage.Append("\nAbsence Type must be populated\n");
            //    isValid = false;
            //}
            if(EffectiveFromDateTimePicker.Text is null || ExpiresOnDateTimePicker.Text is null)
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
    }
}
