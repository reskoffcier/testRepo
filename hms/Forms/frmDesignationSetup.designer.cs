namespace hms.Forms
{
    partial class frmDesignationSetup
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
            this.dgvDensignation = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDesigntionName = new System.Windows.Forms.TextBox();
            this.txtDesignatioID = new System.Windows.Forms.TextBox();
            this.lblDesignationname = new System.Windows.Forms.Label();
            this.lbldesigid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensignation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDensignation
            // 
            this.dgvDensignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDensignation.Location = new System.Drawing.Point(24, 222);
            this.dgvDensignation.Name = "dgvDensignation";
            this.dgvDensignation.Size = new System.Drawing.Size(471, 111);
            this.dgvDensignation.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(493, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::hms.Properties.Resources.SAVE;
            this.btnSave.Location = new System.Drawing.Point(474, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(21, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::hms.Properties.Resources.ADD;
            this.btnNew.Location = new System.Drawing.Point(449, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(26, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDesigntionName
            // 
            this.txtDesigntionName.Location = new System.Drawing.Point(118, 172);
            this.txtDesigntionName.Name = "txtDesigntionName";
            this.txtDesigntionName.Size = new System.Drawing.Size(227, 20);
            this.txtDesigntionName.TabIndex = 6;
            // 
            // txtDesignatioID
            // 
            this.txtDesignatioID.Enabled = false;
            this.txtDesignatioID.Location = new System.Drawing.Point(118, 112);
            this.txtDesignatioID.Name = "txtDesignatioID";
            this.txtDesignatioID.ReadOnly = true;
            this.txtDesignatioID.Size = new System.Drawing.Size(107, 20);
            this.txtDesignatioID.TabIndex = 10;
            // 
            // lblDesignationname
            // 
            this.lblDesignationname.AutoSize = true;
            this.lblDesignationname.Location = new System.Drawing.Point(21, 175);
            this.lblDesignationname.Name = "lblDesignationname";
            this.lblDesignationname.Size = new System.Drawing.Size(94, 13);
            this.lblDesignationname.TabIndex = 8;
            this.lblDesignationname.Text = "Designation Name";
            // 
            // lbldesigid
            // 
            this.lbldesigid.AutoSize = true;
            this.lbldesigid.Location = new System.Drawing.Point(21, 115);
            this.lbldesigid.Name = "lbldesigid";
            this.lbldesigid.Size = new System.Drawing.Size(77, 13);
            this.lbldesigid.TabIndex = 7;
            this.lbldesigid.Text = "Designation ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Designation Setup";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(21, 147);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(76, 13);
            this.lblDepartmentID.TabIndex = 15;
            this.lblDepartmentID.Text = "Department ID";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(120, 140);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(143, 21);
            this.cmbDepartment.TabIndex = 16;
            // 
            // frmDesignationSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 354);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.dgvDensignation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtDesigntionName);
            this.Controls.Add(this.txtDesignatioID);
            this.Controls.Add(this.lblDesignationname);
            this.Controls.Add(this.lbldesigid);
            this.Controls.Add(this.label1);
            this.Name = "frmDesignationSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDesignationSetup";
            this.Load += new System.EventHandler(this.frmDesignationSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDensignation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtDesigntionName;
        private System.Windows.Forms.TextBox txtDesignatioID;
        private System.Windows.Forms.Label lblDesignationname;
        private System.Windows.Forms.Label lbldesigid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.ComboBox cmbDepartment;
    }
}