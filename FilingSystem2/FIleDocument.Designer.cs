﻿namespace FilingSystem2
{
    partial class addDocumentRecordForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.cbFolder = new System.Windows.Forms.ComboBox();
            this.tblfolderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbParticulars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblfolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfolderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfolderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "File a Document / Record";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbRemarks);
            this.panel2.Controls.Add(this.cbFolder);
            this.panel2.Controls.Add(this.btnFileDocument);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbParticulars);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbSubject);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 510);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(855, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remarks";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbRemarks.Location = new System.Drawing.Point(860, 127);
            this.tbRemarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(283, 288);
            this.tbRemarks.TabIndex = 4;
            // 
            // cbFolder
            // 
            this.cbFolder.DataSource = this.tblfolderBindingSource1;
            this.cbFolder.DisplayMember = "folder_name";
            this.cbFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbFolder.FormattingEnabled = true;
            this.cbFolder.Location = new System.Drawing.Point(443, 49);
            this.cbFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(393, 36);
            this.cbFolder.TabIndex = 1;
            this.cbFolder.ValueMember = "ID";
            this.cbFolder.SelectedIndexChanged += new System.EventHandler(this.cbFolder_SelectedIndexChanged);
            // 
            // tblfolderBindingSource1
            // 
            this.tblfolderBindingSource1.DataMember = "tbl_folder";
            // 
            // btnFileDocument
            // 
            this.btnFileDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFileDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFileDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFileDocument.ForeColor = System.Drawing.Color.White;
            this.btnFileDocument.Image = global::FilingSystem2.Properties.Resources.plus_symbol_button__1_;
            this.btnFileDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDocument.Location = new System.Drawing.Point(416, 440);
            this.btnFileDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFileDocument.Size = new System.Drawing.Size(344, 49);
            this.btnFileDocument.TabIndex = 5;
            this.btnFileDocument.Text = " Add Document / Record";
            this.btnFileDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(515, 27);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 16);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add Folder";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(437, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Folder";
            // 
            // tbParticulars
            // 
            this.tbParticulars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbParticulars.Location = new System.Drawing.Point(27, 260);
            this.tbParticulars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbParticulars.Multiline = true;
            this.tbParticulars.Name = "tbParticulars";
            this.tbParticulars.Size = new System.Drawing.Size(809, 155);
            this.tbParticulars.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Particulars";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbSubject.Location = new System.Drawing.Point(27, 127);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubject.Multiline = true;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(809, 91);
            this.tbSubject.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbCode.Location = new System.Drawing.Point(27, 49);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(379, 34);
            this.tbCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // addDocumentRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addDocumentRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File a Document / Record";
            this.Load += new System.EventHandler(this.addDocumentRecordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfolderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfolderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbParticulars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnFileDocument;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tblfolderBindingSource;
        private System.Windows.Forms.ComboBox cbFolder;
        private System.Windows.Forms.BindingSource tblfolderBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRemarks;
    }
}