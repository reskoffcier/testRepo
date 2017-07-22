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
    public partial class frmserviceiteminformation : Form
    {
        C_Data_Batch objData;
        public frmserviceiteminformation()
        {
            InitializeComponent();
        }

        private void cbCategory_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("1");
        }

        private void frmserviceiteminformation_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void frmLoad()
        {
            cmbDurationType.Items.Clear();
            cmbDurationType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Hour", 1));
            cmbDurationType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Day", 2));
            //to select the selected item
            cmbDurationType.SelectedIndex = cmbDurationType.FindStringExact("Hour");

            cmbCommission.Items.Clear();
            cmbCommission.Items.Add(new hms.Include_Files.Utility.ComboboxItem("%", 1));
            cmbCommission.Items.Add(new hms.Include_Files.Utility.ComboboxItem("TK", 2));
            //to select the selected item
            cmbCommission.SelectedIndex = cmbCommission.FindStringExact("%");

            getServiceID();
            clearField();
            fillGridView();
            getCategoryList();
        }

        private void getCategoryList()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "select Category_id, Category_name from dbo_Service_Category order by Category_Name";
            DataTable arrcatList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            
            cmbCategory.Items.Clear();
            if (arrcatList.Rows.Count > 0)
            {
                for (int i = 0; i < arrcatList.Rows.Count; i++)
                {
                    cmbCategory.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrcatList.Rows[i][1].ToString(), Convert.ToInt32(arrcatList.Rows[i][0].ToString())));
                }
            }


        }

        private void clearField()
        {
            //throw new NotImplementedException();
            txtcatagory.Text = "";
            txtcommistion.Text = "";
            txtpc.Text = "";
            txtservicecharge.Text = "";
            txtservicename.Text = "";
            txtDuration.Text = "";
            chkSample.Checked = false;
            txtSample.Text = "";
            
            
        }

        

        private void getServiceID()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "select max(Service_ID) from Dbo_Services";
            DataTable arrID = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
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
            txtServiceID.Text = Id.ToString();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem itms = cmbCategory.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            if (itms != null)
            {
                txtcatagory.Text = itms.Value.ToString();
            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            frmLoad();
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
            InsertData();
        }

        private void InsertData()
        {
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            hms.Include_Files.Utility.ComboboxItem commissionType = cmbCommission.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            hms.Include_Files.Utility.ComboboxItem DurationType = cmbDurationType.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            int isSample = 0;
            if (chkSample.Checked == true)
            {
                isSample = 1;
            }
            string strSQL = "";
            strSQL = "insert into [Dbo_Services] ([Category_ID],[Amount],[Commission],[Commision_Type],[Dutaion],[Duraion_Type],[CC_PC],[isSample],[Sample_Type], [Service_Name] ) ";
            strSQL = strSQL + "Values (" + txtcatagory.Text.ToString() + ", " + txtservicecharge.Text.ToString() + ", " + txtcommistion.Text.ToString() + ", " + commissionType.Value.ToString() + ", " + txtDuration.Text.ToString() + ", " + DurationType.Value.ToString();
            strSQL = strSQL + ", "+txtpc.Text.ToString()+", "+isSample.ToString()+", '"+txtSample.Text.ToString()+"', '"+txtservicename.Text.ToString()+"' )";
            //MessageBox.Show(strSQL);
            objData.ExecuteQuery(strSQL, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data not Inserted."); 
            }
            else
            {
                MessageBox.Show("Data Inserted Succefully Done.");
                frmLoad();
            }
            objData.CloseConnection();
        }
        private void fillGridView()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "SELECT [Service_ID],cat.Category_Name,[Service_Name],[Amount],[Commission],case when [Commision_Type] = 1 then '%' else 'Tk' end  'Commision Type',[Dutaion]	,case when [Duraion_Type] = 1 then 'Hour' else 'day' end 'Duraion Type'	,[CC_PC],[Sample_Type],[isSample] FROM [Dbo_Services] S Inner Join dbo_Service_category Cat On S.Category_ID = CAt.Category_ID order by Service_id Desc ";
            DataTable arrID = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();

            DataSet Ds = new DataSet();
            Ds.Tables.Add(arrID);
            dgvServcieInformation.DataSource = Ds.Tables["Table1"];



        }
        private void dgvServcieInformation_Click(object sender, EventArgs e)
        {
            txtServiceID.Text = dgvServcieInformation.CurrentRow.Cells[0].Value.ToString();
            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(dgvServcieInformation.CurrentRow.Cells[1].Value.ToString());
            hms.Include_Files.Utility.ComboboxItem valCategory = cmbCategory.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            if (valCategory != null)
            {
                txtcatagory.Text = valCategory.Value.ToString();
            }
            //txtcatagory.Text = "";

            cmbCommission.SelectedIndex = cmbCommission.FindStringExact(dgvServcieInformation.CurrentRow.Cells[5].Value.ToString());

            cmbDurationType.SelectedIndex = cmbDurationType.FindStringExact(dgvServcieInformation.CurrentRow.Cells[7].Value.ToString());

            txtcommistion.Text = dgvServcieInformation.CurrentRow.Cells[4].Value.ToString();
            txtpc.Text = dgvServcieInformation.CurrentRow.Cells[6].Value.ToString();
            txtservicecharge.Text = dgvServcieInformation.CurrentRow.Cells[3].Value.ToString();
            txtservicename.Text = dgvServcieInformation.CurrentRow.Cells[2].Value.ToString();
            txtDuration.Text = dgvServcieInformation.CurrentRow.Cells[6].Value.ToString();
            if (dgvServcieInformation.CurrentRow.Cells[10].Value.ToString() == "True")
            {
                chkSample.Checked = true;
            }
            else {
                chkSample.Checked = false;
            }
            //chkSample.Checked = false;
            txtSample.Text = dgvServcieInformation.CurrentRow.Cells[9].Value.ToString();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "SELECT [Service_ID],cat.Category_Name,[Service_Name],[Amount],[Commission],case when [Commision_Type] = 1 then '%' else 'Tk' end  'Commision Type',[Dutaion]	,case when [Duraion_Type] = 1 then 'Hour' else 'day' end 'Duraion Type'	,[CC_PC],[Sample_Type],[isSample] FROM [Dbo_Services] S Inner Join dbo_Service_category Cat On S.Category_ID = CAt.Category_ID WHERE [Service_Name] LIKE '%" + textBox3.Text.ToString() + "%' order by Service_id Desc ";
            DataTable arrID = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();

            DataSet Ds = new DataSet();
            Ds.Tables.Add(arrID);
            dgvServcieInformation.DataSource = Ds.Tables["Table1"];
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void editData()
        {
            //throw new NotImplementedException();
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            hms.Include_Files.Utility.ComboboxItem commissionType = cmbCommission.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            hms.Include_Files.Utility.ComboboxItem DurationType = cmbDurationType.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            int isSample = 0;
            if (chkSample.Checked == true)
            {
                isSample = 1;
            }
            string strSQL = "";
            //strSQL = "insert into [Dbo_Services] ([Category_ID],[Amount],[Commission],[Commision_Type],[Dutaion],[Duraion_Type],[CC_PC],[isSample],[Sample_Type], [Service_Name] ) ";
            //strSQL = strSQL + "Values (" + txtcatagory.Text.ToString() + ", " + txtservicecharge.Text.ToString() + ", " + txtcommistion.Text.ToString() + ", " + commissionType.Value.ToString() + ", " + txtDuration.Text.ToString() + ", " + DurationType.Value.ToString();
            //strSQL = strSQL + ", " + txtpc.Text.ToString() + ", " + isSample.ToString() + ", '" + txtSample.Text.ToString() + "', '" + txtservicename.Text.ToString() + "' )";
            //MessageBox.Show(strSQL);
            strSQL = "update [Dbo_Services] SET [Category_ID] = " + txtcatagory.Text.ToString() + " ,[Amount] =" + txtservicecharge.Text.ToString() + " ,[Commission]=" + txtcommistion.Text.ToString();
            strSQL = strSQL + ",[Commision_Type] = " + commissionType.Value.ToString() + ",[Dutaion]= " + txtDuration.Text.ToString() + ",[Duraion_Type] = " + DurationType.Value.ToString();
            strSQL = strSQL + " ,[CC_PC] = " + txtpc.Text.ToString() + ",[isSample] = " + isSample.ToString() + " ,[Sample_Type]='" + txtSample.Text.ToString() + "', [Service_Name] = '" + txtservicename.Text.ToString() + "'  where Service_ID =" + txtServiceID.Text.ToString();
            objData.ExecuteQuery(strSQL, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("Data not updated.");
            }
            else
            {
                MessageBox.Show("Data updated Succefully Done.");
                frmLoad();
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
            strSQL = "SELECT [Service_ID],cat.Category_Name,[Service_Name],[Amount],[Commission],case when [Commision_Type] = 1 then '%' else 'Tk' end  'Commision Type',[Dutaion]	,case when [Duraion_Type] = 1 then 'Hour' else 'day' end 'Duraion Type'	,[CC_PC],[Sample_Type],[isSample] FROM [Dbo_Services] S Inner Join dbo_Service_category Cat On S.Category_ID = CAt.Category_ID order by Service_id Desc";
            DataTable arrCatList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();
            DataSet ds = new DataSet();
            ds.Tables.Add(arrCatList);


            frmReport reportviewer = new frmReport();
            var rptpath = Utility.ReportPath + "rptServices.rpt";
            reportviewer.ReportPath = rptpath;
            reportviewer.Reportds = ds;
            reportviewer.Show(this);
        }
    }
}
