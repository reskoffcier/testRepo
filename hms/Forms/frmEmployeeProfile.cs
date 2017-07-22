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
namespace hms.Forms
{
    public partial class frmEmployeeProfile : Form
    {
        C_Data_Batch objetdata;
        public frmEmployeeProfile()
        {
            InitializeComponent();
        }

        private void frmEmployeeProfile_Load(object sender, EventArgs e)
        {
            clearFields();
            getEmployeeID();
            
            fillDepartment();
            ShowdgvEmpprofile();
            
        }

        private void ShowdgvEmpprofile()
        {
            //throw new NotImplementedException();
            objetdata = new C_Data_Batch();
            string strErr = "";
            objetdata.OpenConnection("PolinPC-Office", ref strErr);
            //txtCategoryID
            string strSQL = "";
            strSQL = "select * from v_Emplopyee_Details order by EmpID Desc";
            DataTable arrCatList = objetdata.RetriveData(strSQL, ref strErr);
            objetdata.CloseConnection();
            DataSet ds = new DataSet();
            ds.Tables.Add(arrCatList);
            dgvEmpprofile.DataSource = ds.Tables["Table1"];


        }

        private void clearFields()
        {
            Include_Files.Utility.ClearAllControls(this);
            rtbPresentAddress.Text = "";
            txtParmanentAddress.Text = "";
            chkDoctor.Checked = false;
            chkIsCommession.Checked = false;
            chkParmanent.Checked = false;
            fillDepartment();
            cmbDesignation.Items.Clear();
            dateformateJoinDate();
            dateformateDateOfBirth();
            ShowdgvEmpprofile();

            
        }

        
        private void dateformateDateOfBirth()
        {
            //throw new NotImplementedException();
          
            dtpDateOfBirth.CustomFormat = "M/dd/yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            //dtpDateOfBirth.Text = DateTime.Today.Date();

        }

