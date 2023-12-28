namespace Call_in_a_Doctor
{
    partial class frmAdminShowAdmin
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
            this.btnBackAdmin = new System.Windows.Forms.Button();
            this.dgvAdminInformation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAdmin.Location = new System.Drawing.Point(9, 9);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(67, 36);
            this.btnBackAdmin.TabIndex = 153;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // dgvAdminInformation
            // 
            this.dgvAdminInformation.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAdminInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminInformation.Location = new System.Drawing.Point(308, 149);
            this.dgvAdminInformation.Name = "dgvAdminInformation";
            this.dgvAdminInformation.RowTemplate.Height = 24;
            this.dgvAdminInformation.Size = new System.Drawing.Size(675, 433);
            this.dgvAdminInformation.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(308, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 83);
            this.label1.TabIndex = 151;
            this.label1.Text = "All Admin Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminShowAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AdminPatientUpdate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.dgvAdminInformation);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminShowAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Admin Information";
            this.Load += new System.EventHandler(this.frmAdminShowAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackAdmin;
        private System.Windows.Forms.DataGridView dgvAdminInformation;
        private System.Windows.Forms.Label label1;
    }
}