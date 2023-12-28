namespace Call_in_a_Doctor
{
    partial class frmInPersonATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInPersonATM));
            this.btnOnlineProceed = new System.Windows.Forms.Button();
            this.linkDrATM = new System.Windows.Forms.LinkLabel();
            this.btnBackPatient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnlineProceed
            // 
            this.btnOnlineProceed.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlineProceed.Location = new System.Drawing.Point(513, 611);
            this.btnOnlineProceed.Name = "btnOnlineProceed";
            this.btnOnlineProceed.Size = new System.Drawing.Size(239, 53);
            this.btnOnlineProceed.TabIndex = 119;
            this.btnOnlineProceed.Text = "Proceed for Appointment";
            this.btnOnlineProceed.UseVisualStyleBackColor = true;
            this.btnOnlineProceed.Click += new System.EventHandler(this.btnOnlineProceed_Click);
            // 
            // linkDrATM
            // 
            this.linkDrATM.AutoSize = true;
            this.linkDrATM.Location = new System.Drawing.Point(1078, 420);
            this.linkDrATM.Name = "linkDrATM";
            this.linkDrATM.Size = new System.Drawing.Size(74, 17);
            this.linkDrATM.TabIndex = 118;
            this.linkDrATM.TabStop = true;
            this.linkDrATM.Text = "Reference";
            this.linkDrATM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDrATM_LinkClicked);
            // 
            // btnBackPatient
            // 
            this.btnBackPatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPatient.Location = new System.Drawing.Point(42, 38);
            this.btnBackPatient.Name = "btnBackPatient";
            this.btnBackPatient.Size = new System.Drawing.Size(67, 36);
            this.btnBackPatient.TabIndex = 117;
            this.btnBackPatient.Text = "Back";
            this.btnBackPatient.UseVisualStyleBackColor = true;
            this.btnBackPatient.Click += new System.EventHandler(this.btnBackPatient_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(682, 234);
            this.label4.TabIndex = 116;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 23);
            this.label6.TabIndex = 115;
            this.label6.Text = "Prof. ATM Mowladad Chowdhury";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 57);
            this.label5.TabIndex = 114;
            this.label5.Text = "FCPS, (Surgery) MRCSED, \r\nMRCPS (Glasgow), MS (Urology)\r\nUrology Surgery Speciali" +
    "st";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 42);
            this.label2.TabIndex = 113;
            this.label2.Text = "Days: Saturday to Thursday\r\nTime: 11:30 AM - 1:30 PM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "---------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 111;
            this.label1.Text = "OPD Schedule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(503, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 60);
            this.label7.TabIndex = 110;
            this.label7.Text = "Call in a Doctor";
            // 
            // frmInPersonATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.CallinaDoctorBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnOnlineProceed);
            this.Controls.Add(this.linkDrATM);
            this.Controls.Add(this.btnBackPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "frmInPersonATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prof. ATM Mowladad Chowdhury Details";
            this.Load += new System.EventHandler(this.frmInPersonATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnlineProceed;
        private System.Windows.Forms.LinkLabel linkDrATM;
        private System.Windows.Forms.Button btnBackPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}