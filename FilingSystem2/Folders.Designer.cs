namespace FilingSystem2
{
    partial class foldersForm
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
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFileBox = new System.Windows.Forms.ComboBox();
            this.tbFolderDescription = new System.Windows.Forms.TextBox();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFolderCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgFolder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsViewSelectedFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbl_userTableAdapter1 = new FilingSystem2.db_filingsystemDataSetForReportsTableAdapters.tbl_userTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTagColor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFolder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Folder";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbTagColor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnFileDocument);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbFileBox);
            this.panel2.Controls.Add(this.tbFolderDescription);
            this.panel2.Controls.Add(this.tbFolderName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbFolderCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 742);
            this.panel2.TabIndex = 1;
            // 
            // btnFileDocument
            // 
            this.btnFileDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFileDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFileDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFileDocument.ForeColor = System.Drawing.Color.White;
            this.btnFileDocument.Image = global::FilingSystem2.Properties.Resources.folder__2_;
            this.btnFileDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDocument.Location = new System.Drawing.Point(317, 345);
            this.btnFileDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFileDocument.Size = new System.Drawing.Size(155, 49);
            this.btnFileDocument.TabIndex = 9;
            this.btnFileDocument.Text = "Create";
            this.btnFileDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(220, 111);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(144, 16);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add File Box / Location";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "File Box / Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Folder Description";
            // 
            // cbFileBox
            // 
            this.cbFileBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbFileBox.FormattingEnabled = true;
            this.cbFileBox.Location = new System.Drawing.Point(29, 134);
            this.cbFileBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFileBox.Name = "cbFileBox";
            this.cbFileBox.Size = new System.Drawing.Size(335, 36);
            this.cbFileBox.TabIndex = 10;
            // 
            // tbFolderDescription
            // 
            this.tbFolderDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFolderDescription.Location = new System.Drawing.Point(29, 218);
            this.tbFolderDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFolderDescription.Multiline = true;
            this.tbFolderDescription.Name = "tbFolderDescription";
            this.tbFolderDescription.Size = new System.Drawing.Size(745, 120);
            this.tbFolderDescription.TabIndex = 5;
            // 
            // tbFolderName
            // 
            this.tbFolderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFolderName.Location = new System.Drawing.Point(410, 41);
            this.tbFolderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFolderName.MaxLength = 1028;
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.Size = new System.Drawing.Size(343, 34);
            this.tbFolderName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(405, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Folder Name";
            // 
            // tbFolderCode
            // 
            this.tbFolderCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFolderCode.Location = new System.Drawing.Point(29, 43);
            this.tbFolderCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFolderCode.MaxLength = 3;
            this.tbFolderCode.Name = "tbFolderCode";
            this.tbFolderCode.Size = new System.Drawing.Size(335, 34);
            this.tbFolderCode.TabIndex = 1;
            this.tbFolderCode.TextChanged += new System.EventHandler(this.tbFolderCode_TextChanged);
            this.tbFolderCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolderCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Prefix";
            // 
            // dgFolder
            // 
            this.dgFolder.AllowUserToAddRows = false;
            this.dgFolder.AllowUserToDeleteRows = false;
            this.dgFolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFolder.ContextMenuStrip = this.contextMenuStrip1;
            this.dgFolder.Location = new System.Drawing.Point(29, 69);
            this.dgFolder.Margin = new System.Windows.Forms.Padding(4);
            this.dgFolder.MultiSelect = false;
            this.dgFolder.Name = "dgFolder";
            this.dgFolder.ReadOnly = true;
            this.dgFolder.RowHeadersWidth = 51;
            this.dgFolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFolder.Size = new System.Drawing.Size(747, 246);
            this.dgFolder.TabIndex = 15;
            this.dgFolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgFolder_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsViewSelectedFolder,
            this.tsDeleteFolder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 52);
            // 
            // tsViewSelectedFolder
            // 
            this.tsViewSelectedFolder.Name = "tsViewSelectedFolder";
            this.tsViewSelectedFolder.Size = new System.Drawing.Size(249, 24);
            this.tsViewSelectedFolder.Text = "View/Edit Selected Folder";
            this.tsViewSelectedFolder.Click += new System.EventHandler(this.tsViewSelectedFolder_Click);
            // 
            // tsDeleteFolder
            // 
            this.tsDeleteFolder.Name = "tsDeleteFolder";
            this.tsDeleteFolder.Size = new System.Drawing.Size(249, 24);
            this.tsDeleteFolder.Text = "Delete Selected Folder";
            this.tsDeleteFolder.Click += new System.EventHandler(this.tsDeleteFolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbSearch.Location = new System.Drawing.Point(111, 21);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.MaxLength = 1028;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(335, 34);
            this.tbSearch.TabIndex = 18;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.dgFolder);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 502);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 340);
            this.panel3.TabIndex = 19;
            // 
            // tbl_userTableAdapter1
            // 
            this.tbl_userTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(404, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tag Color";
            // 
            // cbTagColor
            // 
            this.cbTagColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbTagColor.FormattingEnabled = true;
            this.cbTagColor.Location = new System.Drawing.Point(409, 134);
            this.cbTagColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTagColor.Name = "cbTagColor";
            this.cbTagColor.Size = new System.Drawing.Size(335, 36);
            this.cbTagColor.TabIndex = 17;
            // 
            // foldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 842);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "foldersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Folder";
            this.Load += new System.EventHandler(this.foldersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFolder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFolderCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFolderDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFileDocument;
        private System.Windows.Forms.ComboBox cbFileBox;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dgFolder;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsViewSelectedFolder;
        private System.Windows.Forms.ToolStripMenuItem tsDeleteFolder;
        private db_filingsystemDataSetForReportsTableAdapters.tbl_userTableAdapter tbl_userTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTagColor;
    }
}