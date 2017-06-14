namespace UniversityRegistrationSystem
{
    partial class studentMarksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentMarksForm));
            this.lblNameReplace = new System.Windows.Forms.Label();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.dgvStudentsMarks = new System.Windows.Forms.DataGridView();
            this.btnEmailGenerator = new System.Windows.Forms.Button();
            this.btnStuBackToLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameReplace
            // 
            this.lblNameReplace.AutoSize = true;
            this.lblNameReplace.BackColor = System.Drawing.Color.Transparent;
            this.lblNameReplace.Location = new System.Drawing.Point(36, 115);
            this.lblNameReplace.Name = "lblNameReplace";
            this.lblNameReplace.Size = new System.Drawing.Size(35, 13);
            this.lblNameReplace.TabIndex = 0;
            this.lblNameReplace.Text = "Name";
            // 
            // comboDepartment
            // 
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(246, 112);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(158, 21);
            this.comboDepartment.TabIndex = 1;
            // 
            // dgvStudentsMarks
            // 
            this.dgvStudentsMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsMarks.Location = new System.Drawing.Point(39, 147);
            this.dgvStudentsMarks.Name = "dgvStudentsMarks";
            this.dgvStudentsMarks.Size = new System.Drawing.Size(365, 156);
            this.dgvStudentsMarks.TabIndex = 2;
            // 
            // btnEmailGenerator
            // 
            this.btnEmailGenerator.Location = new System.Drawing.Point(39, 318);
            this.btnEmailGenerator.Name = "btnEmailGenerator";
            this.btnEmailGenerator.Size = new System.Drawing.Size(95, 29);
            this.btnEmailGenerator.TabIndex = 3;
            this.btnEmailGenerator.Text = "Email a report";
            this.btnEmailGenerator.UseVisualStyleBackColor = true;
            // 
            // btnStuBackToLogin
            // 
            this.btnStuBackToLogin.Location = new System.Drawing.Point(307, 318);
            this.btnStuBackToLogin.Name = "btnStuBackToLogin";
            this.btnStuBackToLogin.Size = new System.Drawing.Size(97, 29);
            this.btnStuBackToLogin.TabIndex = 4;
            this.btnStuBackToLogin.Text = "Home";
            this.btnStuBackToLogin.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(66, 115);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(151, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = ",please select your department";
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(124, 27);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(189, 53);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 11;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright2.Location = new System.Drawing.Point(231, 389);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 24;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright1.Location = new System.Drawing.Point(188, 385);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 23;
            this.lblCopyright1.Text = "Copyright";
            // 
            // studentMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(445, 406);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStuBackToLogin);
            this.Controls.Add(this.btnEmailGenerator);
            this.Controls.Add(this.dgvStudentsMarks);
            this.Controls.Add(this.comboDepartment);
            this.Controls.Add(this.lblNameReplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentMarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameReplace;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.DataGridView dgvStudentsMarks;
        private System.Windows.Forms.Button btnEmailGenerator;
        private System.Windows.Forms.Button btnStuBackToLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
    }
}