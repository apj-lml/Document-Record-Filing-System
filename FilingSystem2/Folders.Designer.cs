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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cbFileBox = new System.Windows.Forms.ComboBox();
            this.tblfileboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_filingsystemDataSet_test_1 = new FilingSystem2.db_filingsystemDataSet_test_1();
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFolderDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFolderCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_file_boxTableAdapter = new FilingSystem2.db_filingsystemDataSet_test_1TableAdapters.tbl_file_boxTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSet_test_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Folder";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.cbFileBox);
            this.panel2.Controls.Add(this.btnFileDocument);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbFolderDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbFolderName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbFolderCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 418);
            this.panel2.TabIndex = 1;
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
            // cbFileBox
            // 
            this.cbFileBox.DataSource = this.tblfileboxBindingSource;
            this.cbFileBox.DisplayMember = "box_name";
            this.cbFileBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbFileBox.FormattingEnabled = true;
            this.cbFileBox.Location = new System.Drawing.Point(29, 134);
            this.cbFileBox.Name = "cbFileBox";
            this.cbFileBox.Size = new System.Drawing.Size(334, 36);
            this.cbFileBox.TabIndex = 10;
            this.cbFileBox.ValueMember = "ID";
            // 
            // tblfileboxBindingSource
            // 
            this.tblfileboxBindingSource.DataMember = "tbl_file_box";
            this.tblfileboxBindingSource.DataSource = this.db_filingsystemDataSet_test_1;
            // 
            // db_filingsystemDataSet_test_1
            // 
            this.db_filingsystemDataSet_test_1.DataSetName = "db_filingsystemDataSet_test_1";
            this.db_filingsystemDataSet_test_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnFileDocument.Location = new System.Drawing.Point(321, 352);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFileDocument.Size = new System.Drawing.Size(119, 49);
            this.btnFileDocument.TabIndex = 9;
            this.btnFileDocument.Text = " Add";
            this.btnFileDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
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
            // tbFolderDescription
            // 
            this.tbFolderDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFolderDescription.Location = new System.Drawing.Point(29, 218);
            this.tbFolderDescription.Multiline = true;
            this.tbFolderDescription.Name = "tbFolderDescription";
            this.tbFolderDescription.Size = new System.Drawing.Size(745, 120);
            this.tbFolderDescription.TabIndex = 5;
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
            // tbFolderName
            // 
            this.tbFolderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFolderName.Location = new System.Drawing.Point(408, 51);
            this.tbFolderName.MaxLength = 1028;
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.Size = new System.Drawing.Size(324, 34);
            this.tbFolderName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(403, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Folder Name";
            // 
            // tbFolderCode
            // 
            this.tbFolderCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFolderCode.Location = new System.Drawing.Point(29, 51);
            this.tbFolderCode.MaxLength = 3;
            this.tbFolderCode.Name = "tbFolderCode";
            this.tbFolderCode.Size = new System.Drawing.Size(334, 34);
            this.tbFolderCode.TabIndex = 1;
            this.tbFolderCode.TextChanged += new System.EventHandler(this.tbFolderCode_TextChanged);
            this.tbFolderCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolderCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Prefix";
            // 
            // tbl_file_boxTableAdapter
            // 
            this.tbl_file_boxTableAdapter.ClearBeforeFill = true;
            // 
            // foldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "foldersForm";
            this.Text = "Create Folder";
            this.Load += new System.EventHandler(this.foldersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSet_test_1)).EndInit();
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
        private db_filingsystemDataSet_test_1 db_filingsystemDataSet_test_1;
        private System.Windows.Forms.BindingSource tblfileboxBindingSource;
        private db_filingsystemDataSet_test_1TableAdapters.tbl_file_boxTableAdapter tbl_file_boxTableAdapter;
    }
}