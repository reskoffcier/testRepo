using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using CrystalDecisions.CrystalReports.Engine;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmPatientBill : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmPatientBill()
        {
            InitializeComponent();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdmissionId.Text.Trim()))
            {
                MessageBox.Show(@"Please select a patient.");
                return;
            }
            var isSummary = rbtnPatientSummary.Checked;
            if (rbtnPatientDetails.Checked || rbtnPatientSummary.Checked)
            {
                if (isSummary)
                {
                    objData.OpenConnection("AatickPC-Office", ref strErr);
                    var sqlBill = "USP_HospitalConsultantBill_Summery " + txtAdmissionId.Text;
                    var dtBillInfo = objData.RetriveData(sqlBill, ref strErr);
                    objData.CloseConnection();

                    var rptpath = Utility.ReportPath + "rptHospitalBill.rpt";
                    var report = new ReportDocument();
                    report.Load(rptpath);
                    report.SetDataSource(dtBillInfo);
                    report.SetParameterValue("UserName",Utility.UserName);
                    var reportviewer = new frmReport(report);
                    reportviewer.Show(this);
                }
            }
            else
            {
                MessageBox.Show(@"Please select any one report option.");
            }
        }

        private void btnPatienList_Click(object sender, EventArgs e)
        {
            new frmAdmitedPatientList() { Owner = this }.ShowDialog();
        }

        public void LoadAdmissionInfo(string addmissionSl, string admission_Id)
        {
            txtAdmissionId.Text = admission_Id;
        }
    }
}
