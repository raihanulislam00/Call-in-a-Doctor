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
    public partial class frmAdminCreateAdmin : Form
    {
        public frmAdminCreateAdmin()
        {
            InitializeComponent();
        }

        private void tbAdminCreateFirstName_Enter(object sender, EventArgs e)
        {
            if(tbAdminCreateFirstName.Text == "First Name")
            {
                tbAdminCreateFirstName.Text = "";
                tbAdminCreateFirstName.ForeColor = Color.Black;
            }
        }

        private void tbAdminCreateFirstName_Leave(object sender, EventArgs e)
        {
            if (tbAdminCreateFirstName.Text == "")
            {
                tbAdminCreateFirstName.Text = "First Name";
                tbAdminCreateFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbAdminCreateLastName_Enter(object sender, EventArgs e)
        {
            if(tbAdminCreateLastName.Text == "Last Name")
            {
                tbAdminCreateLastName.Text = "";
                tbAdminCreateLastName.ForeColor = Color.Black;
            }
        }

        private void tbAdminCreateLastName_Leave(object sender, EventArgs e)
        {
            if (tbAdminCreateLastName.Text == "")
            {
                tbAdminCreateLastName.Text = "Last Name";
                tbAdminCreateLastName.ForeColor = Color.Silver;
            }
        }

        private void tbAdminCreateUsername_Enter(object sender, EventArgs e)
        {
            if(tbAdminCreateUsername.Text == "Username")
            {
                tbAdminCreateUsername.Text = "";
                tbAdminCreateUsername.ForeColor = Color.Black;
            }
        }

        private void tbAdminCreateUsername_Leave(object sender, EventArgs e)
        {
            if (tbAdminCreateUsername.Text == "")
            {
                tbAdminCreateUsername.Text = "Username";
                tbAdminCreateUsername.ForeColor = Color.Silver;
            }
        }

        private void tbAdminCreatePhoneNumber_Enter(object sender, EventArgs e)
        {
            if(tbAdminCreatePhoneNumber.Text == "Phone Number")
            {
                tbAdminCreatePhoneNumber.Text = "";
                tbAdminCreatePhoneNumber.ForeColor = Color.Black;
            }
        }

        private void tbAdminCreatePhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbAdminCreatePhoneNumber.Text == "")
            {
                tbAdminCreatePhoneNumber.Text = "Phone Number";
                tbAdminCreatePhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void tbAdminCreatePassword_Enter(object sender, EventArgs e)
        {
            if(tbAdminCreatePassword.Text == "Password")
            {
                tbAdminCreatePassword.Text = "";
                tbAdminCreatePassword.ForeColor = Color.Black;
            }
        }

        private void tbAdminCreatePassword_Leave(object sender, EventArgs e)
        {
            if (tbAdminCreatePassword.Text == "")
            {
                tbAdminCreatePassword.Text = "Password";
                tbAdminCreatePassword.ForeColor = Color.Silver;
            }
        }

        private void rtbAdminCreateAddress_Enter(object sender, EventArgs e)
        {
            if(rtbAdminCreateAddress.Text == "Address")
            {
                rtbAdminCreateAddress.Text = "";
                rtbAdminCreateAddress.ForeColor = Color.Black;
            }
        }

        private void rtbAdminCreateAddress_Leave(object sender, EventArgs e)
        {
            if (rtbAdminCreateAddress.Text == "")
            {
                rtbAdminCreateAddress.Text = "Address";
                rtbAdminCreateAddress.ForeColor = Color.Silver;
            }
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminCreateAdmin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnAdminCreate_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = tbAdminCreateFirstName.Text;
            string lastName = tbAdminCreateLastName.Text;
            string username = tbAdminCreateUsername.Text;
            string phoneNumber = tbAdminCreatePhoneNumber.Text;
            string pass = tbAdminCreatePassword.Text;
            string gender = rbAdminCreateGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpAdminCreateDOB.Value;
            string address = rtbAdminCreateAddress.Text;

            // cheking if all tables are filled
            if (firstName == "First Name" || lastName == "Last Name" || username == "Username" ||
            phoneNumber == "Phone Number" || pass == "Password" || address == "Address" ||
            rbAdminCreateGenderMale.Checked == false && rbAdminCreateGenderFemale.Checked == false ||
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
                SqlCommand cmd1 = new SqlCommand("Select * from regAdmin where Username=" + "'" + username + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedUsername = "";
                while (da1.Read())
                {
                    searchedUsername = da1.GetValue(3).ToString();
                }
                // Cheking Duplicacy 
                if (username == searchedUsername)
                {
                    MessageBox.Show("The Username Is Already Taken :(\nPlease Choose Another Username!");
                }
                else
                {
                    /// Creating Admin
                    //Initiating SQL connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                            "integrated security = SSPI";

                    // Generating SQL query
                    string sql = "INSERT INTO regAdmin([First Name],[Last Name],Username,Password,[Phone Number],Gender,DOB,Address)" +
                                  "VALUES(" + "'" + firstName + "'" + ","
                                            + "'" + lastName + "'" + ","
                                            + "'" + username + "'" + ","
                                            + "'" + pass + "'" + ","
                                            + "'" + phoneNumber + "'" + ","
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



                    // Login Table
                    //Initiating SQL connection
                    SqlConnection conLogin = new SqlConnection();
                    conLogin.ConnectionString = "data source = DELL-VOSTRO-556; database = Login_CID; " +
                                            "integrated security = SSPI";

                    //Assigning Values
                    string usernameLogin = tbAdminCreateUsername.Text;
                    string passLogin = tbAdminCreatePassword.Text;

                    // Generating SQL query
                    string sqlLogin = "INSERT INTO loginAdmin(Username,Password)" +
                                  "VALUES(" + "'" + usernameLogin + "'" + ","
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

                    MessageBox.Show("Admin Added Successfully");
                }
            }
        }
    }
}
