using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Call_in_a_Doctor
{
    public partial class frmHomePatient : Form
    {
        public frmHomePatient()
        {
            InitializeComponent();
        }

        public string em;
        public frmHomePatient(string email)
        {
            InitializeComponent();
            this.em = email;
        }

        private void frmHomePatient_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            /// ICU display
            //Initiating SQL connection
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = DELL-VOSTRO-556; database = AvailableICU_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query
            string query1 = "Select [Hospital Name],[Available Seats] from availableSeat";

            SqlCommand command1 = new SqlCommand(query1, con1);

            // opening the connection
            con1.Open();

            // Execute SQL query
            SqlDataReader reader1 = command1.ExecuteReader();

            // Binding reader to source
            BindingSource source1 = new BindingSource();
            source1.DataSource = reader1;


            // Binding source to grid view control
            dgvICU.DataSource = source1;
        }

        private void btnOnlineShams_Click(object sender, EventArgs e)
        {
            frmOnlineAlim fOnlineAlim = new frmOnlineAlim();
            fOnlineAlim.Show();
        }

        private void btnOnlineAli_Click(object sender, EventArgs e)
        {
            frmOnlineAli fOnlineAli = new frmOnlineAli();
            fOnlineAli.Show();
        }

        private void btnOnlineGulshan_Click(object sender, EventArgs e)
        {
            frmOnlineGulshan fOnlineGushan = new frmOnlineGulshan();
            fOnlineGushan.Show();
        }

        private void btnOnlineATM_Click(object sender, EventArgs e)
        {
            frmOnlineATM fOnlineATM = new frmOnlineATM();
            fOnlineATM.Show();
        }

        private void btnPnlineFahmida_Click(object sender, EventArgs e)
        {
            frmOnlineFahmida fOnlineFahmida = new frmOnlineFahmida();
            fOnlineFahmida.Show();
        }

        private void btnOnlineJasmin_Click(object sender, EventArgs e)
        {
            frmOnlineJasmin fOnlineJasmin = new frmOnlineJasmin();
            fOnlineJasmin.Show();
        }

        private void btnInPersonAli_Click(object sender, EventArgs e)
        {
            frmInPersonDrAli fAli = new frmInPersonDrAli();
            fAli.Show();
        }

        private void btnInPersonAlim_Click(object sender, EventArgs e)
        {
            frmInPersonAlim fAlim = new frmInPersonAlim();
            fAlim.Show();
        }

        private void btnlInPersonATM_Click(object sender, EventArgs e)
        {
            frmInPersonATM fATM = new frmInPersonATM();
            fATM.Show();
        }

        private void btnInPersonFahmida_Click(object sender, EventArgs e)
        {
            frmInPersonFahmida fFahmida = new frmInPersonFahmida();
            fFahmida.Show();
        }

        private void btnInPersonGulshan_Click(object sender, EventArgs e)
        {
            frmInPersonDrGulshan fGulshan = new frmInPersonDrGulshan();
            fGulshan.Show();
        }

        private void btnInPersonJasmin_Click(object sender, EventArgs e)
        {
            frmInPersonDrJasmin fJasmin = new frmInPersonDrJasmin();
            fJasmin.Show();
        }

        private void btnCallinAli_Click(object sender, EventArgs e)
        {
            frmCallinDrAli fAli = new frmCallinDrAli();
            fAli.Show();
        }

        private void btnCallinGulshan_Click(object sender, EventArgs e)
        {
            frmCallinDrGulshan fGulshan = new frmCallinDrGulshan();
            fGulshan.Show();
        }

        private void btnFreeAlim_Click(object sender, EventArgs e)
        {
            frmFreeAlim fAlim = new frmFreeAlim();
            fAlim.Show();
        }

        private void linkHomeBlog1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://findoutadoctor.com/fever-treatment/");
        }

        private void linkHomeBlog2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://findoutadoctor.com/a-helpful-healthy-eating-strategy/");
        }

        private void linkHomeBlog3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://findoutadoctor.com/migraine-or-headache-pain-and-food/");
        }

        private void btnPatientLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpProfile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                    "integrated security = SSPI";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from regPatient where email=" + "'" + this.em + "'",con);
            SqlDataReader da = cmd.ExecuteReader();
            while(da.Read())
            {
                labelPatientProfileFirstName.Text = da.GetValue(1).ToString();
                labelPatientProfileLastName.Text = da.GetValue(2).ToString();
                labelPatientProfileEmail.Text = da.GetValue(3).ToString();
                labelPatientProfilePhoneNumber.Text = da.GetValue(4).ToString();
                labelPatientProfilePassword.Text = da.GetValue(5).ToString();
                labelPatientProfileGender.Text = da.GetValue(6).ToString();
                labelPatientProfileDOB.Text = da.GetValue(7).ToString();
                labelPatientProfileAddress.Text = da.GetValue(8).ToString();
            }
            con.Close();
        }

        private void tcProfile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                    "integrated security = SSPI";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from regPatient where email=" + "'" + this.em + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                labelPatientProfileFirstName.Text = da.GetValue(1).ToString();
                labelPatientProfileLastName.Text = da.GetValue(2).ToString();
                labelPatientProfileEmail.Text = da.GetValue(3).ToString();
                labelPatientProfilePhoneNumber.Text = da.GetValue(4).ToString();
                labelPatientProfilePassword.Text = da.GetValue(5).ToString();
                labelPatientProfileGender.Text = da.GetValue(6).ToString();
                labelPatientProfileDOB.Text = da.GetValue(7).ToString();
                labelPatientProfileAddress.Text = da.GetValue(8).ToString();
            }
            con.Close();
        }

        private void btnPatientUpdate_Click(object sender, EventArgs e)
        {
            frmPatientProfileUpdate fPatientUPD = new frmPatientProfileUpdate(this.em);
            fPatientUPD.Show();
        }

        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";

                string sql = "delete from regPatient where email='" + this.em + "'";

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

                string sql2 = "delete from loginPatient where email='" + this.em + "'";

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

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if(tbSearchDoctorName.Text == "Dr. M. Ali")
            {
                frmSearchDrAli fAli = new frmSearchDrAli();
                fAli.Show();
            }
            else if (tbSearchDoctorName.Text == "Dr. Alim Akhtar Bhuiyan")
            {
                frmSearchDrAlim fAlim = new frmSearchDrAlim();
                fAlim.Show();
            }
            else if (tbSearchDoctorName.Text == "Prof. ATM Mowladad Chowdhury")
            {
                frmSearchDrATM fATM = new frmSearchDrATM();
                fATM.Show();
            }
            else if (tbSearchDoctorName.Text == "Dr. Fahmida Begum")
            {
                frmSearchDrFahmida fFahmida = new frmSearchDrFahmida();
                fFahmida.Show();
            }
            else if (tbSearchDoctorName.Text == "Dr. Gulshan Ara")
            {
                frmSearchDrGulshan fGulshan = new frmSearchDrGulshan();
                fGulshan.Show();
            }
            else if (tbSearchDoctorName.Text == "Dr. Jasmin Manzoor")
            {
                frmSearchDrJasmin fJasmin = new frmSearchDrJasmin();
                fJasmin.Show();
            }
            else
            {
                MessageBox.Show("Sorry! Doctor is not in our list :(");
            }
        }

        private void btnSearchCatagory_Click(object sender, EventArgs e)
        {
            if(tbSearchDoctorCatagory.Text == "Neurology")
            {
                frmDoctorsListNeurology fNeuro = new frmDoctorsListNeurology();
                fNeuro.Show();
            }
            else if (tbSearchDoctorCatagory.Text == "Orthopedics")
            {
                frmDoctorsListOrthopedics fOrtho = new frmDoctorsListOrthopedics();
                fOrtho.Show();
            }
            else if (tbSearchDoctorCatagory.Text == "Obstetrics and Gynaecology")
            {
                frmDoctorsListObstetricsAndGynaecology fGyn = new frmDoctorsListObstetricsAndGynaecology();
                fGyn.Show();
            }
            else if (tbSearchDoctorCatagory.Text == "Urology")
            {
                frmDoctorsListUrology fUro = new frmDoctorsListUrology();
                fUro.Show();
            }
            else if (tbSearchDoctorCatagory.Text == "Nephrology")
            {
                frmDoctorsListNephrology fNeph = new frmDoctorsListNephrology();
                fNeph.Show();
            }
            else if (tbSearchDoctorCatagory.Text == "Dermatology and Venereology")
            {
                frmDoctorsListDermatologyAndVenereology fDerm = new frmDoctorsListDermatologyAndVenereology();
                fDerm.Show();
            }
            else
            {
                MessageBox.Show("Sorry! Catagory is not in our list :(");
            }
        }

        private void dgvICU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvICU.Rows[e.RowIndex];
                string hospitalName = row.Cells["Hospital Name"].Value.ToString();

                if(hospitalName == "Bangladesh Specialized Hospital")
                {
                    frmBangladeshSpecializedHospitalICUPayment fBSH = new frmBangladeshSpecializedHospitalICUPayment();
                    fBSH.Show();
                }
                else if(hospitalName == "Delta Hospital Limited")
                {
                    frmDeltaHospitalLimitedICUPayment fDHL = new frmDeltaHospitalLimitedICUPayment();
                    fDHL.Show();
                }
                else if(hospitalName == "SQUARE Hospital Ltd.")
                {
                    frmSQUAREHospitalLtdICUPayment fSHL = new frmSQUAREHospitalLtdICUPayment();
                    fSHL.Show();
                }
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

        private void linkEmailFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&source=mailto&to=atanu.saha415@gmail.com");
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            frmShowPrescription fSP = new frmShowPrescription(this.em);
            fSP.Show();
        }
    }
}
