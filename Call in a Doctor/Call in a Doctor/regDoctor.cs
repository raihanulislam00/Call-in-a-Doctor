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
    public partial class frmRegDoctor : Form
    {
        public frmRegDoctor()
        {
            InitializeComponent();
        }

        private void tbDoctorFirstName_Enter(object sender, EventArgs e)
        {
            if(tbDoctorFirstName.Text == "First Name")
            {
                tbDoctorFirstName.Text = "";
                tbDoctorFirstName.ForeColor = Color.Black;
            }
        }

        private void tbDoctorFirstName_Leave(object sender, EventArgs e)
        {
            if(tbDoctorFirstName.Text == "")
            {
                tbDoctorFirstName.Text = "First Name";
                tbDoctorFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbLastLastName_Enter(object sender, EventArgs e)
        {
            if(tbDoctorLastName.Text == "Last Name")
            {
                tbDoctorLastName.Text = "";
                tbDoctorLastName.ForeColor = Color.Black;
            }
        }

        private void tbDoctorLastName_Leave(object sender, EventArgs e)
        {
            if (tbDoctorLastName.Text == "")
            {
                tbDoctorLastName.Text = "Last Name";
                tbDoctorLastName.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorEmail_Enter(object sender, EventArgs e)
        {
            if(tbDoctorEmail.Text == "someone@example.com")
            {
                tbDoctorEmail.Text = "";
                tbDoctorEmail.ForeColor = Color.Black;
            }
        }

        private void tbDoctorEmail_Leave(object sender, EventArgs e)
        {
            if (tbDoctorEmail.Text == "")
            {
                tbDoctorEmail.Text = "someone@example.com";
                tbDoctorEmail.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorPhoneNumber_Enter(object sender, EventArgs e)
        {
            if(tbDoctorPhoneNumber.Text == "Phone Number")
            {
                tbDoctorPhoneNumber.Text = "";
                tbDoctorPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void tbDoctorPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbDoctorPhoneNumber.Text == "")
            {
                tbDoctorPhoneNumber.Text = "Phone Number";
                tbDoctorPhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorPassword_Enter(object sender, EventArgs e)
        {
            if(tbDoctorPassword.Text == "Password")
            {
                tbDoctorPassword.Text = "";
                tbDoctorPassword.ForeColor = Color.Black;
            }
        }

        private void tbDoctorPassword_Leave(object sender, EventArgs e)
        {
            if (tbDoctorPassword.Text == "")
            {
                tbDoctorPassword.Text = "Password";
                tbDoctorPassword.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorNID_Enter(object sender, EventArgs e)
        {
            if(tbDoctorNID.Text == "NID")
            {
                tbDoctorNID.Text = "";
                tbDoctorNID.ForeColor = Color.Black;
            }
        }

        private void tbDoctorNID_Leave(object sender, EventArgs e)
        {
            if (tbDoctorNID.Text == "")
            {
                tbDoctorNID.Text = "NID";
                tbDoctorNID.ForeColor = Color.Silver;
            }
        }

        private void tbDoctorRegNo_Enter(object sender, EventArgs e)
        {
            if(tbDoctorRegNo.Text == "Registration No.")
            {
                tbDoctorRegNo.Text = "";
                tbDoctorRegNo.ForeColor = Color.Black;
            }
        }

        private void tbDoctorRegNo_Leave(object sender, EventArgs e)
        {
            if (tbDoctorRegNo.Text == "")
            {
                tbDoctorRegNo.Text = "Registration No.";
                tbDoctorRegNo.ForeColor = Color.Silver;
            }
        }

        private void btnRegDoctor_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = tbDoctorFirstName.Text;
            string lastName = tbDoctorLastName.Text;
            string email = tbDoctorEmail.Text;
            string phoneNumber = tbDoctorPhoneNumber.Text;
            string pass = tbDoctorPassword.Text;
            string nid = tbDoctorNID.Text;
            string regNo = tbDoctorRegNo.Text;
            string gender = rbDoctorGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpDoctorDOB.Value;
            string address = rtbDoctorAddress.Text;

            // cheking if all tables are filled
            if (firstName == "First Name" || lastName == "Last Name" || email == "Email" ||
            phoneNumber == "Phone Number" || pass == "Password" || nid == "NID" || regNo == "Registration No." ||
            address == "Address" ||
            rbDoctorGenderMale.Checked == false && rbDoctorGenderFemale.Checked == false ||
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
                SqlCommand cmd1 = new SqlCommand("Select * from regDoctor where email=" + "'" + email + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedEmail = "";
                while (da1.Read())
                {
                    searchedEmail = da1.GetValue(3).ToString();
                }
                // checking duplicacy
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
                    string sql = "INSERT INTO regDoctor([First Name],[Last Name],Email,[Phone Number],Password,NID,[Registration No.],Gender,DOB,Address)" +
                                  "VALUES(" + "'" + firstName + "'" + ","
                                            + "'" + lastName + "'" + ","
                                            + "'" + email + "'" + ","
                                            + "'" + phoneNumber + "'" + ","
                                            + "'" + pass + "'" + ","
                                            + "'" + nid + "'" + ","
                                            + "'" + regNo + "'" + ","
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

                    MessageBox.Show("Doctor Added Successfully");

                    // Login Table
                    //Initiating SQL connection
                    SqlConnection conLogin = new SqlConnection();
                    conLogin.ConnectionString = "data source = DELL-VOSTRO-556; database = Login_CID; " +
                                            "integrated security = SSPI";

                    //Assigning Values
                    string emailLogin = tbDoctorEmail.Text;
                    string passLogin = tbDoctorPassword.Text;

                    // Generating SQL query
                    string sqlLogin = "INSERT INTO loginDoctor(Email,Password)" +
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

        private void btnBackDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegDoctor_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void rtbDoctorAddress_Enter(object sender, EventArgs e)
        {
            if(rtbDoctorAddress.Text == "Address")
            {
                rtbDoctorAddress.Text = "";
                rtbDoctorAddress.ForeColor = Color.Black;
            }
        }

        private void rtbDoctorAddress_Leave(object sender, EventArgs e)
        {
            if (rtbDoctorAddress.Text == "")
            {
                rtbDoctorAddress.Text = "Address";
                rtbDoctorAddress.ForeColor = Color.Silver;
            }
        }
    }
}
