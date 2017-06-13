namespace UniversityRegistrationSystem
{
    partial class statusSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statusSelectionForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnContinueStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student",
            "Lecturer",
            "Staff"});
            this.comboBox1.Location = new System.Drawing.Point(79, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(46, 32);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(209, 67);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 1;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright2.Location = new System.Drawing.Point(153, 291);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 8;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Location = new System.Drawing.Point(106, 286);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(51, 13);
            this.lblCopyright1.TabIndex = 7;
            this.lblCopyright1.Text = "Copyright";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(76, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Please select your status";
            // 
            // btnContinueStatus
            // 
            this.btnContinueStatus.Location = new System.Drawing.Point(107, 203);
            this.btnContinueStatus.Name = "btnContinueStatus";
            this.btnContinueStatus.Size = new System.Drawing.Size(75, 23);
            this.btnContinueStatus.TabIndex = 10;
            this.btnContinueStatus.Text = "Continue";
            this.btnContinueStatus.UseVisualStyleBackColor = true;
            // 
            // statusSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(304, 307);
            this.Controls.Add(this.btnContinueStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Controls.Add(this.comboBox1);
            this.Name = "statusSelectionForm";
            this.Text = "statusSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnContinueStatus;
    }
}