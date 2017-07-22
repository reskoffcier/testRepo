using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using BatchDLL;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmHospitalCommission : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        private int ADMISSION_ID = 0;
        private string AdmissionCreationDate = "";
        public frmHospitalCommission()
        {
            InitializeComponent();
            btnsave.Enabled = false;
            lblDoctor.MaximumSize = new Size(300, 0);
            lblDoctor.AutoSize = true;
        }

        private void txtAdmissionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var admissionSl = txtAdmissionId.Text;
                var arrSl = admissionSl.Split('/');
                if (arrSl.Length != 3)
                {
                    MessageBox.Show(@"Invalid admission id.");
                }
                else
                {
                    objData.OpenConnection("AatickPC-Office", ref strErr);

                    var sql = "USP_rpt_hospital_commission " + arrSl[0] + "," + arrSl[1] + "," + arrSl[2] + "," + Utility.DCP;
                    var dtAdmissionInfo = objData.RetriveData(sql, ref strErr);
                    if (strErr == "" && dtAdmissionInfo.Rows.Count > 0)
                    {
                        int.TryParse(dtAdmissionInfo.Rows[0][0].ToString(), out ADMISSION_ID);
                        AdmissionCreationDate = dtAdmissionInfo.Rows[0][1].ToString();
                        lblName.Text = dtAdmissionInfo.Rows[0][3].ToString();
                        lblBedInfo.Text = dtAdmissionInfo.Rows[0][4].ToString();
                        lblDoctor.Text = dtAdmissionInfo.Rows[0][5].ToString();
                        var payable = 0.0;
                        var discount = 0.0;
                        var totalPayable = 0.0;
                        var paid = 0.0;
                        var returnAmount = 0.0;
                        var totalDue = 0.0;
                        double.TryParse(dtAdmissionInfo.Rows[0][6].ToString(), out payable);
                        double.TryParse(dtAdmissionInfo.Rows[0][7].ToString(), out discount);
                        double.TryParse(dtAdmissionInfo.Rows[0][8].ToString(), out paid);
                        double.TryParse(dtAdmissionInfo.Rows[0][9].ToString(), out returnAmount);
                        totalPayable = payable - discount;
                        totalDue = totalPayable - (paid + returnAmount);
                        lbltotalamount.Text = payable.ToString();
                        lbltotaldiscount.Text = discount.ToString();
                        lbltotalpayamount.Text = totalPayable.ToString();
                        lbltotalpaid.Text = paid.ToString();
                        lbltotalreturn.Text = returnAmount.ToString();
                        lbltotaldue.Text = totalDue.ToString();

                        var reportDoc = new ReportDocument();
                        var rptpath = Utility.ReportPath + "rptHospitalCommission.rpt";
                        reportDoc.Load(rptpath);
                        reportDoc.SetDataSource(dtAdmissionInfo);
                        reportDoc.SetParameterValue("printedBy", Utility.UserName);
                        crViewer.ReportSource = reportDoc;
                        crViewer.ToolPanelView = ToolPanelViewType.None;

                        btnsave.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Already paid commission.");
                        crViewer.ReportSource = null;
                    }
                    objData.CloseConnection();
                }
            }
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
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "UPDATE dbo_InvertigationServiceItem SET CommissionPaidOn=GETDATE(),CommissionPaidUserid=" + Utility.userID + ",CommissionPaidUserPC='" + Utility.UserName + "' WHERE Investigationid IN (SELECT INV.InvestigationID FROM dbo_Admission AD INNER JOIN dbo_Investigation INV ON INV.Admission_id=AD.Admission_Id WHERE AD.Admission_Id=" + ADMISSION_ID + ")";
            objData.ExecuteQuery(sql, ref strErr);


            sql = "INSERT INTO dbo_Admission_Doctor_Commission(Admission_Id,DocId,Commission,PaidOn,PaidUserId,PaidUserPC) SELECT AD.Admission_Id,AD.Reference_Doc_ID,dbo.f_Get_Admission_Commission(AD.Admission_Id," +
                Utility.DCP + "),GETDATE()," + Utility.userID + ",'" + Utility.PcName + "' FROM dbo_Admission AD WHERE AD.Admission_Id=" +
                ADMISSION_ID;
            objData.ExecuteQuery(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "")
            {
                var isPrint = MessageBox.Show("Payement successfull.\n\nDo you want to print receipt?", @"Confirm", MessageBoxButtons.YesNo);
                if (isPrint == DialogResult.Yes)
                {
                    Utility.Print((ReportDocument)crViewer.ReportSource, "", 1);
                }
                btnNew.PerformClick();
            }
        }

        private void btnSpotCommission_Click(object sender, EventArgs e)
        {
            var dt = txtDatePicker.Value.ToShortDateString();
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "USP_daywise_doctor_commission_paid_list '" + dt + "'";
            var dtReport = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "" && dtReport.Rows.Count > 0)
            {
                var reportDoc = new ReportDocument();
                var rptpath = Utility.ReportPath + "rptPaidDoctorCommissionList.rpt";
                reportDoc.Load(rptpath);
                reportDoc.SetDataSource(dtReport);
                reportDoc.SetParameterValue("printedBy", Utility.UserName);
                var reportviewer = new frmReport(reportDoc);
                reportviewer.Show(this);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAdmissionId.ResetText();
            lblName.Text = lblDoctor.Text = lblBedInfo.Text = "";
            lbltotalamount.Text =
                lbltotaldiscount.Text =
                    lbltotaldue.Text = lbltotalpaid.Text = lbltotalpayamount.Text = lbltotalreturn.Text = "0";
            crViewer.ReportSource = null;
            ADMISSION_ID = 0;
            btnsave.Enabled = false;
            AdmissionCreationDate = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
