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
    public partial class frmPatientProfileUpdate : Form
    {
        public frmPatientProfileUpdate()
        {
            InitializeComponent();
        }

        public string em;
        public frmPatientProfileUpdate(string email)
        {
            InitializeComponent();
            this.em = email;
        }
        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPatientProfileUpdate_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

     
        private void btnUpdatePatient_Click_1(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = tbPatientUpdateFirstName.Text;
            string lastName = tbPatientUpdateLastName.Text;
            string phoneNumber = tbPatientUpdatePhoneNumber.Text;
            string pass = tbPatientUpdatePassword.Text;
            string gender = rbPatientUpdateGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpPatientUpdateDOB.Value;
            string address = rtbPatientUpdateAddress.Text;

            //checking if all the tables are filled or not
            if (firstName == "First Name" || lastName == "Last Name" || phoneNumber == "Phone Number" ||
                pass == "Password" || rbPatientUpdateGenderMale.Checked == false && rbPatientUpdateGenderFemale.Checked == false ||
                address == "Address")
            {
                MessageBox.Show("Please Fill All The Tables!");
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
                             " where email = " + "'" + this.em + "'";

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

        private void tbPatientUpdateFirstName_Enter(object sender, EventArgs e)
        {
            if(tbPatientUpdateFirstName.Text == "First Name")
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
            if(tbPatientUpdatePhoneNumber.Text == "Phone Number")
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
            if(rtbPatientUpdateAddress.Text == "Address")
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
    }
}
