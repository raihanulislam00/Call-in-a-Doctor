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
    public partial class frmAdminDoctorShowInformation : Form
    {
        public frmAdminDoctorShowInformation()
        {
            InitializeComponent();
        }

        private void frmAdminDoctorShowInformation_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            /// Patient Information display
            //Initiating SQL connection
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Registration_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query
            string query1 = "Select * from regDoctor";

            SqlCommand command1 = new SqlCommand(query1, con1);

            // opening the connection
            con1.Open();

            // Execute SQL query
            SqlDataReader reader1 = command1.ExecuteReader();

            // Binding reader to source
            BindingSource source1 = new BindingSource();
            source1.DataSource = reader1;


            // Binding source to grid view control
            dgvDoctorInformation.DataSource = source1;
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
