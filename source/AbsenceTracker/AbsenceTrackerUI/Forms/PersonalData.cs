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
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();
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
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
