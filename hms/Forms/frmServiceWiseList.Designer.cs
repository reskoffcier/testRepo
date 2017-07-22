namespace hms.Forms
{
    partial class frmServiceWiseList
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
            this.dgvServiceWiseSetup = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblService_ID = new System.Windows.Forms.Label();
            this.txtSIT_ID = new System.Windows.Forms.TextBox();
            this.lblSIT_ID = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelect = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.lblEntity = new System.Windows.Forms.Label();
            this.txtOGroup = new System.Windows.Forms.TextBox();
            this.lblOGroup = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtRefRenge = new System.Windows.Forms.TextBox();
            this.lblRefRenge = new System.Windows.Forms.Label();
            this.txtResultB = new System.Windows.Forms.TextBox();
            this.lblResultB = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceWiseSetup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceWiseSetup
            // 
            this.dgvServiceWiseSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceWiseSetup.Location = new System.Drawing.Point(10, 234);
            this.dgvServiceWiseSetup.Name = "dgvServiceWiseSetup";
            this.dgvServiceWiseSetup.Size = new System.Drawing.Size(864, 237);
            this.dgvServiceWiseSetup.TabIndex = 19;
            this.dgvServiceWiseSetup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceWiseSetup_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Service Wise List Setup ";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(336, 80);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(42, 20);
            this.txtServiceID.TabIndex = 14;
            // 
            // lblService_ID
            // 
            this.lblService_ID.AutoSize = true;
            this.lblService_ID.Location = new System.Drawing.Point(246, 84);
            this.lblService_ID.Name = "lblService_ID";
            this.lblService_ID.Size = new System.Drawing.Size(57, 13);
            this.lblService_ID.TabIndex = 13;
            this.lblService_ID.Text = "Service ID";
            // 
            // txtSIT_ID
            // 
            this.txtSIT_ID.Location = new System.Drawing.Point(336, 56);
            this.txtSIT_ID.Name = "txtSIT_ID";
            this.txtSIT_ID.ReadOnly = true;
            this.txtSIT_ID.Size = new System.Drawing.Size(100, 20);
            this.txtSIT_ID.TabIndex = 12;
            // 
            // lblSIT_ID
            // 
            this.lblSIT_ID.AutoSize = true;
            this.lblSIT_ID.Location = new System.Drawing.Point(246, 60);
            this.lblSIT_ID.Name = "lblSIT_ID";
            this.lblSIT_ID.Size = new System.Drawing.Size(38, 13);
            this.lblSIT_ID.TabIndex = 11;
            this.lblSIT_ID.Text = "SIT ID";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(853, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 23);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndelect
            // 
            this.btndelect.Image = global::hms.Properties.Resources.DELETE;
            this.btndelect.Location = new System.Drawing.Point(798, 8);
            this.btndelect.Name = "btndelect";
            this.btndelect.Size = new System.Drawing.Size(24, 23);
            this.btndelect.TabIndex = 20;
            this.btndelect.UseVisualStyleBackColor = true;
            this.btndelect.Click += new System.EventHandler(this.btndelect_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::hms.Properties.Resources.Edit;
            this.btnedit.Location = new System.Drawing.Point(768, 8);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(24, 23);
            this.btnedit.TabIndex = 18;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(738, 8);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(24, 23);
            this.btnsave.TabIndex = 17;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(708, 8);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(24, 23);
            this.btnnew.TabIndex = 16;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(828, 8);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(24, 23);
            this.btnpreview.TabIndex = 22;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // txtEntity
            // 
            this.txtEntity.Location = new System.Drawing.Point(336, 130);
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(264, 20);
            this.txtEntity.TabIndex = 26;
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(246, 134);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(33, 13);
            this.lblEntity.TabIndex = 25;
            this.lblEntity.Text = "Entity";
            // 
            // txtOGroup
            // 
            this.txtOGroup.Location = new System.Drawing.Point(336, 105);
            this.txtOGroup.Name = "txtOGroup";
            this.txtOGroup.Size = new System.Drawing.Size(264, 20);
            this.txtOGroup.TabIndex = 24;
            // 
            // lblOGroup
            // 
            this.lblOGroup.AutoSize = true;
            this.lblOGroup.Location = new System.Drawing.Point(246, 109);
            this.lblOGroup.Name = "lblOGroup";
            this.lblOGroup.Size = new System.Drawing.Size(44, 13);
            this.lblOGroup.TabIndex = 23;
            this.lblOGroup.Text = "OGroup";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(336, 154);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(264, 20);
            this.txtUnit.TabIndex = 28;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(246, 158);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 27;
            this.lblUnit.Text = "Unit";
            // 
            // txtRefRenge
            // 
            this.txtRefRenge.Location = new System.Drawing.Point(336, 178);
            this.txtRefRenge.Name = "txtRefRenge";
            this.txtRefRenge.Size = new System.Drawing.Size(264, 20);
            this.txtRefRenge.TabIndex = 30;
            // 
            // lblRefRenge
            // 
            this.lblRefRenge.AutoSize = true;
            this.lblRefRenge.Location = new System.Drawing.Point(246, 182);
            this.lblRefRenge.Name = "lblRefRenge";
            this.lblRefRenge.Size = new System.Drawing.Size(56, 13);
            this.lblRefRenge.TabIndex = 29;
            this.lblRefRenge.Text = "RefRenge";
            // 
            // txtResultB
            // 
            this.txtResultB.Location = new System.Drawing.Point(336, 202);
            this.txtResultB.Name = "txtResultB";
            this.txtResultB.Size = new System.Drawing.Size(264, 20);
            this.txtResultB.TabIndex = 32;
            // 
            // lblResultB
            // 
            this.lblResultB.AutoSize = true;
            this.lblResultB.Location = new System.Drawing.Point(246, 206);
            this.lblResultB.Name = "lblResultB";
            this.lblResultB.Size = new System.Drawing.Size(47, 13);
            this.lblResultB.TabIndex = 31;
            this.lblResultB.Text = "Result B";
            // 
            // cmbServices
            // 
            this.cmbServices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbServices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(385, 78);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(215, 21);
            this.cmbServices.TabIndex = 33;
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            // 
            // frmServiceWiseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 478);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.txtResultB);
            this.Controls.Add(this.lblResultB);
            this.Controls.Add(this.txtRefRenge);
            this.Controls.Add(this.lblRefRenge);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtEntity);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.txtOGroup);
            this.Controls.Add(this.lblOGroup);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelect);
            this.Controls.Add(this.dgvServiceWiseSetup);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lblService_ID);
            this.Controls.Add(this.txtSIT_ID);
            this.Controls.Add(this.lblSIT_ID);
            this.Name = "frmServiceWiseList";
            this.Text = "frmServiceWiseList";
            this.Load += new System.EventHandler(this.frmServiceWiseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceWiseSetup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelect;
        private System.Windows.Forms.DataGridView dgvServiceWiseSetup;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblService_ID;
        private System.Windows.Forms.TextBox txtSIT_ID;
        private System.Windows.Forms.Label lblSIT_ID;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.TextBox txtOGroup;
        private System.Windows.Forms.Label lblOGroup;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtRefRenge;
        private System.Windows.Forms.Label lblRefRenge;
        private System.Windows.Forms.TextBox txtResultB;
        private System.Windows.Forms.Label lblResultB;
        private System.Windows.Forms.ComboBox cmbServices;
    }
}