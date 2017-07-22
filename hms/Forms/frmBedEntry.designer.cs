namespace hms.Forms
{
    partial class frmBedEntry
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
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBINumber = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstBedInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lstBedInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpreview
            // 
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(586, 55);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(24, 23);
            this.btnpreview.TabIndex = 23;
            this.btnpreview.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(613, 55);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 23);
            this.btnclose.TabIndex = 22;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::hms.Properties.Resources.Edit;
            this.btnedit.Location = new System.Drawing.Point(556, 55);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(24, 23);
            this.btnedit.TabIndex = 19;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::hms.Properties.Resources.SAVE;
            this.btnSave.Location = new System.Drawing.Point(526, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(496, 55);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(24, 23);
            this.btnnew.TabIndex = 17;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bed Setup";
            // 
            // txtBINumber
            // 
            this.txtBINumber.Location = new System.Drawing.Point(180, 134);
            this.txtBINumber.MaxLength = 150;
            this.txtBINumber.Name = "txtBINumber";
            this.txtBINumber.Size = new System.Drawing.Size(290, 20);
            this.txtBINumber.TabIndex = 15;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(90, 138);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(66, 13);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Bed Number";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(180, 73);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 13;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(90, 77);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(16, 13);
            this.lblCategoryID.TabIndex = 12;
            this.lblCategoryID.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(180, 164);
            this.txtRate.MaxLength = 150;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(290, 20);
            this.txtRate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(180, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 13;
            // 
            // lstBedInfo
            // 
            this.lstBedInfo.AllowUserToAddRows = false;
            this.lstBedInfo.AllowUserToDeleteRows = false;
            this.lstBedInfo.AllowUserToOrderColumns = true;
            this.lstBedInfo.AllowUserToResizeColumns = false;
            this.lstBedInfo.AllowUserToResizeRows = false;
            this.lstBedInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstBedInfo.Location = new System.Drawing.Point(13, 203);
            this.lstBedInfo.Name = "lstBedInfo";
            this.lstBedInfo.Size = new System.Drawing.Size(708, 290);
            this.lstBedInfo.TabIndex = 24;
            this.lstBedInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstBedInfo_CellClick);
            // 
            // frmBedEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 505);
            this.Controls.Add(this.lstBedInfo);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtBINumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCategoryID);
            this.Name = "frmBedEntry";
            this.Text = "frmBedEntry";
            ((System.ComponentModel.ISupportInitialize)(this.lstBedInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBINumber;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView lstBedInfo;

    }
}