namespace hms.Forms
{
    partial class frmInvestigationReturn
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
            this.lblInvestigationID = new System.Windows.Forms.Label();
            this.txtInvestigationID = new System.Windows.Forms.TextBox();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.lbltotalreturn = new System.Windows.Forms.Label();
            this.lbltotalpaid = new System.Windows.Forms.Label();
            this.lbltotalpayamount = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltotaldiscount = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lblaccountsinformation = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpAccountsInformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvRetrurn = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcashmemoid = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.gbPatientInformation.SuspendLayout();
            this.gpAccountsInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetrurn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvestigationID
            // 
            this.lblInvestigationID.AutoSize = true;
            this.lblInvestigationID.Location = new System.Drawing.Point(12, 46);
            this.lblInvestigationID.Name = "lblInvestigationID";
            this.lblInvestigationID.Size = new System.Drawing.Size(81, 13);
            this.lblInvestigationID.TabIndex = 0;
            this.lblInvestigationID.Text = "Investigation ID";
            // 
            // txtInvestigationID
            // 
            this.txtInvestigationID.Location = new System.Drawing.Point(115, 46);
            this.txtInvestigationID.Name = "txtInvestigationID";
            this.txtInvestigationID.Size = new System.Drawing.Size(100, 20);
            this.txtInvestigationID.TabIndex = 1;
            this.txtInvestigationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.txtInvestigationID.TextChanged += new System.EventHandler(this.txtInvestigationID_TextChanged);
            this.txtInvestigationID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvestigationID_KeyPress);
            // 
            // lbltotaldue
            // 
            this.lbltotaldue.AutoSize = true;
            this.lbltotaldue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldue.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldue.Location = new System.Drawing.Point(151, 149);
            this.lbltotaldue.Name = "lbltotaldue";
            this.lbltotaldue.Size = new System.Drawing.Size(63, 15);
            this.lbltotaldue.TabIndex = 49;
            this.lbltotaldue.Text = "Total Due:";
            // 
            // lbltotalreturn
            // 
            this.lbltotalreturn.AutoSize = true;
            this.lbltotalreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalreturn.ForeColor = System.Drawing.Color.Black;
            this.lbltotalreturn.Location = new System.Drawing.Point(151, 126);
            this.lbltotalreturn.Name = "lbltotalreturn";
            this.lbltotalreturn.Size = new System.Drawing.Size(77, 15);
            this.lbltotalreturn.TabIndex = 48;
            this.lbltotalreturn.Text = "Total Return:";
            // 
            // lbltotalpaid
            // 
            this.lbltotalpaid.AutoSize = true;
            this.lbltotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpaid.Location = new System.Drawing.Point(151, 109);
            this.lbltotalpaid.Name = "lbltotalpaid";
            this.lbltotalpaid.Size = new System.Drawing.Size(65, 15);
            this.lbltotalpaid.TabIndex = 47;
            this.lbltotalpaid.Text = "Total Paid:";
            // 
            // lbltotalpayamount
            // 
            this.lbltotalpayamount.AutoSize = true;
            this.lbltotalpayamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpayamount.Location = new System.Drawing.Point(151, 89);
            this.lbltotalpayamount.Name = "lbltotalpayamount";
            this.lbltotalpayamount.Size = new System.Drawing.Size(129, 15);
            this.lbltotalpayamount.TabIndex = 46;
            this.lbltotalpayamount.Text = "Total Payable Amount:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.Black;
            this.lblvat.Location = new System.Drawing.Point(151, 57);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(27, 15);
            this.lblvat.TabIndex = 45;
            this.lblvat.Text = "Vat:";
            // 
            // lbltotaldiscount
            // 
            this.lbltotaldiscount.AutoSize = true;
            this.lbltotaldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldiscount.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldiscount.Location = new System.Drawing.Point(151, 39);
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
            this.lbltotalamount.Location = new System.Drawing.Point(151, 21);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(82, 15);
            this.lbltotalamount.TabIndex = 43;
            this.lbltotalamount.Text = "Total Amount:";
            // 
            // lblaccountsinformation
            // 
            this.lblaccountsinformation.AutoSize = true;
            this.lblaccountsinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccountsinformation.ForeColor = System.Drawing.Color.Crimson;
            this.lblaccountsinformation.Location = new System.Drawing.Point(361, 179);
            this.lblaccountsinformation.Name = "lblaccountsinformation";
            this.lblaccountsinformation.Size = new System.Drawing.Size(0, 13);
            this.lblaccountsinformation.TabIndex = 42;
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.lblDoctor);
            this.gbPatientInformation.Controls.Add(this.lblAddress);
            this.gbPatientInformation.Controls.Add(this.lblName);
            this.gbPatientInformation.Controls.Add(this.label1);
            this.gbPatientInformation.Controls.Add(this.label2);
            this.gbPatientInformation.Controls.Add(this.label3);
            this.gbPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientInformation.Location = new System.Drawing.Point(229, 9);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(303, 124);
            this.gbPatientInformation.TabIndex = 50;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(62, 82);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(46, 15);
            this.lblDoctor.TabIndex = 47;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(62, 38);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 15);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(62, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name:";
            // 
            // gpAccountsInformation
            // 
            this.gpAccountsInformation.Controls.Add(this.label4);
            this.gpAccountsInformation.Controls.Add(this.lbltotaldiscount);
            this.gpAccountsInformation.Controls.Add(this.lbltotalamount);
            this.gpAccountsInformation.Controls.Add(this.label5);
            this.gpAccountsInformation.Controls.Add(this.lbltotaldue);
            this.gpAccountsInformation.Controls.Add(this.label6);
            this.gpAccountsInformation.Controls.Add(this.lblvat);
            this.gpAccountsInformation.Controls.Add(this.lbltotalreturn);
            this.gpAccountsInformation.Controls.Add(this.label7);
            this.gpAccountsInformation.Controls.Add(this.lbltotalpayamount);
            this.gpAccountsInformation.Controls.Add(this.lbltotalpaid);
            this.gpAccountsInformation.Controls.Add(this.label8);
            this.gpAccountsInformation.Controls.Add(this.label9);
            this.gpAccountsInformation.Controls.Add(this.label10);
            this.gpAccountsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAccountsInformation.ForeColor = System.Drawing.Color.Red;
            this.gpAccountsInformation.Location = new System.Drawing.Point(541, 11);
            this.gpAccountsInformation.Name = "gpAccountsInformation";
            this.gpAccountsInformation.Size = new System.Drawing.Size(289, 169);
            this.gpAccountsInformation.TabIndex = 51;
            this.gpAccountsInformation.TabStop = false;
            this.gpAccountsInformation.Text = "Accounts Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Total Discount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Total Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(73, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Total Due:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(109, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Vat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(60, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Total Return:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "Total Payable Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(71, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "Total Paid:";
            // 
            // dgvRetrurn
            // 
            this.dgvRetrurn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetrurn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL});
            this.dgvRetrurn.Location = new System.Drawing.Point(15, 189);
            this.dgvRetrurn.Name = "dgvRetrurn";
            this.dgvRetrurn.Size = new System.Drawing.Size(815, 246);
            this.dgvRetrurn.TabIndex = 52;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // txtcashmemoid
            // 
            this.txtcashmemoid.Location = new System.Drawing.Point(113, 9);
            this.txtcashmemoid.Name = "txtcashmemoid";
            this.txtcashmemoid.ReadOnly = true;
            this.txtcashmemoid.Size = new System.Drawing.Size(100, 20);
            this.txtcashmemoid.TabIndex = 53;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(71, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 23);
            this.btnclose.TabIndex = 56;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(39, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 57;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(8, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(25, 23);
            this.btnnew.TabIndex = 54;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // frmInvestigationReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 447);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtcashmemoid);
            this.Controls.Add(this.dgvRetrurn);
            this.Controls.Add(this.gpAccountsInformation);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.lblaccountsinformation);
            this.Controls.Add(this.txtInvestigationID);
            this.Controls.Add(this.lblInvestigationID);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmInvestigationReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvestigationReturn";
            this.Load += new System.EventHandler(this.frmInvestigationReturn_Load);
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            this.gpAccountsInformation.ResumeLayout(false);
            this.gpAccountsInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetrurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestigationID;
        private System.Windows.Forms.TextBox txtInvestigationID;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.Label lbltotalreturn;
        private System.Windows.Forms.Label lbltotalpaid;
        private System.Windows.Forms.Label lbltotalpayamount;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lbltotaldiscount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblaccountsinformation;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpAccountsInformation;
        private System.Windows.Forms.DataGridView dgvRetrurn;
        private System.Windows.Forms.TextBox txtcashmemoid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
    }
}