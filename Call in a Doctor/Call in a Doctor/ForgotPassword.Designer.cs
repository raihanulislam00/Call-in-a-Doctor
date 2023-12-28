namespace Call_in_a_Doctor
{
    partial class frmForgotPassword
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbForgotPasswordEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnForgotPasswordSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(391, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 51);
            this.label7.TabIndex = 11;
            this.label7.Text = "Call in a Doctor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.ForgotPassword1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 240);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Can\'t remember password? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "-----------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(278, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter your registered email id and we\'ll help you out.";
            // 
            // tbForgotPasswordEmail
            // 
            this.tbForgotPasswordEmail.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForgotPasswordEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbForgotPasswordEmail.Location = new System.Drawing.Point(306, 240);
            this.tbForgotPasswordEmail.Multiline = true;
            this.tbForgotPasswordEmail.Name = "tbForgotPasswordEmail";
            this.tbForgotPasswordEmail.Size = new System.Drawing.Size(395, 38);
            this.tbForgotPasswordEmail.TabIndex = 16;
            this.tbForgotPasswordEmail.Text = "Email";
            this.tbForgotPasswordEmail.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tbForgotPasswordEmail.Leave += new System.EventHandler(this.tbForgotPasswordEmail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 17;
            // 
            // btnForgotPasswordSend
            // 
            this.btnForgotPasswordSend.BackColor = System.Drawing.Color.CadetBlue;
            this.btnForgotPasswordSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPasswordSend.Location = new System.Drawing.Point(462, 300);
            this.btnForgotPasswordSend.Name = "btnForgotPasswordSend";
            this.btnForgotPasswordSend.Size = new System.Drawing.Size(89, 40);
            this.btnForgotPasswordSend.TabIndex = 18;
            this.btnForgotPasswordSend.Text = "SEND";
            this.btnForgotPasswordSend.UseVisualStyleBackColor = false;
            this.btnForgotPasswordSend.Click += new System.EventHandler(this.btnForgotPasswordSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.homePatientOnline1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnForgotPasswordSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbForgotPasswordEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbForgotPasswordEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnForgotPasswordSend;
        private System.Windows.Forms.Label label4;
    }
}