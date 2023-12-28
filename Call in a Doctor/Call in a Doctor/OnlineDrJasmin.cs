using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Call_in_a_Doctor
{
    public partial class frmOnlineJasmin : Form
    {
        public frmOnlineJasmin()
        {
            InitializeComponent();
        }

        private void linkDrJasmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evercarebd.com/profile/?cid=6");
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOnlineJasmin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnOnlineProceed_Click(object sender, EventArgs e)
        {
            frmOnlinePaymentJasmin fJasmin = new frmOnlinePaymentJasmin();
            fJasmin.Show();
        }
    }
}
