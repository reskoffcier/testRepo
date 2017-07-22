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

namespace hms.Forms
{
    public partial class frmReportDelivery : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        public string strErr = "";
        public frmReportDelivery()
        {
            InitializeComponent();
            cmbInvestigation.DataSource = new List<object>
            {
                new {Text = "Receive", Value = "1"},
                new {Text = "Delivery", Value = "2"},
                new {Text = "Row Delivery", Value = "3"}
            };
            cmbInvestigation.DisplayMember = "Text";
            cmbInvestigation.ValueMember = "Value";
            cmbInvestigation.BackColor = Color.White;
            cmbInvestigation.SelectedIndex = 0;
            btnReceive.Enabled = true;
            btnDeliver.Enabled = false;
            btnRowDeliver.Enabled = false;
        }

        private void frmReportDelivery_Load(object sender, EventArgs e)
        {
            objData.OpenConnection("AzharPC-Office", ref strErr);
            frmLoad();
            objData.CloseConnection();
        }
        private void clearGrid()
        {
            dgvFontDeskReport.Columns.Clear();
            dgvFontDeskReport.Refresh();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "";
            dgvFontDeskReport.Columns.Insert(0, checkBoxColumn);


        }
        private void frmLoad()
        {
            clearGrid();
            lblPName.Text = "";
            lblPAddress.Text = "";
            lblDoc.Text = "";
            lbltotalamount.Text = "";
            lbltotalpayamount.Text = "";
            lbltotaldiscount.Text = "";
            lblvat.Text = "";
            lbltotalpayamount.Text = "";
            lbltotalpaid.Text = "";
            lbltotalreturn.Text = "";
            lbltotaldue.Text = "";
            //throw new NotImplementedException();
            var strSql = "";
            strSql = "select ROW_NUMBER() over( order by inv.InvestigationID) SL,cast(inv.Invetigation_SL as varchar(6))+'/'+cast( MONTH(inv.CreatedON) as varchar(2))+'/'+cast(year(inv.CreatedON) as varchar(4)) investigation, S.Service_Name TestName,invItem.ReceivedOn, invItem.Delivered, invItem.DeliveryOn, inv.Investigationid, invItem.ISI_ID   ";
            strSql = strSql + "from dbo_Investigation inv inner join dbo_InvertigationServiceItem invItem on inv.InvestigationID =invItem.Investigationid   ";
            strSql = strSql + "inner join Dbo_Services S On invItem.Service_ID = s.Service_ID   ";
            strSql = strSql + "left join Dbo_service_Itemwise_Test ST On s.Service_ID = st.Service_ID   ";
            //strSql = strSql +"where invItem.Status in (4)";

            DataTable arrData = objData.RetriveData(strSql, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(arrData);
            dgvFontDeskReport.DataSource = ds.Tables["Table1"];
            dgvFontDeskReport.Columns["Investigationid"].Visible = false;
            dgvFontDeskReport.Columns["ISI_ID"].Visible = false;
            btnDeliver.Enabled = false;
            btnReceive.Enabled = true;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            objData.OpenConnection("AzharPC-Office", ref strErr);
            frmLoad();
            objData.CloseConnection();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.N))
            {
                btnnew.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void chkAllSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllSelect.Checked == true)
            {
                for (int i = 0; i < dgvFontDeskReport.Rows.Count - 1; i++)
                {
                    dgvFontDeskReport.Rows[i].Cells[0].Value = "True";
                }
            }
            else
            {
                for (int i = 0; i < dgvFontDeskReport.Rows.Count - 1; i++)
                {
                    dgvFontDeskReport.Rows[i].Cells[0].Value = "False";
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            string strSqlUpdateItems = "";
            string strSqlInsertHistory = "";
            string strIDs = "";

            if (Convert.ToInt32(dgvFontDeskReport.Rows.Count) - 1 > 0)
            {
                for (int i = 0; i < dgvFontDeskReport.Rows.Count - 1; i++)
                {
                    if ((bool)dgvFontDeskReport.Rows[i].Cells[0].FormattedValue == true)
                    {
                        if (strIDs == "")
                        {
                            strIDs = dgvFontDeskReport.Rows[i].Cells[8].Value.ToString();
                            strSqlInsertHistory = " (" + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString() + ", 5," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                        }
                        else
                        {
                            strIDs = strIDs + ", " + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString();
                            strSqlInsertHistory = strSqlInsertHistory + ", (" + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString() + ", 5," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                        }
                    }
                }
            }

            if (strIDs != "")
            {
                strSqlUpdateItems = "Update dbo_InvertigationServiceItem SET Status=5, ReceivedOn= getdate() where [ISI_ID] in (" + strIDs.ToString() + ")";
                strSqlInsertHistory = "insert into Investigation_Serviceitem_History (ISI_ID, Status, UserID, UserPC) values " + strSqlInsertHistory;

                objData = new C_Data_Batch();
                objData.OpenConnection("AzharPC-Home", ref strErr);

                objData.BeginTransaction(ref strErr);
                if (strErr.ToString() == "")
                {
                    objData.ExecuteQuery(strSqlUpdateItems, ref strErr);
                    if (strErr.ToString() == "")
                    {
                        objData.ExecuteQuery(strSqlInsertHistory, ref strErr);
                        if (strErr.ToString() == "")
                        {
                            MessageBox.Show("Report Collection succefully done.");
                            objData.CommitTransaction(ref strErr);
                            frmLoad();
                            //txtInvestigationID_KeyPress;
                        }
                        else
                        {
                            objData.Rollback(ref strErr);
                            MessageBox.Show("System cannot deal at this moment.");
                        }
                    }
                    else
                    {
                        objData.Rollback(ref strErr);
                        MessageBox.Show("System cannot deal at this moment.");
                    }
                }

            }
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {

            var tD = 0;
            if (lbltotaldue.Text == "")
            {
                tD = 0;
            }
            else
            {
                tD = Convert.ToInt16(lbltotaldue.Text.ToString());
                if (tD > 0)
                {
                    MessageBox.Show("Please paid the due collection");
                }
                else
                {
                    string strSqlUpdateItems = "";
                    string strSqlInsertHistory = "";
                    string strIDs = "";

                    if (Convert.ToInt32(dgvFontDeskReport.Rows.Count) - 1 > 0)
                    {
                        for (int i = 0; i < dgvFontDeskReport.Rows.Count - 1; i++)
                        {
                            if ((bool)dgvFontDeskReport.Rows[i].Cells[0].FormattedValue == true)
                            {
                                if (strIDs.ToString() == "")
                                {
                                    strIDs = dgvFontDeskReport.Rows[i].Cells[8].Value.ToString();
                                    strSqlInsertHistory = " (" + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString() + ", 6," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                                }
                                else
                                {
                                    strIDs = strIDs + ", " + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString();
                                    strSqlInsertHistory = strSqlInsertHistory + ", (" + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString() + ", 6," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                                }
                            }
                        }
                    }

                    if (strIDs != "")
                    {
                        strSqlUpdateItems = "Update dbo_InvertigationServiceItem SET Status=6, Delivered= getdate() where [ISI_ID] in (" + strIDs + ")";
                        strSqlInsertHistory = "insert into Investigation_Serviceitem_History (ISI_ID, Status, UserID,userPC) values " + strSqlInsertHistory;

                        //objData = new C_Data_Batch();
                        objData.OpenConnection("AzharPC-Home", ref strErr);

                        objData.BeginTransaction(ref strErr);
                        if (strErr == "")
                        {
                            objData.ExecuteQuery(strSqlUpdateItems, ref strErr);
                            if (strErr == "")
                            {
                                objData.ExecuteQuery(strSqlInsertHistory, ref strErr);
                                if (strErr == "")
                                {
                                    MessageBox.Show("Report Delivery succefully done.");
                                    objData.CommitTransaction(ref strErr);
                                    frmLoad();
                                }
                                else
                                {
                                    objData.Rollback(ref strErr);
                                    MessageBox.Show("System cannot deal at this moment.");
                                }
                            }
                            else
                            {
                                objData.Rollback(ref strErr);
                                MessageBox.Show("System cannot deal at this moment.");
                            }
                        }

                    }
                }
            }




        }

        private void txtInvestigationID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                getdata();
            }

        }

