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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                continueToNexForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                continueToNexForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void continueToNexForm()
        {

            statusSelectionForm objstatusSelectionForm = new statusSelectionForm();
            objstatusSelectionForm.Show();
            this.Hide();
        }
    }
}
