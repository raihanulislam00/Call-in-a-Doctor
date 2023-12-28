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
    public partial class frmOnlinePaymentATM : Form
    {
        public frmOnlinePaymentATM()
        {
            InitializeComponent();
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
            {
                //Initiating SQL connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = OnlineAppoinment_CID; " +
                                        "integrated security = SSPI";

                // Generating SQL query
                string sql = "INSERT INTO Dr_ATM([Patient's Name],[Patient's Email],[Patient's Mobile],[Appointment Date],[Trx ID])" +
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

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtpOnlineDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbOnlineMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOnlineEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbOnlineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTrxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmOnlinePaymentATM_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
