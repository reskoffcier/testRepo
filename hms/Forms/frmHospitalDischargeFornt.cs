using hms.Include_Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;

namespace hms.Forms
{
    public partial class frmHospitalDischargeFornt : Form
    {
        private C_Data_Batch objData = new C_Data_Batch();

        public string strErr = "";
        public frmHospitalDischargeFornt()
        {
            InitializeComponent();
        }

        private void btnPatienList_Click(object sender, EventArgs e)
        {
            new frmAdmitedPatientList("frmHospitalDischargeFornt") { Owner = this }.ShowDialog();
        }


        public void LoadAdmissionInfo(string addmissionSl, string admission_Id)
        {
            Utility.ClearAllControls(this);
            txtAdmissionId.Text = admission_Id;
            //int.TryParse(admission_Id, out this.txtAdmissionId.Text);
            //LoadGrid(admission_Id);
            //lstserviceinfo.SelectedIndex = -1;
            //txtServiceInfo.Text = "";
            //txtServiceInfo.Enabled = false;
            //EnableDisableTextFields(false);
            //txtsl.Visible = txtDate.Visible = txtremark.Visible = lblRemark.Visible = lbldate.Visible = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var strSQL = "";
            var strStatus = "";
            if (rbtnDischarge.Checked == true)
            {
                strStatus = rbtnDischarge.Text;
            }
            else if (rbtnPatientDeath.Checked)
            {
                strStatus = rbtnPatientDeath.Text;
            }
            else if (rbtntransfer.Checked)
            {
                strStatus = rbtntransfer.Text;
            }
            else
            {
                strStatus = "Unknown";
            }
             
            strSQL = "update Patient_Bed SET isBooked = 0,Note='"+strStatus+"',release_on=getdate(), DischargeUserID = " + Utility.userID + ",DischargeUserPC='" + Utility.PcName + "'  where Admission_id = " + txtAdmissionId.Text + " and isBooked = 1";
            objData.OpenConnection("AzharPC-Office", ref strErr);

            objData.ExecuteQuery(strSQL, ref strErr);
            objData.CloseConnection();
            MessageBox.Show(strErr != "" ? @"Patient Not Discharge." : @"Patient Discharge successfully.");
            Utility.ClearAllControls(this);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Utility.ClearAllControls(this);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
