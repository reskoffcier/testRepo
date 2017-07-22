namespace hms.Forms
{
    partial class frmMedicineInfoSetupForm
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtMedicinename = new System.Windows.Forms.TextBox();
            this.lblMedicinename = new System.Windows.Forms.Label();
            this.txtcatagory = new System.Windows.Forms.TextBox();
            this.lblcatagoryid = new System.Windows.Forms.Label();
            this.txtMedinineCode = new System.Windows.Forms.TextBox();
            this.lblserviceid = new System.Windows.Forms.Label();
            this.txtCatShotname = new System.Windows.Forms.TextBox();
            this.txtgname = new System.Windows.Forms.TextBox();
            this.lblGname = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.txtcountryname = new System.Windows.Forms.TextBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblfridge = new System.Windows.Forms.Label();
            this.txtfridge = new System.Windows.Forms.TextBox();
            this.lblpartNo = new System.Windows.Forms.Label();
            this.txtpartNo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblRackNo = new System.Windows.Forms.Label();
            this.txtshelfNo = new System.Windows.Forms.TextBox();
            this.lblLabelNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchMedicineInfo = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(455, 61);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(177, 21);
            this.cmbCategory.TabIndex = 32;
            // 
            // txtMedicinename
            // 
            this.txtMedicinename.Location = new System.Drawing.Point(310, 82);
            this.txtMedicinename.Name = "txtMedicinename";
            this.txtMedicinename.Size = new System.Drawing.Size(322, 20);
            this.txtMedicinename.TabIndex = 31;
            // 
            // lblMedicinename
            // 
            this.lblMedicinename.AutoSize = true;
            this.lblMedicinename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicinename.Location = new System.Drawing.Point(215, 89);
            this.lblMedicinename.Name = "lblMedicinename";
            this.lblMedicinename.Size = new System.Drawing.Size(39, 13);
            this.lblMedicinename.TabIndex = 30;
            this.lblMedicinename.Text = "Name";
            // 
            // txtcatagory
            // 
            this.txtcatagory.Location = new System.Drawing.Point(310, 62);
            this.txtcatagory.Name = "txtcatagory";
            this.txtcatagory.ReadOnly = true;
            this.txtcatagory.Size = new System.Drawing.Size(57, 20);
            this.txtcatagory.TabIndex = 29;
            // 
            // lblcatagoryid
            // 
            this.lblcatagoryid.AutoSize = true;
            this.lblcatagoryid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatagoryid.Location = new System.Drawing.Point(215, 65);
            this.lblcatagoryid.Name = "lblcatagoryid";
            this.lblcatagoryid.Size = new System.Drawing.Size(74, 13);
            this.lblcatagoryid.TabIndex = 28;
            this.lblcatagoryid.Text = "Catagory ID";
            // 
            // txtMedinineCode
            // 
            this.txtMedinineCode.Location = new System.Drawing.Point(310, 39);
            this.txtMedinineCode.Name = "txtMedinineCode";
            this.txtMedinineCode.ReadOnly = true;
            this.txtMedinineCode.Size = new System.Drawing.Size(57, 20);
            this.txtMedinineCode.TabIndex = 27;
            // 
            // lblserviceid
            // 
            this.lblserviceid.AutoSize = true;
            this.lblserviceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserviceid.Location = new System.Drawing.Point(215, 42);
            this.lblserviceid.Name = "lblserviceid";
            this.lblserviceid.Size = new System.Drawing.Size(91, 13);
            this.lblserviceid.TabIndex = 26;
            this.lblserviceid.Text = "Medicine Code";
            // 
            // txtCatShotname
            // 
            this.txtCatShotname.Location = new System.Drawing.Point(370, 62);
            this.txtCatShotname.Name = "txtCatShotname";
            this.txtCatShotname.ReadOnly = true;
            this.txtCatShotname.Size = new System.Drawing.Size(82, 20);
            this.txtCatShotname.TabIndex = 33;
            // 
            // txtgname
            // 
            this.txtgname.Location = new System.Drawing.Point(310, 108);
            this.txtgname.Name = "txtgname";
            this.txtgname.Size = new System.Drawing.Size(322, 20);
            this.txtgname.TabIndex = 35;
            // 
            // lblGname
            // 
            this.lblGname.AutoSize = true;
            this.lblGname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGname.Location = new System.Drawing.Point(215, 111);
            this.lblGname.Name = "lblGname";
            this.lblGname.Size = new System.Drawing.Size(77, 13);
            this.lblGname.TabIndex = 34;
            this.lblGname.Text = "Group Name";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(310, 131);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(322, 20);
            this.txtCname.TabIndex = 37;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComName.Location = new System.Drawing.Point(215, 134);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(94, 13);
            this.lblComName.TabIndex = 36;
            this.lblComName.Text = "Company Name";
            // 
            // txtcountryname
            // 
            this.txtcountryname.Location = new System.Drawing.Point(310, 155);
            this.txtcountryname.Name = "txtcountryname";
            this.txtcountryname.Size = new System.Drawing.Size(322, 20);
            this.txtcountryname.TabIndex = 39;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.Location = new System.Drawing.Point(215, 158);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(86, 13);
            this.lblCountryName.TabIndex = 38;
            this.lblCountryName.Text = "Country Name";
            // 
            // lblfridge
            // 
            this.lblfridge.AutoSize = true;
            this.lblfridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfridge.Location = new System.Drawing.Point(434, 207);
            this.lblfridge.Name = "lblfridge";
            this.lblfridge.Size = new System.Drawing.Size(62, 13);
            this.lblfridge.TabIndex = 182;
            this.lblfridge.Text = "Fridge No";
            // 
            // txtfridge
            // 
            this.txtfridge.Location = new System.Drawing.Point(518, 204);
            this.txtfridge.Name = "txtfridge";
            this.txtfridge.Size = new System.Drawing.Size(114, 20);
            this.txtfridge.TabIndex = 181;
            // 
            // lblpartNo
            // 
            this.lblpartNo.AutoSize = true;
            this.lblpartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpartNo.Location = new System.Drawing.Point(215, 205);
            this.lblpartNo.Name = "lblpartNo";
            this.lblpartNo.Size = new System.Drawing.Size(50, 13);
            this.lblpartNo.TabIndex = 180;
            this.lblpartNo.Text = "Part No";
            // 
            // txtpartNo
            // 
            this.txtpartNo.Location = new System.Drawing.Point(310, 204);
            this.txtpartNo.Name = "txtpartNo";
            this.txtpartNo.Size = new System.Drawing.Size(111, 20);
            this.txtpartNo.TabIndex = 179;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(518, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 178;
            // 
            // lblRackNo
            // 
            this.lblRackNo.AutoSize = true;
            this.lblRackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRackNo.Location = new System.Drawing.Point(215, 181);
            this.lblRackNo.Name = "lblRackNo";
            this.lblRackNo.Size = new System.Drawing.Size(56, 13);
            this.lblRackNo.TabIndex = 177;
            this.lblRackNo.Text = "Shelf No";
            // 
            // txtshelfNo
            // 
            this.txtshelfNo.Location = new System.Drawing.Point(310, 180);
            this.txtshelfNo.Name = "txtshelfNo";
            this.txtshelfNo.Size = new System.Drawing.Size(111, 20);
            this.txtshelfNo.TabIndex = 176;
            // 
            // lblLabelNo
            // 
            this.lblLabelNo.AutoSize = true;
            this.lblLabelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelNo.Location = new System.Drawing.Point(434, 183);
            this.lblLabelNo.Name = "lblLabelNo";
            this.lblLabelNo.Size = new System.Drawing.Size(58, 13);
            this.lblLabelNo.TabIndex = 183;
            this.lblLabelNo.Text = "Label No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 232);
            this.dataGridView1.TabIndex = 184;
            // 
            // txtSearchMedicineInfo
            // 
            this.txtSearchMedicineInfo.Location = new System.Drawing.Point(15, 238);
            this.txtSearchMedicineInfo.Name = "txtSearchMedicineInfo";
            this.txtSearchMedicineInfo.Size = new System.Drawing.Size(817, 20);
            this.txtSearchMedicineInfo.TabIndex = 190;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(792, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 23);
            this.btnclose.TabIndex = 189;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(642, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(38, 23);
            this.btnnew.TabIndex = 188;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnpreview
            // 
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(757, 2);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(40, 23);
            this.btnpreview.TabIndex = 187;
            this.btnpreview.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Image = global::hms.Properties.Resources.Edit;
            this.btnedit.Location = new System.Drawing.Point(719, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(38, 23);
            this.btnedit.TabIndex = 186;
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(679, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(40, 23);
            this.btnsave.TabIndex = 185;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // frmMedicineInfoSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 508);
            this.Controls.Add(this.txtSearchMedicineInfo);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLabelNo);
            this.Controls.Add(this.lblfridge);
            this.Controls.Add(this.txtfridge);
            this.Controls.Add(this.lblpartNo);
            this.Controls.Add(this.txtpartNo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblRackNo);
            this.Controls.Add(this.txtshelfNo);
            this.Controls.Add(this.txtcountryname);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.txtgname);
            this.Controls.Add(this.lblGname);
            this.Controls.Add(this.txtCatShotname);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtMedicinename);
            this.Controls.Add(this.lblMedicinename);
            this.Controls.Add(this.txtcatagory);
            this.Controls.Add(this.lblcatagoryid);
            this.Controls.Add(this.txtMedinineCode);
            this.Controls.Add(this.lblserviceid);
            this.Name = "frmMedicineInfoSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Info Setup Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtMedicinename;
        private System.Windows.Forms.Label lblMedicinename;
        private System.Windows.Forms.TextBox txtcatagory;
        private System.Windows.Forms.Label lblcatagoryid;
        private System.Windows.Forms.TextBox txtMedinineCode;
        private System.Windows.Forms.Label lblserviceid;
        private System.Windows.Forms.TextBox txtCatShotname;
        private System.Windows.Forms.TextBox txtgname;
        private System.Windows.Forms.Label lblGname;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.TextBox txtcountryname;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblfridge;
        private System.Windows.Forms.TextBox txtfridge;
        private System.Windows.Forms.Label lblpartNo;
        private System.Windows.Forms.TextBox txtpartNo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblRackNo;
        private System.Windows.Forms.TextBox txtshelfNo;
        private System.Windows.Forms.Label lblLabelNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchMedicineInfo;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
    }
}