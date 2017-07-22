namespace hms.Forms
{
    partial class frmHospitalReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstFirst = new System.Windows.Forms.ListBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lstSecond = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShow_bill = new System.Windows.Forms.Button();
            this.btnShow_ad = new System.Windows.Forms.Button();
            this.txtAdmissionId_bill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadmissionId_ad = new System.Windows.Forms.TextBox();
            this.lbladmissionfrm = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstFirst);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date To Date";
            // 
            // lstFirst
            // 
            this.lstFirst.FormattingEnabled = true;
            this.lstFirst.Location = new System.Drawing.Point(190, 20);
            this.lstFirst.Name = "lstFirst";
            this.lstFirst.Size = new System.Drawing.Size(278, 160);
            this.lstFirst.TabIndex = 2;
            this.lstFirst.DoubleClick += new System.EventHandler(this.lstFirst_DoubleClick);
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(6, 147);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(155, 20);
            this.dateTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(7, 31);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(155, 20);
            this.dateFrom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.lstSecond);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Wise";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(7, 40);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(155, 20);
            this.datePicker.TabIndex = 2;
            // 
            // lstSecond
            // 
            this.lstSecond.FormattingEnabled = true;
            this.lstSecond.Location = new System.Drawing.Point(190, 18);
            this.lstSecond.Name = "lstSecond";
            this.lstSecond.Size = new System.Drawing.Size(278, 69);
            this.lstSecond.TabIndex = 0;
            this.lstSecond.DoubleClick += new System.EventHandler(this.lstSecond_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShow_bill);
            this.groupBox3.Controls.Add(this.btnShow_ad);
            this.groupBox3.Controls.Add(this.txtAdmissionId_bill);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtadmissionId_ad);
            this.groupBox3.Controls.Add(this.lbladmissionfrm);
            this.groupBox3.Location = new System.Drawing.Point(529, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Admission Patient Form and Hospital Bill ";
            // 
            // btnShow_bill
            // 
            this.btnShow_bill.Location = new System.Drawing.Point(203, 42);
            this.btnShow_bill.Name = "btnShow_bill";
            this.btnShow_bill.Size = new System.Drawing.Size(62, 23);
            this.btnShow_bill.TabIndex = 5;
            this.btnShow_bill.Text = "show";
            this.btnShow_bill.UseVisualStyleBackColor = true;
            this.btnShow_bill.Click += new System.EventHandler(this.btnShow_bill_Click);
            // 
            // btnShow_ad
            // 
            this.btnShow_ad.Location = new System.Drawing.Point(203, 17);
            this.btnShow_ad.Name = "btnShow_ad";
            this.btnShow_ad.Size = new System.Drawing.Size(62, 23);
            this.btnShow_ad.TabIndex = 4;
            this.btnShow_ad.Text = "show";
            this.btnShow_ad.UseVisualStyleBackColor = true;
            this.btnShow_ad.Click += new System.EventHandler(this.btnShow_ad_Click);
            // 
            // txtAdmissionId_bill
            // 
            this.txtAdmissionId_bill.Location = new System.Drawing.Point(93, 44);
            this.txtAdmissionId_bill.Name = "txtAdmissionId_bill";
            this.txtAdmissionId_bill.Size = new System.Drawing.Size(104, 20);
            this.txtAdmissionId_bill.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital Bill";
            // 
            // txtadmissionId_ad
            // 
            this.txtadmissionId_ad.Location = new System.Drawing.Point(93, 17);
            this.txtadmissionId_ad.Name = "txtadmissionId_ad";
            this.txtadmissionId_ad.Size = new System.Drawing.Size(104, 20);
            this.txtadmissionId_ad.TabIndex = 1;
            // 
            // lbladmissionfrm
            // 
            this.lbladmissionfrm.AutoSize = true;
            this.lbladmissionfrm.Location = new System.Drawing.Point(7, 20);
            this.lbladmissionfrm.Name = "lbladmissionfrm";
            this.lbladmissionfrm.Size = new System.Drawing.Size(80, 13);
            this.lbladmissionfrm.TabIndex = 0;
            this.lbladmissionfrm.Text = "Admission Form";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(539, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(257, 186);
            this.listBox3.TabIndex = 3;
            this.listBox3.Visible = false;
            // 
            // frmHospitalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 369);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHospitalReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAdmissionId_bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadmissionId_ad;
        private System.Windows.Forms.Label lbladmissionfrm;
        private System.Windows.Forms.Button btnShow_bill;
        private System.Windows.Forms.Button btnShow_ad;
        private System.Windows.Forms.ListBox lstFirst;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox lstSecond;
        private System.Windows.Forms.ListBox listBox3;
    }
}