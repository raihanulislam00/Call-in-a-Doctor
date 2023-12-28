using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_in_a_Doctor
{
    public partial class frmCallingPatient : Form
    {
        public frmCallingPatient()
        {
            InitializeComponent();
        }
        public string name, patientEmail, doctorEmail; 
        public frmCallingPatient(string name, string pEmail, string dEmail)
        {
            InitializeComponent();
            this.name = name;
            patientEmail = pEmail;
            doctorEmail = dEmail;
        }

        private void frmCallingPatient_Load(object sender, EventArgs e)
        {
            labelPatientName.Text = this.name;
        }

        private void pbCancelCall_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrescription fP = new frmPrescription(this.name, patientEmail, doctorEmail);
            fP.Show();
        }
    }
}
