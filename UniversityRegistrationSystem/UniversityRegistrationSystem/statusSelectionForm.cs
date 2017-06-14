using SharedLibrary;
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
        //Create a list to store status details.
        List<Status> lstStatus = null;

        public statusSelectionForm()
        {
            InitializeComponent();
        }

        private void statusSelectionForm_Load(object sender, EventArgs e)
        {   
            //creating a object list from the satus class to give a data source to status combobox.
            lstStatus = new List<Status>();

            //adding status values to the each object
            lstStatus.Add(new Status() { StatusID = 1, StatusName = "Student"  });
            lstStatus.Add(new Status() { StatusID = 2, StatusName = "Lecture" });
            lstStatus.Add(new Status() { StatusID = 3, StatusName = "Staff" });

            comboStatus.DataSource = lstStatus;
            comboStatus.DisplayMember = "StatusName";
            comboStatus.ValueMember = "StatusID";
            comboStatus.SelectedIndex = -1;
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

        private void btnContinueStatus_Click(object sender, EventArgs e)
        {
            try
            {
                getSelectedStatus();

                if (getSelectedStatus() == 1)
                { 
                    studentLoginForm objstudentLoginForm = new studentLoginForm();
                    objstudentLoginForm.Show();
                    this.Hide();
                }
                if (getSelectedStatus() == 2)
                {
                    lecturerLoginForm objlecturerLoginForm = new lecturerLoginForm();
                    objlecturerLoginForm.Show();
                    this.Hide();
                }
                if (getSelectedStatus() == 3)
                {
                    staffLoginForm objstaffLoginForm = new staffLoginForm();
                    objstaffLoginForm.Show();
                    this.Hide();
                }
                if (getSelectedStatus() == 0)
                {
                    MessageBox.Show("Please select your status before you continue","Reminder",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error Log Report",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        

        //method which perform according to the user selected status
        public int getSelectedStatus()
        {
            int SelectedStatus = 0;

            if (comboStatus.SelectedIndex > -1)
            {
                if ((int)comboStatus.SelectedValue == 1)
                {
                    SelectedStatus = 1;
                }

                if ((int)comboStatus.SelectedValue == 2)
                {
                    SelectedStatus = 2;
                }

                if ((int)comboStatus.SelectedValue == 3)
                {
                    SelectedStatus = 3;
                }                
            }
            return SelectedStatus;
        }

    }
}

//Code by Dilum De Silva.