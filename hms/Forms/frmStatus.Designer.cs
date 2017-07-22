namespace hms.Forms
{
    partial class frmStatus
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
            this.txtInvIDandAdmID = new System.Windows.Forms.TextBox();
            this.rbtnInvestigation = new System.Windows.Forms.RadioButton();
            this.btnIdWise = new System.Windows.Forms.Button();
            this.btnDocWise = new System.Windows.Forms.Button();
            this.rbtnAdmission = new System.Windows.Forms.RadioButton();
            this.txtDocID = new System.Windows.Forms.TextBox();
            this.grdInfo = new System.Windows.Forms.DataGridView();
            this.grdDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvIDandAdmID
            // 
            this.txtInvIDandAdmID.Location = new System.Drawing.Point(2, 2);
            this.txtInvIDandAdmID.Name = "txtInvIDandAdmID";
            this.txtInvIDandAdmID.Size = new System.Drawing.Size(121, 20);
            this.txtInvIDandAdmID.TabIndex = 1;
            this.txtInvIDandAdmID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvIDandAdmID_KeyPress);
            // 
            // rbtnInvestigation
            // 
            this.rbtnInvestigation.AutoSize = true;
            this.rbtnInvestigation.Location = new System.Drawing.Point(343, 2);
            this.rbtnInvestigation.Name = "rbtnInvestigation";
            this.rbtnInvestigation.Size = new System.Drawing.Size(85, 17);
            this.rbtnInvestigation.TabIndex = 2;
            this.rbtnInvestigation.TabStop = true;
            this.rbtnInvestigation.Text = "Investigation";
            this.rbtnInvestigation.UseVisualStyleBackColor = true;
            this.rbtnInvestigation.CheckedChanged += new System.EventHandler(this.Reset);
            // 
            // btnIdWise
            // 
            this.btnIdWise.Location = new System.Drawing.Point(127, 2);
            this.btnIdWise.Name = "btnIdWise";
            this.btnIdWise.Size = new System.Drawing.Size(59, 23);
            this.btnIdWise.TabIndex = 3;
            this.btnIdWise.Text = "ID Wise";
            this.btnIdWise.UseVisualStyleBackColor = true;
            this.btnIdWise.Click += new System.EventHandler(this.btnIdWise_Click);
            // 
            // btnDocWise
            // 
            this.btnDocWise.Location = new System.Drawing.Point(678, 2);
            this.btnDocWise.Name = "btnDocWise";
            this.btnDocWise.Size = new System.Drawing.Size(79, 23);
            this.btnDocWise.TabIndex = 6;
            this.btnDocWise.Text = "Doctor Wise";
            this.btnDocWise.UseVisualStyleBackColor = true;
            this.btnDocWise.Click += new System.EventHandler(this.btnDocWise_Click);
            // 
            // rbtnAdmission
            // 
            this.rbtnAdmission.AutoSize = true;
            this.rbtnAdmission.Location = new System.Drawing.Point(439, 2);
            this.rbtnAdmission.Name = "rbtnAdmission";
            this.rbtnAdmission.Size = new System.Drawing.Size(72, 17);
            this.rbtnAdmission.TabIndex = 5;
            this.rbtnAdmission.TabStop = true;
            this.rbtnAdmission.Text = "Admission";
            this.rbtnAdmission.UseVisualStyleBackColor = true;
            this.rbtnAdmission.CheckedChanged += new System.EventHandler(this.Reset);
            // 
            // txtDocID
            // 
            this.txtDocID.Location = new System.Drawing.Point(760, 2);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.Size = new System.Drawing.Size(121, 20);
            this.txtDocID.TabIndex = 4;
            this.txtDocID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocID_KeyPress);
            // 
            // grdInfo
            // 
            this.grdInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInfo.Location = new System.Drawing.Point(2, 39);
            this.grdInfo.Name = "grdInfo";
            this.grdInfo.Size = new System.Drawing.Size(879, 313);
            this.grdInfo.TabIndex = 7;
            this.grdInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInfo_CellClick);
            // 
            // grdDetails
            // 
            this.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetails.Location = new System.Drawing.Point(2, 378);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Size = new System.Drawing.Size(879, 171);
            this.grdDetails.TabIndex = 8;
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.grdInfo);
            this.Controls.Add(this.btnDocWise);
            this.Controls.Add(this.rbtnAdmission);
            this.Controls.Add(this.txtDocID);
            this.Controls.Add(this.btnIdWise);
            this.Controls.Add(this.rbtnInvestigation);
            this.Controls.Add(this.txtInvIDandAdmID);
            this.Name = "frmStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.grdInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvIDandAdmID;
        private System.Windows.Forms.RadioButton rbtnInvestigation;
        private System.Windows.Forms.Button btnIdWise;
        private System.Windows.Forms.Button btnDocWise;
        private System.Windows.Forms.RadioButton rbtnAdmission;
        private System.Windows.Forms.TextBox txtDocID;
        private System.Windows.Forms.DataGridView grdInfo;
        private System.Windows.Forms.DataGridView grdDetails;
    }
}