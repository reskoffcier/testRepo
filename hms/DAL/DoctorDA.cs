using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hms.BLL;
using BatchDLL;
using System.Data;
using System.Windows.Forms;
namespace hms.DAL
{
    class DoctorDA
    {
        C_Data_Batch objData;
        public bool SaveDoctorInfo(Doctor objDoctor)
        {
            string strErr = "";
            objData = new C_Data_Batch();
            objData.OpenConnection("PolinPC-Office", ref strErr);
            string sql = "Insert into dbo_Doctor_list(Title,DocID,Name,Degree,Doctype,Phone,IsPc,Address,Area,Specialist,MarketingBy)";
            sql = sql + " values('"+objDoctor.Title+"','"+objDoctor.DoctorId+"','"+objDoctor.DoctorName+"','"+objDoctor.Degree+"'";
            sql = sql + " ,'" + objDoctor.Doctype + "','" + objDoctor.Phone + "'," + objDoctor.IsPC + ",'" + objDoctor.Address + "'";
            sql = sql + " ,'" + objDoctor.Area + "','" + objDoctor.Specialist + "'," + objDoctor.MarketingBy+")";
            
            objData.ExecuteQuery(sql,ref strErr);
            objData.CloseConnection();
            //objData = null;
            if (strErr == "")
            {
                MessageBox.Show("Succefully Insert into Doctor List");
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public int getDoctorId()
        {
            int doctorid = 0;
            string strErr = "";

            string strSQL = "select max(DocID) from dbo_Doctor_list";
            objData = new C_Data_Batch();
            objData.OpenConnection("PolinPC-Office", ref strErr);
            DataTable dtMaxDictorID = objData.RetriveData(strSQL, ref strErr);
            //string[,]  arrMaxDictorID = objData.RetriveDataArray(strSQL, ref strErr);
            objData.CloseConnection();
            if (dtMaxDictorID.Rows.Count>0)
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

            return doctorid;
        }
    }
}
 