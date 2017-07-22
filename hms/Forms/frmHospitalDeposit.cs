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
    public partial class frmHospitalDeposit : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        private double bedCost = 0.0;
        private double visitCharge = 0.0;
        private double otherServiceCharge = 0.0;
        public frmHospitalDeposit()
        {
            InitializeComponent();
            objData.OpenConnection("AatickPC-Office", ref strErr);
            lstdiscountby.DataSource = new List<object> { new { Name = "MD", Id = "1" }, new { Name = "Chairperson", Id = "2" }, new { Name = "Doctor", Id = "3" } };
            lstdiscountby.DisplayMember = "Name";
            lstdiscountby.ValueMember = "Id";
            lstdiscountby.SelectedIndex = -1;

            lstDiscountType.DataSource = new List<object> { new { Name = "Bed Charge", Id = "1" }, new { Name = "Consultant & Team Charge", Id = "2" }, new { Name = "Other Service Charge", Id = "3" } };
            lstDiscountType.DisplayMember = "Name";
            lstDiscountType.ValueMember = "Id";
            lstDiscountType.SelectedIndex = -1;

            lstMemoList.Columns.Add("Date");
            lstMemoList.Columns.Add("Memo No");
            lstMemoList.Columns.Add("Deposit Amount");
            lstMemoList.Columns.Add("Discount");
            lstMemoList.Columns.Add("Discount Type");
            lstMemoList.Columns.Add("Returm Amount");
            lstMemoList.Columns.Add("Remarks");
            lstMemoList.Columns.Add("CM_ID");
            var eachWidth = lstMemoList.Width / 7;
            for (var i = 0; i < lstMemoList.Columns.Count; i++)
            {
                lstMemoList.Columns[i].Width = eachWidth;
            }
            lstMemoList.Columns[7].Width = 0;
            lstMemoList.AutoSize = false;
            btnprint.Enabled = false;
        }

        private void LoadAddmissionInfo(string add_id)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "SELECT PI.Name,BI.Name,AD.Status,AD.DiscountTK,AD.DiscountPercentage,AD.DiscountByID";
            sql += " FROM dbo_Admission AD INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID ";
            sql += " LEFT JOIN Patient_Bed PB ON PB.Admission_id=AD.Admission_Id";
            sql += " LEFT JOIN Bed_Information BI ON BI.BI_ID=PB.BI_ID ";
            sql += " WHERE AD.Admission_Id=" + add_id;
            var admissionInfo = objData.RetriveData(sql, ref strErr);
            if (strErr == "")
            {
                if (admissionInfo.Rows.Count > 0)
                {
                    lblPatientName.Text = admissionInfo.Rows[0][0].ToString();
                    lblCabin.Text = admissionInfo.Rows[0][1].ToString();
                    lblStatus.Text = admissionInfo.Rows[0][2].ToString();
                    txtdiscount.Text = string.IsNullOrEmpty(admissionInfo.Rows[0][3].ToString())
                        ? ""
                        : admissionInfo.Rows[0][3].ToString();
                    txtpersentance.Text = string.IsNullOrEmpty(admissionInfo.Rows[0][4].ToString())
                        ? ""
                        : admissionInfo.Rows[0][4].ToString();
                    if (!string.IsNullOrEmpty(admissionInfo.Rows[0][5].ToString()))
                        lstdiscountby.SelectedValue = int.Parse(admissionInfo.Rows[0][5].ToString());

                    var sqlCharges = "USP_Get_Admission_Charges " + add_id;
                    var dtCharges = objData.RetriveData(sqlCharges, ref strErr);
                    if (dtCharges.Rows.Count > 0 && strErr == "")
                    {
                        lstDiscountType.DataSource = dtCharges;
                        lstDiscountType.SelectedIndex = -1;
                        for (var j = 0; j < dtCharges.Rows.Count; j++)
                        {
                            if (dtCharges.Rows[j][0].ToString() == "1")
                                double.TryParse(dtCharges.Rows[j][2].ToString(), out bedCost);
                            if (dtCharges.Rows[j][0].ToString() == "2")
                                double.TryParse(dtCharges.Rows[j][2].ToString(), out visitCharge);
                            if (dtCharges.Rows[j][0].ToString() == "3")
                                double.TryParse(dtCharges.Rows[j][2].ToString(), out otherServiceCharge);
                        }
                    }

                    var sqlRemainingAmount = "SELECT (dbo.f_Get_Admission_PayableAmount(" + add_id + ")+dbo.f_Get_Admission_ReturnAmount(" + add_id + "))-(dbo.f_get_Admission_PaidAmount(" + add_id + ")+dbo.f_Get_Admission_Discount(" + add_id + ")) Remaining_Amount,dbo.f_Get_Admission_PayableAmount(" + add_id + ") Payable_Amount";
                    var dtRemainingAmount = objData.RetriveData(sqlRemainingAmount, ref strErr);
                    if (strErr == "" && dtRemainingAmount.Rows.Count > 0)
                    {
                        txtpaymentremaining.Text = dtRemainingAmount.Rows[0][0].ToString();
                        //lblReturnAmount.Visible = txtReturnAmount.Visible = false;
                        btnsave.Enabled = true;


                        //if (double.Parse(dtRemainingAmount.Rows[0][0].ToString()) < 0)
                        //{
                        //    if (int.Parse(dtRemainingAmount.Rows[0][1].ToString()) > 0)
                        //    {
                        //        lblReturnAmount.Visible = txtReturnAmount.Visible = true;
                        //    }
                        //}
                        if (int.Parse(dtRemainingAmount.Rows[0][0].ToString()) == 0)
                        {
                            btnsave.Enabled = false;
                        }

                    }
                    else
                    {
                        txtpaymentremaining.Text = "0";
                    }
                    var sqlCashMemoInfo = "SELECT CM.CreatedOn,CAST(CM.CM_SL AS VARCHAR(20))+'/'+CAST(Month(CM.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(CM.CreatedOn) AS VARCHAR(20))";
                    sqlCashMemoInfo += " ,CM.Pay_Amount";
                    sqlCashMemoInfo += " ,CASE WHEN AD.DiscountTK=0 OR AD.DiscountTK IS NULL THEN CASE WHEN AD.DiscountPercentage=0 OR AD.DiscountPercentage IS NULL THEN '' ELSE AD.DiscountPercentage END ELSE AD.DiscountTK END";
                    sqlCashMemoInfo += " ,CASE WHEN AD.DiscountTK=0 OR AD.DiscountTK IS NULL THEN CASE WHEN AD.DiscountPercentage=0 OR AD.DiscountPercentage IS NULL THEN '' ELSE '%' END ELSE 'Tk' END";
                    sqlCashMemoInfo += " ,CM.Return_Amount,CM.Remarks,CM.CM_ID";
                    sqlCashMemoInfo += " FROM dbo_Admission AD INNER JOIN dbo_CashMemo CM ON CM.Admission_ID=ad.Admission_Id";
                    sqlCashMemoInfo += " WHERE AD.Admission_Id=" + add_id;
                    var dtCashMemoInfo = objData.RetriveData(sqlCashMemoInfo, ref strErr);
                    lstMemoList.Items.Clear();
                    if (dtCashMemoInfo.Rows.Count > 0)
                    {
                        for (var i = 0; i < dtCashMemoInfo.Rows.Count; i++)
                        {
                            var listviewitem =
                                new ListViewItem(
                                    DateTime.Parse(dtCashMemoInfo.Rows[i][0].ToString()).ToShortDateString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][1].ToString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][2].ToString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][3].ToString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][4].ToString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][5].ToString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][6].ToString());
                            listviewitem.SubItems.Add(dtCashMemoInfo.Rows[i][7].ToString());
                            lstMemoList.Items.Add(listviewitem);
                        }
                    }
                    var sqlcashSl = "SELECT CASE WHEN MAX(CM_SL) IS NULL THEN 1001 ELSE MAX(CM_SL)+1 END FROM dbo_CashMemo WHERE CreatedOn>='" +
                                                        new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                                                            .ToShortDateString() + "'";
                    var dtACashSl = objData.RetriveData(sqlcashSl, ref strErr);
                    txtcashmemono.Text = dtACashSl.Rows[0][0] + "/" + DateTime.Today.Month.ToString("00") + "/" + DateTime.Today.Year;
                }
                else
                {
                    lblPatientName.Text = "";
                    lblCabin.Text = "";
                    lblStatus.Text = "";
                    txtpaymentremaining.Text = "0";
                }
            }
            objData.CloseConnection();
            CalculatePayableamount();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var addmissionId = txtAdmissionId.Text;
            var payAmount = 0;
            int.TryParse(txtdepositamount.Text, out payAmount);
            if (payAmount == 0)
            {
                MessageBox.Show(@"Please enter deposit amount.");
                txtdepositamount.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtdiscount.Text) || !string.IsNullOrEmpty(txtpersentance.Text))
            {
                if (lstDiscountType.SelectedItems.Count == 0)
                {
                    MessageBox.Show(@"Please select discount type.");
                    return;
                }
                if (lstdiscountby.SelectedItems.Count == 0)
                {
                    MessageBox.Show(@"Please select discount by.");
                    return;
                }
            }
            var dueAmount = txtremainingdue.Text;
            var userId = Utility.userID;
            var cashMemoSl = "";
            var cashId = "";
            strErr = "";
            var msg = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlCashMemoSl =
                        "SELECT CASE WHEN MAX(CM_SL) IS NULL THEN 1001 ELSE MAX(CM_SL)+1 END FROM dbo_CashMemo WHERE CreatedOn>='" +
                        new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString() + "'";
            var dtCashMemoSl = objData.RetriveData(sqlCashMemoSl, ref strErr);
            cashMemoSl = dtCashMemoSl.Rows[0][0].ToString();
            if (txtReturnAmount.Visible && !string.IsNullOrEmpty(txtReturnAmount.Text))
            {
                var insertReturnsql = "INSERT INTO dbo_CashMemo(CM_SL,Admission_ID,USERID,Return_Amount,UserPC) VALUES('" +
                                      cashMemoSl + "'," + addmissionId + "," + userId + ",'" + txtReturnAmount.Text +
                                      "','" + Utility.PcName + "')";
                objData.ExecuteQuery(insertReturnsql, ref strErr);
                if (strErr == "")
                {
                    var maxCashMemoSql = "SELECT MAX(CM_ID) FROM dbo_CashMemo;";
                    var arrCashId = objData.RetriveData(maxCashMemoSql, ref strErr);
                    if (strErr == "")
                    {
                        cashId = arrCashId.Rows[0][0].ToString();
                    }
                }
                msg = strErr != "" ? "An error occured.\nPlease try again later." : "Successfully saved.";
            }
            else
            {
                objData.BeginTransaction(ref strErr);
                var insertDepositinfosql =
                    "INSERT INTO Hospital_Deposit(Admission_id,Deposit_amount,Deposit_On,UserPC,Deposite_Type,UserID) VALUES(" + addmissionId + ",'" +
                    payAmount + "',getdate(),'" + Utility.PcName + "','AD'," + Utility.userID + ")";
                objData.ExecuteQuery(insertDepositinfosql, ref strErr);
                if (strErr == "")
                {
                    var insertCashinfosql =
                        "INSERT INTO dbo_CashMemo(CM_SL,Admission_ID,Pay_Amount,Due,USERID,Remarks,UserPC) VALUES('" +
                        cashMemoSl + "'," + addmissionId + ",'" + payAmount + "','" + dueAmount + "'," + userId +
                        ",'" + txtremarks.Text + "','" + Utility.PcName + "')";
                    objData.ExecuteQuery(insertCashinfosql, ref strErr);
                    if (strErr == "")
                    {
                        var maxCashMemoSql = "SELECT MAX(CM_ID) FROM dbo_CashMemo;";
                        var arrCashId = objData.RetriveData(maxCashMemoSql, ref strErr);
                        if (strErr == "")
                        {
                            cashId = arrCashId.Rows[0][0].ToString();
                            if (!string.IsNullOrEmpty(txtdiscount.Text) || !string.IsNullOrEmpty(txtpersentance.Text))
                            {
                                var sql =
                                    "INSERT INTO dbo_Admission_Discount(Admission_Id,Discount_Amount,Discount_Percentage,Discount_Type,DiscountBy_Id,UserId,UserPc) VALUES(" +
                                    addmissionId + ",'" + GetDiscountAmount() + "','" + (string.IsNullOrEmpty(txtpersentance.Text) ? "0" : txtpersentance.Text) + "','" + lstDiscountType.SelectedValue +
                                    "','" + txtdiscountby.Text + "'," + Utility.userID + ",'" + Utility.PcName + "')";
                                objData.ExecuteQuery(sql, ref strErr);
                                var updateAdmissioninfosql = "UPDATE dbo_Admission SET DiscountByID='" +
                                                             txtdiscountby.Text +
                                                             "', DiscountTK=ISNULL(DiscountTK,0)+" + GetDiscountAmount() + ",DiscountPercentage='0',UserId=" + Utility.userID + ",UserPc='" + Utility.PcName + "' WHERE Admission_Id=" + addmissionId;
                                objData.ExecuteQuery(updateAdmissioninfosql, ref strErr);
                            }
                        }
                    }
                }
                if (strErr != "")
                {
                    objData.Rollback(ref strErr);
                    msg = "An error occured.\nPlease try again later.";
                }
                else
                {
                    objData.CommitTransaction(ref strErr);
                    msg = "Successfully saved.";
                }
            }
            objData.CloseConnection();
            MessageBox.Show(msg);
            if (strErr == "")
            {
                LoadAddmissionInfo(addmissionId);
                ShowMoneyReceipt(cashId);
            }
        }

        //private void cmbAdmissionId_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbAdmissionId.SelectedIndex > -1)
        //        LoadAddmissionInfo(cmbAdmissionId.SelectedValue.ToString());
        //}

        private void lstdiscountby_DoubleClick(object sender, EventArgs e)
        {
            txtdiscountby.Text = lstdiscountby.SelectedValue.ToString();
            CalculatePayableamount();
        }

        private void CalculatePayableamount()
        {
            if (!string.IsNullOrEmpty(txtpaymentremaining.Text))
            {
                var discount = GetDiscountAmount();
                lblDiscountAmount.Text = GetDiscountAmount().ToString("F") + @" Tk";
                var payableAmount = double.Parse(txtpaymentremaining.Text) - discount;
                txtpayableamount.Text = payableAmount.ToString();
                CalculateRemainingDue();
            }
        }

        private double GetDiscountAmount()
        {
            var payment = 0.0;
            var discountAmount = 0.0;
            var discountType = lstDiscountType.SelectedValue ?? 0;
            //payment = double.Parse(txtpaymentremaining.Text);
            switch (int.Parse(discountType.ToString()))
            {
                case 1:
                    payment = bedCost;
                    break;
                case 2:
                    payment = visitCharge;
                    break;
                case 3:
                    payment = otherServiceCharge;
                    break;
            }
            if (!(payment > 0)) return discountAmount;
            if (string.IsNullOrEmpty(txtdiscount.Text))
            {
                if (!string.IsNullOrEmpty(txtpersentance.Text))
                {
                    discountAmount = (payment * double.Parse(txtpersentance.Text)) / 100;
                }
            }
            else
            {
                discountAmount = double.Parse(txtdiscount.Text);
                if (!string.IsNullOrEmpty(txtpersentance.Text))
                {
                    discountAmount += (payment * double.Parse(txtpersentance.Text)) / 100;
                }
            }
            return discountAmount;
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            CalculatePayableamount();
        }

        private void txtpersentance_TextChanged(object sender, EventArgs e)
        {
            CalculatePayableamount();
        }

        private void KeyPress_OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CalculateRemainingDue()
        {

            if (!string.IsNullOrEmpty(txtpayableamount.Text))
            {
                var dueAmount = double.Parse(txtpayableamount.Text);
                if (!string.IsNullOrEmpty(txtdepositamount.Text))
                {
                    dueAmount -= double.Parse(txtdepositamount.Text);
                }
                txtremainingdue.Text = dueAmount.ToString();
            }
        }

        private void txtdepositamount_TextChanged(object sender, EventArgs e)
        {
            CalculateRemainingDue();
        }

        private void txtreceive_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdepositamount.Text) && !string.IsNullOrEmpty(txtreceive.Text))
            {
                var totalDepositAmount = double.Parse(txtdepositamount.Text);
                var receivedAmount = double.Parse(txtreceive.Text);
                txtreturn.Text = (receivedAmount - totalDepositAmount).ToString();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            frmLoad();
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

        private void frmLoad()
        {
            //throw new NotImplementedException();
            txtAdmissionId.Text = txtAdmissionSl.Text = "";
            lstdiscountby.SelectedIndex = -1;
            lblPatientName.Text = "";
            lblCabin.Text = "";
            lblStatus.Text = "";
            lstMemoList.Items.Clear();
            btnprint.Enabled = false;
            Utility.ClearAllControls(this);
        }

        private void lstMemoList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstMemoList.Columns[e.ColumnIndex].Width;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstMemoList_DoubleClick(object sender, EventArgs e)
        {
            if (lstMemoList.SelectedItems.Count > 0)
            {
                ShowMoneyReceipt(lstMemoList.SelectedItems[0].SubItems[7].Text, true);
            }
        }

        private void ShowMoneyReceipt(string cashMemoId, bool isEdit = false)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlCashMemoInfo = "SELECT CAST(CM.CM_SL AS VARCHAR(10))+'/'+CAST(MONTH(CM.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(CM.CreatedOn) AS VARCHAR(4)) AS CashMemoNo";
            sqlCashMemoInfo += " , CAST(AD.Admission_SL AS VARCHAR(10))+'/'+CAST(MONTH(AD.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(AD.CreatedOn) AS VARCHAR(4)) AS AdmissionSlNo";
            sqlCashMemoInfo += " , AD.CreatedOn,PI.Name,PI.Year,PI.Month,PI.Day,PI.Gender";
            sqlCashMemoInfo += " , CM.Pay_Amount,case when AD.DiscountTk is null then 0 else  AD.DiscountTk end DiscountTk,case when Ad.DiscountPercentage is null then 0 else Ad.DiscountPercentage end DiscountPercentage,AD.DiscountByID,dbo.f_Get_Admission_PayableAmount(AD.Admission_Id) Payable_Amount, case when CM.Return_Amount is null then 0 else CM.Return_Amount end Return_Amount,U.Name UserName ";
            sqlCashMemoInfo +=
                " FROM dbo_CashMemo CM INNER JOIN dbo_Admission AD ON CM.Admission_ID=AD.Admission_Id ";
            sqlCashMemoInfo += " INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID	 ";
            sqlCashMemoInfo += " LEFT JOIN dbo_Users U ON U.User_Id=CM.UserId ";
            sqlCashMemoInfo += " WHERE CM.CM_ID=" + cashMemoId;
            var dtCashMemoInfo = objData.RetriveData(sqlCashMemoInfo, ref strErr);
            objData.CloseConnection();

            var rptpath = Utility.ReportPath + "rptMoneyReceipt.rpt";
            if (isEdit)
            {
                var dataset = new DataSet();
                dataset.Tables.Add(dtCashMemoInfo);
                var reportviewer = new frmReport();
                reportviewer.ReportPath = rptpath;
                reportviewer.Reportds = dataset;
                reportviewer.Show(this);
            }
            else
            {
                Utility.Print(dtCashMemoInfo, rptpath, 1);
            }
        }

        private void lstMemoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMemoList.SelectedItems.Count > 0)
            {
                btnprint.Enabled = true;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (lstMemoList.SelectedItems.Count > 0)
            {
                ShowMoneyReceipt(lstMemoList.SelectedItems[0].SubItems[7].Text, true);
            }
        }

        private void txtdepositamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.PerformClick();
            }
        }

        private void btnPatienList_Click(object sender, EventArgs e)
        {
            //new frmAdmitedPatientList() { Owner = this }.ShowDialog();
            new frmAdmitedPatientList("frmHospitalDeposit") { Owner = this }.ShowDialog();
        }

        public void LoadAdmissionInfo(string addmissionSl, string admission_Id)
        {
            txtAdmissionId.Text = admission_Id;
            txtAdmissionSl.Text = addmissionSl;
            LoadAddmissionInfo(admission_Id);
            txtdiscount.Focus();
        }

        private void lstdiscountby_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtdiscountby.Text = lstdiscountby.SelectedValue.ToString();
                CalculatePayableamount();
                txtdepositamount.Focus();
            }
        }

        private void txtreceive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.PerformClick();
            }
        }

        private void chkReturnAmount_Click(object sender, EventArgs e)
        {
            txtReturnAmount.Enabled = chkReturnAmount.Checked;
            txtReturnAmount.Text = "";
        }
    }
}