        private void fillDepartment()
        {
                   
            objetdata = new C_Data_Batch();
            string strErr = "";
            objetdata.OpenConnection("PolinPC-Office", ref strErr);
            string strSQL = "";
            strSQL = "select DeptID, Name from dbo_Department order by DeptID Desc ";
             DataTable arrDept = objetdata.RetriveData(strSQL, ref strErr);
             objetdata.CloseConnection();
            // DataSet ds = new DataSet();
            //ds.Tables.Add(arrDept);
            //dgvEmpprofile.DataSource = ds.Tables["Table1"];
             cmbDepartment.Items.Clear();
             if (arrDept.Rows.Count > 0)
             {
                 for (int i = 0; i < arrDept.Rows.Count; i++)
                 {
                     cmbDepartment.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrDept.Rows[i][1].ToString(), Convert.ToInt32(arrDept.Rows[i][0].ToString())));
                 }
             }
        }
        private void dateformateJoinDate()
        {
            dtpJoinDate.CustomFormat = "M/dd/yyyy";
            dtpJoinDate.Format = DateTimePickerFormat.Custom;
        }

        private void fillDesignation()
        {
            //throw new NotImplementedException();
            objetdata = new C_Data_Batch();
            string strErr = "";
            objetdata.OpenConnection("PolinPC-Office", ref strErr);
            string strSQL = "";
            hms.Include_Files.Utility.ComboboxItem itms = cmbDepartment.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            var DeptID = 0;
            if (itms != null)
            {
                DeptID = itms.Value;
                strSQL = "select DegId, Designation from dbo_Designation where DeptID= " + DeptID + " order by DeptID Desc ";
                DataTable arrDept = objetdata.RetriveData(strSQL, ref strErr);
                objetdata.CloseConnection();
                //DataSet ds = new DataSet();
                //ds.Tables.Add(arrDept);
                //dgvEmpprofile.DataSource = ds.Tables["Table1"];
                cmbDesignation.Items.Clear();
                if (arrDept.Rows.Count > 0)
                {
                    for (int i = 0; i < arrDept.Rows.Count; i++)
                    {
                        cmbDesignation.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrDept.Rows[i][1].ToString(), Convert.ToInt32(arrDept.Rows[i][0].ToString())));
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the Department");
            }
            
        }

        private void getEmployeeID()
        {
            //throw new NotImplementedException();
            string strErr = "";
            objetdata = new C_Data_Batch();
            string strSQL = "";
            strSQL = "select max(EmpID) from dbo_Employee_Profiles";
            objetdata.OpenConnection("PolinPC-Office", ref strErr);
            Int32 EmpID = 0;
            DataTable arrEmpID = objetdata.RetriveData(strSQL, ref strErr);

            if (arrEmpID.Rows.Count > 0)
            {
                if (arrEmpID.Rows[0][0].ToString() != "")
                {
                    EmpID = Convert.ToInt32(arrEmpID.Rows[0][0].ToString()) + 1;
                }
                else
                {
                    EmpID = 1;
                }
            }
            else
            {
                EmpID = 1;
            }

            txtEmpployeeID.Text = EmpID.ToString();

        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            frmDerpartmentSetup f = new frmDerpartmentSetup();
            f.Show();
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            frmDesignationSetup f = new frmDesignationSetup();
            f.Show();
        }

        private void chkDoctor_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(chkDoctor.Checked.ToString());
            if (chkDoctor.Checked.ToString() == "True")
            {
                txtDoctorId.ReadOnly = false;
            }
            else
            {
                txtDoctorId.ReadOnly = true;
            }

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDesignation();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void insertData()
        {
            //throw new NotImplementedException();
            objetdata = new C_Data_Batch();
            string strErr ="";
            
            hms.Include_Files.Utility.ComboboxItem Department = cmbDepartment.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            hms.Include_Files.Utility.ComboboxItem Designation = cmbDesignation.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            if(Department != null && Designation != null)
            {
                var ValDepartment = Department.Value.ToString();
                var ValDesignation = Designation.Value.ToString();

                //var DeptID = 0;

                objetdata.OpenConnection("PolinPC-Office", ref strErr);
                string strSQL = "";
                var Gender = "M";
                if (txtgender.Text.ToString() == "F")
                {
                    Gender = "F";
                }

                var IsCommession = 0;
                if (chkIsCommession.Checked == true)
                {
                    IsCommession = 1;
                }
                var isDoc = 0;
                if (chkDoctor.Checked == true)
                {
                    isDoc = 1;
                }

                var valDocID = 0;
                if (isDoc.ToString() == "1")
                {
                    valDocID = Convert.ToInt32(txtDoctorId.Text.ToString());
                }
                var isparmanent = 0;
                if (chkParmanent.Checked == true)
                {
                    isparmanent = 1;
                }

                strSQL = "Insert into dbo_Employee_Profiles ([Name],[PresentAddress],[Gender],[BloodGroup],";
                strSQL = strSQL + "[JoiningDate],[Phone],[DateOfBirth],[ParmanentAddress],[IsDoctor],[IsCommession],[IsEmployment],[FatherName],[MotherName], [DocID]) ";
                strSQL = strSQL + " values ('" + txtEmployeeName.Text.ToString() + "','" + rtbPresentAddress.Text + "','" + Gender + "','" + txtBloodGroup.Text + "',";
                strSQL = strSQL + "'" + dtpJoinDate.Text + "','" + txtMobileNo.Text + "','" + dtpDateOfBirth.Text + "',";
                strSQL = strSQL + "'" + txtParmanentAddress.Text + "'," + isDoc + "," + IsCommession + "," + isparmanent + ",'"+txtFatherName.Text+"','"+txtMotherName.Text+"', "+valDocID+")";

                objetdata.BeginTransaction(ref strErr);

                objetdata.ExecuteQuery(strSQL, ref strErr);

                if (strErr == "")
                {
                    strSQL = "Select Max(EmpID) From dbo_Employee_Profiles";
                    var arr = objetdata.RetriveData(strSQL, ref strErr);
                    var EmpId = 1;
                    if (arr.Rows[0][0].ToString() != "")
                    {
                        EmpId = Convert.ToInt32(arr.Rows[0][0].ToString());

                        strSQL = "Insert into dbo_Employee_Designation (EmpID, DegID)  values (" + EmpId.ToString() + ", " + ValDesignation + ")";
                        objetdata.ExecuteQuery(strSQL, ref strErr);
                        if (strErr == "")
                        {
                            strSQL = "Insert into dbo_Employee_Salary(EmpID, Basic, HouseRent, Medical, Others, InActive) ";
                            strSQL = strSQL + " Values("+EmpId.ToString()+", "+txtBasic.Text+", "+txthouse.Text+", "+txtmedical.Text+", "+txtother.Text+", 1)";
                            objetdata.ExecuteQuery(strSQL, ref strErr);
                            if (strErr == "")
                            {
                                objetdata.CommitTransaction(ref strErr);
                                 MessageBox.Show("Employe Insert succefully done.");
                                 clearFields();
                                 getEmployeeID();
                                 
                                 fillDepartment();
                                 ShowdgvEmpprofile();
                            }
                            else
                            {
                                objetdata.Rollback(ref strErr);
                                   MessageBox.Show("Employe Not Insert");
                            }
                        }
                        else
                        {
                            objetdata.Rollback(ref strErr);
                            MessageBox.Show("Employe Not Insert");
                    }
                        
                    }
                    else
                    {
                        objetdata.Rollback(ref strErr);
                    MessageBox.Show("Employe Not Insert");
                    }

                }
                else
                {
                    objetdata.Rollback(ref strErr);
                    MessageBox.Show("Employe Not Insert");
                }
            }
            else
            {
                MessageBox.Show("Please select Department or Designation");
            }

        }

        private void btnUpdDepartment_Click(object sender, EventArgs e)
        {
            fillDepartment();
         
        }

        private void btnUpdDesignation_Click(object sender, EventArgs e)
        {
            fillDesignation();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clearFields();
            getEmployeeID();

            fillDepartment();
            ShowdgvEmpprofile();
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

        private void dgvEmpprofile_Click(object sender, EventArgs e)
        {
            txtEmpployeeID.Text=dgvEmpprofile.CurrentRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvEmpprofile.CurrentRow.Cells[1].Value.ToString();
            rtbPresentAddress.Text = dgvEmpprofile.CurrentRow.Cells[2].Value.ToString();
            txtgender.Text = dgvEmpprofile.CurrentRow.Cells[3].Value.ToString();
            txtBloodGroup.Text = dgvEmpprofile.CurrentRow.Cells[4].Value.ToString();
            dtpJoinDate.Text = dgvEmpprofile.CurrentRow.Cells[5].Value.ToString();
            txtMobileNo.Text = dgvEmpprofile.CurrentRow.Cells[6].Value.ToString();
            dtpDateOfBirth.Text = dgvEmpprofile.CurrentRow.Cells[7].Value.ToString();
            txtParmanentAddress.Text = dgvEmpprofile.CurrentRow.Cells[8].Value.ToString();
            if (dgvEmpprofile.CurrentRow.Cells[9].Value.ToString() == "True")
            {
                chkDoctor.Checked=true;
            }
            else
            {
                chkDoctor.Checked = false;
            }
            if (dgvEmpprofile.CurrentRow.Cells[10].Value.ToString() == "True")
            {
                chkIsCommession.Checked = true;
            }
            else
            {
                chkIsCommession.Checked = false;
            }
            if (dgvEmpprofile.CurrentRow.Cells[11].Value.ToString() == "True")
            {
                chkParmanent.Checked = true;
            }
            else
            {
                chkParmanent.Checked = false;
            }
            txtFatherName.Text = dgvEmpprofile.CurrentRow.Cells[12].Value.ToString();
            txtMotherName.Text = dgvEmpprofile.CurrentRow.Cells[13].Value.ToString();
            if (dgvEmpprofile.CurrentRow.Cells[9].Value.ToString() == "True")
            {
                txtDoctorId.Text = dgvEmpprofile.CurrentRow.Cells[14].Value.ToString();
            }
            else
            {
                txtDoctorId.Text = "";
            }
            cmbDepartment.SelectedIndex = cmbDepartment.FindStringExact(dgvEmpprofile.CurrentRow.Cells[15].Value.ToString());
            cmbDesignation.SelectedIndex = cmbDesignation.FindStringExact(dgvEmpprofile.CurrentRow.Cells[16].Value.ToString());
            txtBasic.Text = dgvEmpprofile.CurrentRow.Cells[17].Value.ToString();
            txthouse.Text = dgvEmpprofile.CurrentRow.Cells[18].Value.ToString();
            txtmedical.Text = dgvEmpprofile.CurrentRow.Cells[19].Value.ToString();
            txtother.Text = dgvEmpprofile.CurrentRow.Cells[20].Value.ToString();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
     
    }
}
