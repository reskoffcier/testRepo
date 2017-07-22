namespace hms.Forms
{
    partial class frmReportAll
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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstFirst);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 195);
            this.groupBox1.TabIndex = 4;
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
            this.dateTo.CustomFormat = "MM/dd/yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(6, 147);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(155, 20);
            this.dateTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "MM/dd/yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(7, 31);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(155, 20);
            this.dateFrom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.lstSecond);
            this.groupBox2.Location = new System.Drawing.Point(14, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Wise";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MM/dd/yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.lstSecond.Size = new System.Drawing.Size(278, 134);
            this.lstSecond.TabIndex = 0;
            this.lstSecond.DoubleClick += new System.EventHandler(this.lstSecond_DoubleClick);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(498, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(257, 186);
            this.listBox3.TabIndex = 7;
            this.listBox3.Visible = false;
            // 
            // frmReportAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox3);
            this.Name = "frmReportAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report All";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstFirst;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox lstSecond;
        private System.Windows.Forms.ListBox listBox3;
    }
}