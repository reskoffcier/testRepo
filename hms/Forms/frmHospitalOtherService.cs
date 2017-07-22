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
using Microsoft.VisualBasic;

namespace hms.Forms
{
    public partial class frmHospitalOtherService : Form
    {
        C_Data_Batch objdata = new C_Data_Batch();
        public string strErr = "";
        private int admissionId = 0;
        public frmHospitalOtherService()
        {
            InitializeComponent();
            GetOtherServices();
            txtDate.Value = DateTime.Today;
            txtsl.Visible = txtDate.Visible = txtremark.Visible = lblRemark.Visible = lbldate.Visible = false;
            txtfixed.DataSource = new List<object>
            {
                new {Text = "Yes", Value = 1},
                new {Text = "No", Value = 0}
            };
            txtfixed.DisplayMember = "Text";
            txtfixed.ValueMember = "Value";
            txtDate.MaxDate = DateTime.Today;
        }

        private void GetOtherServices(string searchText = "")
        {
            objdata.OpenConnection("AatickPC-Home", ref strErr);
            var strSql = "select OSL_ID, Name from Dbo_Other_Service_List Where Name like '%" + searchText + "%' order by Name";
            var otherServiceList = objdata.RetriveData(strSql, ref strErr);
            objdata.CloseConnection();
            lstserviceinfo.DisplayMember = "Name";
            lstserviceinfo.ValueMember = "OSL_ID";
            lstserviceinfo.DataSource = otherServiceList;
            lstserviceinfo.SelectedIndex = -1;
            var textBox = new ArrayList { txtadmissionid.Name, txtServiceInfo.Name };
            Utility.ClearAllControls(this, textBox);
            btnGridDelete.Enabled = false;
        }

        private void EnableDisableTextFields(bool flag)
        {
            txthead.Enabled = txtRmayCha.Enabled = txtdatafor.Enabled = txtfixed.Enabled = flag;
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            new frmAdmitedPatientList() { Owner = this }.ShowDialog();
        }

        public void LoadAdmissionInfo(string addmissionSl, string admission_Id)
        {
            Utility.ClearAllControls(this);
            txtadmissionid.Text = addmissionSl;
            int.TryParse(admission_Id, out this.admissionId);
            LoadGrid(admission_Id);
            lstserviceinfo.SelectedIndex = -1;
            txtServiceInfo.Text = "";
            //txtServiceInfo.Enabled = false;
            EnableDisableTextFields(false);
            txtsl.Visible = txtDate.Visible = txtremark.Visible = lblRemark.Visible = lbldate.Visible = true;
        }

        private void txtServiceInfo_KeyUp(object sender, KeyEventArgs e)
        {
            GetOtherServices(txtServiceInfo.Text);
            if (e.KeyCode == Keys.Down)
            {
                if (lstserviceinfo.Items.Count > 0)
                {
                    lstserviceinfo.SelectedIndex = 0;
                    lstserviceinfo.Focus();
                }
            }
        }

        private void lstserviceinfo_Click(object sender, EventArgs e)
        {
            SetServiceInfo();
        }

        private void SetServiceInfo()
        {
            if (lstserviceinfo.SelectedIndex > -1)
            {
                LoadServiceInfo(lstserviceinfo.SelectedValue.ToString());
                txtsl.Text = txtremark.Text = "";
                txtDate.Value = DateTime.Today;
                EnableDisableTextFields(admissionId == 0);
            }
        }

        private void LoadServiceInfo(string oslId, bool isEdit = false)
        {
            objdata.OpenConnection("AatickPC-Home", ref strErr);
            var sql =
                "SELECT OSL.Amount,OSL.Head,OSL.RMay_cha,OSL.Fiexed,OSL.Data_For";
            sql += " FROM Dbo_Other_Service_List OSL ";
            sql += " WHERE OSL.OSL_ID=" + oslId;
            var serviceInfo = objdata.RetriveData(sql, ref strErr);
            objdata.CloseConnection();
            if (strErr == "" && serviceInfo.Rows.Count > 0)
            {
                txtamount.Text = serviceInfo.Rows[0][0].ToString();
                txthead.Text = serviceInfo.Rows[0][1].ToString();
                txtRmayCha.Text = serviceInfo.Rows[0][2].ToString();
                txtfixed.SelectedValue = Convert.ToBoolean(Convert.ToInt32(serviceInfo.Rows[0][3].ToString())) ? 1 : 0;
                txtdatafor.Text = serviceInfo.Rows[0][4].ToString();
                txtamount.Enabled = true;
                if (Convert.ToBoolean(Convert.ToInt32(serviceInfo.Rows[0][3].ToString())))
                {
                    txtamount.Enabled = false;
                }
            }
            EnableDisableTextFields(false);
        }

        private void LoadGrid(string addId)
        {
            objdata.OpenConnection("AatickPC-Home", ref strErr);
            var sql = "SELECT PST.ServiceTakenDate Date,OSL.Name,(PST.Quentity*PST.Amount) Amount,PST.Remarks,PST.PST_ID ";
            sql += " FROM Dbo_Other_Service_List OSL ";
            sql += " INNER JOIN PatientServiceTaken PST ON PST.OSL_ID=OSL.OSL_ID";
            sql += " WHERE PST.Admission_ID=" + addId;
            var serviceInfo = objdata.RetriveData(sql, ref strErr);
            objdata.CloseConnection();
            dgvOtherservice.DataSource = serviceInfo;
            dgvOtherservice.ClearSelection();
            if (serviceInfo.Rows.Count > 0)
                dgvOtherservice.Columns[4].Visible = false;
        }

