namespace FilingSystem2
{
    partial class dashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFileBox = new System.Windows.Forms.Button();
            this.btnFolders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgDocumentsRecords = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tblfileBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_filingsystemDataSet1 = new FilingSystem2.db_filingsystemDataSet();
            this.tblfileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbfilingsystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbfilingsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_fileTableAdapter1 = new FilingSystem2.db_filingsystemDataSetTableAdapters.tbl_fileTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocumentsRecords)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfilingsystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfilingsystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnFileBox);
            this.panel1.Controls.Add(this.btnFolders);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 751);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::FilingSystem2.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 681);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(288, 70);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "  LOGOUT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::FilingSystem2.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 517);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(288, 70);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "  REPORTS";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::FilingSystem2.Properties.Resources.users_32x32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 447);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(288, 70);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "  USERS";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnFileBox
            // 
            this.btnFileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFileBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFileBox.FlatAppearance.BorderSize = 0;
            this.btnFileBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFileBox.ForeColor = System.Drawing.Color.White;
            this.btnFileBox.Image = global::FilingSystem2.Properties.Resources.archives;
            this.btnFileBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileBox.Location = new System.Drawing.Point(0, 377);
            this.btnFileBox.Name = "btnFileBox";
            this.btnFileBox.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFileBox.Size = new System.Drawing.Size(288, 70);
            this.btnFileBox.TabIndex = 6;
            this.btnFileBox.Text = "  FILE BOX / LOCATION";
            this.btnFileBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileBox.UseVisualStyleBackColor = false;
            this.btnFileBox.Click += new System.EventHandler(this.btnFileBox_Click);
            // 
            // btnFolders
            // 
            this.btnFolders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFolders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFolders.FlatAppearance.BorderSize = 0;
            this.btnFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFolders.ForeColor = System.Drawing.Color.White;
            this.btnFolders.Image = global::FilingSystem2.Properties.Resources.folder;
            this.btnFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolders.Location = new System.Drawing.Point(0, 307);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFolders.Size = new System.Drawing.Size(288, 70);
            this.btnFolders.TabIndex = 2;
            this.btnFolders.Text = "  FOLDERS";
            this.btnFolders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFolders.UseVisualStyleBackColor = false;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::FilingSystem2.Properties.Resources.dashboard1;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 237);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(288, 70);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  DASHBOARD";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 237);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 751);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgDocumentsRecords);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 514);
            this.panel5.TabIndex = 1;
            // 
            // dgDocumentsRecords
            // 
            this.dgDocumentsRecords.AllowUserToAddRows = false;
            this.dgDocumentsRecords.AllowUserToDeleteRows = false;
            this.dgDocumentsRecords.AllowUserToResizeColumns = false;
            this.dgDocumentsRecords.AllowUserToResizeRows = false;
            this.dgDocumentsRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDocumentsRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDocumentsRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocumentsRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDocumentsRecords.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDocumentsRecords.Location = new System.Drawing.Point(0, 0);
            this.dgDocumentsRecords.MultiSelect = false;
            this.dgDocumentsRecords.Name = "dgDocumentsRecords";
            this.dgDocumentsRecords.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDocumentsRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDocumentsRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgDocumentsRecords.RowTemplate.Height = 24;
            this.dgDocumentsRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDocumentsRecords.Size = new System.Drawing.Size(1000, 514);
            this.dgDocumentsRecords.TabIndex = 0;
            this.dgDocumentsRecords.DoubleClick += new System.EventHandler(this.btnViewDocument_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbFilter);
            this.panel4.Controls.Add(this.btnFileDocument);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 237);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(323, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(328, 185);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(288, 36);
            this.cbFilter.TabIndex = 4;
            // 
            // btnFileDocument
            // 
            this.btnFileDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnFileDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFileDocument.ForeColor = System.Drawing.Color.White;
            this.btnFileDocument.Location = new System.Drawing.Point(632, 177);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Size = new System.Drawing.Size(332, 49);
            this.btnFileDocument.TabIndex = 2;
            this.btnFileDocument.Text = "File Document / Record";
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbSearch.Location = new System.Drawing.Point(29, 185);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(283, 34);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tblfileBindingSource2
            // 
            this.tblfileBindingSource2.DataMember = "tbl_file";
            this.tblfileBindingSource2.DataSource = this.db_filingsystemDataSet1;
            // 
            // db_filingsystemDataSet1
            // 
            this.db_filingsystemDataSet1.DataSetName = "db_filingsystemDataSet";
            this.db_filingsystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblfileBindingSource1
            // 
            this.tblfileBindingSource1.DataMember = "tbl_file";
            this.tblfileBindingSource1.DataSource = this.dbfilingsystemDataSet1BindingSource;
            // 
            // tblfileBindingSource
            // 
            this.tblfileBindingSource.DataMember = "tbl_file";
            // 
            // tbl_fileTableAdapter1
            // 
            this.tbl_fileTableAdapter1.ClearBeforeFill = true;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "dashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDocumentsRecords)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfilingsystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnFolders;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgDocumentsRecords;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFileDocument;
        private System.Windows.Forms.BindingSource dbfilingsystemDataSetBindingSource;
        //private db_filingsystemDataSet db_filingsystemDataSet;
        private System.Windows.Forms.BindingSource tblfileBindingSource;
        //private db_filingsystemDataSetTableAdapters.tbl_fileTableAdapter tbl_fileTableAdapter;
        private System.Windows.Forms.BindingSource dbfilingsystemDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblfileBindingSource1;
        //private System.Windows.Forms.ToolStrip fillByToolStrip;
        //private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private db_filingsystemDataSet db_filingsystemDataSet1;
        //private System.Windows.Forms.BindingSource tblfileBindingSource2;
        private db_filingsystemDataSetTableAdapters.tbl_fileTableAdapter tbl_fileTableAdapter1;
        private System.Windows.Forms.BindingSource tblfileBindingSource2;
        private System.Windows.Forms.Button btnFileBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}