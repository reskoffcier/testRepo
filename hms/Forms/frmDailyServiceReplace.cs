using System;
using System.Collections;
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
    public partial class frmDailyServiceReplace : Form
    {
        private C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        private int INV_ADM_ID = 0;
        private int PREV_DOC_ID = 0;
        public frmDailyServiceReplace()
        {
            InitializeComponent();
            rbtnInvestigation.Checked = true;
            rbtnAdmissionRefTo.Checked = rbtnAdmissionReffBy.Checked = false;
            lblInvIdandAdvID.Text = @"Investigation Id";
        }
        private void TextBox_OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            strErr = "";
            INV_ADM_ID = PREV_DOC_ID = 0;
            if (!rbtnInvestigation.Checked && !rbtnAdmissionRefTo.Checked && !rbtnAdmissionReffBy.Checked)
            {
                MessageBox.Show(@"Please select a doctor type.");
                return;
            }
            if (txtInvAdvID.Text.Replace("/", "").Trim() == "")
            {
                MessageBox.Show(@"Please enter " + (rbtnInvestigation.Checked ? "Investigation" : "Admission") + @"Id");
                return;
            }
            if (string.IsNullOrEmpty(txtdocid.Text.Trim()))
            {
                MessageBox.Show(@"Please enter replace doctor id.", @"Error", MessageBoxButtons.OK);
                return;
            }
            var id = txtInvAdvID.Text.Trim();
            var sl = 0;
            var month = 0;
            var year = 0;
            if (id.Split('/').Length == 3)
            {
                int.TryParse(id.Split('/')[0], out sl);
                int.TryParse(id.Split('/')[1], out month);
                int.TryParse(id.Split('/')[2], out year);
            }
            if (!(sl >= 1000 && month > 0 && year >= 1000))
            {
                MessageBox.Show(@"Invalid " + (rbtnInvestigation.Checked ? "Investigation" : "Admission") + @"Id");
                return;
            }
            var sql = "SELECT '(Id: '+CAST(DL.DocID AS VARCHAR)+') '+CASE WHEN DL.Title IS NOT NULL AND DL.Title<>'' THEN DL.Title+' ' ELSE '' END";
            sql += " +DL.Name";
            sql += " +CASE WHEN DL.Degree IS NOT NULL AND DL.Degree<>'' THEN CHAR(13)+DL.Degree ELSE '' END";
            sql +=
                " +CASE WHEN DL.Specialist IS NOT NULL AND DL.Specialist<>'' THEN CHAR(13)+DL.Specialist ELSE '' END";
            sql += " +CASE WHEN DL.Area IS NOT NULL AND DL.Area<>'' THEN CHAR(13)+DL.Area ELSE '' END";
            sql += " , (SELECT '(Id: '+CAST(D.DocID AS VARCHAR)+') '+CASE WHEN D.Title IS NOT NULL AND D.Title<>'' THEN D.Title+' ' ELSE '' END";
            sql += " +D.Name";
            sql += " +CASE WHEN D.Degree IS NOT NULL AND D.Degree<>'' THEN CHAR(13)+D.Degree ELSE '' END";
            sql +=
                " +CASE WHEN D.Specialist IS NOT NULL AND D.Specialist<>'' THEN CHAR(13)+D.Specialist ELSE '' END";
            sql += " +CASE WHEN D.Area IS NOT NULL AND D.Area<>'' THEN CHAR(13)+D.Area ELSE '' END";
            sql += " FROM dbo_Doctor_List D WHERE D.DocId=" + txtdocid.Text.Trim() + "),DL.DocId";
            if (rbtnInvestigation.Checked)
            {
                sql += " ,I.InvestigationID";
                sql += " FROM dbo_Investigation I INNER JOIN dbo_Doctor_List DL ON DL.DocID=I.DocID INNER JOIN dbo_Patient_info PI ON PI.P_ID=I.P_ID";
                sql += " WHERE I.Invetigation_SL=" + sl + " AND MONTH(I.CreatedON)=" + month + " AND YEAR(I.CreatedON)=" + year;
            }
            else
            {
                sql += " ,AD.Admission_Id";
                if (rbtnAdmissionRefTo.Checked)
                {
                    sql += " FROM dbo_Admission AD INNER JOIN dbo_Doctor_List DL ON DL.DocID=AD.Under_Doc_ID INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID";
                }
                else if (rbtnAdmissionReffBy.Checked)
                {
                    sql += " FROM dbo_Admission AD INNER JOIN dbo_Doctor_List DL ON DL.DocID=AD.Reference_Doc_ID INNER JOIN dbo_Patient_info PI ON PI.P_ID=AD.P_ID";
                }
                sql += " WHERE AD.Admission_SL=" + sl + " AND MONTH(AD.CreatedON)=" + month + " AND YEAR(AD.CreatedON)=" + year;
            }
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var dtDocInfo = objData.RetriveData(sql, ref strErr);
            if (strErr == "")
            {
                if (dtDocInfo.Rows.Count > 0)
                {
                    txtIDDetails.Text = dtDocInfo.Rows[0][0].ToString();
                    txtDocDetails.Text = dtDocInfo.Rows[0][1].ToString();
                    int.TryParse(dtDocInfo.Rows[0][2].ToString(), out PREV_DOC_ID);
                    int.TryParse(dtDocInfo.Rows[0][3].ToString(), out INV_ADM_ID);
                    sql = "USP_Get_Admission_Investigation_Services_Details " + INV_ADM_ID + "," + (rbtnInvestigation.Checked ? 2 : 1);
                    var dtServiceInfo = objData.RetriveData(sql, ref strErr);
                    if (strErr == "")
                    {
                        if (dtServiceInfo.Rows.Count > 0)
                        {
                            grdServiceInfo.DataSource = dtServiceInfo;
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error occurred.\n\nTry again later.", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(@"No doctor found for this " + (rbtnInvestigation.Checked ? "Investigation." : "Admission."));
                }
            }
            else
            {
                MessageBox.Show("An error occurred.\n\nTry again later.");
            }
            objData.CloseConnection();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lblInvIdandAdvID.Text = rbtnInvestigation.Checked ? "Investigation Id" : "Admission Id";
            PREV_DOC_ID = INV_ADM_ID = 0;
            txtInvAdvID.ResetText();
            txtdocid.ResetText();
            txtRemark.ResetText();
            txtIDDetails.ResetText();
            txtDocDetails.ResetText();
            grdServiceInfo.DataSource = null;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (!rbtnInvestigation.Checked && !rbtnAdmissionRefTo.Checked && !rbtnAdmissionReffBy.Checked)
            {
                MessageBox.Show(@"Please select a doctor type.");
                return;
            }
            if (txtInvAdvID.Text.Replace("/", "").Trim() == "")
            {
                MessageBox.Show(@"Please enter " + (rbtnInvestigation.Checked ? "Investigation" : "Admission") + @"Id");
                return;
            }
            if (string.IsNullOrEmpty(txtdocid.Text.Trim()))
            {
                MessageBox.Show(@"Please enter replace doctor id.", @"Error", MessageBoxButtons.OK);
                return;
            }
            strErr = "";
            var docId = int.Parse(txtdocid.Text);
            if (docId == PREV_DOC_ID)
            {
                MessageBox.Show(@"Existing doctor id and replace doctor id is same.", @"Information", MessageBoxButtons.OK);
                return;
            }
            var sql = "";
            if (rbtnInvestigation.Checked)
            {
                sql = "UPDATE dbo_Investigation SET DocID=" + docId + ",UpdatedOn=GETDATE() WHERE InvestigationID=" + INV_ADM_ID + ";";
                sql += " UPDATE Investigation_SpootCommission SET Doc_ID=" + docId + ",Update_On=GETDATE() WHERE InvestigationID=" + INV_ADM_ID + ";";
                sql +=
                    " INSERT INTO InvestigationTransfer_Log(InvestigationID,Previus_Doctors_ID,Transfer_Doctors_ID,Transfer_ON,UserID,UserPC,Is_Admission_Ref_Changed,Remarks)";
                sql += " VALUES(" + INV_ADM_ID + "," + PREV_DOC_ID + "," + docId + ",GETDATE()," + Utility.userID + ",'" + Utility.PcName + "',0,'" + txtRemark.Text + "') ";
            }
            else if (rbtnAdmissionReffBy.Checked)
            {
                sql = "UPDATE dbo_Admission SET Reference_Doc_ID=" + docId + ",UpdatedOn=GETDATE() WHERE Admission_Id=" + INV_ADM_ID + ";"; sql +=
                sql += " INSERT INTO dbo_Admission_Doctor_Transfer_Log(Admission_Id,Previus_Doctors_ID,Transfer_Doctors_ID,Transfer_ON,UserID,UserPC,Doctor_Type,Remarks)";
                sql += " VALUES(" + INV_ADM_ID + "," + PREV_DOC_ID + "," + docId + ",GETDATE()," + Utility.userID + ",'" + Utility.PcName + "',2,'" + txtRemark.Text + "'); ";
                sql += " UPDATE dbo_Admission_Doctor_Commission SET DocId=" + docId + " WHERE Admission_Id=" + INV_ADM_ID + ";";
                sql += " UPDATE dbo_Investigation SET DocID=" + docId + " WHERE InvestigationID=" + INV_ADM_ID + ";";
                sql += " UPDATE Investigation_SpootCommission SET Doc_ID=" + docId + " WHERE InvestigationID=" + INV_ADM_ID + ";";
                sql +=
                    " INSERT INTO InvestigationTransfer_Log(InvestigationID,Previus_Doctors_ID,Transfer_Doctors_ID,Transfer_ON,UserID,UserPC,Is_Admission_Ref_Changed,Remarks)";
                sql += " VALUES(" + INV_ADM_ID + "," + PREV_DOC_ID + "," + docId + ",GETDATE()," + Utility.userID + ",'" + Utility.PcName + "',1,'" + txtRemark.Text + "') ";
            }
            else if (rbtnAdmissionRefTo.Checked)
            {
                sql = "UPDATE dbo_Admission SET Under_Doc_ID=" + docId + ",UpdatedOn=GETDATE() WHERE Admission_Id=" + INV_ADM_ID + ";";
                sql += " INSERT INTO dbo_Admission_Doctor_Transfer_Log(Admission_Id,Previus_Doctors_ID,Transfer_Doctors_ID,Transfer_ON,UserID,UserPC,Doctor_Type,Remarks)";
                sql += " VALUES(" + INV_ADM_ID + "," + PREV_DOC_ID + "," + docId + ",GETDATE()," + Utility.userID + ",'" + Utility.PcName + "',1,'" + txtRemark.Text + "'); ";
            }
            if (sql != "")
            {
                objData.OpenConnection("AatickPC-Office", ref strErr);
                objData.ExecuteQuery(sql, ref strErr);
                objData.CloseConnection();
                if (strErr == "")
                {
                    MessageBox.Show(@"Doctor Replacement successful.", @"Success", MessageBoxButtons.OK);
                    PREV_DOC_ID = docId;
                }
                else
                {
                    MessageBox.Show("An error. occurred.\n\nTry again later.", @"Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnshowDuplicate_Click(object sender, EventArgs e)
        {
            if (txtsuspectedDocId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter suspected doctor id.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtReplaceDocId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter replace doctor id.", "Error", MessageBoxButtons.OK);
                return;
            }
            var sql = "SELECT D.DocId,'(Id: '+CAST(D.DocID AS VARCHAR)+') '+CASE WHEN D.Title IS NOT NULL AND D.Title<>'' THEN D.Title+' ' ELSE '' END +D.Name +CASE WHEN D.Degree IS NOT NULL AND D.Degree<>'' THEN CHAR(13)+D.Degree ELSE '' END +CASE WHEN D.Specialist IS NOT NULL AND D.Specialist<>'' THEN CHAR(13)+D.Specialist ELSE '' END +CASE WHEN D.Area IS NOT NULL AND D.Area<>'' THEN CHAR(13)+D.Area ELSE '' END FROM dbo_Doctor_List D WHERE D.DocId IN(" + txtsuspectedDocId.Text.Trim() + "," + txtReplaceDocId.Text.Trim() + ")";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var dtDocInfo = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            if (strErr != "")
            {
                MessageBox.Show("An error occurred.\n\nTry again later.", @"Error", MessageBoxButtons.OK);
                return;
            }
            if (dtDocInfo.Rows.Count < 2)
            {
                MessageBox.Show(@"Invalid suspected or replace doctor id.", @"Error", MessageBoxButtons.OK);
                return;
            }
            txtsuspectedDocInfo.Text = dtDocInfo.Rows[0][0].ToString() == txtsuspectedDocId.Text.Trim() ? dtDocInfo.Rows[0][1].ToString() : dtDocInfo.Rows[1][1].ToString();
            txtReplaceDocInfo.Text = dtDocInfo.Rows[0][0].ToString() == txtsuspectedDocId.Text.Trim() ? dtDocInfo.Rows[1][1].ToString() : dtDocInfo.Rows[0][1].ToString();
        }

        private void btnProcessDuplicate_Click(object sender, EventArgs e)
        {
            strErr = "";
            if (txtsuspectedDocId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter suspected doctor id.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtReplaceDocId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter replace doctor id.", "Error", MessageBoxButtons.OK);
                return;
            }
            var sql = "USP_Duplicate_Doctor_Transfer " + txtsuspectedDocId.Text.Trim() + "," + txtReplaceDocId.Text.Trim();
            objData.OpenConnection("AatickPC-Office", ref strErr);
            objData.ExecuteQuery(sql, ref strErr);
            objData.CloseConnection();
            if (strErr=="")
            {
                MessageBox.Show(@"Duplicate doctor replacement successful.", @"Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("An error occurred.\n\nTry again later.", @"Error", MessageBoxButtons.OK);
            }
        }
    }
}
