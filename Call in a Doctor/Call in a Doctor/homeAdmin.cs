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
    public partial class frmHomeAdmin : Form
    {
        public frmHomeAdmin()
        {
            InitializeComponent();
        }

        private void frmHomeAdmin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnShowPatientInfo_Click(object sender, EventArgs e)
        {
            frmAdminPatientShowInformation fPatientInfo = new frmAdminPatientShowInformation();
            fPatientInfo.Show();
        }

        private void btnUpdatePatientInfo_Click(object sender, EventArgs e)
        {
            frmAdminPatientUpdateInformation fAPUI = new frmAdminPatientUpdateInformation();
            fAPUI.Show();
        }

        private void btnDeletePatientAccount_Click(object sender, EventArgs e)
        {
            frmAdminPatientDeleteAccount fADA = new frmAdminPatientDeleteAccount();
            fADA.Show();
        }

        private void btnShowDoctorInfo_Click(object sender, EventArgs e)
        {
            frmAdminDoctorShowInformation fADSI = new frmAdminDoctorShowInformation();
            fADSI.Show();
        }

        private void btnUpdateDoctorInfo_Click(object sender, EventArgs e)
        {
            frmAdminDoctorUpdateInformation fADUI = new frmAdminDoctorUpdateInformation();
            fADUI.Show();
        }

        private void btnDeleteDeleteAccount_Click(object sender, EventArgs e)
        {
            frmAdminDoctorDeleteAccount fADDA = new frmAdminDoctorDeleteAccount();
            fADDA.Show();
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            frmAdminCreateAdmin fACA = new frmAdminCreateAdmin();
            fACA.Show();
        }

        private void btnShowAdmin_Click(object sender, EventArgs e)
        {
            frmAdminShowAdmin fASA = new frmAdminShowAdmin();
            fASA.Show();
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            frmAdminUpdateAdmin fAUA = new frmAdminUpdateAdmin();
            fAUA.Show();
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            frmAdminRemoveAdmin fARD = new frmAdminRemoveAdmin();
            fARD.Show();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchedName = tbSearchDoctorName.Text;
            if (searchedName == "Dr. Alim Akhtar Bhuiyan" || searchedName == "Dr. M. Ali" ||
                searchedName == "Dr. Gulshan Ara" || searchedName == "Prof. ATM Mowladad Chowdhury" ||
                searchedName == "Dr. Fahmida Begum" || searchedName == "Dr. Jasmin Manzoor")
            {
                frmAdminConsultancyReq fACR = new frmAdminConsultancyReq(tbSearchDoctorName.Text);
                fACR.Show();
            }
            else
            {
                MessageBox.Show("No Results Found!");
            }
        }

        private void btnShowFeedback_Click(object sender, EventArgs e)
        {
            frmFeedback fF = new frmFeedback();
            fF.Show();
        }
    }
}
