using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
using hms.Forms;
using hms.Include_Files;

namespace hms.Forms
{
    public partial class frmlogin : Form
    {
        C_Data_Batch objData = new C_Data_Batch();
        public string strErr = "";
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Include_Files.Utility.PcName);
            login();
            
        }

        private void login()
        {
            //throw new NotImplementedException();
            //string strErr = "";
            var userName = txtusername.Text.ToString();
            var password = txtpasword.Text.ToString();
            if (userName.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Please enter the user name and password.");
            }
            else
            {

                objData.OpenConnection("PolinPC-Office", ref strErr);
                //txtCategoryID
                string strSQL = "";
                strSQL = "select Name, User_ID from dbo_Users where USER_Name='" + txtusername.Text.ToString() + "' and  Password='" + txtpasword.Text.ToString() + "'  ";// +txtCategoryID.Text.ToString();
                DataTable arr = objData.RetriveData(strSQL, ref strErr);
                objData.CloseConnection();
                if (strErr != "")
                {
                    MessageBox.Show("Error.");
                }
                else
                {
                    if (arr.Rows.Count > 0)
                    {
                        Utility.userID = Convert.ToInt16(arr.Rows[0][1].ToString());
                        Utility.UserName = arr.Rows[0][0].ToString();
                        double.TryParse(ConfigurationManager.AppSettings["DCP"].Trim(), out Utility.DCP);
                        new frmmainfrom().Show(); 
                        Hide();


                    }
                    else
                    {
                        MessageBox.Show("Login Failed.");
                    }
                }
            }
        }

        private void txtpasword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtpasword.Focus();
            }
        }
    }
}
