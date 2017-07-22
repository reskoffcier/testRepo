namespace hms.Forms
{
    partial class frmIndDoctorLedger
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
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.txtpayableamount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(50, 95);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(710, 465);
            this.crViewer.TabIndex = 55;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(554, 45);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(206, 20);
            this.txtremark.TabIndex = 51;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(504, 46);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 50;
            this.lblRemark.Text = "Remark";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(389, 44);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPaidAmount.TabIndex = 49;
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(324, 46);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(64, 13);
            this.lblPayAmount.TabIndex = 48;
            this.lblPayAmount.Text = "Pay Amount";
            // 
            // txtpayableamount
            // 
            this.txtpayableamount.Location = new System.Drawing.Point(240, 45);
            this.txtpayableamount.Name = "txtpayableamount";
            this.txtpayableamount.ReadOnly = true;
            this.txtpayableamount.Size = new System.Drawing.Size(78, 20);
            this.txtpayableamount.TabIndex = 47;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Location = new System.Drawing.Point(174, 46);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(67, 13);
            this.lblPaidAmount.TabIndex = 46;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(100, 45);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(65, 20);
            this.txtDoctorId.TabIndex = 45;
            this.txtDoctorId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorId_KeyPress);
            // 
            // lblDoctorId
            // 
            this.lblDoctorId.AutoSize = true;
            this.lblDoctorId.Location = new System.Drawing.Point(47, 46);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(53, 13);
            this.lblDoctorId.TabIndex = 44;
            this.lblDoctorId.Text = "Doctor ID";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(719, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 54;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(686, 7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(31, 23);
            this.btnnew.TabIndex = 53;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(653, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(36, 22);
            this.btnsave.TabIndex = 52;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmIndDoctorLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 606);
            this.Controls.Add(this.crViewer);
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
            this.Name = "frmIndDoctorLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ind Doctor Ledger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.TextBox txtpayableamount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Label lblDoctorId;
    }
}