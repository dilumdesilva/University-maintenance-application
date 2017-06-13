namespace UniversityRegistrationSystem
{
    partial class studentLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentLoginForm));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnLoginToCheckMarks = new System.Windows.Forms.Button();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Location = new System.Drawing.Point(37, 94);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(122, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please enter your details";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Location = new System.Drawing.Point(38, 128);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Location = new System.Drawing.Point(37, 160);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Location = new System.Drawing.Point(38, 191);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(129, 125);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(144, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(129, 157);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(144, 20);
            this.txtStudentID.TabIndex = 5;
            // 
            // btnLoginToCheckMarks
            // 
            this.btnLoginToCheckMarks.Location = new System.Drawing.Point(128, 239);
            this.btnLoginToCheckMarks.Name = "btnLoginToCheckMarks";
            this.btnLoginToCheckMarks.Size = new System.Drawing.Size(80, 27);
            this.btnLoginToCheckMarks.TabIndex = 7;
            this.btnLoginToCheckMarks.Text = "Login";
            this.btnLoginToCheckMarks.UseVisualStyleBackColor = true;
            // 
            // comboDepartment
            // 
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(129, 188);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(144, 21);
            this.comboDepartment.TabIndex = 8;
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(71, 12);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(189, 53);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 9;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // studentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(327, 278);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Controls.Add(this.comboDepartment);
            this.Controls.Add(this.btnLoginToCheckMarks);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblInstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentLoginForm";
            this.Text = "studentLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnLoginToCheckMarks;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
    }
}