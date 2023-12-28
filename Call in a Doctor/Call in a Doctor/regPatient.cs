using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // For sql connection

namespace Call_in_a_Doctor
{
    public partial class frmRegPatient : Form
    {
        public frmRegPatient()
        {
            InitializeComponent();
        }

        private void tbPatientFirstName_Enter(object sender, EventArgs e)
        {
            if(tbPatientFirstName.Text == "First Name")
            {
                tbPatientFirstName.Text = "";
                tbPatientFirstName.ForeColor = Color.Black;
            }
        }

        private void tbPatientFirstName_Leave(object sender, EventArgs e)
        {
            if (tbPatientFirstName.Text == "")
            {
                tbPatientFirstName.Text = "First Name";
                tbPatientFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbPatientSecondName_Enter(object sender, EventArgs e)
        {
            if(tbPatientLastName.Text == "Last Name")
            {
                tbPatientLastName.Text = "";
                tbPatientLastName.ForeColor = Color.Black;
            }
        }

        private void tbPatientSecondName_Leave(object sender, EventArgs e)
        {
            if(tbPatientLastName.Text == "")
            {
                tbPatientLastName.Text = "Last Name";
                tbPatientLastName.ForeColor = Color.Silver;
            }
        }

        private void tbPatientEmail_Enter(object sender, EventArgs e)
        {
            if (tbPatientEmail.Text == "someone@example.com")
            {
                tbPatientEmail.Text = "";
                tbPatientEmail.ForeColor = Color.Black;
            }
        }

        private void tbPatientEmail_Leave(object sender, EventArgs e)
        {
            if (tbPatientEmail.Text == "")
            {
                tbPatientEmail.Text = "someone@example.com";
                tbPatientEmail.ForeColor = Color.Silver;
            }
        }

        private void tbPatientPhoneNumber_Enter(object sender, EventArgs e)
        {
            if(tbPatientPhoneNumber.Text == "Phone Number")
            {
                tbPatientPhoneNumber.Text = "";
                tbPatientPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void tbPatientPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbPatientPhoneNumber.Text == "")
            {
                tbPatientPhoneNumber.Text = "Phone Number";
                tbPatientPhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void tbPatientPassword_Enter(object sender, EventArgs e)
        {
            if(tbPatientPassword.Text == "Password")
            {
                tbPatientPassword.Text = "";
                tbPatientPassword.ForeColor = Color.Black;
            }
        }

        private void tbPatientPassword_Leave(object sender, EventArgs e)
        {
            if (tbPatientPassword.Text == "")
            {
                tbPatientPassword.Text = "Password";
                tbPatientPassword.ForeColor = Color.Silver;
            }
        }

        private void btnRegPatient_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = tbPatientFirstName.Text;
            string lastName = tbPatientLastName.Text;
            string email = tbPatientEmail.Text;
            string phoneNumber = tbPatientPhoneNumber.Text;
            string pass = tbPatientPassword.Text;
            string gender = rbPatientGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpPatientDOB.Value;
            string address = rtbPatientAddress.Text;

            // cheking if all tables are filled
            if (firstName == "First Name" || lastName == "Last Name" || email == "Email" ||
            phoneNumber == "Phone Number" || pass == "Password" || address == "Address" ||
            rbPatientGenderMale.Checked == false && rbPatientGenderFemale.Checked == false ||
            dob == DateTime.Now)
            {
                MessageBox.Show("Please fill all the tables!");
            }
            else
            {
                // Getting a value from table
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from regPatient where email=" + "'" + email + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedEmail = "";
                while (da1.Read())
                {
                    searchedEmail = da1.GetValue(3).ToString();
                }
                if (searchedEmail == email)
                {
                    MessageBox.Show("The Email Is Already Taken :(");
                }
                else
                {
                    //Initiating SQL connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                            "integrated security = SSPI";

                    // Generating SQL query
                    string sql = "INSERT INTO regPatient([First Name],[Last Name],Email,[Phone Number],Password,Gender,DOB,Address)" +
                                  "VALUES(" + "'" + firstName + "'" + ","
                                            + "'" + lastName + "'" + ","
                                            + "'" + email + "'" + ","
                                            + "'" + phoneNumber + "'" + ","
                                            + "'" + pass + "'" + ","
                                            + "'" + gender + "'" + ","
                                            + "'" + dob + "'" + ","
                                            + "'" + address + "'"
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

                    MessageBox.Show("Patient Added Successfully");



                    // Login Table
                    //Initiating SQL connection
                    SqlConnection conLogin = new SqlConnection();
                    conLogin.ConnectionString = "data source = DELL-VOSTRO-556; database = Login_CID; " +
                                            "integrated security = SSPI";

                    //Assigning Values
                    string emailLogin = tbPatientEmail.Text;
                    string passLogin = tbPatientPassword.Text;

                    // Generating SQL query
                    string sqlLogin = "INSERT INTO loginPatient(Email,Password)" +
                                  "VALUES(" + "'" + emailLogin + "'" + ","
                                            + "'" + passLogin + "'"
                                            + ")";

                    using (SqlCommand cmdLogin = new SqlCommand(sqlLogin, conLogin))
                    {
                        // Opening the connection
                        conLogin.Open();
                        // cmd.CommandType = CommandType.Text;
                        cmdLogin.ExecuteNonQuery();
                        // Disconnect
                        conLogin.Close();
                    }

                    this.Close();
                }
            }
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegPatient_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void rtbPatientAddress_Enter(object sender, EventArgs e)
        {
            if(rtbPatientAddress.Text == "Address")
            {
                rtbPatientAddress.Text = "";
                rtbPatientAddress.ForeColor = Color.Black;
            }
        }

        private void rtbPatientAddress_Leave(object sender, EventArgs e)
        {
            if(rtbPatientAddress.Text == "")
            {
                rtbPatientAddress.Text = "Address";
                rtbPatientAddress.ForeColor = Color.Silver;
            }
        }
    }
}
