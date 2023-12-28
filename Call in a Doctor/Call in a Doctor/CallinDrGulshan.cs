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

namespace Call_in_a_Doctor
{
    public partial class frmCallinDrGulshan : Form
    {
        public frmCallinDrGulshan()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCallinDrGulshan_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void linkDrGulshan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evercarebd.com/profile/?cid=170");
        }

        private void btnOnlineProceed_Click(object sender, EventArgs e)
        {
            frmCallinPaymentDrGulshan fGulshan = new frmCallinPaymentDrGulshan();
            fGulshan.Show();
        }
    }
}
