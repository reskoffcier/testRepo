using BatchDLL;
using hms.Include_Files;
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
    public partial class frmReportAll : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmReportAll()
        {
            InitializeComponent();
            lstFirst.DataSource = new List<object> 
             { 
                new {Text = "Hospital Monthly Collection (Sammary)", Value = "1"},
                new {Text = "Monthly Collection (Diagnostic)", Value = "2"},
                new {Text= "Total Sales And Commission (Marketing)",Value="3"},
                new {Text= "Doctors Statement",Value="4"},
                new {Text= "Doctors Refarral",Value="5"}
             };
            lstSecond.DataSource = new List<object>
            {
                new {Text = "Daily Doctor's Spot Commission List", Value = "1"},
                new {Text = "Daily Cash Collection", Value = "2"}
            };
            lstSecond.DisplayMember = "Text";
            lstSecond.ValueMember = "Value";
            lstSecond.SelectedIndex = -1;
            lstFirst.DisplayMember = "Text";
            lstFirst.ValueMember = "Value";
            lstFirst.SelectedIndex = -1;
        }

        private void lstSecond_DoubleClick(object sender, EventArgs e)
        {
            if (lstSecond.SelectedIndex > -1)
            {
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sql = "";
                if (lstSecond.SelectedValue.ToString() == "1")
                    sql = "USP_Inv_SpotCommissionReport '" + datePicker.Value.ToShortDateString() + "'";
                else if (lstSecond.SelectedValue.ToString() == "2")
                    sql = "USP_Get_DailyUserTransactionReport '" + datePicker.Value.ToShortDateString() + "','" + datePicker.Value.AddDays(1).ToShortDateString() + "'";
                
                var dtReport = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (strErr == "" && dtReport.Rows.Count > 0)
                {
                    var rptpath = Utility.ReportPath;
                    if (lstSecond.SelectedValue.ToString() == "1")
                        rptpath += "rptDailySpotCommission.rpt";
                    else if (lstSecond.SelectedValue.ToString() == "2")
                        rptpath += "rptHospitalCollection.rpt";
                    
                    var dataset = new DataSet();
                    dataset.Tables.Add(dtReport);
                    var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
                    reportviewer.Show(this);
                }
            }
        }

        private void lstFirst_DoubleClick(object sender, EventArgs e)
        {
            if (lstFirst.SelectedIndex > -1)
            {
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sql = "";
                if (lstFirst.SelectedValue.ToString() == "2")
                    sql = "rpt_USP_inv_Monthly_Report '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(1).ToShortDateString() + "'";
                else if (lstFirst.SelectedValue.ToString() == "1")
                    sql = "rpt_USP_Hospital_Monthly_Collection_summery '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(0).ToShortDateString() + "'";
                else if (lstFirst.SelectedValue.ToString() == "3")
                    sql = "rpt_USP_Marketing_Total_sales_Commission '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(1).ToShortDateString() + "'";
                var dtReport = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (strErr == "" && dtReport.Rows.Count > 0)
                {
                    var rptpath = Utility.ReportPath;
                    if (lstFirst.SelectedValue.ToString() == "2")
                        rptpath += "rptMonthlyCollectionDiagnostic.rpt";
                    else if (lstFirst.SelectedValue.ToString() == "1")
                        rptpath += "rptHospitalMonthlySummary.rpt";
                    else if (lstFirst.SelectedValue.ToString() == "3")
                        rptpath += "rptMonthlyTotalsalesComissionInvest.rpt";
                    var dataset = new DataSet();
                    dataset.Tables.Add(dtReport);
                    var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
                    reportviewer.Show(this);
                }
            }
        }
    }
    }

