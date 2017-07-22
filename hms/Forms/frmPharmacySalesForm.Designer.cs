namespace hms.Forms
{
    partial class frmPharmacySalesForm
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
            this.lblShowpriceServiceItem = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.listViewServiceItem = new System.Windows.Forms.ListView();
            this.lblSales = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BachNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstDiscount = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiscouuntpersentnance = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtngenaral = new System.Windows.Forms.RadioButton();
            this.rbtnindoor = new System.Windows.Forms.RadioButton();
            this.txtSearchServices = new System.Windows.Forms.TextBox();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.lblreturn = new System.Windows.Forms.Label();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.lblreceive = new System.Windows.Forms.Label();
            this.txttotaldue = new System.Windows.Forms.TextBox();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.lblpaidamount = new System.Windows.Forms.Label();
            this.txtPayableAmount = new System.Windows.Forms.TextBox();
            this.lblpayableamount = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.lblvat = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpatientinformation = new System.Windows.Forms.Label();
            this.lblfridge = new System.Windows.Forms.Label();
            this.txtfridge = new System.Windows.Forms.TextBox();
            this.lblPartno = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.lbllabelNo = new System.Windows.Forms.Label();
            this.txtLabelno = new System.Windows.Forms.TextBox();
            this.lblshelfno = new System.Windows.Forms.Label();
            this.txtshelfno = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupname = new System.Windows.Forms.TextBox();
            this.txtSalesVoucherNo = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShowpriceServiceItem
            // 
            this.lblShowpriceServiceItem.AutoSize = true;
            this.lblShowpriceServiceItem.Location = new System.Drawing.Point(450, 156);
            this.lblShowpriceServiceItem.Name = "lblShowpriceServiceItem";
            this.lblShowpriceServiceItem.Size = new System.Drawing.Size(126, 13);
            this.lblShowpriceServiceItem.TabIndex = 159;
            this.lblShowpriceServiceItem.Text = "Show Price Service Item ";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(378, 156);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(39, 20);
            this.txtQty.TabIndex = 157;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(353, 161);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 158;
            this.lblQty.Text = "Qty";
            // 
            // listViewServiceItem
            // 
            this.listViewServiceItem.Location = new System.Drawing.Point(77, 180);
            this.listViewServiceItem.Name = "listViewServiceItem";
            this.listViewServiceItem.Size = new System.Drawing.Size(269, 90);
            this.listViewServiceItem.TabIndex = 156;
            this.listViewServiceItem.UseCompatibleStateImageBehavior = false;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(1, 161);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(66, 13);
            this.lblSales.TabIndex = 155;
            this.lblSales.Text = "Service Item";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BachNo});
            this.dataGridView1.Location = new System.Drawing.Point(19, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 200);
            this.dataGridView1.TabIndex = 154;
            // 
            // BachNo
            // 
            this.BachNo.HeaderText = "Bach No";
            this.BachNo.Name = "BachNo";
            // 
            // lstDiscount
            // 
            this.lstDiscount.FormattingEnabled = true;
            this.lstDiscount.Location = new System.Drawing.Point(748, 69);
            this.lstDiscount.Name = "lstDiscount";
            this.lstDiscount.Size = new System.Drawing.Size(145, 30);
            this.lstDiscount.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 153;
            this.label4.Text = "Discount By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Tk";
            // 
            // txtdiscouuntpersentnance
            // 
            this.txtdiscouuntpersentnance.Location = new System.Drawing.Point(832, 47);
            this.txtdiscouuntpersentnance.Name = "txtdiscouuntpersentnance";
            this.txtdiscouuntpersentnance.Size = new System.Drawing.Size(61, 20);
            this.txtdiscouuntpersentnance.TabIndex = 133;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtngenaral);
            this.groupBox1.Controls.Add(this.rbtnindoor);
            this.groupBox1.Location = new System.Drawing.Point(488, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 108);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            // 
            // rbtngenaral
            // 
            this.rbtngenaral.AutoSize = true;
            this.rbtngenaral.Location = new System.Drawing.Point(16, 27);
            this.rbtngenaral.Name = "rbtngenaral";
            this.rbtngenaral.Size = new System.Drawing.Size(62, 17);
            this.rbtngenaral.TabIndex = 45;
            this.rbtngenaral.TabStop = true;
            this.rbtngenaral.Text = "Genaral";
            this.rbtngenaral.UseVisualStyleBackColor = true;
            // 
            // rbtnindoor
            // 
            this.rbtnindoor.AutoSize = true;
            this.rbtnindoor.Location = new System.Drawing.Point(16, 62);
            this.rbtnindoor.Name = "rbtnindoor";
            this.rbtnindoor.Size = new System.Drawing.Size(55, 17);
            this.rbtnindoor.TabIndex = 47;
            this.rbtnindoor.TabStop = true;
            this.rbtnindoor.Text = "Indoor";
            this.rbtnindoor.UseVisualStyleBackColor = true;
            // 
            // txtSearchServices
            // 
            this.txtSearchServices.Location = new System.Drawing.Point(77, 158);
            this.txtSearchServices.Name = "txtSearchServices";
            this.txtSearchServices.Size = new System.Drawing.Size(269, 20);
            this.txtSearchServices.TabIndex = 121;
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(848, 193);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(45, 20);
            this.txtReturn.TabIndex = 137;
            // 
            // lblreturn
            // 
            this.lblreturn.AutoSize = true;
            this.lblreturn.Location = new System.Drawing.Point(803, 196);
            this.lblreturn.Name = "lblreturn";
            this.lblreturn.Size = new System.Drawing.Size(39, 13);
            this.lblreturn.TabIndex = 149;
            this.lblreturn.Text = "Retrun";
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(748, 194);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(49, 20);
            this.txtreceive.TabIndex = 136;
            // 
            // lblreceive
            // 
            this.lblreceive.AutoSize = true;
            this.lblreceive.Location = new System.Drawing.Point(657, 196);
            this.lblreceive.Name = "lblreceive";
            this.lblreceive.Size = new System.Drawing.Size(47, 13);
            this.lblreceive.TabIndex = 148;
            this.lblreceive.Text = "Receive";
            // 
            // txttotaldue
            // 
            this.txttotaldue.Location = new System.Drawing.Point(748, 171);
            this.txttotaldue.Name = "txttotaldue";
            this.txttotaldue.ReadOnly = true;
            this.txttotaldue.Size = new System.Drawing.Size(144, 20);
            this.txttotaldue.TabIndex = 147;
            // 
            // lbltotaldue
            // 
            this.lbltotaldue.AutoSize = true;
            this.lbltotaldue.Location = new System.Drawing.Point(657, 171);
            this.lbltotaldue.Name = "lbltotaldue";
            this.lbltotaldue.Size = new System.Drawing.Size(54, 13);
            this.lbltotaldue.TabIndex = 146;
            this.lbltotaldue.Text = "Total Due";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(748, 148);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(144, 20);
            this.txtpaidamount.TabIndex = 135;
            // 
            // lblpaidamount
            // 
            this.lblpaidamount.AutoSize = true;
            this.lblpaidamount.Location = new System.Drawing.Point(657, 155);
            this.lblpaidamount.Name = "lblpaidamount";
            this.lblpaidamount.Size = new System.Drawing.Size(67, 13);
            this.lblpaidamount.TabIndex = 145;
            this.lblpaidamount.Text = "Paid Amount";
            // 
            // txtPayableAmount
            // 
            this.txtPayableAmount.Location = new System.Drawing.Point(748, 126);
            this.txtPayableAmount.Name = "txtPayableAmount";
            this.txtPayableAmount.ReadOnly = true;
            this.txtPayableAmount.Size = new System.Drawing.Size(144, 20);
            this.txtPayableAmount.TabIndex = 144;
            // 
            // lblpayableamount
            // 
            this.lblpayableamount.AutoSize = true;
            this.lblpayableamount.Location = new System.Drawing.Point(657, 133);
            this.lblpayableamount.Name = "lblpayableamount";
            this.lblpayableamount.Size = new System.Drawing.Size(84, 13);
            this.lblpayableamount.TabIndex = 143;
            this.lblpayableamount.Text = "Payable Amount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(748, 47);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(50, 20);
            this.txtdiscount.TabIndex = 132;
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Location = new System.Drawing.Point(657, 47);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(49, 13);
            this.lbldiscount.TabIndex = 140;
            this.lbldiscount.Text = "Discount";
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(748, 26);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(145, 20);
            this.txttotalamount.TabIndex = 139;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(657, 26);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(70, 13);
            this.lbltotalamount.TabIndex = 138;
            this.lbltotalamount.Text = "Total Amount";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(77, 134);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(269, 20);
            this.txtphone.TabIndex = 126;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(19, 137);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(41, 13);
            this.lblphone.TabIndex = 127;
            this.lblphone.Text = "Phone:";
            // 
            // txtvat
            // 
            this.txtvat.Location = new System.Drawing.Point(748, 103);
            this.txtvat.Name = "txtvat";
            this.txtvat.ReadOnly = true;
            this.txtvat.Size = new System.Drawing.Size(145, 20);
            this.txtvat.TabIndex = 142;
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(657, 103);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(23, 13);
            this.lblvat.TabIndex = 141;
            this.lblvat.Text = "Vat";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(77, 65);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(269, 66);
            this.txtaddress.TabIndex = 125;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(17, 95);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(48, 13);
            this.lbladdress.TabIndex = 124;
            this.lbladdress.Text = "Address:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(77, 43);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(269, 20);
            this.txtname.TabIndex = 123;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(19, 43);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 122;
            this.lblname.Text = "Neme:";
            // 
            // lblpatientinformation
            // 
            this.lblpatientinformation.AutoSize = true;
            this.lblpatientinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientinformation.Location = new System.Drawing.Point(15, 19);
            this.lblpatientinformation.Name = "lblpatientinformation";
            this.lblpatientinformation.Size = new System.Drawing.Size(163, 20);
            this.lblpatientinformation.TabIndex = 120;
            this.lblpatientinformation.Text = "Patient Information";
            // 
            // lblfridge
            // 
            this.lblfridge.AutoSize = true;
            this.lblfridge.Location = new System.Drawing.Point(498, 254);
            this.lblfridge.Name = "lblfridge";
            this.lblfridge.Size = new System.Drawing.Size(53, 13);
            this.lblfridge.TabIndex = 187;
            this.lblfridge.Text = "Fridge No";
            // 
            // txtfridge
            // 
            this.txtfridge.Location = new System.Drawing.Point(558, 250);
            this.txtfridge.Name = "txtfridge";
            this.txtfridge.ReadOnly = true;
            this.txtfridge.Size = new System.Drawing.Size(77, 20);
            this.txtfridge.TabIndex = 186;
            // 
            // lblPartno
            // 
            this.lblPartno.AutoSize = true;
            this.lblPartno.Location = new System.Drawing.Point(353, 253);
            this.lblPartno.Name = "lblPartno";
            this.lblPartno.Size = new System.Drawing.Size(43, 13);
            this.lblPartno.TabIndex = 185;
            this.lblPartno.Text = "Part No";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(420, 250);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.ReadOnly = true;
            this.txtpartno.Size = new System.Drawing.Size(72, 20);
            this.txtpartno.TabIndex = 184;
            // 
            // lbllabelNo
            // 
            this.lbllabelNo.AutoSize = true;
            this.lbllabelNo.Location = new System.Drawing.Point(501, 229);
            this.lbllabelNo.Name = "lbllabelNo";
            this.lbllabelNo.Size = new System.Drawing.Size(50, 13);
            this.lbllabelNo.TabIndex = 183;
            this.lbllabelNo.Text = "Label No";
            // 
            // txtLabelno
            // 
            this.txtLabelno.Location = new System.Drawing.Point(558, 226);
            this.txtLabelno.Name = "txtLabelno";
            this.txtLabelno.ReadOnly = true;
            this.txtLabelno.Size = new System.Drawing.Size(77, 20);
            this.txtLabelno.TabIndex = 182;
            // 
            // lblshelfno
            // 
            this.lblshelfno.AutoSize = true;
            this.lblshelfno.Location = new System.Drawing.Point(353, 229);
            this.lblshelfno.Name = "lblshelfno";
            this.lblshelfno.Size = new System.Drawing.Size(48, 13);
            this.lblshelfno.TabIndex = 181;
            this.lblshelfno.Text = "Shelf No";
            // 
            // txtshelfno
            // 
            this.txtshelfno.Location = new System.Drawing.Point(420, 226);
            this.txtshelfno.Name = "txtshelfno";
            this.txtshelfno.ReadOnly = true;
            this.txtshelfno.Size = new System.Drawing.Size(72, 20);
            this.txtshelfno.TabIndex = 180;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(353, 206);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(62, 13);
            this.lblCompanyName.TabIndex = 179;
            this.lblCompanyName.Text = "Com. Name";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(420, 203);
            this.txtCname.Name = "txtCname";
            this.txtCname.ReadOnly = true;
            this.txtCname.Size = new System.Drawing.Size(215, 20);
            this.txtCname.TabIndex = 178;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(353, 183);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(67, 13);
            this.lblGroupName.TabIndex = 177;
            this.lblGroupName.Text = "Group Name";
            // 
            // txtGroupname
            // 
            this.txtGroupname.Location = new System.Drawing.Point(420, 180);
            this.txtGroupname.Name = "txtGroupname";
            this.txtGroupname.ReadOnly = true;
            this.txtGroupname.Size = new System.Drawing.Size(215, 20);
            this.txtGroupname.TabIndex = 176;
            // 
            // txtSalesVoucherNo
            // 
            this.txtSalesVoucherNo.Location = new System.Drawing.Point(181, 19);
            this.txtSalesVoucherNo.Name = "txtSalesVoucherNo";
            this.txtSalesVoucherNo.ReadOnly = true;
            this.txtSalesVoucherNo.Size = new System.Drawing.Size(165, 20);
            this.txtSalesVoucherNo.TabIndex = 188;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(491, 4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(24, 23);
            this.btnnew.TabIndex = 189;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::hms.Properties.Resources.SAVE;
            this.button1.Location = new System.Drawing.Point(516, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 190;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(542, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 23);
            this.btnclose.TabIndex = 191;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // frmPharmacySalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 503);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtSalesVoucherNo);
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
            this.Controls.Add(this.lblShowpriceServiceItem);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.listViewServiceItem);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiscouuntpersentnance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchServices);
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
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblpatientinformation);
            this.Name = "frmPharmacySalesForm";
            this.Text = "Pharmacy Sales Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowpriceServiceItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ListView listViewServiceItem;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiscouuntpersentnance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtngenaral;
        private System.Windows.Forms.RadioButton rbtnindoor;
        private System.Windows.Forms.TextBox txtSearchServices;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label lblreturn;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.Label lblreceive;
        private System.Windows.Forms.TextBox txttotaldue;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.Label lblpaidamount;
        private System.Windows.Forms.TextBox txtPayableAmount;
        private System.Windows.Forms.Label lblpayableamount;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpatientinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BachNo;
        private System.Windows.Forms.Label lblfridge;
        private System.Windows.Forms.TextBox txtfridge;
        private System.Windows.Forms.Label lblPartno;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label lbllabelNo;
        private System.Windows.Forms.TextBox txtLabelno;
        private System.Windows.Forms.Label lblshelfno;
        private System.Windows.Forms.TextBox txtshelfno;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupname;
        private System.Windows.Forms.TextBox txtSalesVoucherNo;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclose;
    }
}