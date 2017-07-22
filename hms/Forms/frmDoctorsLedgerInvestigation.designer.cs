namespace hms.Forms
{
    partial class frmDoctorsLedgerInvestigation
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
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.txtpayableamount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lblDoctorId
            // 
            this.lblDoctorId.AutoSize = true;
            this.lblDoctorId.Location = new System.Drawing.Point(15, 39);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(51, 13);
            this.lblDoctorId.TabIndex = 0;
            this.lblDoctorId.Text = "Doctor Id";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(68, 38);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(65, 20);
            this.txtDoctorId.TabIndex = 1;
            this.txtDoctorId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorId_KeyPress);
            // 
            // txtpayableamount
            // 
            this.txtpayableamount.Location = new System.Drawing.Point(230, 38);
            this.txtpayableamount.Name = "txtpayableamount";
            this.txtpayableamount.ReadOnly = true;
            this.txtpayableamount.Size = new System.Drawing.Size(78, 20);
            this.txtpayableamount.TabIndex = 3;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Location = new System.Drawing.Point(142, 39);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(84, 13);
            this.lblPaidAmount.TabIndex = 2;
            this.lblPaidAmount.Text = "Payable Amount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(379, 37);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(78, 20);
            this.txtPaidAmount.TabIndex = 5;
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(313, 39);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(67, 13);
            this.lblPayAmount.TabIndex = 4;
            this.lblPayAmount.Text = "Paid Amount";
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(522, 38);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(206, 20);
            this.txtremark.TabIndex = 7;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(472, 39);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "Remark";
            // 
            // btnpreview
            // 
            this.btnpreview.Enabled = false;
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(708, 0);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(33, 23);
            this.btnpreview.TabIndex = 30;
            this.btnpreview.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(675, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 29;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(642, 0);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(31, 23);
            this.btnnew.TabIndex = 28;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(609, 0);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(36, 22);
            this.btnsave.TabIndex = 27;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(18, 64);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(710, 548);
            this.crViewer.TabIndex = 31;
            // 
            // frmDoctorsLedgerInvestigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 624);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.lblPayAmount);
            this.Controls.Add(this.txtpayableamount);
            this.Controls.Add(this.lblPaidAmount);
            this.Controls.Add(this.txtDoctorId);
            this.Controls.Add(this.lblDoctorId);
            this.Name = "frmDoctorsLedgerInvestigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors Ledger Investigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtpayableamount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}