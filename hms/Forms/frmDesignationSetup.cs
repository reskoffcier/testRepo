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
    public partial class frmDesignationSetup : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmDesignationSetup()
        {
            InitializeComponent();
        }

        private void frmDesignationSetup_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmLoad();
            objData.CloseConnection();
        }

        private void frmLoad()
        {
            //throw new NotImplementedException();
            txtDesigntionName.Text = "";
            getMaxID();
            loadDepartment();
            fillGrdView();
        }

        private void fillGrdView()
        {
            //throw new NotImplementedException();
            string strSql = "";
            strSql = "select Deg.DegId,dept.Name DeptName, deg.Designation DegName From dbo_Designation Deg Inner Join dbo_Department dept On deg.DeptID = dept.DeptID order by deg.DegId Desc";
            DataTable dtDeptInfo = objData.RetriveData(strSql, ref strErr);
            DataSet ds = new DataSet();
            ds.Tables.Add(dtDeptInfo);
            dgvDensignation.DataSource = ds.Tables["Table1"];
        }

        private void loadDepartment()
        {
            //throw new NotImplementedException();
            string strSql = "";
            strSql = "select DeptID, Name From dbo_Department order by Name";
            DataTable dtDeptInfo = objData.RetriveData(strSql, ref strErr);

            if (dtDeptInfo.Rows.Count > 0)
            {
                cmbDepartment.Items.Clear();
                for (int i = 0; i < dtDeptInfo.Rows.Count; i++)
                {
                    cmbDepartment.Items.Add(new hms.Include_Files.Utility.ComboboxItem(dtDeptInfo.Rows[i][1].ToString(), Convert.ToInt32(dtDeptInfo.Rows[i][0].ToString())));
                }
                //hms.Include_Files.Utility.ComboboxItem dept = new Include_Files.Utility.ComboboxItem();
            }
        }

        private void getMaxID()
        {
            //throw new NotImplementedException();
            string strSql = "";
            strSql = "select max(DegId) form dbo_Designation";
            DataTable dtMaxid = objData.RetriveData(strSql, ref strErr);
            int MaxId = 1;
            if (dtMaxid.Rows.Count > 0)
            {
                if (dtMaxid.Rows[0][0].ToString() != "")
                {
                    MaxId = Convert.ToInt16(dtMaxid.Rows[0][0].ToString()) + 1;
                }
            }

            txtDesignatioID.Text = MaxId.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
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
                btnNew.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = "";
            hms.Include_Files.Utility.ComboboxItem Dept = cmbDepartment.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            if (Dept != null)
            {
                objData = new C_Data_Batch();
                objData.OpenConnection("AzharPC-Home", ref strErr);
                strSql = "Insert into dbo_Designation(DeptID, Designation) values ("+Dept.Value.ToString()+", '"+txtDesigntionName.Text.ToString()+"')";
                objData.ExecuteQuery(strSql, ref strErr);

                if (strErr.ToString() != "")
                {
                    MessageBox.Show("Designation inserted");
                    frmLoad();
                }
                else
                {
                    MessageBox.Show("Designation not inserted");
                }

                objData.CloseConnection();
            }
            else
            {
                MessageBox.Show("Please Select the Department.");
            }

        }
    }
}
