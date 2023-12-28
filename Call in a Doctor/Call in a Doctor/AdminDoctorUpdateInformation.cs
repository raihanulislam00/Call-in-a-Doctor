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
    public partial class frmAdminDoctorUpdateInformation : Form
    {
        public frmAdminDoctorUpdateInformation()
        {
            InitializeComponent();
        }

        private void tbDoctorUpdateEmail_Enter(object sender, EventArgs e)
        {
            if(tbDoctorUpdateEmail.Text == "Email")
            {
                tbDoctorUpdateEmail.Text = "";
                tbDoctorUpdateEmail.ForeColor = Color.Black;
            }
        }

        private void tbDoctorUpdateEmail_Leave(object sender, EventArgs e)
        {
            if (tbDoctorUpdateEmail.Text == "")
            {
                tbDoctorUpdateEmail.Text = "Email";
                tbDoctorUpdateEmail.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorUpdateFirstName_Enter(object sender, EventArgs e)
        {
            if (tbDoctorUpdateFirstName.Text == "First Name")
            {
                tbDoctorUpdateFirstName.Text = "";
                tbDoctorUpdateFirstName.ForeColor = Color.Black;
            }
        }

        private void tbDoctorUpdateFirstName_Leave(object sender, EventArgs e)
        {
            if (tbDoctorUpdateFirstName.Text == "")
            {
                tbDoctorUpdateFirstName.Text = "First Name";
                tbDoctorUpdateFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorUpdateLastName_Enter(object sender, EventArgs e)
        {
            if (tbDoctorUpdateLastName.Text == "Last Name")
            {
                tbDoctorUpdateLastName.Text = "";
                tbDoctorUpdateLastName.ForeColor = Color.Black;
            }
        }

        private void tbDoctorUpdateLastName_Leave(object sender, EventArgs e)
        {
            if (tbDoctorUpdateLastName.Text == "")
            {
                tbDoctorUpdateLastName.Text = "Last Name";
                tbDoctorUpdateLastName.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorUpdatePhoneNumber_Enter(object sender, EventArgs e)
        {
            if (tbDoctorUpdatePhoneNumber.Text == "Phone Number")
            {
                tbDoctorUpdatePhoneNumber.Text = "";
                tbDoctorUpdatePhoneNumber.ForeColor = Color.Black;
            }
        }

        private void tbDoctorUpdatePhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbDoctorUpdatePhoneNumber.Text == "")
            {
                tbDoctorUpdatePhoneNumber.Text = "Phone Number";
                tbDoctorUpdatePhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorUpdatePassword_Enter(object sender, EventArgs e)
        {
            if (tbDoctorUpdatePassword.Text == "Password")
            {
                tbDoctorUpdatePassword.Text = "";
                tbDoctorUpdatePassword.ForeColor = Color.Black;
            }
        }

        private void tbDoctorUpdatePassword_Leave(object sender, EventArgs e)
        {
            if (tbDoctorUpdatePassword.Text == "")
            {
                tbDoctorUpdatePassword.Text = "Password";
                tbDoctorUpdatePassword.ForeColor = Color.Silver;
            }
        }

        private void rtbDoctorUpdateAddress_Enter(object sender, EventArgs e)
        {
            if (rtbDoctorUpdateAddress.Text == "Address")
            {
                rtbDoctorUpdateAddress.Text = "";
                rtbDoctorUpdateAddress.ForeColor = Color.Black;
            }
        }

        private void rtbDoctorUpdateAddress_Leave(object sender, EventArgs e)
        {
            if (rtbDoctorUpdateAddress.Text == "")
            {
                rtbDoctorUpdateAddress.Text = "Address";
                rtbDoctorUpdateAddress.ForeColor = Color.Silver;
            }
        }

        private void frmAdminDoctorUpdateInformation_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnBackDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string email = tbDoctorUpdateEmail.Text;
            string firstName = tbDoctorUpdateFirstName.Text;
            string lastName = tbDoctorUpdateLastName.Text;
            string phoneNumber = tbDoctorUpdatePhoneNumber.Text;
            string pass = tbDoctorUpdatePassword.Text;
            string gender = rbDoctorUpdateGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpDoctorUpdateDOB.Value;
            string address = rtbDoctorUpdateAddress.Text;

            // Cheking if all fields are filled
            if (email == "Email" || firstName == "First Name" || lastName == "Last Name" ||
            phoneNumber == "Phone Number" || pass == "Password" || address == "Address" ||
            rbDoctorUpdateGenderMale.Checked == false && rbDoctorUpdateGenderFemale.Checked == false ||
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
                string sql = "UPDATE regDoctor SET [First Name] = " + "'" + firstName + "'" + "," +
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
    }
}
