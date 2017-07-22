using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BatchDLL;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmStatus : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmStatus()
        {
            InitializeComponent();
            rbtnInvestigation.Checked = true;
            rbtnAdmission.Checked = false;
            grdInfo.AllowUserToAddRows =
                grdDetails.AllowUserToAddRows =
                    grdInfo.AllowUserToDeleteRows =
                        grdDetails.AllowUserToDeleteRows =
                            grdInfo.RowHeadersVisible = grdDetails.RowHeadersVisible = grdInfo.MultiSelect = grdDetails.MultiSelect = false;
        }

        private void btnIdWise_Click(object sender, EventArgs e)
        {
            txtDocID.ResetText();
            var id = txtInvIDandAdmID.Text.Trim();
            if (id != "" && id.Split('/').Length == 3)
            {
                GetAdmissionOrInvestigationInfo(id.Split('/')[0], id.Split('/')[1], id.Split('/')[2], 0);
            }
            else
            {
                MessageBox.Show("Invalid " + (rbtnAdmission.Checked ? "Admission" : "Investigation") + " Id");
            }
        }

        private void GetAdmissionOrInvestigationInfo(string sl, string mm, string yy, int docId)
        {
            strErr = "";
            if (rbtnAdmission.Checked || rbtnInvestigation.Checked)
            {
                var sql = "USP_Get_Admission_Investigation_Info " + sl + "," + mm + "," + yy + "," + (rbtnAdmission.Checked ? "1" : "2") + "," + docId + "," + Utility.DCP;
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var dtInfo = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (strErr != "")
                {
                    MessageBox.Show("An error occured.\n\nTry again later.");
                }
                else
                {
                    if (dtInfo.Rows.Count > 0)
                    {
                        grdInfo.DataSource = dtInfo;
                        grdInfo.Columns[0].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No " + (rbtnAdmission.Checked ? "Admission" : "Investigation") + " found.");
                        grdInfo.DataSource = null;
                    }
                    grdDetails.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please select Admission or Investigation radio button.");
            }
        }

        private void btnDocWise_Click(object sender, EventArgs e)
        {
            txtInvIDandAdmID.ResetText();
            int docId;
            int.TryParse(txtDocID.Text.Trim(), out docId);
            if (docId > 0)
            {
                GetAdmissionOrInvestigationInfo("null", "null", "null", docId);
            }
            else
            {
                MessageBox.Show("Invalid Doctor id.");
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            grdDetails.DataSource = grdInfo.DataSource = null;
            txtDocID.ResetText();
            txtInvIDandAdmID.ResetText();
        }

        private void txtInvIDandAdmID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIdWise.PerformClick();
            }
        }

        private void txtDocID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDocWise.PerformClick();
            }
        }

        private void grdInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = grdInfo.CurrentRow.Cells[0].Value.ToString();
            strErr = "";
            var sql = "USP_Get_Admission_Investigation_Services_Details " + id + "," + (rbtnAdmission.Checked ? 1 : 2);
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var dtInfo = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            if (strErr != "")
            {
                MessageBox.Show("An error occured.\n\nTry again later.");
            }
            else
            {
                if (dtInfo.Rows.Count > 0)
                {
                    grdDetails.DataSource = dtInfo;
                }
                else
                {
                    MessageBox.Show(@"No Services found for this " + (rbtnAdmission.Checked ? "Admission" : "Investigation") + ".");
                    grdDetails.DataSource = null;
                }
            }
        }
    }
}
