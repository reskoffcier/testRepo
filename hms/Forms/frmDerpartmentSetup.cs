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
    public partial class frmDerpartmentSetup : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmDerpartmentSetup()
        {
            InitializeComponent();
        }

        private void frmDerpartmentSetup_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmLoad();
            objData.CloseConnection();
            
        }

        private void frmLoad()
        {
            //throw new NotImplementedException();
            
            txtDeptID.Text = "";
            txtDeptName.Text = "";
            rtbDeptDes.Text = "";
            fillGrvDepartment(); 
            getMaxID();
            
        }

        private void getMaxID()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select max(DeptID) from dbo_Department";
            DataTable dtMaxID = objData.RetriveData(strSQL, ref strErr);
            int DptId = 1;
            if (dtMaxID.Rows.Count > 0)
            {
                if (dtMaxID.Rows[0][0].ToString() != "")
                {
                    DptId = Convert.ToInt16(dtMaxID.Rows[0][0].ToString()) + 1;
                }
            }
            txtDeptID.Text = DptId.ToString();
        }

        private void fillGrvDepartment()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select * from dbo_Department order by DeptID desc";
            DataTable dtAllDept = objData.RetriveData(strSQL, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(dtAllDept);

            dgvDepartment.DataSource = ds.Tables["Table1"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmLoad();
            objData.CloseConnection();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.N))
            {
                button3.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            string strSql = "";
            strSql = "insert into dbo_Department(Name, Description) values('"+txtDeptName.Text.ToString()+"','"+rtbDeptDes.Text.ToString()+"')";
            objData.ExecuteQuery(strSql, ref strErr);
            if (strErr.ToString() == "")
            {
                MessageBox.Show("Doctor list save Succefully Done");
                frmLoad();
            }
            else
            {
                MessageBox.Show("Doctor list not save Succefully.");
            }
            objData.CloseConnection();
        }

       
    }
}
