﻿using System;
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
    public partial class frmInPersonDrAli : Form
    {
        public frmInPersonDrAli()
        {
            InitializeComponent();
        }

        private void btnBackOnline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInPersonDrAli_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void linkDrAli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evercarebd.com/profile/?cid=47");
        }

        private void btnOnlineProceed_Click(object sender, EventArgs e)
        {
            frmInPersonPaymentAli fAli = new frmInPersonPaymentAli();
            fAli.Show();
        }
    }
}
