using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using hms.Include_Files;
using CrystalDecisions.CrystalReports.Engine;

namespace hms.Forms
{
    public partial class frmHospitalReport : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmHospitalReport()
        {
            InitializeComponent();
            lstFirst.DataSource = new List<object>
            {
                new {Text = "Discharge Register", Value = "1"},
                new {Text = "Monthly Collection Admitted Patient", Value = "2"},
                new {Text = "Monthly Total Sales & Commission", Value = "3"}
            };

            lstFirst.DisplayMember = "Text";
            lstFirst.ValueMember = "Value";


            lstSecond.DataSource = new List<object>
            {
                new {Text = "List Of Admission", Value = "1"},
                new {Text = "List Of Discharge", Value = "2"}
            };
            lstSecond.DisplayMember = "Text";
            lstSecond.ValueMember = "Value";
            lstFirst.SelectedIndex = lstSecond.SelectedIndex = -1;
        }

        private void lstFirst_DoubleClick(object sender, EventArgs e)
        {
            if (lstFirst.SelectedIndex > -1)
            {
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sql = "";
                if (lstFirst.SelectedValue.ToString() == "1")
                    sql = "USP_Admission_DischageList '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(1).ToShortDateString() + "'";
                else if (lstFirst.SelectedValue.ToString() == "2")
                    sql = "rpt_USP_Hospital_Monthly_Collection '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(0).ToShortDateString() + "'";
                else if (lstFirst.SelectedValue.ToString() == "3")
                    sql = "rpt_USP_Hospital_Marketing_Total_sales_Commission '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(0).ToShortDateString() + "'";

                var dtReport = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (strErr == "" && dtReport.Rows.Count > 0)
                {
                    var rptpath = Utility.ReportPath;
                    if (lstFirst.SelectedValue.ToString() == "1")
                        rptpath += "rptDischargedPatientList.rpt";
                   else if (lstFirst.SelectedValue.ToString() == "2")
                        rptpath += "rptHospitalMonthlyCollection.rpt";
                   else if (lstFirst.SelectedValue.ToString() == "3")
                        rptpath += "rptAPTotalSalesCommistionMarketing.rpt";
                    var dataset = new DataSet();
                    dataset.Tables.Add(dtReport);
                    var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
                    reportviewer.Show(this);
                }
            }

            //if (lstFirst.SelectedIndex > -2)
            //{
            //    objData.OpenConnection("AatickPC-Office", ref strErr);
            //    var sql = "";
            //    if (lstFirst.SelectedValue.ToString() == "2")
            //        sql = "rpt_USP_Hospital_Monthly_Collection '" + dateFrom.Value.ToShortDateString() + "','" + dateTo.Value.AddDays(1).ToShortDateString() + "'";

            //    var dtReport = objData.RetriveData(sql, ref strErr);
            //    objData.CloseConnection();
            //    if (strErr == "" && dtReport.Rows.Count > 0)
            //    {
            //        var rptpath = Utility.ReportPath;
            //        if (lstFirst.SelectedValue.ToString() == "2")
            //            rptpath += "rptHospitalMonthlyCollection.rpt";
            //        var dataset = new DataSet();
            //        dataset.Tables.Add(dtReport);
            //        var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
            //        reportviewer.Show(this);
            //    }
            //}

        }

        private void lstSecond_DoubleClick(object sender, EventArgs e)
        {
            if (lstSecond.SelectedIndex > -1)
            {
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sql = "";
                if (lstSecond.SelectedValue.ToString() == "1")
                    sql = "USP_Admission_AdmitedList "; //'" + datePicker.Value.ToShortDateString() + "','" + datePicker.Value.AddDays(1).ToShortDateString() + "'";
                else if (lstSecond.SelectedValue.ToString() == "2")
                    sql = "USP_Admission_DischageList '" + datePicker.Value.ToShortDateString() + "','" + datePicker.Value.AddDays(1).ToShortDateString() + "'";
                var dtReport = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (strErr == "" && dtReport.Rows.Count > 0)
                {
                    var rptpath = Utility.ReportPath;
                    if (lstSecond.SelectedValue.ToString() == "1")
                        rptpath += "rptAdmittedPatientList.rpt";
                    else if (lstSecond.SelectedValue.ToString() == "2")
                        rptpath += "rptDischargedPatientList.rpt";
                    var dataset = new DataSet();
                    dataset.Tables.Add(dtReport);
                    var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
                    reportviewer.Show(this);
                }
            }
        }

        private void btnShow_ad_Click(object sender, EventArgs e)
        {
            ShowReport(txtadmissionId_ad.Text, true);
        }

        private void btnShow_bill_Click(object sender, EventArgs e)
        {
            ShowReport(txtAdmissionId_bill.Text, false);
        }

        private void ShowReport(string admissionSl, bool isAdmission)
        {
            strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSQL = "";
            if (isAdmission)
            {
                strSQL = "SELECT Top 1 CAST(Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) Admission_SL";
                strSQL += " ,BI.Name Bed_Name,PI.Name,AD.CreatedOn,PI.Year,PI.Month,PI.Day,PI.Gender";
                strSQL += " ,DL.Title+' '+DL.Name+','+DL.Degree+','+DL.Specialist+',Phone: '+dl.Phone DoctorInfo";
                strSQL += " ,PO.ForH_Name,PO.Mother_Name,PI.PresentAddress,PO.Parmanent_address,PO.Region,PO.Occupation";
                strSQL += " ,PO.Guardian,PO.Guardian_Relation,po.Gurdian_Address,PI.Phone";
                strSQL += " ,ADO.Provisional_Diagnosis,ADO.ListOfDiagnosis,PB.Booked_On,U.Name UserName,BI.BI_Number BedNo";
                strSQL +=
                    " FROM dbo_Admission AD INNER JOIN dbo_Admission_other_info ADO ON ADO.Admission_Id=AD.Admission_Id ";
                strSQL += " INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID ";
                strSQL += " INNER JOIN dbo_Patient_other_info PO ON PO.P_ID=AD.P_ID ";
                strSQL += " LEFT JOIN Patient_Bed PB ON PB.Admission_id=AD.Admission_Id";
                strSQL += " LEFT JOIN Bed_Information BI ON BI.BI_ID=PB.BI_ID";
                strSQL += " LEFT JOIN dbo_Users U ON U.User_Id=AD.UserId";
                strSQL += " LEFT JOIN dbo_Doctor_List DL ON DL.DocID=AD.Under_Doc_ID WHERE AD.Admission_SL=" + admissionSl.Split('/')[0] + " AND MONTH(AD.CreatedOn)=" + admissionSl.Split('/')[1] + " AND YEAR(AD.CreatedOn)=" + admissionSl.Split('/')[2] + " order by PB.Booked_On desc";
            }
            else
            {
                strSQL = "USP_HospitalConsultantBill_Summery null,'" + admissionSl + "'";
            }
            var dtReport = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            if (strErr == "" && dtReport.Rows.Count > 0)
            {
                if (isAdmission)
                {
                    var rptpath = Utility.ReportPath +  "rptAdmissionForm.rpt";
                    var dataset = new DataSet();
                    dataset.Tables.Add(dtReport);
                    var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
                    reportviewer.Show(this);
                }
                else
                {
                    var rptpath = Utility.ReportPath + "rptHospitalBill.rpt";
                    var report = new ReportDocument();
                    report.Load(rptpath);
                    report.SetDataSource(dtReport);
                    report.SetParameterValue("UserName", Utility.UserName);
                    var reportviewer = new frmReport(report);
                    reportviewer.Show(this);
                }
            }
        }
    }
}
