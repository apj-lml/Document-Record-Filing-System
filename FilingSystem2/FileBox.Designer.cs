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
            this.tblfileboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_filingsystemDataSet_test_1 = new FilingSystem2.db_filingsystemDataSet_test_1();
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.tbFileBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFileBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFileBoxCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_file_boxTableAdapter = new FilingSystem2.db_filingsystemDataSet_test_1TableAdapters.tbl_file_boxTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSet_test_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnFileDocument);
            this.panel2.Controls.Add(this.tbFileBoxDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbFileBoxName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbFileBoxCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 353);
            this.panel2.TabIndex = 3;
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
            this.btnFileDocument.Location = new System.Drawing.Point(333, 287);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFileDocument.Size = new System.Drawing.Size(119, 49);
            this.btnFileDocument.TabIndex = 9;
            this.btnFileDocument.Text = " Add";
            this.btnFileDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // tbFileBoxDescription
            // 
            this.tbFileBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFileBoxDescription.Location = new System.Drawing.Point(29, 145);
            this.tbFileBoxDescription.Multiline = true;
            this.tbFileBoxDescription.Name = "tbFileBoxDescription";
            this.tbFileBoxDescription.Size = new System.Drawing.Size(745, 120);
            this.tbFileBoxDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Box / Location Description";
            // 
            // tbFileBoxName
            // 
            this.tbFileBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFileBoxName.Location = new System.Drawing.Point(408, 51);
            this.tbFileBoxName.MaxLength = 1028;
            this.tbFileBoxName.Name = "tbFileBoxName";
            this.tbFileBoxName.Size = new System.Drawing.Size(324, 34);
            this.tbFileBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(403, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Box / Location Name";
            // 
            // tbFileBoxCode
            // 
            this.tbFileBoxCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFileBoxCode.Location = new System.Drawing.Point(29, 51);
            this.tbFileBoxCode.MaxLength = 3;
            this.tbFileBoxCode.Name = "tbFileBoxCode";
            this.tbFileBoxCode.Size = new System.Drawing.Size(334, 34);
            this.tbFileBoxCode.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create File Box / Location";
            // 
            // tbl_file_boxTableAdapter
            // 
            this.tbl_file_boxTableAdapter.ClearBeforeFill = true;
            // 
            // fileBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fileBoxForm";
            this.Text = "File Box / Location";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSet_test_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tblfileboxBindingSource;
        private db_filingsystemDataSet_test_1 db_filingsystemDataSet_test_1;
        private System.Windows.Forms.Button btnFileDocument;
        private System.Windows.Forms.TextBox tbFileBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFileBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFileBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private db_filingsystemDataSet_test_1TableAdapters.tbl_file_boxTableAdapter tbl_file_boxTableAdapter;
    }
}