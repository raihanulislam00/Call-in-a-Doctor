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
    public partial class frmAdminRemoveAdmin : Form
    {
        public frmAdminRemoveAdmin()
        {
            InitializeComponent();
        }

        private void tbAdminRemoveUsername_Enter(object sender, EventArgs e)
        {
            if(tbAdminRemoveUsername.Text == "Username")
            {
                tbAdminRemoveUsername.Text = "";
                tbAdminRemoveUsername.ForeColor = Color.Black;
            }
        }

        private void tbAdminRemoveUsername_Leave(object sender, EventArgs e)
        {
            if (tbAdminRemoveUsername.Text == "")
            {
                tbAdminRemoveUsername.Text = "Username";
                tbAdminRemoveUsername.ForeColor = Color.Silver;
            }
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            if(tbAdminRemoveUsername.Text == "Username")
            {
                MessageBox.Show("Please Enter Username!");
            }
            else
            {
                // Getting a value from table
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                        "integrated security = SSPI";
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from regAdmin where Username=" + "'" + tbAdminRemoveUsername.Text + "'", con1);
                SqlDataReader da1 = cmd1.ExecuteReader();
                string searchedUsername = "";
                while (da1.Read())
                {
                    searchedUsername = da1.GetValue(3).ToString();
                }

                if(searchedUsername == tbAdminRemoveUsername.Text)
                {
                    if (MessageBox.Show("Are You Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                                "integrated security = SSPI";

                        string userName = tbAdminRemoveUsername.Text;

                        string sql = "delete from regAdmin where Username ='" + userName + "'";

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

                        string sql2 = "delete from loginAdmin where Username ='" + userName + "'";

                        using (SqlCommand cmd = new SqlCommand(sql2, con2))
                        {
                            // Opening the connection
                            con2.Open();
                            // cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            // Disconnect
                            con2.Close();
                        }
                        MessageBox.Show("Admin Removed!");
                    }
                }
                else
                {
                    MessageBox.Show("This Username Is Not Registered :(");
                }
            }
        }
    }
}
