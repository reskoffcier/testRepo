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
    public partial class frmServiceWiseList : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmServiceWiseList()
        {
            InitializeComponent();
        }

        private void frmServiceWiseList_Load(object sender, EventArgs e)
        {
            
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmload();
            objData.CloseConnection();
        }

        private void frmload()
        {
            //throw new NotImplementedException();
            fillGridView();
            clearData();
            loadServiceName();
            getMaxID();
        }

        private void getMaxID()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select max(SIT_ID) from Dbo_service_Itemwise_Test";
            DataTable arrID = objData.RetriveData(strSQL, ref strErr);
            int Id = 0;

            if (arrID.Rows.Count > 0)
            {
                if (arrID.Rows[0][0].ToString() == "")
                {
                    Id = 1;
                }
                else
                {
                    Id = Convert.ToInt32(arrID.Rows[0][0].ToString()) + 1;
                }
            }
            else
            {
                Id = 1;
            }
            txtSIT_ID.Text = Id.ToString();
        }

        private void loadServiceName()
        {
        
            string strSQL = "";
            strSQL = "select Service_ID, Service_Name from Dbo_Services order by Service_Name";
            DataTable arrcatList = objData.RetriveData(strSQL, ref strErr);

            cmbServices.Items.Clear();
            if (arrcatList.Rows.Count > 0)
            {
                for (int i = 0; i < arrcatList.Rows.Count; i++)
                {
                    cmbServices.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrcatList.Rows[i][1].ToString(), Convert.ToInt32(arrcatList.Rows[i][0].ToString())));
                }
            }
        }

        private void clearData()
        {
            //throw new NotImplementedException();
            txtSIT_ID.Text = "";
            txtServiceID.Text = "";
            txtEntity.Text = "";
            txtOGroup.Text = "";
            txtRefRenge.Text = "";
            txtResultB.Text = "";
            txtUnit.Text="";
            cmbServices.SelectedIndex = -1;


            
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("PolinPC-Office", ref strErr);
            frmload();
            objData.CloseConnection();
        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem itms = cmbServices.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            if (itms != null)
            {
                txtServiceID.Text = itms.Value.ToString();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click (object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            DataSave();
            objData.CloseConnection();
        }

        private void DataSave()
        {
            //throw new NotImplementedException();
            string strSql = "";
            strSql = "INSERT INTO [Dbo_service_Itemwise_Test]([Service_ID],[OGroup],[Entity],[Unit],[RefRenge],[Result_B]) ";
            strSql = strSql + " values (" + txtServiceID.Text.ToString() + ", N'" + txtOGroup.Text.ToString() + "' ";
            strSql = strSql + ", N'"+txtEntity.Text.ToString()+"', N'"+txtUnit.Text.ToString()+"', N'"+txtRefRenge.Text.ToString()+"', N'"+txtResultB.Text.ToString()+"')";

            objData.ExecuteQuery(strSql, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data Not inserted.");
            }
            else
            {
                MessageBox.Show("Data inserted succefully done.");
                frmload();
            }

        }

        private void btndelect_Click(object sender, EventArgs e)
        {
            string strSql = "";
            strSql = "Delete From  [Dbo_service_Itemwise_Test] where SIT_ID = " + txtSIT_ID.Text.ToString();//([Service_ID],[OGroup],[Entity],[Unit],[RefRenge],[Result_B]) ";
            //strSql = strSql + " values (" + txtServiceID.Text.ToString() + ", '" + txtOGroup.Text.ToString() + "' ";
            //strSql = strSql + ", '" + txtEntity.Text.ToString() + "', '" + txtUnit.Text.ToString() + "', '" + txtRefRenge.Text.ToString() + "', '" + txtResultB.Text.ToString() + "')";

            objData.ExecuteQuery(strSql, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data Not Deleted.");
            }
            else
            {
                MessageBox.Show("Data deleted succefully done.");
                frmload();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            DataEdit();
            objData.CloseConnection();
        }

        private void DataEdit()
        {
            //throw new NotImplementedException();
            string strSql = "";
            strSql = "UPDATE [Dbo_service_Itemwise_Test] SET [Service_ID] =" + txtServiceID.Text.ToString() + " ,[OGroup] =N'" + txtOGroup.Text.ToString() + "' ,[Entity] = N'" + txtEntity.Text.ToString() + "',[Unit] = N'" + txtUnit.Text.ToString() + "',[RefRenge] = N'" + txtRefRenge.Text.ToString() + "',[Result_B] =N'" + txtResultB.Text.ToString() + "' WHERE SIT_ID = "+txtSIT_ID.Text.ToString();
            objData.ExecuteQuery(strSql, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data Not Edited.");
            }
            else
            {
                MessageBox.Show("Data Edited succefully done.");
                frmload();
            }

        }
        private void fillGridView()
        {
            //throw new NotImplementedException();
            string strSql = "";

            strSql = "SELECT st.[SIT_ID],s.[Service_Name],st.[OGroup],st.[Entity],st.[Unit],st.[RefRenge],st.[Result_B]  FROM [Dbo_service_Itemwise_Test] ST inner Join Dbo_Services S On St.Service_ID=s.Service_ID order by st.[SIT_ID] desc ";

            DataTable arrSTInfo = objData.RetriveData(strSql, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(arrSTInfo);
            dgvServiceWiseSetup.DataSource = ds.Tables["Table1"];
        }
        private void dgvServiceWiseSetup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSIT_ID.Text=dgvServiceWiseSetup.CurrentRow.Cells[0].Value.ToString();
            cmbServices.SelectedIndex = cmbServices.FindStringExact(dgvServiceWiseSetup.CurrentRow.Cells[1].Value.ToString());
            hms.Include_Files.Utility.ComboboxItem valService = cmbServices.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            if (valService != null)
            {
                txtServiceID.Text = valService.Value.ToString();
            }
            else
            {
                txtServiceID.Text = "";
            }
            txtOGroup.Text = dgvServiceWiseSetup.CurrentRow.Cells[2].Value.ToString();
            txtEntity.Text = dgvServiceWiseSetup.CurrentRow.Cells[3].Value.ToString();
            txtUnit.Text = dgvServiceWiseSetup.CurrentRow.Cells[4].Value.ToString();
            txtRefRenge.Text = dgvServiceWiseSetup.CurrentRow.Cells[5].Value.ToString();
            txtResultB.Text = dgvServiceWiseSetup.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "SELECT st.[SIT_ID],s.[Service_Name],st.[OGroup],st.[Entity],st.[Unit],st.[RefRenge],st.[Result_B]  FROM [Dbo_service_Itemwise_Test] ST inner Join Dbo_Services S On St.Service_ID=s.Service_ID order by st.[SIT_ID] desc";
            DataTable arrCatList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            DataSet ds = new DataSet();
            ds.Tables.Add(arrCatList);


            frmReport reportviewer = new frmReport();
            var rptpath = Utility.ReportPath + "rptServicesWiseTest.rpt";
            reportviewer.ReportPath = rptpath;
            reportviewer.Reportds = ds;
            reportviewer.Show(this);
        }
    }
}
