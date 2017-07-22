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
    public partial class frmMarketingTargetSetup : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmMarketingTargetSetup()
        {
            InitializeComponent();
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "SELECT EmpID,Name FROM dbo_Employee_Profiles";
            var employeeList = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "EmpId";
            cmbEmployee.DataSource = employeeList;
            cmbEmployee.SelectedIndex = -1;
            cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged;
        }

        private void cmbEmployee_TextChanged(object sender, EventArgs e)
        {
            cmbEmployee.DroppedDown = false;
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex > -1)
            {
                var empId = cmbEmployee.SelectedValue.ToString();
                objData.OpenConnection("AatickPC-Office", ref strErr);
                var sql = "SELECT E.EmpID,E.Name,CASE WHEN E.IsDoctor=1 THEN 'Yes' ELSE 'No' END,CASE WHEN E.IsEmployment=1 THEN 'Yes' ELSE 'No' END,DS.Designation,DP.Name,CONVERT(VARCHAR(12),JoiningDate,106) FROM dbo_Employee_Profiles E INNER JOIN dbo_Employee_Designation D ON E.EmpId=D.EmpId INNER JOIN dbo_Designation DS ON DS.DegId=D.DegId INNER JOIN dbo_Department DP ON DP.DeptID=DS.DeptID WHERE E.EmpId=" + empId;
                var employeeInfo = objData.RetriveData(sql, ref strErr);
                objData.CloseConnection();
                if (employeeInfo.Rows.Count > 0)
                {
                    txtEmpployeeID.Text = employeeInfo.Rows[0][0].ToString();
                    txtEmployeeName.Text = employeeInfo.Rows[0][1].ToString();
                    txtDoctors.Text = employeeInfo.Rows[0][2].ToString();
                    txtPermanent.Text = employeeInfo.Rows[0][3].ToString();
                    txtDesignation.Text = employeeInfo.Rows[0][4].ToString();
                    txtDepartment.Text = employeeInfo.Rows[0][5].ToString();
                    txtDateofJoin.Text = employeeInfo.Rows[0][6].ToString();
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            strErr = "";
            var empId = cmbEmployee.SelectedValue.ToString();
            var target = 0.0;
            double.TryParse(txtsettergetamount.Text,out target);
            if (target<=0)
            {
                MessageBox.Show(@"Please enter target amount.");
                return;
            }
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sql = "SELECT COUNT(1) FROM dbo_Marketing_Yearly_Target WHERE EmpID=" + empId + " AND TrgYearFrom=CASE WHEN MONTH(GETDATE())>6 THEN YEAR(GETDATE()) ELSE YEAR(GETDATE())-1 END AND TrgYearTo=CASE WHEN MONTH(GETDATE())>6 THEN YEAR(GETDATE())+1 ELSE YEAR(GETDATE()) END";
            var dtCount = objData.RetriveData(sql, ref strErr);
            if (int.Parse(dtCount.Rows[0][0].ToString())>0)
            {
                objData.CloseConnection();
                MessageBox.Show(@"The target has already been set up for this employee.");
                return;
            }
            sql = "USP_SET_MARKETING_TARGET "+empId+","+target+","+Utility.userID+",'"+Utility.PcName+"'";
            objData.ExecuteQuery(sql,ref strErr);
            objData.CloseConnection();
            if (strErr == "")
            {
                MessageBox.Show(@"Target set up successfull.");
            }
        }
    }
}
