namespace hms.Forms
{
    partial class frmPharmacyReturnForm
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
            this.lblvoucherno = new System.Windows.Forms.Label();
            this.txtPurvoucherno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblvoucherno
            // 
            this.lblvoucherno.AutoSize = true;
            this.lblvoucherno.Location = new System.Drawing.Point(0, 9);
            this.lblvoucherno.Name = "lblvoucherno";
            this.lblvoucherno.Size = new System.Drawing.Size(64, 13);
            this.lblvoucherno.TabIndex = 182;
            this.lblvoucherno.Text = "Voucher No";
            // 
            // txtPurvoucherno
            // 
            this.txtPurvoucherno.Location = new System.Drawing.Point(76, 6);
            this.txtPurvoucherno.Name = "txtPurvoucherno";
            this.txtPurvoucherno.ReadOnly = true;
            this.txtPurvoucherno.Size = new System.Drawing.Size(269, 20);
            this.txtPurvoucherno.TabIndex = 181;
            // 
            // frmPharmacyReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 262);
            this.Controls.Add(this.lblvoucherno);
            this.Controls.Add(this.txtPurvoucherno);
            this.Name = "frmPharmacyReturnForm";
            this.Text = "Pharmacy Return Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvoucherno;
        private System.Windows.Forms.TextBox txtPurvoucherno;
    }
}