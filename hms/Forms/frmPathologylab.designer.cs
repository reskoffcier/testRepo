namespace hms.Forms
{
    partial class frmPathologylab
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
            this.chkNewData = new System.Windows.Forms.CheckBox();
            this.txtinvestigationid = new System.Windows.Forms.TextBox();
            this.gbtestcatagory = new System.Windows.Forms.GroupBox();
            this.dgvPathLab = new System.Windows.Forms.DataGridView();
            this.lbPathlab = new System.Windows.Forms.ListBox();
            this.lblclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPathLab)).BeginInit();
            this.SuspendLayout();
            // 
            // chkNewData
            // 
            this.chkNewData.AutoSize = true;
            this.chkNewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewData.ForeColor = System.Drawing.Color.Crimson;
            this.chkNewData.Location = new System.Drawing.Point(13, 13);
            this.chkNewData.Name = "chkNewData";
            this.chkNewData.Size = new System.Drawing.Size(131, 19);
            this.chkNewData.TabIndex = 0;
            this.chkNewData.Text = "Check New Data";
            this.chkNewData.UseVisualStyleBackColor = true;
            this.chkNewData.CheckedChanged += new System.EventHandler(this.chkNewData_CheckedChanged);
            // 
            // txtinvestigationid
            // 
            this.txtinvestigationid.Location = new System.Drawing.Point(13, 34);
            this.txtinvestigationid.Name = "txtinvestigationid";
            this.txtinvestigationid.Size = new System.Drawing.Size(131, 20);
            this.txtinvestigationid.TabIndex = 1;
            this.txtinvestigationid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtinvestigationid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtinvestigationid_KeyUp);
            // 
            // gbtestcatagory
            // 
            this.gbtestcatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtestcatagory.ForeColor = System.Drawing.Color.Crimson;
            this.gbtestcatagory.Location = new System.Drawing.Point(162, 13);
            this.gbtestcatagory.Name = "gbtestcatagory";
            this.gbtestcatagory.Size = new System.Drawing.Size(691, 126);
            this.gbtestcatagory.TabIndex = 5;
            this.gbtestcatagory.TabStop = false;
            this.gbtestcatagory.Text = "Test Catagory";
            // 
            // dgvPathLab
            // 
            this.dgvPathLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPathLab.Location = new System.Drawing.Point(12, 154);
            this.dgvPathLab.Name = "dgvPathLab";
            this.dgvPathLab.Size = new System.Drawing.Size(841, 454);
            this.dgvPathLab.TabIndex = 6;
            this.dgvPathLab.DoubleClick += new System.EventHandler(this.dgvPathLab_DoubleClick);
            // 
            // lbPathlab
            // 
            this.lbPathlab.FormattingEnabled = true;
            this.lbPathlab.Location = new System.Drawing.Point(16, 59);
            this.lbPathlab.Name = "lbPathlab";
            this.lbPathlab.Size = new System.Drawing.Size(127, 56);
            this.lbPathlab.TabIndex = 7;
            this.lbPathlab.SelectedIndexChanged += new System.EventHandler(this.lbPathlab_SelectedIndexChanged);
            // 
            // lblclose
            // 
            this.lblclose.Image = global::hms.Properties.Resources.CLOSE;
            this.lblclose.Location = new System.Drawing.Point(57, 124);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(29, 23);
            this.lblclose.TabIndex = 9;
            this.lblclose.UseVisualStyleBackColor = true;
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(26, 124);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmPathologylab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 620);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbPathlab);
            this.Controls.Add(this.dgvPathLab);
            this.Controls.Add(this.gbtestcatagory);
            this.Controls.Add(this.txtinvestigationid);
            this.Controls.Add(this.chkNewData);
            this.Name = "frmPathologylab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathology Lab";
            this.Load += new System.EventHandler(this.frmPathologylab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPathLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNewData;
        private System.Windows.Forms.TextBox txtinvestigationid;
        private System.Windows.Forms.DataGridView dgvPathLab;
        private System.Windows.Forms.ListBox lbPathlab;
        private System.Windows.Forms.Button lblclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox gbtestcatagory;
    }
}