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
    public partial class frmOnlineATM : Form
    {
        public frmOnlineATM()
        {
            InitializeComponent();
        }

        private void frmOnlineATM_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void linkDrATM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mawbiz.com.bd/prof-atm-mowladad-chowdhury-urologist-apollo-hospitals");
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnlineProceed_Click(object sender, EventArgs e)
        {
            frmOnlinePaymentATM fATM = new frmOnlinePaymentATM();
            fATM.Show();
        }
    }
}
