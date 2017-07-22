namespace hms.Forms
{
    partial class frmHospitalDeposit
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
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblWardcabin = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.lblremarks = new System.Windows.Forms.Label();
            this.txtreturn = new System.Windows.Forms.TextBox();
            this.lblreturn = new System.Windows.Forms.Label();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.lblreceive = new System.Windows.Forms.Label();
            this.txtremainingdue = new System.Windows.Forms.TextBox();
            this.lblremainingdue = new System.Windows.Forms.Label();
            this.txtdepositamount = new System.Windows.Forms.TextBox();
            this.lbldepositamount = new System.Windows.Forms.Label();
            this.txtpayableamount = new System.Windows.Forms.TextBox();
            this.lblpayableamount = new System.Windows.Forms.Label();
            this.lstdiscountby = new System.Windows.Forms.ListBox();
            this.txtdiscountby = new System.Windows.Forms.TextBox();
            this.lbldiscountby = new System.Windows.Forms.Label();
            this.txtpersentance = new System.Windows.Forms.TextBox();
            this.lblpersentance = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.txtpaymentremaining = new System.Windows.Forms.TextBox();
            this.lblpaymentremaining = new System.Windows.Forms.Label();
            this.lbladmissionid = new System.Windows.Forms.Label();
            this.txtcashmemono = new System.Windows.Forms.TextBox();
            this.lblcashmemono = new System.Windows.Forms.Label();
            this.gbPatientinformation = new System.Windows.Forms.GroupBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblCabin = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMemoList = new System.Windows.Forms.ListView();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.txtAdmissionId = new System.Windows.Forms.TextBox();
            this.btnPatienList = new System.Windows.Forms.Button();
            this.txtAdmissionSl = new System.Windows.Forms.TextBox();
            this.chkReturnAmount = new System.Windows.Forms.CheckBox();
            this.lstDiscountType = new System.Windows.Forms.ListBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPatientinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctor.ForeColor = System.Drawing.Color.Black;
            this.lbldoctor.Location = new System.Drawing.Point(78, 88);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(44, 15);
            this.lbldoctor.TabIndex = 67;
            this.lbldoctor.Text = "Status:";
            // 
            // lblWardcabin
            // 
            this.lblWardcabin.AutoSize = true;
            this.lblWardcabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWardcabin.ForeColor = System.Drawing.Color.Black;
            this.lblWardcabin.Location = new System.Drawing.Point(53, 35);
            this.lblWardcabin.Name = "lblWardcabin";
            this.lblWardcabin.Size = new System.Drawing.Size(74, 15);
            this.lblWardcabin.TabIndex = 66;
            this.lblWardcabin.Text = "Ward/Cabin:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(80, 15);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 15);
            this.lblname.TabIndex = 65;
            this.lblname.Text = "Name:";
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(147, 333);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(208, 20);
            this.txtremarks.TabIndex = 5;
            // 
            // lblremarks
            // 
            this.lblremarks.AutoSize = true;
            this.lblremarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremarks.Location = new System.Drawing.Point(79, 333);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(57, 15);
            this.lblremarks.TabIndex = 62;
            this.lblremarks.Text = "Remarks";
            // 
            // txtreturn
            // 
            this.txtreturn.Location = new System.Drawing.Point(255, 357);
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.ReadOnly = true;
            this.txtreturn.Size = new System.Drawing.Size(98, 20);
            this.txtreturn.TabIndex = 60;
            // 
            // lblreturn
            // 
            this.lblreturn.AutoSize = true;
            this.lblreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturn.Location = new System.Drawing.Point(193, 358);
            this.lblreturn.Name = "lblreturn";
            this.lblreturn.Size = new System.Drawing.Size(50, 15);
            this.lblreturn.TabIndex = 59;
            this.lblreturn.Text = "Return";
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(115, 357);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(76, 20);
            this.txtreceive.TabIndex = 6;
            this.txtreceive.TextChanged += new System.EventHandler(this.txtreceive_TextChanged);
            this.txtreceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtreceive_KeyDown);
            this.txtreceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // lblreceive
            // 
            this.lblreceive.AutoSize = true;
            this.lblreceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceive.Location = new System.Drawing.Point(50, 358);
            this.lblreceive.Name = "lblreceive";
            this.lblreceive.Size = new System.Drawing.Size(58, 15);
            this.lblreceive.TabIndex = 57;
            this.lblreceive.Text = "Receive";
            // 
            // txtremainingdue
            // 
            this.txtremainingdue.Location = new System.Drawing.Point(147, 309);
            this.txtremainingdue.Name = "txtremainingdue";
            this.txtremainingdue.ReadOnly = true;
            this.txtremainingdue.Size = new System.Drawing.Size(208, 20);
            this.txtremainingdue.TabIndex = 56;
            this.txtremainingdue.TabStop = false;
            // 
            // lblremainingdue
            // 
            this.lblremainingdue.AutoSize = true;
            this.lblremainingdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremainingdue.Location = new System.Drawing.Point(36, 309);
            this.lblremainingdue.Name = "lblremainingdue";
            this.lblremainingdue.Size = new System.Drawing.Size(94, 15);
            this.lblremainingdue.TabIndex = 55;
            this.lblremainingdue.Text = "Remaining Due";
            // 
            // txtdepositamount
            // 
            this.txtdepositamount.Location = new System.Drawing.Point(146, 277);
            this.txtdepositamount.Name = "txtdepositamount";
            this.txtdepositamount.Size = new System.Drawing.Size(209, 20);
            this.txtdepositamount.TabIndex = 4;
            this.txtdepositamount.TextChanged += new System.EventHandler(this.txtdepositamount_TextChanged);
            this.txtdepositamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdepositamount_KeyDown);
            this.txtdepositamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // lbldepositamount
            // 
            this.lbldepositamount.AutoSize = true;
            this.lbldepositamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepositamount.Location = new System.Drawing.Point(37, 277);
            this.lbldepositamount.Name = "lbldepositamount";
            this.lbldepositamount.Size = new System.Drawing.Size(94, 15);
            this.lbldepositamount.TabIndex = 53;
            this.lbldepositamount.Text = "Deposit Amount";
            // 
            // txtpayableamount
            // 
            this.txtpayableamount.Location = new System.Drawing.Point(147, 254);
            this.txtpayableamount.Name = "txtpayableamount";
            this.txtpayableamount.ReadOnly = true;
            this.txtpayableamount.Size = new System.Drawing.Size(208, 20);
            this.txtpayableamount.TabIndex = 52;
            this.txtpayableamount.TabStop = false;
            // 
            // lblpayableamount
            // 
            this.lblpayableamount.AutoSize = true;
            this.lblpayableamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayableamount.Location = new System.Drawing.Point(34, 254);
            this.lblpayableamount.Name = "lblpayableamount";
            this.lblpayableamount.Size = new System.Drawing.Size(96, 15);
            this.lblpayableamount.TabIndex = 51;
            this.lblpayableamount.Text = "Payable Amount";
            // 
            // lstdiscountby
            // 
            this.lstdiscountby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstdiscountby.FormattingEnabled = true;
            this.lstdiscountby.Location = new System.Drawing.Point(146, 198);
            this.lstdiscountby.Name = "lstdiscountby";
            this.lstdiscountby.Size = new System.Drawing.Size(209, 52);
            this.lstdiscountby.TabIndex = 3;
            this.lstdiscountby.DoubleClick += new System.EventHandler(this.lstdiscountby_DoubleClick);
            this.lstdiscountby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstdiscountby_KeyPress);
            // 
            // txtdiscountby
            // 
            this.txtdiscountby.Location = new System.Drawing.Point(147, 174);
            this.txtdiscountby.Name = "txtdiscountby";
            this.txtdiscountby.ReadOnly = true;
            this.txtdiscountby.Size = new System.Drawing.Size(207, 20);
            this.txtdiscountby.TabIndex = 49;
            this.txtdiscountby.TabStop = false;
            // 
            // lbldiscountby
            // 
            this.lbldiscountby.AutoSize = true;
            this.lbldiscountby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscountby.Location = new System.Drawing.Point(63, 175);
            this.lbldiscountby.Name = "lbldiscountby";
            this.lbldiscountby.Size = new System.Drawing.Size(71, 15);
            this.lbldiscountby.TabIndex = 48;
            this.lbldiscountby.Text = "Discount By";
            // 
            // txtpersentance
            // 
            this.txtpersentance.Location = new System.Drawing.Point(239, 151);
            this.txtpersentance.Name = "txtpersentance";
            this.txtpersentance.Size = new System.Drawing.Size(40, 20);
            this.txtpersentance.TabIndex = 2;
            this.txtpersentance.TextChanged += new System.EventHandler(this.txtpersentance_TextChanged);
            this.txtpersentance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // lblpersentance
            // 
            this.lblpersentance.AutoSize = true;
            this.lblpersentance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersentance.Location = new System.Drawing.Point(281, 154);
            this.lblpersentance.Name = "lblpersentance";
            this.lblpersentance.Size = new System.Drawing.Size(19, 15);
            this.lblpersentance.TabIndex = 46;
            this.lblpersentance.Text = "%";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(147, 151);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(66, 20);
            this.txtdiscount.TabIndex = 1;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(81, 154);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(55, 15);
            this.lbldiscount.TabIndex = 44;
            this.lbldiscount.Text = "Discount";
            // 
            // txtpaymentremaining
            // 
            this.txtpaymentremaining.Location = new System.Drawing.Point(146, 66);
            this.txtpaymentremaining.Name = "txtpaymentremaining";
            this.txtpaymentremaining.ReadOnly = true;
            this.txtpaymentremaining.Size = new System.Drawing.Size(208, 20);
            this.txtpaymentremaining.TabIndex = 43;
            this.txtpaymentremaining.TabStop = false;
            // 
            // lblpaymentremaining
            // 
            this.lblpaymentremaining.AutoSize = true;
            this.lblpaymentremaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymentremaining.Location = new System.Drawing.Point(7, 65);
            this.lblpaymentremaining.Name = "lblpaymentremaining";
            this.lblpaymentremaining.Size = new System.Drawing.Size(119, 15);
            this.lblpaymentremaining.TabIndex = 42;
            this.lblpaymentremaining.Text = "Payment Remaining";
            // 
            // lbladmissionid
            // 
            this.lbladmissionid.AutoSize = true;
            this.lbladmissionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmissionid.Location = new System.Drawing.Point(41, 42);
            this.lbladmissionid.Name = "lbladmissionid";
            this.lbladmissionid.Size = new System.Drawing.Size(79, 15);
            this.lbladmissionid.TabIndex = 40;
            this.lbladmissionid.Text = "Admission ID";
            // 
            // txtcashmemono
            // 
            this.txtcashmemono.Location = new System.Drawing.Point(146, 11);
            this.txtcashmemono.Name = "txtcashmemono";
            this.txtcashmemono.ReadOnly = true;
            this.txtcashmemono.Size = new System.Drawing.Size(208, 20);
            this.txtcashmemono.TabIndex = 39;
            this.txtcashmemono.TabStop = false;
            // 
            // lblcashmemono
            // 
            this.lblcashmemono.AutoSize = true;
            this.lblcashmemono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcashmemono.Location = new System.Drawing.Point(37, 13);
            this.lblcashmemono.Name = "lblcashmemono";
            this.lblcashmemono.Size = new System.Drawing.Size(93, 15);
            this.lblcashmemono.TabIndex = 38;
            this.lblcashmemono.Text = "Cash Memo No";
            // 
            // gbPatientinformation
            // 
            this.gbPatientinformation.Controls.Add(this.lblPatientName);
            this.gbPatientinformation.Controls.Add(this.lblname);
            this.gbPatientinformation.Controls.Add(this.lblCabin);
            this.gbPatientinformation.Controls.Add(this.lblWardcabin);
            this.gbPatientinformation.Controls.Add(this.lblStatus);
            this.gbPatientinformation.Controls.Add(this.lbldoctor);
            this.gbPatientinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientinformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientinformation.Location = new System.Drawing.Point(380, 47);
            this.gbPatientinformation.Name = "gbPatientinformation";
            this.gbPatientinformation.Size = new System.Drawing.Size(433, 119);
            this.gbPatientinformation.TabIndex = 77;
            this.gbPatientinformation.TabStop = false;
            this.gbPatientinformation.Text = "Patient Information";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.Black;
            this.lblPatientName.Location = new System.Drawing.Point(132, 15);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 15);
            this.lblPatientName.TabIndex = 65;
            // 
            // lblCabin
            // 
            this.lblCabin.AutoSize = true;
            this.lblCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabin.ForeColor = System.Drawing.Color.Black;
            this.lblCabin.Location = new System.Drawing.Point(132, 35);
            this.lblCabin.Name = "lblCabin";
            this.lblCabin.Size = new System.Drawing.Size(0, 15);
            this.lblCabin.TabIndex = 66;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(132, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 67;
            // 
            // btnprint
            // 
            this.btnprint.Image = global::hms.Properties.Resources.PRINTMAN;
            this.btnprint.Location = new System.Drawing.Point(719, 6);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(28, 20);
            this.btnprint.TabIndex = 83;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(686, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(28, 23);
            this.btnsave.TabIndex = 81;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(653, 4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(31, 23);
            this.btnnew.TabIndex = 80;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(751, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 23);
            this.btnclose.TabIndex = 84;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tk";
            // 
            // lstMemoList
            // 
            this.lstMemoList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lstMemoList.FullRowSelect = true;
            this.lstMemoList.GridLines = true;
            this.lstMemoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMemoList.LabelWrap = false;
            this.lstMemoList.Location = new System.Drawing.Point(23, 383);
            this.lstMemoList.MultiSelect = false;
            this.lstMemoList.Name = "lstMemoList";
            this.lstMemoList.ShowGroups = false;
            this.lstMemoList.Size = new System.Drawing.Size(804, 184);
            this.lstMemoList.TabIndex = 86;
            this.lstMemoList.UseCompatibleStateImageBehavior = false;
            this.lstMemoList.View = System.Windows.Forms.View.Details;
            this.lstMemoList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstMemoList_ColumnWidthChanging);
            this.lstMemoList.SelectedIndexChanged += new System.EventHandler(this.lstMemoList_SelectedIndexChanged);
            this.lstMemoList.DoubleClick += new System.EventHandler(this.lstMemoList_DoubleClick);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Enabled = false;
            this.txtReturnAmount.Location = new System.Drawing.Point(506, 225);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(208, 20);
            this.txtReturnAmount.TabIndex = 5;
            this.txtReturnAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtreceive_KeyDown);
            this.txtReturnAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(406, 225);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(92, 15);
            this.lblReturnAmount.TabIndex = 87;
            this.lblReturnAmount.Text = "Return Amount:";
            // 
            // txtAdmissionId
            // 
            this.txtAdmissionId.Enabled = false;
            this.txtAdmissionId.Location = new System.Drawing.Point(148, 41);
            this.txtAdmissionId.Name = "txtAdmissionId";
            this.txtAdmissionId.ReadOnly = true;
            this.txtAdmissionId.Size = new System.Drawing.Size(40, 20);
            this.txtAdmissionId.TabIndex = 89;
            this.txtAdmissionId.TabStop = false;
            // 
            // btnPatienList
            // 
            this.btnPatienList.Location = new System.Drawing.Point(329, 40);
            this.btnPatienList.Name = "btnPatienList";
            this.btnPatienList.Size = new System.Drawing.Size(24, 23);
            this.btnPatienList.TabIndex = 201;
            this.btnPatienList.TabStop = false;
            this.btnPatienList.Text = "...";
            this.btnPatienList.UseVisualStyleBackColor = true;
            this.btnPatienList.Click += new System.EventHandler(this.btnPatienList_Click);
            // 
            // txtAdmissionSl
            // 
            this.txtAdmissionSl.Enabled = false;
            this.txtAdmissionSl.Location = new System.Drawing.Point(196, 41);
            this.txtAdmissionSl.Name = "txtAdmissionSl";
            this.txtAdmissionSl.ReadOnly = true;
            this.txtAdmissionSl.Size = new System.Drawing.Size(126, 20);
            this.txtAdmissionSl.TabIndex = 202;
            this.txtAdmissionSl.TabStop = false;
            // 
            // chkReturnAmount
            // 
            this.chkReturnAmount.AutoSize = true;
            this.chkReturnAmount.Location = new System.Drawing.Point(382, 228);
            this.chkReturnAmount.Name = "chkReturnAmount";
            this.chkReturnAmount.Size = new System.Drawing.Size(15, 14);
            this.chkReturnAmount.TabIndex = 203;
            this.chkReturnAmount.UseVisualStyleBackColor = true;
            this.chkReturnAmount.Click += new System.EventHandler(this.chkReturnAmount_Click);
            // 
            // lstDiscountType
            // 
            this.lstDiscountType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDiscountType.FormattingEnabled = true;
            this.lstDiscountType.Location = new System.Drawing.Point(144, 92);
            this.lstDiscountType.Name = "lstDiscountType";
            this.lstDiscountType.Size = new System.Drawing.Size(209, 52);
            this.lstDiscountType.TabIndex = 3;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(304, 154);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(44, 13);
            this.lblDiscountAmount.TabIndex = 204;
            this.lblDiscountAmount.Text = "0.00 Tk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Discount Type";
            // 
            // frmHospitalDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 586);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.chkReturnAmount);
            this.Controls.Add(this.txtAdmissionSl);
            this.Controls.Add(this.btnPatienList);
            this.Controls.Add(this.txtAdmissionId);
            this.Controls.Add(this.txtReturnAmount);
            this.Controls.Add(this.lblReturnAmount);
            this.Controls.Add(this.lstMemoList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpersentance);
            this.Controls.Add(this.lblpersentance);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.gbPatientinformation);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.lblremarks);
            this.Controls.Add(this.txtreturn);
            this.Controls.Add(this.lblreturn);
            this.Controls.Add(this.txtreceive);
            this.Controls.Add(this.lblreceive);
            this.Controls.Add(this.txtremainingdue);
            this.Controls.Add(this.lblremainingdue);
            this.Controls.Add(this.txtdepositamount);
            this.Controls.Add(this.lbldepositamount);
            this.Controls.Add(this.txtpayableamount);
            this.Controls.Add(this.lblpayableamount);
            this.Controls.Add(this.lstDiscountType);
            this.Controls.Add(this.lstdiscountby);
            this.Controls.Add(this.txtdiscountby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldiscountby);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txtpaymentremaining);
            this.Controls.Add(this.lblpaymentremaining);
            this.Controls.Add(this.lbladmissionid);
            this.Controls.Add(this.txtcashmemono);
            this.Controls.Add(this.lblcashmemono);
            this.Name = "frmHospitalDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHospitalDeposit";
            this.gbPatientinformation.ResumeLayout(false);
            this.gbPatientinformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblWardcabin;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label lblremarks;
        private System.Windows.Forms.TextBox txtreturn;
        private System.Windows.Forms.Label lblreturn;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.Label lblreceive;
        private System.Windows.Forms.TextBox txtremainingdue;
        private System.Windows.Forms.Label lblremainingdue;
        private System.Windows.Forms.TextBox txtdepositamount;
        private System.Windows.Forms.Label lbldepositamount;
        private System.Windows.Forms.TextBox txtpayableamount;
        private System.Windows.Forms.Label lblpayableamount;
        private System.Windows.Forms.ListBox lstdiscountby;
        private System.Windows.Forms.TextBox txtdiscountby;
        private System.Windows.Forms.Label lbldiscountby;
        private System.Windows.Forms.TextBox txtpersentance;
        private System.Windows.Forms.Label lblpersentance;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.TextBox txtpaymentremaining;
        private System.Windows.Forms.Label lblpaymentremaining;
        private System.Windows.Forms.Label lbladmissionid;
        private System.Windows.Forms.TextBox txtcashmemono;
        private System.Windows.Forms.Label lblcashmemono;
        private System.Windows.Forms.GroupBox gbPatientinformation;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblCabin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMemoList;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.TextBox txtAdmissionId;
        private System.Windows.Forms.Button btnPatienList;
        private System.Windows.Forms.TextBox txtAdmissionSl;
        private System.Windows.Forms.CheckBox chkReturnAmount;
        private System.Windows.Forms.ListBox lstDiscountType;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label label2;

        
    }
}