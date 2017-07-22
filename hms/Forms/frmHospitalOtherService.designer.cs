namespace hms.Forms
{
    partial class frmHospitalOtherService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAdmissionId = new System.Windows.Forms.Label();
            this.txtadmissionid = new System.Windows.Forms.TextBox();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.txtServiceInfo = new System.Windows.Forms.TextBox();
            this.lstserviceinfo = new System.Windows.Forms.ListBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txthead = new System.Windows.Forms.TextBox();
            this.lblhead = new System.Windows.Forms.Label();
            this.txtRmayCha = new System.Windows.Forms.TextBox();
            this.lblRmayCha = new System.Windows.Forms.Label();
            this.lblFixed = new System.Windows.Forms.Label();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblDatefor = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvOtherservice = new System.Windows.Forms.DataGridView();
            this.txtdatafor = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnGridDelete = new System.Windows.Forms.Button();
            this.txtfixed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherservice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.AutoSize = true;
            this.lblAdmissionId.Location = new System.Drawing.Point(169, 51);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(68, 13);
            this.lblAdmissionId.TabIndex = 0;
            this.lblAdmissionId.Text = "Admission ID";
            // 
            // txtadmissionid
            // 
            this.txtadmissionid.Enabled = false;
            this.txtadmissionid.Location = new System.Drawing.Point(247, 48);
            this.txtadmissionid.Name = "txtadmissionid";
            this.txtadmissionid.ReadOnly = true;
            this.txtadmissionid.Size = new System.Drawing.Size(220, 20);
            this.txtadmissionid.TabIndex = 1;
            this.txtadmissionid.TabStop = false;
            // 
            // btnAdmission
            // 
            this.btnAdmission.Location = new System.Drawing.Point(473, 46);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(24, 23);
            this.btnAdmission.TabIndex = 2;
            this.btnAdmission.TabStop = false;
            this.btnAdmission.Text = "....";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // txtServiceInfo
            // 
            this.txtServiceInfo.Location = new System.Drawing.Point(165, 74);
            this.txtServiceInfo.Name = "txtServiceInfo";
            this.txtServiceInfo.Size = new System.Drawing.Size(332, 20);
            this.txtServiceInfo.TabIndex = 1;
            this.txtServiceInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServiceInfo_KeyUp);
            // 
            // lstserviceinfo
            // 
            this.lstserviceinfo.FormattingEnabled = true;
            this.lstserviceinfo.Location = new System.Drawing.Point(165, 100);
            this.lstserviceinfo.Name = "lstserviceinfo";
            this.lstserviceinfo.Size = new System.Drawing.Size(332, 82);
            this.lstserviceinfo.TabIndex = 2;
            this.lstserviceinfo.Click += new System.EventHandler(this.lstserviceinfo_Click);
            this.lstserviceinfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstserviceinfo_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(162, 187);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(220, 186);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(76, 20);
            this.txtamount.TabIndex = 3;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // txthead
            // 
            this.txthead.Location = new System.Drawing.Point(220, 210);
            this.txthead.Name = "txthead";
            this.txthead.Size = new System.Drawing.Size(277, 20);
            this.txthead.TabIndex = 6;
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Location = new System.Drawing.Point(162, 213);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(33, 13);
            this.lblhead.TabIndex = 7;
            this.lblhead.Text = "Head";
            // 
            // txtRmayCha
            // 
            this.txtRmayCha.Location = new System.Drawing.Point(220, 235);
            this.txtRmayCha.Name = "txtRmayCha";
            this.txtRmayCha.Size = new System.Drawing.Size(277, 20);
            this.txtRmayCha.TabIndex = 7;
            // 
            // lblRmayCha
            // 
            this.lblRmayCha.AutoSize = true;
            this.lblRmayCha.Location = new System.Drawing.Point(162, 238);
            this.lblRmayCha.Name = "lblRmayCha";
            this.lblRmayCha.Size = new System.Drawing.Size(53, 13);
            this.lblRmayCha.TabIndex = 9;
            this.lblRmayCha.Text = "RmayCha";
            // 
            // lblFixed
            // 
            this.lblFixed.AutoSize = true;
            this.lblFixed.Location = new System.Drawing.Point(162, 263);
            this.lblFixed.Name = "lblFixed";
            this.lblFixed.Size = new System.Drawing.Size(32, 13);
            this.lblFixed.TabIndex = 11;
            this.lblFixed.Text = "Fixed";
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(220, 286);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(277, 20);
            this.txtremark.TabIndex = 14;
            this.txtremark.Text = "10";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(162, 289);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 13;
            this.lblRemark.Text = "Remark";
            // 
            // lblDatefor
            // 
            this.lblDatefor.AutoSize = true;
            this.lblDatefor.Location = new System.Drawing.Point(332, 263);
            this.lblDatefor.Name = "lblDatefor";
            this.lblDatefor.Size = new System.Drawing.Size(48, 13);
            this.lblDatefor.TabIndex = 15;
            this.lblDatefor.Text = "Data For";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(301, 187);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(20, 20);
            this.txtsl.TabIndex = 4;
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(654, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 30;
            this.btnclose.TabStop = false;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(552, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(31, 23);
            this.btnnew.TabIndex = 29;
            this.btnnew.TabStop = false;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(585, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(36, 22);
            this.btnsave.TabIndex = 27;
            this.btnsave.TabStop = false;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvOtherservice
            // 
            this.dgvOtherservice.AllowUserToAddRows = false;
            this.dgvOtherservice.AllowUserToDeleteRows = false;
            this.dgvOtherservice.AllowUserToResizeColumns = false;
            this.dgvOtherservice.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOtherservice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOtherservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherservice.Location = new System.Drawing.Point(12, 314);
            this.dgvOtherservice.MultiSelect = false;
            this.dgvOtherservice.Name = "dgvOtherservice";
            this.dgvOtherservice.ReadOnly = true;
            this.dgvOtherservice.Size = new System.Drawing.Size(677, 150);
            this.dgvOtherservice.TabIndex = 32;
            this.dgvOtherservice.Click += new System.EventHandler(this.dgvOtherservice_Click);
            // 
            // txtdatafor
            // 
            this.txtdatafor.Location = new System.Drawing.Point(380, 260);
            this.txtdatafor.Name = "txtdatafor";
            this.txtdatafor.Size = new System.Drawing.Size(117, 20);
            this.txtdatafor.TabIndex = 33;
            this.txtdatafor.Text = "9";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(337, 191);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(371, 187);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(123, 20);
            this.txtDate.TabIndex = 5;
            this.txtDate.Value = new System.DateTime(2016, 10, 26, 18, 59, 18, 0);
            // 
            // btnGridDelete
            // 
            this.btnGridDelete.Image = global::hms.Properties.Resources.DELETE;
            this.btnGridDelete.Location = new System.Drawing.Point(623, 2);
            this.btnGridDelete.Name = "btnGridDelete";
            this.btnGridDelete.Size = new System.Drawing.Size(30, 22);
            this.btnGridDelete.TabIndex = 70;
            this.btnGridDelete.TabStop = false;
            this.btnGridDelete.UseVisualStyleBackColor = true;
            this.btnGridDelete.Click += new System.EventHandler(this.btnGridDelete_Click);
            // 
            // txtfixed
            // 
            this.txtfixed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfixed.FormattingEnabled = true;
            this.txtfixed.Location = new System.Drawing.Point(220, 259);
            this.txtfixed.Name = "txtfixed";
            this.txtfixed.Size = new System.Drawing.Size(90, 21);
            this.txtfixed.TabIndex = 71;
            // 
            // frmHospitalOtherService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 475);
            this.Controls.Add(this.txtfixed);
            this.Controls.Add(this.btnGridDelete);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtdatafor);
            this.Controls.Add(this.dgvOtherservice);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.lblDatefor);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblFixed);
            this.Controls.Add(this.txtRmayCha);
            this.Controls.Add(this.lblRmayCha);
            this.Controls.Add(this.txthead);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lstserviceinfo);
            this.Controls.Add(this.txtServiceInfo);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.txtadmissionid);
            this.Controls.Add(this.lblAdmissionId);
            this.Name = "frmHospitalOtherService";
            this.Text = "frmHospitalOtherService";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherservice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmissionId;
        private System.Windows.Forms.TextBox txtadmissionid;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.TextBox txtServiceInfo;
        private System.Windows.Forms.ListBox lstserviceinfo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txthead;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.TextBox txtRmayCha;
        private System.Windows.Forms.Label lblRmayCha;
        private System.Windows.Forms.Label lblFixed;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblDatefor;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvOtherservice;
        private System.Windows.Forms.TextBox txtdatafor;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btnGridDelete;
        private System.Windows.Forms.ComboBox txtfixed;
    }
}