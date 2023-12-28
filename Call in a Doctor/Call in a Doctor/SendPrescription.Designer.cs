namespace Call_in_a_Doctor
{
    partial class frmPrescription
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
            this.labelPatientName = new System.Windows.Forms.Label();
            this.tbWritePrescription = new System.Windows.Forms.TextBox();
            this.frmSendPrescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.BackColor = System.Drawing.Color.Transparent;
            this.labelPatientName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.Location = new System.Drawing.Point(448, 19);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(164, 33);
            this.labelPatientName.TabIndex = 0;
            this.labelPatientName.Text = "Patient Name";
            // 
            // tbWritePrescription
            // 
            this.tbWritePrescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWritePrescription.Location = new System.Drawing.Point(89, 90);
            this.tbWritePrescription.Multiline = true;
            this.tbWritePrescription.Name = "tbWritePrescription";
            this.tbWritePrescription.Size = new System.Drawing.Size(633, 228);
            this.tbWritePrescription.TabIndex = 1;
            // 
            // frmSendPrescription
            // 
            this.frmSendPrescription.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmSendPrescription.Location = new System.Drawing.Point(359, 658);
            this.frmSendPrescription.Name = "frmSendPrescription";
            this.frmSendPrescription.Size = new System.Drawing.Size(112, 33);
            this.frmSendPrescription.TabIndex = 2;
            this.frmSendPrescription.Text = "SEND";
            this.frmSendPrescription.UseVisualStyleBackColor = false;
            this.frmSendPrescription.Click += new System.EventHandler(this.frmSendPrescription_Click);
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.PrescriptionForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 703);
            this.Controls.Add(this.frmSendPrescription);
            this.Controls.Add(this.tbWritePrescription);
            this.Controls.Add(this.labelPatientName);
            this.DoubleBuffered = true;
            this.Name = "frmPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.frmPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox tbWritePrescription;
        private System.Windows.Forms.Button frmSendPrescription;
    }
}