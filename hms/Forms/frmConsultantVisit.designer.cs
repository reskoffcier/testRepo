namespace hms.Forms
{
    partial class frmConsultantVisit
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
            this.lblAdmissionID = new System.Windows.Forms.Label();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.btnPatienList = new System.Windows.Forms.Button();
            this.txtVisitNo = new System.Windows.Forms.TextBox();
            this.lblvisitby = new System.Windows.Forms.Label();
            this.txtvisitamount = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtdoctorsname = new System.Windows.Forms.TextBox();
            this.lstdoctorsname = new System.Windows.Forms.ListBox();
            this.txtDocType = new System.Windows.Forms.TextBox();
            this.lbldoctortype = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtspecialist = new System.Windows.Forms.TextBox();
            this.lblspecialist = new System.Windows.Forms.Label();
            this.txtdegree = new System.Windows.Forms.TextBox();
            this.lbldegree = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtdoctorname = new System.Windows.Forms.TextBox();
            this.lbldoctorname = new System.Windows.Forms.Label();
            this.lblproduccedure = new System.Windows.Forms.Label();
            this.txtproccedure = new System.Windows.Forms.TextBox();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.lblmedicine = new System.Windows.Forms.Label();
            this.txtcomments = new System.Windows.Forms.TextBox();
            this.lblcomments = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblvisittype = new System.Windows.Forms.Label();
            this.lblAddmissionId = new System.Windows.Forms.Label();
            this.lstConsultantInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbVisitType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAdmissionID
            // 
            this.lblAdmissionID.AutoSize = true;
            this.lblAdmissionID.Location = new System.Drawing.Point(13, 13);
            this.lblAdmissionID.Name = "lblAdmissionID";
            this.lblAdmissionID.Size = new System.Drawing.Size(68, 13);
            this.lblAdmissionID.TabIndex = 0;
            this.lblAdmissionID.Text = "Admission ID";
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(85, 13);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionID.TabIndex = 1;
            this.txtAdmissionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionID_KeyPress);
            // 
            // btnPatienList
            // 
            this.btnPatienList.Location = new System.Drawing.Point(186, 12);
            this.btnPatienList.Name = "btnPatienList";
            this.btnPatienList.Size = new System.Drawing.Size(24, 23);
            this.btnPatienList.TabIndex = 2;
            this.btnPatienList.TabStop = false;
            this.btnPatienList.Text = "....";
            this.btnPatienList.UseVisualStyleBackColor = true;
            this.btnPatienList.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtVisitNo
            // 
            this.txtVisitNo.Location = new System.Drawing.Point(237, 37);
            this.txtVisitNo.Name = "txtVisitNo";
            this.txtVisitNo.Size = new System.Drawing.Size(45, 20);
            this.txtVisitNo.TabIndex = 3;
            this.txtVisitNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVisitNo_KeyPress);
            // 
            // lblvisitby
            // 
            this.lblvisitby.AutoSize = true;
            this.lblvisitby.Location = new System.Drawing.Point(185, 40);
            this.lblvisitby.Name = "lblvisitby";
            this.lblvisitby.Size = new System.Drawing.Size(46, 13);
            this.lblvisitby.TabIndex = 5;
            this.lblvisitby.Text = "Visit No.";
            // 
            // txtvisitamount
            // 
            this.txtvisitamount.Location = new System.Drawing.Point(352, 37);
            this.txtvisitamount.Name = "txtvisitamount";
            this.txtvisitamount.Size = new System.Drawing.Size(55, 20);
            this.txtvisitamount.TabIndex = 4;
            this.txtvisitamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OnlyNumeric);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(303, 40);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(43, 13);
            this.lblamount.TabIndex = 7;
            this.lblamount.Text = "Amount";
            // 
            // txtdoctorsname
            // 
            this.txtdoctorsname.Location = new System.Drawing.Point(85, 61);
            this.txtdoctorsname.Name = "txtdoctorsname";
            this.txtdoctorsname.Size = new System.Drawing.Size(325, 20);
            this.txtdoctorsname.TabIndex = 5;
            this.txtdoctorsname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdoctorsname_KeyUp);
            // 
            // lstdoctorsname
            // 
            this.lstdoctorsname.FormattingEnabled = true;
            this.lstdoctorsname.Location = new System.Drawing.Point(85, 85);
            this.lstdoctorsname.Name = "lstdoctorsname";
            this.lstdoctorsname.Size = new System.Drawing.Size(325, 95);
            this.lstdoctorsname.TabIndex = 10;
            this.lstdoctorsname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstdoctorsname_MouseClick);
            this.lstdoctorsname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstdoctorsname_KeyPress);
            // 
            // txtDocType
            // 
            this.txtDocType.Location = new System.Drawing.Point(117, 297);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Size = new System.Drawing.Size(75, 20);
            this.txtDocType.TabIndex = 11;
            // 
            // lbldoctortype
            // 
            this.lbldoctortype.AutoSize = true;
            this.lbldoctortype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctortype.Location = new System.Drawing.Point(39, 297);
            this.lbldoctortype.Name = "lbldoctortype";
            this.lbldoctortype.Size = new System.Drawing.Size(66, 13);
            this.lbldoctortype.TabIndex = 28;
            this.lbldoctortype.Text = "Doctor Type";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(230, 297);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(180, 20);
            this.txtArea.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Area";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 274);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(293, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(62, 277);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 24;
            this.lbladdress.Text = "Address";
            // 
            // txtspecialist
            // 
            this.txtspecialist.Location = new System.Drawing.Point(117, 252);
            this.txtspecialist.Name = "txtspecialist";
            this.txtspecialist.Size = new System.Drawing.Size(293, 20);
            this.txtspecialist.TabIndex = 9;
            // 
            // lblspecialist
            // 
            this.lblspecialist.AutoSize = true;
            this.lblspecialist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecialist.Location = new System.Drawing.Point(54, 259);
            this.lblspecialist.Name = "lblspecialist";
            this.lblspecialist.Size = new System.Drawing.Size(52, 13);
            this.lblspecialist.TabIndex = 22;
            this.lblspecialist.Text = "Specialist";
            // 
            // txtdegree
            // 
            this.txtdegree.Location = new System.Drawing.Point(117, 230);
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.Size = new System.Drawing.Size(293, 20);
            this.txtdegree.TabIndex = 8;
            // 
            // lbldegree
            // 
            this.lbldegree.AutoSize = true;
            this.lbldegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldegree.Location = new System.Drawing.Point(66, 233);
            this.lbldegree.Name = "lbldegree";
            this.lbldegree.Size = new System.Drawing.Size(42, 13);
            this.lbldegree.TabIndex = 20;
            this.lbldegree.Text = "Degree";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(117, 185);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(293, 20);
            this.txttitle.TabIndex = 6;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(82, 186);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 18;
            this.lbltitle.Text = "Title";
            // 
            // txtdoctorname
            // 
            this.txtdoctorname.Location = new System.Drawing.Point(117, 207);
            this.txtdoctorname.Name = "txtdoctorname";
            this.txtdoctorname.Size = new System.Drawing.Size(293, 20);
            this.txtdoctorname.TabIndex = 7;
            // 
            // lbldoctorname
            // 
            this.lbldoctorname.AutoSize = true;
            this.lbldoctorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctorname.Location = new System.Drawing.Point(38, 208);
            this.lbldoctorname.Name = "lbldoctorname";
            this.lbldoctorname.Size = new System.Drawing.Size(70, 13);
            this.lbldoctorname.TabIndex = 30;
            this.lbldoctorname.Text = "Doctor Name";
            // 
            // lblproduccedure
            // 
            this.lblproduccedure.AutoSize = true;
            this.lblproduccedure.Location = new System.Drawing.Point(192, 332);
            this.lblproduccedure.Name = "lblproduccedure";
            this.lblproduccedure.Size = new System.Drawing.Size(62, 13);
            this.lblproduccedure.TabIndex = 33;
            this.lblproduccedure.Text = "Proccedure";
            // 
            // txtproccedure
            // 
            this.txtproccedure.Location = new System.Drawing.Point(16, 355);
            this.txtproccedure.Multiline = true;
            this.txtproccedure.Name = "txtproccedure";
            this.txtproccedure.Size = new System.Drawing.Size(404, 92);
            this.txtproccedure.TabIndex = 14;
            // 
            // txtmedicine
            // 
            this.txtmedicine.Location = new System.Drawing.Point(423, 355);
            this.txtmedicine.Multiline = true;
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(399, 92);
            this.txtmedicine.TabIndex = 15;
            // 
            // lblmedicine
            // 
            this.lblmedicine.AutoSize = true;
            this.lblmedicine.Location = new System.Drawing.Point(531, 332);
            this.lblmedicine.Name = "lblmedicine";
            this.lblmedicine.Size = new System.Drawing.Size(50, 13);
            this.lblmedicine.TabIndex = 35;
            this.lblmedicine.Text = "Medicine";
            // 
            // txtcomments
            // 
            this.txtcomments.Location = new System.Drawing.Point(418, 35);
            this.txtcomments.Multiline = true;
            this.txtcomments.Name = "txtcomments";
            this.txtcomments.Size = new System.Drawing.Size(404, 282);
            this.txtcomments.TabIndex = 13;
            // 
            // lblcomments
            // 
            this.lblcomments.AutoSize = true;
            this.lblcomments.Location = new System.Drawing.Point(584, 17);
            this.lblcomments.Name = "lblcomments";
            this.lblcomments.Size = new System.Drawing.Size(56, 13);
            this.lblcomments.TabIndex = 37;
            this.lblcomments.Text = "Comments";
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(697, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(35, 23);
            this.btnnew.TabIndex = 39;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(732, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(35, 23);
            this.btnsave.TabIndex = 40;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(768, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 23);
            this.btnclose.TabIndex = 43;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblvisittype
            // 
            this.lblvisittype.AutoSize = true;
            this.lblvisittype.Location = new System.Drawing.Point(28, 44);
            this.lblvisittype.Name = "lblvisittype";
            this.lblvisittype.Size = new System.Drawing.Size(31, 13);
            this.lblvisittype.TabIndex = 44;
            this.lblvisittype.Text = "Type";
            // 
            // lblAddmissionId
            // 
            this.lblAddmissionId.AutoSize = true;
            this.lblAddmissionId.Location = new System.Drawing.Point(239, 17);
            this.lblAddmissionId.Name = "lblAddmissionId";
            this.lblAddmissionId.Size = new System.Drawing.Size(0, 13);
            this.lblAddmissionId.TabIndex = 46;
            this.lblAddmissionId.Visible = false;
            // 
            // lstConsultantInfo
            // 
            this.lstConsultantInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstConsultantInfo.FullRowSelect = true;
            this.lstConsultantInfo.GridLines = true;
            this.lstConsultantInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstConsultantInfo.HideSelection = false;
            this.lstConsultantInfo.Location = new System.Drawing.Point(16, 453);
            this.lstConsultantInfo.MultiSelect = false;
            this.lstConsultantInfo.Name = "lstConsultantInfo";
            this.lstConsultantInfo.Size = new System.Drawing.Size(806, 285);
            this.lstConsultantInfo.TabIndex = 47;
            this.lstConsultantInfo.UseCompatibleStateImageBehavior = false;
            this.lstConsultantInfo.View = System.Windows.Forms.View.Details;
            this.lstConsultantInfo.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstConsultantInfo_ColumnWidthChanging);
            this.lstConsultantInfo.SelectedIndexChanged += new System.EventHandler(this.lstConsultantInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sl.";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Consultant";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Visit Type";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Comments";
            this.columnHeader6.Width = 155;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Procedure";
            this.columnHeader7.Width = 151;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Medicine";
            this.columnHeader8.Width = 134;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id";
            this.columnHeader9.Width = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::hms.Properties.Resources.DELETE;
            this.btnDelete.Location = new System.Drawing.Point(805, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 20);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbVisitType
            // 
            this.cmbVisitType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVisitType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVisitType.FormattingEnabled = true;
            this.cmbVisitType.Location = new System.Drawing.Point(85, 37);
            this.cmbVisitType.Name = "cmbVisitType";
            this.cmbVisitType.Size = new System.Drawing.Size(100, 21);
            this.cmbVisitType.TabIndex = 2;
            this.cmbVisitType.SelectedIndexChanged += new System.EventHandler(this.cmbVisitType_SelectedIndexChanged);
            this.cmbVisitType.TextChanged += new System.EventHandler(this.cmbVisitType_TextChanged);
            // 
            // frmConsultantVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 741);
            this.Controls.Add(this.cmbVisitType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstConsultantInfo);
            this.Controls.Add(this.lblAddmissionId);
            this.Controls.Add(this.lblvisittype);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtcomments);
            this.Controls.Add(this.lblcomments);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.lblmedicine);
            this.Controls.Add(this.txtproccedure);
            this.Controls.Add(this.lblproduccedure);
            this.Controls.Add(this.txtdoctorname);
            this.Controls.Add(this.lbldoctorname);
            this.Controls.Add(this.txtDocType);
            this.Controls.Add(this.lbldoctortype);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtspecialist);
            this.Controls.Add(this.lblspecialist);
            this.Controls.Add(this.txtdegree);
            this.Controls.Add(this.lbldegree);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lstdoctorsname);
            this.Controls.Add(this.txtdoctorsname);
            this.Controls.Add(this.txtvisitamount);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.txtVisitNo);
            this.Controls.Add(this.lblvisitby);
            this.Controls.Add(this.btnPatienList);
            this.Controls.Add(this.txtAdmissionID);
            this.Controls.Add(this.lblAdmissionID);
            this.Name = "frmConsultantVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultantVisit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmissionID;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Button btnPatienList;
        private System.Windows.Forms.TextBox txtVisitNo;
        private System.Windows.Forms.Label lblvisitby;
        private System.Windows.Forms.TextBox txtvisitamount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtdoctorsname;
        private System.Windows.Forms.ListBox lstdoctorsname;
        private System.Windows.Forms.TextBox txtDocType;
        private System.Windows.Forms.Label lbldoctortype;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtspecialist;
        private System.Windows.Forms.Label lblspecialist;
        private System.Windows.Forms.TextBox txtdegree;
        private System.Windows.Forms.Label lbldegree;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtdoctorname;
        private System.Windows.Forms.Label lbldoctorname;
        private System.Windows.Forms.Label lblproduccedure;
        private System.Windows.Forms.TextBox txtproccedure;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.Label lblmedicine;
        private System.Windows.Forms.TextBox txtcomments;
        private System.Windows.Forms.Label lblcomments;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblvisittype;
        private System.Windows.Forms.Label lblAddmissionId;
        private System.Windows.Forms.ListView lstConsultantInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cmbVisitType;
    }
}