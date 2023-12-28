namespace Call_in_a_Doctor
{
    partial class frmAdminDoctorDeleteAccount
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
            this.btnBackDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDoctorDeleteEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackDoctor
            // 
            this.btnBackDoctor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDoctor.Location = new System.Drawing.Point(28, 25);
            this.btnBackDoctor.Name = "btnBackDoctor";
            this.btnBackDoctor.Size = new System.Drawing.Size(67, 36);
            this.btnBackDoctor.TabIndex = 130;
            this.btnBackDoctor.Text = "Back";
            this.btnBackDoctor.UseVisualStyleBackColor = true;
            this.btnBackDoctor.Click += new System.EventHandler(this.btnBackDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor.ForeColor = System.Drawing.Color.Lime;
            this.btnDeleteDoctor.Location = new System.Drawing.Point(563, 264);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(99, 43);
            this.btnDeleteDoctor.TabIndex = 129;
            this.btnDeleteDoctor.Text = "Delete";
            this.btnDeleteDoctor.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(456, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 127;
            this.label7.Text = "Email";
            // 
            // tbDoctorDeleteEmail
            // 
            this.tbDoctorDeleteEmail.BackColor = System.Drawing.Color.ForestGreen;
            this.tbDoctorDeleteEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorDeleteEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDoctorDeleteEmail.Location = new System.Drawing.Point(460, 205);
            this.tbDoctorDeleteEmail.Multiline = true;
            this.tbDoctorDeleteEmail.Name = "tbDoctorDeleteEmail";
            this.tbDoctorDeleteEmail.Size = new System.Drawing.Size(316, 32);
            this.tbDoctorDeleteEmail.TabIndex = 128;
            this.tbDoctorDeleteEmail.Text = "Email";
            this.tbDoctorDeleteEmail.Enter += new System.EventHandler(this.tbDoctorDeleteEmail_Enter);
            this.tbDoctorDeleteEmail.Leave += new System.EventHandler(this.tbDoctorDeleteEmail_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(266, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 83);
            this.label1.TabIndex = 126;
            this.label1.Text = "Delete Doctor Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminDoctorDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AdminPatientDelete;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnBackDoctor);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDoctorDeleteEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminDoctorDeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Doctor Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDoctorDeleteEmail;
        private System.Windows.Forms.Label label1;
    }
}