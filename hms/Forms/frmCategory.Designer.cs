namespace hms.Forms
{
    partial class frmCategory
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
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelect = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(29, 89);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(119, 85);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryID.TabIndex = 1;
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(119, 116);
            this.txtcategoryname.MaxLength = 150;
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(290, 20);
            this.txtcategoryname.TabIndex = 3;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(29, 120);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category Setup";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(12, 178);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(604, 275);
            this.dgvCategory.TabIndex = 8;
            this.dgvCategory.Click += new System.EventHandler(this.dgvCategory_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(588, 54);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 23);
            this.btnclose.TabIndex = 10;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndelect
            // 
            this.btndelect.Image = global::hms.Properties.Resources.DELETE;
            this.btndelect.Location = new System.Drawing.Point(535, 54);
            this.btndelect.Name = "btndelect";
            this.btndelect.Size = new System.Drawing.Size(24, 23);
            this.btndelect.TabIndex = 9;
            this.btndelect.UseVisualStyleBackColor = true;
            this.btndelect.Click += new System.EventHandler(this.btndelect_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::hms.Properties.Resources.Edit;
            this.btnedit.Location = new System.Drawing.Point(505, 54);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(24, 23);
            this.btnedit.TabIndex = 7;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(475, 54);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(24, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(445, 54);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(24, 23);
            this.btnnew.TabIndex = 5;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Image = global::hms.Properties.Resources.Preview;
            this.btnpreview.Location = new System.Drawing.Point(561, 54);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(24, 23);
            this.btnpreview.TabIndex = 11;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 465);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelect);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcategoryname);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.lblCategoryID);
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btndelect;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnpreview;

    }
}