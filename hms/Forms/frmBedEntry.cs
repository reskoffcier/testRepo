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
    public partial class frmBedEntry : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        public frmBedEntry()
        {
            InitializeComponent();
            LoadList();
            btnedit.Enabled = false;
        }

        private void LoadList()
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var strSql = "SELECT BI_ID,Name,BI_Number BedNumber,Rate FROM Bed_Information ORDER BY Name";
            var bedList = objData.RetriveData(strSql, ref strErr);

            lstBedInfo.DataSource = bedList;
            objData.CloseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var bedName = txtName.Text;
            var bedNumber = txtBINumber.Text;
            var rate = txtRate.Text;

            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);

            var insertBedInfo = "INSERT INTO Bed_Information(Name,BI_Number,Rate) VALUES('" + bedName + "','" + bedNumber + "'," + rate + ");";
            objData.ExecuteQuery(insertBedInfo, ref strErr);
            MessageBox.Show(strErr != "" ? strErr : @"Bed Information inserted successfully.");
            objData.CloseConnection();
            LoadList();
        }

        private void lstBedInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = lstBedInfo.Rows[e.RowIndex];
            txtid.Text = currentRow.Cells[0].Value.ToString();
            txtBINumber.Text = currentRow.Cells[2].Value.ToString();
            txtName.Text = currentRow.Cells[1].Value.ToString();
            txtRate.Text = currentRow.Cells[3].Value.ToString();
            btnSave.Enabled = false;
            btnedit.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            var bedName = txtName.Text;
            var bedNumber = txtBINumber.Text;
            var rate = txtRate.Text;

            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);

            var updateBedInfo = "UPDATE Bed_Information SET Name='"+bedName+"',BI_Number='"+bedNumber+"',Rate='"+rate+"' WHERE BI_ID="+txtid.Text;
            objData.ExecuteQuery(updateBedInfo, ref strErr);
            MessageBox.Show(strErr != "" ? strErr : @"Bed Information updated successfully.");
            objData.CloseConnection();
            LoadList();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Utility.ClearAllControls(this);
            btnSave.Enabled = true;
            btnedit.Enabled = false;
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