        private void getdata()
        {
            //throw new NotImplementedException();
            var valid = false;
            var invstType = 0;
            if (cmbInvestigation.SelectedValue.ToString() == "1")
            {
                valid = true;
                btnDeliver.Enabled = false;
                btnRowDeliver.Enabled = false;
                btnReceive.Enabled = true;
                invstType = 3;
            }
            else if (cmbInvestigation.SelectedValue.ToString() == "2")
            {
                valid = true;
                btnDeliver.Enabled = true;
                btnRowDeliver.Enabled = false;
                btnReceive.Enabled = false;
                invstType = 4;
            }
            else if (cmbInvestigation.SelectedValue.ToString() == "3")
            {
                valid = true;
                btnDeliver.Enabled = false;
                btnRowDeliver.Enabled = true;
                btnReceive.Enabled = false;
                invstType = 5;
            }

            if (valid == true)
            {
                clearGrid();
                //throw new NotImplementedException();
                objData.OpenConnection("AzharPC-Office", ref strErr);
                var strSql = "";
                strSql =
                    "select ROW_NUMBER() over( order by inv.InvestigationID) SL,cast(inv.Invetigation_SL as varchar(6))+'/'+cast( MONTH(inv.CreatedON) as varchar(2))+'/'+cast(year(inv.CreatedON) as varchar(4)) investigation, S.Service_Name TestName,invItem.ReceivedOn, invItem.Delivered, invItem.DeliveryOn, inv.Investigationid, invItem.ISI_ID   ";
                strSql = strSql + ", P.Name PName,P.PresentAddress, D.Title, D.Name DName,D.Degree, D.Specialist   ";
                strSql = strSql +
                         ", dbo.f_Get_Payable_Amount(inv.InvestigationID) PayableAmount, dbo.f_get_inv_DiscountAmont(inv.InvestigationID) TDiscuntAmount, 0 Vat, dbo.f_Get_Inv_ReturnAmount(inv.InvestigationID) ReturnAmount, case when dbo.f_Get_Inv_PaidAmount(inv.InvestigationID) is null then 0 else dbo.f_Get_Inv_PaidAmount(inv.InvestigationID) end PaidAmount   ";
                strSql = strSql +
                         "from dbo_Investigation inv inner join dbo_InvertigationServiceItem invItem on inv.InvestigationID =invItem.Investigationid   ";
                strSql = strSql + "inner join Dbo_Services S On invItem.Service_ID = s.Service_ID   ";
                strSql = strSql + "inner join dbo_Patient_info P On inv.P_ID = p.P_ID   ";
                strSql = strSql + "inner join dbo_Doctor_List D On inv.DocID = D.DocID   ";
                strSql = strSql + "left join Dbo_service_Itemwise_Test ST On s.Service_ID = st.Service_ID   ";
                var sqlWhere = "";
                if (invstType >= 4)
                {
                    sqlWhere = sqlWhere + "where invItem.Status >= " + invstType;
                }


                string strVal = "";

                strVal = txtInvestigationID.Text.ToString();


                string[] arrinv = strVal.Split(new string[] { "/" }, StringSplitOptions.None);

                if (arrinv.Length.ToString() == "3")
                {
                    if (arrinv[0].ToString() == "")
                    {
                        //MessageBox.Show("please enter valid investifgation no.");
                    }
                    else
                    {
                        if (arrinv[1].ToString() == "")
                        {
                            //MessageBox.Show("please enter valid Month no.");
                        }
                        else
                        {
                            if (arrinv[2].ToString() == "")
                            {
                                //MessageBox.Show("please enter valid year no.");
                            }
                            else
                            {
                                if (sqlWhere == "")
                                {
                                    sqlWhere = "Where ";
                                }
                                else
                                {
                                    sqlWhere = sqlWhere + " and ";
                                }
                                sqlWhere = sqlWhere + " inv.Invetigation_SL= " + arrinv[0].Trim().ToString();
                                sqlWhere = sqlWhere + " and  MONTH(inv.CreatedON)= " + arrinv[1].Trim().ToString();
                                sqlWhere = sqlWhere + " and  year(inv.CreatedON)= " + arrinv[2].Trim().ToString();
                            }
                        }
                    }
                }

                strSql = strSql + " " + sqlWhere;

                DataTable arrData = objData.RetriveData(strSql, ref strErr);

                DataSet ds = new DataSet();
                objData.CloseConnection();
                ds.Tables.Add(arrData);
                dgvFontDeskReport.DataSource = ds.Tables["Table1"];
                dgvFontDeskReport.Columns["Investigationid"].Visible = false;
                dgvFontDeskReport.Columns["PName"].Visible = false;
                dgvFontDeskReport.Columns["PresentAddress"].Visible = false;
                dgvFontDeskReport.Columns["Title"].Visible = false;
                dgvFontDeskReport.Columns["DName"].Visible = false;
                dgvFontDeskReport.Columns["Degree"].Visible = false;
                dgvFontDeskReport.Columns["Specialist"].Visible = false;
                dgvFontDeskReport.Columns["PayableAmount"].Visible = false;
                dgvFontDeskReport.Columns["TDiscuntAmount"].Visible = false;
                dgvFontDeskReport.Columns["Vat"].Visible = false;
                dgvFontDeskReport.Columns["ReturnAmount"].Visible = false;
                dgvFontDeskReport.Columns["PaidAmount"].Visible = false;

                if (arrData.Rows.Count > 0)
                {
                    lblPName.Text = arrData.Rows[0][8].ToString();
                    lblPAddress.Text = arrData.Rows[0][9].ToString();
                    lblDoc.Text = arrData.Rows[0][10].ToString() + " " + arrData.Rows[0][11].ToString() + "\n" +
                                  arrData.Rows[0][12].ToString() + "\n" + arrData.Rows[0][13].ToString();

                    lbltotalpayamount.Text = arrData.Rows[0][14].ToString();
                    lbltotaldiscount.Text = arrData.Rows[0][15].ToString();
                    lblvat.Text = arrData.Rows[0][16].ToString();
                    int payableAbount = Convert.ToInt16(arrData.Rows[0][14].ToString()) +
                                        Convert.ToInt16(arrData.Rows[0][16].ToString()) -
                                        Convert.ToInt16(arrData.Rows[0][15].ToString());
                    int TotalDue = payableAbount -
                                   (Convert.ToInt16(arrData.Rows[0][18].ToString()) +
                                    Convert.ToInt16(arrData.Rows[0][17].ToString()));
                    lbltotalpayamount.Text = payableAbount.ToString();
                    lbltotalpaid.Text = arrData.Rows[0][18].ToString();
                    lbltotalreturn.Text = arrData.Rows[0][17].ToString();
                    lbltotaldue.Text = TotalDue.ToString();
                }
                else
                {
                    lblPName.Text = "";
                    lblPAddress.Text = "";
                    lblDoc.Text = "";

                    lbltotalpayamount.Text = "";
                    lbltotaldiscount.Text = "";
                    lblvat.Text = "";
                    lbltotalpayamount.Text = "";
                    lbltotalpaid.Text = "";
                    lbltotalreturn.Text = "";
                    lbltotaldue.Text = "";
                }


            }
        }

