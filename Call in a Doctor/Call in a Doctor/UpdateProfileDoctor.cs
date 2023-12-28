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
    public partial class frmUpdateProfileDoctor : Form
    {
        public frmUpdateProfileDoctor()
        {
            InitializeComponent();
        }

        public string email;
        public frmUpdateProfileDoctor(string email)
        {
            InitializeComponent();
            this.email = email;
        }


        private void btnBackDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProfileDoctor_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = tbDoctorUpdateFirstName.Text;
            string lastName = tbDoctorUpdateLastName.Text;
            string phoneNumber = tbDoctorUpdatePhoneNumber.Text;
            string pass = tbDoctorUpdatePassword.Text;
            string gender = rbDoctorUpdateGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpDoctorUpdateDOB.Value;
            string address = rtbDoctorUpdateAddress.Text;

            if (firstName == "First Name" || lastName == "Last Name" || phoneNumber == "Phone Number" ||
                pass == "Password" || rbDoctorUpdateGenderMale.Checked == false && rbDoctorUpdateGenderFemale.Checked == false ||
                address == "Address")
            {
                MessageBox.Show("Please Fill All The Tables!");
            }
            else
            {//Initiating SQL connection
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
                             " where email = " + "'" + this.email + "'";

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
    }
}
