namespace hms.Forms
{
    partial class frmAdmitedPatientList
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstPatientView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lstPatientView
            // 
            this.lstPatientView.FullRowSelect = true;
            this.lstPatientView.Location = new System.Drawing.Point(12, 38);
            this.lstPatientView.Name = "lstPatientView";
            this.lstPatientView.Size = new System.Drawing.Size(305, 211);
            this.lstPatientView.TabIndex = 1;
            this.lstPatientView.UseCompatibleStateImageBehavior = false;
            this.lstPatientView.View = System.Windows.Forms.View.Details;
            this.lstPatientView.DoubleClick += new System.EventHandler(this.lstPatientView_DoubleClick);
            // 
            // frmAdmitedPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.lstPatientView);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmAdmitedPatientList";
            this.Text = "frmAdmitedPatientList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lstPatientView;
    }
}