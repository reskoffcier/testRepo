namespace hms.Forms
{
    partial class frmInvestigationSearchEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateRange = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblto = new System.Windows.Forms.Label();
            this.dtenddate = new System.Windows.Forms.DateTimePicker();
            this.lstdocinformation = new System.Windows.Forms.ListBox();
            this.lblDocInformation = new System.Windows.Forms.Label();
            this.lblinvestigationID = new System.Windows.Forms.Label();
            this.txtInvestigationID = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtday = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.lstInvestigationList = new System.Windows.Forms.ListView();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.Location = new System.Drawing.Point(13, 2);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(75, 13);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "Date Range";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(12, 16);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(76, 18);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(88, 19);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(20, 13);
            this.lblto.TabIndex = 2;
            this.lblto.Text = "To";
            // 
            // dtenddate
            // 
            this.dtenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtenddate.Location = new System.Drawing.Point(106, 16);
            this.dtenddate.Name = "dtenddate";
            this.dtenddate.Size = new System.Drawing.Size(71, 18);
            this.dtenddate.TabIndex = 3;
            this.dtenddate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lstdocinformation
            // 
            this.lstdocinformation.FormattingEnabled = true;
            this.lstdocinformation.Location = new System.Drawing.Point(13, 50);
            this.lstdocinformation.Name = "lstdocinformation";
            this.lstdocinformation.Size = new System.Drawing.Size(164, 30);
            this.lstdocinformation.TabIndex = 4;
            // 
            // lblDocInformation
            // 
            this.lblDocInformation.AutoSize = true;
            this.lblDocInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocInformation.Location = new System.Drawing.Point(10, 34);
            this.lblDocInformation.Name = "lblDocInformation";
            this.lblDocInformation.Size = new System.Drawing.Size(118, 13);
            this.lblDocInformation.TabIndex = 5;
            this.lblDocInformation.Text = "Doctors Information";
            // 
            // lblinvestigationID
            // 
            this.lblinvestigationID.AutoSize = true;
            this.lblinvestigationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvestigationID.Location = new System.Drawing.Point(11, 83);
            this.lblinvestigationID.Name = "lblinvestigationID";
            this.lblinvestigationID.Size = new System.Drawing.Size(97, 13);
            this.lblinvestigationID.TabIndex = 6;
            this.lblinvestigationID.Text = "Investigation ID";
            // 
            // txtInvestigationID
            // 
            this.txtInvestigationID.Location = new System.Drawing.Point(12, 99);
            this.txtInvestigationID.Name = "txtInvestigationID";
            this.txtInvestigationID.Size = new System.Drawing.Size(165, 20);
            this.txtInvestigationID.TabIndex = 7;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(763, 127);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(46, 20);
            this.txtsex.TabIndex = 77;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(733, 131);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(25, 13);
            this.lblsex.TabIndex = 76;
            this.lblsex.Text = "Sex";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(668, 128);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(30, 20);
            this.txtmonth.TabIndex = 75;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(636, 128);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(31, 20);
            this.txtyear.TabIndex = 74;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(589, 128);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 73;
            this.lblage.Text = "Age";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(636, 104);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(210, 20);
            this.txtphone.TabIndex = 72;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(592, 107);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(41, 13);
            this.lblphone.TabIndex = 71;
            this.lblphone.Text = "Phone:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(636, 34);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(210, 67);
            this.txtaddress.TabIndex = 70;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(590, 66);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(48, 13);
            this.lbladdress.TabIndex = 69;
            this.lbladdress.Text = "Address:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(636, 13);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 20);
            this.txtname.TabIndex = 68;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(592, 13);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 67;
            this.lblname.Text = "Neme:";
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(700, 128);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(30, 20);
            this.txtday.TabIndex = 78;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(106, 123);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(32, 23);
            this.btnsave.TabIndex = 79;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnfind
            // 
            this.btnfind.Image = global::hms.Properties.Resources.Search;
            this.btnfind.Location = new System.Drawing.Point(138, 123);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(37, 23);
            this.btnfind.TabIndex = 80;
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // lstInvestigationList
            // 
            this.lstInvestigationList.FullRowSelect = true;
            this.lstInvestigationList.GridLines = true;
            this.lstInvestigationList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstInvestigationList.HideSelection = false;
            this.lstInvestigationList.Location = new System.Drawing.Point(186, 4);
            this.lstInvestigationList.MultiSelect = false;
            this.lstInvestigationList.Name = "lstInvestigationList";
            this.lstInvestigationList.Size = new System.Drawing.Size(401, 120);
            this.lstInvestigationList.TabIndex = 81;
            this.lstInvestigationList.UseCompatibleStateImageBehavior = false;
            this.lstInvestigationList.View = System.Windows.Forms.View.Details;
            this.lstInvestigationList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstInvestigationList_ColumnWidthChanging);
            this.lstInvestigationList.SelectedIndexChanged += new System.EventHandler(this.lstInvestigationList_SelectedIndexChanged);
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(-2, 152);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(861, 321);
            this.crViewer.TabIndex = 82;
            // 
            // frmInvestigationSearchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 476);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.lstInvestigationList);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtInvestigationID);
            this.Controls.Add(this.lblinvestigationID);
            this.Controls.Add(this.lblDocInformation);
            this.Controls.Add(this.lstdocinformation);
            this.Controls.Add(this.dtenddate);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.lblDateRange);
            this.Name = "frmInvestigationSearchEdit";
            this.Text = "frmInvestigationSearchEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.DateTimePicker dtenddate;
        private System.Windows.Forms.ListBox lstdocinformation;
        private System.Windows.Forms.Label lblDocInformation;
        private System.Windows.Forms.Label lblinvestigationID;
        private System.Windows.Forms.TextBox txtInvestigationID;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.ListView lstInvestigationList;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}