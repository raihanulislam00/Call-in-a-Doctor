﻿namespace Call_in_a_Doctor
{
    partial class frmDoctorsListDermatologyAndVenereology
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBackPatient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 183;
            this.label4.Text = "Dr. Jasmin Manzoor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(59, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 51);
            this.label5.TabIndex = 182;
            this.label5.Text = "MBBS, DDSc (UK), MSDc (USA)\r\nSenior Consultant and Coordinator - \r\nDermatalogy";
            // 
            // btnBackPatient
            // 
            this.btnBackPatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPatient.Location = new System.Drawing.Point(22, 15);
            this.btnBackPatient.Name = "btnBackPatient";
            this.btnBackPatient.Size = new System.Drawing.Size(67, 36);
            this.btnBackPatient.TabIndex = 181;
            this.btnBackPatient.Text = "Back";
            this.btnBackPatient.UseVisualStyleBackColor = true;
            this.btnBackPatient.Click += new System.EventHandler(this.btnBackPatient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(469, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 60);
            this.label7.TabIndex = 180;
            this.label7.Text = "Call in a Doctor";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 50);
            this.label1.TabIndex = 179;
            this.label1.Text = "Doctor\'s List - Dermatology and Venereology";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDoctorsListDermatologyAndVenereology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.homeDoctorHome1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackPatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmDoctorsListDermatologyAndVenereology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor\'s @ Dermatology and Venereology";
            this.Load += new System.EventHandler(this.frmDoctorsListDermatologyAndVenereology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}