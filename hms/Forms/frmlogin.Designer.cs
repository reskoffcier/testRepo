namespace hms.Forms
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpasword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblloginheader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(36, 58);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(63, 13);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "User Name:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(124, 55);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(119, 20);
            this.txtusername.TabIndex = 1;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(36, 88);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // txtpasword
            // 
            this.txtpasword.Location = new System.Drawing.Point(124, 88);
            this.txtpasword.Name = "txtpasword";
            this.txtpasword.PasswordChar = '*';
            this.txtpasword.Size = new System.Drawing.Size(119, 20);
            this.txtpasword.TabIndex = 3;
            this.txtpasword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpasword_KeyPress);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(124, 143);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblloginheader
            // 
            this.lblloginheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblloginheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginheader.Location = new System.Drawing.Point(0, 0);
            this.lblloginheader.Name = "lblloginheader";
            this.lblloginheader.Size = new System.Drawing.Size(284, 38);
            this.lblloginheader.TabIndex = 5;
            this.lblloginheader.Text = "Log in From";
            this.lblloginheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.lblloginheader);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpasword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpasword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblloginheader;
    }
}