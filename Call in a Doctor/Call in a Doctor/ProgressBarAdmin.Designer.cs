namespace Call_in_a_Doctor
{
    partial class frmProgressBarAdmin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarAdmin = new System.Windows.Forms.ProgressBar();
            this.timerProgressBarAdmin = new System.Windows.Forms.Timer(this.components);
            this.labelLoading = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(860, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration";
            // 
            // progressBarAdmin
            // 
            this.progressBarAdmin.Location = new System.Drawing.Point(870, 505);
            this.progressBarAdmin.Name = "progressBarAdmin";
            this.progressBarAdmin.Size = new System.Drawing.Size(285, 39);
            this.progressBarAdmin.TabIndex = 1;
            // 
            // timerProgressBarAdmin
            // 
            this.timerProgressBarAdmin.Interval = 1000;
            this.timerProgressBarAdmin.Tick += new System.EventHandler(this.timerProgressBarAdmin_Tick);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.Yellow;
            this.labelLoading.Location = new System.Drawing.Point(930, 460);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(92, 29);
            this.labelLoading.TabIndex = 2;
            this.labelLoading.Text = "Loading";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(860, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 60);
            this.label7.TabIndex = 11;
            this.label7.Text = "Call in a Doctor";
            // 
            // frmProgressBarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AminProgress;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.progressBarAdmin);
            this.Controls.Add(this.label1);
            this.Name = "frmProgressBarAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Administration Form";
            this.Load += new System.EventHandler(this.frmProgressBarAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarAdmin;
        private System.Windows.Forms.Timer timerProgressBarAdmin;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label label7;
    }
}