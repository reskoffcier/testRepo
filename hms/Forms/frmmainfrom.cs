using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hms.Forms
{
    public partial class frmmainfrom : Form
    {
        public frmmainfrom()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frontDeskInvestigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmfrontdeskinvestigation {MdiParent = this};
            f.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frontDeskInvestigationDueCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmInvestigationDueCollection {MdiParent = this};
            f.Show();
        }

        private void frontDeskSearchbEdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmInvestigationSearchEdit {MdiParent = this};
            f.Show();
        }

        private void investigationReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmInvestigationReturn {MdiParent = this};
            f.Show();
        }

        private void reportDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmReportDelivery {MdiParent = this};
            f.Show();
        }

        private void hospitalAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHopitalAdmissionFront {MdiParent = this};
            f.Show();
        }

        private void hospitalDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHospitalDeposit {MdiParent = this};
            f.Show();
        }

        private void hospitalOtherServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHospitalOtherService {MdiParent = this};
            f.Show();
        }

        private void consultantVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmConsultantVisit {MdiParent = this};
            f.Show();
        }

        private void sampleCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmInvestigationsamplecollection {MdiParent = this};
            f.Show();
        }

        private void pathologyProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPathologylab {MdiParent = this};
            f.Show();
        }

        private void doctorsInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoctorsInformation {MdiParent = this};
            f.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCategory {MdiParent = this};
            f.Show();
        }

        private void serviceItemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmserviceiteminformation {MdiParent = this};
            f.Show();
        }

        private void serviceWiseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmServiceWiseList();
            f.MdiParent = this;
            f.Show();
        }

        private void employeeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmEmployeeProfile {MdiParent = this};
            f.Show();
        }

        private void bedSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBedEntry {MdiParent = this};
            f.Show();
        }

        private void hospitalDischargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHospitalDischargeFornt {MdiParent = this};
            f.Show();
        }

        private void refferalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoctorsLedgerInvestigation {MdiParent = this};
            f.Show();
        }

        private void patientBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPatientBill {MdiParent = this};
            f.Show();
        }

        private void doctorsSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoctorsSearch {MdiParent = this};
            f.Show();
        }

        private void spotCommessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SpotCommission {MdiParent = this};
            f.Show();
        }

        private void dischaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPatientBedTransfer {MdiParent = this};
            f.Show();
        }

        private void frmmainfrom_Load(object sender, EventArgs e)
        {
            lblUserName.Text = hms.Include_Files.Utility.UserName;
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new frmHospitalReport {MdiParent = this};
            f.Show();
        }

        private void mISReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmReportAll {MdiParent = this};
            f.Show();
        }

        private void spotPrecedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmSpotProcedure {MdiParent = this};
            f.Show();
        }

        private void spotDoctorsVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmSpotDoctorsVisit {MdiParent = this};
            f.Show();
        }

        private void statusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new frmStatus {MdiParent = this};
            f.Show();
        }

        private void dailyServiceReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDailyServiceReplace {MdiParent = this};
            f.Show();
        }

        private void hospitalCommissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHospitalCommission {MdiParent = this};
            f.Show();
        }

        private void investigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoctorsLedgerInvestigation() { MdiParent = this };
            f.Show();
        }

        private void indoorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmIndDoctorLedger() { MdiParent = this };
            f.Show();
        }

        private void consultantTeamChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoctorLedgerConsultantVisit() { MdiParent = this };
            f.Show();
        } 

        private void marketingTargetSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmMarketingTargetSetup() { MdiParent = this };
            f.Show();
        }

        private void marketingTargetAdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmMarketingTargetAdjustForm() { MdiParent = this };
            f.Show();
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPharmacyCatagorySetup() { MdiParent = this };
            f.Show();
        }

        private void medicineInfoSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmMedicineInfoSetupForm() { MdiParent = this };
            f.Show();
        }

        private void purchasesInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPharmacyPurchasesInputForm() { MdiParent = this };
            f.Show();
        }

        private void purchasesOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPharmacySalesForm() { MdiParent = this };
            f.Show();
        }
    }
}
