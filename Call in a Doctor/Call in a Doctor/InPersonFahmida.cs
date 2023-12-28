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
    public partial class frmInPersonFahmida : Form
    {
        public frmInPersonFahmida()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInPersonFahmida_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void linkDrFahmida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evercarebd.com/profile/?cid=408");
        }

        private void btnOnlineProceed_Click(object sender, EventArgs e)
        {
            frmInPersonPaymentFahmida fFahmida = new frmInPersonPaymentFahmida();
            fFahmida.Show();
        }
    }
}
