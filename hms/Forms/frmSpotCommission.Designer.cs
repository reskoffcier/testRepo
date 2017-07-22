namespace hms.Forms
{
    partial class SpotCommission
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
            this.lblinvestigationid = new System.Windows.Forms.Label();
            this.txtinvestigationid = new System.Windows.Forms.TextBox();
            this.gbAccountsInformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotaldiscount = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltotalreturn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotalpayamount = new System.Windows.Forms.Label();
            this.lbltotalpaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpotCommission = new System.Windows.Forms.Button();
            this.txtreceiveby = new System.Windows.Forms.TextBox();
            this.lblReceiveby = new System.Windows.Forms.Label();
            this.gbAccountsInformation.SuspendLayout();
            this.gbPatientInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinvestigationid
            // 
            this.lblinvestigationid.AutoSize = true;
            this.lblinvestigationid.Location = new System.Drawing.Point(13, 8);
            this.lblinvestigationid.Name = "lblinvestigationid";
            this.lblinvestigationid.Size = new System.Drawing.Size(81, 13);
            this.lblinvestigationid.TabIndex = 0;
            this.lblinvestigationid.Text = "Investigation ID";
            // 
            // txtinvestigationid
            // 
            this.txtinvestigationid.Location = new System.Drawing.Point(97, 5);
            this.txtinvestigationid.Name = "txtinvestigationid";
            this.txtinvestigationid.Size = new System.Drawing.Size(100, 20);
            this.txtinvestigationid.TabIndex = 1;
            this.txtinvestigationid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvestigationid_KeyPress);
            // 
            // gbAccountsInformation
            // 
            this.gbAccountsInformation.Controls.Add(this.label4);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldiscount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalamount);
            this.gbAccountsInformation.Controls.Add(this.lblTA);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldue);
            this.gbAccountsInformation.Controls.Add(this.label6);
            this.gbAccountsInformation.Controls.Add(this.lblvat);
            this.gbAccountsInformation.Controls.Add(this.lbltotalreturn);
            this.gbAccountsInformation.Controls.Add(this.label7);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpayamount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpaid);
            this.gbAccountsInformation.Controls.Add(this.label8);
            this.gbAccountsInformation.Controls.Add(this.label10);
            this.gbAccountsInformation.Controls.Add(this.label9);
            this.gbAccountsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountsInformation.ForeColor = System.Drawing.Color.Red;
            this.gbAccountsInformation.Location = new System.Drawing.Point(480, 5);
            this.gbAccountsInformation.Name = "gbAccountsInformation";
            this.gbAccountsInformation.Size = new System.Drawing.Size(289, 187);
            this.gbAccountsInformation.TabIndex = 55;
            this.gbAccountsInformation.TabStop = false;
            this.gbAccountsInformation.Text = "Accounts Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Total Discount:";
            // 
            // lbltotaldiscount
            // 
            this.lbltotaldiscount.AutoSize = true;
            this.lbltotaldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldiscount.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldiscount.Location = new System.Drawing.Point(142, 35);
            this.lbltotaldiscount.Name = "lbltotaldiscount";
            this.lbltotaldiscount.Size = new System.Drawing.Size(88, 15);
            this.lbltotaldiscount.TabIndex = 44;
            this.lbltotaldiscount.Text = "Total Discount:";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalamount.Location = new System.Drawing.Point(142, 17);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(82, 15);
            this.lbltotalamount.TabIndex = 43;
            this.lbltotalamount.Text = "Total Amount:";
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
            this.lbltotaldue.Size = new System.Drawing.Size(63, 15);
            this.lbltotaldue.TabIndex = 49;
            this.lbltotaldue.Text = "Total Due:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Total Due:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.Black;
            this.lblvat.Location = new System.Drawing.Point(142, 53);
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
            this.lbltotalreturn.Location = new System.Drawing.Point(142, 122);
            this.lbltotalreturn.Name = "lbltotalreturn";
            this.lbltotalreturn.Size = new System.Drawing.Size(77, 15);
            this.lbltotalreturn.TabIndex = 48;
            this.lbltotalreturn.Text = "Total Return:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Vat:";
            // 
            // lbltotalpayamount
            // 
            this.lbltotalpayamount.AutoSize = true;
            this.lbltotalpayamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpayamount.Location = new System.Drawing.Point(142, 85);
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
            this.lbltotalpaid.Location = new System.Drawing.Point(142, 105);
            this.lbltotalpaid.Name = "lbltotalpaid";
            this.lbltotalpaid.Size = new System.Drawing.Size(65, 15);
            this.lbltotalpaid.TabIndex = 47;
            this.lbltotalpaid.Text = "Total Paid:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Total Return:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "Total Paid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "Total Payable Amount:";
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.lblDoctor);
            this.gbPatientInformation.Controls.Add(this.lblAddress);
            this.gbPatientInformation.Controls.Add(this.lblName);
            this.gbPatientInformation.Controls.Add(this.label3);
            this.gbPatientInformation.Controls.Add(this.label5);
            this.gbPatientInformation.Controls.Add(this.label11);
            this.gbPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientInformation.Location = new System.Drawing.Point(16, 67);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(377, 125);
            this.gbPatientInformation.TabIndex = 54;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(68, 67);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 48;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(65, 40);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(65, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Address:";
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
            this.btnNew.Location = new System.Drawing.Point(215, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 23);
            this.btnNew.TabIndex = 65;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(289, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 23);
            this.btnclose.TabIndex = 64;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(253, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 62;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(16, 198);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(753, 390);
            this.crViewer.TabIndex = 66;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpotCommission);
            this.groupBox1.Controls.Add(this.txtDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(322, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 58);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spot Commission Report";
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
            // txtreceiveby
            // 
            this.txtreceiveby.Location = new System.Drawing.Point(97, 30);
            this.txtreceiveby.Name = "txtreceiveby";
            this.txtreceiveby.Size = new System.Drawing.Size(100, 20);
            this.txtreceiveby.TabIndex = 3;
            // 
            // lblReceiveby
            // 
            this.lblReceiveby.AutoSize = true;
            this.lblReceiveby.Location = new System.Drawing.Point(13, 33);
            this.lblReceiveby.Name = "lblReceiveby";
            this.lblReceiveby.Size = new System.Drawing.Size(62, 13);
            this.lblReceiveby.TabIndex = 2;
            this.lblReceiveby.Text = "Receive By";
            // 
            // SpotCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.gbAccountsInformation);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.txtreceiveby);
            this.Controls.Add(this.lblReceiveby);
            this.Controls.Add(this.txtinvestigationid);
            this.Controls.Add(this.lblinvestigationid);
            this.Name = "SpotCommission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spot Commission";
            this.gbAccountsInformation.ResumeLayout(false);
            this.gbAccountsInformation.PerformLayout();
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinvestigationid;
        private System.Windows.Forms.TextBox txtinvestigationid;
        private System.Windows.Forms.GroupBox gbAccountsInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotaldiscount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lbltotalreturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotalpayamount;
        private System.Windows.Forms.Label lbltotalpaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
        private System.Windows.Forms.DateTimePicker txtDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpotCommission;
        private System.Windows.Forms.TextBox txtreceiveby;
        private System.Windows.Forms.Label lblReceiveby;
    }
}