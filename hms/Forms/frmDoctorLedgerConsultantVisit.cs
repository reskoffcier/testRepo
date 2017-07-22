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
    public partial class frmDoctorLedgerConsultantVisit : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmDoctorLedgerConsultantVisit()
        {
            InitializeComponent();
            btnsave.Enabled = false;
        }
        private void txtDoctorId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnsave.Enabled = false;
                var docId = txtDoctorId.Text.Trim();
                if (docId == "")
                {
                    MessageBox.Show("Please enter doctor id.");
                    return;
                }
                objData.OpenConnection("AatickPC-Home", ref strErr);
                var sql = "USP_Doctor_Payment_Due_Amount " + docId + ",'C'," + Utility.DCP;
                var dtDoctorPayment = objData.RetriveData(sql, ref strErr);
                if (strErr == "" && dtDoctorPayment.Rows.Count > 0)
                {
                    txtpayableamount.Text = dtDoctorPayment.Rows[0][0].ToString();
                    if (double.Parse(txtpayableamount.Text.Trim()) > 0)
                    {
                        btnsave.Enabled = true;
                    }
                }
                else
                {
                    txtpayableamount.Text = "0";
                }
                strErr = "";
                sql = "rpt_Doctor_Ledger " + docId + ",'C'," + Utility.DCP;
                var dtDoctorLedger = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (strErr == "" && dtDoctorLedger.Rows.Count > 0)
                {
                    var reportDoc = new ReportDocument();
                    var rptpath = Utility.ReportPath + "rptDoctorLedger.rpt";
                    reportDoc.Load(rptpath);
                    reportDoc.SetDataSource(dtDoctorLedger);
                    crViewer.ReportSource = reportDoc;
                    crViewer.ToolPanelView = ToolPanelViewType.None;
                }
                else
                {
                    crViewer.ReportSource = null;
                    MessageBox.Show("No ledger found.");
                }
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var docId = txtDoctorId.Text.Trim();
            var paidAmount = 0.0;
            double.TryParse(txtPaidAmount.Text.Trim(), out paidAmount);
            var payableAmount = 0.0;
            double.TryParse(txtpayableamount.Text.Trim(), out payableAmount);
            if (docId == "")
            {
                MessageBox.Show("Please enter doctor id.");
                return;
            }
            if (!(paidAmount > 0 && payableAmount > 0))
            {
                MessageBox.Show("Payable amount & paid amount must be greater than 0.");
                return;
            }
            if (paidAmount > payableAmount)
            {
                MessageBox.Show("Paid amount must be less than or equal to payable amount.");
                return;
            }
            objData.OpenConnection("AatickPC-Home", ref strErr);
            var sql = "INSERT INTO dbo_Doctor_Payment(Doc_Id,Paid_Amount,Paid_On,Paid_Type,Remarks) VALUES(" + docId + "," + paidAmount + ",getdate(),'C','" + txtremark.Text + "')";
            objData.ExecuteQuery(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "")
            {
                MessageBox.Show("Payment Successfull.");
                btnnew.PerformClick();
            }
            else
            {
                MessageBox.Show("An error occurred.\n\nTry again later.");
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            Utility.ClearAllControls(this);
            crViewer.ReportSource = null;
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
