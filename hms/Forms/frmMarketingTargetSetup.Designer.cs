namespace hms.Forms
{
    partial class frmMarketingTargetSetup
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lbllistdoctor = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEmpployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtDoctors = new System.Windows.Forms.TextBox();
            this.lblParmanent = new System.Windows.Forms.Label();
            this.txtsettergetamount = new System.Windows.Forms.TextBox();
            this.lblSetTarget = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPermanent = new System.Windows.Forms.TextBox();
            this.txtDateofJoin = new System.Windows.Forms.TextBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(725, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 47;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(664, 0);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(31, 23);
            this.btnnew.TabIndex = 46;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // lbllistdoctor
            // 
            this.lbllistdoctor.AutoSize = true;
            this.lbllistdoctor.Location = new System.Drawing.Point(437, 125);
            this.lbllistdoctor.Name = "lbllistdoctor";
            this.lbllistdoctor.Size = new System.Drawing.Size(59, 13);
            this.lbllistdoctor.TabIndex = 43;
            this.lbllistdoctor.Text = "Is Doctor ?";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(14, 150);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(64, 13);
            this.lblJoinDate.TabIndex = 31;
            this.lblJoinDate.Text = "Date of Join";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(142, 92);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(247, 20);
            this.txtEmployeeName.TabIndex = 38;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(14, 121);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 36;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(14, 92);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeName.TabIndex = 35;
            this.lblEmployeeName.Text = "Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(436, 92);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 34;
            this.lblDepartment.Text = "Department";
            // 
            // txtEmpployeeID
            // 
            this.txtEmpployeeID.Enabled = false;
            this.txtEmpployeeID.Location = new System.Drawing.Point(142, 63);
            this.txtEmpployeeID.Name = "txtEmpployeeID";
            this.txtEmpployeeID.ReadOnly = true;
            this.txtEmpployeeID.Size = new System.Drawing.Size(179, 20);
            this.txtEmpployeeID.TabIndex = 33;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(14, 63);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 32;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(693, 0);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(36, 22);
            this.btnsave.TabIndex = 45;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(142, 114);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(247, 20);
            this.txtDesignation.TabIndex = 48;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(504, 89);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(247, 20);
            this.txtDepartment.TabIndex = 49;
            // 
            // txtDoctors
            // 
            this.txtDoctors.Location = new System.Drawing.Point(504, 121);
            this.txtDoctors.Name = "txtDoctors";
            this.txtDoctors.ReadOnly = true;
            this.txtDoctors.Size = new System.Drawing.Size(247, 20);
            this.txtDoctors.TabIndex = 50;
            // 
            // lblParmanent
            // 
            this.lblParmanent.AutoSize = true;
            this.lblParmanent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParmanent.ForeColor = System.Drawing.Color.Black;
            this.lblParmanent.Location = new System.Drawing.Point(420, 152);
            this.lblParmanent.Name = "lblParmanent";
            this.lblParmanent.Size = new System.Drawing.Size(78, 13);
            this.lblParmanent.TabIndex = 51;
            this.lblParmanent.Text = "Is Permanent ?";
            // 
            // txtsettergetamount
            // 
            this.txtsettergetamount.Location = new System.Drawing.Point(142, 173);
            this.txtsettergetamount.Name = "txtsettergetamount";
            this.txtsettergetamount.Size = new System.Drawing.Size(247, 20);
            this.txtsettergetamount.TabIndex = 53;
            // 
            // lblSetTarget
            // 
            this.lblSetTarget.AutoSize = true;
            this.lblSetTarget.Location = new System.Drawing.Point(12, 173);
            this.lblSetTarget.Name = "lblSetTarget";
            this.lblSetTarget.Size = new System.Drawing.Size(128, 13);
            this.lblSetTarget.TabIndex = 52;
            this.lblSetTarget.Text = "Set Yearly Target Amount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 174);
            this.dataGridView1.TabIndex = 56;
            // 
            // txtPermanent
            // 
            this.txtPermanent.Location = new System.Drawing.Point(504, 150);
            this.txtPermanent.Name = "txtPermanent";
            this.txtPermanent.ReadOnly = true;
            this.txtPermanent.Size = new System.Drawing.Size(247, 20);
            this.txtPermanent.TabIndex = 57;
            // 
            // txtDateofJoin
            // 
            this.txtDateofJoin.Location = new System.Drawing.Point(142, 143);
            this.txtDateofJoin.Name = "txtDateofJoin";
            this.txtDateofJoin.ReadOnly = true;
            this.txtDateofJoin.Size = new System.Drawing.Size(247, 20);
            this.txtDateofJoin.TabIndex = 58;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(142, 13);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(408, 21);
            this.cmbEmployee.TabIndex = 59;
            this.cmbEmployee.TextChanged += new System.EventHandler(this.cmbEmployee_TextChanged);
            // 
            // frmMarketingTargetSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.txtDateofJoin);
            this.Controls.Add(this.txtPermanent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsettergetamount);
            this.Controls.Add(this.lblSetTarget);
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
            this.Name = "frmMarketingTargetSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marketing Target Setup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtDoctors;
        private System.Windows.Forms.Label lblParmanent;
        private System.Windows.Forms.TextBox txtsettergetamount;
        private System.Windows.Forms.Label lblSetTarget;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPermanent;
        private System.Windows.Forms.TextBox txtDateofJoin;
        private System.Windows.Forms.ComboBox cmbEmployee;

    }
}