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
    public partial class frmAdmitedPatientList : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        string OwnerName = "";

        public frmAdmitedPatientList()
        {
            InitializeComponent();
            LoadAll();
        }

        private void LoadAll()
        {
            lstPatientView.Columns.Add("SL");
            lstPatientView.Columns.Add("Patient Name");
            lstPatientView.Columns.Add("Admission ID");
            lstPatientView.Columns.Add("Patient ID");
            lstPatientView.Columns.Add("Bed Info");
            lstPatientView.Columns[2].Width = 0;
            lstPatientView.Columns[3].Width = 0;
            lstPatientView.Columns[0].Width = lstPatientView.Columns[1].Width = lstPatientView.Columns[4].Width = (lstPatientView.Width - 1) / 3;
            
            LoadList("");
        }
        public frmAdmitedPatientList(string ownerName)
        {
            InitializeComponent();
            this.OwnerName = ownerName;
            LoadAll();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText = txtSearch.Text;
            LoadList(searchText);
        }

        private void LoadList(string searchText)
        {
            var strErr = "";
            objData.OpenConnection("AatickPC-Office", ref strErr);
            var sqlSelectPatientList = "";
            //var sqlSelectPatientList = "USP_Get_AdmissionBasicInfo '" + searchText + "', 0";//"SELECT AD.Admission_Id ,AD.P_ID,PT.Name, CAST(AD.Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) Admission_SL FROM dbo_Admission AD INNER JOIN dbo_Patient_info PT ON PT.P_ID=AD.P_ID" + (searchText == "" ? "" : " WHERE PT.Name LIKE '%" + searchText + "%'");
            //this.OwnerName = this.Owner.Name;
            if (this.OwnerName == "frmHospitalDeposit" )
            {
                sqlSelectPatientList = "USP_Get_AdmissionBasicInfo '" + searchText + "', 0";//"SELECT AD.Admission_Id ,AD.P_ID,PT.Name, CAST(AD.Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) Admission_SL FROM dbo_Admission AD INNER JOIN dbo_Patient_info PT ON PT.P_ID=AD.P_ID" + (searchText == "" ? "" : " WHERE PT.Name LIKE '%" + searchText + "%'");
            }
            else
            {
            sqlSelectPatientList = "USP_Get_AdmissionBasicInfo '" + searchText + "', 1";//"SELECT AD.Admission_Id ,AD.P_ID,PT.Name, CAST(AD.Admission_SL AS VARCHAR(20))+'/'+CAST(Month(AD.CreatedOn) AS VARCHAR(20))+'/'+CAST(Year(AD.CreatedOn) AS VARCHAR(20)) Admission_SL FROM dbo_Admission AD INNER JOIN dbo_Patient_info PT ON PT.P_ID=AD.P_ID  WHERE (SELECT COUNT(1) FROM Patient_Bed WHERE Admission_id=AD.Admission_Id AND DischargeUserID IS NOT NULL)=0 " + (searchText == "" ? "" : " AND PT.Name LIKE '%" + searchText + "%'");
            }
            var dtSelectPatientList = objData.RetriveData(sqlSelectPatientList, ref strErr);
            if (strErr != "")
            {
                MessageBox.Show("An Error occured.\nTry again later.");
            }
            else
            {
                lstPatientView.Items.Clear();
                for (var i = 0; i < dtSelectPatientList.Rows.Count; i++)
                {
                    var listViewItems = new ListViewItem(dtSelectPatientList.Rows[i][3].ToString());
                    listViewItems.SubItems.Add(dtSelectPatientList.Rows[i][2].ToString());
                    listViewItems.SubItems.Add(dtSelectPatientList.Rows[i][0].ToString());
                    listViewItems.SubItems.Add(dtSelectPatientList.Rows[i][1].ToString());
                    listViewItems.SubItems.Add(dtSelectPatientList.Rows[i][4].ToString());
                    lstPatientView.Items.Add(listViewItems);
                }
            }
            objData.CloseConnection();
        }

        private void listPatient_DoubleClick(object sender, EventArgs e)
        {
            //var parent = ((frmHopitalAdmissionFront)this.Owner);
            //parent.LoadPatientInfo(listPatient.SelectedValue.ToString().Split('#')[0], listPatient.SelectedValue.ToString().Split('#')[1]);
            //this.Close();
        }

        private void lstPatientView_DoubleClick(object sender, EventArgs e)
        {
            var name = this.Owner.Name;
            if (name == "frmHopitalAdmissionFront")
            {
                var parent = ((frmHopitalAdmissionFront)this.Owner);
                parent.LoadPatientInfo(lstPatientView.SelectedItems[0].SubItems[2].Text,
                    lstPatientView.SelectedItems[0].SubItems[3].Text);
            }
            else if (name == "frmConsultantVisit")
            {
                var parent = ((frmConsultantVisit)this.Owner);
                parent.LoadPatientInfo(lstPatientView.SelectedItems[0].SubItems[2].Text,
                    lstPatientView.SelectedItems[0].SubItems[3].Text, lstPatientView.SelectedItems[0].SubItems[0].Text);
            }
            else if (name == "frmHospitalOtherService")
            {
                var parent = ((frmHospitalOtherService)this.Owner);
                parent.LoadAdmissionInfo(lstPatientView.SelectedItems[0].SubItems[0].Text, lstPatientView.SelectedItems[0].SubItems[2].Text);
            }
            else if (name == "frmPatientBedTransfer")
            {
                var parent = ((frmPatientBedTransfer)this.Owner);
                parent.LoadAdmissionInfo(lstPatientView.SelectedItems[0].SubItems[0].Text, lstPatientView.SelectedItems[0].SubItems[2].Text);
            }

            else if (name == "frmHospitalDischargeFornt")
            {
                var parent = ((frmHospitalDischargeFornt)this.Owner);
                parent.LoadAdmissionInfo(lstPatientView.SelectedItems[0].SubItems[0].Text, lstPatientView.SelectedItems[0].SubItems[2].Text);
            }
            else if (name == "frmHospitalDeposit")
            {
                var parent = ((frmHospitalDeposit)this.Owner);
                parent.LoadAdmissionInfo(lstPatientView.SelectedItems[0].SubItems[0].Text, lstPatientView.SelectedItems[0].SubItems[2].Text);
            }
            else if (name == "frmPatientBill")
            {
                var parent = ((frmPatientBill)this.Owner);
                parent.LoadAdmissionInfo(lstPatientView.SelectedItems[0].SubItems[0].Text, lstPatientView.SelectedItems[0].SubItems[2].Text);
            }
            else if (name == "frmfrontdeskinvestigation")
            {
                var parent = ((frmfrontdeskinvestigation)this.Owner);
                parent.LoadAdmissionInfo(lstPatientView.SelectedItems[0].SubItems[0].Text, lstPatientView.SelectedItems[0].SubItems[2].Text);
            }
            this.Close();
        }
    }
}
