namespace FilingSystem2
{
    partial class fileBoxForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.llColor = new System.Windows.Forms.LinkLabel();
            this.cbTagColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.tbFileBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFileBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgFileBox = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSelectedFileBoxLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedFileBoxLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tblfileboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.llColor);
            this.panel2.Controls.Add(this.cbTagColor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnFileDocument);
            this.panel2.Controls.Add(this.tbFileBoxDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbFileBoxName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 589);
            this.panel2.TabIndex = 3;
            // 
            // llColor
            // 
            this.llColor.AutoSize = true;
            this.llColor.Location = new System.Drawing.Point(93, 82);
            this.llColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llColor.Name = "llColor";
            this.llColor.Size = new System.Drawing.Size(53, 13);
            this.llColor.TabIndex = 21;
            this.llColor.TabStop = true;
            this.llColor.Text = "Add Color";
            this.llColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llColor_LinkClicked);
            // 
            // cbTagColor
            // 
            this.cbTagColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbTagColor.FormattingEnabled = true;
            this.cbTagColor.Location = new System.Drawing.Point(19, 101);
            this.cbTagColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbTagColor.Name = "cbTagColor";
            this.cbTagColor.Size = new System.Drawing.Size(275, 29);
            this.cbTagColor.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tag Color";
            // 
            // btnFileDocument
            // 
            this.btnFileDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFileDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFileDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFileDocument.ForeColor = System.Drawing.Color.White;
            this.btnFileDocument.Image = global::FilingSystem2.Properties.Resources.add_product;
            this.btnFileDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDocument.Location = new System.Drawing.Point(255, 268);
            this.btnFileDocument.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFileDocument.Size = new System.Drawing.Size(188, 41);
            this.btnFileDocument.TabIndex = 9;
            this.btnFileDocument.Text = "  Create File Box";
            this.btnFileDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // tbFileBoxDescription
            // 
            this.tbFileBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFileBoxDescription.Location = new System.Drawing.Point(19, 163);
            this.tbFileBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileBoxDescription.Multiline = true;
            this.tbFileBoxDescription.Name = "tbFileBoxDescription";
            this.tbFileBoxDescription.Size = new System.Drawing.Size(652, 99);
            this.tbFileBoxDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Box / Location Description";
            // 
            // tbFileBoxName
            // 
            this.tbFileBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFileBoxName.Location = new System.Drawing.Point(19, 40);
            this.tbFileBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileBoxName.MaxLength = 1028;
            this.tbFileBoxName.Name = "tbFileBoxName";
            this.tbFileBoxName.Size = new System.Drawing.Size(652, 29);
            this.tbFileBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Box / Location Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 81);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create File Box / Location";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.dgFileBox);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 273);
            this.panel3.TabIndex = 20;
            // 
            // dgFileBox
            // 
            this.dgFileBox.AllowUserToAddRows = false;
            this.dgFileBox.AllowUserToDeleteRows = false;
            this.dgFileBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFileBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileBox.ContextMenuStrip = this.contextMenuStrip1;
            this.dgFileBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgFileBox.Location = new System.Drawing.Point(0, 73);
            this.dgFileBox.MultiSelect = false;
            this.dgFileBox.Name = "dgFileBox";
            this.dgFileBox.ReadOnly = true;
            this.dgFileBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFileBox.Size = new System.Drawing.Size(689, 200);
            this.dgFileBox.TabIndex = 15;
            this.dgFileBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgFileBox_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedFileBoxLocationToolStripMenuItem,
            this.deleteSelectedFileBoxLocationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 48);
            // 
            // editSelectedFileBoxLocationToolStripMenuItem
            // 
            this.editSelectedFileBoxLocationToolStripMenuItem.Name = "editSelectedFileBoxLocationToolStripMenuItem";
            this.editSelectedFileBoxLocationToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.editSelectedFileBoxLocationToolStripMenuItem.Text = "Edit Selected File Box/Location";
            this.editSelectedFileBoxLocationToolStripMenuItem.Click += new System.EventHandler(this.editSelectedFileBoxLocationToolStripMenuItem_Click);
            // 
            // deleteSelectedFileBoxLocationToolStripMenuItem
            // 
            this.deleteSelectedFileBoxLocationToolStripMenuItem.Name = "deleteSelectedFileBoxLocationToolStripMenuItem";
            this.deleteSelectedFileBoxLocationToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.deleteSelectedFileBoxLocationToolStripMenuItem.Text = "Delete Selected File Box/Location";
            this.deleteSelectedFileBoxLocationToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedFileBoxLocationToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(83, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 29);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search";
            // 
            // tblfileboxBindingSource
            // 
            this.tblfileboxBindingSource.DataMember = "tbl_file_box";
            // 
            // fileBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fileBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Box / Location";
            this.Load += new System.EventHandler(this.fileBoxForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tblfileboxBindingSource;
        private System.Windows.Forms.Button btnFileDocument;
        private System.Windows.Forms.TextBox tbFileBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFileBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgFileBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llColor;
        private System.Windows.Forms.ComboBox cbTagColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editSelectedFileBoxLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedFileBoxLocationToolStripMenuItem;
    }
}