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

namespace Call_in_a_Doctor
{
    public partial class frmPrescription : Form
    {
        public frmPrescription()
        {
            InitializeComponent();
        }

        public string patientName, patientEmail, doctorEmail;
        public frmPrescription(string name, string pEmail, string dEmail)
        {
            InitializeComponent();
            patientName = name;
            patientEmail = pEmail;
            doctorEmail = dEmail;
        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            labelPatientName.Text = patientName;
        }

        private void frmSendPrescription_Click(object sender, EventArgs e)
        {
            string detailsPrescription = tbWritePrescription.Text;

            // Getting a value from table
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                    "integrated security = SSPI";
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from regPatient where Email=" + "'" + patientEmail + "'", con1);
            SqlDataReader da1 = cmd1.ExecuteReader();
            string searchedEmail = "";
            while (da1.Read())
            {
                searchedEmail = da1.GetValue(3).ToString();
            }
            // checking duplicacy
            if (searchedEmail == patientEmail)
            {
                //Initiating SQL connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = Prescription_CID; " +
                                        "integrated security = SSPI";

                // Generating SQL query
                string sql = "INSERT INTO patientPrescription([Patient Email], [Doctor Email], [Prescription Details])" +
                              "VALUES(" + "'" + patientEmail + "'" + ","
                                        + "'" + doctorEmail + "'" + ","
                                        + "'" + detailsPrescription + "'"
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

                MessageBox.Show("Prescription Sent!");
            }
            else
            {
                MessageBox.Show("This Email Is Not Registered! :(");
            }
        }
    }
}
