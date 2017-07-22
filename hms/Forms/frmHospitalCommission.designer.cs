namespace hms.Forms
{
    partial class frmHospitalCommission
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
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblTDiscont = new System.Windows.Forms.Label();
            this.lbltotaldiscount = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.lblTdue = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltotalreturn = new System.Windows.Forms.Label();
            this.lblVa = new System.Windows.Forms.Label();
            this.lbltotalpayamount = new System.Windows.Forms.Label();
            this.lbltotalpaid = new System.Windows.Forms.Label();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnSpotCommission = new System.Windows.Forms.Button();
            this.lblTreturn = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.lblBedInfo = new System.Windows.Forms.Label();
            this.lblTpaid = new System.Windows.Forms.Label();
            this.lblTPAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAccountsInformation = new System.Windows.Forms.GroupBox();
            this.txtAdmissionId = new System.Windows.Forms.TextBox();
            this.lblAdmissionId = new System.Windows.Forms.Label();
            this.gbPatientInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAccountsInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(65, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Bed Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Name:";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::hms.Properties.Resources.ADD;
            this.btnNew.Location = new System.Drawing.Point(235, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 23);
            this.btnNew.TabIndex = 77;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.Color.Black;
            this.lblDoc.Location = new System.Drawing.Point(-1, 67);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(68, 15);
            this.lblDoc.TabIndex = 44;
            this.lblDoc.Text = "Ref Doctor:";
            // 
            // lblTDiscont
            // 
            this.lblTDiscont.AutoSize = true;
            this.lblTDiscont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDiscont.ForeColor = System.Drawing.Color.Black;
            this.lblTDiscont.Location = new System.Drawing.Point(13, 35);
            this.lblTDiscont.Name = "lblTDiscont";
            this.lblTDiscont.Size = new System.Drawing.Size(88, 15);
            this.lblTDiscont.TabIndex = 51;
            this.lblTDiscont.Text = "Total Discount:";
            // 
            // lbltotaldiscount
            // 
            this.lbltotaldiscount.AutoSize = true;
            this.lbltotaldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldiscount.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldiscount.Location = new System.Drawing.Point(142, 35);
            this.lbltotaldiscount.Name = "lbltotaldiscount";
            this.lbltotaldiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotaldiscount.Size = new System.Drawing.Size(14, 15);
            this.lbltotaldiscount.TabIndex = 44;
            this.lbltotaldiscount.Text = "0";
            this.lbltotaldiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalamount.Location = new System.Drawing.Point(142, 17);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotalamount.Size = new System.Drawing.Size(14, 15);
            this.lbltotalamount.TabIndex = 43;
            this.lbltotalamount.Text = "0";
            this.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTA.ForeColor = System.Drawing.Color.Black;
            this.lblTA.Location = new System.Drawing.Point(13, 17);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(82, 15);
            this.lblTA.TabIndex = 50;
            this.lblTA.Text = "Total Amount:";
            // 
            // lbltotaldue
            // 
            this.lbltotaldue.AutoSize = true;
            this.lbltotaldue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldue.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldue.Location = new System.Drawing.Point(142, 149);
            this.lbltotaldue.Name = "lbltotaldue";
            this.lbltotaldue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotaldue.Size = new System.Drawing.Size(14, 15);
            this.lbltotaldue.TabIndex = 49;
            this.lbltotaldue.Text = "0";
            this.lbltotaldue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTdue
            // 
            this.lblTdue.AutoSize = true;
            this.lblTdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTdue.ForeColor = System.Drawing.Color.Black;
            this.lblTdue.Location = new System.Drawing.Point(13, 149);
            this.lblTdue.Name = "lblTdue";
            this.lblTdue.Size = new System.Drawing.Size(63, 15);
            this.lblTdue.TabIndex = 56;
            this.lblTdue.Text = "Total Due:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.Black;
            this.lblvat.Location = new System.Drawing.Point(142, 53);
            this.lblvat.Name = "lblvat";
            this.lblvat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblvat.Size = new System.Drawing.Size(14, 15);
            this.lblvat.TabIndex = 45;
            this.lblvat.Text = "0";
            this.lblvat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltotalreturn
            // 
            this.lbltotalreturn.AutoSize = true;
            this.lbltotalreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalreturn.ForeColor = System.Drawing.Color.Black;
            this.lbltotalreturn.Location = new System.Drawing.Point(142, 122);
            this.lbltotalreturn.Name = "lbltotalreturn";
            this.lbltotalreturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotalreturn.Size = new System.Drawing.Size(14, 15);
            this.lbltotalreturn.TabIndex = 48;
            this.lbltotalreturn.Text = "0";
            this.lbltotalreturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVa
            // 
            this.lblVa.AutoSize = true;
            this.lblVa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVa.ForeColor = System.Drawing.Color.Black;
            this.lblVa.Location = new System.Drawing.Point(13, 53);
            this.lblVa.Name = "lblVa";
            this.lblVa.Size = new System.Drawing.Size(27, 15);
            this.lblVa.TabIndex = 52;
            this.lblVa.Text = "Vat:";
            // 
            // lbltotalpayamount
            // 
            this.lbltotalpayamount.AutoSize = true;
            this.lbltotalpayamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpayamount.Location = new System.Drawing.Point(142, 85);
            this.lbltotalpayamount.Name = "lbltotalpayamount";
            this.lbltotalpayamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotalpayamount.Size = new System.Drawing.Size(14, 15);
            this.lbltotalpayamount.TabIndex = 46;
            this.lbltotalpayamount.Text = "0";
            this.lbltotalpayamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltotalpaid
            // 
            this.lbltotalpaid.AutoSize = true;
            this.lbltotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpaid.Location = new System.Drawing.Point(142, 105);
            this.lbltotalpaid.Name = "lbltotalpaid";
            this.lbltotalpaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotalpaid.Size = new System.Drawing.Size(14, 15);
            this.lbltotalpaid.TabIndex = 47;
            this.lbltotalpaid.Text = "0";
            this.lbltotalpaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(36, 208);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(753, 390);
            this.crViewer.TabIndex = 78;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(273, 13);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 75;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtDatePicker
            // 
            this.txtDatePicker.CustomFormat = "MM/dd/yyyy";
            this.txtDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatePicker.Location = new System.Drawing.Point(5, 23);
            this.txtDatePicker.Name = "txtDatePicker";
            this.txtDatePicker.Size = new System.Drawing.Size(66, 18);
            this.txtDatePicker.TabIndex = 67;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(309, 13);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 23);
            this.btnclose.TabIndex = 76;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnSpotCommission
            // 
            this.btnSpotCommission.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpotCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpotCommission.Location = new System.Drawing.Point(74, 21);
            this.btnSpotCommission.Name = "btnSpotCommission";
            this.btnSpotCommission.Size = new System.Drawing.Size(69, 24);
            this.btnSpotCommission.TabIndex = 68;
            this.btnSpotCommission.Text = "Show Report";
            this.btnSpotCommission.UseVisualStyleBackColor = false;
            this.btnSpotCommission.Click += new System.EventHandler(this.btnSpotCommission_Click);
            // 
            // lblTreturn
            // 
            this.lblTreturn.AutoSize = true;
            this.lblTreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreturn.ForeColor = System.Drawing.Color.Black;
            this.lblTreturn.Location = new System.Drawing.Point(13, 122);
            this.lblTreturn.Name = "lblTreturn";
            this.lblTreturn.Size = new System.Drawing.Size(77, 15);
            this.lblTreturn.TabIndex = 55;
            this.lblTreturn.Text = "Total Return:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(68, 67);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(0, 15);
            this.lblDoctor.TabIndex = 48;
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.lblDoctor);
            this.gbPatientInformation.Controls.Add(this.lblBedInfo);
            this.gbPatientInformation.Controls.Add(this.lblName);
            this.gbPatientInformation.Controls.Add(this.lblDoc);
            this.gbPatientInformation.Controls.Add(this.label5);
            this.gbPatientInformation.Controls.Add(this.label11);
            this.gbPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientInformation.Location = new System.Drawing.Point(36, 77);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(377, 125);
            this.gbPatientInformation.TabIndex = 73;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // lblBedInfo
            // 
            this.lblBedInfo.AutoSize = true;
            this.lblBedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedInfo.ForeColor = System.Drawing.Color.Black;
            this.lblBedInfo.Location = new System.Drawing.Point(65, 40);
            this.lblBedInfo.Name = "lblBedInfo";
            this.lblBedInfo.Size = new System.Drawing.Size(0, 15);
            this.lblBedInfo.TabIndex = 46;
            // 
            // lblTpaid
            // 
            this.lblTpaid.AutoSize = true;
            this.lblTpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpaid.ForeColor = System.Drawing.Color.Black;
            this.lblTpaid.Location = new System.Drawing.Point(13, 105);
            this.lblTpaid.Name = "lblTpaid";
            this.lblTpaid.Size = new System.Drawing.Size(65, 15);
            this.lblTpaid.TabIndex = 54;
            this.lblTpaid.Text = "Total Paid:";
            // 
            // lblTPAmount
            // 
            this.lblTPAmount.AutoSize = true;
            this.lblTPAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTPAmount.Location = new System.Drawing.Point(13, 85);
            this.lblTPAmount.Name = "lblTPAmount";
            this.lblTPAmount.Size = new System.Drawing.Size(129, 15);
            this.lblTPAmount.TabIndex = 53;
            this.lblTPAmount.Text = "Total Payable Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpotCommission);
            this.groupBox1.Controls.Add(this.txtDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(342, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 58);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hospital Commission Report";
            // 
            // gbAccountsInformation
            // 
            this.gbAccountsInformation.Controls.Add(this.lblTDiscont);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldiscount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalamount);
            this.gbAccountsInformation.Controls.Add(this.lblTA);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldue);
            this.gbAccountsInformation.Controls.Add(this.lblTdue);
            this.gbAccountsInformation.Controls.Add(this.lblvat);
            this.gbAccountsInformation.Controls.Add(this.lbltotalreturn);
            this.gbAccountsInformation.Controls.Add(this.lblVa);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpayamount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpaid);
            this.gbAccountsInformation.Controls.Add(this.lblTreturn);
            this.gbAccountsInformation.Controls.Add(this.lblTpaid);
            this.gbAccountsInformation.Controls.Add(this.lblTPAmount);
            this.gbAccountsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountsInformation.ForeColor = System.Drawing.Color.Red;
            this.gbAccountsInformation.Location = new System.Drawing.Point(500, 15);
            this.gbAccountsInformation.Name = "gbAccountsInformation";
            this.gbAccountsInformation.Size = new System.Drawing.Size(289, 187);
            this.gbAccountsInformation.TabIndex = 74;
            this.gbAccountsInformation.TabStop = false;
            this.gbAccountsInformation.Text = "Accounts Information";
            // 
            // txtAdmissionId
            // 
            this.txtAdmissionId.Location = new System.Drawing.Point(117, 15);
            this.txtAdmissionId.Name = "txtAdmissionId";
            this.txtAdmissionId.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionId.TabIndex = 70;
            this.txtAdmissionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionId_KeyPress);
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.AutoSize = true;
            this.lblAdmissionId.Location = new System.Drawing.Point(33, 18);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(68, 13);
            this.lblAdmissionId.TabIndex = 69;
            this.lblAdmissionId.Text = "Admission ID";
            // 
            // frmHospitalCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 609);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAccountsInformation);
            this.Controls.Add(this.txtAdmissionId);
            this.Controls.Add(this.lblAdmissionId);
            this.Name = "frmHospitalCommission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Commission";
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbAccountsInformation.ResumeLayout(false);
            this.gbAccountsInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblTDiscont;
        private System.Windows.Forms.Label lbltotaldiscount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.Label lblTdue;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lbltotalreturn;
        private System.Windows.Forms.Label lblVa;
        private System.Windows.Forms.Label lbltotalpayamount;
        private System.Windows.Forms.Label lbltotalpaid;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker txtDatePicker;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSpotCommission;
        private System.Windows.Forms.Label lblTreturn;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label lblBedInfo;
        private System.Windows.Forms.Label lblTpaid;
        private System.Windows.Forms.Label lblTPAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAccountsInformation;
        private System.Windows.Forms.TextBox txtAdmissionId;
        private System.Windows.Forms.Label lblAdmissionId;

    }
}