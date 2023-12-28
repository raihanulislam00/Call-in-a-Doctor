namespace Call_in_a_Doctor
{
    partial class frmHomeAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletePatientAccount = new System.Windows.Forms.Button();
            this.btnUpdatePatientInfo = new System.Windows.Forms.Button();
            this.btnShowPatientInfo = new System.Windows.Forms.Button();
            this.tpDoctor = new System.Windows.Forms.TabPage();
            this.btnDeleteDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateDoctorInfo = new System.Windows.Forms.Button();
            this.btnShowDoctorInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnShowAdmin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tpOthers = new System.Windows.Forms.TabPage();
            this.btnShowFeedback = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.tbSearchDoctorName = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpDoctor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpOthers.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(818, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 60);
            this.label7.TabIndex = 12;
            this.label7.Text = "Call in a Doctor";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPatient);
            this.tabControl1.Controls.Add(this.tpDoctor);
            this.tabControl1.Controls.Add(this.tpAdmin);
            this.tabControl1.Controls.Add(this.tpOthers);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(766, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 483);
            this.tabControl1.TabIndex = 13;
            // 
            // tpPatient
            // 
            this.tpPatient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpPatient.Controls.Add(this.panel1);
            this.tpPatient.Controls.Add(this.btnDeletePatientAccount);
            this.tpPatient.Controls.Add(this.btnUpdatePatientInfo);
            this.tpPatient.Controls.Add(this.btnShowPatientInfo);
            this.tpPatient.Location = new System.Drawing.Point(4, 29);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(375, 450);
            this.tpPatient.TabIndex = 0;
            this.tpPatient.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 444);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 273);
            this.label1.TabIndex = 0;
            this.label1.Text = "P\r\nA\r\nT\r\nI\r\nE\r\nN\r\nT";
            // 
            // btnDeletePatientAccount
            // 
            this.btnDeletePatientAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeletePatientAccount.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatientAccount.Location = new System.Drawing.Point(170, 327);
            this.btnDeletePatientAccount.Name = "btnDeletePatientAccount";
            this.btnDeletePatientAccount.Size = new System.Drawing.Size(148, 82);
            this.btnDeletePatientAccount.TabIndex = 2;
            this.btnDeletePatientAccount.Text = "Delete \r\nAccount";
            this.btnDeletePatientAccount.UseVisualStyleBackColor = false;
            this.btnDeletePatientAccount.Click += new System.EventHandler(this.btnDeletePatientAccount_Click);
            // 
            // btnUpdatePatientInfo
            // 
            this.btnUpdatePatientInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdatePatientInfo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatientInfo.Location = new System.Drawing.Point(170, 181);
            this.btnUpdatePatientInfo.Name = "btnUpdatePatientInfo";
            this.btnUpdatePatientInfo.Size = new System.Drawing.Size(148, 82);
            this.btnUpdatePatientInfo.TabIndex = 1;
            this.btnUpdatePatientInfo.Text = "Update Information";
            this.btnUpdatePatientInfo.UseVisualStyleBackColor = false;
            this.btnUpdatePatientInfo.Click += new System.EventHandler(this.btnUpdatePatientInfo_Click);
            // 
            // btnShowPatientInfo
            // 
            this.btnShowPatientInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowPatientInfo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.btnShowPatientInfo.Location = new System.Drawing.Point(170, 37);
            this.btnShowPatientInfo.Name = "btnShowPatientInfo";
            this.btnShowPatientInfo.Size = new System.Drawing.Size(148, 85);
            this.btnShowPatientInfo.TabIndex = 0;
            this.btnShowPatientInfo.Text = "Show Information";
            this.btnShowPatientInfo.UseVisualStyleBackColor = false;
            this.btnShowPatientInfo.Click += new System.EventHandler(this.btnShowPatientInfo_Click);
            // 
            // tpDoctor
            // 
            this.tpDoctor.BackColor = System.Drawing.Color.Black;
            this.tpDoctor.Controls.Add(this.btnDeleteDeleteAccount);
            this.tpDoctor.Controls.Add(this.btnUpdateDoctorInfo);
            this.tpDoctor.Controls.Add(this.btnShowDoctorInfo);
            this.tpDoctor.Controls.Add(this.panel2);
            this.tpDoctor.Location = new System.Drawing.Point(4, 29);
            this.tpDoctor.Name = "tpDoctor";
            this.tpDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoctor.Size = new System.Drawing.Size(375, 450);
            this.tpDoctor.TabIndex = 1;
            this.tpDoctor.Text = "Doctor";
            // 
            // btnDeleteDeleteAccount
            // 
            this.btnDeleteDeleteAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeleteDeleteAccount.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDeleteAccount.Location = new System.Drawing.Point(170, 327);
            this.btnDeleteDeleteAccount.Name = "btnDeleteDeleteAccount";
            this.btnDeleteDeleteAccount.Size = new System.Drawing.Size(148, 82);
            this.btnDeleteDeleteAccount.TabIndex = 7;
            this.btnDeleteDeleteAccount.Text = "Delete \r\nAccount";
            this.btnDeleteDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteDeleteAccount.Click += new System.EventHandler(this.btnDeleteDeleteAccount_Click);
            // 
            // btnUpdateDoctorInfo
            // 
            this.btnUpdateDoctorInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateDoctorInfo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDoctorInfo.Location = new System.Drawing.Point(170, 181);
            this.btnUpdateDoctorInfo.Name = "btnUpdateDoctorInfo";
            this.btnUpdateDoctorInfo.Size = new System.Drawing.Size(148, 82);
            this.btnUpdateDoctorInfo.TabIndex = 6;
            this.btnUpdateDoctorInfo.Text = "Update Information";
            this.btnUpdateDoctorInfo.UseVisualStyleBackColor = false;
            this.btnUpdateDoctorInfo.Click += new System.EventHandler(this.btnUpdateDoctorInfo_Click);
            // 
            // btnShowDoctorInfo
            // 
            this.btnShowDoctorInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowDoctorInfo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDoctorInfo.ForeColor = System.Drawing.Color.Black;
            this.btnShowDoctorInfo.Location = new System.Drawing.Point(170, 37);
            this.btnShowDoctorInfo.Name = "btnShowDoctorInfo";
            this.btnShowDoctorInfo.Size = new System.Drawing.Size(148, 85);
            this.btnShowDoctorInfo.TabIndex = 5;
            this.btnShowDoctorInfo.Text = "Show Information";
            this.btnShowDoctorInfo.UseVisualStyleBackColor = false;
            this.btnShowDoctorInfo.Click += new System.EventHandler(this.btnShowDoctorInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 444);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 234);
            this.label2.TabIndex = 0;
            this.label2.Text = "D\r\nO\r\nC\r\nT\r\nO\r\nR";
            // 
            // tpAdmin
            // 
            this.tpAdmin.BackColor = System.Drawing.Color.Black;
            this.tpAdmin.Controls.Add(this.btnCreateAdmin);
            this.tpAdmin.Controls.Add(this.btnRemoveAdmin);
            this.tpAdmin.Controls.Add(this.btnUpdateAdmin);
            this.tpAdmin.Controls.Add(this.btnShowAdmin);
            this.tpAdmin.Controls.Add(this.panel3);
            this.tpAdmin.Location = new System.Drawing.Point(4, 29);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Size = new System.Drawing.Size(375, 450);
            this.tpAdmin.TabIndex = 2;
            this.tpAdmin.Text = "Admin";
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreateAdmin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAdmin.Location = new System.Drawing.Point(170, 25);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(148, 85);
            this.btnCreateAdmin.TabIndex = 11;
            this.btnCreateAdmin.Text = "Create Admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveAdmin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAdmin.Location = new System.Drawing.Point(170, 346);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(148, 82);
            this.btnRemoveAdmin.TabIndex = 10;
            this.btnRemoveAdmin.Text = "Remove Admin";
            this.btnRemoveAdmin.UseVisualStyleBackColor = false;
            this.btnRemoveAdmin.Click += new System.EventHandler(this.btnRemoveAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdmin.Location = new System.Drawing.Point(170, 241);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(148, 82);
            this.btnUpdateAdmin.TabIndex = 9;
            this.btnUpdateAdmin.Text = "Update Admin";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnShowAdmin
            // 
            this.btnShowAdmin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowAdmin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnShowAdmin.Location = new System.Drawing.Point(170, 134);
            this.btnShowAdmin.Name = "btnShowAdmin";
            this.btnShowAdmin.Size = new System.Drawing.Size(148, 85);
            this.btnShowAdmin.TabIndex = 8;
            this.btnShowAdmin.Text = "Show Admin";
            this.btnShowAdmin.UseVisualStyleBackColor = false;
            this.btnShowAdmin.Click += new System.EventHandler(this.btnShowAdmin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 450);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 195);
            this.label3.TabIndex = 0;
            this.label3.Text = "A\r\nD\r\nM\r\nI\r\nN";
            // 
            // tpOthers
            // 
            this.tpOthers.BackColor = System.Drawing.Color.Black;
            this.tpOthers.Controls.Add(this.btnShowFeedback);
            this.tpOthers.Controls.Add(this.label8);
            this.tpOthers.Controls.Add(this.label6);
            this.tpOthers.Controls.Add(this.label5);
            this.tpOthers.Controls.Add(this.btnSearchName);
            this.tpOthers.Controls.Add(this.tbSearchDoctorName);
            this.tpOthers.Controls.Add(this.label65);
            this.tpOthers.Controls.Add(this.panel4);
            this.tpOthers.Location = new System.Drawing.Point(4, 29);
            this.tpOthers.Name = "tpOthers";
            this.tpOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tpOthers.Size = new System.Drawing.Size(375, 450);
            this.tpOthers.TabIndex = 3;
            this.tpOthers.Text = "Others";
            // 
            // btnShowFeedback
            // 
            this.btnShowFeedback.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowFeedback.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFeedback.ForeColor = System.Drawing.Color.Black;
            this.btnShowFeedback.Location = new System.Drawing.Point(143, 323);
            this.btnShowFeedback.Name = "btnShowFeedback";
            this.btnShowFeedback.Size = new System.Drawing.Size(145, 68);
            this.btnShowFeedback.TabIndex = 33;
            this.btnShowFeedback.Text = "Show\r\nFeedback";
            this.btnShowFeedback.UseVisualStyleBackColor = false;
            this.btnShowFeedback.Click += new System.EventHandler(this.btnShowFeedback_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(143, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 27);
            this.label8.TabIndex = 32;
            this.label8.Text = "Feedback";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(153, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(131, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Appointments";
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSearchName.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.ForeColor = System.Drawing.Color.Black;
            this.btnSearchName.Location = new System.Drawing.Point(136, 161);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(91, 32);
            this.btnSearchName.TabIndex = 30;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // tbSearchDoctorName
            // 
            this.tbSearchDoctorName.AutoCompleteCustomSource.AddRange(new string[] {
            "Dr. Alim Akhtar Bhuiyan",
            "Dr. M. Ali",
            "Dr. Gulshan Ara",
            "Prof. ATM Mowladad Chowdhury",
            "Dr. Fahmida Begum",
            "Dr. Jasmin Manzoor"});
            this.tbSearchDoctorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchDoctorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearchDoctorName.Location = new System.Drawing.Point(136, 114);
            this.tbSearchDoctorName.Name = "tbSearchDoctorName";
            this.tbSearchDoctorName.Size = new System.Drawing.Size(217, 26);
            this.tbSearchDoctorName.TabIndex = 29;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Lime;
            this.label65.Location = new System.Drawing.Point(130, 79);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(158, 19);
            this.label65.TabIndex = 25;
            this.label65.Text = "Search by Dr. Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 444);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 234);
            this.label4.TabIndex = 0;
            this.label4.Text = "O\r\nT\r\nH\r\nE\r\nR\r\nS";
            // 
            // frmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AdminPatient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Name = "frmHomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home | Admin";
            this.Load += new System.EventHandler(this.frmHomeAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPatient.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpDoctor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpAdmin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpOthers.ResumeLayout(false);
            this.tpOthers.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.TabPage tpDoctor;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.Button btnShowPatientInfo;
        private System.Windows.Forms.Button btnDeletePatientAccount;
        private System.Windows.Forms.Button btnUpdatePatientInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteDeleteAccount;
        private System.Windows.Forms.Button btnUpdateDoctorInfo;
        private System.Windows.Forms.Button btnShowDoctorInfo;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnRemoveAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnShowAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpOthers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox tbSearchDoctorName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowFeedback;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}