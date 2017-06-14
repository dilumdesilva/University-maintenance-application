using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityRegistrationSystem
{
    public partial class statusSelectionForm : Form
    {
        public statusSelectionForm()
        {
            InitializeComponent();
        }

        public string getSelectedStatus()
        {
            string selectedStatus = null;

            if (comboStatus.SelectedValue.ToString() == "Student")
            {
                selectedStatus = "Student";
            }
            else
            {
                selectedStatus = null;
            }

            if (comboStatus.SelectedValue.ToString() == "Lecturer")
            {
                selectedStatus = "Lecturer";
            }
            else
            {
                selectedStatus = null;
            }

            if (comboStatus.SelectedValue.ToString() == "Staff")
            {
                selectedStatus = "Staff";
            }
            else
            {
                selectedStatus = null;
            }

            return selectedStatus;
        }

        private void statusSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
