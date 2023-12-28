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
    public partial class frmProgressBarAdmin : Form
    {
        public frmProgressBarAdmin()
        {
            InitializeComponent();
        }

        private void frmProgressBarAdmin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            this.timerProgressBarAdmin.Start();
        }

        private void timerProgressBarAdmin_Tick(object sender, EventArgs e)
        {
            this.progressBarAdmin.Increment(25);
            this.labelLoading.Text = "Loading " + this.progressBarAdmin.Value.ToString() + "%";

            if(progressBarAdmin.Value >= progressBarAdmin.Maximum)
            {
                timerProgressBarAdmin.Stop();
                this.Hide();
                frmHomeAdmin frmHD = new frmHomeAdmin();
                frmHD.Show();
            }
        }
    }
}
