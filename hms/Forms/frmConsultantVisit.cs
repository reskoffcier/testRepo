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
using CrystalDecisions.Shared.Json;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmConsultantVisit : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        public frmConsultantVisit()
        {
            InitializeComponent();
            LoadDoctorList(lstdoctorsname);
            btnDelete.Enabled = false;
            LoadVisitType();
            txtVisitNo.Visible = lblvisitby.Visible = false;
        }

        private void LoadVisitType()
        {
            var strSQL = "";
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            strSQL = "select VisitID,VisitType from dbo_VisitType order by VisitType";
            var visitTypes = objData.RetriveData(strSQL, ref strErr);
            if (strErr == "")
            {
                cmbVisitType.DisplayMember = "VisitType";
                cmbVisitType.ValueMember = "VisitID";
                cmbVisitType.DataSource = visitTypes;
                cmbVisitType.SelectedIndex = -1;
            }
            objData.CloseConnection();
        }

        public void LoadPatientInfo(string add_id = "", string p_id = "", string add_sl = "", string searchText = "")
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            if (searchText != "")
            {
                string strSQL = "";
                strSQL =
                    "SELECT AD.Admission_Id,CAST(AD.Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) Admission_SL FROM dbo_Admission AD WHERE CAST(AD.Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) LIKE '%" +
                    searchText + "%'";
                var patientInfo = objData.RetriveData(strSQL, ref strErr);
                if (strErr == "" && patientInfo.Rows.Count > 0)
                {
                    add_id = patientInfo.Rows[0][0].ToString();
                    add_sl = patientInfo.Rows[0][1].ToString();

                }
                else
                {
                    MessageBox.Show("Incorrect addmission id.");
                }
                objData.CloseConnection();
            }
            lblAddmissionId.Text = add_id;
            txtAdmissionID.Text = add_sl;
            if (!string.IsNullOrEmpty(add_id))
            {
                LoadList(add_id);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            new frmAdmitedPatientList() { Owner = this }.ShowDialog();
        }

        private void LoadDoctorList(ListBox list, string searchText = "")
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);

            string strSQL = "";
            strSQL = "select DocID, Name from dbo_Doctor_List WHERE Name LIKE '%" + searchText + "%' order by Name";
            var doctorList = objData.RetriveData(strSQL, ref strErr);
            if (strErr == "")
            {
                list.DataSource = doctorList;
                list.DisplayMember = "Name";
                list.ValueMember = "DocID";
                list.SelectedIndex = -1;
                txttitle.Text = txtdoctorname.Text = txtdegree.Text = txtspecialist.Text = txtAddress.Text = txtDocType.Text = txtArea.Text = "";
            }
            objData.CloseConnection();
        }

        private void txtdoctorsname_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDoctorList(lstdoctorsname, txtdoctorsname.Text);
            if (e.KeyCode == Keys.Down)
            {
                if (lstdoctorsname.Items.Count > 0)
                {
                    lstdoctorsname.SelectedIndex = 0;
                    lstdoctorsname.Focus();
                }
            }
        }
        private void FillDoctorDetails(string docid)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSQL = "";
            strSQL = "select Title, Name, Degree, Specialist, Address, Doctype, Area from dbo_Doctor_List WHERE DocId=" + docid;
            var doctorList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            if (strErr == "" && doctorList.Rows.Count > 0)
            {
                txttitle.Text = doctorList.Rows[0][0].ToString();
                txtdoctorname.Text = doctorList.Rows[0][1].ToString();
                txtdegree.Text = doctorList.Rows[0][2].ToString();
                txtspecialist.Text = doctorList.Rows[0][3].ToString();
                txtAddress.Text = doctorList.Rows[0][4].ToString();
                txtDocType.Text = doctorList.Rows[0][5].ToString();
                txtArea.Text = doctorList.Rows[0][6].ToString();
            }
        }
        private void lstdoctorsname_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstdoctorsname.IndexFromPoint(e.X, e.Y) > -1)
            {
                lstdoctorsname.SelectedIndex = lstdoctorsname.IndexFromPoint(e.X, e.Y);
                FillDoctorDetails(lstdoctorsname.SelectedValue.ToString());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var docId = lstdoctorsname.SelectedValue;
            if (docId == null)
            {
                MessageBox.Show("Please select a doctor.");
                lstdoctorsname.Focus();
                return;
            }
            var addmissionId = lblAddmissionId.Text;
            if (addmissionId == "")
            {
                MessageBox.Show("Please enter addmission id.");
                txtAdmissionID.Focus();
                return;
            }
            var visitType = 0;
            int.TryParse(cmbVisitType.SelectedValue.ToString(), out visitType);
            var visitNo = 0;
            int.TryParse(txtVisitNo.Text, out visitNo);
            visitNo = visitNo == 0 ? 1 : visitNo;
            var amount = txtvisitamount.Text;
            var procedure = txtproccedure.Text;
            var medicine = txtmedicine.Text;
            var comment = txtcomments.Text;
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSql = "INSERT INTO dbo_Admission_Consultant_Visit_Charge(Doc_ID,Admission_ID,VisitId,Amount,Doc_Procedure,Doc_Medicin,Comment,UserId,UserPC,VisitNo) VALUES(" + docId + "," + addmissionId + "," + visitType + "," + amount + ",'" + procedure + "','" + medicine + "','" + comment + "'," + Utility.userID + ",'" + Utility.PcName + "'," + visitNo + ")";
            objData.ExecuteQuery(strSql, ref strErr);
            objData.CloseConnection();
            MessageBox.Show(strErr == "" ? "Successfully saved." : "Data not saved.\nPlease try again later.");
            //ClearAllFields();
            LoadList(addmissionId);
        }

        private void ClearAllFields()
        {
            Utility.ClearAllControls(this);
            lstdoctorsname.SelectedIndex = -1;
            lstConsultantInfo.Items.Clear();
            lblAddmissionId.Text = "";
            cmbVisitType.SelectedIndex = -1;
        }

        private void txtAdmissionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadPatientInfo(searchText: txtAdmissionID.Text);
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadList(string addmissionid)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSQL = "";
            strSQL = "SELECT AC.VisitOn,DL.Name,VT.VisitType,(AC.VisitNo*AC.Amount) Amount,AC.Comment,AC.Doc_Procedure,AC.Doc_Medicin,AC.ID FROM dbo_Admission_Consultant_Visit_Charge AC INNER JOIN dbo_Doctor_List DL ON DL.DocID=AC.Doc_ID INNER JOIN dbo_VisitType VT ON VT.VisitID=AC.VisitID WHERE AC.Admission_ID=" + addmissionid;
            var list = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            btnDelete.Enabled = false;
            lstConsultantInfo.Items.Clear();
            if (strErr == "" && list.Rows.Count > 0)
            {
                for (var i = 0; i < list.Rows.Count; i++)
                {
                    var listviewitem = new ListViewItem((i + 1).ToString());
                    listviewitem.SubItems.Add(DateTime.Parse(list.Rows[i][0].ToString()).ToShortDateString());
                    for (var j = 1; j < list.Columns.Count; j++)
                    {
                        listviewitem.SubItems.Add(list.Rows[i][j].ToString());
                    }
                    lstConsultantInfo.Items.Add(listviewitem);
                }
                Utility.AutoResizeColumns(lstConsultantInfo);
                lstConsultantInfo.Columns[lstConsultantInfo.Columns.Count - 1].Width = 0;
            }
        }

        private void lstConsultantInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstConsultantInfo.Items.Count > 0)
            {
                btnDelete.Enabled = lstConsultantInfo.SelectedItems.Count > 0;
            }
        }

        private void lstConsultantInfo_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstConsultantInfo.Columns[e.ColumnIndex].Width;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSql = "DELETE FROM dbo_Admission_Consultant_Visit_Charge WHERE ID=" + lstConsultantInfo.SelectedItems[0].SubItems[8].Text;
            objData.ExecuteQuery(strSql, ref strErr);
            objData.CloseConnection();
            MessageBox.Show("Delete successfull.");
            LoadList(lblAddmissionId.Text);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearAllFields();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbVisitType_TextChanged(object sender, EventArgs e)
        {
            cmbVisitType.DroppedDown = false;
        }

        private void cmbVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVisitNo.Text = "";
            if (cmbVisitType.SelectedIndex > -1)
            {
                txtVisitNo.Visible = lblvisitby.Visible = Convert.ToInt32(cmbVisitType.SelectedValue) == 1;
            }
        }

        private void txtVisitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lstdoctorsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (lstdoctorsname.Items.Count > 0)
                {
                    if (lstdoctorsname.SelectedIndex > -1)
                    {
                        FillDoctorDetails(lstdoctorsname.SelectedValue.ToString());
                        txtdoctorsname.Focus();
                    }

                }
            }
        }

    }
}

