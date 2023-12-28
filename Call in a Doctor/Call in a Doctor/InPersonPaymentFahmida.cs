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
    public partial class frmInPersonPaymentFahmida : Form
    {
        public frmInPersonPaymentFahmida()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInPersonPaymentFahmida_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnPaymentConfirm_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string name = tbOnlineName.Text;
            string email = tbOnlineEmail.Text;
            string phoneNumber = tbOnlineMobile.Text;
            DateTime appointmentDate = dtpOnlineDate.Value;
            string trxID = tbTrxID.Text;

            // cheking all tables are filled or not
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) ||
                appointmentDate == DateTime.Now || string.IsNullOrEmpty(trxID))
            {
                MessageBox.Show("Please Fill All The Tables!");
            }
            else
            {//Initiating SQL connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = InPersonAppointment_CID; " +
                                        "integrated security = SSPI";



                // Generating SQL query
                string sql = "INSERT INTO Dr_Fahmida_Begum([Patient's Name],[Patient's Email],[Patient's Mobile],[Appointment Date],[Trx ID])" +
                              "VALUES(" + "'" + name + "'" + ","
                                        + "'" + email + "'" + ","
                                        + "'" + phoneNumber + "'" + ","
                                        + "'" + appointmentDate + "'" + ","
                                        + "'" + trxID + "'"
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

                MessageBox.Show("Appointment Added Successfully");
            }
        }
    }
}
