namespace FilingSystem2
{
    partial class AdminUserControl
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnFileDocument = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNameExtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmpId = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgListOfUsers = new System.Windows.Forms.DataGridView();
            this.cmControlsDg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSelectedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfUsers)).BeginInit();
            this.cmControlsDg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(287, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Status";
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
            this.btnFileDocument.Location = new System.Drawing.Point(424, 290);
            this.btnFileDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileDocument.Name = "btnFileDocument";
            this.btnFileDocument.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnFileDocument.Size = new System.Drawing.Size(139, 41);
            this.btnFileDocument.TabIndex = 41;
            this.btnFileDocument.Text = "  Add User";
            this.btnFileDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileDocument.UseVisualStyleBackColor = false;
            this.btnFileDocument.Click += new System.EventHandler(this.btnFileDocument_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(551, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Middle Name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbMiddleName.Location = new System.Drawing.Point(555, 104);
            this.tbMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMiddleName.MaxLength = 1028;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(261, 29);
            this.tbMiddleName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(287, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbFirstName.Location = new System.Drawing.Point(291, 104);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.MaxLength = 1028;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(260, 29);
            this.tbFirstName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Users";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(289, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Unit";
            // 
            // cbUnit
            // 
            this.cbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Administrative Unit",
            "Finance Unit",
            "Property Unit",
            "Design Unit",
            "Planning Unit",
            "Construction Unit",
            "Institutional Development Unit",
            "N/A"});
            this.cbUnit.Location = new System.Drawing.Point(291, 167);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(260, 29);
            this.cbUnit.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Section";
            // 
            // cbSection
            // 
            this.cbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Items.AddRange(new object[] {
            "Administrative & Finance Section",
            "Engineering Section",
            "Operations & Maintenance",
            "Office of the Irrigation Manager",
            "N/A"});
            this.cbSection.Location = new System.Drawing.Point(19, 167);
            this.cbSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(269, 29);
            this.cbSection.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(816, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Name Extension";
            // 
            // tbNameExtn
            // 
            this.tbNameExtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbNameExtn.Location = new System.Drawing.Point(820, 104);
            this.tbNameExtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameExtn.MaxLength = 1028;
            this.tbNameExtn.Name = "tbNameExtn";
            this.tbNameExtn.Size = new System.Drawing.Size(126, 29);
            this.tbNameExtn.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Employee ID";
            // 
            // tbEmpId
            // 
            this.tbEmpId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmpId.Location = new System.Drawing.Point(19, 41);
            this.tbEmpId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmpId.MaxLength = 6;
            this.tbEmpId.Name = "tbEmpId";
            this.tbEmpId.Size = new System.Drawing.Size(269, 29);
            this.tbEmpId.TabIndex = 33;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbLastName.Location = new System.Drawing.Point(19, 104);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.MaxLength = 1028;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(269, 29);
            this.tbLastName.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 78);
            this.panel1.TabIndex = 26;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbId.HideSelection = false;
            this.tbId.Location = new System.Drawing.Point(73, 27);
            this.tbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbId.MaxLength = 1028;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(269, 29);
            this.tbId.TabIndex = 46;
            this.tbId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbRole);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbConfirmPassword);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.btnSaveChanges);
            this.panel2.Controls.Add(this.btnFileDocument);
            this.panel2.Controls.Add(this.tbMiddleName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbFirstName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbUnit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbLastName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbEmpId);
            this.panel2.Controls.Add(this.tbNameExtn);
            this.panel2.Controls.Add(this.cbSection);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 522);
            this.panel2.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(289, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Confirm Password";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbConfirmPassword.Location = new System.Drawing.Point(291, 230);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbConfirmPassword.MaxLength = 1028;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(260, 29);
            this.tbConfirmPassword.TabIndex = 48;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbPassword.Location = new System.Drawing.Point(19, 230);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.MaxLength = 1028;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(269, 29);
            this.tbPassword.TabIndex = 46;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.btnSaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Image = global::FilingSystem2.Properties.Resources.diskette_white;
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.Location = new System.Drawing.Point(400, 290);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 41);
            this.btnSaveChanges.TabIndex = 45;
            this.btnSaveChanges.Text = "  Save Changes";
            this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgListOfUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 431);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 169);
            this.panel3.TabIndex = 46;
            // 
            // dgListOfUsers
            // 
            this.dgListOfUsers.AllowUserToAddRows = false;
            this.dgListOfUsers.AllowUserToDeleteRows = false;
            this.dgListOfUsers.AllowUserToResizeRows = false;
            this.dgListOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListOfUsers.ContextMenuStrip = this.cmControlsDg;
            this.dgListOfUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListOfUsers.Location = new System.Drawing.Point(0, 0);
            this.dgListOfUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgListOfUsers.Name = "dgListOfUsers";
            this.dgListOfUsers.ReadOnly = true;
            this.dgListOfUsers.RowHeadersWidth = 51;
            this.dgListOfUsers.RowTemplate.Height = 24;
            this.dgListOfUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListOfUsers.Size = new System.Drawing.Size(957, 169);
            this.dgListOfUsers.TabIndex = 0;
            // 
            // cmControlsDg
            // 
            this.cmControlsDg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmControlsDg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedUserToolStripMenuItem,
            this.activateUserToolStripMenuItem,
            this.deactivateUserToolStripMenuItem});
            this.cmControlsDg.Name = "cmControlsDg";
            this.cmControlsDg.Size = new System.Drawing.Size(203, 92);
            // 
            // editSelectedUserToolStripMenuItem
            // 
            this.editSelectedUserToolStripMenuItem.Name = "editSelectedUserToolStripMenuItem";
            this.editSelectedUserToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editSelectedUserToolStripMenuItem.Text = "Edit Selected User";
            this.editSelectedUserToolStripMenuItem.Click += new System.EventHandler(this.editSelectedUserToolStripMenuItem_Click);
            // 
            // activateUserToolStripMenuItem
            // 
            this.activateUserToolStripMenuItem.Name = "activateUserToolStripMenuItem";
            this.activateUserToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.activateUserToolStripMenuItem.Text = "Activate Selected User";
            this.activateUserToolStripMenuItem.Click += new System.EventHandler(this.activateUserToolStripMenuItem_Click);
            // 
            // deactivateUserToolStripMenuItem
            // 
            this.deactivateUserToolStripMenuItem.Name = "deactivateUserToolStripMenuItem";
            this.deactivateUserToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deactivateUserToolStripMenuItem.Text = "Deactivate Selected User";
            this.deactivateUserToolStripMenuItem.Click += new System.EventHandler(this.deactivateUserToolStripMenuItem_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(291, 41);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(260, 29);
            this.cbStatus.TabIndex = 50;
            // 
            // cbRole
            // 
            this.cbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbRole.Location = new System.Drawing.Point(556, 41);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(260, 29);
            this.cbRole.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(552, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "Role";
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminUserControl";
            this.Text = "AdminUserControl";
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfUsers)).EndInit();
            this.cmControlsDg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFileDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNameExtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmpId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgListOfUsers;
        private System.Windows.Forms.ContextMenuStrip cmControlsDg;
        private System.Windows.Forms.ToolStripMenuItem editSelectedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateUserToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label12;
    }
}