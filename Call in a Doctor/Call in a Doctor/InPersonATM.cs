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
    public partial class frmInPersonATM : Form
    {
        public frmInPersonATM()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInPersonATM_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void linkDrATM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mawbiz.com.bd/prof-atm-mowladad-chowdhury-urologist-apollo-hospitals");
        }

        private void btnOnlineProceed_Click(object sender, EventArgs e)
        {
            frmInPersonPaymentATM fATM = new frmInPersonPaymentATM();
            fATM.Show();
        }
    }
}
