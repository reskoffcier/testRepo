using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using hms.Include_Files;


namespace hms.Forms
{
    public partial class frmPathologyLabProcess : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        public string strErr = "";
        public string InvId = ""
;
        public frmPathologyLabProcess(string PathInvID)
        {
            InitializeComponent();
            InvId = PathInvID;
        }

        private void frmPathologyLabProcess_Load(object sender, EventArgs e)
        {
            //var parentWindow = ((frmPathologylab)this.Owner);
            //var invID = parentWindow.loadInvestigationID();
            txtInvestigstionID.Text = InvId;

            objData.OpenConnection("AzharPC-Office", ref strErr);
            fillGdv();
            //loadReport();
            objData.CloseConnection();

        }

        private void loadReport()
        {
            var strSql = "usp_Inv_LabReport " + txtInvestigstionID.Text;
            var dtResult = objData.RetriveData(strSql, ref strErr);

            var strSqlDocReportComplete = "select top 1  U.Name From dbo_Investigation I Inner join dbo_InvertigationServiceItem items on i.InvestigationID = items.Investigationid  Inner join  Investigation_Serviceitem_History H on items.ISI_ID = H.ISI_ID  inner join dbo_Users U On H.UserID = U.User_ID    Where i.InvestigationID = " + txtInvestigstionID.Text + " and H.Status = 3";
            var strSqlDocReportApprove = "select top 1  D.Title ,D.Name, D.Degree, D.Specialist From dbo_Investigation I Inner join dbo_InvertigationServiceItem items on i.InvestigationID = items.Investigationid 	Inner join  Investigation_Serviceitem_History H on items.ISI_ID = H.ISI_ID 	inner join dbo_Users U On H.UserID = U.User_ID 	inner join dbo_Doctor_List D On U.DocID = D.DocID  Where i.InvestigationID = "+txtInvestigstionID.Text+" and H.Status = 4";

            var strDocReportCompleteName = "";

            
            var dtDocReportComplete = objData.RetriveData(strSqlDocReportComplete, ref strErr);

            if (strErr == "")
            {
                if (dtDocReportComplete.Rows.Count > 0)
                {
                    strDocReportCompleteName = dtDocReportComplete.Rows[0][0].ToString();
                }
            }
            var strDocReportApproveName = "";
            var strDocReportApproveTitle = "";
            var strDocReportApproveDegree = "";
            var strDocReportApproveSpecialst = "";
            var dtDocReportApprove = objData.RetriveData(strSqlDocReportApprove, ref strErr);

            if (strErr == "")
            {
                if (dtDocReportApprove.Rows.Count > 0)
                {
                    strDocReportApproveName = dtDocReportApprove.Rows[0][1].ToString();
                    strDocReportApproveTitle = dtDocReportApprove.Rows[0][0].ToString();
                    strDocReportApproveDegree = dtDocReportApprove.Rows[0][2].ToString();
                    strDocReportApproveSpecialst = dtDocReportApprove.Rows[0][3].ToString();
                }
            }


            var reportDoc = new ReportDocument();
            var dataset = new DataSet();
            dataset.Tables.Add(dtResult);
            var rptpath = Utility.ReportPath + "rptLabReportPath.rpt";
            reportDoc.Load(rptpath);
            reportDoc.SetDataSource(dataset.Tables[0]);
            reportDoc.SetParameterValue("ReportCompleteName", strDocReportCompleteName);
            reportDoc.SetParameterValue("DocReportApproveName", strDocReportApproveName);
            reportDoc.SetParameterValue("DocReportApproveTitle", strDocReportApproveTitle);
            reportDoc.SetParameterValue("DocReportApproveDegree", strDocReportApproveDegree);
            reportDoc.SetParameterValue("DocReportApproveSpecialst", strDocReportApproveSpecialst);
            reportDoc.SetParameterValue("UserName", Utility.UserName);



            crViewer.ReportSource = reportDoc;
            crViewer.ToolPanelView = ToolPanelViewType.None;
        }

        private void fillGdv()
        {
            //throw new NotImplementedException();

            var strSql = "";
            strSql = "select cast(inv.Invetigation_SL as varchar(6))+'/'+cast( MONTH(inv.CreatedON) as varchar(2))+'/'+cast(year(inv.CreatedON) as varchar(4)) investigation ";
            strSql = strSql + ", s.Service_Name, test.OGroup, test.Entity, TResult.Result, test.Unit, test.RefRenge, test.Result_B, test.SIT_ID,  inv.InvestigationID ";
            strSql = strSql + "From dbo_Investigation Inv inner join dbo_InvertigationServiceItem InvItem on inv.InvestigationID = InvItem.Investigationid ";
            strSql = strSql + "inner join Dbo_Services S on InvItem.Service_ID = s.Service_ID ";
            strSql = strSql + "inner JOin Dbo_service_Itemwise_Test test On test.Service_ID = InvItem.Service_ID ";
            strSql = strSql + "left Join InvertigationServiceItemwise_testResult TResult On test.SIT_ID = TResult.SIT_ID  and TResult.InvestigationID = inv.InvestigationID ";
            strSql = strSql + "where inv.Investigationid = "+txtInvestigstionID.Text;

            var arrResult = objData.RetriveData(strSql, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(arrResult);
            dgvPathologyLabProcess.DataSource = ds.Tables["Table1"];
            dgvPathologyLabProcess.Columns["InvestigationID"].Visible = false;
        }

        private void btnSane_Click(object sender, EventArgs e)
        {

            var strSql = "";
            //var strSqlInvItem = "";
            DataTable arrData;

            objData.OpenConnection("AzharPC-Office", ref strErr);

            objData.BeginTransaction(ref strErr);

            for (int i = 0; i < dgvPathologyLabProcess.Rows.Count - 1; i++)
            {
                if (strErr == "")
                {
                    if (dgvPathologyLabProcess.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        strSql = "select ID From InvertigationServiceItemwise_testResult Where SIT_ID =" + dgvPathologyLabProcess.Rows[i].Cells[8].Value + " and InvestigationID =" + dgvPathologyLabProcess.Rows[i].Cells[9].Value;
                        arrData = objData.RetriveData(strSql, ref strErr);

                        if (arrData.Rows.Count > 0)
                        {
                            strSql = "update InvertigationServiceItemwise_testResult set Result= '" + dgvPathologyLabProcess.Rows[i].Cells[4].Value + "' Where SIT_ID =" + dgvPathologyLabProcess.Rows[i].Cells[8].Value + " and InvestigationID =" + dgvPathologyLabProcess.Rows[i].Cells[9].Value;
                            //MessageBox.Show(strSql);
                            objData.ExecuteQuery(strSql, ref strErr);

                        }
                        else
                        {
                            strSql = "Insert into InvertigationServiceItemwise_testResult (SIT_ID,InvestigationID, Result) values(" + dgvPathologyLabProcess.Rows[i].Cells[8].Value + "," + dgvPathologyLabProcess.Rows[i].Cells[9].Value + ",'" + dgvPathologyLabProcess.Rows[i].Cells[4].Value + "')";
                            //MessageBox.Show(strSql);
                            objData.ExecuteQuery(strSql, ref strErr);
                        }
                    }
                }
            }

            if (strErr == "")
            {
                objData.CommitTransaction(ref strErr);
            }
            else
            {
                objData.Rollback(ref strErr);
            }
            if (strErr == "")
            {
                fillGdv();
                //loadReport();
            }
            objData.CloseConnection();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            objData.OpenConnection("AzharPC-Office", ref strErr);
            loadReport();
            objData.CloseConnection();
        }
    }
}
