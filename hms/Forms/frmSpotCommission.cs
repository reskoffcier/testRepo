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
    public partial class SpotCommission : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        private int investigationId = 0;
        private string InvestigationCreationDate="";
        public SpotCommission()
        {
            InitializeComponent();
            ClearFields();
            txtDatePicker.MaxDate = DateTime.Today;
        }

        private void txtinvestigationid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var arrInvSl = txtinvestigationid.Text.Trim().Split('/');
                if (arrInvSl.Length == 3)
                {
                    objData.OpenConnection("AatickPC-Office", ref strErr);
                    var strSql =
                        "SELECT PT.Name,PT.PresentAddress,DL.Title+' '+DL.Name+CHAR(13)+DL.Degree+CHAR(13)+DL.Specialist AS DocInfo";
                    strSql += " ,dbo.f_Get_Payable_Amount(INV.InvestigationID),dbo.f_get_inv_DiscountAmont(INV.InvestigationID),dbo.f_Get_Inv_PaidAmount(INV.InvestigationID),dbo.f_Get_Inv_ReturnAmount(INV.InvestigationID),INV.InvestigationID,CASE WHEN SP.Paid_Amount>0 THEN 1 ELSE CASE WHEN SP.InvestigationID IS NULL THEN 2 ELSE 0 END END IsPaid,INV.DiscountById,SP.Receive_By,INV.CreatedON ";
                    strSql += " FROM dbo_Investigation INV ";
                    strSql += " INNER JOIN dbo_Patient_info PT ON PT.P_ID=INV.P_ID";
                    strSql += " INNER JOIN dbo_Doctor_List DL ON DL.DocID=INV.DocID";
                    strSql += " LEFT JOIN Investigation_SpootCommission SP ON SP.InvestigationID=INV.InvestigationID";
                    strSql += " WHERE INV.Invetigation_SL=" + arrInvSl[0] + " AND MONTH(INV.CreatedON)=" + arrInvSl[1] + " AND YEAR(INV.CreatedON)=" + arrInvSl[2];
                    var spotCommissionInfo = objData.RetriveData(strSql, ref strErr);
                    objData.CloseConnection();
                    if (strErr == "" && spotCommissionInfo.Rows.Count > 0)
                    {

                        lblName.Text = spotCommissionInfo.Rows[0][0].ToString();
                        lblAddress.Text = spotCommissionInfo.Rows[0][1].ToString();
                        lblDoctor.Text = spotCommissionInfo.Rows[0][2].ToString();
                        lbltotalamount.Text = spotCommissionInfo.Rows[0][3].ToString();
                        lbltotaldiscount.Text = spotCommissionInfo.Rows[0][4].ToString();
                        lbltotalpayamount.Text =
                            (double.Parse(spotCommissionInfo.Rows[0][3].ToString()) -
                             double.Parse(spotCommissionInfo.Rows[0][4].ToString())).ToString();
                        lbltotalpaid.Text = spotCommissionInfo.Rows[0][5].ToString();
                        lbltotalreturn.Text = spotCommissionInfo.Rows[0][6].ToString();
                        lbltotaldue.Text =
                            (double.Parse(lbltotalpayamount.Text) -
                             double.Parse(spotCommissionInfo.Rows[0][5].ToString()) -
                             double.Parse(spotCommissionInfo.Rows[0][6].ToString())).ToString();
                        int.TryParse(spotCommissionInfo.Rows[0][7].ToString(), out investigationId);
                        InvestigationCreationDate = spotCommissionInfo.Rows[0][11].ToString();
                        btnsave.Enabled = spotCommissionInfo.Rows[0][8].ToString() != "1";
                        if (spotCommissionInfo.Rows[0][8].ToString() == "1")
                        {
                            MessageBox.Show("Already paid spot commission.");
                            txtreceiveby.Text = spotCommissionInfo.Rows[0][10].ToString();
                        }
                        ShowReport(spotCommissionInfo.Rows[0][8].ToString() == "1");
                    }
                    else
                    {
                        MessageBox.Show(@"Invalid investigation id.");
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show(@"Invalid investigation id.");
                    ClearFields();
                }
            }
        }

        private void ClearFields()
        {
            lblName.Text = lblAddress.Text = lblDoctor.Text = lbltotalamount.Text =
                            lbltotaldiscount.Text = lbltotalpayamount.Text =
                                lbltotalpaid.Text = lbltotalreturn.Text = lbltotaldue.Text = lblvat.Text = "";
            investigationId = 0;
            InvestigationCreationDate = "";
            btnsave.Enabled = false;
            crViewer.ReportSource = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtinvestigationid.Text = "";
            txtreceiveby.Text = "";
            ClearFields();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.N))
            {
                btnNew.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (
                new DateTime(DateTime.Parse(InvestigationCreationDate).Year,
                    DateTime.Parse(InvestigationCreationDate).Month, DateTime.Parse(InvestigationCreationDate).Day) <
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1))
            {
                MessageBox.Show("This is a backdated investigation.\n\nYou can not pay it here.");
                return;
            }
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "UPDATE Investigation_SpootCommission SET Paid_Amount=Payable_Amount,Payable_Amount=0,Total_Due=0,Receive_By='" + txtreceiveby.Text + "',Paid_On=GETDATE(),Update_On=GETDATE(),UserId=" + Utility.userID + ",UserPc='" + Utility.PcName + "' WHERE InvestigationID=" + investigationId;
            objData.ExecuteQuery(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "")
            {
                btnsave.Enabled = false;
                MessageBox.Show("Commission paid successfully.");
                ShowReport(true);
            }
        }

        private void ShowReport(bool isAlreadyPaid = false)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "SELECT CAST(INV.Invetigation_SL AS VARCHAR(10))+'/'+CAST(MONTH(INV.CreatedON) AS VARCHAR(2))+'/'+CAST(YEAR(INV.CreatedON) AS VARCHAR(4)) Investigation_Sl";
            sql += " ,INV.CreatedON,DL.DocID,PT.Name,CASE WHEN DL.IsPc=1 THEN 'PC' ELSE '' END PC";
            sql += " ,DL.Name DoctorName,DL.Doctor_Type,emp.Name MarketingBy,DL.Phone ,PT.Name,PT.CreatedOn PatientDate";
            sql += " ,S.Service_Name,ISI.Amount,CASE WHEN S.Commision_Type=2 THEN S.Commission ELSE (ISI.Amount*S.Commission)/100 END Commission";
            sql +=
                " ,SC.Category_Name, CASE WHEN INV.DiscountByID=3 THEN dbo.f_get_inv_DiscountAmont(INV.InvestigationID) ELSE 0 END DoctorDisCount";
            sql += " FROM dbo_Investigation INV ";
            sql += " INNER JOIN dbo_Patient_info PT ON PT.P_ID=INV.P_ID";
            sql += " INNER JOIN dbo_Doctor_List DL ON DL.DocID=INV.DocID";
            sql += " Left JOIN dbo_Employee_Profiles Emp ON Emp.EmpID=DL.MarketingBy";
            sql += " INNER JOIN dbo_InvertigationServiceItem ISI ON ISI.Investigationid=INV.InvestigationID";
            sql += " INNER JOIN Dbo_Services S ON S.Service_ID=ISI.Service_ID";
            sql += " INNER JOIN Dbo_Service_Category SC ON SC.Category_ID=S.Category_ID";
            sql += " WHERE INV.InvestigationID=" + investigationId + " AND (ISI.Return_Amount=0 OR ISI.Return_Amount IS NULL)";

            var dtReport = objData.RetriveData(sql, ref strErr);
            var reportDoc = new ReportDocument();
            var rptpath = Utility.ReportPath + "rptSpotCommission.rpt";
            reportDoc.Load(rptpath);
            reportDoc.SetDataSource(dtReport);
            var postBy = "";
            var fromPc = "";
            var receivedBy = "";
            if (isAlreadyPaid)
            {
                var sqlUser = "select U.user_name,I.UserPc,I.Receive_By from Investigation_SpootCommission I INNER JOIN dbo_Users U ON U.User_ID=I.userID WHERE InvestigationID=" + investigationId;
                var dtUser = objData.RetriveData(sqlUser, ref strErr);
                postBy = dtUser.Rows[0][0].ToString();
                fromPc = dtUser.Rows[0][1].ToString();
                receivedBy = dtUser.Rows[0][2].ToString();
            }
            objData.CloseConnection();
            reportDoc.SetParameterValue("receivedBy", receivedBy);
            reportDoc.SetParameterValue("printedBy", Utility.UserName);
            reportDoc.SetParameterValue("postBy", postBy);
            reportDoc.SetParameterValue("fromPc", fromPc);
            crViewer.ReportSource = reportDoc;
            crViewer.ToolPanelView = ToolPanelViewType.None;
        }

        private void btnSpotCommission_Click(object sender, EventArgs e)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "";
            sql = "USP_Inv_SpotCommissionList '" + txtDatePicker.Value.ToShortDateString() + "'";

            var dtReport = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            if (strErr == "" && dtReport.Rows.Count > 0)
            {
                var rptpath = Utility.ReportPath + "rptSpotCommissionList.rpt";
                var dataset = new DataSet();
                dataset.Tables.Add(dtReport);
                var reportviewer = new frmReport { ReportPath = rptpath, Reportds = dataset };
                reportviewer.Show(this);
            }
        }
    }
}
