namespace hms.Forms
{
    partial class frmPharmacyPurchasesInputForm
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.listViewService = new System.Windows.Forms.ListView();
            this.lblServiceItem = new System.Windows.Forms.Label();
            this.txtSearchServices = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupname = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblshelfno = new System.Windows.Forms.Label();
            this.txtshelfno = new System.Windows.Forms.TextBox();
            this.lbllabelNo = new System.Windows.Forms.Label();
            this.txtLabelno = new System.Windows.Forms.TextBox();
            this.lblfridge = new System.Windows.Forms.Label();
            this.txtfridge = new System.Windows.Forms.TextBox();
            this.lblPartno = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.lblExpirydate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BachNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblvoucherno = new System.Windows.Forms.Label();
            this.txtPurvoucherno = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(705, 37);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 20);
            this.txtQty.TabIndex = 162;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(664, 40);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 163;
            this.lblQty.Text = "Qty";
            // 
            // listViewService
            // 
            this.listViewService.Location = new System.Drawing.Point(85, 59);
            this.listViewService.Name = "listViewService";
            this.listViewService.Size = new System.Drawing.Size(269, 68);
            this.listViewService.TabIndex = 161;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            // 
            // lblServiceItem
            // 
            this.lblServiceItem.AutoSize = true;
            this.lblServiceItem.Location = new System.Drawing.Point(9, 40);
            this.lblServiceItem.Name = "lblServiceItem";
            this.lblServiceItem.Size = new System.Drawing.Size(66, 13);
            this.lblServiceItem.TabIndex = 160;
            this.lblServiceItem.Text = "Service Item";
            // 
            // txtSearchServices
            // 
            this.txtSearchServices.Location = new System.Drawing.Point(85, 37);
            this.txtSearchServices.Name = "txtSearchServices";
            this.txtSearchServices.Size = new System.Drawing.Size(269, 20);
            this.txtSearchServices.TabIndex = 159;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(358, 40);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(67, 13);
            this.lblGroupName.TabIndex = 165;
            this.lblGroupName.Text = "Group Name";
            // 
            // txtGroupname
            // 
            this.txtGroupname.Location = new System.Drawing.Point(425, 37);
            this.txtGroupname.Name = "txtGroupname";
            this.txtGroupname.ReadOnly = true;
            this.txtGroupname.Size = new System.Drawing.Size(215, 20);
            this.txtGroupname.TabIndex = 164;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(358, 63);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(62, 13);
            this.lblCompanyName.TabIndex = 167;
            this.lblCompanyName.Text = "Com. Name";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(425, 60);
            this.txtCname.Name = "txtCname";
            this.txtCname.ReadOnly = true;
            this.txtCname.Size = new System.Drawing.Size(215, 20);
            this.txtCname.TabIndex = 166;
            // 
            // lblshelfno
            // 
            this.lblshelfno.AutoSize = true;
            this.lblshelfno.Location = new System.Drawing.Point(358, 86);
            this.lblshelfno.Name = "lblshelfno";
            this.lblshelfno.Size = new System.Drawing.Size(48, 13);
            this.lblshelfno.TabIndex = 169;
            this.lblshelfno.Text = "Shelf No";
            // 
            // txtshelfno
            // 
            this.txtshelfno.Location = new System.Drawing.Point(425, 83);
            this.txtshelfno.Name = "txtshelfno";
            this.txtshelfno.ReadOnly = true;
            this.txtshelfno.Size = new System.Drawing.Size(57, 20);
            this.txtshelfno.TabIndex = 168;
            // 
            // lbllabelNo
            // 
            this.lbllabelNo.AutoSize = true;
            this.lbllabelNo.Location = new System.Drawing.Point(496, 86);
            this.lbllabelNo.Name = "lbllabelNo";
            this.lbllabelNo.Size = new System.Drawing.Size(50, 13);
            this.lbllabelNo.TabIndex = 171;
            this.lbllabelNo.Text = "Label No";
            // 
            // txtLabelno
            // 
            this.txtLabelno.Location = new System.Drawing.Point(583, 83);
            this.txtLabelno.Name = "txtLabelno";
            this.txtLabelno.ReadOnly = true;
            this.txtLabelno.Size = new System.Drawing.Size(57, 20);
            this.txtLabelno.TabIndex = 170;
            // 
            // lblfridge
            // 
            this.lblfridge.AutoSize = true;
            this.lblfridge.Location = new System.Drawing.Point(496, 110);
            this.lblfridge.Name = "lblfridge";
            this.lblfridge.Size = new System.Drawing.Size(53, 13);
            this.lblfridge.TabIndex = 175;
            this.lblfridge.Text = "Fridge No";
            // 
            // txtfridge
            // 
            this.txtfridge.Location = new System.Drawing.Point(583, 107);
            this.txtfridge.Name = "txtfridge";
            this.txtfridge.ReadOnly = true;
            this.txtfridge.Size = new System.Drawing.Size(57, 20);
            this.txtfridge.TabIndex = 174;
            // 
            // lblPartno
            // 
            this.lblPartno.AutoSize = true;
            this.lblPartno.Location = new System.Drawing.Point(358, 110);
            this.lblPartno.Name = "lblPartno";
            this.lblPartno.Size = new System.Drawing.Size(43, 13);
            this.lblPartno.TabIndex = 173;
            this.lblPartno.Text = "Part No";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(425, 107);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.ReadOnly = true;
            this.txtpartno.Size = new System.Drawing.Size(57, 20);
            this.txtpartno.TabIndex = 172;
            // 
            // lblExpirydate
            // 
            this.lblExpirydate.AutoSize = true;
            this.lblExpirydate.Location = new System.Drawing.Point(647, 61);
            this.lblExpirydate.Name = "lblExpirydate";
            this.lblExpirydate.Size = new System.Drawing.Size(61, 13);
            this.lblExpirydate.TabIndex = 177;
            this.lblExpirydate.Text = "Expiry Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BachNo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 269);
            this.dataGridView1.TabIndex = 178;
            // 
            // BachNo
            // 
            this.BachNo.HeaderText = "BachNo";
            this.BachNo.Name = "BachNo";
            // 
            // lblvoucherno
            // 
            this.lblvoucherno.AutoSize = true;
            this.lblvoucherno.Location = new System.Drawing.Point(9, 15);
            this.lblvoucherno.Name = "lblvoucherno";
            this.lblvoucherno.Size = new System.Drawing.Size(64, 13);
            this.lblvoucherno.TabIndex = 180;
            this.lblvoucherno.Text = "Voucher No";
            // 
            // txtPurvoucherno
            // 
            this.txtPurvoucherno.Location = new System.Drawing.Point(85, 12);
            this.txtPurvoucherno.Name = "txtPurvoucherno";
            this.txtPurvoucherno.ReadOnly = true;
            this.txtPurvoucherno.Size = new System.Drawing.Size(269, 20);
            this.txtPurvoucherno.TabIndex = 179;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(705, 82);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(200, 20);
            this.txtprice.TabIndex = 181;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(665, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 182;
            this.lblPrice.Text = "Price";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(705, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 183;
            // 
            // frmPharmacyPurchasesInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblvoucherno);
            this.Controls.Add(this.txtPurvoucherno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblExpirydate);
            this.Controls.Add(this.lblfridge);
            this.Controls.Add(this.txtfridge);
            this.Controls.Add(this.lblPartno);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.lbllabelNo);
            this.Controls.Add(this.txtLabelno);
            this.Controls.Add(this.lblshelfno);
            this.Controls.Add(this.txtshelfno);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtGroupname);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.listViewService);
            this.Controls.Add(this.lblServiceItem);
            this.Controls.Add(this.txtSearchServices);
            this.Name = "frmPharmacyPurchasesInputForm";
            this.Text = "frmPharmacyPurchasesInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.Label lblServiceItem;
        private System.Windows.Forms.TextBox txtSearchServices;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupname;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblshelfno;
        private System.Windows.Forms.TextBox txtshelfno;
        private System.Windows.Forms.Label lbllabelNo;
        private System.Windows.Forms.TextBox txtLabelno;
        private System.Windows.Forms.Label lblfridge;
        private System.Windows.Forms.TextBox txtfridge;
        private System.Windows.Forms.Label lblPartno;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label lblExpirydate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblvoucherno;
        private System.Windows.Forms.TextBox txtPurvoucherno;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BachNo;
    }
}