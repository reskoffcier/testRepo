namespace hms.Forms
{
    partial class frmPharmacyCatagorySetup
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
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCatNane = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCatShotName = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(80, 23);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID";
            // 
            // txtCatId
            // 
            this.txtCatId.Location = new System.Drawing.Point(188, 20);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(100, 20);
            this.txtCatId.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblCatNane
            // 
            this.lblCatNane.AutoSize = true;
            this.lblCatNane.Location = new System.Drawing.Point(80, 52);
            this.lblCatNane.Name = "lblCatNane";
            this.lblCatNane.Size = new System.Drawing.Size(80, 13);
            this.lblCatNane.TabIndex = 2;
            this.lblCatNane.Text = "Category Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblCatShotName
            // 
            this.lblCatShotName.AutoSize = true;
            this.lblCatShotName.Location = new System.Drawing.Point(80, 78);
            this.lblCatShotName.Name = "lblCatShotName";
            this.lblCatShotName.Size = new System.Drawing.Size(105, 13);
            this.lblCatShotName.TabIndex = 4;
            this.lblCatShotName.Text = "Category Shot Name";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(468, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 23);
            this.btnclose.TabIndex = 192;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(394, -1);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(38, 23);
            this.btnnew.TabIndex = 191;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(431, -1);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(40, 23);
            this.btnsave.TabIndex = 190;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // frmPharmacyCatagorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 140);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCatShotName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCatNane);
            this.Controls.Add(this.txtCatId);
            this.Controls.Add(this.lblCategoryID);
            this.Name = "frmPharmacyCatagorySetup";
            this.Text = "Pharmacy Category Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCatNane;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCatShotName;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
    }
}