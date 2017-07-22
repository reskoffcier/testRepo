namespace hms.Forms
{
    partial class frmSpotDoctorsVisit
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
            this.btnSpotCommission = new System.Windows.Forms.Button();
            this.txtDatePicker = new System.Windows.Forms.DateTimePicker();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBedInfo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdmissionId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPayableAmount = new System.Windows.Forms.TextBox();
            this.lblReceiveby = new System.Windows.Forms.Label();
            this.lblAdmissionId = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.cmbDoctorList = new System.Windows.Forms.ComboBox();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.gbPatientInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(39, 234);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(753, 390);
            this.crViewer.TabIndex = 89;
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
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.label1);
            this.gbPatientInformation.Controls.Add(this.lblBedInfo);
            this.gbPatientInformation.Controls.Add(this.lblDoctor);
            this.gbPatientInformation.Controls.Add(this.lblAddress);
            this.gbPatientInformation.Controls.Add(this.lblName);
            this.gbPatientInformation.Controls.Add(this.label3);
            this.gbPatientInformation.Controls.Add(this.label5);
            this.gbPatientInformation.Controls.Add(this.label11);
            this.gbPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientInformation.Location = new System.Drawing.Point(500, 12);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(377, 165);
            this.gbPatientInformation.TabIndex = 84;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Bed Info:";
            // 
            // lblBedInfo
            // 
            this.lblBedInfo.AutoSize = true;
            this.lblBedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedInfo.ForeColor = System.Drawing.Color.Black;
            this.lblBedInfo.Location = new System.Drawing.Point(66, 70);
            this.lblBedInfo.Name = "lblBedInfo";
            this.lblBedInfo.Size = new System.Drawing.Size(49, 15);
            this.lblBedInfo.TabIndex = 94;
            this.lblBedInfo.Text = "BedInfo";
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
            this.label3.Location = new System.Drawing.Point(13, 94);
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
            // txtAdmissionId
            // 
            this.txtAdmissionId.Location = new System.Drawing.Point(120, 36);
            this.txtAdmissionId.Name = "txtAdmissionId";
            this.txtAdmissionId.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionId.TabIndex = 81;
            this.txtAdmissionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionId_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpotCommission);
            this.groupBox1.Controls.Add(this.txtDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(345, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 58);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spot Doctors visit Report";
            // 
            // txtPayableAmount
            // 
            this.txtPayableAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayableAmount.Enabled = false;
            this.txtPayableAmount.Location = new System.Drawing.Point(120, 92);
            this.txtPayableAmount.Name = "txtPayableAmount";
            this.txtPayableAmount.ReadOnly = true;
            this.txtPayableAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPayableAmount.TabIndex = 83;
            // 
            // lblReceiveby
            // 
            this.lblReceiveby.AutoSize = true;
            this.lblReceiveby.Location = new System.Drawing.Point(20, 95);
            this.lblReceiveby.Name = "lblReceiveby";
            this.lblReceiveby.Size = new System.Drawing.Size(84, 13);
            this.lblReceiveby.TabIndex = 82;
            this.lblReceiveby.Text = "Payable Amount";
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.AutoSize = true;
            this.lblAdmissionId.Location = new System.Drawing.Point(36, 39);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(68, 13);
            this.lblAdmissionId.TabIndex = 80;
            this.lblAdmissionId.Text = "Admission ID";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::hms.Properties.Resources.ADD;
            this.btnNew.Location = new System.Drawing.Point(238, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 23);
            this.btnNew.TabIndex = 88;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(276, 34);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 86;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(312, 34);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 23);
            this.btnclose.TabIndex = 87;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // cmbDoctorList
            // 
            this.cmbDoctorList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDoctorList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDoctorList.FormattingEnabled = true;
            this.cmbDoctorList.Location = new System.Drawing.Point(120, 62);
            this.cmbDoctorList.Name = "cmbDoctorList";
            this.cmbDoctorList.Size = new System.Drawing.Size(219, 21);
            this.cmbDoctorList.TabIndex = 91;
            this.cmbDoctorList.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorList_SelectedIndexChanged);
            this.cmbDoctorList.TextChanged += new System.EventHandler(this.cmbDoctorList_TextChanged);
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Location = new System.Drawing.Point(65, 66);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(39, 13);
            this.lblDoctors.TabIndex = 92;
            this.lblDoctors.Text = "Doctor";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(68, 94);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 48;
            this.lblDoctor.Text = "Doctor";
            // 
            // frmSpotDoctorsVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.cmbDoctorList);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.txtAdmissionId);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPayableAmount);
            this.Controls.Add(this.lblReceiveby);
            this.Controls.Add(this.lblAdmissionId);
            this.Name = "frmSpotDoctorsVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spot Doctors Visit";
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
        private System.Windows.Forms.Button btnSpotCommission;
        private System.Windows.Forms.DateTimePicker txtDatePicker;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdmissionId;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPayableAmount;
        private System.Windows.Forms.Label lblReceiveby;
        private System.Windows.Forms.Label lblAdmissionId;
        private System.Windows.Forms.ComboBox cmbDoctorList;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBedInfo;
        private System.Windows.Forms.Label lblDoctor;
    }
}