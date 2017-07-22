namespace hms.Forms
{
    partial class frmEmployeeProfile
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
            this.grpSalaryInfo = new System.Windows.Forms.GroupBox();
            this.txtother = new System.Windows.Forms.TextBox();
            this.lblother = new System.Windows.Forms.Label();
            this.txthouse = new System.Windows.Forms.TextBox();
            this.lblHouserate = new System.Windows.Forms.Label();
            this.txtmedical = new System.Windows.Forms.TextBox();
            this.lblmedical = new System.Windows.Forms.Label();
            this.chkIsCommession = new System.Windows.Forms.CheckBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.chkParmanent = new System.Windows.Forms.CheckBox();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdDepartment = new System.Windows.Forms.Button();
            this.btnUpdDesignation = new System.Windows.Forms.Button();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.chkDoctor = new System.Windows.Forms.CheckBox();
            this.lbllistdoctor = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.btnDesignation = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.txtParmanentAddress = new System.Windows.Forms.RichTextBox();
            this.rtbPresentAddress = new System.Windows.Forms.RichTextBox();
            this.lblParmanentAddress = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateOfJoin = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeMobile = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtEmpployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtSearchEmp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvEmpprofile = new System.Windows.Forms.DataGridView();
            this.grpSalaryInfo.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSalaryInfo
            // 
            this.grpSalaryInfo.Controls.Add(this.txtother);
            this.grpSalaryInfo.Controls.Add(this.lblother);
            this.grpSalaryInfo.Controls.Add(this.txthouse);
            this.grpSalaryInfo.Controls.Add(this.lblHouserate);
            this.grpSalaryInfo.Controls.Add(this.txtmedical);
            this.grpSalaryInfo.Controls.Add(this.lblmedical);
            this.grpSalaryInfo.Controls.Add(this.chkIsCommession);
            this.grpSalaryInfo.Controls.Add(this.txtBasic);
            this.grpSalaryInfo.Controls.Add(this.lblBasic);
            this.grpSalaryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalaryInfo.Location = new System.Drawing.Point(29, 377);
            this.grpSalaryInfo.Name = "grpSalaryInfo";
            this.grpSalaryInfo.Size = new System.Drawing.Size(760, 64);
            this.grpSalaryInfo.TabIndex = 4;
            this.grpSalaryInfo.TabStop = false;
            this.grpSalaryInfo.Text = "Salary Information";
            // 
            // txtother
            // 
            this.txtother.Location = new System.Drawing.Point(439, 34);
            this.txtother.Name = "txtother";
            this.txtother.Size = new System.Drawing.Size(78, 23);
            this.txtother.TabIndex = 12;
            // 
            // lblother
            // 
            this.lblother.AutoSize = true;
            this.lblother.Location = new System.Drawing.Point(394, 35);
            this.lblother.Name = "lblother";
            this.lblother.Size = new System.Drawing.Size(41, 17);
            this.lblother.TabIndex = 11;
            this.lblother.Text = "other";
            // 
            // txthouse
            // 
            this.txthouse.Location = new System.Drawing.Point(313, 33);
            this.txthouse.Name = "txthouse";
            this.txthouse.Size = new System.Drawing.Size(78, 23);
            this.txthouse.TabIndex = 10;
            // 
            // lblHouserate
            // 
            this.lblHouserate.AutoSize = true;
            this.lblHouserate.Location = new System.Drawing.Point(268, 34);
            this.lblHouserate.Name = "lblHouserate";
            this.lblHouserate.Size = new System.Drawing.Size(49, 17);
            this.lblHouserate.TabIndex = 9;
            this.lblHouserate.Text = "House";
            // 
            // txtmedical
            // 
            this.txtmedical.Location = new System.Drawing.Point(190, 34);
            this.txtmedical.Name = "txtmedical";
            this.txtmedical.Size = new System.Drawing.Size(78, 23);
            this.txtmedical.TabIndex = 8;
            // 
            // lblmedical
            // 
            this.lblmedical.AutoSize = true;
            this.lblmedical.Location = new System.Drawing.Point(135, 36);
            this.lblmedical.Name = "lblmedical";
            this.lblmedical.Size = new System.Drawing.Size(56, 17);
            this.lblmedical.TabIndex = 7;
            this.lblmedical.Text = "Medical";
            // 
            // chkIsCommession
            // 
            this.chkIsCommession.AutoSize = true;
            this.chkIsCommession.Location = new System.Drawing.Point(526, 32);
            this.chkIsCommession.Name = "chkIsCommession";
            this.chkIsCommession.Size = new System.Drawing.Size(121, 21);
            this.chkIsCommession.TabIndex = 6;
            this.chkIsCommession.Text = "Is Commession";
            this.chkIsCommession.UseVisualStyleBackColor = true;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(52, 34);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(78, 23);
            this.txtBasic.TabIndex = 5;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(7, 35);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(42, 17);
            this.lblBasic.TabIndex = 0;
            this.lblBasic.Text = "Basic";
            // 
            // chkParmanent
            // 
            this.chkParmanent.AutoSize = true;
            this.chkParmanent.Location = new System.Drawing.Point(576, 88);
            this.chkParmanent.Name = "chkParmanent";
            this.chkParmanent.Size = new System.Drawing.Size(96, 21);
            this.chkParmanent.TabIndex = 2;
            this.chkParmanent.Text = "Parmanent";
            this.chkParmanent.UseVisualStyleBackColor = true;
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.btnUpdDepartment);
            this.gbPersonalInfo.Controls.Add(this.btnUpdDesignation);
            this.gbPersonalInfo.Controls.Add(this.txtDoctorId);
            this.gbPersonalInfo.Controls.Add(this.chkDoctor);
            this.gbPersonalInfo.Controls.Add(this.chkParmanent);
            this.gbPersonalInfo.Controls.Add(this.lbllistdoctor);
            this.gbPersonalInfo.Controls.Add(this.txtgender);
            this.gbPersonalInfo.Controls.Add(this.lblGender);
            this.gbPersonalInfo.Controls.Add(this.cmbDesignation);
            this.gbPersonalInfo.Controls.Add(this.btnDesignation);
            this.gbPersonalInfo.Controls.Add(this.btnDept);
            this.gbPersonalInfo.Controls.Add(this.cmbDepartment);
            this.gbPersonalInfo.Controls.Add(this.dtpDateOfBirth);
            this.gbPersonalInfo.Controls.Add(this.dtpJoinDate);
            this.gbPersonalInfo.Controls.Add(this.txtParmanentAddress);
            this.gbPersonalInfo.Controls.Add(this.rtbPresentAddress);
            this.gbPersonalInfo.Controls.Add(this.lblParmanentAddress);
            this.gbPersonalInfo.Controls.Add(this.txtBloodGroup);
            this.gbPersonalInfo.Controls.Add(this.txtMobileNo);
            this.gbPersonalInfo.Controls.Add(this.lblAddress);
            this.gbPersonalInfo.Controls.Add(this.lblDateOfJoin);
            this.gbPersonalInfo.Controls.Add(this.lblJoinDate);
            this.gbPersonalInfo.Controls.Add(this.txtEmployeeName);
            this.gbPersonalInfo.Controls.Add(this.lblBloodGroup);
            this.gbPersonalInfo.Controls.Add(this.lblDesignation);
            this.gbPersonalInfo.Controls.Add(this.lblEmployeeMobile);
            this.gbPersonalInfo.Controls.Add(this.lblEmployeeName);
            this.gbPersonalInfo.Controls.Add(this.txtMotherName);
            this.gbPersonalInfo.Controls.Add(this.lblMotherName);
            this.gbPersonalInfo.Controls.Add(this.lblDepartment);
            this.gbPersonalInfo.Controls.Add(this.txtFatherName);
            this.gbPersonalInfo.Controls.Add(this.lblFatherName);
            this.gbPersonalInfo.Controls.Add(this.txtEmpployeeID);
            this.gbPersonalInfo.Controls.Add(this.lblEmployeeID);
            this.gbPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonalInfo.Location = new System.Drawing.Point(29, 56);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Size = new System.Drawing.Size(772, 319);
            this.gbPersonalInfo.TabIndex = 3;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Information";
            // 
            // btnUpdDepartment
            // 
            this.btnUpdDepartment.Image = global::hms.Properties.Resources.Refresh_icon;
            this.btnUpdDepartment.Location = new System.Drawing.Point(731, 22);
            this.btnUpdDepartment.Name = "btnUpdDepartment";
            this.btnUpdDepartment.Size = new System.Drawing.Size(29, 23);
            this.btnUpdDepartment.TabIndex = 22;
            this.btnUpdDepartment.UseVisualStyleBackColor = true;
            this.btnUpdDepartment.Click += new System.EventHandler(this.btnUpdDepartment_Click);
            // 
            // btnUpdDesignation
            // 
            this.btnUpdDesignation.Image = global::hms.Properties.Resources.Refresh_icon;
            this.btnUpdDesignation.Location = new System.Drawing.Point(346, 93);
            this.btnUpdDesignation.Name = "btnUpdDesignation";
            this.btnUpdDesignation.Size = new System.Drawing.Size(26, 23);
            this.btnUpdDesignation.TabIndex = 21;
            this.btnUpdDesignation.UseVisualStyleBackColor = true;
            this.btnUpdDesignation.Click += new System.EventHandler(this.btnUpdDesignation_Click);
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(598, 49);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.ReadOnly = true;
            this.txtDoctorId.Size = new System.Drawing.Size(100, 23);
            this.txtDoctorId.TabIndex = 20;
            // 
            // chkDoctor
            // 
            this.chkDoctor.AutoSize = true;
            this.chkDoctor.Location = new System.Drawing.Point(576, 55);
            this.chkDoctor.Name = "chkDoctor";
            this.chkDoctor.Size = new System.Drawing.Size(15, 14);
            this.chkDoctor.TabIndex = 19;
            this.chkDoctor.UseVisualStyleBackColor = true;
            this.chkDoctor.CheckedChanged += new System.EventHandler(this.chkDoctor_CheckedChanged);
            // 
            // lbllistdoctor
            // 
            this.lbllistdoctor.AutoSize = true;
            this.lbllistdoctor.Location = new System.Drawing.Point(437, 56);
            this.lbllistdoctor.Name = "lbllistdoctor";
            this.lbllistdoctor.Size = new System.Drawing.Size(76, 17);
            this.lbllistdoctor.TabIndex = 18;
            this.lbllistdoctor.Text = "Is Doctor ?";
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(264, 150);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(108, 23);
            this.txtgender.TabIndex = 17;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(196, 152);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(126, 94);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(179, 24);
            this.cmbDesignation.TabIndex = 15;
            // 
            // btnDesignation
            // 
            this.btnDesignation.Location = new System.Drawing.Point(313, 94);
            this.btnDesignation.Name = "btnDesignation";
            this.btnDesignation.Size = new System.Drawing.Size(26, 23);
            this.btnDesignation.TabIndex = 14;
            this.btnDesignation.Text = "+";
            this.btnDesignation.UseVisualStyleBackColor = true;
            this.btnDesignation.Click += new System.EventHandler(this.btnDesignation_Click);
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(704, 22);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(23, 23);
            this.btnDept.TabIndex = 6;
            this.btnDept.Text = "+";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(575, 20);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(123, 24);
            this.cmbDepartment.TabIndex = 8;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(575, 124);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(179, 23);
            this.dtpDateOfBirth.TabIndex = 10;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Location = new System.Drawing.Point(126, 121);
            this.dtpJoinDate.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(247, 23);
            this.dtpJoinDate.TabIndex = 3;
            // 
            // txtParmanentAddress
            // 
            this.txtParmanentAddress.Location = new System.Drawing.Point(575, 206);
            this.txtParmanentAddress.Name = "txtParmanentAddress";
            this.txtParmanentAddress.Size = new System.Drawing.Size(179, 79);
            this.txtParmanentAddress.TabIndex = 13;
            this.txtParmanentAddress.Text = "";
            // 
            // rtbPresentAddress
            // 
            this.rtbPresentAddress.Location = new System.Drawing.Point(126, 210);
            this.rtbPresentAddress.Name = "rtbPresentAddress";
            this.rtbPresentAddress.Size = new System.Drawing.Size(247, 77);
            this.rtbPresentAddress.TabIndex = 7;
            this.rtbPresentAddress.Text = "";
            // 
            // lblParmanentAddress
            // 
            this.lblParmanentAddress.AutoSize = true;
            this.lblParmanentAddress.Location = new System.Drawing.Point(436, 209);
            this.lblParmanentAddress.Name = "lblParmanentAddress";
            this.lblParmanentAddress.Size = new System.Drawing.Size(133, 17);
            this.lblParmanentAddress.TabIndex = 0;
            this.lblParmanentAddress.Text = "Parmanent Address";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(126, 149);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(55, 23);
            this.txtBloodGroup.TabIndex = 5;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(126, 178);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(179, 23);
            this.txtMobileNo.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 209);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Present Address";
            // 
            // lblDateOfJoin
            // 
            this.lblDateOfJoin.AutoSize = true;
            this.lblDateOfJoin.Location = new System.Drawing.Point(432, 122);
            this.lblDateOfJoin.Name = "lblDateOfJoin";
            this.lblDateOfJoin.Size = new System.Drawing.Size(87, 17);
            this.lblDateOfJoin.TabIndex = 0;
            this.lblDateOfJoin.Text = "Date of Birth";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(7, 121);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(84, 17);
            this.lblJoinDate.TabIndex = 0;
            this.lblJoinDate.Text = "Date of Join";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(126, 63);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(247, 23);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(7, 149);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(88, 17);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(7, 92);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(83, 17);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmployeeMobile
            // 
            this.lblEmployeeMobile.AutoSize = true;
            this.lblEmployeeMobile.Location = new System.Drawing.Point(7, 178);
            this.lblEmployeeMobile.Name = "lblEmployeeMobile";
            this.lblEmployeeMobile.Size = new System.Drawing.Size(75, 17);
            this.lblEmployeeMobile.TabIndex = 0;
            this.lblEmployeeMobile.Text = "Mobile No.";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(7, 63);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(45, 17);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Name";
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(575, 178);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(179, 23);
            this.txtMotherName.TabIndex = 12;
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(436, 178);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(93, 17);
            this.lblMotherName.TabIndex = 0;
            this.lblMotherName.Text = "Mother Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(436, 20);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(575, 149);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(179, 23);
            this.txtFatherName.TabIndex = 11;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(436, 149);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(90, 17);
            this.lblFatherName.TabIndex = 0;
            this.lblFatherName.Text = "Father Name";
            // 
            // txtEmpployeeID
            // 
            this.txtEmpployeeID.Enabled = false;
            this.txtEmpployeeID.Location = new System.Drawing.Point(126, 34);
            this.txtEmpployeeID.Name = "txtEmpployeeID";
            this.txtEmpployeeID.ReadOnly = true;
            this.txtEmpployeeID.Size = new System.Drawing.Size(179, 23);
            this.txtEmpployeeID.TabIndex = 0;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(7, 34);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtSearchEmp
            // 
            this.txtSearchEmp.Location = new System.Drawing.Point(6, 20);
            this.txtSearchEmp.Name = "txtSearchEmp";
            this.txtSearchEmp.Size = new System.Drawing.Size(314, 20);
            this.txtSearchEmp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchEmp);
            this.groupBox1.Location = new System.Drawing.Point(465, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Box";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(103, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 30;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(25, 5);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(31, 23);
            this.btnnew.TabIndex = 29;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(61, 6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(36, 22);
            this.btnsave.TabIndex = 27;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvEmpprofile
            // 
            this.dgvEmpprofile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpprofile.Location = new System.Drawing.Point(29, 452);
            this.dgvEmpprofile.Name = "dgvEmpprofile";
            this.dgvEmpprofile.Size = new System.Drawing.Size(762, 150);
            this.dgvEmpprofile.TabIndex = 32;
            this.dgvEmpprofile.Click += new System.EventHandler(this.dgvEmpprofile_Click);
            // 
            // frmEmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 613);
            this.Controls.Add(this.dgvEmpprofile);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSalaryInfo);
            this.Controls.Add(this.gbPersonalInfo);
            this.Name = "frmEmployeeProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeProfile";
            this.Load += new System.EventHandler(this.frmEmployeeProfile_Load);
            this.grpSalaryInfo.ResumeLayout(false);
            this.grpSalaryInfo.PerformLayout();
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpprofile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalaryInfo;
        private System.Windows.Forms.CheckBox chkParmanent;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button btnDesignation;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.RichTextBox txtParmanentAddress;
        private System.Windows.Forms.RichTextBox rtbPresentAddress;
        private System.Windows.Forms.Label lblParmanentAddress;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDateOfJoin;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmployeeMobile;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtEmpployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkIsCommession;
        private System.Windows.Forms.Label lbllistdoctor;
        private System.Windows.Forms.TextBox txtSearchEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtother;
        private System.Windows.Forms.Label lblother;
        private System.Windows.Forms.TextBox txthouse;
        private System.Windows.Forms.Label lblHouserate;
        private System.Windows.Forms.TextBox txtmedical;
        private System.Windows.Forms.Label lblmedical;
        private System.Windows.Forms.DataGridView dgvEmpprofile;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.CheckBox chkDoctor;
        private System.Windows.Forms.Button btnUpdDepartment;
        private System.Windows.Forms.Button btnUpdDesignation;

        public System.EventHandler dtpJoinDate_ValueChanged { get; set; }
    }
}