using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using hms.BLL;
using hms.DAL;
using BatchDLL;
namespace hms.Forms
{
    public partial class frmDoctorsInformation : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmDoctorsInformation()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem Maritms = cmbMarktingOfficer.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            var valMar = 0;
            if (Maritms != null)
            {
                valMar = Maritms.Value;
            }
            hms.Include_Files.Utility.ComboboxItem itms = drDoctorType.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            if (itms != null)
            {
                //MessageBox.Show(itms.Value.ToString());
                int isPC = 0;
                if (chkbispc.Checked == true)
                {
                    isPC = 1;
                }
                string strSql = "";
                strSql = "insert into dbo_Doctor_List ([Title],[Name],[Degree],[Phone],[IsPc],[Address],[Area],[Specialist],[Doctor_Type],[MarketingBy],[UserID],DocID, Doctype) ";
                strSql = strSql + "Values ('" + txttitle.Text.ToString() + "', '" + txtdoctorname.Text.ToString();
                strSql = strSql + "', '" + txtdegree.Text.ToString() + "', '" + txtPhone.Text.ToString() + "'," + isPC.ToString();
                strSql = strSql + " ,'" + txtAddress.Text.ToString() + "','" + txtArea.Text.ToString() + "','" + txtspecialist.Text.ToString();
                strSql = strSql + "'," + itms.Value.ToString() + ", " + valMar + "," + hms.Include_Files.Utility.userID.ToString() + ", " + txtdoctorsid.Text.ToString() + ", '' )";
                

                objData = new C_Data_Batch();

                objData.OpenConnection("sakhawat-pc", ref strErr);

                objData.ExecuteQuery(strSql, ref strErr);

                if (strErr.ToString() == "")
                {
                    MessageBox.Show("Dotor setup succefully done.");
                    frmLoad();
                }
                else
                {
                    MessageBox.Show("Dotor setup not succefully done.");
                }
                objData.CloseConnection();
            }




            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem Maritms = cmbMarktingOfficer.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            var valMar = 0;
            if (Maritms != null)
            {
                valMar = Maritms.Value;
            }
            hms.Include_Files.Utility.ComboboxItem itms = drDoctorType.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            if (itms != null)
            {
                //MessageBox.Show(itms.Value.ToString());
                int isPC = 0;
                if (chkbispc.Checked == true)
                {
                    isPC = 1;
                }
                string strSql = "";
                //strSql = "insert into dbo_Doctor_List ([Title],[Name],[Degree],[Phone],[IsPc],[Address],[Area],[Specialist],[Doctor_Type],[MarketingBy],[UserID],DocID, Doctype) ";
                //strSql = strSql + "Values ('" + txttitle.Text.ToString() + "', '" + txtdoctorname.Text.ToString();
                //strSql = strSql + "', '" + txtdegree.Text.ToString() + "', '" + txtPhone.Text.ToString() + "'," + isPC.ToString();
                //strSql = strSql + " ,'" + txtAddress.Text.ToString() + "','" + txtArea.Text.ToString() + "','" + txtspecialist.Text.ToString();
                //strSql = strSql + "'," + itms.Value.ToString() + ", 1," + hms.Include_Files.Utility.userID.ToString() + ", " + txtdoctorsid.Text.ToString() + ", '' )";

                strSql = "Update dbo_Doctor_List SET [Title] = '" + txttitle.Text.ToString() + "',[Name] = '" + txtdoctorname.Text.ToString()+"',[Degree] ='" + txtdegree.Text.ToString() + "'";
                strSql = strSql + ",[Phone]='" + txtPhone.Text.ToString() + "',[IsPc]=" + isPC.ToString() + ",[Address]='" + txtAddress.Text.ToString() + "',[Area] = '" + txtArea.Text.ToString() + "',[Specialist] ='" + txtspecialist.Text.ToString() + "'";
                strSql = strSql + ",[Doctor_Type] ='" + itms.Value.ToString() + "', MarketingBy = "+valMar+"  where DocID =" + txtdoctorsid.Text.ToString();


                objData = new C_Data_Batch();

                objData.OpenConnection("sakhawat-pc", ref strErr);

                objData.ExecuteQuery(strSql, ref strErr);

                if (strErr.ToString() == "")
                {
                    MessageBox.Show("Dotor setup Edit succefully done.");
                    frmLoad();
                }
                else
                {
                    MessageBox.Show("Dotor setup Edit not succefully done.");
                }
                objData.CloseConnection();
            }
        }

        private void frmDoctorsInformation_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("PolinPC-Office", ref strErr);
            btnedit.Enabled = false;
            btnsave.Enabled = true;
            frmLoad();
            objData.CloseConnection();
            
        }

        private void frmLoad()
        {
            //throw new NotImplementedException();
            getMaxID();
            allFiledSet();
            FillGrdView();
            fillMarketingOfficer();
        }

        private void fillMarketingOfficer()
        {
            //throw new NotImplementedException();

            string strSQL = "";
            strSQL = "select E.EmpID, E.Name from dbo_Employee_Profiles E inner join dbo_Employee_Designation D On e.EmpID= D.EmpID 	inner join dbo_Designation DD On DD.DegId = D.DegID where DD.DeptID = 2 order by E.Name ";
            DataTable arrcatList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();

            cmbMarktingOfficer.Items.Clear();
            if (arrcatList.Rows.Count > 0)
            {
                for (int i = 0; i < arrcatList.Rows.Count; i++)
                {
                    cmbMarktingOfficer.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrcatList.Rows[i][1].ToString(), Convert.ToInt32(arrcatList.Rows[i][0].ToString())));
                }
            }

        }

        private void allFiledSet()
        {
            //throw new NotImplementedException();

            txttitle.Text = "";
            txtdoctorname.Text = "";
            txtdegree.Text  = ""; 
            txtPhone.Text = ""; 
            txtAddress.Text = ""; 
            txtArea.Text = "";
            chkbispc.Checked = false;
            txtspecialist.Text = ""; 
            drDoctorType.Items.Clear();
            drDoctorType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Listed", 1));
            drDoctorType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("In House", 2));
            drDoctorType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Out Source", 3));

            //to select the selected item
            drDoctorType.SelectedIndex = drDoctorType.FindStringExact("Out Source");


        }



        private void getMaxID()
        {
            int doctorid = 0;
            //string strErr = "";

            string strSQL = "select max(DocID) from dbo_Doctor_list";
            
            DataTable dtMaxDictorID = objData.RetriveData(strSQL, ref strErr);
            
            if (dtMaxDictorID.Rows.Count > 0)
            {
                if (dtMaxDictorID.Rows[0][0].ToString() != "")
                {
                    doctorid = Convert.ToInt32(dtMaxDictorID.Rows[0][0].ToString()) + 1;
                }
                else
                {
                    doctorid = 1;
                }
            }
            else
            {
                doctorid = 1;
            }

            txtdoctorsid.Text = doctorid.ToString();
        }

        private void FillGrdView( string p ="")
        {
            //throw new NotImplementedException();
            string strSQL = "select D.Title,D.Name,D.Degree,D.Phone,D.IsPc,D.Address,D.Area,D.Specialist	,case when D.Doctor_Type = 1 then 'Listed' when D.Doctor_Type = 2 then 'In House' when D.Doctor_Type = 3 then 'Out Source' end,D.DocID, E.Name  from dbo_Doctor_list D Left Join dbo_Designation Deg On D.MarketingBy = deg.DeptID left join dbo_Employee_Designation Ed On deg.DegId = ed.DegID	left join dbo_Employee_Profiles E On E.EmpID = ed.EmpID where D.Name like '%" + p + "%' or D.DocID like '%" + p + "%'  order by D.DocID desc";

            DataTable dtMaxDictorID = objData.RetriveData(strSQL, ref strErr);
            DataSet ds = new DataSet();
            ds.Tables.Add(dtMaxDictorID);
            dgvDoctorList.DataSource = ds.Tables["Table1"];

        }

        private void drDoctorType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            btnedit.Enabled = false;
            objData = new C_Data_Batch();
            objData.OpenConnection("sakhawat-pc", ref strErr);
            frmLoad();
            objData.CloseConnection();
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

        private void btnpreview_Click(object sender, EventArgs e)
        {

        }

        private void dgvDoctorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsave.Enabled = false;
            btnedit.Enabled = true;
            txttitle.Text = dgvDoctorList.CurrentRow.Cells[0].Value.ToString();
            txtdoctorname.Text = dgvDoctorList.CurrentRow.Cells[1].Value.ToString();
            txtdegree.Text = dgvDoctorList.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvDoctorList.CurrentRow.Cells[3].Value.ToString();
            if (dgvDoctorList.CurrentRow.Cells[4].Value.ToString() == "True")
            {
                chkbispc.Checked = true;
            }
            else
            {
                chkbispc.Checked = false;
            }
            txtAddress.Text = dgvDoctorList.CurrentRow.Cells[5].Value.ToString();
            txtArea.Text = dgvDoctorList.CurrentRow.Cells[6].Value.ToString();
            txtspecialist.Text = dgvDoctorList.CurrentRow.Cells[7].Value.ToString();
            drDoctorType.SelectedIndex = drDoctorType.FindStringExact(dgvDoctorList.CurrentRow.Cells[8].Value.ToString());
            txtdoctorsid.Text = dgvDoctorList.CurrentRow.Cells[9].Value.ToString();
            txtMarketingBy.Text = dgvDoctorList.CurrentRow.Cells[10].Value.ToString();
        }

        private void txtSearchEmp_TextChanged(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("sakhawat-pc", ref strErr);
            //string strSQL = "select Title,Name,Degree,Phone,IsPc,Address,Area,Specialist	,case when Doctor_Type = 1 then 'Listed' when Doctor_Type = 2 then 'In House' when Doctor_Type = 3 then 'Out Source' end,DocID  from dbo_Doctor_list where Name like '%" + txtSearchEmp.Text.ToString() + "%' or DocID like '%" + txtSearchEmp.Text.ToString() + "%'  order by DocID desc";

            //DataTable dtMaxDictorID = objData.RetriveData(strSQL, ref strErr);
            FillGrdView(txtSearchEmp.Text);
            objData.CloseConnection();
            //DataSet ds = new DataSet();
            //ds.Tables.Add(dtMaxDictorID);
            //dgvDoctorList.DataSource = ds.Tables["Table1"];
        }

        private void cmbMarktingOfficer_SelectedIndexChanged(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem itms = cmbMarktingOfficer.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            if (itms != null)
            {
                txtMarketingBy.Text = itms.Name.ToString();
            }
        }

        
    }
}
