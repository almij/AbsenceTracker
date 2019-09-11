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
            using (var personalData = new PersonalData())
            {
                personalData.Show();
            }
        }
    }
}
