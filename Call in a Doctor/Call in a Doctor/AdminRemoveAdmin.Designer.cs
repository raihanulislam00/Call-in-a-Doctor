namespace Call_in_a_Doctor
{
    partial class frmAdminRemoveAdmin
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
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdminRemoveUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAdmin.Location = new System.Drawing.Point(21, 27);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(67, 36);
            this.btnBackAdmin.TabIndex = 130;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveAdmin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAdmin.ForeColor = System.Drawing.Color.Lime;
            this.btnRemoveAdmin.Location = new System.Drawing.Point(556, 266);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(99, 43);
            this.btnRemoveAdmin.TabIndex = 129;
            this.btnRemoveAdmin.Text = "Remove";
            this.btnRemoveAdmin.UseVisualStyleBackColor = false;
            this.btnRemoveAdmin.Click += new System.EventHandler(this.btnRemoveAdmin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(449, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 127;
            this.label7.Text = "Username";
            // 
            // tbAdminRemoveUsername
            // 
            this.tbAdminRemoveUsername.BackColor = System.Drawing.Color.ForestGreen;
            this.tbAdminRemoveUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdminRemoveUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAdminRemoveUsername.Location = new System.Drawing.Point(453, 207);
            this.tbAdminRemoveUsername.Multiline = true;
            this.tbAdminRemoveUsername.Name = "tbAdminRemoveUsername";
            this.tbAdminRemoveUsername.Size = new System.Drawing.Size(316, 32);
            this.tbAdminRemoveUsername.TabIndex = 128;
            this.tbAdminRemoveUsername.Text = "Username";
            this.tbAdminRemoveUsername.Enter += new System.EventHandler(this.tbAdminRemoveUsername_Enter);
            this.tbAdminRemoveUsername.Leave += new System.EventHandler(this.tbAdminRemoveUsername_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(259, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 83);
            this.label1.TabIndex = 126;
            this.label1.Text = "Remove Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminRemoveAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AdminPatientDelete;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.btnRemoveAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAdminRemoveUsername);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminRemoveAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRemoveAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackAdmin;
        private System.Windows.Forms.Button btnRemoveAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdminRemoveUsername;
        private System.Windows.Forms.Label label1;
    }
}