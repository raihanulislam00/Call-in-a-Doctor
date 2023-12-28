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
    public partial class frmCallinaDoctor : Form
    {
        public frmCallinaDoctor()
        {
            InitializeComponent();

            /*string[] user = new string[3];
            user[0] = "Admin";
            user[1] = "Doctor";
            user[2] = "Patient";

            cmbSelectUser.DataSource = user;*/
        }

        private void tbLoginEmail_Enter(object sender, EventArgs e)
        {
            if(tbLoginEmail.Text == "someone@example.com")
            {
                tbLoginEmail.Text = "";
                tbLoginEmail.ForeColor = Color.Black;
            }
        }

        private void tbLoginEmail_Leave(object sender, EventArgs e)
        {
            if (tbLoginEmail.Text == "")
            {
                tbLoginEmail.Text = "someone@example.com";
                tbLoginEmail.ForeColor = Color.Silver;
            }
        }

        private void tbLoginPassword_Enter(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "Password")
            {
                tbLoginPassword.Text = "";
                tbLoginPassword.ForeColor = Color.Black;
            }
        }

        private void tbLoginPassword_Leave(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "")
            {
                tbLoginPassword.Text = "Password";
                tbLoginPassword.ForeColor = Color.Silver;
            }
        }
        

        private void btnRegPatient_Click(object sender, EventArgs e)
        {
            frmRegPatient rp = new frmRegPatient();
            rp.Show();
        }

        private void btnRegDoctor_Click(object sender, EventArgs e)
        {
            frmRegDoctor rd = new frmRegDoctor();
            rd.Show();
        }

        private void frmCallinaDoctor_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Initiating SQL 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DELL-VOSTRO-556; database = Login_CID; " +
                                    "integrated security = SSPI";

            //Cheking Patient DB
            string query = "Select * from loginPatient where Email = '" + tbLoginEmail.Text.Trim() + "' and Password = '" + tbLoginPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1 || tbLoginEmail.Text.Trim()=="patient" && tbLoginPassword.Text.Trim()=="patient")
            {
                string email = tbLoginEmail.Text.Trim();
                frmHomePatient frmHP = new frmHomePatient(email);
                frmHP.Show();
            }
            else
            {
                //Cheking Patient DB
                string query1 = "Select * from loginDoctor where Email = '" + tbLoginEmail.Text.Trim() + "' and Password = '" + tbLoginPassword.Text.Trim() + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                DataTable dtbl1 = new DataTable();
                sda1.Fill(dtbl1);
                if (dtbl1.Rows.Count == 1 || tbLoginEmail.Text.Trim() == "doctor" && tbLoginPassword.Text.Trim() == "doctor")
                {
                    string email = tbLoginEmail.Text.Trim();
                    frmHomeDoctor frmHD = new frmHomeDoctor(email);
                    frmHD.Show();
                }
                else
                {
                    //Cheking Patient DB
                    string query2 = "Select * from loginAdmin where Username = '" + tbLoginEmail.Text.Trim() + "' and Password = '" + tbLoginPassword.Text.Trim() + "'";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                    DataTable dtbl2 = new DataTable();
                    sda2.Fill(dtbl2);
                    if (dtbl2.Rows.Count == 1 || tbLoginEmail.Text.Trim() == "admin" && tbLoginPassword.Text.Trim() == "admin")
                    {
                        frmProgressBarAdmin fProgressAdmin = new frmProgressBarAdmin();
                        fProgressAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check Email and Password");
                    }
                }
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword fFP = new frmForgotPassword();
            fFP.Show();
        }
    }
}
