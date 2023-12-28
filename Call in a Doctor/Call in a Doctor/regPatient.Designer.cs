namespace Call_in_a_Doctor
{
    partial class frmRegPatient
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatientFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatientLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPatientGenderMale = new System.Windows.Forms.RadioButton();
            this.rbPatientGenderFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPatientEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbPatientAddress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPatientPassword = new System.Windows.Forms.TextBox();
            this.btnRegPatient = new System.Windows.Forms.Button();
            this.btnBackPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(782, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 60);
            this.label7.TabIndex = 11;
            this.label7.Text = "Call in a Doctor";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Patient Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPatientFirstName
            // 
            this.tbPatientFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPatientFirstName.Location = new System.Drawing.Point(31, 46);
            this.tbPatientFirstName.Name = "tbPatientFirstName";
            this.tbPatientFirstName.Size = new System.Drawing.Size(200, 30);
            this.tbPatientFirstName.TabIndex = 13;
            this.tbPatientFirstName.Text = "First Name";
            this.tbPatientFirstName.Enter += new System.EventHandler(this.tbPatientFirstName_Enter);
            this.tbPatientFirstName.Leave += new System.EventHandler(this.tbPatientFirstName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // tbPatientLastName
            // 
            this.tbPatientLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPatientLastName.Location = new System.Drawing.Point(260, 46);
            this.tbPatientLastName.Name = "tbPatientLastName";
            this.tbPatientLastName.Size = new System.Drawing.Size(200, 30);
            this.tbPatientLastName.TabIndex = 15;
            this.tbPatientLastName.Text = "Last Name";
            this.tbPatientLastName.Enter += new System.EventHandler(this.tbPatientSecondName_Enter);
            this.tbPatientLastName.Leave += new System.EventHandler(this.tbPatientSecondName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender";
            // 
            // rbPatientGenderMale
            // 
            this.rbPatientGenderMale.AutoSize = true;
            this.rbPatientGenderMale.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatientGenderMale.Location = new System.Drawing.Point(342, 150);
            this.rbPatientGenderMale.Name = "rbPatientGenderMale";
            this.rbPatientGenderMale.Size = new System.Drawing.Size(69, 24);
            this.rbPatientGenderMale.TabIndex = 17;
            this.rbPatientGenderMale.TabStop = true;
            this.rbPatientGenderMale.Text = "Male";
            this.rbPatientGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbPatientGenderFemale
            // 
            this.rbPatientGenderFemale.AutoSize = true;
            this.rbPatientGenderFemale.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatientGenderFemale.Location = new System.Drawing.Point(426, 150);
            this.rbPatientGenderFemale.Name = "rbPatientGenderFemale";
            this.rbPatientGenderFemale.Size = new System.Drawing.Size(90, 24);
            this.rbPatientGenderFemale.TabIndex = 18;
            this.rbPatientGenderFemale.TabStop = true;
            this.rbPatientGenderFemale.Text = "Female";
            this.rbPatientGenderFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // tbPatientEmail
            // 
            this.tbPatientEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPatientEmail.Location = new System.Drawing.Point(31, 119);
            this.tbPatientEmail.Name = "tbPatientEmail";
            this.tbPatientEmail.Size = new System.Drawing.Size(277, 30);
            this.tbPatientEmail.TabIndex = 20;
            this.tbPatientEmail.Text = "someone@example.com";
            this.tbPatientEmail.Enter += new System.EventHandler(this.tbPatientEmail_Enter);
            this.tbPatientEmail.Leave += new System.EventHandler(this.tbPatientEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone Number";
            // 
            // tbPatientPhoneNumber
            // 
            this.tbPatientPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientPhoneNumber.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPatientPhoneNumber.Location = new System.Drawing.Point(31, 189);
            this.tbPatientPhoneNumber.Name = "tbPatientPhoneNumber";
            this.tbPatientPhoneNumber.Size = new System.Drawing.Size(277, 30);
            this.tbPatientPhoneNumber.TabIndex = 22;
            this.tbPatientPhoneNumber.Text = "Phone Number";
            this.tbPatientPhoneNumber.Enter += new System.EventHandler(this.tbPatientPhoneNumber_Enter);
            this.tbPatientPhoneNumber.Leave += new System.EventHandler(this.tbPatientPhoneNumber_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date of Birth";
            // 
            // dtpPatientDOB
            // 
            this.dtpPatientDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPatientDOB.Location = new System.Drawing.Point(341, 220);
            this.dtpPatientDOB.Name = "dtpPatientDOB";
            this.dtpPatientDOB.Size = new System.Drawing.Size(224, 26);
            this.dtpPatientDOB.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Address";
            // 
            // rtbPatientAddress
            // 
            this.rtbPatientAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPatientAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbPatientAddress.Location = new System.Drawing.Point(32, 335);
            this.rtbPatientAddress.Name = "rtbPatientAddress";
            this.rtbPatientAddress.Size = new System.Drawing.Size(240, 81);
            this.rtbPatientAddress.TabIndex = 26;
            this.rtbPatientAddress.Text = "Address";
            this.rtbPatientAddress.Enter += new System.EventHandler(this.rtbPatientAddress_Enter);
            this.rtbPatientAddress.Leave += new System.EventHandler(this.rtbPatientAddress_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Password";
            // 
            // tbPatientPassword
            // 
            this.tbPatientPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPatientPassword.Location = new System.Drawing.Point(32, 263);
            this.tbPatientPassword.Name = "tbPatientPassword";
            this.tbPatientPassword.PasswordChar = '*';
            this.tbPatientPassword.Size = new System.Drawing.Size(277, 30);
            this.tbPatientPassword.TabIndex = 28;
            this.tbPatientPassword.Text = "Password";
            this.tbPatientPassword.Enter += new System.EventHandler(this.tbPatientPassword_Enter);
            this.tbPatientPassword.Leave += new System.EventHandler(this.tbPatientPassword_Leave);
            // 
            // btnRegPatient
            // 
            this.btnRegPatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegPatient.Location = new System.Drawing.Point(869, 648);
            this.btnRegPatient.Name = "btnRegPatient";
            this.btnRegPatient.Size = new System.Drawing.Size(99, 43);
            this.btnRegPatient.TabIndex = 29;
            this.btnRegPatient.Text = "Register";
            this.btnRegPatient.UseVisualStyleBackColor = true;
            this.btnRegPatient.Click += new System.EventHandler(this.btnRegPatient_Click);
            // 
            // btnBackPatient
            // 
            this.btnBackPatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPatient.Location = new System.Drawing.Point(28, 12);
            this.btnBackPatient.Name = "btnBackPatient";
            this.btnBackPatient.Size = new System.Drawing.Size(67, 36);
            this.btnBackPatient.TabIndex = 56;
            this.btnBackPatient.Text = "Back";
            this.btnBackPatient.UseVisualStyleBackColor = true;
            this.btnBackPatient.Click += new System.EventHandler(this.btnBackPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.rbPatientGenderFemale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbPatientGenderMale);
            this.panel1.Controls.Add(this.rtbPatientAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbPatientPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpPatientDOB);
            this.panel1.Controls.Add(this.tbPatientLastName);
            this.panel1.Controls.Add(this.tbPatientFirstName);
            this.panel1.Controls.Add(this.tbPatientPhoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPatientEmail);
            this.panel1.Location = new System.Drawing.Point(609, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 441);
            this.panel1.TabIndex = 57;
            // 
            // frmRegPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.regPatient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackPatient);
            this.Controls.Add(this.btnRegPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.Name = "frmRegPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.frmRegPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatientFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPatientLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPatientGenderMale;
        private System.Windows.Forms.RadioButton rbPatientGenderFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPatientEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPatientPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPatientDOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbPatientAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPatientPassword;
        private System.Windows.Forms.Button btnRegPatient;
        private System.Windows.Forms.Button btnBackPatient;
        private System.Windows.Forms.Panel panel1;
    }
}