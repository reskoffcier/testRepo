namespace hms.Forms
{
    partial class frmPathologyLabProcess
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
            this.dgvPathologyLabProcess = new System.Windows.Forms.DataGridView();
            this.btnSane = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtInvestigstionID = new System.Windows.Forms.TextBox();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPathologyLabProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPathologyLabProcess
            // 
            this.dgvPathologyLabProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPathologyLabProcess.Location = new System.Drawing.Point(12, 12);
            this.dgvPathologyLabProcess.Name = "dgvPathologyLabProcess";
            this.dgvPathologyLabProcess.Size = new System.Drawing.Size(753, 150);
            this.dgvPathologyLabProcess.TabIndex = 0;
            // 
            // btnSane
            // 
            this.btnSane.Image = global::hms.Properties.Resources.SAVE;
            this.btnSane.Location = new System.Drawing.Point(613, 168);
            this.btnSane.Name = "btnSane";
            this.btnSane.Size = new System.Drawing.Size(29, 23);
            this.btnSane.TabIndex = 1;
            this.btnSane.UseVisualStyleBackColor = true;
            this.btnSane.Click += new System.EventHandler(this.btnSane_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::hms.Properties.Resources.PRINTMAN;
            this.btnPrint.Location = new System.Drawing.Point(648, 168);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(34, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(688, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtInvestigstionID
            // 
            this.txtInvestigstionID.Location = new System.Drawing.Point(13, 169);
            this.txtInvestigstionID.Name = "txtInvestigstionID";
            this.txtInvestigstionID.Size = new System.Drawing.Size(39, 20);
            this.txtInvestigstionID.TabIndex = 5;
            this.txtInvestigstionID.Visible = false;
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(13, 195);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(752, 303);
            this.crViewer.TabIndex = 6;
            // 
            // frmPathologyLabProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 510);
            this.Controls.Add(this.crViewer);
            this.Controls.Add(this.txtInvestigstionID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSane);
            this.Controls.Add(this.dgvPathologyLabProcess);
            this.Name = "frmPathologyLabProcess";
            this.Text = "frmPathologyLabProcess";
            this.Load += new System.EventHandler(this.frmPathologyLabProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPathologyLabProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPathologyLabProcess;
        private System.Windows.Forms.Button btnSane;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInvestigstionID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}