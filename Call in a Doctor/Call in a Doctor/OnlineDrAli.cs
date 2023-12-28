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
using System.Diagnostics;

namespace Call_in_a_Doctor
{
    public partial class frmOnlineAli : Form
    {
        public frmOnlineAli()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evercarebd.com/profile/?cid=47");
        }

        private void btnBackOnline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOnlineAli_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnOnlineProceed_Click_1(object sender, EventArgs e)
        {
            frmOnlinePaymentAli fOnlinePayment = new frmOnlinePaymentAli();
            fOnlinePayment.Show();
        }
    }
}
