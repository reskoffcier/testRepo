namespace hms.Forms
{
    partial class frmDoctorsSearch
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
            this.lblsearchcriteria = new System.Windows.Forms.Label();
            this.txtsearchcriteria = new System.Windows.Forms.TextBox();
            this.grdDoctorList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctorList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsearchcriteria
            // 
            this.lblsearchcriteria.AutoSize = true;
            this.lblsearchcriteria.Location = new System.Drawing.Point(3, 13);
            this.lblsearchcriteria.Name = "lblsearchcriteria";
            this.lblsearchcriteria.Size = new System.Drawing.Size(76, 13);
            this.lblsearchcriteria.TabIndex = 0;
            this.lblsearchcriteria.Text = "Search Criteria";
            // 
            // txtsearchcriteria
            // 
            this.txtsearchcriteria.Location = new System.Drawing.Point(81, 13);
            this.txtsearchcriteria.Name = "txtsearchcriteria";
            this.txtsearchcriteria.Size = new System.Drawing.Size(595, 20);
            this.txtsearchcriteria.TabIndex = 1;
            this.txtsearchcriteria.TextChanged += new System.EventHandler(this.txtsearchcriteria_TextChanged);
            // 
            // grdDoctorList
            // 
            this.grdDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoctorList.Location = new System.Drawing.Point(13, 50);
            this.grdDoctorList.Name = "grdDoctorList";
            this.grdDoctorList.RowHeadersVisible = false;
            this.grdDoctorList.Size = new System.Drawing.Size(779, 290);
            this.grdDoctorList.TabIndex = 3;
            // 
            // frmDoctorsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 352);
            this.Controls.Add(this.grdDoctorList);
            this.Controls.Add(this.txtsearchcriteria);
            this.Controls.Add(this.lblsearchcriteria);
            this.Name = "frmDoctorsSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors Search";
            this.Load += new System.EventHandler(this.frmDoctorsSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsearchcriteria;
        private System.Windows.Forms.TextBox txtsearchcriteria;
        private System.Windows.Forms.DataGridView grdDoctorList;
    }
}