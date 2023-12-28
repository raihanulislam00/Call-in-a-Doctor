namespace Call_in_a_Doctor
{
    partial class frmHomeDoctor
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
            this.tcProfileDoctor = new System.Windows.Forms.TabControl();
            this.tpDoctorHome = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFreeRequest = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCallinRequest = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInPersonRequest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOnlineRequest = new System.Windows.Forms.DataGridView();
            this.label36 = new System.Windows.Forms.Label();
            this.tpProfileDoctor = new System.Windows.Forms.TabPage();
            this.btnDoctorLogOut = new System.Windows.Forms.Button();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            this.btnDoctorUpdate = new System.Windows.Forms.Button();
            this.labelDoctorReg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDoctorNID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDoctorProfileAddress = new System.Windows.Forms.Label();
            this.labelDoctorProfileDOB = new System.Windows.Forms.Label();
            this.labelDoctorProfileGender = new System.Windows.Forms.Label();
            this.labelDoctorProfilePassword = new System.Windows.Forms.Label();
            this.labelDoctorProfilePhoneNumber = new System.Windows.Forms.Label();
            this.labelDoctorProfileEmail = new System.Windows.Forms.Label();
            this.labelDoctorProfileLastName = new System.Windows.Forms.Label();
            this.labelDoctorProfileFirstName = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.tpContectUs = new System.Windows.Forms.TabPage();
            this.btnFeedbackSend = new System.Windows.Forms.Button();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label72 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label71 = new System.Windows.Forms.Label();
            this.linkEmailFeedback = new System.Windows.Forms.LinkLabel();
            this.label70 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.tcProfileDoctor.SuspendLayout();
            this.tpDoctorHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallinRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInPersonRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineRequest)).BeginInit();
            this.tpProfileDoctor.SuspendLayout();
            this.tpContectUs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(490, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 60);
            this.label7.TabIndex = 14;
            this.label7.Text = "Call in a Doctor";
            // 
            // tcProfileDoctor
            // 
            this.tcProfileDoctor.Controls.Add(this.tpDoctorHome);
            this.tcProfileDoctor.Controls.Add(this.tpProfileDoctor);
            this.tcProfileDoctor.Controls.Add(this.tpContectUs);
            this.tcProfileDoctor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProfileDoctor.Location = new System.Drawing.Point(3, 126);
            this.tcProfileDoctor.Name = "tcProfileDoctor";
            this.tcProfileDoctor.SelectedIndex = 0;
            this.tcProfileDoctor.Size = new System.Drawing.Size(1236, 588);
            this.tcProfileDoctor.TabIndex = 15;
            this.tcProfileDoctor.Click += new System.EventHandler(this.tcProfileDoctor_Click);
            // 
            // tpDoctorHome
            // 
            this.tpDoctorHome.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.homeDoctorHome1;
            this.tpDoctorHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpDoctorHome.Controls.Add(this.label4);
            this.tpDoctorHome.Controls.Add(this.dgvFreeRequest);
            this.tpDoctorHome.Controls.Add(this.label3);
            this.tpDoctorHome.Controls.Add(this.dgvCallinRequest);
            this.tpDoctorHome.Controls.Add(this.label2);
            this.tpDoctorHome.Controls.Add(this.dgvInPersonRequest);
            this.tpDoctorHome.Controls.Add(this.label1);
            this.tpDoctorHome.Controls.Add(this.dgvOnlineRequest);
            this.tpDoctorHome.Controls.Add(this.label36);
            this.tpDoctorHome.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDoctorHome.Location = new System.Drawing.Point(4, 29);
            this.tpDoctorHome.Name = "tpDoctorHome";
            this.tpDoctorHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoctorHome.Size = new System.Drawing.Size(1228, 555);
            this.tpDoctorHome.TabIndex = 0;
            this.tpDoctorHome.Text = "Home";
            this.tpDoctorHome.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1134, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 76);
            this.label4.TabIndex = 34;
            this.label4.Text = "* Select a \r\nname to \r\nmake a \r\ncall";
            // 
            // dgvFreeRequest
            // 
            this.dgvFreeRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFreeRequest.Location = new System.Drawing.Point(256, 426);
            this.dgvFreeRequest.Name = "dgvFreeRequest";
            this.dgvFreeRequest.RowTemplate.Height = 24;
            this.dgvFreeRequest.Size = new System.Drawing.Size(863, 91);
            this.dgvFreeRequest.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 87);
            this.label3.TabIndex = 32;
            this.label3.Text = "Free \r\nAppointment \r\nRequest";
            // 
            // dgvCallinRequest
            // 
            this.dgvCallinRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallinRequest.Location = new System.Drawing.Point(256, 292);
            this.dgvCallinRequest.Name = "dgvCallinRequest";
            this.dgvCallinRequest.RowTemplate.Height = 24;
            this.dgvCallinRequest.Size = new System.Drawing.Size(863, 100);
            this.dgvCallinRequest.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 87);
            this.label2.TabIndex = 30;
            this.label2.Text = "Call in \r\nAppointment \r\nRequest";
            // 
            // dgvInPersonRequest
            // 
            this.dgvInPersonRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInPersonRequest.Location = new System.Drawing.Point(256, 159);
            this.dgvInPersonRequest.Name = "dgvInPersonRequest";
            this.dgvInPersonRequest.RowTemplate.Height = 24;
            this.dgvInPersonRequest.Size = new System.Drawing.Size(863, 95);
            this.dgvInPersonRequest.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 87);
            this.label1.TabIndex = 28;
            this.label1.Text = "In Person \r\nAppointment \r\nRequest";
            // 
            // dgvOnlineRequest
            // 
            this.dgvOnlineRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnlineRequest.Location = new System.Drawing.Point(256, 23);
            this.dgvOnlineRequest.Name = "dgvOnlineRequest";
            this.dgvOnlineRequest.RowTemplate.Height = 24;
            this.dgvOnlineRequest.Size = new System.Drawing.Size(863, 108);
            this.dgvOnlineRequest.TabIndex = 27;
            this.dgvOnlineRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOnlineRequest_CellContentClick);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(35, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(160, 87);
            this.label36.TabIndex = 26;
            this.label36.Text = "Online\r\nAppointment \r\nRequest";
            // 
            // tpProfileDoctor
            // 
            this.tpProfileDoctor.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.homePatientHome;
            this.tpProfileDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpProfileDoctor.Controls.Add(this.btnDoctorLogOut);
            this.tpProfileDoctor.Controls.Add(this.btnDoctorDelete);
            this.tpProfileDoctor.Controls.Add(this.btnDoctorUpdate);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorReg);
            this.tpProfileDoctor.Controls.Add(this.label9);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorNID);
            this.tpProfileDoctor.Controls.Add(this.label5);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfileAddress);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfileDOB);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfileGender);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfilePassword);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfilePhoneNumber);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfileEmail);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfileLastName);
            this.tpProfileDoctor.Controls.Add(this.labelDoctorProfileFirstName);
            this.tpProfileDoctor.Controls.Add(this.label63);
            this.tpProfileDoctor.Controls.Add(this.label62);
            this.tpProfileDoctor.Controls.Add(this.label61);
            this.tpProfileDoctor.Controls.Add(this.label60);
            this.tpProfileDoctor.Controls.Add(this.label59);
            this.tpProfileDoctor.Controls.Add(this.label58);
            this.tpProfileDoctor.Controls.Add(this.label57);
            this.tpProfileDoctor.Controls.Add(this.label56);
            this.tpProfileDoctor.Controls.Add(this.label55);
            this.tpProfileDoctor.Location = new System.Drawing.Point(4, 29);
            this.tpProfileDoctor.Name = "tpProfileDoctor";
            this.tpProfileDoctor.Size = new System.Drawing.Size(1228, 555);
            this.tpProfileDoctor.TabIndex = 2;
            this.tpProfileDoctor.Text = "Profile";
            this.tpProfileDoctor.UseVisualStyleBackColor = true;
            this.tpProfileDoctor.Click += new System.EventHandler(this.tpProfileDoctor_Click);
            // 
            // btnDoctorLogOut
            // 
            this.btnDoctorLogOut.Location = new System.Drawing.Point(1035, 257);
            this.btnDoctorLogOut.Name = "btnDoctorLogOut";
            this.btnDoctorLogOut.Size = new System.Drawing.Size(101, 41);
            this.btnDoctorLogOut.TabIndex = 39;
            this.btnDoctorLogOut.Text = "Log Out";
            this.btnDoctorLogOut.UseVisualStyleBackColor = true;
            this.btnDoctorLogOut.Click += new System.EventHandler(this.btnDoctorLogOut_Click);
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.Location = new System.Drawing.Point(1010, 401);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(159, 46);
            this.btnDoctorDelete.TabIndex = 41;
            this.btnDoctorDelete.Text = "Delete Profile";
            this.btnDoctorDelete.UseVisualStyleBackColor = true;
            this.btnDoctorDelete.Click += new System.EventHandler(this.btnDoctorDelete_Click);
            // 
            // btnDoctorUpdate
            // 
            this.btnDoctorUpdate.Location = new System.Drawing.Point(1010, 326);
            this.btnDoctorUpdate.Name = "btnDoctorUpdate";
            this.btnDoctorUpdate.Size = new System.Drawing.Size(159, 46);
            this.btnDoctorUpdate.TabIndex = 40;
            this.btnDoctorUpdate.Text = "Update Profile";
            this.btnDoctorUpdate.UseVisualStyleBackColor = true;
            this.btnDoctorUpdate.Click += new System.EventHandler(this.btnDoctorUpdate_Click);
            // 
            // labelDoctorReg
            // 
            this.labelDoctorReg.AutoSize = true;
            this.labelDoctorReg.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorReg.Location = new System.Drawing.Point(222, 347);
            this.labelDoctorReg.Name = "labelDoctorReg";
            this.labelDoctorReg.Size = new System.Drawing.Size(226, 22);
            this.labelDoctorReg.TabIndex = 38;
            this.labelDoctorReg.Text = "Your Registration Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(36, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Reg. Number:";
            // 
            // labelDoctorNID
            // 
            this.labelDoctorNID.AutoSize = true;
            this.labelDoctorNID.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorNID.Location = new System.Drawing.Point(222, 269);
            this.labelDoctorNID.Name = "labelDoctorNID";
            this.labelDoctorNID.Size = new System.Drawing.Size(160, 22);
            this.labelDoctorNID.TabIndex = 36;
            this.labelDoctorNID.Text = "Your NID Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "NID:";
            // 
            // labelDoctorProfileAddress
            // 
            this.labelDoctorProfileAddress.AutoSize = true;
            this.labelDoctorProfileAddress.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfileAddress.Location = new System.Drawing.Point(766, 192);
            this.labelDoctorProfileAddress.Name = "labelDoctorProfileAddress";
            this.labelDoctorProfileAddress.Size = new System.Drawing.Size(119, 22);
            this.labelDoctorProfileAddress.TabIndex = 34;
            this.labelDoctorProfileAddress.Text = "Your Address";
            // 
            // labelDoctorProfileDOB
            // 
            this.labelDoctorProfileDOB.AutoSize = true;
            this.labelDoctorProfileDOB.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfileDOB.Location = new System.Drawing.Point(219, 477);
            this.labelDoctorProfileDOB.Name = "labelDoctorProfileDOB";
            this.labelDoctorProfileDOB.Size = new System.Drawing.Size(161, 22);
            this.labelDoctorProfileDOB.TabIndex = 33;
            this.labelDoctorProfileDOB.Text = "Your Date of Birth";
            // 
            // labelDoctorProfileGender
            // 
            this.labelDoctorProfileGender.AutoSize = true;
            this.labelDoctorProfileGender.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfileGender.Location = new System.Drawing.Point(219, 414);
            this.labelDoctorProfileGender.Name = "labelDoctorProfileGender";
            this.labelDoctorProfileGender.Size = new System.Drawing.Size(115, 22);
            this.labelDoctorProfileGender.TabIndex = 32;
            this.labelDoctorProfileGender.Text = "Your Gender";
            // 
            // labelDoctorProfilePassword
            // 
            this.labelDoctorProfilePassword.AutoSize = true;
            this.labelDoctorProfilePassword.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfilePassword.Location = new System.Drawing.Point(221, 192);
            this.labelDoctorProfilePassword.Name = "labelDoctorProfilePassword";
            this.labelDoctorProfilePassword.Size = new System.Drawing.Size(134, 22);
            this.labelDoctorProfilePassword.TabIndex = 31;
            this.labelDoctorProfilePassword.Text = "Your Password";
            // 
            // labelDoctorProfilePhoneNumber
            // 
            this.labelDoctorProfilePhoneNumber.AutoSize = true;
            this.labelDoctorProfilePhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfilePhoneNumber.Location = new System.Drawing.Point(766, 115);
            this.labelDoctorProfilePhoneNumber.Name = "labelDoctorProfilePhoneNumber";
            this.labelDoctorProfilePhoneNumber.Size = new System.Drawing.Size(176, 22);
            this.labelDoctorProfilePhoneNumber.TabIndex = 30;
            this.labelDoctorProfilePhoneNumber.Text = "Your Phone Number";
            // 
            // labelDoctorProfileEmail
            // 
            this.labelDoctorProfileEmail.AutoSize = true;
            this.labelDoctorProfileEmail.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfileEmail.Location = new System.Drawing.Point(222, 115);
            this.labelDoctorProfileEmail.Name = "labelDoctorProfileEmail";
            this.labelDoctorProfileEmail.Size = new System.Drawing.Size(102, 22);
            this.labelDoctorProfileEmail.TabIndex = 29;
            this.labelDoctorProfileEmail.Text = "Your Email";
            // 
            // labelDoctorProfileLastName
            // 
            this.labelDoctorProfileLastName.AutoSize = true;
            this.labelDoctorProfileLastName.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfileLastName.Location = new System.Drawing.Point(776, 40);
            this.labelDoctorProfileLastName.Name = "labelDoctorProfileLastName";
            this.labelDoctorProfileLastName.Size = new System.Drawing.Size(143, 22);
            this.labelDoctorProfileLastName.TabIndex = 28;
            this.labelDoctorProfileLastName.Text = "Your Last Name";
            // 
            // labelDoctorProfileFirstName
            // 
            this.labelDoctorProfileFirstName.AutoSize = true;
            this.labelDoctorProfileFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelDoctorProfileFirstName.Location = new System.Drawing.Point(221, 40);
            this.labelDoctorProfileFirstName.Name = "labelDoctorProfileFirstName";
            this.labelDoctorProfileFirstName.Size = new System.Drawing.Size(146, 22);
            this.labelDoctorProfileFirstName.TabIndex = 27;
            this.labelDoctorProfileFirstName.Text = "Your First Name";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.ForeColor = System.Drawing.Color.Black;
            this.label63.Location = new System.Drawing.Point(189, 44);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(0, 22);
            this.label63.TabIndex = 26;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(586, 192);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(81, 22);
            this.label62.TabIndex = 25;
            this.label62.Text = "Address:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.Black;
            this.label61.Location = new System.Drawing.Point(39, 477);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(122, 22);
            this.label61.TabIndex = 24;
            this.label61.Text = "Date of Birth:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.Black;
            this.label60.Location = new System.Drawing.Point(39, 414);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(76, 22);
            this.label60.TabIndex = 23;
            this.label60.Text = "Gender:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.Color.Black;
            this.label59.Location = new System.Drawing.Point(41, 192);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(95, 22);
            this.label59.TabIndex = 22;
            this.label59.Text = "Password:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.Color.Black;
            this.label58.Location = new System.Drawing.Point(586, 115);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(137, 22);
            this.label58.TabIndex = 21;
            this.label58.Text = "Phone Number:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.Location = new System.Drawing.Point(36, 115);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(63, 22);
            this.label57.TabIndex = 20;
            this.label57.Text = "Email:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(590, 40);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(104, 22);
            this.label56.TabIndex = 19;
            this.label56.Text = "Last Name:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(38, 40);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(112, 22);
            this.label55.TabIndex = 18;
            this.label55.Text = "First Name: ";
            // 
            // tpContectUs
            // 
            this.tpContectUs.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.homeDoctorSupport;
            this.tpContectUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpContectUs.Controls.Add(this.btnFeedbackSend);
            this.tpContectUs.Controls.Add(this.rtbFeedback);
            this.tpContectUs.Controls.Add(this.label75);
            this.tpContectUs.Controls.Add(this.label74);
            this.tpContectUs.Controls.Add(this.label73);
            this.tpContectUs.Controls.Add(this.linkLabel3);
            this.tpContectUs.Controls.Add(this.label72);
            this.tpContectUs.Controls.Add(this.linkLabel2);
            this.tpContectUs.Controls.Add(this.label71);
            this.tpContectUs.Controls.Add(this.linkEmailFeedback);
            this.tpContectUs.Controls.Add(this.label70);
            this.tpContectUs.Controls.Add(this.label68);
            this.tpContectUs.Controls.Add(this.label69);
            this.tpContectUs.Location = new System.Drawing.Point(4, 29);
            this.tpContectUs.Name = "tpContectUs";
            this.tpContectUs.Padding = new System.Windows.Forms.Padding(3);
            this.tpContectUs.Size = new System.Drawing.Size(1228, 555);
            this.tpContectUs.TabIndex = 1;
            this.tpContectUs.Text = "Contact Us";
            this.tpContectUs.UseVisualStyleBackColor = true;
            // 
            // btnFeedbackSend
            // 
            this.btnFeedbackSend.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFeedbackSend.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSend.Location = new System.Drawing.Point(1007, 271);
            this.btnFeedbackSend.Name = "btnFeedbackSend";
            this.btnFeedbackSend.Size = new System.Drawing.Size(105, 43);
            this.btnFeedbackSend.TabIndex = 47;
            this.btnFeedbackSend.Text = "SEND";
            this.btnFeedbackSend.UseVisualStyleBackColor = false;
            this.btnFeedbackSend.Click += new System.EventHandler(this.btnFeedbackSend_Click);
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbFeedback.Location = new System.Drawing.Point(630, 140);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(482, 125);
            this.rtbFeedback.TabIndex = 46;
            this.rtbFeedback.Text = "";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(626, 84);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(503, 38);
            this.label75.TabIndex = 45;
            this.label75.Text = "We would love to hear your thoughts, suggestions, concerns or problems\r\nwith anyt" +
    "hing so that we can imporove!";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(626, 62);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(256, 22);
            this.label74.TabIndex = 44;
            this.label74.Text = "-----------------------------------------";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.OrangeRed;
            this.label73.Location = new System.Drawing.Point(654, 28);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(199, 35);
            this.label73.TabIndex = 43;
            this.label73.Text = "Feedback Form";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(146, 183);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(142, 19);
            this.linkLabel3.TabIndex = 42;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "+880-1303132435";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(42, 179);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(84, 23);
            this.label72.TabIndex = 41;
            this.label72.Text = "Text us at";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(146, 144);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(142, 19);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "+880-1828675754";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(42, 144);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(82, 23);
            this.label71.TabIndex = 39;
            this.label71.Text = "Call us at";
            // 
            // linkEmailFeedback
            // 
            this.linkEmailFeedback.AutoSize = true;
            this.linkEmailFeedback.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEmailFeedback.Location = new System.Drawing.Point(148, 108);
            this.linkEmailFeedback.Name = "linkEmailFeedback";
            this.linkEmailFeedback.Size = new System.Drawing.Size(140, 19);
            this.linkEmailFeedback.TabIndex = 38;
            this.linkEmailFeedback.TabStop = true;
            this.linkEmailFeedback.Text = "support@cid.com";
            this.linkEmailFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmailFeedback_LinkClicked);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(29, 66);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(298, 22);
            this.label70.TabIndex = 37;
            this.label70.Text = "------------------------------------------------";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(42, 106);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(95, 23);
            this.label68.TabIndex = 36;
            this.label68.Text = "Email us at";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label69.Location = new System.Drawing.Point(40, 32);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(262, 35);
            this.label69.TabIndex = 35;
            this.label69.Text = "We\'re Here to Help";
            // 
            // frmHomeDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.CallinaDoctorBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.tcProfileDoctor);
            this.Controls.Add(this.label7);
            this.Name = "frmHomeDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home | Doctor";
            this.Load += new System.EventHandler(this.frmHomeDoctor_Load);
            this.tcProfileDoctor.ResumeLayout(false);
            this.tpDoctorHome.ResumeLayout(false);
            this.tpDoctorHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallinRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInPersonRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineRequest)).EndInit();
            this.tpProfileDoctor.ResumeLayout(false);
            this.tpProfileDoctor.PerformLayout();
            this.tpContectUs.ResumeLayout(false);
            this.tpContectUs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tcProfileDoctor;
        private System.Windows.Forms.TabPage tpDoctorHome;
        private System.Windows.Forms.TabPage tpContectUs;
        private System.Windows.Forms.DataGridView dgvOnlineRequest;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvInPersonRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCallinRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFreeRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFeedbackSend;
        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.LinkLabel linkEmailFeedback;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TabPage tpProfileDoctor;
        private System.Windows.Forms.Label labelDoctorReg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDoctorNID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDoctorProfileAddress;
        private System.Windows.Forms.Label labelDoctorProfileDOB;
        private System.Windows.Forms.Label labelDoctorProfileGender;
        private System.Windows.Forms.Label labelDoctorProfilePassword;
        private System.Windows.Forms.Label labelDoctorProfilePhoneNumber;
        private System.Windows.Forms.Label labelDoctorProfileEmail;
        private System.Windows.Forms.Label labelDoctorProfileLastName;
        private System.Windows.Forms.Label labelDoctorProfileFirstName;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnDoctorLogOut;
        private System.Windows.Forms.Button btnDoctorDelete;
        private System.Windows.Forms.Button btnDoctorUpdate;
    }
}