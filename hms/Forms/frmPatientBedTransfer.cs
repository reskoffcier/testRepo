using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmPatientBedTransfer : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmPatientBedTransfer()
        {
            InitializeComponent();
            LoadBedInfo();
            btnsave.Enabled = false;
            //MessageBox.Show(DateTime.Now.ToString());
        }

        private void LoadBedInfo(string searchText = "")
        {
            lstBedInfo.Items.Clear();
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlBedInfo = "SELECT BI.BI_Number Serial,BI.Name Bed,BI.Rate Rent	,'P. Status: '+CASE WHEN (SELECT COUNT(1) FROM Patient_Bed WHERE BI_ID=BI.BI_ID AND isBooked=1)>0 THEN 'Patient Admitted' ELSE 'Free' END Note,CASE WHEN (SELECT COUNT(1) FROM Patient_Bed WHERE BI_ID=BI.BI_ID AND isBooked=1)>0 THEN 1 ELSE 0 END Booked,BI.BI_ID FROM Bed_Information BI" + (searchText == "" ? "" : " WHERE BI.Name LIKE '%" + searchText + "%'");
            var dtBedInfo = objData.RetriveData(sqlBedInfo, ref strErr);
            objData.CloseConnection();
            for (var i = 0; i < dtBedInfo.Rows.Count; i++)
            {
                var listitem = new ListViewItem(dtBedInfo.Rows[i][0].ToString());
                listitem.SubItems.Add(dtBedInfo.Rows[i][1].ToString());
                listitem.SubItems.Add(dtBedInfo.Rows[i][2].ToString());
                listitem.SubItems.Add(dtBedInfo.Rows[i][3].ToString());
                listitem.ForeColor = dtBedInfo.Rows[i][4].ToString() == "1" ? Color.Red : Color.Blue;
                listitem.Tag = dtBedInfo.Rows[i][4] + "#" + dtBedInfo.Rows[i][5];
                lstBedInfo.Items.Add(listitem);
            }
            Utility.AutoResizeColumns(lstBedInfo);
        }

        private void btnpatientlist_Click(object sender, EventArgs e)
        {
            new frmAdmitedPatientList() { Owner = this }.ShowDialog();
        }

        public void LoadAdmissionInfo(string sl, string id)
        {
            txtadmissionid.Text = sl;
            txtadmissionid.Tag = id;
            FillGridView(id);
            btnsave.Enabled = true;
        }

        private void FillGridView(string admissionId)
        {
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlBedInfo = "SELECT convert(varchar,PB.Booked_On,101) AS 'Date'";
            sqlBedInfo += " ,CASE WHEN PB.Transfer_From IS NOT NULL THEN (SELECT Name FROM Bed_Information WHERE BI_ID=PB.Transfer_From) ELSE '' END AS 'Previous Bed'";
            sqlBedInfo += " ,BI.Name AS 'To Bed',BI.BI_ID";
            sqlBedInfo += " FROM Patient_Bed PB INNER JOIN Bed_Information BI ON BI.BI_ID=PB.BI_ID";
            sqlBedInfo += " WHERE PB.Admission_id=" + admissionId + " ORDER BY convert(varchar,PB.Booked_On,101)";
            var dtBedInfo = objData.RetriveData(sqlBedInfo, ref strErr);
            objData.CloseConnection();
            dgbpreviousbedinfo.DataSource = dtBedInfo;
            if (dtBedInfo.Rows.Count > 0)
                dgbpreviousbedinfo.Tag = dtBedInfo.Rows[dtBedInfo.Rows.Count - 1][3].ToString();
            dgbpreviousbedinfo.Columns[3].Visible = false;
        }

        private void lstBedInfo_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstBedInfo.Columns[e.ColumnIndex].Width;
        }

        private void txtbed_KeyUp(object sender, KeyEventArgs e)
        {
            LoadBedInfo(txtbed.Text);
        }

        private void lstBedInfo_Click(object sender, EventArgs e)
        {
            if (lstBedInfo.SelectedItems.Count > 0)
            {
                txtbed.Text = lstBedInfo.SelectedItems[0].SubItems[1].Text;
                txtBedRate.Text = lstBedInfo.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (lstBedInfo.SelectedItems.Count > 0)
            {
                var arrData = lstBedInfo.SelectedItems[0].Tag.ToString().Split('#');
                if (arrData[0] == "1")
                {
                    MessageBox.Show("This bed is not free now.");
                }
                else
                {
                    objData.OpenConnection("AatickPC-Office", ref strErr);
                    var date = "";
                    var time = DateTime.Now;
                    if (time < DateTime.Parse(DateTime.Today.ToShortDateString() + " 11:00:00 AM") || time > DateTime.Parse(DateTime.Today.ToShortDateString() + " 01:00:00 PM"))
                    {
                        var sqlText = "SELECT Rate FROM Bed_Information WHERE BI_ID=" + dgbpreviousbedinfo.Tag;
                        var prev = double.Parse(objData.RetriveData(sqlText, ref strErr).Rows[0][0].ToString());
                        sqlText = "SELECT Rate FROM Bed_Information WHERE BI_ID=" + arrData[1];
                        var current = double.Parse(objData.RetriveData(sqlText, ref strErr).Rows[0][0].ToString());
                        if (time.ToString("tt", CultureInfo.InvariantCulture) == "AM")
                        {
                            date = (prev >= current)
                                ? (DateTime.Today.ToShortDateString() + " 12:00 PM")
                                : (DateTime.Today.AddDays(-1).ToShortDateString() + " 12:00 PM");
                        }
                        else
                        {
                            date = (prev >= current)
                                ? (DateTime.Today.AddDays(1).ToShortDateString() + " 12:00 PM")
                                : (DateTime.Today.ToShortDateString() + " 12:00 PM");
                        }
                    }
                    var sql = "UPDATE Patient_Bed SET isBooked=0,release_on='" + date + "' WHERE BI_ID=" +
                              dgbpreviousbedinfo.Tag + " AND Admission_id=" + txtadmissionid.Tag +
                              ";INSERT INTO Patient_Bed(BI_ID,Admission_id,Booked_On,isBooked,isTransfer,Transfer_From,Transfer_On,Note,TransferUserID,TransferUserPC) VALUES(" +
                              arrData[1] + "," + txtadmissionid.Tag + ",'" + date + "',1,1," + dgbpreviousbedinfo.Tag +
                              ",'" + date + "','" + txtremarks.Text + "'," + Utility.userID + ",'" + Utility.PcName +
                              "')";
                    objData.ExecuteQuery(sql, ref strErr);
                    objData.CloseConnection();
                    if (strErr == "")
                    {
                        MessageBox.Show("Bed has been successfully transfered.");
                        LoadBedInfo();
                        FillGridView(txtadmissionid.Tag.ToString());
                    }
                    else
                    {
                        MessageBox.Show("An error occurred.\n\nTry again later.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select any free bed.");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtadmissionid.Text = txtremarks.Text = txtbed.Text = txtBedRate.Text = "";
            btnsave.Enabled = false;
            dgbpreviousbedinfo.DataSource = null;
            LoadBedInfo();
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
    }
}
