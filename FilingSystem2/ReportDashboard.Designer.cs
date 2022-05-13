namespace FilingSystem2
{
    partial class ReportDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSaveChangesDocument = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFolder = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 81);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate Report";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btnSaveChangesDocument);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 193);
            this.panel2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 12F);
            this.checkBox1.Location = new System.Drawing.Point(28, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 23);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Generate All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSaveChangesDocument
            // 
            this.btnSaveChangesDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnSaveChangesDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveChangesDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChangesDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChangesDocument.ForeColor = System.Drawing.Color.White;
            this.btnSaveChangesDocument.Image = global::FilingSystem2.Properties.Resources.report;
            this.btnSaveChangesDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChangesDocument.Location = new System.Drawing.Point(110, 123);
            this.btnSaveChangesDocument.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChangesDocument.Name = "btnSaveChangesDocument";
            this.btnSaveChangesDocument.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSaveChangesDocument.Size = new System.Drawing.Size(156, 48);
            this.btnSaveChangesDocument.TabIndex = 40;
            this.btnSaveChangesDocument.Text = "  Generate";
            this.btnSaveChangesDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChangesDocument.UseVisualStyleBackColor = false;
            this.btnSaveChangesDocument.Click += new System.EventHandler(this.btnSaveChangesDocument_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Folder";
            // 
            // cbFolder
            // 
            this.cbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFolder.Font = new System.Drawing.Font("Cambria", 12F);
            this.cbFolder.FormattingEnabled = true;
            this.cbFolder.Items.AddRange(new object[] {
            "All"});
            this.cbFolder.Location = new System.Drawing.Point(28, 41);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(319, 27);
            this.cbFolder.TabIndex = 38;
            this.cbFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFolder_KeyPress);
            // 
            // ReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 274);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Dashboard";
            this.Load += new System.EventHandler(this.ReportDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFolder;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSaveChangesDocument;
    }
}