namespace hms.Forms
{
    partial class frmMarketingTargetAdjustForm
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
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtDateofJoin = new System.Windows.Forms.TextBox();
            this.txtPermanent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtYearlyTergetamount = new System.Windows.Forms.TextBox();
            this.lblYearlyTargetAmount = new System.Windows.Forms.Label();
            this.lblParmanent = new System.Windows.Forms.Label();
            this.txtDoctors = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lbllistdoctor = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEmpployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtMonthlyAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdjustAmount = new System.Windows.Forms.TextBox();
            this.lblSetAdjustAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(184, 40);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(408, 21);
            this.cmbEmployee.TabIndex = 80;
            // 
            // txtDateofJoin
            // 
            this.txtDateofJoin.Location = new System.Drawing.Point(184, 155);
            this.txtDateofJoin.Name = "txtDateofJoin";
            this.txtDateofJoin.ReadOnly = true;
            this.txtDateofJoin.Size = new System.Drawing.Size(247, 20);
            this.txtDateofJoin.TabIndex = 79;
            // 
            // txtPermanent
            // 
            this.txtPermanent.Location = new System.Drawing.Point(546, 161);
            this.txtPermanent.Name = "txtPermanent";
            this.txtPermanent.ReadOnly = true;
            this.txtPermanent.Size = new System.Drawing.Size(247, 20);
            this.txtPermanent.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 183);
            this.dataGridView1.TabIndex = 77;
            // 
            // txtYearlyTergetamount
            // 
            this.txtYearlyTergetamount.Location = new System.Drawing.Point(184, 178);
            this.txtYearlyTergetamount.Name = "txtYearlyTergetamount";
            this.txtYearlyTergetamount.ReadOnly = true;
            this.txtYearlyTergetamount.Size = new System.Drawing.Size(247, 20);
            this.txtYearlyTergetamount.TabIndex = 76;
            // 
            // lblYearlyTargetAmount
            // 
            this.lblYearlyTargetAmount.AutoSize = true;
            this.lblYearlyTargetAmount.Location = new System.Drawing.Point(54, 181);
            this.lblYearlyTargetAmount.Name = "lblYearlyTargetAmount";
            this.lblYearlyTargetAmount.Size = new System.Drawing.Size(109, 13);
            this.lblYearlyTargetAmount.TabIndex = 75;
            this.lblYearlyTargetAmount.Text = "Yearly Target Amount";
            // 
            // lblParmanent
            // 
            this.lblParmanent.AutoSize = true;
            this.lblParmanent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParmanent.ForeColor = System.Drawing.Color.Black;
            this.lblParmanent.Location = new System.Drawing.Point(462, 163);
            this.lblParmanent.Name = "lblParmanent";
            this.lblParmanent.Size = new System.Drawing.Size(78, 13);
            this.lblParmanent.TabIndex = 74;
            this.lblParmanent.Text = "Is Permanent ?";
            // 
            // txtDoctors
            // 
            this.txtDoctors.Location = new System.Drawing.Point(546, 138);
            this.txtDoctors.Name = "txtDoctors";
            this.txtDoctors.ReadOnly = true;
            this.txtDoctors.Size = new System.Drawing.Size(247, 20);
            this.txtDoctors.TabIndex = 73;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(546, 116);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(247, 20);
            this.txtDepartment.TabIndex = 72;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(184, 132);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(247, 20);
            this.txtDesignation.TabIndex = 71;
            // 
            // lbllistdoctor
            // 
            this.lbllistdoctor.AutoSize = true;
            this.lbllistdoctor.Location = new System.Drawing.Point(479, 142);
            this.lbllistdoctor.Name = "lbllistdoctor";
            this.lbllistdoctor.Size = new System.Drawing.Size(59, 13);
            this.lbllistdoctor.TabIndex = 67;
            this.lbllistdoctor.Text = "Is Doctor ?";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(56, 158);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(64, 13);
            this.lblJoinDate.TabIndex = 60;
            this.lblJoinDate.Text = "Date of Join";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(184, 111);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(247, 20);
            this.txtEmployeeName.TabIndex = 66;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(56, 137);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 65;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(56, 111);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeName.TabIndex = 64;
            this.lblEmployeeName.Text = "Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(478, 119);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 63;
            this.lblDepartment.Text = "Department";
            // 
            // txtEmpployeeID
            // 
            this.txtEmpployeeID.Enabled = false;
            this.txtEmpployeeID.Location = new System.Drawing.Point(184, 90);
            this.txtEmpployeeID.Name = "txtEmpployeeID";
            this.txtEmpployeeID.ReadOnly = true;
            this.txtEmpployeeID.Size = new System.Drawing.Size(179, 20);
            this.txtEmpployeeID.TabIndex = 62;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(56, 90);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 61;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(755, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 23);
            this.btnclose.TabIndex = 70;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(682, 13);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(37, 23);
            this.btnnew.TabIndex = 69;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(716, 13);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(42, 23);
            this.btnsave.TabIndex = 68;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txtMonthlyAmount
            // 
            this.txtMonthlyAmount.Location = new System.Drawing.Point(546, 184);
            this.txtMonthlyAmount.Name = "txtMonthlyAmount";
            this.txtMonthlyAmount.ReadOnly = true;
            this.txtMonthlyAmount.Size = new System.Drawing.Size(247, 20);
            this.txtMonthlyAmount.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Monthly Amount";
            // 
            // txtAdjustAmount
            // 
            this.txtAdjustAmount.Location = new System.Drawing.Point(184, 202);
            this.txtAdjustAmount.Name = "txtAdjustAmount";
            this.txtAdjustAmount.Size = new System.Drawing.Size(247, 20);
            this.txtAdjustAmount.TabIndex = 84;
            // 
            // lblSetAdjustAmount
            // 
            this.lblSetAdjustAmount.AutoSize = true;
            this.lblSetAdjustAmount.Location = new System.Drawing.Point(54, 203);
            this.lblSetAdjustAmount.Name = "lblSetAdjustAmount";
            this.lblSetAdjustAmount.Size = new System.Drawing.Size(109, 13);
            this.lblSetAdjustAmount.TabIndex = 83;
            this.lblSetAdjustAmount.Text = "Adjust Target Amount";
            // 
            // frmMarketingTargetAdjustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 428);
            this.Controls.Add(this.txtAdjustAmount);
            this.Controls.Add(this.lblSetAdjustAmount);
            this.Controls.Add(this.txtMonthlyAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.txtDateofJoin);
            this.Controls.Add(this.txtPermanent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYearlyTergetamount);
            this.Controls.Add(this.lblYearlyTargetAmount);
            this.Controls.Add(this.lblParmanent);
            this.Controls.Add(this.txtDoctors);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lbllistdoctor);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtEmpployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnsave);
            this.Name = "frmMarketingTargetAdjustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marketing Target Adjust Form";
            this.Load += new System.EventHandler(this.frmMarketingTargetAdjustForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtDateofJoin;
        private System.Windows.Forms.TextBox txtPermanent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtYearlyTergetamount;
        private System.Windows.Forms.Label lblYearlyTargetAmount;
        private System.Windows.Forms.Label lblParmanent;
        private System.Windows.Forms.TextBox txtDoctors;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label lbllistdoctor;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtEmpployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtMonthlyAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdjustAmount;
        private System.Windows.Forms.Label lblSetAdjustAmount;
    }
}