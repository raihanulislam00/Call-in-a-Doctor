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
    public partial class frmAdminDoctorDeleteAccount : Form
    {
        public frmAdminDoctorDeleteAccount()
        {
            InitializeComponent();
        }

        private void btnBackDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            MaximizeBox = false;

            if (tbDoctorDeleteEmail.Text == "Email")
            {
                MessageBox.Show("Please Enter Email");
            }
            else
            {
                /// checking If email exist
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from regDoctor where email=" + "'" + tbDoctorDeleteEmail.Text + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedEmail = "";
                while (da1.Read())
                {
                    searchedEmail = da1.GetValue(3).ToString();
                }

                if (searchedEmail == tbDoctorDeleteEmail.Text)
                {
                    if (MessageBox.Show("Are You Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                                "integrated security = SSPI";

                        string email = tbDoctorDeleteEmail.Text;

                        string sql = "delete from regDoctor where email='" + email + "'";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            // Opening the connection
                            con.Open();
                            // cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            // Disconnect
                            con.Close();
                        }

                        SqlConnection con2 = new SqlConnection();
                        con2.ConnectionString = "data source = DELL-VOSTRO-556; database = Login_CID; " +
                                                "integrated security = SSPI";

                        string sql2 = "delete from loginDoctor where email='" + email + "'";

                        using (SqlCommand cmd = new SqlCommand(sql2, con2))
                        {
                            // Opening the connection
                            con2.Open();
                            // cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            // Disconnect
                            con2.Close();
                        }
                        MessageBox.Show("Account Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("The Email Is Not Registered :(");
                }
            }
        }

        private void tbDoctorDeleteEmail_Enter(object sender, EventArgs e)
        {
            if(tbDoctorDeleteEmail.Text == "Email")
            {
                tbDoctorDeleteEmail.Text = "";
                tbDoctorDeleteEmail.ForeColor = Color.Black;
            }
        }

        private void tbDoctorDeleteEmail_Leave(object sender, EventArgs e)
        {
            if (tbDoctorDeleteEmail.Text == "")
            {
                tbDoctorDeleteEmail.Text = "Email";
                tbDoctorDeleteEmail.ForeColor = Color.Silver;
            }
        }
    }
}
