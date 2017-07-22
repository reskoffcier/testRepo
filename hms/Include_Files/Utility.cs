using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace hms.Include_Files
{
    class Utility
    {
        public static int userID = 1;
        public static int intVat = 0;
        public static string selectTestIds = "";
        public static string PathInvID = "";
        public static string PcName = Environment.MachineName;
        public static string UserName = "";
        public static bool IsDevelopment = true;
        public static double DCP = 0.0;

        public static string ReportPath = IsDevelopment
            ? (Application.StartupPath.ToLower().Replace("bin", "").Replace("debug", "").Replace("release", "") +
               @"\reports\").Replace(@"\\\", @"\").Replace(@"\\", @"\")
            : Application.StartupPath.ToLower()+@"\reports\";

        public class ComboboxItem
        {

            public string Name;
            public int Value;
            public ComboboxItem(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }




        public bool IsDate(string date)
        {

            try
            {

                DateTime dt = DateTime.Parse(date);

                return true;
            }

            catch
            {

                return false;

            }

        }


        public static void ClearAllControls(Form form, ArrayList controList = null)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    if (controList != null)
                    {
                        if (!controList.Contains(control.Name))
                            control.ResetText();
                    }
                    else
                    {
                        control.ResetText();
                    }
                }
                else if (control is RadioButton)
                {
                    if (controList != null)
                    {
                        if (!controList.Contains(control.Name))
                            ((RadioButton)control).Checked = false;
                    }
                    else
                    {
                        ((RadioButton)control).Checked = false;
                    }
                    
                }
                else if (control is RichTextBox)
                {
                    if (controList != null)
                    {
                        if (!controList.Contains(control.Name))
                            control.Text = "";
                    }
                    else
                    {
                        control.Text = "";
                    }
                }
                else if (control is CheckBox)
                {
                    if (controList != null)
                    {
                        if (!controList.Contains(control.Name))
                            ((CheckBox)control).Checked = false;
                    }
                    else
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
                else
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is TextBox)
                        {
                            if (controList != null)
                            {
                                if (!controList.Contains(subControl.Name))
                                    subControl.ResetText();
                            }
                            else
                            {
                                subControl.ResetText();
                            }
                        }
                        else if (subControl is RadioButton)
                        {
                            if (controList != null)
                            {
                                if (!controList.Contains(subControl.Name))
                                    ((RadioButton)subControl).Checked = false;
                            }
                            else
                            {
                                ((RadioButton)subControl).Checked = false;
                            }
                        }
                        else if (subControl is RichTextBox)
                        {
                            if (controList != null)
                            {
                                if (!controList.Contains(subControl.Name))
                                    subControl.Text = "";
                            }
                            else
                            {
                                subControl.Text = "";
                            }
                        }
                        else if (subControl is CheckBox)
                        {
                            if (controList != null)
                            {
                                if (!controList.Contains(subControl.Name))
                                    ((CheckBox)subControl).Checked = false;
                            }
                            else
                            {
                                ((CheckBox)subControl).Checked = false;
                            }
                        }
                    }
                }
            }
        }

        public static void AutoResizeColumns(ListView list)
        {
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            var arr = new ArrayList();
            for (var i = 0; i < list.Columns.Count; i++)
            {
                arr.Add(list.Columns[i].Width);
            }
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            for (var i = 0; i < list.Columns.Count; i++)
            {
                if (list.Columns[i].Width < int.Parse(arr[i].ToString()))
                {
                    list.Columns[i].Width = int.Parse(arr[i].ToString());
                }
            }
        }

        public static void Print(DataTable reportSource, string reportPath, int copies)
        {
            var report = new ReportDocument();
            report.Load(reportPath);
            report.SetDataSource(reportSource);
            var dialog = new PrintDialog { AllowSomePages = true, AllowPrintToFile = false };
            report.PrintOptions.PrinterName = dialog.PrinterSettings.PrinterName;
            report.PrintToPrinter(copies, true, 0, 0);
        }

        public static void Print(ReportDocument report, string reportPath, int copies)
        {
            var dialog = new PrintDialog { AllowSomePages = true, AllowPrintToFile = false };
            report.PrintOptions.PrinterName = dialog.PrinterSettings.PrinterName;
            report.PrintToPrinter(copies, true, 0, 0);
        }

        public static string  FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}
