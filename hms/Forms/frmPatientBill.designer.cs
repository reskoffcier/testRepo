namespace hms.Forms
{
    partial class frmPatientBill
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
            this.lblP_Id = new System.Windows.Forms.Label();
            this.btnPatienList = new System.Windows.Forms.Button();
            this.lblAdmissionID = new System.Windows.Forms.Label();
            this.txtAdmissionId = new System.Windows.Forms.TextBox();
            this.gbpatientbill = new System.Windows.Forms.GroupBox();
            this.rbtnPatientDetails = new System.Windows.Forms.RadioButton();
            this.rbtnPatientSummary = new System.Windows.Forms.RadioButton();
            this.btnpreview = new System.Windows.Forms.Button();
            this.gbpatientbill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblP_Id
            // 
            this.lblP_Id.AutoSize = true;
            this.lblP_Id.Location = new System.Drawing.Point(216, 27);
            this.lblP_Id.Name = "lblP_Id";
            this.lblP_Id.Size = new System.Drawing.Size(0, 13);
            this.lblP_Id.TabIndex = 42;
            this.lblP_Id.Visible = false;
            // 
            // btnPatienList
            // 
            this.btnPatienList.Location = new System.Drawing.Point(166, 20);
            this.btnPatienList.Name = "btnPatienList";
            this.btnPatienList.Size = new System.Drawing.Size(24, 23);
            this.btnPatienList.TabIndex = 41;
            this.btnPatienList.Text = "...";
            this.btnPatienList.UseVisualStyleBackColor = true;
            this.btnPatienList.Click += new System.EventHandler(this.btnPatienList_Click);
            // 
            // lblAdmissionID
            // 
            this.lblAdmissionID.AutoSize = true;
            this.lblAdmissionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionID.ForeColor = System.Drawing.Color.Black;
            this.lblAdmissionID.Location = new System.Drawing.Point(42, 24);
            this.lblAdmissionID.Name = "lblAdmissionID";
            this.lblAdmissionID.Size = new System.Drawing.Size(19, 15);
            this.lblAdmissionID.TabIndex = 39;
            this.lblAdmissionID.Text = "ID";
            // 
            // txtAdmissionId
            // 
            this.txtAdmissionId.Enabled = false;
            this.txtAdmissionId.Location = new System.Drawing.Point(67, 22);
            this.txtAdmissionId.Name = "txtAdmissionId";
            this.txtAdmissionId.ReadOnly = true;
            this.txtAdmissionId.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionId.TabIndex = 43;
            // 
            // gbpatientbill
            // 
            this.gbpatientbill.Controls.Add(this.rbtnPatientDetails);
            this.gbpatientbill.Controls.Add(this.rbtnPatientSummary);
            this.gbpatientbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpatientbill.Location = new System.Drawing.Point(16, 70);
            this.gbpatientbill.Name = "gbpatientbill";
            this.gbpatientbill.Size = new System.Drawing.Size(200, 100);
            this.gbpatientbill.TabIndex = 44;
            this.gbpatientbill.TabStop = false;
            this.gbpatientbill.Text = "Patient Bill";
            // 
            // rbtnPatientDetails
            // 
            this.rbtnPatientDetails.AutoSize = true;
            this.rbtnPatientDetails.Location = new System.Drawing.Point(29, 59);
            this.rbtnPatientDetails.Name = "rbtnPatientDetails";
            this.rbtnPatientDetails.Size = new System.Drawing.Size(119, 19);
            this.rbtnPatientDetails.TabIndex = 1;
            this.rbtnPatientDetails.TabStop = true;
            this.rbtnPatientDetails.Text = "Patient Details";
            this.rbtnPatientDetails.UseVisualStyleBackColor = true;
            // 
            // rbtnPatientSummary
            // 
            this.rbtnPatientSummary.AutoSize = true;
            this.rbtnPatientSummary.Location = new System.Drawing.Point(29, 30);
            this.rbtnPatientSummary.Name = "rbtnPatientSummary";
            this.rbtnPatientSummary.Size = new System.Drawing.Size(159, 19);
            this.rbtnPatientSummary.TabIndex = 0;
            this.rbtnPatientSummary.TabStop = true;
            this.rbtnPatientSummary.Text = "Patient Summary Bill";
            this.rbtnPatientSummary.UseVisualStyleBackColor = true;
            // 
            // btnpreview
            // 
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(82, 191);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(36, 23);
            this.btnpreview.TabIndex = 45;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // frmPatientBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 342);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.gbpatientbill);
            this.Controls.Add(this.txtAdmissionId);
            this.Controls.Add(this.lblP_Id);
            this.Controls.Add(this.btnPatienList);
            this.Controls.Add(this.lblAdmissionID);
            this.Name = "frmPatientBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Bill";
            this.gbpatientbill.ResumeLayout(false);
            this.gbpatientbill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP_Id;
        private System.Windows.Forms.Button btnPatienList;
        private System.Windows.Forms.Label lblAdmissionID;
        private System.Windows.Forms.TextBox txtAdmissionId;
        private System.Windows.Forms.GroupBox gbpatientbill;
        private System.Windows.Forms.RadioButton rbtnPatientDetails;
        private System.Windows.Forms.RadioButton rbtnPatientSummary;
        private System.Windows.Forms.Button btnpreview;
    }
}