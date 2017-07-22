namespace hms.Forms
{
    partial class frmPatientBedTransfer
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
            this.txtBedRate = new System.Windows.Forms.TextBox();
            this.txtbed = new System.Windows.Forms.TextBox();
            this.btnpatientlist = new System.Windows.Forms.Button();
            this.txtadmissionid = new System.Windows.Forms.TextBox();
            this.lblAdmissionId = new System.Windows.Forms.Label();
            this.lblNewBed = new System.Windows.Forms.Label();
            this.dgbpreviousbedinfo = new System.Windows.Forms.DataGridView();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lstBedInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgbpreviousbedinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBedRate
            // 
            this.txtBedRate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedRate.Location = new System.Drawing.Point(911, 48);
            this.txtBedRate.Name = "txtBedRate";
            this.txtBedRate.ReadOnly = true;
            this.txtBedRate.Size = new System.Drawing.Size(78, 21);
            this.txtBedRate.TabIndex = 50;
            // 
            // txtbed
            // 
            this.txtbed.BackColor = System.Drawing.SystemColors.Window;
            this.txtbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbed.Location = new System.Drawing.Point(3, 48);
            this.txtbed.Name = "txtbed";
            this.txtbed.Size = new System.Drawing.Size(902, 21);
            this.txtbed.TabIndex = 49;
            this.txtbed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbed_KeyUp);
            // 
            // btnpatientlist
            // 
            this.btnpatientlist.Location = new System.Drawing.Point(166, 4);
            this.btnpatientlist.Name = "btnpatientlist";
            this.btnpatientlist.Size = new System.Drawing.Size(24, 23);
            this.btnpatientlist.TabIndex = 54;
            this.btnpatientlist.Text = "....";
            this.btnpatientlist.UseVisualStyleBackColor = true;
            this.btnpatientlist.Click += new System.EventHandler(this.btnpatientlist_Click);
            // 
            // txtadmissionid
            // 
            this.txtadmissionid.Location = new System.Drawing.Point(78, 6);
            this.txtadmissionid.Name = "txtadmissionid";
            this.txtadmissionid.ReadOnly = true;
            this.txtadmissionid.Size = new System.Drawing.Size(84, 20);
            this.txtadmissionid.TabIndex = 53;
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.AutoSize = true;
            this.lblAdmissionId.Location = new System.Drawing.Point(0, 9);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(68, 13);
            this.lblAdmissionId.TabIndex = 52;
            this.lblAdmissionId.Text = "Admission ID";
            // 
            // lblNewBed
            // 
            this.lblNewBed.AutoSize = true;
            this.lblNewBed.Location = new System.Drawing.Point(2, 29);
            this.lblNewBed.Name = "lblNewBed";
            this.lblNewBed.Size = new System.Drawing.Size(51, 13);
            this.lblNewBed.TabIndex = 55;
            this.lblNewBed.Text = "New Bed";
            // 
            // dgbpreviousbedinfo
            // 
            this.dgbpreviousbedinfo.AllowUserToAddRows = false;
            this.dgbpreviousbedinfo.AllowUserToDeleteRows = false;
            this.dgbpreviousbedinfo.AllowUserToResizeColumns = false;
            this.dgbpreviousbedinfo.AllowUserToResizeRows = false;
            this.dgbpreviousbedinfo.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgbpreviousbedinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbpreviousbedinfo.Location = new System.Drawing.Point(606, 72);
            this.dgbpreviousbedinfo.MultiSelect = false;
            this.dgbpreviousbedinfo.Name = "dgbpreviousbedinfo";
            this.dgbpreviousbedinfo.ReadOnly = true;
            this.dgbpreviousbedinfo.RowHeadersVisible = false;
            this.dgbpreviousbedinfo.Size = new System.Drawing.Size(383, 272);
            this.dgbpreviousbedinfo.TabIndex = 56;
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(605, 367);
            this.txtremarks.Multiline = true;
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(384, 115);
            this.txtremarks.TabIndex = 57;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(605, 351);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 58;
            this.lblRemark.Text = "Remark";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(961, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 23);
            this.btnclose.TabIndex = 61;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(936, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(24, 23);
            this.btnsave.TabIndex = 60;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(911, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(24, 23);
            this.btnnew.TabIndex = 59;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lstBedInfo
            // 
            this.lstBedInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lstBedInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstBedInfo.FullRowSelect = true;
            this.lstBedInfo.GridLines = true;
            this.lstBedInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstBedInfo.HideSelection = false;
            this.lstBedInfo.Location = new System.Drawing.Point(3, 76);
            this.lstBedInfo.MultiSelect = false;
            this.lstBedInfo.Name = "lstBedInfo";
            this.lstBedInfo.Size = new System.Drawing.Size(597, 405);
            this.lstBedInfo.TabIndex = 62;
            this.lstBedInfo.UseCompatibleStateImageBehavior = false;
            this.lstBedInfo.View = System.Windows.Forms.View.Details;
            this.lstBedInfo.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstBedInfo_ColumnWidthChanging);
            this.lstBedInfo.Click += new System.EventHandler(this.lstBedInfo_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bed";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rent";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Note";
            // 
            // frmPatientBedTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 493);
            this.Controls.Add(this.lstBedInfo);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.dgbpreviousbedinfo);
            this.Controls.Add(this.lblNewBed);
            this.Controls.Add(this.btnpatientlist);
            this.Controls.Add(this.txtadmissionid);
            this.Controls.Add(this.lblAdmissionId);
            this.Controls.Add(this.txtBedRate);
            this.Controls.Add(this.txtbed);
            this.Name = "frmPatientBedTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Bed Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.dgbpreviousbedinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBedRate;
        private System.Windows.Forms.TextBox txtbed;
        private System.Windows.Forms.Button btnpatientlist;
        private System.Windows.Forms.TextBox txtadmissionid;
        private System.Windows.Forms.Label lblAdmissionId;
        private System.Windows.Forms.Label lblNewBed;
        private System.Windows.Forms.DataGridView dgbpreviousbedinfo;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ListView lstBedInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}