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
    public partial class frmAdminConsultancyReq : Form
    {
        public frmAdminConsultancyReq()
        {
            InitializeComponent();
        }

        public string doctorName;
        public frmAdminConsultancyReq(string name)
        {
            InitializeComponent();
            doctorName = name;
        }

        private void frmAdminConsultancyReq_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            /// Online Appointment display
            //Initiating SQL connection
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = DELL-VOSTRO-556; database = OnlineAppoinment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (doctorName == "Dr. Alim Akhtar Bhuiyan")
            {
                string query1 = "Select * from Dr_Alim_Akhtar_Bhuiyan";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. M. Ali")
            {
                string query1 = "Select * from Dr_M_Ali";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Gulshan Ara")
            {
                string query1 = "Select * from Dr_Gulshan_Ara";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (doctorName == "Prof. ATM Mowladad Chowdhury")
            {
                string query1 = "Select * from Dr_ATM";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Fahmida Begum")
            {
                string query1 = "Select * from Dr_Fahmida_Begum";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Jasmin Manzoor")
            {
                string query1 = "Select * from Dr_Jasmin_Manzoor";

                SqlCommand command1 = new SqlCommand(query1, con1);

                // opening the connection
                con1.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvOnlineRequest.DataSource = source1;
            }






            /// In Person Appointment display
            //Initiating SQL connection
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "data source = DELL-VOSTRO-556; database = InPersonAppointment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (doctorName == "Dr. Alim Akhtar Bhuiyan")
            {
                string query1 = "Select * from Dr_Alim_Akhtar_Bhuiyan";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. M. Ali")
            {
                string query1 = "Select * from Dr_M_Ali";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Gulshan Ara")
            {
                string query1 = "Select * from Dr_Gulshan_Ara";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (doctorName == "Prof. ATM Mowladad Chowdhury")
            {
                string query1 = "Select * from Dr_ATM";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Fahmida Begum")
            {
                string query1 = "Select * from Dr_Fahmida_Begum";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Jasmin Manzoor")
            {
                string query1 = "Select * from Dr_Jasmin_Manzoor";

                SqlCommand command1 = new SqlCommand(query1, con2);

                // opening the connection
                con2.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvInPersonRequest.DataSource = source1;
            }







            /// Call in Appointment display
            //Initiating SQL connection
            SqlConnection con3 = new SqlConnection();
            con3.ConnectionString = "data source = DELL-VOSTRO-556; database = CallinAppointment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (doctorName == "Dr. M. Ali")
            {
                string query1 = "Select * from Dr_M_Ali";

                SqlCommand command1 = new SqlCommand(query1, con3);

                // opening the connection
                con3.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvCallinRequest.DataSource = source1;
            }
            else if (doctorName == "Dr. Gulshan Ara")
            {
                string query1 = "Select * from Dr_Gulshan_Ara";

                SqlCommand command1 = new SqlCommand(query1, con3);

                // opening the connection
                con3.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvCallinRequest.DataSource = source1;
            }






            /// Free Appointment display
            //Initiating SQL connection
            SqlConnection con4 = new SqlConnection();
            con4.ConnectionString = "data source = DELL-VOSTRO-556; database = FreeAppointment_CID; " +
                                    "integrated security = SSPI";

            // connectingg SQL query for DR ALIM
            if (doctorName == "Dr. Alim Akhtar Bhuiyan")
            {
                string query1 = "Select * from Dr_Alim_Akhtar_Bhuiyan";

                SqlCommand command1 = new SqlCommand(query1, con4);

                // opening the connection
                con4.Open();

                // Execute SQL query
                SqlDataReader reader1 = command1.ExecuteReader();

                // Binding reader to source
                BindingSource source1 = new BindingSource();
                source1.DataSource = reader1;


                // Binding source to grid view control
                dgvFreeRequest.DataSource = source1;
            }
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
