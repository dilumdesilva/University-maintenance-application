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

        //create a global varible to identify signup,signin seperatly
        public int Stage { get; set; }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {   
                Stage = 1;
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
                Stage = 2;
                continueToNexForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void continueToNexForm()
        {
            if (Stage==1)
            {
                statusSelectionForm objstatusSelectionForm = new statusSelectionForm(Stage);
                //MessageBox.Show(Stage.ToString());
                objstatusSelectionForm.Show();
                this.Hide();
            }
            else if (Stage==2)
            {
                statusSelectionForm objstatusSelectionForm = new statusSelectionForm(Stage);
                //MessageBox.Show(Stage.ToString());
                objstatusSelectionForm.Show();
                this.Hide();
            }
            
        }
    }
}
