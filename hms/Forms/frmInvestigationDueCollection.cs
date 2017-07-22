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
    public partial class frmInvestigationDueCollection : Form
    {
        public string strErr = "";
        C_Data_Batch objData;
        public frmInvestigationDueCollection()
        {
            InitializeComponent();
        }

        private void cmbInvestigation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                //MessageBox.Show(cmbInvestigation.Text.ToString());
            }
        }

        private void frmInvestigationDueCollection_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmlod();
            objData.CloseConnection();
        }

        private void frmlod()
        {
            //throw new NotImplementedException();

            clearFilds();
            fillgrid();
            fillcombo();

        }

        private void fillcombo()
        {
            //throw new NotImplementedException();
            investigationlist();
            discuntby();
        }

        private void discuntby()
        {
            cmbDiscount.DataSource = new List<object> { new { Name = "MD", Id = "1" }, new { Name = "Chairperson", Id = "2" }, new { Name = "Doctor", Id = "3" } }; ;
            cmbDiscount.DisplayMember = "Name";
            cmbDiscount.ValueMember = "Id";
            cmbDiscount.SelectedIndex = -1;
        }

        private void investigationlist()
        {
            string strSQL = "";

            strSQL = "select InvestigationID, cast((Invetigation_SL) as varchar(10))  +'/'+ cast(month(CreatedON) as varchar(2))+'/'+ cast(year(CreatedON) as varchar(4)) as 'Name' from dbo_Investigation  order by InvestigationID desc";
            var arrInvList = objData.RetriveData(strSQL, ref strErr);
            cmbInvestigation.DataSource = arrInvList;
            cmbInvestigation.DisplayMember = "Name";
            cmbInvestigation.ValueMember = "InvestigationID";
            cmbInvestigation.SelectedIndex = -1;
            cmbInvestigation.SelectedIndexChanged += cmbInvestigation_SelectedIndexChanged;

        }

        private void fillgrid()
        {
            //throw new NotImplementedException();
        }

        private void clearFilds()
        {
            //throw new NotImplementedException();
            txtcashmemono.Text = "";
            txtpaymentremaining.Text = "";
            txtdiscount.Text = "";
            txtpersentance.Text = "";
            txtpaidamount.Text = "";
            txtremainingdue.Text = "";
            txtreceive.Text = "";
            txtreturn.Text = "";
            lblNameNew.Text = "";
            lblAddress.Text = "";
            lblDoctor.Text = "";
            lbltotalamount.Text = "";
            lbltotaldiscount.Text = "";
            lblvat.Text = "";
            lbltotalpayamount.Text = "";
            lbltotalpaid.Text = "";
            lbltotaldue.Text = "";
            lbltotalreturn.Text = "";


        }

        private void cmbInvestigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            loadall();
            objData.CloseConnection();
        }

        private void loadall()
        {
            if (cmbInvestigation.SelectedIndex > -1)
            {
                string strSQL = "";
                strSQL = "USP_INV_DUE_Collection " + cmbInvestigation.SelectedValue;//.SelectedValue;

                DataTable arrAllInfo = objData.RetriveData(strSQL, ref strErr);

                DataSet ds = new DataSet();
                ds.Tables.Add(arrAllInfo);
                dgvDueCollection.DataSource = ds.Tables["Table1"];
                dgvDueCollection.Columns["Cash Memo"].DisplayIndex = 0;
                dgvDueCollection.Columns["Invertigation"].DisplayIndex = 1;


                if (arrAllInfo.Rows.Count > 0)
                {
                    lblNameNew.Text = arrAllInfo.Rows[0][0].ToString();
                    lblAddress.Text = arrAllInfo.Rows[0][1].ToString();
                    lblDoctor.Text = arrAllInfo.Rows[0][2].ToString();
                    cmbDiscount.SelectedValue = arrAllInfo.Rows[0][3].ToString();
                    lbltotalamount.Text = arrAllInfo.Rows[0][4].ToString();
                    lbltotalpayamount.Text = arrAllInfo.Rows[0][4].ToString();
                    txtpayableamount.Text = arrAllInfo.Rows[0][4].ToString();


                    lblvat.Text = arrAllInfo.Rows[0][8].ToString();

                    lbltotalpaid.Text = arrAllInfo.Rows[0][9].ToString();
                    //int totalDue = Convert.ToInt16(arrAllInfo.Rows[0][4].ToString()) - Convert.ToInt16(arrAllInfo.Rows[0][9].ToString());
                    lbltotaldue.Text = arrAllInfo.Rows[0][5].ToString();
                    lbltotalreturn.Text = arrAllInfo.Rows[0][10].ToString();

                    //int totalDiscountAmount = 0;

                    //totalDiscountAmount = Convert.ToInt16(arrAllInfo.Rows[0][6].ToString()) * Convert.ToInt16(arrAllInfo.Rows[0][6].ToString()) / 100;
                    //totalDiscountAmount = totalDiscountAmount + Convert.ToInt16(arrAllInfo.Rows[0][7].ToString());
                    lbltotaldiscount.Text = arrAllInfo.Rows[0][13].ToString();

                    if (Convert.ToInt32(lbltotaldiscount.Text.ToString()) > 0)
                    {
                        txtpersentance.Enabled = false;
                        txtdiscount.Enabled = false;
                    }
                    else
                    {
                        txtpersentance.Enabled = true;
                        txtdiscount.Enabled = true;

                    }

                    txtpaymentremaining.Text = arrAllInfo.Rows[0][5].ToString();
                    txtdiscount.Text = arrAllInfo.Rows[0][7].ToString();
                    txtpersentance.Text = arrAllInfo.Rows[0][6].ToString();
                    //txtpaidamount.Text = arrAllInfo.Rows[0][9].ToString();
                    txtremainingdue.Text = arrAllInfo.Rows[0][5].ToString();

                }
            }




        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            //getcalclalculation();
            getdiscountamount();

        }

        private void getdiscountamount()
        {
            //throw new NotImplementedException();
            int totalDiscountTake = 0;
            int totalDiscountParsentence = 0;

            if (txtdiscount.Text != "")
            {
                totalDiscountTake = Convert.ToInt16(txtdiscount.Text);
            }
            if (txtpersentance.Text != "")
            {
                totalDiscountParsentence = Convert.ToInt16(Math.Floor(Convert.ToDecimal(txtpayableamount.Text) * (Convert.ToDecimal(txtpersentance.Text) / 100)));
            }

            var tDis = totalDiscountTake + totalDiscountParsentence;
            var paidAmount = 0;

            if (txtpaidamount.Text != "")
            {
                paidAmount = Convert.ToInt16(txtpaidamount.Text);
            }
            txtremainingdue.Text = (Convert.ToInt32(txtpaymentremaining.Text.ToString()) - (tDis + paidAmount)).ToString();

        }

        private void getcalclalculation()
        {
            int totalDiscountTake = 0;
            int totalDiscountParsentence = 0;

            if (txtdiscount.Text != "")
            {
                totalDiscountTake = Convert.ToInt16(txtdiscount.Text);
            }
            if (txtpersentance.Text != "")
            {
                totalDiscountParsentence = Convert.ToInt16(Math.Floor(Convert.ToDecimal(txtpayableamount.Text) * (Convert.ToDecimal(txtpersentance.Text) / 100)));
            }
            int toDue = 0;

            var payableAmount = Convert.ToInt16(txtpaymentremaining.Text);
            var paidAmount = 0;

            if (txtpaidamount.Text != "")
            {
                paidAmount = Convert.ToInt16(txtpaidamount.Text);
            }

            paidAmount = paidAmount + (totalDiscountTake + totalDiscountParsentence);
            toDue = payableAmount - paidAmount;

            //if (txtpaidamount.Text != "")
            //{
            //    if (txtpayableamount.Text != "")
            //    {
            //        toDue = (Convert.ToInt16(txtpaymentremaining.Text) - (totalDiscountTake + totalDiscountParsentence));
            //    }
            //}
            //else
            //{
            //    if (txtpaymentremaining.Text != "")
            //    {
            //        toDue = (Convert.ToInt16(txtpaymentremaining.Text) - (totalDiscountTake + totalDiscountParsentence));
            //    }
            //}


            //if (txtpaidamount.Text != "")
            //{
            //    toDue = toDue - (Convert.ToInt16(txtpaidamount.Text) - (totalDiscountTake + totalDiscountParsentence));
            //}
            txtremainingdue.Text = toDue.ToString();
        }

        private void txtpersentance_TextChanged(object sender, EventArgs e)
        {
            //getcalclalculation();
            getdiscountamount();
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            getcalclalculation();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            strErr = "";
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            SaveData();
            objData.CloseConnection();
        }

        private void SaveData()
        {
            var invid = cmbInvestigation.SelectedValue.ToString();
            var DincountByID = cmbDiscount.SelectedIndex > -1 ? int.Parse(cmbDiscount.SelectedValue.ToString()) : 0;

            var invSL = cmbInvestigation.Text;

            string strSQLUpdateInvertigation = "";

            string strSQLUpdateCashMemo = "select max(CM_SL) From dbo_CashMemo where month(CreatedOn) = month(getdate()) ";
            DataTable arrCashSL = objData.RetriveData(strSQLUpdateCashMemo, ref strErr);

            int cashSL = 0;
            if (arrCashSL.Rows.Count > 0)
            {
                if (arrCashSL.Rows[0][0].ToString() == "")
                {
                    cashSL = 1000;
                }
                else
                {
                    cashSL = Convert.ToInt16(arrCashSL.Rows[0][0].ToString()) + 1;
                }
            }
            else
            {
                cashSL = 1000;
            }
            string strSQLCASH = "";
            int paidAmount = 0;
            if (txtpaidamount.ToString() == "")
            {
                paidAmount = 0;
            }
            else
            {
                paidAmount = Convert.ToInt16(txtpaidamount.Text);
            }

            int totalDueAmount = 0;
            if (txtremainingdue.Text == "")
            {
                totalDueAmount = 0;
            }
            else
            {
                totalDueAmount = Convert.ToInt16(txtremainingdue.Text);
            }
            var totalDiscountTake = 0;
            if (txtdiscount.Text != "")
            {
                totalDiscountTake = Convert.ToInt32(txtdiscount.Text);
            }
            var totalDiscountParsentence = 0;
            if (txtpersentance.Text != "")
            {
                totalDiscountParsentence = Convert.ToInt32(txtpersentance.Text);
            }

            objData.BeginTransaction(ref strErr);

            strSQLUpdateInvertigation = "update dbo_Investigation SET  TotalDue = " + txtremainingdue.Text + " ,DiscountTK=" + totalDiscountTake + ", DiscountPasentance=" + totalDiscountParsentence + ", DiscountByID =" + DincountByID + ",  UpdatedOn = getdate()  where InvestigationID =" + invid;
            objData.ExecuteQuery(strSQLUpdateInvertigation, ref strErr);

            if (strErr == "")
            {

                var strDueCollection = "insert into dbo_Inv_Due_Collection (investigationID, Paid_Amount, Paid_Type, UserId, UserPC) ";
                strDueCollection += " Values (" + invid + ", " + paidAmount + ", 'DI'," + hms.Include_Files.Utility.userID + ", '" + hms.Include_Files.Utility.PcName + "' )";
                objData.ExecuteQuery(strDueCollection, ref strErr);

                if (strErr == "")
                {
                    strSQLCASH = "insert into [dbo_CashMemo]([CM_SL], [InvetigationID], [Pay_Amount], [Due], USERID,UserPC) ";
                    strSQLCASH = strSQLCASH + "Values (" + cashSL + ", " + invid + ", " + paidAmount + ", " + totalDueAmount + ", " + hms.Include_Files.Utility.userID + ", '" + hms.Include_Files.Utility.PcName + "')";
                    objData.ExecuteQuery(strSQLCASH, ref strErr);

                    if (strErr == "")
                    {
                        string strSqlSpotCommission = "USP_Inv_Calculate_SpotCommission " + cmbInvestigation.Text.Split('/')[0] + "," + cmbInvestigation.Text.Split('/')[1] + "," + cmbInvestigation.Text.Split('/')[2];
                        objData.ExecuteQuery(strSqlSpotCommission, ref strErr);
                        MessageBox.Show("Due Collection succefullty done");
                        objData.CommitTransaction(ref strErr);
                        string strSQL = "";
                        strSQL = "USP_INV_DUE_Collection " + invid;

                        DataTable arrAllInfo = objData.RetriveData(strSQL, ref strErr);

                        DataSet ds = new DataSet();
                        ds.Tables.Add(arrAllInfo);
                        dgvDueCollection.DataSource = ds.Tables["Table1"];
                        dgvDueCollection.Columns["Cash Memo"].DisplayIndex = 0;
                        dgvDueCollection.Columns["Invertigation"].DisplayIndex = 1;
                        //dgvDueCollection.Columns["Pay_Amount"].DisplayIndex = 2;

                        var maxCashMemo = "select max(CM_ID) from dbo_CashMemo ";

                        var arrCashmemo = objData.RetriveData(maxCashMemo, ref strErr);
                        var cashId = 0;
                        if (arrCashmemo.Rows.Count > 0)
                        {
                            cashId = Convert.ToInt32(arrCashmemo.Rows[0][0].ToString());
                        }

                        var sqlCashMemoInfo = "SELECT CAST(CM.CM_SL AS VARCHAR(10))+'/'+CAST(MONTH(CM.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(CM.CreatedOn) AS VARCHAR(4)) AS CashMemoNo";
                        sqlCashMemoInfo += " , CAST(Inv.Invetigation_SL AS VARCHAR(10))+'/'+CAST(MONTH(Inv.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(Inv.CreatedOn) AS VARCHAR(4)) AS  InvestigationSlNo";
                        sqlCashMemoInfo += " , Inv.CreatedOn,PI.Name,PI.Year,PI.Month,PI.Day,PI.Gender";
                        sqlCashMemoInfo +=
                            " , CM.Pay_Amount,Inv.DiscountTK,Inv.DiscountPasentance,Inv.DiscountByID,dbo.f_Get_Payable_Amount(Inv.InvestigationID) Payable_Amount,U.Name UserName";
                        sqlCashMemoInfo +=
                            " FROM dbo_CashMemo CM INNER JOIN dbo_Investigation Inv ON CM.InvetigationID=Inv.InvestigationID";
                        sqlCashMemoInfo += " INNER JOIN dbo_Patient_info PI ON PI.P_ID=Inv.P_ID	 ";
                        sqlCashMemoInfo += " LEFT JOIN dbo_Users U ON U.User_Id=CM.UserId ";
                        sqlCashMemoInfo += " WHERE CM.CM_ID=" + cashId;
                        var dtCashMemoInfo = objData.RetriveData(sqlCashMemoInfo, ref strErr);
                        DataSet dscsh = new DataSet();
                        dscsh.Tables.Add(dtCashMemoInfo);

                        var rptpath = Utility.ReportPath + "rptDueMoneyReceipt.rpt";
                        var reportDoc = new ReportDocument();
                        reportDoc.Load(rptpath);
                        reportDoc.SetDataSource(dscsh.Tables[0]);

                        //ReportDoc.SetParameterValue("UserName", Utility.UserName);

                        Utility.Print(reportDoc, rptpath, 2);

                    }
                    else
                    {
                        MessageBox.Show("cash memo not creted.");
                        objData.Rollback(ref strErr);
                    }
                }
                else
                {
                    MessageBox.Show("investigation not updated.");
                    objData.Rollback(ref strErr);
                }


            }
            else
            {
                MessageBox.Show("investigation not updated.");
                objData.Rollback(ref strErr);
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            if (dgvDueCollection.SelectedCells.Count > 0)
            {
                var cashId = dgvDueCollection.Rows[dgvDueCollection.SelectedCells[0].RowIndex].Cells[14].Value;
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sqlCashMemoInfo = "SELECT CAST(CM.CM_SL AS VARCHAR(10))+'/'+CAST(MONTH(CM.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(CM.CreatedOn) AS VARCHAR(4)) AS CashMemoNo";
                sqlCashMemoInfo += " , CAST(Inv.Invetigation_SL AS VARCHAR(10))+'/'+CAST(MONTH(Inv.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(Inv.CreatedOn) AS VARCHAR(4)) AS  InvestigationSlNo";
                sqlCashMemoInfo += " , Inv.CreatedOn,PI.Name,PI.Year,PI.Month,PI.Day,PI.Gender";
                sqlCashMemoInfo +=
                    " , CM.Pay_Amount,Inv.DiscountTK,Inv.DiscountPasentance,Inv.DiscountByID,dbo.f_Get_Payable_Amount(Inv.InvestigationID) Payable_Amount,U.Name UserName";
                sqlCashMemoInfo +=
                    " FROM dbo_CashMemo CM INNER JOIN dbo_Investigation Inv ON CM.InvetigationID=Inv.InvestigationID";
                sqlCashMemoInfo += " INNER JOIN dbo_Patient_info PI ON PI.P_ID=Inv.P_ID	 ";
                sqlCashMemoInfo += " LEFT JOIN dbo_Users U ON U.User_Id=CM.UserId ";
                sqlCashMemoInfo += " WHERE CM.CM_ID=" + cashId;
                var dtCashMemoInfo = objData.RetriveData(sqlCashMemoInfo, ref strErr);
                objData.CloseConnection();
                var dataset = new DataSet();
                dataset.Tables.Add(dtCashMemoInfo);
                var reportviewer = new frmReport();
                var rptpath = Utility.ReportPath + "rptDueMoneyReceipt.rpt";
                reportviewer.ReportPath = rptpath;
                reportviewer.Reportds = dataset;
                reportviewer.Show(this);
            }
        }

        private void dgvDueCollection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Utility.ClearAllControls(this);
            lbltotalpaid.Text = "";
            lbltotalreturn.Text = "";
            cmbInvestigation.SelectedIndex = -1;
            dgvDueCollection.Columns.Clear();
            lbltotalamount.Text = "";
            lbltotaldue.Text = "";
            txtpayableamount.Text = "";
            lbltotaldiscount.Text = "";
            lblvat.Text = "";
            lbltotalpayamount.Text = "";
            lblDoctor.Text = "";
            lblNameNew.Text = "";
            lblAddress.Text = "";
            txtremainingdue.Text = ""; 
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
        

        private void cmbInvestigation_TextChanged(object sender, EventArgs e)
        {
            cmbInvestigation.DroppedDown = false;
        }

        private void txtpaidamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnsave.PerformClick();
            }
        }
    }
}
