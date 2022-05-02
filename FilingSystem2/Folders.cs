using System;
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

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        public foldersForm()
        {
            InitializeComponent();
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
            string query = "SELECT * FROM tbl_color ORDER BY color ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Colors");

            cbTagColor.DisplayMember = "color";
            cbTagColor.ValueMember = "ID";
            cbTagColor.DataSource = ds.Tables["Colors"];

        }

        public DataTable MyFolders(string filter_by = null, string filter_value = null)
        {
            string sql = null;
            //if (filter_value == "ID")
            //{
            //    filter_value = "tfil.ID";
            //}
            //else if (filter_value == "code")
            //{
            //    filter_value = "tfil.code";

            //}
            //else if (filter_value == "subject")
            //{
            //    filter_value = "tfil.subject";
            //}
            //else if (filter_value == "particulars")
            //{
            //    filter_value = "tfil.particulars";
            //}
            //else if (filter_value == "folder_name")
            //{
            //    filter_value = "tfol.folder_name";
            //}
            //else if (filter_value == "box_name")
            //{
            //    filter_value = "tfilbox.box_name";
            //}
            //else if (filter_value == "filed_by")
            //{
            //    filter_value = "usr.last_name & ', '& usr.first_name";
            //}
            //else
            //{
            //    //filter_value = "usr.last_name & ', '& usr.first_name";

            //}

            Console.WriteLine("filter val: " + filter_value);

            if (filter_by == null)
            {
                sql = @"SELECT tfol.ID AS [ID], tfol.folder_code AS [Code], tfol.folder_name AS [Folder],
                               tfol.folder_description AS [Folder Description], tfilbox.box_name AS [File Box / Location], usr.last_name & ', ' & usr.first_name AS [Created By]
                        FROM ((tbl_folder AS tfol
                            LEFT JOIN
                        tbl_file_box AS tfilbox
                        ON tfol.file_box_id = tfilbox.ID)
                            LEFT JOIN
                        tbl_user AS usr
                        ON usr.ID = tfol.created_by)
                        ";

                //sql = @"SELECT * FROM tbl_folder";

            }
            else
            {
                sql = @"SELECT tfol.ID AS [ID], tfol.folder_code AS [Code], tfol.folder_name AS [Folder],
                               tfol.folder_description AS [Folder Description], tfilbox.box_name AS [File Box / Location], usr.last_name & ', ' & usr.first_name AS [Created By]
                        FROM ((tbl_folder AS tfol
                            LEFT JOIN
                        tbl_file_box AS tfilbox
                        ON tfol.file_box_id = tfilbox.ID)
                            LEFT JOIN
                        tbl_user AS usr
                        ON usr.ID = tfol.created_by)
                        WHERE tfol.ID LIKE '%" + filter_by + "%' OR tfol.folder_code LIKE '%" + filter_by + "%' OR tfol.folder_name LIKE '%" + filter_by + "%' OR tfol.folder_description LIKE '%" + filter_by + "%' " +
                        "OR tfilbox.box_name LIKE '%" + filter_by + "%' OR usr.last_name LIKE '%" + filter_by + "%' OR usr.first_name LIKE '%" + filter_by + "%'";

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
        private void foldersForm_Load(object sender, EventArgs e)
        {
            loadFolders();
            CbLoadBoxes();
            CbloadColors();
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {

            if (tbFolderCode.Text == "" || tbFolderName.Text == "" || tbFolderDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_folder WHERE folder_code = @folder_code", con);
                cmd2.Parameters.AddWithValue("@folder_code", tbFolderCode.Text);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("Code prefix has already been used. Please choose another.", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                else
                {
                    var user_id = loginForm.LoginInfo.UserID;

                    con.Close();

                    //cmd.CommandType = CommandType.Text;
                    string sql = "INSERT INTO tbl_folder(folder_code,folder_name, folder_description, file_box_id, created_by) values(@folder_code,@folder_name,@folder_description,@file_box_id,@created_by)";
                    

                    //cmd.Connection = con;
                    con.Open();
                    cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.AddWithValue("@folder_code", tbFolderCode.Text);
                    cmd.Parameters.AddWithValue("@folder_name", tbFolderName.Text);
                    cmd.Parameters.AddWithValue("@folder_description", tbFolderDescription.Text);
                    cmd.Parameters.AddWithValue("@file_box_id", int.Parse(cbFileBox.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@created_by", user_id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    loadFolders();
                    MessageBox.Show("Record Inserted Successfully", "Success!");

                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new fileBoxForm().ShowDialog();
        }

        private void tbFolderCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void dgFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new EditFolderForm(this).ShowDialog();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgFolder.DataSource = MyFolders(tbSearch.Text);

        }

        private void tbFolderCode_TextChanged(object sender, EventArgs e)
        {

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

                    MessageBox.Show("Folder deleted succesfully!", "Folder Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadFolders();

                }
            }
            

        }
    }
}