        private void dgvOtherservice_Click(object sender, EventArgs e)
        {
            if (dgvOtherservice.CurrentRow != null)
            {
                btnGridDelete.Enabled = true;
                dgvOtherservice.CurrentRow.Selected = true;
            }
            else
            {
                btnGridDelete.Enabled = false;
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var serviceId = lstserviceinfo.SelectedItems.Count == 0 ? 0 : int.Parse(lstserviceinfo.SelectedValue.ToString());
            var serviceName = serviceId == 0 ? txtServiceInfo.Text : "";

            if (string.IsNullOrEmpty(serviceName.Trim()) && serviceId == 0 && admissionId == 0)
            {
                MessageBox.Show("Please enter service name.");
                txtServiceInfo.Focus();
                return;
            }
            if (admissionId > 0 && serviceId == 0)
            {
                MessageBox.Show("Please select a service from list.");
                lstserviceinfo.Focus();
                return;
            }
            var amount = 0;
            int.TryParse(txtamount.Text, out amount);
            var quantity = 0;
            int.TryParse(txtsl.Text, out quantity);
            var head = txthead.Text;
            var rmayCha = txtRmayCha.Text;
            var intFixed = 0;
            int.TryParse(txtfixed.SelectedValue.ToString(), out intFixed);
            var dataFor = txtdatafor.Text;
            var remarks = txtremark.Text;
            var serviceTakenDate = txtDate.Value.ToShortDateString();
            var sql = "";
            var msg = "";
            if (serviceId == 0 && admissionId == 0)
            {
                sql = "INSERT INTO Dbo_Other_Service_List(Name,Amount,Head,RMay_cha,Fiexed,Data_For) VALUES('" + serviceName + "'," + amount + ",'" + head + "','" + rmayCha + "'," + intFixed + ",'" + dataFor + "')";
                msg = "Service has been saved successfully.";
            }
            else if (serviceId > 0 && admissionId == 0)
            {
                sql = "UPDATE Dbo_Other_Service_List SET Amount=" + amount + ",Head='" + head + "',RMay_cha='" + rmayCha + "',Fiexed=" + intFixed + ",Data_For='" + dataFor + "',UpdatedOn=getdate() WHERE OSL_ID=" + serviceId;
                msg = "Service has been updated successfully.";
            }
            else if (admissionId > 0 && serviceId > 0)
            {
                if (quantity == 0)
                {
                    MessageBox.Show(@"Please enter quantity of service.");
                    txtsl.Focus();
                    return;
                }
                quantity = quantity == 0 ? 1 : quantity;
                sql = "INSERT INTO PatientServiceTaken(Admission_ID,Quentity,OSL_ID,Remarks,Amount,ServiceTakenDate,UserPC, UserID) VALUES(" +
                      admissionId + "," + quantity + "," + serviceId + ",'" + remarks + "'," + amount + ",'" + serviceTakenDate + "','"+Utility.PcName+"', "+Utility.userID+")";
                msg = "Service has been taken successfully.";
            }
            if (sql != "")
            {
                objdata.OpenConnection("AatickPC-Home", ref strErr);
                objdata.ExecuteQuery(sql, ref strErr);
                objdata.CloseConnection();
                MessageBox.Show(strErr == "" ? msg : "Data not saved.\nPlease try again later.");
                if (strErr == "" && serviceId == 0 && admissionId == 0)
                {
                    GetOtherServices();
                }
                else if (strErr == "" && admissionId > 0 && serviceId > 0)
                {
                    LoadGrid(admissionId.ToString());
                }
            }
        }
        private void KeyPress_OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            admissionId = 0;
            Utility.ClearAllControls(this);
            EnableDisableTextFields(true);
            txtServiceInfo.Enabled = true;
            lstserviceinfo.SelectedIndex = -1;
            txtfixed.SelectedIndex = 0;
            dgvOtherservice.DataSource = null;
            txtDate.Value = DateTime.Today;
            txtsl.Visible = txtDate.Visible = txtremark.Visible = lblRemark.Visible = lbldate.Visible = false;
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

        private void btnGridDelete_Click(object sender, EventArgs e)
        {
            if (dgvOtherservice.CurrentRow != null)
            {
                if (MessageBox.Show(@"Do you sure to remove this service?", @"Confirm", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    var sql = "DELETE FROM PatientServiceTaken WHERE PST_ID=" +
                              dgvOtherservice.CurrentRow.Cells[4].Value;
                    objdata.OpenConnection("AatickPC-Home", ref strErr);
                    objdata.ExecuteQuery(sql, ref strErr);
                    objdata.CloseConnection();
                    dgvOtherservice.Rows.Remove(dgvOtherservice.CurrentRow);
                    MessageBox.Show(@"Service has been removed from this admission.");
                }
            }
            else
            {
                MessageBox.Show(@"Please select a row to delete from grid.");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstserviceinfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                SetServiceInfo();
            }
        }
    }
}