        private void btnRowDeliver_Click(object sender, EventArgs e)
        {
            var tD = 0;
            if (lbltotaldue.Text == "")
            {
                tD = 0;
            }
            else
            {
                tD = Convert.ToInt16(lbltotaldue.Text.ToString());
                if (tD > 0)
                {
                    MessageBox.Show("Please paid the due collection");
                }
                else
                {
                    string strSqlUpdateItems = "";
                    string strSqlInsertHistory = "";
                    string strIDs = "";

                    if (Convert.ToInt32(dgvFontDeskReport.Rows.Count) - 1 > 0)
                    {
                        for (int i = 0; i < dgvFontDeskReport.Rows.Count - 1; i++)
                        {
                            if ((bool)dgvFontDeskReport.Rows[i].Cells[0].FormattedValue == true)
                            {
                                if (strIDs.ToString() == "")
                                {
                                    strIDs = dgvFontDeskReport.Rows[i].Cells[8].Value.ToString();
                                    strSqlInsertHistory = " (" + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString() + ", 7," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                                }
                                else
                                {
                                    strIDs = strIDs + ", " + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString();
                                    strSqlInsertHistory = strSqlInsertHistory + ", (" + dgvFontDeskReport.Rows[i].Cells[8].Value.ToString() + ", 7," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                                }
                            }
                        }
                    }

                    if (strIDs != "")
                    {
                        strSqlUpdateItems = "Update dbo_InvertigationServiceItem SET Status=7, Delivered= getdate() where [ISI_ID] in (" + strIDs + ")";
                        strSqlInsertHistory = "insert into Investigation_Serviceitem_History (ISI_ID, Status, UserID,userPC) values " + strSqlInsertHistory;

                        //objData = new C_Data_Batch();
                        objData.OpenConnection("AzharPC-Home", ref strErr);

                        objData.BeginTransaction(ref strErr);
                        if (strErr == "")
                        {
                            objData.ExecuteQuery(strSqlUpdateItems, ref strErr);
                            if (strErr == "")
                            {
                                objData.ExecuteQuery(strSqlInsertHistory, ref strErr);
                                if (strErr == "")
                                {
                                    MessageBox.Show("Report Row Delivery succefully done.");
                                    objData.CommitTransaction(ref strErr);
                                    frmLoad();
                                }
                                else
                                {
                                    objData.Rollback(ref strErr);
                                    MessageBox.Show("System cannot deal at this moment.");
                                }
                            }
                            else
                            {
                                objData.Rollback(ref strErr);
                                MessageBox.Show("System cannot deal at this moment.");
                            }
                        }

                    }
                }
            }
        }

        private void cmbInvestigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
