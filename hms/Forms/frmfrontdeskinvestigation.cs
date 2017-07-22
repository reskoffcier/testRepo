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
    public partial class frmfrontdeskinvestigation : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public string strSelectedServices = "";
        public string isFirstTime = "";

        public frmfrontdeskinvestigation()
        {
            InitializeComponent();

            //txtSearchServices.Focus();
        }

        private void frmfrontdeskinvestigation_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            isFirstTime = "1";
            frmload();
            isFirstTime = "0";
            objData.CloseConnection();
        }

        private void frmload()
        {
            //throw new NotImplementedException();
            clearGrid();
            clearFileds();
            getMaxID();
            getServices();
            getDocList();
        }

        private void clearGrid()
        {
            dgvInvestigation.Rows.Clear();
        }

        private void getDocList(string searchText = "")
        {
            var strSQL = "";
            strSQL = "select DocID, Name from dbo_Doctor_List " + (searchText != "" ? " WHERE Name LIKE '%" + searchText + "%'" : "") + " order by Name ";
            var arrDocList = objData.RetriveData(strSQL, ref strErr);
            lstdoctorsinformation.DataSource = arrDocList;
            lstdoctorsinformation.DisplayMember = "Name";
            lstdoctorsinformation.ValueMember = "DocID";
            lstdoctorsinformation.SelectedIndex = -1;
        }

        private void getServices()
        {
            string strSQL = "";
            strSQL = "select Service_ID, Service_Name from Dbo_Services where Service_Name like'%" + txtSearchServices.Text + "%' order by Service_Name";
            DataTable arrDocList = objData.RetriveData(strSQL, ref strErr);
            lsttestname.DataSource = arrDocList;
            lsttestname.DisplayMember = "Service_Name";
            lsttestname.ValueMember = "Service_ID";
            lsttestname.SelectedIndex = -1;

        }

        private void getMaxID()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select max(P_ID) from dbo_Patient_info";
            DataTable arrCatID = objData.RetriveData(strSQL, ref strErr);

            int CatId = 0;

            if (arrCatID.Rows.Count > 0)
            {
                if (arrCatID.Rows[0][0].ToString() == "")
                {
                    CatId = 1;
                }
                else
                {
                    CatId = Convert.ToInt32(arrCatID.Rows[0][0].ToString()) + 1;
                }
            }
            else
            {
                CatId = 1;
            }
            txtid.Text = CatId.ToString();
        }

        private void clearFileds()
        {
            //throw new NotImplementedException();
            txtid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtYear.Text = "";
            txtMonth.Text = "";
            //txtsex.SelectedValue = "";

            DataTable arrSex = new DataTable();
            arrSex.Columns.Add("Text");
            arrSex.Columns.Add("Value");
            arrSex.Rows.Add("Male", "M");
            arrSex.Rows.Add("Female", "F");
            txtsex.DataSource = arrSex;
            txtsex.DisplayMember = "Text";
            txtsex.ValueMember = "Value";
            lstDiscount.DataSource = new List<object>
            {
                new {Text="MD", Value ="1"},
                new {Text="ChairPerson", Value ="2"},
                new {Text="Doctor", Value ="3"}
            };
            lstDiscount.DisplayMember = "Text";
            lstDiscount.ValueMember = "Value";
            lstDiscount.SelectedIndex = -1;

            txtSearchServices.Text = "";
            txtAdmissionSl.Text = "";
            rbtngenaral.Checked = true;
            rbtnopd.Checked = false;
            rbtnindoor.Checked = false;
            rbtnbloodbank.Checked = false;
            rbtndental.Checked = false;
            rbtndialysis.Checked = false;
            rbtnpathology.Checked = false;
            rbtntherapy.Checked = false;
            txtdoctorid.Text = "";
            txttitle.Text = "";
            txtrefferedby.Text = "";
            txtdegree.Text = "";
            txtarea.Text = "";
            txtspecialist.Text = "";
            txttype.Text = "";
            txttotalamount.Text = "";
            txtpaidamount.Text = "";
            txtdiscount.Text = "";
            txtdiscouuntpersentnance.Text = "";
            txtvat.Text = "";
            txtpaidamount.Text = "";
            txtpc.Text = "";
            txttotaldue.Text = "";
            txtreceive.Text = "";
            txtReturn.Text = "";
            txtPayableAmount.Text = "";
            txttotalamount.Text = "";
            Utility.selectTestIds = "";
            lstdoctorsinformation.Enabled = true;
            txtdoctorinformation.Enabled = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmload();
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

        private void lsttestname_DoubleClick(object sender, EventArgs e)
        {

            addService();
        }

        private void addService()
        {
            if (lsttestname.SelectedIndex > -1)
            {
                var isVal = false;
                for (int i = 0; i < dgvInvestigation.Rows.Count; i++)
                {
                    if (dgvInvestigation.Rows[i].Cells[1].Value.ToString() == lsttestname.SelectedValue.ToString())
                    {
                        isVal = true;
                        break;
                    }
                }

                if (!isVal)
                {
                    objData = new C_Data_Batch();
                    objData.OpenConnection("AzharPC-Home", ref strErr);
                    string strSQL = "";
                    strSQL = "Select s.Service_ID,  s.Service_Name, s.Amount ,(case when Duraion_Type = 1 then dateadd(hh, Dutaion, getdate()) else dateadd(day,Dutaion, getdate() ) end ) 'Delivery Date' ,  '' Remarks from Dbo_Services S where service_id in (" + lsttestname.SelectedValue + ")";
                    DataTable arrservice = objData.RetriveData(strSQL, ref strErr);
                    dgvInvestigation.Rows.Add(false, arrservice.Rows[0][0].ToString(), arrservice.Rows[0][1].ToString(), arrservice.Rows[0][2].ToString(), arrservice.Rows[0][3].ToString(), arrservice.Rows[0][4].ToString());
                    dgvInvestigation.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.ColumnHeader);
                    getTotalCalculation();
                    objData.CloseConnection();

                }

            }
        }
        private void getTotalCalculation()
        {
            //throw new NotImplementedException();
            int totalPayableAmount = 0;

            for (int i = 0; i < dgvInvestigation.Rows.Count; i++)
            {
                totalPayableAmount = totalPayableAmount + Convert.ToInt32(dgvInvestigation.Rows[i].Cells[3].Value.ToString());
            }


            txttotalamount.Text = totalPayableAmount.ToString();
            int discount;
            Int32.TryParse(txtdiscouuntpersentnance.Text, out discount);
            txtdiscouuntpersentnance.Text = discount.ToString();
            int DiscountTaka;
            Int32.TryParse(txtdiscount.Text, out DiscountTaka);
            txtdiscount.Text = DiscountTaka.ToString();
            Decimal intVat;
            Decimal.TryParse(txtvat.Text, out intVat);

            txtvat.Text = intVat.ToString();
            Decimal intPayableAmount = Convert.ToDecimal(totalPayableAmount);
            if (discount > 0)
            {
                intPayableAmount = Convert.ToDecimal(intPayableAmount) - ((Convert.ToDecimal(discount) / 100) * Convert.ToDecimal(totalPayableAmount));
            }

            if (DiscountTaka > 0)
            {
                intPayableAmount = intPayableAmount - Convert.ToDecimal(DiscountTaka);
            }

            intVat = ((Convert.ToDecimal(Utility.intVat) / 100) * Convert.ToDecimal(totalPayableAmount));
            txtvat.Text = intVat.ToString();
            intPayableAmount = intPayableAmount + intVat;

            txtPayableAmount.Text = intPayableAmount.ToString();

            Decimal paidAmount;
            Decimal.TryParse(txtpaidamount.Text, out paidAmount);

            decimal totalDue = intPayableAmount - paidAmount;

            txttotaldue.Text = Convert.ToInt64(Math.Floor(Convert.ToDouble(totalDue.ToString()))).ToString();// Math.Round(d, totalDue);
        }

        private void lstdoctorsinformation_DoubleClick(object sender, EventArgs e)
        {
            selectDoctorInfo();
        }

        private void selectDoctorInfo()
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            loadDoctorInformation();
            objData.CloseConnection();
        }

        private void loadDoctorInformation()
        {
            var strSQL = "SELECT [DocID],[Title],[Name],[Degree],[Specialist],[Area],(CASE WHEN [Doctor_Type] = 1 THEN 'Listed'  WHEN [Doctor_Type] = 3 THEN 'In House' WHEN [Doctor_Type] = 3 THEN 'Out Source' end) FROM [dbo_Doctor_List] where [DocID]=" + lstdoctorsinformation.SelectedValue;
            var arrDocInfo = objData.RetriveData(strSQL, ref strErr);
            if (arrDocInfo.Rows.Count > 0)
            {
                txtdoctorid.Text = arrDocInfo.Rows[0][0].ToString();
                txttitle.Text = arrDocInfo.Rows[0][1].ToString();
                txtrefferedby.Text = arrDocInfo.Rows[0][2].ToString();
                txtdegree.Text = arrDocInfo.Rows[0][3].ToString();
                txtspecialist.Text = arrDocInfo.Rows[0][4].ToString();
                txtarea.Text = arrDocInfo.Rows[0][5].ToString();
                txttype.Text = arrDocInfo.Rows[0][6].ToString();
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorsInformation doc = new frmDoctorsInformation();
            doc.Show();
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            getTotalCalculation();
        }

        private string numericCheck(string p)
        {
            string val = "F";
            if (p != "")
            {
                try
                {
                    decimal d = Convert.ToDecimal(p);
                    val = "T";
                }
                catch
                {
                    MessageBox.Show("Please Enter Numeric");
                }
            }
            else
            {
                val = "T";
            }
            return val;
        }



        private void txtdiscouuntpersentnance_TextChanged(object sender, EventArgs e)
        {
            string Valid = numericCheck(txtdiscouuntpersentnance.Text);
            if (Valid == "F")
            {
                txtdiscouuntpersentnance.Text = "";
            }
            else
            {
                getTotalCalculation();
            }
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            string Valid = numericCheck(txtpaidamount.Text);
            if (Valid == "F")
            {
                txtpaidamount.Text = "";
            }
            else
            {
                getTotalCalculation();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            frmSave();
        }

        private void frmSave()
        {
            objData = new C_Data_Batch();
            strErr = "";
            objData.OpenConnection("AzharPC-Home", ref strErr);
            saveData();
            objData.CloseConnection();
        }

        private void saveData()
        {
            if (txtYear.Text.Trim() == "")
            {
                MessageBox.Show("Please enter year!");
                return;
            }

            int year;
            int.TryParse(txtYear.Text, out year);
            int month;
            int.TryParse(txtMonth.Text, out month);
            DateTime thisDay = DateTime.Today;
            Int64 DateDiff = Convert.ToInt64(((year * 12) + month) * 30);
            DateTime totalDays = thisDay.AddDays(-DateDiff);

            string birthDate = totalDays.Date.ToShortDateString();

            string strYear = totalDays.Year.ToString();
            string strmonth = "";
            if (totalDays.Month < 10)
            {
                strmonth = "0" + totalDays.Month; ;
            }
            else
            {
                strmonth = totalDays.Month.ToString();
            }
            string strDay = "";
            if (totalDays.Day < 10)
            {
                strDay = "0" + totalDays.Day;
            }
            else
            {
                strDay = totalDays.Day.ToString();
            }

            int intInvestigationType = 0;
            if (rbtngenaral.Checked == true)
            {
                intInvestigationType = 1;
            }
            else if (rbtnopd.Checked == true)
            {
                intInvestigationType = 2;
            }
            else
            {
                intInvestigationType = 1;
            }
            int intInvestigationDeptType = 0;
            if (rbtnpathology.Checked == true)
            {
                intInvestigationDeptType = 1;
            }
            else if (rbtndental.Checked == true)
            {
                intInvestigationDeptType = 2;
            }
            else if (rbtnbloodbank.Checked == true)
            {
                intInvestigationDeptType = 3;
            }
            else if (rbtndialysis.Checked == true)
            {
                intInvestigationDeptType = 4;
            }
            else
            {
                intInvestigationDeptType = 1;
            }
            var isUpdate = (rbtnindoor.Checked && !string.IsNullOrEmpty(txtAdmissionSl.Text.Trim())) ? true : false;
            objData.BeginTransaction(ref strErr);
            string strPatSql = "";

            strPatSql = "INSERT INTO [dbo_Patient_info]([Name],[PresentAddress],[Phone],[Year],[Month],[Day],[Gender],[BirthDate], UserID,UserPC) ";
            strPatSql = strPatSql + "VALUES('" + txtname.Text + "','" + txtaddress.Text + "','" + txtphone.Text;
            strPatSql = strPatSql + "'," + year + "," + month + ",0,'" + txtsex.SelectedValue + "','" + birthDate + "', " + Utility.userID + ",'" + Utility.PcName + "')";
            if (isUpdate)
            {
                strPatSql = "UPDATE dbo_Patient_info SET Name='" + txtname.Text + "',PresentAddress='" + txtaddress.Text + "',Phone='" + txtphone.Text + "',Year=" + txtYear.Text + ",Month=" + txtMonth.Text + ",Gender='" + txtsex.SelectedValue + "',BirthDate='" + birthDate + "',UserID=" + Utility.userID + " WHERE P_ID=" + txtid.Text + ";";
            }
            objData.ExecuteQuery(strPatSql, ref strErr);

            if (strErr == "")
            {
                string strInvFndSL = "";
                strInvFndSL = "select case when max(Invetigation_SL) is null then 1001 else max(Invetigation_SL)+1 end From dbo_Investigation where month(CreatedON) = month(getdate()) AND  YEAR(CreatedON) = YEAR(getdate()) ";
                DataTable arrMaxInvSL = objData.RetriveData(strInvFndSL, ref strErr);
                if (strErr == "")
                {
                    int maxInvSlL = 0;
                    maxInvSlL = Convert.ToInt32(arrMaxInvSL.Rows[0][0].ToString());

                    string strP_ID = "select CASE WHEN max(p_ID) IS NULL THEN 0 ELSE max(p_ID) END From dbo_Patient_info ";
                    DataTable arrp_ID = objData.RetriveData(strP_ID, ref strErr);
                    int p_IDval = 0;
                    p_IDval = Convert.ToInt32(arrp_ID.Rows[0][0].ToString());
                    if (isUpdate)
                    {
                        p_IDval = Convert.ToInt32(txtid.Text);
                    }
                    var pc = txtpc.Text;
                    if (pc.Trim() == "")
                    {
                        pc = "0";

                    }

                    var disciuntBy = lstDiscount.SelectedIndex == -1 ? "0" : lstDiscount.SelectedValue.ToString();

                    string strInvSql = "";
                    strInvSql = "INSERT INTO [dbo_Investigation]([DocID],[DiscountTK],[DiscountPasentance],[TotalDue],[InvestigationType],[InvestigationDeptType]";
                    strInvSql = strInvSql + " ,[P_ID],[Invetigation_SL],[PC_CC], [userID],[UserPC], DiscountByID" + (isUpdate ? ",[Admission_id]" : "") + ")";
                    strInvSql = strInvSql + " Values (" + txtdoctorid.Text + ", " + txtdiscount.Text + ", " + txtdiscouuntpersentnance.Text + ", " + txttotaldue.Text;
                    strInvSql = strInvSql + ", " + intInvestigationType + ", " + intInvestigationDeptType + ", " + p_IDval + ", " + maxInvSlL + ", " + pc + "," + Utility.userID + ",'" + Utility.PcName + "'," + disciuntBy + (isUpdate ? "," + lblAdmissionId.Text : "") + " )";

                    objData.ExecuteQuery(strInvSql, ref strErr);

                    if (strErr == "")
                    {

                        string strMaxInvID = "";
                        strMaxInvID = "select max(Investigationid) from dbo_Investigation";
                        DataTable arrMaxInvID = objData.RetriveData(strMaxInvID, ref strErr);

                        if (strErr == "")
                        {
                            int maxInvID = 0;
                            if (arrMaxInvID.Rows.Count > 0)
                            {
                                if (arrMaxInvID.Rows[0][0].ToString() == "")
                                {
                                    maxInvID = 0;
                                }
                                else
                                {
                                    maxInvID = Convert.ToInt32(arrMaxInvID.Rows[0][0].ToString());
                                }
                            }
                            else
                            {
                                maxInvID = 0;
                            }
                            string strSqlInvItem = "";

                            for (int i = 0; i < dgvInvestigation.Rows.Count; i++)
                            {
                                if (strSqlInvItem == "")
                                {

                                    strSqlInvItem = " (" + maxInvID + ", " + dgvInvestigation.Rows[i].Cells[1].Value + ",getdate(), 0," + Utility.userID + ", " + dgvInvestigation.Rows[i].Cells[3].Value + ",'" + dgvInvestigation.Rows[i].Cells[4].Value + "' ,'" + dgvInvestigation.Rows[i].Cells[5].Value + "','" + Utility.PcName + "' )";
                                }
                                else
                                {
                                    strSqlInvItem = strSqlInvItem + ", (" + maxInvID + ", " + dgvInvestigation.Rows[i].Cells[1].Value + ",getdate(), 0," + Utility.userID + ", " + dgvInvestigation.Rows[i].Cells[3].Value + ",'" + dgvInvestigation.Rows[i].Cells[4].Value + "' ,'" + dgvInvestigation.Rows[i].Cells[5].Value + "','" + Utility.PcName + "' )";
                                }
                            }

                            if (strSqlInvItem != "")
                            {
                                string strSqlInvItemMain = "INSERT INTO [dbo_InvertigationServiceItem]([Investigationid],[Service_ID],[Date],[Status],[UserID],Amount, DeliveryOn, Remaks,UserPC) Values " + strSqlInvItem;
                                objData.ExecuteQuery(strSqlInvItemMain, ref strErr);
                                if (strErr == "")
                                {
                                    string strSqlSpotCommission = "USP_Inv_Calculate_SpotCommission " + maxInvSlL+","+DateTime.Today.Month+","+DateTime.Today.Year;
                                    objData.ExecuteQuery(strSqlSpotCommission, ref strErr);
                                    getPrint(maxInvID.ToString());
                                    objData.CommitTransaction(ref strErr);
                                    frmload();
                                    objData.CloseConnection();
                                }
                                else
                                {
                                    objData.Rollback(ref strErr);
                                }
                            }

                        }
                        else
                        {
                            objData.Rollback(ref strErr);
                        }
                    }
                    else
                    {
                        objData.Rollback(ref strErr);
                    }
                }
                else
                {
                    objData.Rollback(ref strErr);
                }

            }
            else
            {
                objData.Rollback(ref strErr);
            }

        }

        private void getPrint(string p)
        {
            string strSQLCashMemo = "";
            strSQLCashMemo = "select max(CM_ID) From dbo_CashMemo ";
            string strSQLCashMemoSL = "";
            strSQLCashMemoSL = "select max(CM_SL) From dbo_CashMemo where month(CreatedOn) = month(getdate()) ";

            DataTable arrCashID = objData.RetriveData(strSQLCashMemo, ref strErr);
            DataTable arrCashSL = objData.RetriveData(strSQLCashMemoSL, ref strErr);


            int cashSL = 0;
            if (arrCashSL.Rows.Count > 0)
            {
                if (arrCashSL.Rows[0][0].ToString() == "")
                {
                    cashSL = 1000;
                }
                else
                {
                    cashSL = Convert.ToInt32(arrCashSL.Rows[0][0].ToString()) + 1;
                }
            }
            else
            {
                cashSL = 1000;
            }

            string strSQLCASH = "";
            int paidAmount = 0;
            var paidVal = txtpaidamount.Text;
            if (paidVal.Trim() == "")
            {
                paidAmount = 0;
            }
            else
            {
                paidAmount = Convert.ToInt32(paidVal);
            }

            int totalDueAmount = 0;
            if (txttotaldue.Text == "")
            {
                totalDueAmount = 0;
            }
            else
            {
                totalDueAmount = Convert.ToInt32(txttotaldue.Text);
            }

            var strDueCollection = "insert into dbo_Inv_Due_Collection (investigationID, Paid_Amount, Paid_Type, UserId, UserPC) ";
            strDueCollection += " Values (" + p + ", " + paidAmount + ", 'I'," + hms.Include_Files.Utility.userID + ", '" + hms.Include_Files.Utility.PcName + "' )";
            objData.ExecuteQuery(strDueCollection, ref strErr);

            strSQLCASH = "insert into [dbo_CashMemo]([CM_SL], [InvetigationID], [Pay_Amount], [Due], USERID,UserPC) ";
            strSQLCASH = strSQLCASH + "Values (" + cashSL + ", " + p + ", " + paidAmount + ", " + totalDueAmount + ", " + Utility.userID + ",'" + Utility.PcName + "')";
            objData.ExecuteQuery(strSQLCASH, ref strErr);

            if (strErr == "")
            {
                int cashID = 0;
                if (arrCashID.Rows.Count > 0)
                {
                    if (arrCashID.Rows[0][0].ToString() == "")
                    {
                        cashID = 0;
                    }
                    else
                    {
                        cashID = Convert.ToInt32(arrCashID.Rows[0][0].ToString());
                    }
                }
                else
                {
                    cashID = 0;
                }
                var confirmResult = MessageBox.Show("Investigation created succefully.\n do you want to get print?",
                                                             @"Confirm Delete!!",
                                                             MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string strSQL = "";
                    strSQL = "select * from v_investigation where InvestigationID  = " + p;
                    var StrSQL = "Select DiscountByID, dbo.f_get_inv_DiscountAmont(InvestigationID), dbo.f_Get_Inv_ReturnAmount(InvestigationID) From dbo_Investigation where InvestigationID = " + p;
                    DataTable arrCatList = objData.RetriveData(strSQL, ref strErr);
                    var DisINfo = objData.RetriveData(StrSQL, ref strErr);
                    DataSet ds = new DataSet();
                    ds.Tables.Add(arrCatList);

                    var rptpath = Utility.ReportPath + "rptInvestigation.rpt";
                    var ReportDoc = new ReportDocument();
                    ReportDoc.Load(rptpath);
                    ReportDoc.SetDataSource(ds.Tables[0]);



                    ReportDoc.SetParameterValue("discount_amount", DisINfo.Rows[0][1].ToString());
                    ReportDoc.SetParameterValue("discountBy", DisINfo.Rows[0][0].ToString());
                    ReportDoc.SetParameterValue("return_amount", DisINfo.Rows[0][2].ToString());
                    ReportDoc.SetParameterValue("UserName", Utility.UserName);
                    ReportDoc.SetParameterValue("IsDuplicate", 0);
                    Utility.Print(ReportDoc, rptpath, 3);
                }

            }
            else
            {
                MessageBox.Show(@"Cash memo not Created on the system");
                objData.Rollback(ref strErr);
            }
        }



        private void btnGridDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInvestigation.Rows.Count; i++)
            {
                if ((bool)dgvInvestigation.Rows[i].Cells[0].FormattedValue)
                {
                    dgvInvestigation.Rows.Remove(dgvInvestigation.Rows[i]);
                    i--;
                }
            }
            getTotalCalculation();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            frmInvestigationSearchEdit fr = new frmInvestigationSearchEdit();
            fr.Show();
        }



        private void txtdoctorinformation_KeyUp(object sender, KeyEventArgs e)
        {
            loaddoctor();
            if (e.KeyCode == Keys.Down)
            {
                lstdoctorsinformation.Focus();
                lstdoctorsinformation.SelectedIndex = 0;
            }

        }

        private void loaddoctor()
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            getDocList(txtdoctorinformation.Text.Trim());
            objData.CloseConnection();
        }

        private void btnDocRefresh_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            getDocList();
            objData.CloseConnection();
        }

        private void txtSearchServices_KeyUp(object sender, KeyEventArgs e)
        {

            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            getServices();
            objData.CloseConnection();

            if (e.KeyCode == Keys.Down)
            {
                lsttestname.Focus();
                lsttestname.SelectedIndex = 0;
            }

        }

        private void txtSearchServices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchServices.Text == "0")
            {
                if (e.KeyChar == (char)13)
                {
                    frmserviceiteminformation fr = new frmserviceiteminformation();
                    fr.Show();

                }

            }
        }

        private void txtpc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtdiscouuntpersentnance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtpaidamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                frmSave();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btndailyladger_Click(object sender, EventArgs e)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);

            var intUserID = Utility.userID;
            if (intUserID == 2 || intUserID == 1 || intUserID == 3 || intUserID == 7 || intUserID == 9)
            {
                intUserID = -1;
            }
            var sql = "USP_Inv_Daily_ledger " + intUserID;
            var dtReport = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            var dataset = new DataSet();
            dataset.Tables.Add(dtReport);
            var reportviewer = new frmReport();
            var rptpath = Utility.ReportPath + "rptDailyLedger.rpt";
            reportviewer.ReportPath = rptpath;
            reportviewer.Reportds = dataset;
            reportviewer.Show(this);
        }

        private void rbtnindoor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnindoor.Checked)
            {
                txtAdmissionSl.ReadOnly = false;
                txtAdmissionSl.Focus();
                new frmAdmitedPatientList("frmfrontdeskinvestigation") { Owner = this }.ShowDialog();
            }
            else
            {
                txtAdmissionSl.ReadOnly = true;
                txtAdmissionSl.Text = "";
                lblAdmissionId.Text = "";
            }
        }

        private void txtAdmissionSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdmissionSl.Text.Trim()))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    admittedPatientInfo();
                }
            }
        }

        private void admittedPatientInfo()
        {
            objData.OpenConnection("AzharPC-Home", ref strErr);
            var sql = "SELECT AD.P_ID,PT.Name,PT.PresentAddress,PT.Phone,PT.Year,PT.Month,PT.Gender,AD.Reference_Doc_ID,AD.Admission_Id FROM dbo_Admission AD INNER JOIN dbo_Patient_info PT ON PT.P_ID=AD.P_ID WHERE CAST(AD.Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) ='" + txtAdmissionSl.Text.Trim() + "'";
            var dtPatientInfo = objData.RetriveData(sql, ref strErr);
            if (strErr == "" && dtPatientInfo.Rows.Count > 0)
            {
                txtid.Text = dtPatientInfo.Rows[0][0].ToString();
                txtname.Text = dtPatientInfo.Rows[0][1].ToString();
                txtaddress.Text = dtPatientInfo.Rows[0][2].ToString();
                txtphone.Text = dtPatientInfo.Rows[0][3].ToString();
                txtYear.Text = dtPatientInfo.Rows[0][4].ToString();
                txtMonth.Text = dtPatientInfo.Rows[0][5].ToString();
                txtsex.SelectedValue = dtPatientInfo.Rows[0][6].ToString();
                lstdoctorsinformation.SelectedValue = dtPatientInfo.Rows[0][7].ToString();
                lstdoctorsinformation.Enabled = txtdoctorinformation.Enabled = false;
                lblAdmissionId.Text = dtPatientInfo.Rows[0][8].ToString();
                loadDoctorInformation();
            }
            else
            {
                MessageBox.Show("Invalid Admission id.");
                clearFileds();
            }
            objData.CloseConnection();
        }

        private void lsttestname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                addService();
                txtSearchServices.Text = "";
                txtSearchServices.Focus();
            }
        }

        private void txtSearchServices_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstdoctorsinformation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                selectDoctorInfo();
                txtdoctorinformation.Text = "";
                txtdiscount.Focus();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            new frmInvestigationSearchEdit().Show();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            txtsex.SelectedValue = txtname.Text.ToLower().StartsWith("mrs") || txtname.Text.ToLower().StartsWith("mst") ? "F" : "M";
        }

        private void txtreceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                frmSave();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtreceive_TextChanged(object sender, EventArgs e)
        {
            int paidAmount;
            int.TryParse(txtpaidamount.Text, out paidAmount);

            int receiveAmount;
            int.TryParse(txtreceive.Text, out receiveAmount);

            txtReturn.Text = (receiveAmount - paidAmount).ToString();

        }

        private void txtReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lstDiscount.Focus();
                lstDiscount.SelectedIndex = 0;
            }
        }

        private void txtdiscouuntpersentnance_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lstDiscount.Focus();
                lstDiscount.SelectedIndex = 0;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
            //FirstLetterToUpper()
            //txtname.Text = Utility.FirstLetterToUpper(txtname.Text);

        }

        private void lsttestname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstTime != "0") return;
            var sql = "select Amount from Dbo_Services where service_id = " + lsttestname.SelectedValue;
            //C_Data_Batch objData;
            strErr = "";
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Office", ref strErr);

            var arrServicePrice = objData.RetriveData(sql, ref strErr);

            if (strErr == "")
            {
                if (arrServicePrice.Rows.Count > 0)
                {
                    lblServicePrice.Text = arrServicePrice.Rows[0][0].ToString();
                }
                else
                {
                    lblServicePrice.Text = "";
                }
            }
            else
            {
                lblServicePrice.Text = "";
            }

            objData.CloseConnection();
        }

        public void LoadAdmissionInfo(string addmissionSl, string admission_Id)
        {
            //Utility.ClearAllControls(this);
            txtAdmissionSl.Text = addmissionSl;
            admittedPatientInfo();


        }

    }
}
