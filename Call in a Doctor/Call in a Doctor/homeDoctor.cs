using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Call_in_a_Doctor
{
    public partial class frmHomeDoctor : Form
    {
        public frmHomeDoctor()
        {
            InitializeComponent();
        }

        public string em;
        public frmHomeDoctor(string email)
        {
            InitializeComponent();
            this.em = email;
        }

        private void frmHomeDoctor_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            /// Online Appointment display
            //Initiating SQL connection
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = DELL-VOSTRO-556; database = OnlineAppoinment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (this.em == "dr.alimakhtarbhuiyan@gmail.com")
            {
                string query1 = "Select * from Dr_Alim_Akhtar_Bhuiyan";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if(this.em == "dr.m.ali@gmail.com")
            {
                string query1 = "Select * from Dr_M_Ali";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (this.em == "dr.gulshanara@gmail.com")
            {
                string query1 = "Select * from Dr_Gulshan_Ara";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (this.em == "prof.atmmowladadchowdhury@gmail.com")
            {
                string query1 = "Select * from Dr_ATM";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (this.em == "dr.fahmidabegum@gmail.com")
            {
                string query1 = "Select * from Dr_Fahmida_Begum";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (this.em == "dr.jasminmanzoor@gmail.com")
            {
                string query1 = "Select * from Dr_Jasmin_Manzoor";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }



            /// In Person Appointment display
            //Initiating SQL connection
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "data source = DELL-VOSTRO-556; database = InPersonAppointment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (this.em == "dr.alimakhtarbhuiyan@gmail.com")
            {
                string query1 = "Select * from Dr_Alim_Akhtar_Bhuiyan";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (this.em == "dr.m.ali@gmail.com")
            {
                string query1 = "Select * from Dr_M_Ali";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (this.em == "dr.gulshanara@gmail.com")
            {
                string query1 = "Select * from Dr_Gulshan_Ara";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (this.em == "prof.atmmowladadchowdhury@gmail.com")
            {
                string query1 = "Select * from Dr_ATM";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (this.em == "dr.fahmidabegum@gmail.com")
            {
                string query1 = "Select * from Dr_Fahmida_Begum";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (this.em == "dr.jasminmanzoor@gmail.com")
            {
                string query1 = "Select * from Dr_Jasmin_Manzoor";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }




            /// Call in Appointment display
            //Initiating SQL connection
            SqlConnection con3 = new SqlConnection();
            con3.ConnectionString = "data source = DELL-VOSTRO-556; database = CallinAppointment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (this.em == "dr.m.ali@gmail.com")
            {
                string query1 = "Select * from Dr_M_Ali";

                SqlCommand command1 = new SqlCommand(query1, con3);

                // opening the connection
                con3.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvCallinRequest.DataSource = source1;
            }
            else if (this.em == "dr.gulshanara@gmail.com")
            {
                string query1 = "Select * from Dr_Gulshan_Ara";

                SqlCommand command1 = new SqlCommand(query1, con3);

                // opening the connection
                con3.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvCallinRequest.DataSource = source1;
            }




            /// Free Appointment display
            //Initiating SQL connection
            SqlConnection con4 = new SqlConnection();
            con4.ConnectionString = "data source = DELL-VOSTRO-556; database = FreeAppointment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (this.em == "dr.alimakhtarbhuiyan@gmail.com")
            {
                string query1 = "Select * from Dr_Alim_Akhtar_Bhuiyan";

                SqlCommand command1 = new SqlCommand(query1, con4);

                // opening the connection
                con4.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvFreeRequest.DataSource = source1;
            }
        }

        private void btnFeedbackSend_Click(object sender, EventArgs e)
        {
            //Initiating SQL connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DELL-VOSTRO-556; database = Feedback_CID; " +
                                    "integrated security = SSPI";

            //Assigning Values
            string feedback = rtbFeedback.Text;

            // Generating SQL query
            string sql = "INSERT INTO feedbackList(Email,Feedback)" +
                          "VALUES(" + "'" + this.em + "'" + ","
                                    + "'" + feedback + "'"
                                    + ")";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                // Opening the connection
                con.Open();
                // cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                // Disconnect
                con.Close();
            }
            MessageBox.Show("Thank You! \nWe will try to reach you as soon as possible. \nStay Connected!");
        }

        private void dgvOnlineRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOnlineRequest.Rows[e.RowIndex];
                string patientName = row.Cells["Patient's Name"].Value.ToString();
                string patientEmail = row.Cells["Patient's Email"].Value.ToString();
                frmCallingPatient fCallPatient = new frmCallingPatient(patientName,patientEmail,this.em);
                fCallPatient.Show();
                frmShowPrescription fSP = new frmShowPrescription(patientEmail);
            }
        }

        private void tpProfileDoctor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                    "integrated security = SSPI";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from regDoctor where email=" + "'" + this.em + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                labelDoctorProfileFirstName.Text = da.GetValue(1).ToString();
                labelDoctorProfileLastName.Text = da.GetValue(2).ToString();
                labelDoctorProfileEmail.Text = da.GetValue(3).ToString();
                labelDoctorProfilePhoneNumber.Text = da.GetValue(4).ToString();
                labelDoctorProfilePassword.Text = da.GetValue(5).ToString();
                labelDoctorNID.Text = da.GetValue(6).ToString();
                labelDoctorReg.Text = da.GetValue(7).ToString();
                labelDoctorProfileGender.Text = da.GetValue(8).ToString();
                labelDoctorProfileDOB.Text = da.GetValue(9).ToString();
                labelDoctorProfileAddress.Text = da.GetValue(10).ToString();
            }
            con.Close();
        }

        private void tcProfileDoctor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                    "integrated security = SSPI";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from regDoctor where email=" + "'" + this.em + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                labelDoctorProfileFirstName.Text = da.GetValue(1).ToString();
                labelDoctorProfileLastName.Text = da.GetValue(2).ToString();
                labelDoctorProfileEmail.Text = da.GetValue(3).ToString();
                labelDoctorProfilePhoneNumber.Text = da.GetValue(4).ToString();
                labelDoctorProfilePassword.Text = da.GetValue(5).ToString();
                labelDoctorNID.Text = da.GetValue(6).ToString();
                labelDoctorReg.Text = da.GetValue(7).ToString();
                labelDoctorProfileGender.Text = da.GetValue(8).ToString();
                labelDoctorProfileDOB.Text = da.GetValue(9).ToString();
                labelDoctorProfileAddress.Text = da.GetValue(10).ToString();
            }
            con.Close();
        }

        private void btnDoctorUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateProfileDoctor fDoctorUPD = new frmUpdateProfileDoctor(this.em);
            fDoctorUPD.Show();
        }

        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";

                string sql = "delete from regDoctor where email='" + this.em + "'";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Opening the connection
                    con.Open();
                    // cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Disconnect
                    con.Close();
                }

                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = "data source = DELL-VOSTRO-556; database = Login_CID; " +
                                        "integrated security = SSPI";

                string sql2 = "delete from loginDoctor where email='" + this.em + "'";

                using (SqlCommand cmd = new SqlCommand(sql2, con2))
                {
                    // Opening the connection
                    con2.Open();
                    // cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Disconnect
                    con2.Close();
                }


                MessageBox.Show("We Wish You to Come Back\nAccount Deleted Successfully!");
                this.Close();
            }
        }

        private void linkEmailFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&source=mailto&to=atanu.saha415@gmail.com");
        }

        private void btnDoctorLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
