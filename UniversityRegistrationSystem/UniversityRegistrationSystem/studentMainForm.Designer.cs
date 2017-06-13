namespace UniversityRegistrationSystem
{
    partial class studentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentMainForm));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnCheckMark = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblStudentNameView = new System.Windows.Forms.Label();
            this.lblStudentIDView = new System.Windows.Forms.Label();
            this.lblDepartmentView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(62, 12);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(189, 53);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 10;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Location = new System.Drawing.Point(76, 95);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(81, 13);
            this.lblStudentName.TabIndex = 11;
            this.lblStudentName.Text = "Student Name :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Location = new System.Drawing.Point(76, 127);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(64, 13);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Student ID :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Location = new System.Drawing.Point(76, 157);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(68, 13);
            this.lblDepartment.TabIndex = 13;
            this.lblDepartment.Text = "Department :";
            // 
            // btnCheckMark
            // 
            this.btnCheckMark.Location = new System.Drawing.Point(62, 205);
            this.btnCheckMark.Name = "btnCheckMark";
            this.btnCheckMark.Size = new System.Drawing.Size(92, 31);
            this.btnCheckMark.TabIndex = 14;
            this.btnCheckMark.Text = "Check Marks";
            this.btnCheckMark.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(178, 205);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 31);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblStudentNameView
            // 
            this.lblStudentNameView.AutoSize = true;
            this.lblStudentNameView.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNameView.Location = new System.Drawing.Point(165, 95);
            this.lblStudentNameView.Name = "lblStudentNameView";
            this.lblStudentNameView.Size = new System.Drawing.Size(75, 13);
            this.lblStudentNameView.TabIndex = 16;
            this.lblStudentNameView.Text = "StuName here";
            // 
            // lblStudentIDView
            // 
            this.lblStudentIDView.AutoSize = true;
            this.lblStudentIDView.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentIDView.Location = new System.Drawing.Point(165, 127);
            this.lblStudentIDView.Name = "lblStudentIDView";
            this.lblStudentIDView.Size = new System.Drawing.Size(56, 13);
            this.lblStudentIDView.TabIndex = 17;
            this.lblStudentIDView.Text = "stuID here";
            // 
            // lblDepartmentView
            // 
            this.lblDepartmentView.AutoSize = true;
            this.lblDepartmentView.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentView.Location = new System.Drawing.Point(165, 157);
            this.lblDepartmentView.Name = "lblDepartmentView";
            this.lblDepartmentView.Size = new System.Drawing.Size(86, 13);
            this.lblDepartmentView.TabIndex = 18;
            this.lblDepartmentView.Text = "Department here";
            // 
            // studentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(317, 261);
            this.Controls.Add(this.lblDepartmentView);
            this.Controls.Add(this.lblStudentIDView);
            this.Controls.Add(this.lblStudentNameView);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCheckMark);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "studentMainForm";
            this.Text = "studentMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnCheckMark;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblStudentNameView;
        private System.Windows.Forms.Label lblStudentIDView;
        private System.Windows.Forms.Label lblDepartmentView;
    }
}