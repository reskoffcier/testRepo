using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hms.BLL
{
    class Doctor
    {
        string doctorId;

        public string DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }

        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        string doctorName;

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        string degree;

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        string doctype;

        public string Doctype
        {
            get { return doctype; }
            set { doctype = value; }
        }

        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        string isPC;
        
        public string IsPC
        {
            get { return isPC; }
            set 
            { isPC = value;

            if (Convert.ToBoolean(isPC))
                isPC = "1";
            }
        }

        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        string specialist;

        public string Specialist
        {
            get { return specialist; }
            set { specialist = value; }
        }

        string marketingBy;

        public string MarketingBy
        {
            get { return marketingBy; }
            set { marketingBy = value; }
        }

        string autoDiscount;

        public string AutoDiscount
        {
            get { return autoDiscount; }
            set { autoDiscount = value; }
        }
    }
}
