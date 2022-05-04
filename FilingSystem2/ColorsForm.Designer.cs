namespace FilingSystem2
{
    partial class ColorsForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgColors = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSelectedColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgColors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tag Color";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Colors";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 81);
            this.panel1.TabIndex = 23;
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbColor.Location = new System.Drawing.Point(9, 38);
            this.tbColor.Margin = new System.Windows.Forms.Padding(2);
            this.tbColor.MaxLength = 1028;
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(280, 29);
            this.tbColor.TabIndex = 15;
            // 
            // btnAddColor
            // 
            this.btnAddColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnAddColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddColor.ForeColor = System.Drawing.Color.White;
            this.btnAddColor.Image = global::FilingSystem2.Properties.Resources.plus_symbol_button__1_;
            this.btnAddColor.Location = new System.Drawing.Point(8, 77);
            this.btnAddColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnAddColor.Size = new System.Drawing.Size(280, 40);
            this.btnAddColor.TabIndex = 24;
            this.btnAddColor.Text = " Add Color";
            this.btnAddColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.llAdd);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.dgColors);
            this.panel2.Controls.Add(this.btnAddColor);
            this.panel2.Controls.Add(this.tbColor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 317);
            this.panel2.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::FilingSystem2.Properties.Resources.diskette_white;
            this.btnSave.Location = new System.Drawing.Point(8, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(71, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(280, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = " Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgColors
            // 
            this.dgColors.AllowUserToAddRows = false;
            this.dgColors.AllowUserToDeleteRows = false;
            this.dgColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgColors.ContextMenuStrip = this.contextMenuStrip1;
            this.dgColors.Location = new System.Drawing.Point(9, 128);
            this.dgColors.MultiSelect = false;
            this.dgColors.Name = "dgColors";
            this.dgColors.ReadOnly = true;
            this.dgColors.RowHeadersWidth = 51;
            this.dgColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgColors.Size = new System.Drawing.Size(279, 176);
            this.dgColors.TabIndex = 25;
            this.dgColors.DoubleClick += new System.EventHandler(this.editSelectedColorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedColorToolStripMenuItem,
            this.deleteSelectedColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 48);
            // 
            // editSelectedColorToolStripMenuItem
            // 
            this.editSelectedColorToolStripMenuItem.Name = "editSelectedColorToolStripMenuItem";
            this.editSelectedColorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editSelectedColorToolStripMenuItem.Text = "Edit Selected Color";
            this.editSelectedColorToolStripMenuItem.Click += new System.EventHandler(this.editSelectedColorToolStripMenuItem_Click);
            // 
            // deleteSelectedColorToolStripMenuItem
            // 
            this.deleteSelectedColorToolStripMenuItem.Name = "deleteSelectedColorToolStripMenuItem";
            this.deleteSelectedColorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteSelectedColorToolStripMenuItem.Text = "Delete Selected Color";
            this.deleteSelectedColorToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedColorToolStripMenuItem_Click);
            // 
            // llAdd
            // 
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(91, 16);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(26, 13);
            this.llAdd.TabIndex = 27;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "Add";
            this.llAdd.Visible = false;
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors Form";
            this.Load += new System.EventHandler(this.ColorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgColors)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgColors;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editSelectedColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedColorToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel llAdd;
    }
}