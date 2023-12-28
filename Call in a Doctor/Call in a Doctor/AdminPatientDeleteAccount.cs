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
    public partial class frmAdminPatientDeleteAccount : Form
    {
        public frmAdminPatientDeleteAccount()
        {
            InitializeComponent();
        }

        private void tbPatientDeleteEmail_Enter(object sender, EventArgs e)
        {
            if(tbPatientDeleteEmail.Text == "Email")
            {
                tbPatientDeleteEmail.Text = "";
                tbPatientDeleteEmail.ForeColor = Color.Black;
            }
        }

        private void tbPatientDeleteEmail_Leave(object sender, EventArgs e)
        {
            if (tbPatientDeleteEmail.Text == "")
            {
                tbPatientDeleteEmail.Text = "Email";
                tbPatientDeleteEmail.ForeColor = Color.Silver;
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (tbPatientDeleteEmail.Text == "Email")
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
                SqlCommand cmd1 = new SqlCommand("Select * from regPatient where email=" + "'" + tbPatientDeleteEmail.Text + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedEmail = "";
                while (da1.Read())
                {
                    searchedEmail = da1.GetValue(3).ToString();
                }
                if (searchedEmail == tbPatientDeleteEmail.Text)
                {
                    if (MessageBox.Show("Are You Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                                "integrated security = SSPI";

                        string email = tbPatientDeleteEmail.Text;

                        string sql = "delete from regPatient where email='" + email + "'";

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

                        string sql2 = "delete from loginPatient where email='" + email + "'";

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
                con1.Close();
            }
        }

        private void frmAdminPatientDeleteAccount_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
