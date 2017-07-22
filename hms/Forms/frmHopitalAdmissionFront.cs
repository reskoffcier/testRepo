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
using CrystalDecisions.CrystalReports.Engine;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmHopitalAdmissionFront : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        public string strErr = "";
        public frmHopitalAdmissionFront()
        {
            InitializeComponent();
            txtgender.DataSource = new List<object>
            {
                new {Text = "Male", Value = "M"},
                new {Text = "Female", Value = "F"}
            };
            txtgender.DisplayMember = "Text";
            txtgender.ValueMember = "Value";
            txtgender.BackColor = Color.White;

            txtReligion.DataSource = new List<object>
            {
                new {Text = "Islam", Value = "Islam"},
                new {Text = "Hinduism", Value = "Hinduism"},
                new {Text = "Christianity", Value = "Christianity"},
                new {Text = "Buddhism", Value = "Buddhism"},
                new {Text = "Taoism", Value = "Taoism"},
                new {Text = "Sikhism", Value = "Sikhism"},
                new {Text = "Judaism", Value = "Judaism"}
            };
            txtReligion.DisplayMember = "Text";
            txtReligion.ValueMember = "Value";
            txtReligion.BackColor = Color.White;

            objData.OpenConnection("AatickPC-Office", ref strErr);
            SetNewEnv();
            objData.CloseConnection();
            LoadDoctorList(lstdoctorsinformation, "");
            LoadDoctorList(lstDoctors, "");
            btnedit.Enabled = btnpreview.Enabled = false;

        }

        private void getID()
        {
            //throw new NotImplementedException();
            var admissionid = "1";

            if (strErr == "")
            {
                var sql = "select case when max(admission_id) is null then 0 else max(admission_id) end  from dbo_Admission";
                var dt = objData.RetriveData(sql, ref strErr);
                if (dt.Rows.Count > 0)
                {
                    admissionid = Convert.ToString(Convert.ToInt16(dt.Rows[0][0]) + 1);
                }

            }

            txtadmissionid.Text = admissionid;
        }

        private void LoadBedInfo()
        {
            var strErr = "";
            var strSql = "SELECT BI.BI_ID 'Bed Id',BI.Name Bed,BI.BI_Number Serial,BI.Rate Rent,'No' Booked,'' Note FROM Bed_Information BI WHERE (SELECT COUNT(1) FROM Patient_Bed WHERE BI_ID=BI.BI_ID AND isBooked=1)=0";
            var bedList = objData.RetriveData(strSql, ref strErr);
            lstBedInfo.DataSource = bedList;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveAdmissionInfo();
        }

        private void SaveAdmissionInfo()
        {
            var userid = Utility.userID;
            var patientName = txtPatientName.Text;
            int d, m, y;
            int.TryParse(txtdd.Text, out d);
            int.TryParse(txtmm.Text, out m);
            int.TryParse(txtyyy.Text, out y);
            if (y == 0 && m == 0 && d == 0)
            {
                MessageBox.Show("Please enter age.");
                txtyyy.Focus();
                return;
            }
            var day = d.ToString();
            var month = m.ToString();
            var year = y.ToString();
            var gender = txtgender.SelectedValue;
            var isFathertemp = rbtnfathername.Checked;
            var isHusbandtemp = rbtnhusbandname.Checked;
            var txtFatherOrHusband = txtFatherOrHusbandname.Text;
            var mothername = txtMotherName.Text;
            var religion = txtReligion.SelectedValue;
            var occupation = txtoccupation.Text;
            var guardian = txtguardian.Text;
            var guardianAddress = txtGuardianAddress.Text;
            var patientPresentAddress = txtpresentaddress.Text;
            var patientParmanentAddress = txtpermanetaddress.Text;
            var patientPhone = txtphone.Text;
            var dtbirthDate = DateTime.Now.AddYears(int.Parse("-" + year)).AddMonths(int.Parse("-" + month)).AddDays(int.Parse("-" + day));
            var isFather = isHusbandtemp ? 0 : 1;
            var hospitalFee = 0;
            int.TryParse(txtFee.Text, out hospitalFee);
            var advance = txtadvance.Text == "" ? "0" : txtadvance.Text;

            var selectedBed = lstBedInfo.CurrentRow;

            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            objData.BeginTransaction(ref strErr);
            var p_id = 0;

            //var sqlpatientSl = "SELECT '" + dtbirthDate.ToString("yyyyMMdd") + "'+ CASE WHEN MAX(P_ID) IS NULL THEN '1' ELSE CAST((MAX(P_ID)+1) AS VARCHAR(20)) END FROM dbo_patient_info WHERE CreatedOn>='" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString() + "'";
            //var dtpatientSl = objData.RetriveData(sqlpatientSl, ref strErr);

            var insertPatientinfo = "Insert into dbo_patient_info(Name,PresentAddress,Phone,Year,Month,Day,Gender,BirthDate,UserID,UserPC) values";
            insertPatientinfo += "('" + patientName + "','" + patientPresentAddress + "','" + patientPhone + "'," + year + "," + month + "," + day + ",'" + gender + "','" + dtbirthDate + "'," + userid + ",'" + Utility.PcName + "')";
            objData.ExecuteQuery(insertPatientinfo, ref strErr);
            var intAdmissionId = "";
            var maxCashId = "";
            if (strErr == "")
            {
                var sqlSelectPatientId = "select max(p_id) from dbo_patient_info";
                var dtSelectPatientId = objData.RetriveData(sqlSelectPatientId, ref strErr);
                if (strErr == "")
                {
                    p_id = int.Parse(dtSelectPatientId.Rows[0][0].ToString());
                    var sqlInsertPatientOtherInfo = "Insert into dbo_Patient_other_info(P_ID,IsFather,ForH_Name,Region,Occupation,Guardian,Parmanent_address,Mother_Name,Gurdian_Address,Guardian_Relation) values";
                    sqlInsertPatientOtherInfo += "(" + p_id + "," + isFather + ",'" + txtFatherOrHusband + "','" +
                                                 religion + "','" + occupation + "','" + guardian + "','" +
                                                 patientParmanentAddress + "','" + mothername + "','" + guardianAddress + "','" + txtRelation.Text + "')";
                    objData.ExecuteQuery(sqlInsertPatientOtherInfo, ref strErr);
                    if (strErr == "")
                    {
                        var refDocid = txtdoctorid.Text;
                        var underDocid = txtadmissonunder.Text;

                        var sqladmissionSl = "SELECT CASE WHEN MAX(Admission_SL) IS NULL THEN 1001 ELSE MAX(Admission_SL)+1 END FROM dbo_Admission WHERE CreatedOn>='" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString() + "'";
                        var dtAddmissionSl = objData.RetriveData(sqladmissionSl, ref strErr);

                        if (strErr == "")
                        {
                            var insertAddmissioninfosql = "INSERT INTO dbo_Admission(P_ID,Reference_Doc_ID,Under_Doc_ID,Admission_SL,UserID,UserPC,Hospital_Fee) VALUES(" + p_id + "," + refDocid + "," + underDocid + "," + dtAddmissionSl.Rows[0][0] + "," + Utility.userID + ",'" + Utility.PcName + "'," + hospitalFee + ")";
                            objData.ExecuteQuery(insertAddmissioninfosql, ref strErr);
                            if (strErr == "")
                            {
                                var sqlSelectAdmissionId = "select max(Admission_id) from dbo_Admission";
                                var dtSelectAdmissionId = objData.RetriveData(sqlSelectAdmissionId, ref strErr);
                                if (strErr == "")
                                {
                                    intAdmissionId = dtSelectAdmissionId.Rows[0][0].ToString();
                                    var insertAdmissionOtherinfosql =
                                                        "INSERT INTO dbo_Admission_other_info(Admission_Id,Provisional_Diagnosis,ListOfDiagnosis) VALUES(" +
                                                        dtSelectAdmissionId.Rows[0][0] + ",'" + txtprovisionsis.Text +
                                                        "','" + txtlistofdocument.Text + "')";
                                    objData.ExecuteQuery(insertAdmissionOtherinfosql, ref strErr);
                                    if (strErr == "")
                                    {
                                        var insertBedinfosql = "INSERT INTO Patient_Bed(BI_ID,Admission_id,Booked_On,isBooked,Note,UserID,UserPC) VALUES(" + selectedBed.Cells[0].Value + "," + dtSelectAdmissionId.Rows[0][0] + ",getdate(),1,'" + selectedBed.Cells[5].Value + "'," + Utility.userID + ",'" + Utility.PcName + "')";
                                        objData.ExecuteQuery(insertBedinfosql, ref strErr);
                                        if (strErr == "")
                                        {
                                            if (!string.IsNullOrEmpty(advance))
                                            {
                                                var insertDepositinfosql =
                                                    "INSERT INTO Hospital_Deposit(Admission_id,Deposit_amount,Deposit_On,UserID,UserPC,Deposite_Type) VALUES(" +
                                                    dtSelectAdmissionId.Rows[0][0] + ",'" + advance + "',getdate()," + Utility.userID + ",'" + Utility.PcName + "','A')";
                                                objData.ExecuteQuery(insertDepositinfosql, ref strErr);
                                                if (strErr == "")
                                                {
                                                    var sqlcashSl =
                                                        "SELECT CASE WHEN MAX(CM_SL) IS NULL THEN 1001 ELSE MAX(CM_SL)+1 END FROM dbo_CashMemo WHERE CreatedOn>='" +
                                                        new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                                                            .ToShortDateString() + "'";
                                                    var dtACashSl = objData.RetriveData(sqlcashSl, ref strErr);
                                                    if (strErr == "")
                                                    {
                                                        var insertCashMemosql =
                                                            "INSERT INTO dbo_CashMemo(Admission_ID,CM_SL,Pay_Amount,USERID,UserPC) VALUES(" +
                                                            dtSelectAdmissionId.Rows[0][0] + "," + dtACashSl.Rows[0][0] +
                                                            "," + advance + "," + userid + ",'" + Utility.PcName + "')";
                                                        objData.ExecuteQuery(insertCashMemosql, ref strErr);

                                                        var selectCashMaxId = "SELECT MAX(CM_ID) FROM dbo_CashMemo;";
                                                        var arrMaxCashId = objData.RetriveData(selectCashMaxId, ref strErr);
                                                        maxCashId = arrMaxCashId.Rows[0][0].ToString();
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            var msg = "";
            if (strErr != "")
            {
                objData.Rollback(ref strErr);
                msg = "An Error occured.\nTry again later.";
            }
            else
            {

                objData.CommitTransaction(ref strErr);
                msg = @"Successfully admitted";
            }
            objData.CloseConnection();
            if (strErr == "")
            {
                SetNewEnv();
            }
            MessageBox.Show(msg);
            if (strErr == "")
            {
                ShowAdmissionReport(intAdmissionId);
                PrintMoneyReceipt(maxCashId);
            }
            btnpreview.Enabled = true;
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            new frmAdmitedPatientList() { Owner = this }.ShowDialog();
        }

        private void txtdoctorsinformation_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDoctorList(lstdoctorsinformation, txtdoctorsinformation.Text);
            if (e.KeyCode == Keys.Down && lstdoctorsinformation.Items.Count > 0)
            {
                lstdoctorsinformation.SelectedIndex = 0;
                lstdoctorsinformation.Focus();
            }
        }

        private void txtDoctors_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDoctorList(lstDoctors, txtDoctors.Text);
            if (e.KeyCode == Keys.Down && lstDoctors.Items.Count > 0)
            {
                lstDoctors.SelectedIndex = 0;
                lstDoctors.Focus();
            }
        }

        private void LoadDoctorList(ListBox list, string searchText, bool isPc = false)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);

            string strSQL = "";
            strSQL = "select DocID, Name from dbo_Doctor_List WHERE Name LIKE '%" + searchText + "%' " + (isPc ? "AND IsPc=1" : "") + " order by Name";
            var doctorList = objData.RetriveData(strSQL, ref strErr);
            if (strErr == "")
            {
                list.DataSource = doctorList;
                list.DisplayMember = "Name";
                list.ValueMember = "DocID";
                list.SelectedIndex = -1;
            }
            objData.CloseConnection();
        }

        private void FillDoctorDetails(string docid)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);

            string strSQL = "";
            strSQL = "select Title, Name, Degree, Specialist, Area, Doctype from dbo_Doctor_List WHERE DocId=" + docid;
            var doctorList = objData.RetriveData(strSQL, ref strErr);
            if (strErr == "")
            {
                txtTitle.Text = doctorList.Rows[0][0].ToString();
                txtDocname.Text = doctorList.Rows[0][1].ToString();
                txtdegree.Text = doctorList.Rows[0][2].ToString();
                txtspecialist.Text = doctorList.Rows[0][3].ToString();
                txtarea.Text = doctorList.Rows[0][4].ToString();
                txttype.Text = doctorList.Rows[0][5].ToString();
            }
            objData.CloseConnection();
        }

        private void lstdoctorsinformation_DoubleClick(object sender, EventArgs e)
        {
            SetReferrerDoctorInfo();
        }

        private void SetReferrerDoctorInfo()
        {
            if (lstdoctorsinformation.Items.Count > 0)
            {
                var docid = lstdoctorsinformation.SelectedValue.ToString();
                txtdoctorid.Text = docid;
                FillDoctorDetails(docid);
            }
        }

        private void lstDoctors_DoubleClick(object sender, EventArgs e)
        {
            SetUnderDoctorInfo();
        }

        private void SetUnderDoctorInfo()
        {
            if (lstDoctors.Items.Count > 0)
            {
                var docid = lstDoctors.SelectedValue.ToString();
                txtadmissonunder.Text = docid;
                FillDoctorDetails(docid);
            }

        }
        public void LoadPatientInfo(string add_id, string p_id)
        {
            var strErr = "";
            txtadmissionid.Text = add_id;
            objData.OpenConnection("AatickPC-Office", ref strErr);

            string strSQL = "";
            strSQL = "SELECT PI.Name,PI.Year,PI.Month,PI.Day,PI.Gender,PO.IsFather,PO.ForH_Name,PO.Region,PO.Guardian,PO.Parmanent_address,PI.PresentAddress,PI.Phone,AD.Reference_Doc_ID,AD.Under_Doc_ID,PAB.BI_ID,ADO.Provisional_Diagnosis,ADO.ListOfDiagnosis,HP.Deposit_amount,PO.Guardian_Relation,DL.IsPc FROM dbo_patient_info PI INNER JOIN dbo_patient_other_info PO ON PO.P_ID=PI.P_ID INNER JOIN dbo_Admission AD ON AD.P_ID=PI.P_ID INNER JOIN Patient_Bed PAB ON PAB.Admission_id=AD.Admission_Id INNER JOIN dbo_Admission_other_info ADO ON ADO.Admission_Id=AD.Admission_Id INNER JOIN Hospital_Deposit HP ON HP.Admission_id=AD.Admission_Id left join dbo_Doctor_List DL ON DL.DocID=AD.Reference_Doc_ID WHERE AD.Admission_Id=" + add_id;
            var patientInfo = objData.RetriveData(strSQL, ref strErr);
            if (strErr == "" && patientInfo.Rows.Count > 0)
            {
                lblP_Id.Text = p_id;
                txtPatientName.Text = patientInfo.Rows[0][0].ToString();
                txtyyy.Text = patientInfo.Rows[0][1].ToString();
                txtmm.Text = patientInfo.Rows[0][2].ToString();
                txtdd.Text = patientInfo.Rows[0][3].ToString();
                txtgender.SelectedValue = patientInfo.Rows[0][4].ToString();
                rbtnfathername.Checked = patientInfo.Rows[0][5].ToString() == "1";
                rbtnhusbandname.Checked = patientInfo.Rows[0][5].ToString() != "1";
                txtFatherOrHusbandname.Text = patientInfo.Rows[0][6].ToString();
                txtReligion.SelectedValue = patientInfo.Rows[0][7].ToString();
                txtguardian.Text = patientInfo.Rows[0][8].ToString();
                txtpermanetaddress.Text = patientInfo.Rows[0][9].ToString();
                txtpresentaddress.Text = patientInfo.Rows[0][10].ToString();
                txtphone.Text = patientInfo.Rows[0][11].ToString();
                txtdoctorid.Text = patientInfo.Rows[0][12].ToString();
                txtadmissonunder.Text = patientInfo.Rows[0][13].ToString();
                var bedId = patientInfo.Rows[0][14].ToString();
                txtprovisionsis.Text = patientInfo.Rows[0][15].ToString();
                txtlistofdocument.Text = patientInfo.Rows[0][16].ToString();
                txtadvance.Text = patientInfo.Rows[0][17].ToString();
                txtadvance.ReadOnly = true;

                if (bool.Parse(patientInfo.Rows[0][19].ToString()))
                {
                    chkPc.Checked = true;
                    LoadDoctorList(lstdoctorsinformation, "", true);
                }

                lstdoctorsinformation.SelectedValue = patientInfo.Rows[0][12].ToString();
                lstDoctors.SelectedValue = patientInfo.Rows[0][13].ToString();

                FillDoctorDetails(patientInfo.Rows[0][13].ToString());

                txtRelation.Text = patientInfo.Rows[0][18].ToString();
                btnedit.Enabled = btnpreview.Enabled = true;
                btnsave.Enabled = false;
            }
            objData.CloseConnection();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            SetNewEnv();
        }

        private void SetNewEnv()
        {
            //throw new NotImplementedException();
            Utility.ClearAllControls(this);
            btnsave.Enabled = true;
            btnedit.Enabled = btnpreview.Enabled = false;
            objData.OpenConnection("AatickPC-Office", ref strErr);
            getID();
            LoadBedInfo();
            objData.CloseConnection();
            txtadvance.ReadOnly = false;
            txtPatientName.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            var userid = Utility.userID;
            var patientName = txtPatientName.Text;
            var day = txtdd.Text;
            var month = txtmm.Text;
            var year = txtyyy.Text;
            var gender = txtgender.Text;
            var isFathertemp = rbtnfathername.Checked;
            var isHusbandtemp = rbtnhusbandname.Checked;
            var txtFatherOrHusband = txtFatherOrHusbandname.Text;
            var mothername = txtMotherName.Text;
            var religion = txtReligion.SelectedValue;
            var occupation = txtoccupation.Text;
            var guardian = txtguardian.Text;
            var guardianAddress = txtGuardianAddress.Text;
            var patientPresentAddress = txtpresentaddress.Text;
            var patientParmanentAddress = txtpermanetaddress.Text;
            var patientPhone = txtphone.Text;
            var dtbirthDate = DateTime.Now.AddYears(int.Parse("-" + year)).AddMonths(int.Parse("-" + month)).AddDays(int.Parse("-" + day));
            var isFather = isHusbandtemp ? 0 : 1;

            //var advance = txtadvance.Text == "" ? "0" : txtadvance.Text;

            //var selectedBed = lstBedInfo.SelectedRows[0];
            var gRelation = txtRelation.Text;
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            objData.BeginTransaction(ref strErr);
            var p_id = lblP_Id.Text;

            var updatePatientinfo = "UPDATE dbo_patient_info SET Name='" + patientName + "',PresentAddress='" + patientPresentAddress + "',Phone='" + patientPhone + "',Year=" + year + ",Month=" + month + ",Day=" + day + ",Gender='" + gender + "',BirthDate='" + dtbirthDate.ToShortDateString() + "' WHERE P_ID=" + p_id;
            objData.ExecuteQuery(updatePatientinfo, ref strErr);

            if (strErr == "")
            {
                var sqlUpdatePatientOtherInfo = "UPDATE dbo_Patient_other_info SET IsFather=" + isFather + ",ForH_Name='" + txtFatherOrHusband + "',Region='" + religion + "',Occupation='" + occupation + "',Guardian='" + guardian + "',Parmanent_address='" + patientParmanentAddress + "',Mother_Name='" + mothername + "',Gurdian_Address='" + guardianAddress + "',Guardian_Relation='" + gRelation + "' WHERE P_ID=" + p_id;
                objData.ExecuteQuery(sqlUpdatePatientOtherInfo, ref strErr);
                if (strErr == "")
                {
                    var refDocid = txtdoctorid.Text;
                    var underDocid = txtadmissonunder.Text;

                    var updateAddmissioninfosql = "UPDATE dbo_Admission SET Reference_Doc_ID=" + refDocid + ",Under_Doc_ID=" + underDocid + ",UpdatedOn='" + DateTime.Now.ToShortDateString() + "' WHERE Admission_Id=" + txtadmissionid.Text;
                    objData.ExecuteQuery(updateAddmissioninfosql, ref strErr);
                    if (strErr == "")
                    {
                        var updateAdmissionOtherinfosql = "UPDATE dbo_Admission_other_info SET Provisional_Diagnosis='" + txtprovisionsis.Text + "',ListOfDiagnosis='" + txtlistofdocument.Text + "' WHERE Admission_Id=" + txtadmissionid.Text;
                        objData.ExecuteQuery(updateAdmissionOtherinfosql, ref strErr);
                    }
                }
            }

            var msg = "";
            if (strErr != "")
            {
                objData.Rollback(ref strErr);
                msg = "An Error occured.\nTry again later.";
            }
            else
            {
                objData.CommitTransaction(ref strErr);
                msg = @"Successfully updated.";
            }
            //setNewEnv();
            objData.CloseConnection();
            if (strErr == "")
            {
                SetNewEnv();
            }
            MessageBox.Show(msg);
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            var admission_id = txtadmissionid.Text;
            ShowAdmissionReport(admission_id, true);
        }

        private void ShowAdmissionReport(string admission_id, bool isEdit = false)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSQL = "SELECT Top 1 CAST(Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) Admission_SL";
            strSQL += " ,BI.Name Bed_Name,PI.Name,AD.CreatedOn,PI.Year,PI.Month,PI.Day,PI.Gender";
            strSQL += " ,DL.Title+' '+DL.Name+','+DL.Degree+','+DL.Specialist+',Phone: '+dl.Phone DoctorInfo";
            strSQL += " ,PO.ForH_Name,PO.Mother_Name,PI.PresentAddress,PO.Parmanent_address,PO.Region,PO.Occupation";
            strSQL += " ,PO.Guardian,PO.Guardian_Relation,po.Gurdian_Address,PI.Phone";
            strSQL += " ,ADO.Provisional_Diagnosis,ADO.ListOfDiagnosis,PB.Booked_On,U.Name UserName,BI.BI_Number BedNo,AD.Reference_Doc_ID RefDoc";
            strSQL +=
                " FROM dbo_Admission AD INNER JOIN dbo_Admission_other_info ADO ON ADO.Admission_Id=AD.Admission_Id ";
            strSQL += " INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID ";
            strSQL += " INNER JOIN dbo_Patient_other_info PO ON PO.P_ID=AD.P_ID ";
            strSQL += " LEFT JOIN Patient_Bed PB ON PB.Admission_id=AD.Admission_Id";
            strSQL += " LEFT JOIN Bed_Information BI ON BI.BI_ID=PB.BI_ID";
            strSQL += " LEFT JOIN dbo_Users U ON U.User_Id=AD.UserId";
            strSQL += " LEFT JOIN dbo_Doctor_List DL ON DL.DocID=AD.Under_Doc_ID WHERE AD.Admission_Id=" + admission_id + " order by PB.Booked_On desc";
            var patientInfo = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            var dataset = new DataSet();
            dataset.Tables.Add(patientInfo);
            var reportviewer = new frmReport();
            var rptpath = Utility.ReportPath + "rptAdmissionForm.rpt";
            reportviewer.ReportPath = rptpath;
            reportviewer.Reportds = dataset;
            reportviewer.Show(this);
            if (!isEdit)
                Utility.Print(patientInfo, rptpath, 2);
        }

        private void PrintMoneyReceipt(string cashMemoId)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlCashMemoInfo = "SELECT CAST(CM.CM_SL AS VARCHAR(10))+'/'+CAST(MONTH(CM.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(CM.CreatedOn) AS VARCHAR(4)) AS CashMemoNo";
            sqlCashMemoInfo += " , CAST(AD.Admission_SL AS VARCHAR(10))+'/'+CAST(MONTH(AD.CreatedOn) AS VARCHAR(2))+'/'+CAST(YEAR(AD.CreatedOn) AS VARCHAR(4)) AS AdmissionSlNo";
            sqlCashMemoInfo += " , AD.CreatedOn,PI.Name,PI.Year,PI.Month,PI.Day,PI.Gender";
            sqlCashMemoInfo += " , CM.Pay_Amount,case when AD.DiscountTk is null then 0 else  AD.DiscountTk end DiscountTk,case when Ad.DiscountPercentage is null then 0 else Ad.DiscountPercentage end DiscountPercentage,AD.DiscountByID,dbo.f_Get_Admission_PayableAmount(AD.Admission_Id) Payable_Amount, case when CM.Return_Amount is null then 0 else CM.Return_Amount end Return_Amount,U.Name UserName";
            sqlCashMemoInfo +=
                " FROM dbo_CashMemo CM INNER JOIN dbo_Admission AD ON CM.Admission_ID=AD.Admission_Id ";
            sqlCashMemoInfo += " INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID	 ";
            sqlCashMemoInfo += " LEFT JOIN dbo_Users U ON U.User_Id=CM.UserId ";
            sqlCashMemoInfo += " WHERE CM.CM_ID=" + cashMemoId;
            var dtCashMemoInfo = objData.RetriveData(sqlCashMemoInfo, ref strErr);
            objData.CloseConnection();
            var rptpath = Utility.ReportPath + "rptMoneyReceipt.rpt";
            Utility.Print(dtCashMemoInfo, rptpath, 2);
        }

        private void txtyyy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtadvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            txtgender.SelectedValue = txtPatientName.Text.ToLower().StartsWith("mrs") || txtPatientName.Text.ToLower().StartsWith("mst") ? "F" : "M";
        }

        private void txtGuardianAddress_TextChanged(object sender, EventArgs e)
        {
            txtpresentaddress.Text = txtpermanetaddress.Text = txtGuardianAddress.Text;
        }

        private void lstBedInfo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtbed.Text = lstBedInfo.CurrentRow.Cells[1].Value.ToString();
            txtBedRate.Text = lstBedInfo.CurrentRow.Cells[3].Value.ToString();
        }

        private void lstdoctorsinformation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SetReferrerDoctorInfo();
                txtdoctorsinformation.Focus();
            }
        }

        private void lstDoctors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SetUnderDoctorInfo();
                txtDoctors.Focus();
            }
        }

        private void lstBedInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SaveAdmissionInfo();
            }
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

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void chkPc_CheckedChanged(object sender, EventArgs e)
        {
            LoadDoctorList(lstdoctorsinformation, "", chkPc.Checked);
        }
    }
}
