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
using CrystalDecisions.Windows.Forms;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmSpotDoctorsVisit : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        private int ADMISSION_ID = 0;
        private string AdmissionCreationDate = "";
        public frmSpotDoctorsVisit()
        {
            InitializeComponent();
            txtAdmissionId.TextAlign = HorizontalAlignment.Right;
            txtAdmissionId.Select();
            btnsave.Enabled = false;
            lblDoctor.MaximumSize = lblAddress.MaximumSize = new Size(305, 0);
            lblDoctor.AutoSize = lblAddress.AutoSize = true;
        }

        private void txtAdmissionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            var admissionSl = txtAdmissionId.Text.Trim();
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(admissionSl))
                {
                    if (admissionSl.Count(x => x == '/') != 2)
                    {
                        MessageBox.Show(@"Invalid admission id.");
                    }
                    else
                    {
                        objData.OpenConnection("AatickPC-Office", ref strErr);
                        GetDocInfoWithCommission(admissionSl);
                        ShowReport();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter admission id.");
                }
            }
        }

        private void GetDocInfoWithCommission(string admissionSl, int docId = 0, int visitId = 0)
        {
            var sql = "SELECT CAST(DL.DocID AS VARCHAR)+'@'+CAST(VC.VisitID AS VARCHAR) DocID,DL.Name+' ('+VT.VisitType+')' Name,SUM(VC.Amount*VC.VisitNo) 'Total Amount',AD.Admission_Id,AD.CreatedOn";
            sql += " FROM dbo_Admission AD INNER JOIN dbo_Admission_Consultant_Visit_Charge VC ON VC.Admission_ID=AD.Admission_Id";
            sql += " INNER JOIN dbo_Doctor_List DL ON DL.DocID=VC.Doc_ID";
            sql += " INNER JOIN dbo_VisitType VT ON VT.VisitID=VC.VisitID";
            sql += " WHERE VC.PaidOn IS NULL AND AD.Admission_SL=" + admissionSl.Split('/')[0] + " AND MONTH(AD.CreatedOn)=" + admissionSl.Split('/')[1] + " AND YEAR(AD.CreatedOn)=" + admissionSl.Split('/')[2];
            if (docId > 0)
            {
                sql += " AND VC.Doc_ID=" + docId + " AND VC.VisitID=" + visitId;
            }
            sql += " GROUP BY AD.Admission_Id,DL.DocID,DL.Name,VC.VisitID,VT.VisitType";

            var dtDoctorInfo = objData.RetriveData(sql, ref strErr);

            if (strErr == "" && dtDoctorInfo.Rows.Count > 0)
            {
                if (docId == 0)
                {

                    cmbDoctorList.DisplayMember = "Name";
                    cmbDoctorList.ValueMember = "DocId";
                    cmbDoctorList.DataSource = dtDoctorInfo;
                    cmbDoctorList.SelectedIndex = -1;
                    btnsave.Enabled = false;
                    txtPayableAmount.ResetText();
                    int.TryParse(dtDoctorInfo.Rows[0][3].ToString(), out ADMISSION_ID);
                }
                else
                {
                    txtPayableAmount.Text = dtDoctorInfo.Rows[0][2].ToString();
                    btnsave.Enabled = true;
                }
                AdmissionCreationDate = dtDoctorInfo.Rows[0][4].ToString();
            }
        }

        private void cmbDoctorList_TextChanged(object sender, EventArgs e)
        {
            cmbDoctorList.DroppedDown = false;
        }

        private void cmbDoctorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctorList.SelectedIndex > -1)
            {
                var docId = Convert.ToInt32(cmbDoctorList.SelectedValue.ToString().Split('@')[0]);
                var visitId = Convert.ToInt32(cmbDoctorList.SelectedValue.ToString().Split('@')[1]);
                var admissionSl = txtAdmissionId.Text;
                objData.OpenConnection("AatickPC-Office", ref strErr);
                GetDocInfoWithCommission(admissionSl, docId, visitId);
                objData.CloseConnection();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAdmissionId.ResetText();
            cmbDoctorList.DataSource = null;
            txtPayableAmount.ResetText();
            btnsave.Enabled = false;
            ADMISSION_ID = 0;
            crViewer.ReportSource = null;
            AdmissionCreationDate = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (
                new DateTime(DateTime.Parse(AdmissionCreationDate).Year,
                    DateTime.Parse(AdmissionCreationDate).Month, DateTime.Parse(AdmissionCreationDate).Day) <
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1))
            {
                MessageBox.Show("This is a backdated admission id.\n\nYou can not pay it here.");
                return;
            }
            var docId = Convert.ToInt32(cmbDoctorList.SelectedValue.ToString().Split('@')[0]);
            var visitId = Convert.ToInt32(cmbDoctorList.SelectedValue.ToString().Split('@')[1]);
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "UPDATE dbo_Admission_Consultant_Visit_Charge SET PaidOn=getdate(), PaidUserId=" + Utility.userID + ", PaidUserPC='" + Utility.PcName + "' WHERE Admission_ID=" + ADMISSION_ID + " AND VisitID=" + visitId + " AND Doc_ID=" + docId;
            objData.ExecuteQuery(sql, ref strErr);

            if (strErr == "")
            {
                var isPrint = MessageBox.Show("Payement successfull.\n\nDo you want to print receipt?", @"Confirm", MessageBoxButtons.YesNo);
                if (isPrint == DialogResult.Yes)
                {
                    objData.OpenConnection("AatickPC-Office", ref strErr);
                    sql = "USP_rpt_spot_visit_charge " + ADMISSION_ID + ",1," + docId;
                    var dtReport = objData.RetriveData(sql, ref strErr);
                    objData.CloseConnection();
                    var rptpath = Utility.ReportPath + "rptDoctorSpotVisit.rpt";
                    var report = new ReportDocument();
                    report.Load(rptpath);
                    report.SetDataSource(dtReport);
                    report.SetParameterValue("printedBy", Utility.UserName);
                    Utility.Print(report, rptpath, 1);
                }
                GetDocInfoWithCommission(txtAdmissionId.Text);
                txtPayableAmount.ResetText();
                ShowReport();

            }
            else
            {
                MessageBox.Show(@"An error occured.\nPlease try again later.");
            }
            objData.CloseConnection();
        }

        private void ShowReport()
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "USP_rpt_spot_visit_charge " + ADMISSION_ID;
            var dtReport = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "" && dtReport.Rows.Count > 0)
            {
                lblName.Text = dtReport.Rows[0][2].ToString();
                lblAddress.Text = dtReport.Rows[0][3].ToString();
                lblBedInfo.Text = dtReport.Rows[0][4].ToString();
                lblDoctor.Text = dtReport.Rows[0][5].ToString();

                var rptpath = Utility.ReportPath + "rptDoctorSpotVisit.rpt";
                var report = new ReportDocument();
                report.Load(rptpath);
                report.SetDataSource(dtReport);
                report.SetParameterValue("printedBy", Utility.UserName);
                crViewer.ReportSource = report;
                crViewer.ToolPanelView = ToolPanelViewType.None;
            }
            else
            {
                MessageBox.Show(@"No data found for this admission id");
            }

        }

        private void btnSpotCommission_Click(object sender, EventArgs e)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "USP_rpt_paid_visit_charge_list '" + txtDatePicker.Value.ToShortDateString() + "'";
            var dtReport = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "" && dtReport.Rows.Count > 0)
            {
                var rptpath = Utility.ReportPath + "rptPaidSpotVisitList.rpt";
                var report = new ReportDocument();
                report.Load(rptpath);
                report.SetDataSource(dtReport);
                report.SetParameterValue("printedBy", Utility.UserName);
                var reportviewer = new frmReport(report);
                reportviewer.Show(this);
            }
            else
            {
                MessageBox.Show(@"No data found in this date.");
            }
        }
    }
}
