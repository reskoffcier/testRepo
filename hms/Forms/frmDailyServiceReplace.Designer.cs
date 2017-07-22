using System.Drawing;
using System.Windows.Forms;

namespace hms.Forms
{
    partial class frmDailyServiceReplace
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.grdServiceInfo = new System.Windows.Forms.DataGridView();
            this.txtDocDetails = new System.Windows.Forms.RichTextBox();
            this.txtIDDetails = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvIdandAdvID = new System.Windows.Forms.Label();
            this.txtdocid = new System.Windows.Forms.TextBox();
            this.txtInvAdvID = new System.Windows.Forms.TextBox();
            this.rbtnAdmissionReffBy = new System.Windows.Forms.RadioButton();
            this.rbtnAdmissionRefTo = new System.Windows.Forms.RadioButton();
            this.rbtnInvestigation = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcessDuplicate = new System.Windows.Forms.Button();
            this.txtReplaceDocInfo = new System.Windows.Forms.RichTextBox();
            this.txtsuspectedDocInfo = new System.Windows.Forms.RichTextBox();
            this.btnshowDuplicate = new System.Windows.Forms.Button();
            this.lblReplace = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReplaceDocId = new System.Windows.Forms.TextBox();
            this.txtsuspectedDocId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.grdServiceInfo);
            this.groupBox1.Controls.Add(this.txtDocDetails);
            this.groupBox1.Controls.Add(this.txtIDDetails);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblInvIdandAdvID);
            this.groupBox1.Controls.Add(this.txtdocid);
            this.groupBox1.Controls.Add(this.txtInvAdvID);
            this.groupBox1.Controls.Add(this.rbtnAdmissionReffBy);
            this.groupBox1.Controls.Add(this.rbtnAdmissionRefTo);
            this.groupBox1.Controls.Add(this.rbtnInvestigation);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Doctor in Investigation And Hospital";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(810, 318);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(85, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(169, 324);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(219, 321);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(574, 20);
            this.txtRemark.TabIndex = 11;
            // 
            // grdServiceInfo
            // 
            this.grdServiceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServiceInfo.Location = new System.Drawing.Point(172, 161);
            this.grdServiceInfo.Name = "grdServiceInfo";
            this.grdServiceInfo.Size = new System.Drawing.Size(723, 154);
            this.grdServiceInfo.TabIndex = 10;
            // 
            // txtDocDetails
            // 
            this.txtDocDetails.BackColor = System.Drawing.Color.White;
            this.txtDocDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocDetails.Location = new System.Drawing.Point(172, 85);
            this.txtDocDetails.Name = "txtDocDetails";
            this.txtDocDetails.ReadOnly = true;
            this.txtDocDetails.Size = new System.Drawing.Size(723, 69);
            this.txtDocDetails.TabIndex = 9;
            this.txtDocDetails.Text = "";
            // 
            // txtIDDetails
            // 
            this.txtIDDetails.BackColor = System.Drawing.Color.White;
            this.txtIDDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDetails.Location = new System.Drawing.Point(172, 18);
            this.txtIDDetails.Name = "txtIDDetails";
            this.txtIDDetails.ReadOnly = true;
            this.txtIDDetails.Size = new System.Drawing.Size(723, 61);
            this.txtIDDetails.TabIndex = 8;
            this.txtIDDetails.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(25, 319);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Replace Doctor Id";
            // 
            // lblInvIdandAdvID
            // 
            this.lblInvIdandAdvID.AutoSize = true;
            this.lblInvIdandAdvID.Location = new System.Drawing.Point(36, 177);
            this.lblInvIdandAdvID.Name = "lblInvIdandAdvID";
            this.lblInvIdandAdvID.Size = new System.Drawing.Size(79, 13);
            this.lblInvIdandAdvID.TabIndex = 5;
            this.lblInvIdandAdvID.Text = "Investigation Id";
            // 
            // txtdocid
            // 
            this.txtdocid.Location = new System.Drawing.Point(25, 254);
            this.txtdocid.Name = "txtdocid";
            this.txtdocid.Size = new System.Drawing.Size(100, 20);
            this.txtdocid.TabIndex = 4;
            this.txtdocid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyNumeric);
            // 
            // txtInvAdvID
            // 
            this.txtInvAdvID.Location = new System.Drawing.Point(25, 193);
            this.txtInvAdvID.Name = "txtInvAdvID";
            this.txtInvAdvID.Size = new System.Drawing.Size(100, 20);
            this.txtInvAdvID.TabIndex = 3;
            // 
            // rbtnAdmissionReffBy
            // 
            this.rbtnAdmissionReffBy.AutoSize = true;
            this.rbtnAdmissionReffBy.Location = new System.Drawing.Point(25, 70);
            this.rbtnAdmissionReffBy.Name = "rbtnAdmissionReffBy";
            this.rbtnAdmissionReffBy.Size = new System.Drawing.Size(132, 17);
            this.rbtnAdmissionReffBy.TabIndex = 2;
            this.rbtnAdmissionReffBy.TabStop = true;
            this.rbtnAdmissionReffBy.Text = "Admission Referred To";
            this.rbtnAdmissionReffBy.UseVisualStyleBackColor = true;
            this.rbtnAdmissionReffBy.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // rbtnAdmissionRefTo
            // 
            this.rbtnAdmissionRefTo.AutoSize = true;
            this.rbtnAdmissionRefTo.Location = new System.Drawing.Point(25, 46);
            this.rbtnAdmissionRefTo.Name = "rbtnAdmissionRefTo";
            this.rbtnAdmissionRefTo.Size = new System.Drawing.Size(131, 17);
            this.rbtnAdmissionRefTo.TabIndex = 1;
            this.rbtnAdmissionRefTo.TabStop = true;
            this.rbtnAdmissionRefTo.Text = "Admission Referred By";
            this.rbtnAdmissionRefTo.UseVisualStyleBackColor = true;
            this.rbtnAdmissionRefTo.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // rbtnInvestigation
            // 
            this.rbtnInvestigation.AutoSize = true;
            this.rbtnInvestigation.Location = new System.Drawing.Point(25, 22);
            this.rbtnInvestigation.Name = "rbtnInvestigation";
            this.rbtnInvestigation.Size = new System.Drawing.Size(144, 17);
            this.rbtnInvestigation.TabIndex = 0;
            this.rbtnInvestigation.TabStop = true;
            this.rbtnInvestigation.Text = "Investigation Referred By";
            this.rbtnInvestigation.UseVisualStyleBackColor = true;
            this.rbtnInvestigation.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcessDuplicate);
            this.groupBox2.Controls.Add(this.txtReplaceDocInfo);
            this.groupBox2.Controls.Add(this.txtsuspectedDocInfo);
            this.groupBox2.Controls.Add(this.btnshowDuplicate);
            this.groupBox2.Controls.Add(this.lblReplace);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtReplaceDocId);
            this.groupBox2.Controls.Add(this.txtsuspectedDocId);
            this.groupBox2.Location = new System.Drawing.Point(26, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duplicate Doctor";
            // 
            // btnProcessDuplicate
            // 
            this.btnProcessDuplicate.Location = new System.Drawing.Point(810, 147);
            this.btnProcessDuplicate.Name = "btnProcessDuplicate";
            this.btnProcessDuplicate.Size = new System.Drawing.Size(85, 23);
            this.btnProcessDuplicate.TabIndex = 15;
            this.btnProcessDuplicate.Text = "Process";
            this.btnProcessDuplicate.UseVisualStyleBackColor = true;
            this.btnProcessDuplicate.Click += new System.EventHandler(this.btnProcessDuplicate_Click);
            // 
            // txtReplaceDocInfo
            // 
            this.txtReplaceDocInfo.BackColor = System.Drawing.Color.White;
            this.txtReplaceDocInfo.Location = new System.Drawing.Point(171, 81);
            this.txtReplaceDocInfo.Name = "txtReplaceDocInfo";
            this.txtReplaceDocInfo.ReadOnly = true;
            this.txtReplaceDocInfo.Size = new System.Drawing.Size(724, 60);
            this.txtReplaceDocInfo.TabIndex = 14;
            this.txtReplaceDocInfo.Text = "";
            // 
            // txtsuspectedDocInfo
            // 
            this.txtsuspectedDocInfo.BackColor = System.Drawing.Color.White;
            this.txtsuspectedDocInfo.Location = new System.Drawing.Point(171, 16);
            this.txtsuspectedDocInfo.Name = "txtsuspectedDocInfo";
            this.txtsuspectedDocInfo.ReadOnly = true;
            this.txtsuspectedDocInfo.Size = new System.Drawing.Size(724, 59);
            this.txtsuspectedDocInfo.TabIndex = 13;
            this.txtsuspectedDocInfo.Text = "";
            // 
            // btnshowDuplicate
            // 
            this.btnshowDuplicate.Location = new System.Drawing.Point(25, 147);
            this.btnshowDuplicate.Name = "btnshowDuplicate";
            this.btnshowDuplicate.Size = new System.Drawing.Size(75, 23);
            this.btnshowDuplicate.TabIndex = 12;
            this.btnshowDuplicate.Text = "Show";
            this.btnshowDuplicate.UseVisualStyleBackColor = true;
            this.btnshowDuplicate.Click += new System.EventHandler(this.btnshowDuplicate_Click);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(27, 54);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(94, 13);
            this.lblReplace.TabIndex = 11;
            this.lblReplace.Text = "Replace Doctor Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Suspected Doctor Id";
            // 
            // txtReplaceDocId
            // 
            this.txtReplaceDocId.Location = new System.Drawing.Point(25, 70);
            this.txtReplaceDocId.Name = "txtReplaceDocId";
            this.txtReplaceDocId.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceDocId.TabIndex = 9;
            this.txtReplaceDocId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyNumeric);
            // 
            // txtsuspectedDocId
            // 
            this.txtsuspectedDocId.Location = new System.Drawing.Point(25, 32);
            this.txtsuspectedDocId.Name = "txtsuspectedDocId";
            this.txtsuspectedDocId.Size = new System.Drawing.Size(100, 20);
            this.txtsuspectedDocId.TabIndex = 8;
            this.txtsuspectedDocId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyNumeric);
            // 
            // frmDailyServiceReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDailyServiceReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Service Replace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdServiceInfo;
        private System.Windows.Forms.RichTextBox txtDocDetails;
        private System.Windows.Forms.RichTextBox txtIDDetails;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvIdandAdvID;
        private System.Windows.Forms.TextBox txtdocid;
        private System.Windows.Forms.TextBox txtInvAdvID;
        private System.Windows.Forms.RadioButton rbtnAdmissionReffBy;
        private System.Windows.Forms.RadioButton rbtnAdmissionRefTo;
        private System.Windows.Forms.RadioButton rbtnInvestigation;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcessDuplicate;
        private System.Windows.Forms.RichTextBox txtReplaceDocInfo;
        private System.Windows.Forms.RichTextBox txtsuspectedDocInfo;
        private System.Windows.Forms.Button btnshowDuplicate;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReplaceDocId;
        private System.Windows.Forms.TextBox txtsuspectedDocId;
    }
}