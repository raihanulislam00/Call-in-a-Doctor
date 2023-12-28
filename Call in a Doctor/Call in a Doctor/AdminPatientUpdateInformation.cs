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
    public partial class frmAdminPatientUpdateInformation : Form
    {
        public frmAdminPatientUpdateInformation()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPatientUpdateFirstName_Enter(object sender, EventArgs e)
        {
            if (tbPatientUpdateFirstName.Text == "First Name")
            {
                tbPatientUpdateFirstName.Text = "";
                tbPatientUpdateFirstName.ForeColor = Color.Black;
            }
        }

        private void tbPatientUpdateFirstName_Leave(object sender, EventArgs e)
        {
            if (tbPatientUpdateFirstName.Text == "")
            {
                tbPatientUpdateFirstName.Text = "First Name";
                tbPatientUpdateFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbPatientUpdateLastName_Enter(object sender, EventArgs e)
        {
            if (tbPatientUpdateLastName.Text == "Last Name")
            {
                tbPatientUpdateLastName.Text = "";
                tbPatientUpdateLastName.ForeColor = Color.Black;
            }
        }

        private void tbPatientUpdateLastName_Leave(object sender, EventArgs e)
        {
            if (tbPatientUpdateLastName.Text == "")
            {
                tbPatientUpdateLastName.Text = "Last Name";
                tbPatientUpdateLastName.ForeColor = Color.Silver;
            }
        }

        private void tbPatientUpdatePhoneNumber_Enter(object sender, EventArgs e)
        {
            if (tbPatientUpdatePhoneNumber.Text == "Phone Number")
            {
                tbPatientUpdatePhoneNumber.Text = "";
                tbPatientUpdatePhoneNumber.ForeColor = Color.Black;
            }
        }

        private void tbPatientUpdatePhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbPatientUpdatePhoneNumber.Text == "")
            {
                tbPatientUpdatePhoneNumber.Text = "Phone Number";
                tbPatientUpdatePhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void tbPatientUpdatePassword_Enter(object sender, EventArgs e)
        {
            if (tbPatientUpdatePassword.Text == "Password")
            {
                tbPatientUpdatePassword.Text = "";
                tbPatientUpdatePassword.ForeColor = Color.Black;
            }
        }

        private void tbPatientUpdatePassword_Leave(object sender, EventArgs e)
        {
            if (tbPatientUpdatePassword.Text == "")
            {
                tbPatientUpdatePassword.Text = "Password";
                tbPatientUpdatePassword.ForeColor = Color.Silver;
            }
        }

        private void rtbPatientUpdateAddress_Enter(object sender, EventArgs e)
        {
            if (rtbPatientUpdateAddress.Text == "Address")
            {
                rtbPatientUpdateAddress.Text = "";
                rtbPatientUpdateAddress.ForeColor = Color.Black;
            }
        }

        private void rtbPatientUpdateAddress_Leave(object sender, EventArgs e)
        {
            if (rtbPatientUpdateAddress.Text == "")
            {
                rtbPatientUpdateAddress.Text = "Address";
                rtbPatientUpdateAddress.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbPatientUpdateEmail.Text == "Email")
            {
                tbPatientUpdateEmail.Text = "";
                tbPatientUpdateEmail.ForeColor = Color.Black;
            }
        }


        private void tbPatientUpdateEmail_Leave(object sender, EventArgs e)
        {
            if (tbPatientUpdateEmail.Text == "")
            {
                tbPatientUpdateEmail.Text = "Email";
                tbPatientUpdateEmail.ForeColor = Color.Silver;
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string email = tbPatientUpdateEmail.Text;
            string firstName = tbPatientUpdateFirstName.Text;
            string lastName = tbPatientUpdateLastName.Text;
            string phoneNumber = tbPatientUpdatePhoneNumber.Text;
            string pass = tbPatientUpdatePassword.Text;
            string gender = rbPatientUpdateGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpPatientUpdateDOB.Value;
            string address = rtbPatientUpdateAddress.Text;

            if (email == "Email" || firstName == "First Name" || lastName == "Last Name" ||
                phoneNumber == "Phone Number" || pass == "Password" || address == "Address" ||
                rbPatientUpdateGenderMale.Checked == false && rbPatientUpdateGenderFemale.Checked == false ||
                dob == DateTime.Now)
            {
                MessageBox.Show("Please fill all the tables!");
            }
            else
            {
                //Initiating SQL connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";

                // Generating SQL query
                string sql = "UPDATE regPatient SET [First Name] = " + "'" + firstName + "'" + "," +
                             " [Last Name] = " + "'" + lastName + "'" + "," +
                             " [Phone Number] = " + "'" + phoneNumber + "'" + "," +
                             " Password = " + "'" + pass + "'" + "," +
                             " Gender = " + "'" + gender + "'" + "," +
                             " DOB = " + "'" + dob + "'" + "," +
                             " Address = " + "'" + address + "'" +
                             " where email = " + "'" + email + "'";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Opening the connection
                    con.Open();
                    // cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Disconnect
                    con.Close();
                }

                MessageBox.Show("Profile Updated Successfully");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminPatientUpdateInformation_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        /*
        */


    }
}
