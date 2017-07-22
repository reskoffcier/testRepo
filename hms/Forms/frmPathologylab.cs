using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmPathologylab : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmPathologylab()
        {
            InitializeComponent();
        }



        private void frmPathologylab_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmLoad();
            objData.CloseConnection();
        }

        private void frmLoad()
        {
            //throw new NotImplementedException();
            lbPathlab.Items.Clear();
            lbPathlab.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Test Complete", 1));
            lbPathlab.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Report Complete", 2));
            lbPathlab.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Report Aprove", 3));
            txtinvestigationid.Text = "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;

            //lbPathlab.SelectedIndex = lbPathlab.FindStringExact("Test Complete");
            //to select the selected item
            //lbPathlab.SelectedIndex = lbPathlab.FindStringExact("Test Complete");
            var strSql = "SELECT Category_ID,Category_Name FROM Dbo_Service_Category where cat_type=1 ORDER BY Category_Name";
            var categoryList = objData.RetriveData(strSql, ref strErr);

            var x = 20;
            var y = 20;
            var checkBoxPerRow = 4;
            var eachWidth = gbtestcatagory.Width / checkBoxPerRow;

            for (var i = 0; i < categoryList.Rows.Count; i++)
            {
                var checkbox = new CheckBox();
                checkbox.Text = categoryList.Rows[i][1].ToString();
                checkbox.Tag = categoryList.Rows[i][0].ToString();
                checkbox.Checked = false;
                checkbox.Location = new Point(x, y);
                checkbox.BringToFront();
                checkbox.CheckedChanged += checkbox_CheckedChanged;
                gbtestcatagory.Controls.Add(checkbox);
                y = (i + 1) % checkBoxPerRow == 0 ? (y + 30) : (y);
                x = (i + 1) % checkBoxPerRow == 0 ? (20) : (x + eachWidth);
            }
            //var list = new string[] { "sdf", "sdf", "sdf", "sdf", "sdf", "sdf", "sdf", "sdf" };
            //for (var i = 0; i < list.Length; i++)
            //{
            //    var checkbox = new CheckBox();
            //    checkbox.Text = list[i];//categoryList.Rows[i][1].ToString();
            //    checkbox.Tag = categoryList.Rows[i][0].ToString();
            //    checkbox.Checked = false;
            //    checkbox.Location = new Point(x, y);
            //    checkbox.BringToFront();
            //    checkbox.CheckedChanged += checkbox_CheckedChanged;
            //    gbtestcatagory.Controls.Add(checkbox);
            //    y = (i + 1) % checkBoxPerRow == 0 ? (y + 30) : (20);
            //    x = (i + 1) % checkBoxPerRow == 0 ? (20) : (x + eachWidth);
            //}
            formateGrid();

            fillGridView();


        }

        private void fillGridView()
        {
            //throw new NotImplementedException();
            hms.Include_Files.Utility.ComboboxItem LabData = lbPathlab.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            var ReportId = 1;
            if (LabData != null)
            {
                ReportId = LabData.Value;
            }

            var ids = "";
            for (var i = 0; i < gbtestcatagory.Controls.Count; i++)
            {
                if (gbtestcatagory.Controls[i] is CheckBox)
                {
                    if (((CheckBox)gbtestcatagory.Controls[i]).Checked)
                    {
                        if (ids == "")
                        {
                            ids = ((CheckBox)gbtestcatagory.Controls[i]).Tag.ToString();
                        }
                        else
                        {
                            ids += "," + ((CheckBox)gbtestcatagory.Controls[i]).Tag.ToString();
                        }
                    }
                }
            }

            string strSQL = "";
            strSQL = "select cast(inv.Invetigation_SL as varchar(6))+'/'+cast( MONTH(inv.CreatedON) as varchar(2))+'/'+cast(year(inv.CreatedON) as varchar(4)) investigation ";
            strSQL = strSQL + ", inv.CreatedON 'Date', s.Service_Name 'Test Name', s.Sample_Type 'Sample Type'";
            strSQL = strSQL + ", p.Name+'('+cast(datediff(year, p.BirthDate, getdate()) as varchar(3))+'Y)' 'Tatient' ";
            strSQL = strSQL + ",d.Name 'Doctor', s.Amount 'Charge' ,inv.InvestigationID,  items.ISI_ID ";
            strSQL = strSQL + "From dbo_Investigation Inv inner join dbo_Patient_info P On inv.P_ID = p.P_ID ";
            strSQL = strSQL + "inner join dbo_Doctor_List D on inv.DocID=d.DocID ";
            strSQL = strSQL + "inner Join dbo_InvertigationServiceItem items on inv.InvestigationID=items.Investigationid ";
            strSQL = strSQL + "Inner join Dbo_Services S on s.Service_ID = items.Service_ID ";
            if (ReportId == 3)
            {
                strSQL = strSQL + "where items.Status >=  " + ReportId;
            }
            else
            {
                strSQL = strSQL + "where items.Status =  " + ReportId;
            }

            if (ids != "")
            {
                strSQL = strSQL + " And S.Category_ID in (" + ids + ")";
            }

            string strVal = "";

            strVal = txtinvestigationid.Text;


            string[] arrinv = strVal.Split(new string[] { "/" }, StringSplitOptions.None);

            if (arrinv.Length.ToString() == "3")
            {
                if (arrinv[0].ToString() == "")
                {
                    //MessageBox.Show("please enter valid investifgation no.");
                }
                else
                {
                    if (arrinv[1].ToString() == "")
                    {
                        //MessageBox.Show("please enter valid Month no.");
                    }
                    else
                    {
                        if (arrinv[2].ToString() == "")
                        {
                            //MessageBox.Show("please enter valid year no.");
                        }
                        else
                        {
                            strSQL = strSQL + " and  inv.Invetigation_SL= " + arrinv[0].Trim();
                            strSQL = strSQL + " and  MONTH(inv.CreatedON)= " + arrinv[1].Trim();
                            strSQL = strSQL + " and  year(inv.CreatedON)= " + arrinv[2].Trim();
                        }
                    }
                }
            }



            //objData = new C_Data_Batch();
            //objData.OpenConnection("AzharPC-Home", ref strErr);
            DataTable arrSample = objData.RetriveData(strSQL, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(arrSample);

            dgvPathLab.DataSource = ds.Tables["Table1"];
            dgvPathLab.Columns["InvestigationID"].Visible = false;
            dgvPathLab.Columns["ISI_ID"].Visible = false;




        }

        private void formateGrid()
        {
            //throw new NotImplementedException();
            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //col.HeaderText = "SL No";
            //col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //this.dgvPathLab.Columns.Add(col);
            //this.dgvPathLab.RowCount = 5;

            dgvPathLab.Columns.Clear();
            dgvPathLab.Refresh();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "";
            dgvPathLab.Columns.Insert(0, checkBoxColumn);
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //var ids = "";
            //for (var i = 0; i < gbtestcatagory.Controls.Count; i++)
            //{
            //    if (gbtestcatagory.Controls[i] is CheckBox)
            //    {
            //        if (((CheckBox)gbtestcatagory.Controls[i]).Checked)
            //        {
            //            ids += "," + ((CheckBox)gbtestcatagory.Controls[i]).Tag.ToString();
            //        }
            //    }
            //}
            //MessageBox.Show(ids);
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            fillGridView();
            objData.CloseConnection();
        }

        private void lbPathlab_SelectedIndexChanged(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            fillGridView();
            objData.CloseConnection();
        }

        private void txtinvestigationid_KeyUp(object sender, KeyEventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            fillGridView();
            objData.CloseConnection();
        }

        private void chkNewData_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewData.Checked == true)
            {
                objData = new C_Data_Batch();
                objData.OpenConnection("AzharPC-Home", ref strErr);
                fillGridView();
                objData.CloseConnection();
            }
        }



        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            SaveData();
            objData.CloseConnection();
        }

        private void SaveData()
        {
            //throw new NotImplementedException();
            string strSqlUpdateItems = "";
            string strSqlInsertHistory = "";
            string strIDs = "";
            var strMsg = "";
            hms.Include_Files.Utility.ComboboxItem LabData = lbPathlab.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            var ReportId = 2;
            if (LabData != null)
            {
                ReportId = Convert.ToInt16(LabData.Value.ToString()) + 1;
            }

            if (Convert.ToInt32(dgvPathLab.Rows.Count) - 1 > 0)
            {
                for (int i = 0; i < dgvPathLab.Rows.Count - 1; i++)
                {
                    if ((bool)dgvPathLab.Rows[i].Cells[0].FormattedValue == true)
                    {
                        if (strIDs.ToString() == "")
                        {
                            strIDs = dgvPathLab.Rows[i].Cells[9].Value.ToString();
                            strSqlInsertHistory = " (" + dgvPathLab.Rows[i].Cells[9].Value.ToString() + ", " + ReportId + ", " + hms.Include_Files.Utility.userID + ",'"+Utility.PcName+"')";
                        }
                        else
                        {
                            strIDs = strIDs + ", " + dgvPathLab.Rows[i].Cells[9].Value.ToString();
                            strSqlInsertHistory = strSqlInsertHistory + ", (" + dgvPathLab.Rows[i].Cells[9].Value.ToString() + ", " + ReportId + ", " + hms.Include_Files.Utility.userID + ",'" + Utility.PcName + "')";
                        }
                    }
                }
            }

            if (strIDs.ToString() != "")
            {
                strSqlUpdateItems = "Update dbo_InvertigationServiceItem SET Status=" + ReportId + " where [ISI_ID] in (" + strIDs.ToString() + ")";
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
                            //MessageBox.Show("sample collection saved succefully done.");
                            hms.Include_Files.Utility.ComboboxItem LabDataMsg = lbPathlab.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
                            strMsg = "Test Complete";
                            if (LabDataMsg != null)
                            {
                                strMsg = LabDataMsg.Name;
                            }
                            strMsg = strMsg + " saved succefully done.";
                            MessageBox.Show(strMsg);
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

        private void dgvPathLab_DoubleClick(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem LabData = lbPathlab.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            var ReportId = 2;
            if (LabData != null)
            {
                ReportId = Convert.ToInt16(LabData.Value.ToString());
            }
            if (ReportId == 3)
            {
                frmPathologyLabProcess f = new frmPathologyLabProcess(dgvPathLab.CurrentRow.Cells[8].Value.ToString());
                f.Show();
            }
            //new frmPathologyLabProcess() { Owner = this }.ShowDialog();

            //new frmAdmitedPatientList() { Owner = this }.ShowDialog();
            //var val = 
            //MessageBox.Show(loadInvestigationID());
        }

        //public string  loadInvestigationID()
        //{
        //    var invVal ="";
        //    invVal = dgvPathLab.CurrentRow.Cells[8].Value.ToString();

        //    return invVal;
        //}


    }
}
