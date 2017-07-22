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
    public partial class frmInvestigationsamplecollection : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmInvestigationsamplecollection()
        {
            InitializeComponent();
        }

        private void frmInvestigationsamplecollection_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmLoad();
            objData.CloseConnection();
        }
        private void clearGrid()
        {
            dgvSampleCollection.Columns.Clear();
            dgvSampleCollection.Refresh();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "";
            dgvSampleCollection.Columns.Insert(0, checkBoxColumn);


        }
        private void frmLoad()
        {
            clearGrid();
            string strSQL = "";
            strSQL = "select cast(inv.Invetigation_SL as varchar(6))+'/'+cast( MONTH(inv.CreatedON) as varchar(2))+'/'+cast(year(inv.CreatedON) as varchar(4)) investigation ";
            strSQL = strSQL + ", inv.CreatedON 'Date', s.Service_Name 'Test Name', s.Sample_Type 'Sample Type'";
            strSQL = strSQL + ", p.Name+'('+cast(datediff(year, p.BirthDate, getdate()) as varchar(3))+'Y)' 'Tatient' ";
            strSQL = strSQL + ",d.Name 'Doctor', s.Amount 'Charge' ,inv.InvestigationID,  items.ISI_ID ";
            strSQL = strSQL + "From dbo_Investigation Inv inner join dbo_Patient_info P On inv.P_ID = p.P_ID ";
            strSQL = strSQL + "inner join dbo_Doctor_List D on inv.DocID=d.DocID ";
            strSQL = strSQL + "inner Join dbo_InvertigationServiceItem items on inv.InvestigationID=items.Investigationid ";
            strSQL = strSQL + "Inner join Dbo_Services S on s.Service_ID = items.Service_ID ";
            strSQL = strSQL + "where items.Status = 0 ";

            string strVal = "";

            strVal = txtInvestigation.Text.ToString();


            string[] arrinv = strVal.Split(new string[] { "/" }, StringSplitOptions.None);

            if (arrinv.Length.ToString() == "3")
            {
                if (arrinv[0].ToString() == "")
                {
                    MessageBox.Show("please enter valid investifgation no.");
                }
                else
                {
                    if (arrinv[1].ToString() == "")
                    {
                        MessageBox.Show("please enter valid Month no.");
                    }
                    else
                    {
                        if (arrinv[2].ToString() == "")
                        {
                            MessageBox.Show("please enter valid year no.");
                        }
                        else
                        {
                            strSQL = strSQL + " and  inv.Invetigation_SL= " + arrinv[0].Trim().ToString();
                            strSQL = strSQL + " and  MONTH(inv.CreatedON)= " + arrinv[1].Trim().ToString();
                            strSQL = strSQL + " and  year(inv.CreatedON)= " + arrinv[2].Trim().ToString();
                        }
                    }
                }
            }



            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            DataTable arrSample = objData.RetriveData(strSQL, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(arrSample);

            dgvSampleCollection.DataSource = ds.Tables["Table1"];
            dgvSampleCollection.Columns["InvestigationID"].Visible = false;
            dgvSampleCollection.Columns["ISI_ID"].Visible = false;


        }

        

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            saveData();
            objData.CloseConnection();
        }

        private void saveData()
        {
            //throw new NotImplementedException();
            string strSqlUpdateItems = "";
            string strSqlInsertHistory = "";
            string strIDs = "";

            if (Convert.ToInt32(dgvSampleCollection.Rows.Count) - 1 > 0)
            {
                for (int i = 0; i < dgvSampleCollection.Rows.Count - 1; i++)
                {
                    if ((bool)dgvSampleCollection.Rows[i].Cells[0].FormattedValue == true)
                    {
                        if (strIDs.ToString() == "")
                        {
                            strIDs = dgvSampleCollection.Rows[i].Cells[9].Value.ToString();
                            strSqlInsertHistory = " (" + dgvSampleCollection.Rows[i].Cells[9].Value.ToString() + ", 1,"+hms.Include_Files.Utility.userID+",'"+Utility.PcName+"')";
                        }
                        else
                        {
                            strIDs = strIDs + ", " + dgvSampleCollection.Rows[i].Cells[9].Value.ToString();
                            strSqlInsertHistory = strSqlInsertHistory + ", (" + dgvSampleCollection.Rows[i].Cells[9].Value.ToString() + ", 1," + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                        }
                    }
                }
            }

            if (strIDs.ToString() != "")
            {
                strSqlUpdateItems = "Update dbo_InvertigationServiceItem SET Status=1 where [ISI_ID] in (" + strIDs.ToString() + ")";
                strSqlInsertHistory = "insert into Investigation_Serviceitem_History (ISI_ID, Status, UserID,userPC) values " + strSqlInsertHistory;

                objData = new C_Data_Batch();
                objData.OpenConnection("AzharPC-Home", ref strErr);

                objData.BeginTransaction(ref strErr);
                if (strErr.ToString() == "")
                {
                    objData.ExecuteQuery(strSqlUpdateItems, ref strErr);
                    if (strErr.ToString() == "")
                    {
                        objData.ExecuteQuery(strSqlInsertHistory, ref strErr);
                        if (strErr.ToString() == "")
                        {
                            MessageBox.Show("sample collection saved succefully done.");
                            objData.CommitTransaction(ref strErr);
                            frmLoad();
                        }
                        else
                        {
                            objData.Rollback(ref strErr);
                            MessageBox.Show("System cannot deal at this moment.");
                        }
                    }
                    else
                    {
                        objData.Rollback(ref strErr);
                        MessageBox.Show("System cannot deal at this moment.");
                    }
                }

            }
        }

        
        private void txtInvestigation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                objData = new C_Data_Batch();
                objData.OpenConnection("AzharPC-Home", ref strErr);
                frmLoad();
                objData.CloseConnection();
            }
        }

        private void chkNewCollection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewCollection.Checked == true)
            {
                objData = new C_Data_Batch();
                objData.OpenConnection("AzharPC-Home", ref strErr);
                frmLoad();
                objData.CloseConnection();
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        

        
    }
}
