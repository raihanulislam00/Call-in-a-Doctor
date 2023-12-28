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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(tbForgotPasswordEmail.Text == "Email")
            {
                tbForgotPasswordEmail.Text = "";
                tbForgotPasswordEmail.ForeColor = Color.Black;
            }
        }

        private void tbForgotPasswordEmail_Leave(object sender, EventArgs e)
        {
            if (tbForgotPasswordEmail.Text == "")
            {
                tbForgotPasswordEmail.Text = "Email";
                tbForgotPasswordEmail.ForeColor = Color.Silver;
            }
        }

        private void btnForgotPasswordSend_Click(object sender, EventArgs e)
        {
            if(tbForgotPasswordEmail.Text != "Email")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from regPatient where email=" + "'" + tbForgotPasswordEmail.Text + "'", con);
                SqlDataReader da = cmd.ExecuteReader();
                string searchedEmail = "";
                while (da.Read())
                {
                    searchedEmail = da.GetValue(3).ToString();
                }
                if (searchedEmail == tbForgotPasswordEmail.Text)
                {
                    MessageBox.Show("Check Your Email To Change Password :)");
                    con.Close();
                }
                else
                {
                    con.Close();
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                            "integrated security = SSPI";
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from regDoctor where email=" + "'" + tbForgotPasswordEmail.Text + "'", con1);
                    SqlDataReader da1 = cmd1.ExecuteReader();
                    string searchedEmail1 = "";
                    while (da1.Read())
                    {
                        searchedEmail1 = da1.GetValue(3).ToString();
                    }
                    if (searchedEmail1 == tbForgotPasswordEmail.Text)
                    {
                        MessageBox.Show("Check Your Email To Change Password :)");
                    }
                    else
                    {
                        MessageBox.Show("The Email Is Not Registered :(");
                    }
                    con1.Close();
                }
            }
            else
            {
                MessageBox.Show("You Haven't Entered Email :)");
            }
        }
    }
}
