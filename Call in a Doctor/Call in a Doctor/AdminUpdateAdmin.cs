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
    public partial class frmAdminUpdateAdmin : Form
    {
        public frmAdminUpdateAdmin()
        {
            InitializeComponent();
        }

        private void tbAdminUpdateFirstName_Enter(object sender, EventArgs e)
        {
            if(tbAdminUpdateFirstName.Text == "First Name")
            {
                tbAdminUpdateFirstName.Text = "";
                tbAdminUpdateFirstName.ForeColor = Color.Black;
            }
        }

        private void tbAdminUpdateFirstName_Leave(object sender, EventArgs e)
        {
            if (tbAdminUpdateFirstName.Text == "")
            {
                tbAdminUpdateFirstName.Text = "First Name";
                tbAdminUpdateFirstName.ForeColor = Color.Silver;
            }
        }

        private void tbAdminUpdateLastName_Enter(object sender, EventArgs e)
        {
            if(tbAdminUpdateLastName.Text == "Last Name")
            {
                tbAdminUpdateLastName.Text = "";
                tbAdminUpdateLastName.ForeColor = Color.Black;
            }
        }

        private void tbAdminUpdateLastName_Leave(object sender, EventArgs e)
        {
            if(tbAdminUpdateLastName.Text == "")
            {
                tbAdminUpdateLastName.Text = "Last Name";
                tbAdminUpdateLastName.ForeColor = Color.Silver;
            }
        }

        private void tbAdminUpdateUsername_Enter(object sender, EventArgs e)
        {
            if(tbAdminUpdateUsername.Text == "Username")
            {
                tbAdminUpdateUsername.Text = "";
                tbAdminUpdateUsername.ForeColor = Color.Black;
            }
        }

        private void tbAdminUpdateUsername_Leave(object sender, EventArgs e)
        {
            if (tbAdminUpdateUsername.Text == "")
            {
                tbAdminUpdateUsername.Text = "Username";
                tbAdminUpdateUsername.ForeColor = Color.Silver;
            }
        }

        private void tbAdminUpdatePhoneNumber_Enter(object sender, EventArgs e)
        {
            if(tbAdminUpdatePhoneNumber.Text == "Phone Number")
            {
                tbAdminUpdatePhoneNumber.Text = "";
                tbAdminUpdatePhoneNumber.ForeColor = Color.Black;
            }
        }

        private void tbAdminUpdatePhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbAdminUpdatePhoneNumber.Text == "")
            {
                tbAdminUpdatePhoneNumber.Text = "Phone Number";
                tbAdminUpdatePhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void tbAdminUpdatePassword_Enter(object sender, EventArgs e)
        {
            if(tbAdminUpdatePassword.Text == "Password")
            {
                tbAdminUpdatePassword.Text = "";
                tbAdminUpdatePassword.ForeColor = Color.Black;
            }
        }

        private void tbAdminUpdatePassword_Leave(object sender, EventArgs e)
        {
            if (tbAdminUpdatePassword.Text == "")
            {
                tbAdminUpdatePassword.Text = "Password";
                tbAdminUpdatePassword.ForeColor = Color.Silver;
            }
        }

        private void rtbAdminUpdateAddress_Enter(object sender, EventArgs e)
        {
            if(rtbAdminUpdateAddress.Text == "Address")
            {
                rtbAdminUpdateAddress.Text = "";
                rtbAdminUpdateAddress.ForeColor = Color.Black;
            }
        }

        private void rtbAdminUpdateAddress_Leave(object sender, EventArgs e)
        {
            if (rtbAdminUpdateAddress.Text == "")
            {
                rtbAdminUpdateAddress.Text = "Address";
                rtbAdminUpdateAddress.ForeColor = Color.Silver;
            }
        }

        private void frmAdminUpdateAdmin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = tbAdminUpdateFirstName.Text;
            string lastName = tbAdminUpdateLastName.Text;
            string userName = tbAdminUpdateUsername.Text;
            string phoneNumber = tbAdminUpdatePhoneNumber.Text;
            string pass = tbAdminUpdatePassword.Text;
            string gender = rbAdminUpdateGenderMale.Checked ? "Male" : "Female";
            DateTime dob = dtpAdminUpdateDOB.Value;
            string address = rtbAdminUpdateAddress.Text;


            // cheking if all tables are filled
            if (firstName == "First Name" || lastName == "Last Name" ||
            phoneNumber == "Phone Number" || pass == "Password" || address == "Address" ||
            rbAdminUpdateGenderMale.Checked == false && rbAdminUpdateGenderFemale.Checked == false ||
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
                SqlCommand cmd1 = new SqlCommand("Select * from regAdmin where Username=" + "'" + userName + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedUsername = "";
                while (da1.Read())
                {
                    searchedUsername = da1.GetValue(3).ToString();
                }
                // Cheking Duplicacy 
                if (userName == searchedUsername)
                {

                    //Initiating SQL connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                            "integrated security = SSPI";

                    // Generating SQL query
                    string sql = "UPDATE regAdmin SET [First Name] = " + "'" + firstName + "'" + "," +
                                 " [Last Name] = " + "'" + lastName + "'" + "," +
                                 " Password = " + "'" + pass + "'" + "," +
                                 " [Phone Number] = " + "'" + phoneNumber + "'" + "," +
                                 " Gender = " + "'" + gender + "'" + "," +
                                 " DOB = " + "'" + dob + "'" + "," +
                                 " Address = " + "'" + address + "'" +
                                 " where Username = " + "'" + userName + "'";

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
                else
                {
                    MessageBox.Show("This Username Is Not Registered :(");
                }
            }
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
