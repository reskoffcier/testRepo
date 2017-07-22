namespace hms.Forms
{
    partial class frmReportDelivery
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
            this.lblInvestigationID = new System.Windows.Forms.Label();
            this.txtInvestigationID = new System.Windows.Forms.TextBox();
            this.gbAccountsInformation = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotaldiscount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltotalreturn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltotalpayamount = new System.Windows.Forms.Label();
            this.lbltotalpaid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblPAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dgvFontDeskReport = new System.Windows.Forms.DataGridView();
            this.chkAllSelect = new System.Windows.Forms.CheckBox();
            this.btnRowDeliver = new System.Windows.Forms.Button();
            this.cmbInvestigation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAccountsInformation.SuspendLayout();
            this.gbPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFontDeskReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvestigationID
            // 
            this.lblInvestigationID.AutoSize = true;
            this.lblInvestigationID.Location = new System.Drawing.Point(48, 57);
            this.lblInvestigationID.Name = "lblInvestigationID";
            this.lblInvestigationID.Size = new System.Drawing.Size(81, 13);
            this.lblInvestigationID.TabIndex = 0;
            this.lblInvestigationID.Text = "Investigation ID";
            // 
            // txtInvestigationID
            // 
            this.txtInvestigationID.Location = new System.Drawing.Point(135, 54);
            this.txtInvestigationID.Name = "txtInvestigationID";
            this.txtInvestigationID.Size = new System.Drawing.Size(100, 20);
            this.txtInvestigationID.TabIndex = 1;
            this.txtInvestigationID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvestigationID_KeyPress);
            // 
            // gbAccountsInformation
            // 
            this.gbAccountsInformation.Controls.Add(this.label12);
            this.gbAccountsInformation.Controls.Add(this.label7);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldiscount);
            this.gbAccountsInformation.Controls.Add(this.label8);
            this.gbAccountsInformation.Controls.Add(this.lbltotalamount);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldue);
            this.gbAccountsInformation.Controls.Add(this.label9);
            this.gbAccountsInformation.Controls.Add(this.lblvat);
            this.gbAccountsInformation.Controls.Add(this.lbltotalreturn);
            this.gbAccountsInformation.Controls.Add(this.label10);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpayamount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpaid);
            this.gbAccountsInformation.Controls.Add(this.label11);
            this.gbAccountsInformation.Controls.Add(this.label13);
            this.gbAccountsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountsInformation.ForeColor = System.Drawing.Color.Red;
            this.gbAccountsInformation.Location = new System.Drawing.Point(605, 11);
            this.gbAccountsInformation.Name = "gbAccountsInformation";
            this.gbAccountsInformation.Size = new System.Drawing.Size(219, 156);
            this.gbAccountsInformation.TabIndex = 55;
            this.gbAccountsInformation.TabStop = false;
            this.gbAccountsInformation.Text = "Accounts Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Total Discount:";
            // 
            // lbltotaldiscount
            // 
            this.lbltotaldiscount.AutoSize = true;
            this.lbltotaldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldiscount.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldiscount.Location = new System.Drawing.Point(96, 39);
            this.lbltotaldiscount.Name = "lbltotaldiscount";
            this.lbltotaldiscount.Size = new System.Drawing.Size(88, 15);
            this.lbltotaldiscount.TabIndex = 44;
            this.lbltotaldiscount.Text = "Total Discount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Total Amount:";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalamount.Location = new System.Drawing.Point(96, 21);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(82, 15);
            this.lbltotalamount.TabIndex = 43;
            this.lbltotalamount.Text = "Total Amount:";
            // 
            // lbltotaldue
            // 
            this.lbltotaldue.AutoSize = true;
            this.lbltotaldue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldue.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldue.Location = new System.Drawing.Point(96, 137);
            this.lbltotaldue.Name = "lbltotaldue";
            this.lbltotaldue.Size = new System.Drawing.Size(63, 15);
            this.lbltotaldue.TabIndex = 49;
            this.lbltotaldue.Text = "Total Due:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Total Due:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.Black;
            this.lblvat.Location = new System.Drawing.Point(96, 57);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(27, 15);
            this.lblvat.TabIndex = 45;
            this.lblvat.Text = "Vat:";
            // 
            // lbltotalreturn
            // 
            this.lbltotalreturn.AutoSize = true;
            this.lbltotalreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalreturn.ForeColor = System.Drawing.Color.Black;
            this.lbltotalreturn.Location = new System.Drawing.Point(96, 110);
            this.lbltotalreturn.Name = "lbltotalreturn";
            this.lbltotalreturn.Size = new System.Drawing.Size(77, 15);
            this.lbltotalreturn.TabIndex = 48;
            this.lbltotalreturn.Text = "Total Return:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(68, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "Vat:";
            // 
            // lbltotalpayamount
            // 
            this.lbltotalpayamount.AutoSize = true;
            this.lbltotalpayamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpayamount.Location = new System.Drawing.Point(96, 73);
            this.lbltotalpayamount.Name = "lbltotalpayamount";
            this.lbltotalpayamount.Size = new System.Drawing.Size(129, 15);
            this.lbltotalpayamount.TabIndex = 46;
            this.lbltotalpayamount.Text = "Total Payable Amount:";
            // 
            // lbltotalpaid
            // 
            this.lbltotalpaid.AutoSize = true;
            this.lbltotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpaid.Location = new System.Drawing.Point(96, 93);
            this.lbltotalpaid.Name = "lbltotalpaid";
            this.lbltotalpaid.Size = new System.Drawing.Size(65, 15);
            this.lbltotalpaid.TabIndex = 47;
            this.lbltotalpaid.Text = "Total Paid:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "Total Return:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(30, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 54;
            this.label13.Text = "Total Paid:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(-33, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Total Payable Amount:";
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.label4);
            this.gbPatientInformation.Controls.Add(this.lblDoc);
            this.gbPatientInformation.Controls.Add(this.lblPAddress);
            this.gbPatientInformation.Controls.Add(this.label5);
            this.gbPatientInformation.Controls.Add(this.lblPName);
            this.gbPatientInformation.Controls.Add(this.label6);
            this.gbPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientInformation.Location = new System.Drawing.Point(256, 11);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(343, 126);
            this.gbPatientInformation.TabIndex = 54;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Doctor:";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.Color.Black;
            this.lblDoc.Location = new System.Drawing.Point(56, 72);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(46, 15);
            this.lblDoc.TabIndex = 44;
            this.lblDoc.Text = "Doctor:";
            // 
            // lblPAddress
            // 
            this.lblPAddress.AutoSize = true;
            this.lblPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPAddress.Location = new System.Drawing.Point(56, 44);
            this.lblPAddress.Name = "lblPAddress";
            this.lblPAddress.Size = new System.Drawing.Size(54, 15);
            this.lblPAddress.TabIndex = 43;
            this.lblPAddress.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Address:";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Black;
            this.lblPName.Location = new System.Drawing.Point(56, 23);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(44, 15);
            this.lblPName.TabIndex = 42;
            this.lblPName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Name:";
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(265, 143);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 56;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Enabled = false;
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.Location = new System.Drawing.Point(354, 143);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(75, 23);
            this.btnDeliver.TabIndex = 57;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(31, 11);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(32, 23);
            this.btnnew.TabIndex = 58;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(64, 11);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 59;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgvFontDeskReport
            // 
            this.dgvFontDeskReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFontDeskReport.Location = new System.Drawing.Point(12, 173);
            this.dgvFontDeskReport.Name = "dgvFontDeskReport";
            this.dgvFontDeskReport.Size = new System.Drawing.Size(812, 397);
            this.dgvFontDeskReport.TabIndex = 60;
            // 
            // chkAllSelect
            // 
            this.chkAllSelect.AutoSize = true;
            this.chkAllSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllSelect.ForeColor = System.Drawing.Color.Red;
            this.chkAllSelect.Location = new System.Drawing.Point(13, 150);
            this.chkAllSelect.Name = "chkAllSelect";
            this.chkAllSelect.Size = new System.Drawing.Size(80, 17);
            this.chkAllSelect.TabIndex = 61;
            this.chkAllSelect.Text = "All Select";
            this.chkAllSelect.UseVisualStyleBackColor = true;
            this.chkAllSelect.CheckedChanged += new System.EventHandler(this.chkAllSelect_CheckedChanged);
            // 
            // btnRowDeliver
            // 
            this.btnRowDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowDeliver.Location = new System.Drawing.Point(436, 142);
            this.btnRowDeliver.Name = "btnRowDeliver";
            this.btnRowDeliver.Size = new System.Drawing.Size(94, 23);
            this.btnRowDeliver.TabIndex = 62;
            this.btnRowDeliver.Text = "Raw Deliver";
            this.btnRowDeliver.UseVisualStyleBackColor = true;
            this.btnRowDeliver.Click += new System.EventHandler(this.btnRowDeliver_Click);
            // 
            // cmbInvestigation
            // 
            this.cmbInvestigation.FormattingEnabled = true;
            this.cmbInvestigation.Location = new System.Drawing.Point(135, 77);
            this.cmbInvestigation.Name = "cmbInvestigation";
            this.cmbInvestigation.Size = new System.Drawing.Size(100, 21);
            this.cmbInvestigation.TabIndex = 63;
            this.cmbInvestigation.SelectedIndexChanged += new System.EventHandler(this.cmbInvestigation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Investigation Type";
            // 
            // frmReportDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInvestigation);
            this.Controls.Add(this.btnRowDeliver);
            this.Controls.Add(this.chkAllSelect);
            this.Controls.Add(this.dgvFontDeskReport);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.txtInvestigationID);
            this.Controls.Add(this.lblInvestigationID);
            this.Controls.Add(this.gbAccountsInformation);
            this.Name = "frmReportDelivery";
            this.Text = "frmReportDelivery";
            this.Load += new System.EventHandler(this.frmReportDelivery_Load);
            this.gbAccountsInformation.ResumeLayout(false);
            this.gbAccountsInformation.PerformLayout();
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFontDeskReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestigationID;
        private System.Windows.Forms.TextBox txtInvestigationID;
        private System.Windows.Forms.GroupBox gbAccountsInformation;
        private System.Windows.Forms.Label lbltotaldiscount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lbltotalreturn;
        private System.Windows.Forms.Label lbltotalpayamount;
        private System.Windows.Forms.Label lbltotalpaid;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblPAddress;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dgvFontDeskReport;
        private System.Windows.Forms.CheckBox chkAllSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRowDeliver;
        private System.Windows.Forms.ComboBox cmbInvestigation;
        private System.Windows.Forms.Label label1;
    }
}