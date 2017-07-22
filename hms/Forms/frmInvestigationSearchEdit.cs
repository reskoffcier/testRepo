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
    public partial class frmInvestigationSearchEdit : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmInvestigationSearchEdit()
        {
            InitializeComponent();
            lstInvestigationList.Columns.Add("Investigation Id");
            lstInvestigationList.Columns.Add("Name");
            lstInvestigationList.Columns.Add("Id");
            lstInvestigationList.Columns.Add("PId");

            var width = lstInvestigationList.Width - 5;
            lstInvestigationList.Columns[0].Width = width / 2;
            lstInvestigationList.Columns[1].Width = width / 2;
            for (var i = 2; i < lstInvestigationList.Columns.Count; i++)
            {
                lstInvestigationList.Columns[i].Width = 0;
            }
            dtStartDate.Value = DateTime.Today.AddMonths(-3);
            dtenddate.Value = DateTime.Today;
            LoadDoctorList();
            btnsave.Enabled = false;
        }

        private void LoadInvestigationInfo(string searchText = "", string invid = "")
        {
            var startdate = dtStartDate.Value.ToShortDateString();
            var enddate = dtenddate.Value.AddDays(1).ToShortDateString();
            //MessageBox.Show(startdate + "\n" + enddate);
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlInvestigationList = "SELECT CAST(I.Invetigation_SL AS VARCHAR(10))+'/'+CAST(MONTH(I.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(I.CreatedOn) AS VARCHAR(4)) AS SL_NO,PT.Name,I.InvestigationID,I.P_Id FROM dbo_Investigation I INNER JOIN dbo_Patient_info PT ON PT.P_ID=I.P_ID WHERE I.CreatedOn>='" + startdate + "' AND I.CreatedOn<='" + enddate + "'" + (searchText != "" ? " AND CAST(I.Invetigation_SL AS VARCHAR(10))+'/'+CAST(MONTH(I.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(I.CreatedOn) AS VARCHAR(4)) like '%" + searchText + "%'" : "") + " Order by I.CreatedOn Desc";
            var dtInvestigationList = objData.RetriveData(sqlInvestigationList, ref strErr);
            objData.CloseConnection();
            lstInvestigationList.Items.Clear();
            for (var i = 0; i < dtInvestigationList.Rows.Count; i++)
            {
                var listviewitem = new ListViewItem(dtInvestigationList.Rows[i][0].ToString());
                listviewitem.SubItems.Add(dtInvestigationList.Rows[i][1].ToString());
                listviewitem.SubItems.Add(dtInvestigationList.Rows[i][2].ToString());
                listviewitem.SubItems.Add(dtInvestigationList.Rows[i][3].ToString());
                lstInvestigationList.Items.Add(listviewitem);
            }
            btnsave.Enabled = false;
            lstdocinformation.SelectedIndex = -1;
            Utility.ClearAllControls(this);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            LoadInvestigationInfo();
        }

        private void LoadDoctorList()
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSQL = "";
            strSQL = "select DocID, Name from dbo_Doctor_List order by Name";
            var doctorList = objData.RetriveData(strSQL, ref strErr);
            if (strErr == "")
            {
                lstdocinformation.DataSource = doctorList;
                lstdocinformation.DisplayMember = "Name";
                lstdocinformation.ValueMember = "DocID";
            }
            lstdocinformation.SelectedIndex = -1;
            objData.CloseConnection();
        }

        private void lstInvestigationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            if (lstInvestigationList.SelectedItems.Count > 0)
            {
                for (var i = 0; i < lstInvestigationList.Items.Count; i++)
                {
                    lstInvestigationList.Items[i].BackColor = Color.White;
                }
                lstInvestigationList.SelectedItems[0].BackColor = Color.DodgerBlue;
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sqlInvestigationList = "SELECT CAST(I.Invetigation_SL AS VARCHAR(10))+'/'+CAST(MONTH(I.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(I.CreatedOn) AS VARCHAR(4)) AS SL_NO,PT.Name,I.InvestigationID,PT.PresentAddress,PT.Phone,PT.Year,PT.Month,PT.Day,PT.Gender,I.DocId,I.P_ID FROM dbo_Investigation I INNER JOIN dbo_Patient_info PT ON PT.P_ID=I.P_ID WHERE I.InvestigationID=" + lstInvestigationList.SelectedItems[0].SubItems[2].Text;
                var dtInvestigationList = objData.RetriveData(sqlInvestigationList, ref strErr);
                objData.CloseConnection();
                txtInvestigationID.Text = dtInvestigationList.Rows[0][0].ToString();
                txtname.Text = dtInvestigationList.Rows[0][1].ToString();
                txtaddress.Text = dtInvestigationList.Rows[0][3].ToString();
                txtphone.Text = dtInvestigationList.Rows[0][4].ToString();
                txtyear.Text = dtInvestigationList.Rows[0][5].ToString();
                txtmonth.Text = dtInvestigationList.Rows[0][6].ToString(); ;
                txtday.Text = dtInvestigationList.Rows[0][7].ToString();
                txtsex.Text = dtInvestigationList.Rows[0][8].ToString();
                lstdocinformation.SelectedValue = dtInvestigationList.Rows[0][9].ToString();
                btnsave.Enabled = true;
                ShowInvestigationReport(lstInvestigationList.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void lstInvestigationList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstInvestigationList.Columns[e.ColumnIndex].Width;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            LoadInvestigationInfo(txtInvestigationID.Text);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var docId = lstdocinformation.SelectedValue;
            var invId = lstInvestigationList.SelectedItems[0].SubItems[2].Text;
            var name = txtname.Text;
            var address = txtaddress.Text;
            var phone = txtphone.Text;
            var year = txtyear.Text;
            var month = txtmonth.Text;
            var day = txtday.Text;
            var sex = txtsex.Text;
            var pid = lstInvestigationList.SelectedItems[0].SubItems[3].Text;
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSQL = "UPDATE dbo_Patient_info SET Name='" + name + "',Phone='" + phone + "',PresentAddress='" + address + "',Year=" + year + ",Month=" + month + ",Day=" + day + ",Gender='" + sex + "',UserId=" + Utility.userID + ",UserPc='" + Utility.PcName + "' WHERE P_ID=" + pid;
            strSQL += ";UPDATE dbo_Investigation SET DocId=" + docId + ",UserId=" + Utility.userID + ",UserPc='" + Utility.PcName + "' WHERE InvestigationID=" + invId;
            objData.ExecuteQuery(strSQL, ref strErr);
            objData.CloseConnection();
            if (strErr == "")
            {
                MessageBox.Show("Update successfully.");
                ShowInvestigationReport(invId);
            }
        }

        private void ShowInvestigationReport(string invId)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlInvestigation ="select *  from v_investigation where InvestigationID  =  " + invId;
            var StrSQL = "Select DiscountByID, dbo.f_get_inv_DiscountAmont(InvestigationID), dbo.f_Get_Inv_ReturnAmount(InvestigationID) From dbo_Investigation where InvestigationID = " + invId;
            var dtInvestigation = objData.RetriveData(sqlInvestigation, ref strErr);
            var DisINfo = objData.RetriveData(StrSQL, ref strErr);
            objData.CloseConnection();
            var reportDoc = new ReportDocument();
            var dataset = new DataSet();
            dataset.Tables.Add(dtInvestigation);
            var rptpath = Utility.ReportPath + "rptInvestigation.rpt";
            reportDoc.Load(rptpath);

            reportDoc.SetDataSource(dataset.Tables[0]);
            reportDoc.SetParameterValue("discount_amount", DisINfo.Rows[0][1].ToString());
            reportDoc.SetParameterValue("discountBy", DisINfo.Rows[0][0].ToString());
            reportDoc.SetParameterValue("return_amount", DisINfo.Rows[0][2].ToString());
            reportDoc.SetParameterValue("UserName", Utility.UserName);
            reportDoc.SetParameterValue("IsDuplicate", 1);

            crViewer.ReportSource = reportDoc;
            crViewer.ToolPanelView = ToolPanelViewType.None;
        }
    }
}
