using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using System.Reflection;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmCategory : Form
    {
        C_Data_Batch objData;
        public frmCategory()
        {
            InitializeComponent();
        }

        //public 

        private void frmCategory_Load(object sender, EventArgs e)
        {
            getcategorid();
            clearCatName();
            grdShow();
        }

        private void grdShow()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "select Category_ID, Category_Name from Dbo_Service_Category order by Category_ID Desc";
            DataTable arrCatList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            DataSet ds = new DataSet();
            ds.Tables.Add(arrCatList);
            dgvCategory.DataSource = ds.Tables["Table1"];

        }

        private void clearCatName()
        {
            //throw new NotImplementedException();
            txtcategoryname.Text = "";
        }

        private void getcategorid()
        {
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "select max(Category_ID) from Dbo_Service_Category";
            DataTable arrCatID = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            int CatId = 0;

            if (arrCatID.Rows.Count > 0)
            {
                if (arrCatID.Rows[0][0].ToString() == "")
                {
                    CatId = 1;
                }
                else
                {
                    CatId = Convert.ToInt32(arrCatID.Rows[0][0].ToString()) + 1;
                }
            }
            else
            {
                CatId = 1;
            }
            txtCategoryID.Text = CatId.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            getcategorid();
            clearCatName();
            grdShow();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            insertData();
            
        }

        private void insertData()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "Insert into Dbo_Service_Category (Category_Name) values ('"+txtcategoryname.Text.ToString()+"')";
            objData.ExecuteQuery(strSQL, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data not Saved.");
            }
            else
            {
                MessageBox.Show("Data Save Succefully Done.");
                getcategorid();
                clearCatName();
                grdShow();
            }
            objData.CloseConnection();
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtcategoryname.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            dataEdit();
            
        }

        private void dataEdit()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "Update Dbo_Service_Category Set Category_Name='" + txtcategoryname.Text.ToString() + "' where Category_ID = " + txtCategoryID.Text.ToString();
            objData.ExecuteQuery(strSQL, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data not edited.");
            }
            else
            {
                MessageBox.Show("Data edited Succefully Done.");
                getcategorid();
                clearCatName();
                grdShow();
            }
            objData.CloseConnection();
        }

        private void btndelect_Click(object sender, EventArgs e)
        {
            deleteData();
            
        }

        private void deleteData()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "Delete From  Dbo_Service_Category  where Category_ID = " + txtCategoryID.Text.ToString();
            objData.ExecuteQuery(strSQL, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data not Deleted.");
            }
            else
            {
                MessageBox.Show("Data Deleted Succefully Done.");
                getcategorid();
                clearCatName();
                grdShow();
            }
            objData.CloseConnection();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {

            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "select Category_ID, Category_Name from Dbo_Service_Category where Category_ID = 2 order by Category_ID Desc";
            DataTable arrCatList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            DataSet ds = new DataSet();
            ds.Tables.Add(arrCatList);


            frmReport reportviewer = new frmReport();
            var rptpath = Utility.ReportPath + "rptCategory.rpt";
            reportviewer.ReportPath = rptpath;
            reportviewer.Reportds = ds;
            reportviewer.Show(this);
            
        }
    }
}
