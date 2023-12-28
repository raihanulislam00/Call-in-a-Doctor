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
    public partial class frmShowPrescription : Form
    {
        public frmShowPrescription()
        {
            InitializeComponent();
        }

        public string patientEmail;
        public frmShowPrescription(string email)
        {
            InitializeComponent();
            patientEmail = email;
        }
        private void frmShowPrescription_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            //Initiating SQL connection
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = DELL-VOSTRO-556; database = Prescription_CID; " +
                                    "integrated security = SSPI";
            string query1 = "Select [Doctor Email],[Prescription Details] from patientPrescription where [Patient Email] = " + "'" + patientEmail + "'";

            SqlCommand command1 = new SqlCommand(query1, con1);

            // opening the connection
            con1.Open();

            // Execute SQL query
            SqlDataReader reader1 = command1.ExecuteReader();

            // Binding reader to source
            BindingSource source1 = new BindingSource();
            source1.DataSource = reader1;


            // Binding source to grid view control
            dgvShowPrescription.DataSource = source1;
        }
    }
}
