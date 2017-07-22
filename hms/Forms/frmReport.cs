using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace hms.Forms
{
    public partial class frmReport : Form
    {
        public ReportDocument ReportDoc = new ReportDocument();
        public string ReportPath;
        public DataSet Reportds = new DataSet();
        public int isLoad = 0;
        
        public frmReport(ReportDocument report)
        {
            InitializeComponent();
            isLoad = 0;
            crvViewer.ReportSource = report;
        }


        public frmReport()
        {
            InitializeComponent();
            isLoad = 1;
            
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (isLoad == 1)
            {
                ReportDoc.Load(ReportPath);
                ReportDoc.SetDataSource(Reportds.Tables[0]);
                crvViewer.ReportSource = ReportDoc;
            }
        }

        

        
    }
}
