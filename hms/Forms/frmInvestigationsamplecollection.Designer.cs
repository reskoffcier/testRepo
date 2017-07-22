namespace hms.Forms
{
    partial class frmInvestigationsamplecollection
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
            this.dgvSampleCollection = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtInvestigation = new System.Windows.Forms.TextBox();
            this.chkNewCollection = new System.Windows.Forms.CheckBox();
            this.lblclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cachedrptServicesWiseTest1 = new hms.Reports.CachedrptServicesWiseTest();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampleCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSampleCollection
            // 
            this.dgvSampleCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSampleCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL});
            this.dgvSampleCollection.Location = new System.Drawing.Point(38, 75);
            this.dgvSampleCollection.Name = "dgvSampleCollection";
            this.dgvSampleCollection.Size = new System.Drawing.Size(812, 636);
            this.dgvSampleCollection.TabIndex = 9;
            // 
            // SL
            // 
            this.SL.HeaderText = "Sl NO";
            this.SL.Name = "SL";
            // 
            // txtInvestigation
            // 
            this.txtInvestigation.Location = new System.Drawing.Point(730, 34);
            this.txtInvestigation.Name = "txtInvestigation";
            this.txtInvestigation.Size = new System.Drawing.Size(120, 20);
            this.txtInvestigation.TabIndex = 8;
            this.txtInvestigation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvestigation_KeyPress);
            // 
            // chkNewCollection
            // 
            this.chkNewCollection.AutoSize = true;
            this.chkNewCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewCollection.ForeColor = System.Drawing.Color.Crimson;
            this.chkNewCollection.Location = new System.Drawing.Point(383, 34);
            this.chkNewCollection.Name = "chkNewCollection";
            this.chkNewCollection.Size = new System.Drawing.Size(131, 19);
            this.chkNewCollection.TabIndex = 7;
            this.chkNewCollection.Text = "Check New Data";
            this.chkNewCollection.UseVisualStyleBackColor = true;
            this.chkNewCollection.CheckedChanged += new System.EventHandler(this.chkNewCollection_CheckedChanged);
            // 
            // lblclose
            // 
            this.lblclose.Image = global::hms.Properties.Resources.CLOSE;
            this.lblclose.Location = new System.Drawing.Point(69, 32);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(29, 23);
            this.lblclose.TabIndex = 6;
            this.lblclose.UseVisualStyleBackColor = true;
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(38, 32);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Investigation Id:";
            // 
            // frmInvestigationsamplecollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSampleCollection);
            this.Controls.Add(this.txtInvestigation);
            this.Controls.Add(this.chkNewCollection);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnsave);
            this.Name = "frmInvestigationsamplecollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvestigationsamplecollection";
            this.Load += new System.EventHandler(this.frmInvestigationsamplecollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampleCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSampleCollection;
        private System.Windows.Forms.TextBox txtInvestigation;
        private System.Windows.Forms.CheckBox chkNewCollection;
        private System.Windows.Forms.Button lblclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SL;
        private Reports.CachedrptServicesWiseTest cachedrptServicesWiseTest1;
        private System.Windows.Forms.Label label1;
    }
}