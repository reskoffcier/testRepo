namespace hms.Forms
{
    partial class frmHospitalDischargeFornt
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
            this.lblAdmissionId = new System.Windows.Forms.Label();
            this.txtAdmissionId = new System.Windows.Forms.TextBox();
            this.btnPatienList = new System.Windows.Forms.Button();
            this.rbtnDischarge = new System.Windows.Forms.RadioButton();
            this.rbtntransfer = new System.Windows.Forms.RadioButton();
            this.rbtnPatientDeath = new System.Windows.Forms.RadioButton();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.AutoSize = true;
            this.lblAdmissionId.Location = new System.Drawing.Point(187, 38);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(68, 13);
            this.lblAdmissionId.TabIndex = 0;
            this.lblAdmissionId.Text = "Admission ID";
            // 
            // txtAdmissionId
            // 
            this.txtAdmissionId.Location = new System.Drawing.Point(258, 37);
            this.txtAdmissionId.Name = "txtAdmissionId";
            this.txtAdmissionId.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionId.TabIndex = 1;
            // 
            // btnPatienList
            // 
            this.btnPatienList.Location = new System.Drawing.Point(359, 35);
            this.btnPatienList.Name = "btnPatienList";
            this.btnPatienList.Size = new System.Drawing.Size(26, 23);
            this.btnPatienList.TabIndex = 2;
            this.btnPatienList.Text = "....";
            this.btnPatienList.UseVisualStyleBackColor = true;
            this.btnPatienList.Click += new System.EventHandler(this.btnPatienList_Click);
            // 
            // rbtnDischarge
            // 
            this.rbtnDischarge.AutoSize = true;
            this.rbtnDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDischarge.Location = new System.Drawing.Point(258, 80);
            this.rbtnDischarge.Name = "rbtnDischarge";
            this.rbtnDischarge.Size = new System.Drawing.Size(90, 19);
            this.rbtnDischarge.TabIndex = 3;
            this.rbtnDischarge.TabStop = true;
            this.rbtnDischarge.Text = "Discharge";
            this.rbtnDischarge.UseVisualStyleBackColor = true;
            // 
            // rbtntransfer
            // 
            this.rbtntransfer.AutoSize = true;
            this.rbtntransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtntransfer.Location = new System.Drawing.Point(258, 103);
            this.rbtntransfer.Name = "rbtntransfer";
            this.rbtntransfer.Size = new System.Drawing.Size(78, 19);
            this.rbtntransfer.TabIndex = 4;
            this.rbtntransfer.TabStop = true;
            this.rbtntransfer.Text = "Transfer";
            this.rbtntransfer.UseVisualStyleBackColor = true;
            // 
            // rbtnPatientDeath
            // 
            this.rbtnPatientDeath.AutoSize = true;
            this.rbtnPatientDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPatientDeath.Location = new System.Drawing.Point(258, 126);
            this.rbtnPatientDeath.Name = "rbtnPatientDeath";
            this.rbtnPatientDeath.Size = new System.Drawing.Size(112, 19);
            this.rbtnPatientDeath.TabIndex = 5;
            this.rbtnPatientDeath.TabStop = true;
            this.rbtnPatientDeath.Text = "Patient Death";
            this.rbtnPatientDeath.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(12, 211);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(648, 276);
            this.txtRemark.TabIndex = 6;
            this.txtRemark.Text = "";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(495, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 23);
            this.btnclose.TabIndex = 39;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(473, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(24, 23);
            this.btnsave.TabIndex = 38;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(451, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(24, 23);
            this.btnnew.TabIndex = 37;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // frmHospitalDischargeFornt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 499);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.rbtnPatientDeath);
            this.Controls.Add(this.rbtntransfer);
            this.Controls.Add(this.rbtnDischarge);
            this.Controls.Add(this.btnPatienList);
            this.Controls.Add(this.txtAdmissionId);
            this.Controls.Add(this.lblAdmissionId);
            this.Name = "frmHospitalDischargeFornt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Discharge Fornt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmissionId;
        private System.Windows.Forms.TextBox txtAdmissionId;
        private System.Windows.Forms.Button btnPatienList;
        private System.Windows.Forms.RadioButton rbtnDischarge;
        private System.Windows.Forms.RadioButton rbtntransfer;
        private System.Windows.Forms.RadioButton rbtnPatientDeath;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
    }
}