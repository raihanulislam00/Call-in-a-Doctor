namespace Call_in_a_Doctor
{
    partial class frmAdminPatientDeleteAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPatientDeleteEmail = new System.Windows.Forms.TextBox();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnBackPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(267, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 83);
            this.label1.TabIndex = 38;
            this.label1.Text = "Delete Patient Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(457, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Email";
            // 
            // tbPatientDeleteEmail
            // 
            this.tbPatientDeleteEmail.BackColor = System.Drawing.Color.ForestGreen;
            this.tbPatientDeleteEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientDeleteEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPatientDeleteEmail.Location = new System.Drawing.Point(461, 205);
            this.tbPatientDeleteEmail.Multiline = true;
            this.tbPatientDeleteEmail.Name = "tbPatientDeleteEmail";
            this.tbPatientDeleteEmail.Size = new System.Drawing.Size(316, 32);
            this.tbPatientDeleteEmail.TabIndex = 123;
            this.tbPatientDeleteEmail.Text = "Email";
            this.tbPatientDeleteEmail.Enter += new System.EventHandler(this.tbPatientDeleteEmail_Enter);
            this.tbPatientDeleteEmail.Leave += new System.EventHandler(this.tbPatientDeleteEmail_Leave);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletePatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.ForeColor = System.Drawing.Color.Lime;
            this.btnDeletePatient.Location = new System.Drawing.Point(564, 264);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(99, 43);
            this.btnDeletePatient.TabIndex = 124;
            this.btnDeletePatient.Text = "Delete";
            this.btnDeletePatient.UseVisualStyleBackColor = false;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnBackPatient
            // 
            this.btnBackPatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPatient.Location = new System.Drawing.Point(29, 25);
            this.btnBackPatient.Name = "btnBackPatient";
            this.btnBackPatient.Size = new System.Drawing.Size(67, 36);
            this.btnBackPatient.TabIndex = 125;
            this.btnBackPatient.Text = "Back";
            this.btnBackPatient.UseVisualStyleBackColor = true;
            this.btnBackPatient.Click += new System.EventHandler(this.btnBackPatient_Click);
            // 
            // frmAdminPatientDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AdminPatientDelete;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnBackPatient);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPatientDeleteEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminPatientDeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Patient Account";
            this.Load += new System.EventHandler(this.frmAdminPatientDeleteAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPatientDeleteEmail;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnBackPatient;
    }
}