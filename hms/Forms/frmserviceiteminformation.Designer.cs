namespace hms.Forms
{
    partial class frmserviceiteminformation
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
            this.lblserviceid = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblcatagoryid = new System.Windows.Forms.Label();
            this.txtcatagory = new System.Windows.Forms.TextBox();
            this.txtservicecharge = new System.Windows.Forms.TextBox();
            this.lblservicecharge = new System.Windows.Forms.Label();
            this.txtservicename = new System.Windows.Forms.TextBox();
            this.lblservicename = new System.Windows.Forms.Label();
            this.txtcommistion = new System.Windows.Forms.TextBox();
            this.lblcommision = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblduration = new System.Windows.Forms.Label();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.lblPC = new System.Windows.Forms.Label();
            this.dgvServcieInformation = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbDurationType = new System.Windows.Forms.ComboBox();
            this.cmbCommission = new System.Windows.Forms.ComboBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.chkSample = new System.Windows.Forms.CheckBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServcieInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblserviceid
            // 
            this.lblserviceid.AutoSize = true;
            this.lblserviceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserviceid.Location = new System.Drawing.Point(15, 29);
            this.lblserviceid.Name = "lblserviceid";
            this.lblserviceid.Size = new System.Drawing.Size(67, 13);
            this.lblserviceid.TabIndex = 0;
            this.lblserviceid.Text = "Service ID";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(108, 26);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(57, 20);
            this.txtServiceID.TabIndex = 1;
            // 
            // lblcatagoryid
            // 
            this.lblcatagoryid.AutoSize = true;
            this.lblcatagoryid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatagoryid.Location = new System.Drawing.Point(15, 49);
            this.lblcatagoryid.Name = "lblcatagoryid";
            this.lblcatagoryid.Size = new System.Drawing.Size(74, 13);
            this.lblcatagoryid.TabIndex = 2;
            this.lblcatagoryid.Text = "Catagory ID";
            // 
            // txtcatagory
            // 
            this.txtcatagory.Location = new System.Drawing.Point(108, 49);
            this.txtcatagory.Name = "txtcatagory";
            this.txtcatagory.ReadOnly = true;
            this.txtcatagory.Size = new System.Drawing.Size(57, 20);
            this.txtcatagory.TabIndex = 3;
            // 
            // txtservicecharge
            // 
            this.txtservicecharge.Location = new System.Drawing.Point(106, 133);
            this.txtservicecharge.Name = "txtservicecharge";
            this.txtservicecharge.Size = new System.Drawing.Size(72, 20);
            this.txtservicecharge.TabIndex = 7;
            // 
            // lblservicecharge
            // 
            this.lblservicecharge.AutoSize = true;
            this.lblservicecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicecharge.Location = new System.Drawing.Point(12, 135);
            this.lblservicecharge.Name = "lblservicecharge";
            this.lblservicecharge.Size = new System.Drawing.Size(94, 13);
            this.lblservicecharge.TabIndex = 6;
            this.lblservicecharge.Text = "Service Charge";
            // 
            // txtservicename
            // 
            this.txtservicename.Location = new System.Drawing.Point(108, 74);
            this.txtservicename.Name = "txtservicename";
            this.txtservicename.Size = new System.Drawing.Size(280, 20);
            this.txtservicename.TabIndex = 5;
            // 
            // lblservicename
            // 
            this.lblservicename.AutoSize = true;
            this.lblservicename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicename.Location = new System.Drawing.Point(15, 74);
            this.lblservicename.Name = "lblservicename";
            this.lblservicename.Size = new System.Drawing.Size(39, 13);
            this.lblservicename.TabIndex = 4;
            this.lblservicename.Text = "Name";
            // 
            // txtcommistion
            // 
            this.txtcommistion.Location = new System.Drawing.Point(105, 162);
            this.txtcommistion.Name = "txtcommistion";
            this.txtcommistion.Size = new System.Drawing.Size(72, 20);
            this.txtcommistion.TabIndex = 11;
            // 
            // lblcommision
            // 
            this.lblcommision.AutoSize = true;
            this.lblcommision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcommision.Location = new System.Drawing.Point(12, 162);
            this.lblcommision.Name = "lblcommision";
            this.lblcommision.Size = new System.Drawing.Size(66, 13);
            this.lblcommision.TabIndex = 10;
            this.lblcommision.Text = "Commision";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(238, 133);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(71, 20);
            this.txtDuration.TabIndex = 15;
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.Location = new System.Drawing.Point(184, 136);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(55, 13);
            this.lblduration.TabIndex = 14;
            this.lblduration.Text = "Duration";
            // 
            // txtpc
            // 
            this.txtpc.Location = new System.Drawing.Point(105, 185);
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(72, 20);
            this.txtpc.TabIndex = 13;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.Location = new System.Drawing.Point(15, 185);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(45, 13);
            this.lblPC.TabIndex = 12;
            this.lblPC.Text = "PC/CC";
            // 
            // dgvServcieInformation
            // 
            this.dgvServcieInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServcieInformation.Location = new System.Drawing.Point(403, 49);
            this.dgvServcieInformation.Name = "dgvServcieInformation";
            this.dgvServcieInformation.Size = new System.Drawing.Size(461, 406);
            this.dgvServcieInformation.TabIndex = 18;
            this.dgvServcieInformation.Click += new System.EventHandler(this.dgvServcieInformation_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::hms.Properties.Resources.Edit;
            this.btnedit.Location = new System.Drawing.Point(271, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(38, 23);
            this.btnedit.TabIndex = 20;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(309, 4);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(40, 23);
            this.btnpreview.TabIndex = 21;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(344, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 23);
            this.btnclose.TabIndex = 23;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(461, 20);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(172, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(216, 21);
            this.cmbCategory.TabIndex = 25;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCategory_KeyUp);
            // 
            // cmbDurationType
            // 
            this.cmbDurationType.FormattingEnabled = true;
            this.cmbDurationType.Location = new System.Drawing.Point(316, 133);
            this.cmbDurationType.Name = "cmbDurationType";
            this.cmbDurationType.Size = new System.Drawing.Size(70, 21);
            this.cmbDurationType.TabIndex = 26;
            // 
            // cmbCommission
            // 
            this.cmbCommission.FormattingEnabled = true;
            this.cmbCommission.Location = new System.Drawing.Point(194, 161);
            this.cmbCommission.Name = "cmbCommission";
            this.cmbCommission.Size = new System.Drawing.Size(52, 21);
            this.cmbCommission.TabIndex = 27;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSample.Location = new System.Drawing.Point(12, 100);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(56, 15);
            this.lblSample.TabIndex = 28;
            this.lblSample.Text = "Sample";
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(129, 100);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(259, 20);
            this.txtSample.TabIndex = 29;
            // 
            // chkSample
            // 
            this.chkSample.AutoSize = true;
            this.chkSample.Location = new System.Drawing.Point(108, 103);
            this.chkSample.Name = "chkSample";
            this.chkSample.Size = new System.Drawing.Size(15, 14);
            this.chkSample.TabIndex = 30;
            this.chkSample.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(194, 4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(38, 23);
            this.btnnew.TabIndex = 22;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(231, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(40, 23);
            this.btnsave.TabIndex = 19;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmserviceiteminformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 467);
            this.Controls.Add(this.chkSample);
            this.Controls.Add(this.txtSample);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.cmbCommission);
            this.Controls.Add(this.cmbDurationType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvServcieInformation);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.txtpc);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.txtcommistion);
            this.Controls.Add(this.lblcommision);
            this.Controls.Add(this.txtservicecharge);
            this.Controls.Add(this.lblservicecharge);
            this.Controls.Add(this.txtservicename);
            this.Controls.Add(this.lblservicename);
            this.Controls.Add(this.txtcatagory);
            this.Controls.Add(this.lblcatagoryid);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lblserviceid);
            this.Name = "frmserviceiteminformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Item Information";
            this.Load += new System.EventHandler(this.frmserviceiteminformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServcieInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserviceid;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblcatagoryid;
        private System.Windows.Forms.TextBox txtcatagory;
        private System.Windows.Forms.TextBox txtservicecharge;
        private System.Windows.Forms.Label lblservicecharge;
        private System.Windows.Forms.TextBox txtservicename;
        private System.Windows.Forms.Label lblservicename;
        private System.Windows.Forms.TextBox txtcommistion;
        private System.Windows.Forms.Label lblcommision;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.DataGridView dgvServcieInformation;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbDurationType;
        private System.Windows.Forms.ComboBox cmbCommission;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.CheckBox chkSample;
    }
}