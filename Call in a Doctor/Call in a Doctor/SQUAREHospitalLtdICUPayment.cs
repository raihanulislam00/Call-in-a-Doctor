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
    public partial class frmSQUAREHospitalLtdICUPayment : Form
    {
        public frmSQUAREHospitalLtdICUPayment()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSQUAREHospitalLtdICUPayment_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnPaymentConfirm_Click(object sender, EventArgs e)
        {

            //Assigning Values
            string name = tbOnlineName.Text;
            string email = tbOnlineEmail.Text;
            string phoneNumber = tbOnlineMobile.Text;
            string trxID = tbTrxID.Text;

            if (name == "Name" || email == "Email" || phoneNumber == "Phone No." || trxID == "Trx ID")
            {
                MessageBox.Show("Please fill all the tables!");
            }
            else
            {
                // Booking Seat
                //Initiating SQL connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = AvailableICU_CID; " +
                                        "integrated security = SSPI";

                // Generating SQL query
                string sql = "INSERT INTO bookedSQUAREHospitalLtd(Name,Email,[Phone Number],[Trx ID])" +
                              "VALUES(" + "'" + name + "'" + ","
                                        + "'" + email + "'" + ","
                                        + "'" + phoneNumber + "'" + ","
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

                // Update Seat Number
                //Initiating SQL connection
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = DELL-VOSTRO-556; database = AvailableICU_CID; " +
                                        "integrated security = SSPI";
                con1.Open();
                string count = "";
                string hospitalName = "SQUARE Hospital Ltd.";
                SqlCommand cmd1 = new SqlCommand("Select * from availableSeat where [Hospital Name]=" + "'" + hospitalName + "'", con1);
                SqlDataReader da = cmd1.ExecuteReader();
                while (da.Read())
                {
                    count = da["Available Seats"].ToString();
                }
                con1.Close();

                int availableSeats = Int32.Parse(count) - 1;
                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = "data source = DELL-VOSTRO-556; database = AvailableICU_CID; " +
                                        "integrated security = SSPI";
                // Generating SQL query
                string sql1 = "UPDATE availableSeat SET [Available Seats] = " + "'" + availableSeats + "'" +
                             " where [Hospital Name] = " + "'" + hospitalName + "'";

                using (SqlCommand cmd2 = new SqlCommand(sql1, con2))
                {
                    // Opening the connection
                    con2.Open();
                    // cmd.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                    // Disconnect
                    con2.Close();
                }
                MessageBox.Show("ICU Booked Successfully");
                this.Close();
            }
        }

        private void tbOnlineName_Enter(object sender, EventArgs e)
        {
            if (tbOnlineName.Text == "Name")
            {
                tbOnlineName.Text = "";
                tbOnlineName.ForeColor = Color.Black;
            }
        }

        private void tbOnlineName_Leave(object sender, EventArgs e)
        {
            if (tbOnlineName.Text == "")
            {
                tbOnlineName.Text = "Name";
                tbOnlineName.ForeColor = Color.Silver;
            }
        }

        private void tbOnlineEmail_Enter(object sender, EventArgs e)
        {
            if (tbOnlineEmail.Text == "Email")
            {
                tbOnlineEmail.Text = "";
                tbOnlineEmail.ForeColor = Color.Black;
            }
        }

        private void tbOnlineEmail_Leave(object sender, EventArgs e)
        {
            if (tbOnlineEmail.Text == "")
            {
                tbOnlineEmail.Text = "Email";
                tbOnlineEmail.ForeColor = Color.Silver;
            }
        }

        private void tbOnlineMobile_Enter(object sender, EventArgs e)
        {
            if (tbOnlineMobile.Text == "Mobile No.")
            {
                tbOnlineMobile.Text = "";
                tbOnlineMobile.ForeColor = Color.Black;
            }
        }

        private void tbOnlineMobile_Leave(object sender, EventArgs e)
        {
            if (tbOnlineMobile.Text == "")
            {
                tbOnlineMobile.Text = "Mobile No.";
                tbOnlineMobile.ForeColor = Color.Silver;
            }
        }

        private void tbTrxID_Enter(object sender, EventArgs e)
        {
            if (tbTrxID.Text == "Trx ID")
            {
                tbTrxID.Text = "";
                tbTrxID.ForeColor = Color.Black;
            }
        }

        private void tbTrxID_Leave(object sender, EventArgs e)
        {
            if (tbTrxID.Text == "")
            {
                tbTrxID.Text = "Trx ID";
                tbTrxID.ForeColor = Color.Silver;
            }
        }
    }
}
