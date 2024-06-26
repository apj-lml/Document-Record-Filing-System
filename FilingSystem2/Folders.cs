﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilingSystem2
{
    public partial class foldersForm : Form
    {
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        public foldersForm()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();
        }
        public void CbLoadBoxes()
        {
            string query = "SELECT * FROM tbl_file_box ORDER BY box_name ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Box");

            cbFileBox.DisplayMember = "box_name";
            cbFileBox.ValueMember = "ID";
            cbFileBox.DataSource = ds.Tables["Box"];

        }

        public void CbloadColors()
        {
            string query = "SELECT * FROM tbl_color ORDER BY tag_color ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Colors");

            cbTagColor.DisplayMember = "tag_color";
            cbTagColor.ValueMember = "ID";
            cbTagColor.DataSource = ds.Tables["Colors"];

        }

        public DataTable MyFolders(string filter_by = null, string filter_value = null)
        {
            string sql = null;

            Console.WriteLine("filter val: " + filter_by);

            if (filter_by == null)
            {
                sql = @"SELECT tfol.ID AS [ID], tfol.folder_code AS [Code], tfol.folder_name AS [Folder],
                               tfol.folder_description AS [Folder Description], clr.tag_color AS [Folder Tag Color], tfilbox.box_name AS [File Box / Location], usr.last_name & ', ' & usr.first_name AS [Created By]
                        FROM (((tbl_folder AS tfol
                            LEFT JOIN
                        tbl_file_box AS tfilbox
                        ON tfol.file_box_id = tfilbox.ID)
                            LEFT JOIN
                        tbl_user AS usr
                        ON usr.ID = tfol.created_by)
                            LEFT JOIN
                        tbl_color AS clr
                        ON tfol.folder_tag_color = clr.ID)
                        ORDER BY tfol.ID DESC
                        ";
            }
            else
            {
                sql = @"SELECT tfol.ID AS [ID], tfol.folder_code AS [Code], tfol.folder_name AS [Folder],
                               tfol.folder_description AS [Folder Description], clr.tag_color AS [Folder Tag Color], tfilbox.box_name AS [File Box / Location], usr.last_name & ', ' & usr.first_name AS [Created By]
                        FROM (((tbl_folder AS tfol
                            LEFT JOIN
                        tbl_file_box AS tfilbox
                        ON tfol.file_box_id = tfilbox.ID)
                            LEFT JOIN
                        tbl_user AS usr
                        ON usr.ID = tfol.created_by)
                            LEFT JOIN
                        tbl_color AS clr
                        ON tfol.folder_tag_color = clr.ID)

                        WHERE tfol.ID LIKE '%" + filter_by + "%' OR tfol.folder_code LIKE '%" + filter_by + "%' OR tfol.folder_name LIKE '%" + filter_by + "%' OR tfol.folder_description LIKE '%" + filter_by + "%' " +
                        "OR tfilbox.box_name LIKE '%" + filter_by + "%' OR usr.last_name LIKE '%" + filter_by + "%' OR usr.first_name LIKE '%" + filter_by + "%' OR clr.tag_color LIKE '%" + filter_by + "%' ";
            }
            con.Open();
            OleDbCommand cmd_select_folders = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd_select_folders.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            con.Close();
            return dt;
        }
        public void loadFolders()
        {
            dgFolder.DataSource = MyFolders();
            dgFolder.Refresh();
            dgFolder.Update();
        }
        public string RandomChars()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void AdjustWidthComboBox_DropDown(object sender, EventArgs e)
        {
            var senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }
        private void foldersForm_Load(object sender, EventArgs e)
        {
            loadFolders();
            CbLoadBoxes();
            CbloadColors();

            this.dgFolder.Columns["Code"].Visible = false;

            if (dgFolder.Rows.Count <= 0)
            {
                tsDeleteFolder.Enabled = false;
                tsViewSelectedFolder.Enabled = false;
            }
            else
            {
                tsDeleteFolder.Enabled = true;
                tsViewSelectedFolder.Enabled = true;
            }
            tbFolderCode.Text = RandomChars();
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFolderCode.Text == "" || tbFolderName.Text == "" || cbFileBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_folder WHERE folder_name = @my_folder_name", con);
                cmd2.Parameters.AddWithValue("@my_folder_name", tbFolderName.Text.ToUpper());
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {
                    MessageBox.Show("Folder name already exists. Please choose another.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();

                }
                else
                {
                    var user_id = loginForm.LoginInfo.UserID;

                    con.Close();

                    //cmd.CommandType = CommandType.Text;
                    string sql = @"INSERT INTO tbl_folder(folder_code,folder_name, folder_description, file_box_id, folder_tag_color, created_by)
                                                    VALUES (@folder_code,@folder_name,@folder_description,@file_box_id,@folder_tag_color,@created_by)";
                    //cmd.Connection = con;
                    con.Open();
                    cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.AddWithValue("@folder_code", tbFolderCode.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@folder_name", tbFolderName.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@folder_description", tbFolderDescription.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@file_box_id", int.Parse(cbFileBox.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@folder_tag_color", int.Parse(cbTagColor.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@created_by", user_id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Form form = Application.OpenForms["addDocumentRecordForm"];
                    if (form != null)
                    {
                        addDocumentRecordForm adddocumentrecordform = (addDocumentRecordForm)fc.TheForm("addDocumentRecordForm");
                        adddocumentrecordform.CbLoadFolders();
                    }

                    loadFolders();
                    clearFields();
                    MessageBox.Show("Record Inserted Successfully", "Success!");
                }
            }
        }

        private void clearFields() {

            tbFolderCode.Text = "";
            tbFolderName.Text = "";
            cbFileBox.SelectedIndex = 0;
            cbTagColor.SelectedIndex = 0;
            tbFolderDescription.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            new fileBoxForm().ShowDialog();
        }

        private void tbFolderCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void dgFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgFolder.SelectedRows.Count > 0)
            {
                new EditFolderForm(this).ShowDialog();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(tbSearch.Text);
            dgFolder.DataSource = MyFolders(tbSearch.Text);

        }

        private void tsViewSelectedFolder_Click(object sender, EventArgs e)
        {
            new EditFolderForm(this).ShowDialog();
        }

        private void tsDeleteFolder_Click(object sender, EventArgs e)
        {
            var folder_id = dgFolder.CurrentRow.Cells[0].Value;
                
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this folder?", "Delete Folder?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_file WHERE folder_id = @folder_id", con);
                cmd2.Parameters.AddWithValue("@folder_id", folder_id);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();
                if (reader.Read() == true)
                {
                    con.Close();

                    MessageBox.Show("Please transfer the files in this folder first before deleting!", "Deleting Folder Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    con.Close();

                    OleDbCommand cmd_delete_folder = new OleDbCommand(@"DELETE FROM tbl_folder
                                            WHERE ID = @folder_id", con);

                    cmd_delete_folder.Parameters.AddWithValue("@folder_id", folder_id);
                    con.Open();
                    cmd_delete_folder.ExecuteNonQuery();
                    con.Close();

                    Form form = Application.OpenForms["addDocumentRecordForm"];
                    if (form != null)
                    {
                        addDocumentRecordForm adddocumentrecordform = (addDocumentRecordForm)fc.TheForm("addDocumentRecordForm");
                        adddocumentrecordform.CbLoadFolders();
                    }

                    MessageBox.Show("Folder deleted succesfully!", "Folder Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    loadFolders();

                }
            }
        }

        private void llColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ColorsForm().ShowDialog();
        }

        private void cbFileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled  = true;
        }

        private void cbTagColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
