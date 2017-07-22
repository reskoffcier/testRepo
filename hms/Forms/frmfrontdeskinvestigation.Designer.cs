namespace hms.Forms
{
    partial class frmfrontdeskinvestigation
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
            this.lblpatientinformation = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lsttestname = new System.Windows.Forms.ListBox();
            this.lbldoctorinformaion = new System.Windows.Forms.Label();
            this.lbldoctorid = new System.Windows.Forms.Label();
            this.txtdoctorid = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtrefferedby = new System.Windows.Forms.TextBox();
            this.lblreferedby = new System.Windows.Forms.Label();
            this.txtdegree = new System.Windows.Forms.TextBox();
            this.lbldegree = new System.Windows.Forms.Label();
            this.txtspecialist = new System.Windows.Forms.TextBox();
            this.lblspecialist = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblPasentance = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.lblvat = new System.Windows.Forms.Label();
            this.txtPayableAmount = new System.Windows.Forms.TextBox();
            this.lblpayableamount = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.lblpaidamount = new System.Windows.Forms.Label();
            this.txttotaldue = new System.Windows.Forms.TextBox();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.lblreceive = new System.Windows.Forms.Label();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.lblreturn = new System.Windows.Forms.Label();
            this.rbtngenaral = new System.Windows.Forms.RadioButton();
            this.rbtnopd = new System.Windows.Forms.RadioButton();
            this.rbtnindoor = new System.Windows.Forms.RadioButton();
            this.lstdoctorsinformation = new System.Windows.Forms.ListBox();
            this.btndailyladger = new System.Windows.Forms.Button();
            this.txtSearchServices = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInvestigation = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Service_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdoctorinformation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtntherapy = new System.Windows.Forms.RadioButton();
            this.rbtndialysis = new System.Windows.Forms.RadioButton();
            this.rbtnbloodbank = new System.Windows.Forms.RadioButton();
            this.rbtndental = new System.Windows.Forms.RadioButton();
            this.rbtnpathology = new System.Windows.Forms.RadioButton();
            this.txtAdmissionSl = new System.Windows.Forms.TextBox();
            this.lblpc = new System.Windows.Forms.Label();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.txtdiscouuntpersentnance = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnGridDelete = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnDocRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdmissionId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDiscount = new System.Windows.Forms.ListBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestigation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpatientinformation
            // 
            this.lblpatientinformation.AutoSize = true;
            this.lblpatientinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientinformation.Location = new System.Drawing.Point(0, 38);
            this.lblpatientinformation.Name = "lblpatientinformation";
            this.lblpatientinformation.Size = new System.Drawing.Size(163, 20);
            this.lblpatientinformation.TabIndex = 0;
            this.lblpatientinformation.Text = "Patient Information";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(169, 38);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(89, 20);
            this.txtid.TabIndex = 1;
            this.txtid.TabStop = false;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(4, 62);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Neme:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(48, 62);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 20);
            this.txtname.TabIndex = 3;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(2, 114);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(48, 13);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "Address:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(48, 81);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(210, 67);
            this.txtaddress.TabIndex = 4;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(4, 156);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(41, 13);
            this.lblphone.TabIndex = 6;
            this.lblphone.Text = "Phone:";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(48, 153);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(210, 20);
            this.txtphone.TabIndex = 5;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(1, 177);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 8;
            this.lblage.Text = "Age";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(48, 177);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(31, 20);
            this.txtYear.TabIndex = 6;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(80, 177);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(30, 20);
            this.txtMonth.TabIndex = 7;
            // 
            // lsttestname
            // 
            this.lsttestname.FormattingEnabled = true;
            this.lsttestname.Location = new System.Drawing.Point(48, 237);
            this.lsttestname.Name = "lsttestname";
            this.lsttestname.Size = new System.Drawing.Size(406, 121);
            this.lsttestname.TabIndex = 12;
            this.lsttestname.TabStop = false;
            this.lsttestname.SelectedIndexChanged += new System.EventHandler(this.lsttestname_SelectedIndexChanged);
            this.lsttestname.DoubleClick += new System.EventHandler(this.lsttestname_DoubleClick);
            this.lsttestname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsttestname_KeyPress);
            // 
            // lbldoctorinformaion
            // 
            this.lbldoctorinformaion.AutoSize = true;
            this.lbldoctorinformaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctorinformaion.Location = new System.Drawing.Point(572, 12);
            this.lbldoctorinformaion.Name = "lbldoctorinformaion";
            this.lbldoctorinformaion.Size = new System.Drawing.Size(171, 20);
            this.lbldoctorinformaion.TabIndex = 13;
            this.lbldoctorinformaion.Text = "Doctor\'s Informaiom";
            // 
            // lbldoctorid
            // 
            this.lbldoctorid.AutoSize = true;
            this.lbldoctorid.Location = new System.Drawing.Point(573, 35);
            this.lbldoctorid.Name = "lbldoctorid";
            this.lbldoctorid.Size = new System.Drawing.Size(60, 13);
            this.lbldoctorid.TabIndex = 14;
            this.lbldoctorid.Text = "Doctor\'s ID";
            // 
            // txtdoctorid
            // 
            this.txtdoctorid.Location = new System.Drawing.Point(663, 35);
            this.txtdoctorid.Name = "txtdoctorid";
            this.txtdoctorid.ReadOnly = true;
            this.txtdoctorid.Size = new System.Drawing.Size(100, 20);
            this.txtdoctorid.TabIndex = 15;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(663, 61);
            this.txttitle.Name = "txttitle";
            this.txttitle.ReadOnly = true;
            this.txttitle.Size = new System.Drawing.Size(187, 20);
            this.txttitle.TabIndex = 17;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(573, 57);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 16;
            this.lbltitle.Text = "Title";
            // 
            // txtrefferedby
            // 
            this.txtrefferedby.Location = new System.Drawing.Point(663, 83);
            this.txtrefferedby.Name = "txtrefferedby";
            this.txtrefferedby.ReadOnly = true;
            this.txtrefferedby.Size = new System.Drawing.Size(187, 20);
            this.txtrefferedby.TabIndex = 19;
            // 
            // lblreferedby
            // 
            this.lblreferedby.AutoSize = true;
            this.lblreferedby.Location = new System.Drawing.Point(573, 82);
            this.lblreferedby.Name = "lblreferedby";
            this.lblreferedby.Size = new System.Drawing.Size(65, 13);
            this.lblreferedby.TabIndex = 18;
            this.lblreferedby.Text = "Reffered BY";
            // 
            // txtdegree
            // 
            this.txtdegree.Location = new System.Drawing.Point(663, 108);
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.ReadOnly = true;
            this.txtdegree.Size = new System.Drawing.Size(187, 20);
            this.txtdegree.TabIndex = 21;
            // 
            // lbldegree
            // 
            this.lbldegree.AutoSize = true;
            this.lbldegree.Location = new System.Drawing.Point(573, 104);
            this.lbldegree.Name = "lbldegree";
            this.lbldegree.Size = new System.Drawing.Size(42, 13);
            this.lbldegree.TabIndex = 20;
            this.lbldegree.Text = "Degree";
            // 
            // txtspecialist
            // 
            this.txtspecialist.Location = new System.Drawing.Point(663, 130);
            this.txtspecialist.Name = "txtspecialist";
            this.txtspecialist.ReadOnly = true;
            this.txtspecialist.Size = new System.Drawing.Size(187, 20);
            this.txtspecialist.TabIndex = 23;
            // 
            // lblspecialist
            // 
            this.lblspecialist.AutoSize = true;
            this.lblspecialist.Location = new System.Drawing.Point(573, 126);
            this.lblspecialist.Name = "lblspecialist";
            this.lblspecialist.Size = new System.Drawing.Size(52, 13);
            this.lblspecialist.TabIndex = 22;
            this.lblspecialist.Text = "Specialist";
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(663, 153);
            this.txtarea.Name = "txtarea";
            this.txtarea.ReadOnly = true;
            this.txtarea.Size = new System.Drawing.Size(187, 20);
            this.txtarea.TabIndex = 25;
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(573, 152);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(29, 13);
            this.lblarea.TabIndex = 24;
            this.lblarea.Text = "Area";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(663, 179);
            this.txttype.Name = "txttype";
            this.txttype.ReadOnly = true;
            this.txttype.Size = new System.Drawing.Size(187, 20);
            this.txttype.TabIndex = 27;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(573, 179);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 26;
            this.lbltype.Text = "Type";
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(663, 205);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(187, 20);
            this.txttotalamount.TabIndex = 29;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(573, 205);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(70, 13);
            this.lbltotalamount.TabIndex = 28;
            this.lbltotalamount.Text = "Total Amount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(663, 226);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(50, 20);
            this.txtdiscount.TabIndex = 10;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyUp);
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Location = new System.Drawing.Point(573, 226);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(49, 13);
            this.lbldiscount.TabIndex = 30;
            this.lbldiscount.Text = "Discount";
            // 
            // lblPasentance
            // 
            this.lblPasentance.AutoSize = true;
            this.lblPasentance.Location = new System.Drawing.Point(821, 230);
            this.lblPasentance.Name = "lblPasentance";
            this.lblPasentance.Size = new System.Drawing.Size(15, 13);
            this.lblPasentance.TabIndex = 32;
            this.lblPasentance.Text = "%";
            // 
            // txtvat
            // 
            this.txtvat.Location = new System.Drawing.Point(663, 282);
            this.txtvat.Name = "txtvat";
            this.txtvat.ReadOnly = true;
            this.txtvat.Size = new System.Drawing.Size(187, 20);
            this.txtvat.TabIndex = 34;
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(573, 282);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(23, 13);
            this.lblvat.TabIndex = 33;
            this.lblvat.Text = "Vat";
            // 
            // txtPayableAmount
            // 
            this.txtPayableAmount.Location = new System.Drawing.Point(664, 308);
            this.txtPayableAmount.Name = "txtPayableAmount";
            this.txtPayableAmount.ReadOnly = true;
            this.txtPayableAmount.Size = new System.Drawing.Size(187, 20);
            this.txtPayableAmount.TabIndex = 36;
            // 
            // lblpayableamount
            // 
            this.lblpayableamount.AutoSize = true;
            this.lblpayableamount.Location = new System.Drawing.Point(570, 315);
            this.lblpayableamount.Name = "lblpayableamount";
            this.lblpayableamount.Size = new System.Drawing.Size(84, 13);
            this.lblpayableamount.TabIndex = 35;
            this.lblpayableamount.Text = "Payable Amount";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(664, 334);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(187, 20);
            this.txtpaidamount.TabIndex = 13;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            this.txtpaidamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaidamount_KeyPress);
            // 
            // lblpaidamount
            // 
            this.lblpaidamount.AutoSize = true;
            this.lblpaidamount.Location = new System.Drawing.Point(570, 341);
            this.lblpaidamount.Name = "lblpaidamount";
            this.lblpaidamount.Size = new System.Drawing.Size(67, 13);
            this.lblpaidamount.TabIndex = 37;
            this.lblpaidamount.Text = "Paid Amount";
            // 
            // txttotaldue
            // 
            this.txttotaldue.Location = new System.Drawing.Point(664, 364);
            this.txttotaldue.Name = "txttotaldue";
            this.txttotaldue.ReadOnly = true;
            this.txttotaldue.Size = new System.Drawing.Size(187, 20);
            this.txttotaldue.TabIndex = 40;
            // 
            // lbltotaldue
            // 
            this.lbltotaldue.AutoSize = true;
            this.lbltotaldue.Location = new System.Drawing.Point(576, 364);
            this.lbltotaldue.Name = "lbltotaldue";
            this.lbltotaldue.Size = new System.Drawing.Size(54, 13);
            this.lbltotaldue.TabIndex = 39;
            this.lbltotaldue.Text = "Total Due";
            // 
            // lblreceive
            // 
            this.lblreceive.AutoSize = true;
            this.lblreceive.Location = new System.Drawing.Point(576, 393);
            this.lblreceive.Name = "lblreceive";
            this.lblreceive.Size = new System.Drawing.Size(47, 13);
            this.lblreceive.TabIndex = 41;
            this.lblreceive.Text = "Receive";
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(664, 391);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(62, 20);
            this.txtreceive.TabIndex = 14;
            this.txtreceive.TextChanged += new System.EventHandler(this.txtreceive_TextChanged);
            this.txtreceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtreceive_KeyPress);
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(779, 390);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(74, 20);
            this.txtReturn.TabIndex = 15;
            this.txtReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturn_KeyPress);
            // 
            // lblreturn
            // 
            this.lblreturn.AutoSize = true;
            this.lblreturn.Location = new System.Drawing.Point(734, 393);
            this.lblreturn.Name = "lblreturn";
            this.lblreturn.Size = new System.Drawing.Size(39, 13);
            this.lblreturn.TabIndex = 43;
            this.lblreturn.Text = "Retrun";
            // 
            // rbtngenaral
            // 
            this.rbtngenaral.AutoSize = true;
            this.rbtngenaral.Location = new System.Drawing.Point(6, 19);
            this.rbtngenaral.Name = "rbtngenaral";
            this.rbtngenaral.Size = new System.Drawing.Size(62, 17);
            this.rbtngenaral.TabIndex = 45;
            this.rbtngenaral.TabStop = true;
            this.rbtngenaral.Text = "Genaral";
            this.rbtngenaral.UseVisualStyleBackColor = true;
            // 
            // rbtnopd
            // 
            this.rbtnopd.AutoSize = true;
            this.rbtnopd.Location = new System.Drawing.Point(6, 38);
            this.rbtnopd.Name = "rbtnopd";
            this.rbtnopd.Size = new System.Drawing.Size(48, 17);
            this.rbtnopd.TabIndex = 46;
            this.rbtnopd.TabStop = true;
            this.rbtnopd.Text = "OPD";
            this.rbtnopd.UseVisualStyleBackColor = true;
            // 
            // rbtnindoor
            // 
            this.rbtnindoor.AutoSize = true;
            this.rbtnindoor.Location = new System.Drawing.Point(6, 54);
            this.rbtnindoor.Name = "rbtnindoor";
            this.rbtnindoor.Size = new System.Drawing.Size(55, 17);
            this.rbtnindoor.TabIndex = 47;
            this.rbtnindoor.TabStop = true;
            this.rbtnindoor.Text = "Indoor";
            this.rbtnindoor.UseVisualStyleBackColor = true;
            this.rbtnindoor.CheckedChanged += new System.EventHandler(this.rbtnindoor_CheckedChanged);
            // 
            // lstdoctorsinformation
            // 
            this.lstdoctorsinformation.FormattingEnabled = true;
            this.lstdoctorsinformation.Location = new System.Drawing.Point(264, 65);
            this.lstdoctorsinformation.Name = "lstdoctorsinformation";
            this.lstdoctorsinformation.Size = new System.Drawing.Size(188, 108);
            this.lstdoctorsinformation.TabIndex = 50;
            this.lstdoctorsinformation.DoubleClick += new System.EventHandler(this.lstdoctorsinformation_DoubleClick);
            this.lstdoctorsinformation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstdoctorsinformation_KeyPress);
            // 
            // btndailyladger
            // 
            this.btndailyladger.Location = new System.Drawing.Point(488, 393);
            this.btndailyladger.Name = "btndailyladger";
            this.btndailyladger.Size = new System.Drawing.Size(75, 23);
            this.btndailyladger.TabIndex = 51;
            this.btndailyladger.Text = "Daily Ladger";
            this.btndailyladger.UseVisualStyleBackColor = true;
            this.btndailyladger.Click += new System.EventHandler(this.btndailyladger_Click);
            // 
            // txtSearchServices
            // 
            this.txtSearchServices.Location = new System.Drawing.Point(48, 216);
            this.txtSearchServices.Name = "txtSearchServices";
            this.txtSearchServices.Size = new System.Drawing.Size(367, 20);
            this.txtSearchServices.TabIndex = 1;
            this.txtSearchServices.TextChanged += new System.EventHandler(this.txtSearchServices_TextChanged);
            this.txtSearchServices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchServices_KeyPress);
            this.txtSearchServices.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchServices_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtngenaral);
            this.groupBox1.Controls.Add(this.rbtnopd);
            this.groupBox1.Controls.Add(this.rbtnindoor);
            this.groupBox1.Location = new System.Drawing.Point(482, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 81);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // dgvInvestigation
            // 
            this.dgvInvestigation.AllowUserToAddRows = false;
            this.dgvInvestigation.AllowUserToDeleteRows = false;
            this.dgvInvestigation.AllowUserToOrderColumns = true;
            this.dgvInvestigation.AllowUserToResizeColumns = false;
            this.dgvInvestigation.AllowUserToResizeRows = false;
            this.dgvInvestigation.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvInvestigation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestigation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Service_ID,
            this.Service_Name,
            this.Amount,
            this.Delivery_Date,
            this.Remarks});
            this.dgvInvestigation.Location = new System.Drawing.Point(12, 422);
            this.dgvInvestigation.Name = "dgvInvestigation";
            this.dgvInvestigation.Size = new System.Drawing.Size(838, 121);
            this.dgvInvestigation.TabIndex = 58;
            // 
            // SL
            // 
            this.SL.HeaderText = "Sl";
            this.SL.Name = "SL";
            this.SL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Service_ID
            // 
            this.Service_ID.HeaderText = "Service_ID";
            this.Service_ID.Name = "Service_ID";
            this.Service_ID.ReadOnly = true;
            // 
            // Service_Name
            // 
            this.Service_Name.HeaderText = "Service_Name";
            this.Service_Name.Name = "Service_Name";
            this.Service_Name.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.HeaderText = "Delivery Date";
            this.Delivery_Date.Name = "Delivery_Date";
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // txtdoctorinformation
            // 
            this.txtdoctorinformation.Location = new System.Drawing.Point(264, 40);
            this.txtdoctorinformation.Name = "txtdoctorinformation";
            this.txtdoctorinformation.Size = new System.Drawing.Size(134, 20);
            this.txtdoctorinformation.TabIndex = 9;
            this.txtdoctorinformation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdoctorinformation_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtntherapy);
            this.groupBox2.Controls.Add(this.rbtndialysis);
            this.groupBox2.Controls.Add(this.rbtnbloodbank);
            this.groupBox2.Controls.Add(this.rbtndental);
            this.groupBox2.Controls.Add(this.rbtnpathology);
            this.groupBox2.Location = new System.Drawing.Point(482, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 115);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // rbtntherapy
            // 
            this.rbtntherapy.AutoSize = true;
            this.rbtntherapy.Location = new System.Drawing.Point(6, 88);
            this.rbtntherapy.Name = "rbtntherapy";
            this.rbtntherapy.Size = new System.Drawing.Size(64, 17);
            this.rbtntherapy.TabIndex = 61;
            this.rbtntherapy.TabStop = true;
            this.rbtntherapy.Text = "Therapy";
            this.rbtntherapy.UseVisualStyleBackColor = true;
            // 
            // rbtndialysis
            // 
            this.rbtndialysis.AutoSize = true;
            this.rbtndialysis.Location = new System.Drawing.Point(6, 71);
            this.rbtndialysis.Name = "rbtndialysis";
            this.rbtndialysis.Size = new System.Drawing.Size(60, 17);
            this.rbtndialysis.TabIndex = 61;
            this.rbtndialysis.TabStop = true;
            this.rbtndialysis.Text = "Dialysis";
            this.rbtndialysis.UseVisualStyleBackColor = true;
            // 
            // rbtnbloodbank
            // 
            this.rbtnbloodbank.AutoSize = true;
            this.rbtnbloodbank.Location = new System.Drawing.Point(6, 55);
            this.rbtnbloodbank.Name = "rbtnbloodbank";
            this.rbtnbloodbank.Size = new System.Drawing.Size(80, 17);
            this.rbtnbloodbank.TabIndex = 61;
            this.rbtnbloodbank.TabStop = true;
            this.rbtnbloodbank.Text = "Blood Bank";
            this.rbtnbloodbank.UseVisualStyleBackColor = true;
            // 
            // rbtndental
            // 
            this.rbtndental.AutoSize = true;
            this.rbtndental.Location = new System.Drawing.Point(6, 37);
            this.rbtndental.Name = "rbtndental";
            this.rbtndental.Size = new System.Drawing.Size(56, 17);
            this.rbtndental.TabIndex = 61;
            this.rbtndental.TabStop = true;
            this.rbtndental.Text = "Dental";
            this.rbtndental.UseVisualStyleBackColor = true;
            // 
            // rbtnpathology
            // 
            this.rbtnpathology.AutoSize = true;
            this.rbtnpathology.Location = new System.Drawing.Point(6, 18);
            this.rbtnpathology.Name = "rbtnpathology";
            this.rbtnpathology.Size = new System.Drawing.Size(71, 17);
            this.rbtnpathology.TabIndex = 0;
            this.rbtnpathology.TabStop = true;
            this.rbtnpathology.Text = "pathology";
            this.rbtnpathology.UseVisualStyleBackColor = true;
            // 
            // txtAdmissionSl
            // 
            this.txtAdmissionSl.Location = new System.Drawing.Point(315, 7);
            this.txtAdmissionSl.Name = "txtAdmissionSl";
            this.txtAdmissionSl.ReadOnly = true;
            this.txtAdmissionSl.Size = new System.Drawing.Size(149, 20);
            this.txtAdmissionSl.TabIndex = 61;
            this.txtAdmissionSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionSl_KeyPress);
            // 
            // lblpc
            // 
            this.lblpc.AutoSize = true;
            this.lblpc.Location = new System.Drawing.Point(261, 179);
            this.lblpc.Name = "lblpc";
            this.lblpc.Size = new System.Drawing.Size(21, 13);
            this.lblpc.TabIndex = 62;
            this.lblpc.Text = "PC";
            // 
            // txtpc
            // 
            this.txtpc.Location = new System.Drawing.Point(291, 176);
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(42, 20);
            this.txtpc.TabIndex = 63;
            this.txtpc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpc_KeyPress);
            // 
            // txtdiscouuntpersentnance
            // 
            this.txtdiscouuntpersentnance.Location = new System.Drawing.Point(757, 227);
            this.txtdiscouuntpersentnance.Name = "txtdiscouuntpersentnance";
            this.txtdiscouuntpersentnance.Size = new System.Drawing.Size(61, 20);
            this.txtdiscouuntpersentnance.TabIndex = 11;
            this.txtdiscouuntpersentnance.TextChanged += new System.EventHandler(this.txtdiscouuntpersentnance_TextChanged);
            this.txtdiscouuntpersentnance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscouuntpersentnance_KeyPress);
            this.txtdiscouuntpersentnance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiscouuntpersentnance_KeyUp);
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(145, 180);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(25, 13);
            this.lblsex.TabIndex = 65;
            this.lblsex.Text = "Sex";
            // 
            // txtsex
            // 
            this.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsex.Location = new System.Drawing.Point(175, 176);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(58, 21);
            this.txtsex.TabIndex = 8;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(859, 563);
            this.shapeContainer1.TabIndex = 67;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 573;
            this.lineShape2.X2 = 846;
            this.lineShape2.Y1 = 305;
            this.lineShape2.Y2 = 305;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 575;
            this.lineShape1.X2 = 848;
            this.lineShape1.Y1 = 359;
            this.lineShape1.Y2 = 359;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(404, 38);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(25, 22);
            this.btnAddDoctor.TabIndex = 68;
            this.btnAddDoctor.Text = "+";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnGridDelete
            // 
            this.btnGridDelete.Image = global::hms.Properties.Resources.DELETE;
            this.btnGridDelete.Location = new System.Drawing.Point(20, 373);
            this.btnGridDelete.Name = "btnGridDelete";
            this.btnGridDelete.Size = new System.Drawing.Size(24, 20);
            this.btnGridDelete.TabIndex = 69;
            this.btnGridDelete.UseVisualStyleBackColor = true;
            this.btnGridDelete.Click += new System.EventHandler(this.btnGridDelete_Click);
            // 
            // btnprint
            // 
            this.btnprint.Image = global::hms.Properties.Resources.Search;
            this.btnprint.Location = new System.Drawing.Point(79, 4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(31, 23);
            this.btnprint.TabIndex = 55;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::hms.Properties.Resources.Edit;
            this.btnedit.Location = new System.Drawing.Point(55, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(22, 23);
            this.btnedit.TabIndex = 54;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(29, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(25, 23);
            this.btnsave.TabIndex = 53;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(4, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(23, 23);
            this.btnnew.TabIndex = 52;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnDocRefresh
            // 
            this.btnDocRefresh.Image = global::hms.Properties.Resources.Refresh_icon;
            this.btnDocRefresh.Location = new System.Drawing.Point(435, 37);
            this.btnDocRefresh.Name = "btnDocRefresh";
            this.btnDocRefresh.Size = new System.Drawing.Size(29, 23);
            this.btnDocRefresh.TabIndex = 70;
            this.btnDocRefresh.UseVisualStyleBackColor = true;
            this.btnDocRefresh.Click += new System.EventHandler(this.btnDocRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "M";
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.AutoSize = true;
            this.lblAdmissionId.Location = new System.Drawing.Point(222, 12);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(0, 13);
            this.lblAdmissionId.TabIndex = 74;
            this.lblAdmissionId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Discount By";
            // 
            // lstDiscount
            // 
            this.lstDiscount.FormattingEnabled = true;
            this.lstDiscount.Location = new System.Drawing.Point(663, 245);
            this.lstDiscount.Name = "lstDiscount";
            this.lstDiscount.Size = new System.Drawing.Size(187, 30);
            this.lstDiscount.TabIndex = 12;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.ForeColor = System.Drawing.Color.Red;
            this.lblServicePrice.Location = new System.Drawing.Point(482, 281);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(34, 20);
            this.lblServicePrice.TabIndex = 77;
            this.lblServicePrice.Text = "     ";
            // 
            // frmfrontdeskinvestigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 563);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lstDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdmissionId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDocRefresh);
            this.Controls.Add(this.btnGridDelete);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtdiscouuntpersentnance);
            this.Controls.Add(this.txtpc);
            this.Controls.Add(this.lblpc);
            this.Controls.Add(this.txtAdmissionSl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtdoctorinformation);
            this.Controls.Add(this.dgvInvestigation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchServices);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btndailyladger);
            this.Controls.Add(this.lstdoctorsinformation);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.lblreturn);
            this.Controls.Add(this.txtreceive);
            this.Controls.Add(this.lblreceive);
            this.Controls.Add(this.txttotaldue);
            this.Controls.Add(this.lbltotaldue);
            this.Controls.Add(this.txtpaidamount);
            this.Controls.Add(this.lblpaidamount);
            this.Controls.Add(this.txtPayableAmount);
            this.Controls.Add(this.lblpayableamount);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.lblPasentance);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.txtspecialist);
            this.Controls.Add(this.lblspecialist);
            this.Controls.Add(this.txtdegree);
            this.Controls.Add(this.lbldegree);
            this.Controls.Add(this.txtrefferedby);
            this.Controls.Add(this.lblreferedby);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtdoctorid);
            this.Controls.Add(this.lbldoctorid);
            this.Controls.Add(this.lbldoctorinformaion);
            this.Controls.Add(this.lsttestname);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblpatientinformation);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmfrontdeskinvestigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation";
            this.Load += new System.EventHandler(this.frmfrontdeskinvestigation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestigation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpatientinformation;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.ListBox lsttestname;
        private System.Windows.Forms.Label lbldoctorinformaion;
        private System.Windows.Forms.Label lbldoctorid;
        private System.Windows.Forms.TextBox txtdoctorid;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtrefferedby;
        private System.Windows.Forms.Label lblreferedby;
        private System.Windows.Forms.TextBox txtdegree;
        private System.Windows.Forms.Label lbldegree;
        private System.Windows.Forms.TextBox txtspecialist;
        private System.Windows.Forms.Label lblspecialist;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblPasentance;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.TextBox txtPayableAmount;
        private System.Windows.Forms.Label lblpayableamount;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.Label lblpaidamount;
        private System.Windows.Forms.TextBox txttotaldue;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.Label lblreceive;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label lblreturn;
        private System.Windows.Forms.RadioButton rbtngenaral;
        private System.Windows.Forms.RadioButton rbtnopd;
        private System.Windows.Forms.RadioButton rbtnindoor;
        private System.Windows.Forms.ListBox lstdoctorsinformation;
        private System.Windows.Forms.Button btndailyladger;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtSearchServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInvestigation;
        private System.Windows.Forms.TextBox txtdoctorinformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtntherapy;
        private System.Windows.Forms.RadioButton rbtndialysis;
        private System.Windows.Forms.RadioButton rbtnbloodbank;
        private System.Windows.Forms.RadioButton rbtndental;
        private System.Windows.Forms.RadioButton rbtnpathology;
        private System.Windows.Forms.TextBox txtAdmissionSl;
        private System.Windows.Forms.Label lblpc;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.TextBox txtdiscouuntpersentnance;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.ComboBox txtsex;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnGridDelete;
        private System.Windows.Forms.Button btnDocRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdmissionId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDiscount;
        private System.Windows.Forms.Label lblServicePrice;
    }
}