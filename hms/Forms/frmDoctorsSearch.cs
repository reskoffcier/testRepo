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
    public partial class frmDoctorsSearch : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        private string strErr = "";
        public frmDoctorsSearch()
        {
            InitializeComponent();
            grdDoctorList.AllowUserToAddRows = false;
            grdDoctorList.AllowUserToDeleteRows = false;
            grdDoctorList.AllowUserToOrderColumns = false;
            LoadDoctorList();
            for (var index = 0; index < grdDoctorList.Columns.Count; index++)
            {
                grdDoctorList.AutoResizeColumn(index);
            }
            
        }

        private void LoadDoctorList(string searchText="")
        {
            objData.OpenConnection("AatickPC-Home", ref strErr);
            var sql = "USP_Doctor_Search '" + searchText + "'";
            var dtDoctors = objData.RetriveData(sql, ref strErr);
            objData.CloseConnection();
            grdDoctorList.DataSource = dtDoctors;
        }

        private void txtsearchcriteria_TextChanged(object sender, EventArgs e)
        {
            LoadDoctorList(txtsearchcriteria.Text);
        }

        private void frmDoctorsSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
