namespace FilingSystem2
{
    partial class EditFileBox
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFileBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llColor = new System.Windows.Forms.LinkLabel();
            this.cbTagColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveChangesFileBox = new System.Windows.Forms.Button();
            this.tblfileboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 78);
            this.panel1.TabIndex = 21;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbID.Location = new System.Drawing.Point(19, 33);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaxLength = 1028;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(72, 29);
            this.tbID.TabIndex = 10;
            this.tbID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIEW FILE BOX / LOCATION";
            // 
            // tbFileBoxDescription
            // 
            this.tbFileBoxDescription.Font = new System.Drawing.Font("Cambria", 12F);
            this.tbFileBoxDescription.Location = new System.Drawing.Point(19, 254);
            this.tbFileBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileBoxDescription.MaxLength = 255;
            this.tbFileBoxDescription.Multiline = true;
            this.tbFileBoxDescription.Name = "tbFileBoxDescription";
            this.tbFileBoxDescription.Size = new System.Drawing.Size(560, 98);
            this.tbFileBoxDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Box / Location Description";
            // 
            // tbFileBoxName
            // 
            this.tbFileBoxName.Font = new System.Drawing.Font("Cambria", 12F);
            this.tbFileBoxName.Location = new System.Drawing.Point(19, 126);
            this.tbFileBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileBoxName.MaxLength = 1028;
            this.tbFileBoxName.Name = "tbFileBoxName";
            this.tbFileBoxName.Size = new System.Drawing.Size(560, 26);
            this.tbFileBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Box / Location Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.llColor);
            this.panel2.Controls.Add(this.cbTagColor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnSaveChangesFileBox);
            this.panel2.Controls.Add(this.tbFileBoxDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbFileBoxName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 432);
            this.panel2.TabIndex = 22;
            // 
            // llColor
            // 
            this.llColor.AutoSize = true;
            this.llColor.Location = new System.Drawing.Point(93, 170);
            this.llColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llColor.Name = "llColor";
            this.llColor.Size = new System.Drawing.Size(53, 13);
            this.llColor.TabIndex = 24;
            this.llColor.TabStop = true;
            this.llColor.Text = "Add Color";
            // 
            // cbTagColor
            // 
            this.cbTagColor.Font = new System.Drawing.Font("Cambria", 12F);
            this.cbTagColor.FormattingEnabled = true;
            this.cbTagColor.Location = new System.Drawing.Point(19, 189);
            this.cbTagColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbTagColor.Name = "cbTagColor";
            this.cbTagColor.Size = new System.Drawing.Size(275, 27);
            this.cbTagColor.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tag Color";
            // 
            // btnSaveChangesFileBox
            // 
            this.btnSaveChangesFileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnSaveChangesFileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveChangesFileBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChangesFileBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChangesFileBox.ForeColor = System.Drawing.Color.White;
            this.btnSaveChangesFileBox.Image = global::FilingSystem2.Properties.Resources.edit;
            this.btnSaveChangesFileBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChangesFileBox.Location = new System.Drawing.Point(198, 371);
            this.btnSaveChangesFileBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChangesFileBox.Name = "btnSaveChangesFileBox";
            this.btnSaveChangesFileBox.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSaveChangesFileBox.Size = new System.Drawing.Size(188, 40);
            this.btnSaveChangesFileBox.TabIndex = 9;
            this.btnSaveChangesFileBox.Text = "  Save Changes";
            this.btnSaveChangesFileBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChangesFileBox.UseVisualStyleBackColor = false;
            this.btnSaveChangesFileBox.Click += new System.EventHandler(this.btnSaveChangesFileBox_Click);
            // 
            // tblfileboxBindingSource
            // 
            this.tblfileboxBindingSource.DataMember = "tbl_file_box";
            // 
            // EditFileBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditFileBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View File Box / Location";
            this.Load += new System.EventHandler(this.EditFileBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileboxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveChangesFileBox;
        private System.Windows.Forms.TextBox tbFileBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFileBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tblfileboxBindingSource;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.LinkLabel llColor;
        private System.Windows.Forms.ComboBox cbTagColor;
        private System.Windows.Forms.Label label7;
    }
}