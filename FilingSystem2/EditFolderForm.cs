﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilingSystem2
{
    public partial class EditFolderForm : Form
    {
        OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\\db_filingsystem.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();

        private readonly foldersForm _foldersForm;
        public EditFolderForm(foldersForm foldersform)
        {
            InitializeComponent();
            _foldersForm = foldersform;
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
        private void EditFolderForm_Load(object sender, EventArgs e)
        {
            CbLoadBoxes();

            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("foldersForm"), "dgFolder"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var folder_code = dgv.CurrentRow.Cells[1].Value;
            var folder_name = dgv.CurrentRow.Cells[2].Value;
            var folder_description = dgv.CurrentRow.Cells[3].Value;
            var file_box = dgv.CurrentRow.Cells[4].Value;
            var created_by = dgv.CurrentRow.Cells[5].Value;

            tbID.Text = id.ToString();
            tbFolderCode.Text = folder_code.ToString();
            tbFolderName.Text = folder_name.ToString();
            tbFolderDescription.Text = folder_description.ToString();
            cbFileBox.Text = file_box.ToString();

        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFolderCode.Text == "" || tbFolderName.Text == "" || tbFolderDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_folder WHERE folder_code = @folder_code AND ID <> @id", con);
                cmd2.Parameters.AddWithValue("@folder_code", tbFolderCode.Text);
                cmd2.Parameters.AddWithValue("@id", tbID.Text);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("Code prefix has already been used. Please choose another.", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                else {
                    con.Close();

                    OleDbCommand cmd_update_folder = new OleDbCommand(@"UPDATE tbl_folder
                                                SET folder_code = @folder_code,
                                                    folder_name = @folder_name,
                                                    folder_description = @folder_description,
                                                    file_box_id = @file_box_id
                                                WHERE ID = @id", con);

                    cmd_update_folder.Parameters.AddWithValue("@folder_code", tbFolderCode.Text);
                    cmd_update_folder.Parameters.AddWithValue("@folder_name", tbFolderName.Text);
                    cmd_update_folder.Parameters.AddWithValue("@folder_description", tbFolderDescription.Text);
                    cmd_update_folder.Parameters.AddWithValue("@file_box_id", cbFileBox.SelectedValue);
                    cmd_update_folder.Parameters.AddWithValue("@id", tbID.Text);
                    //cmd.Parameters.AddWithValue("@id", tbID.Text);
                    con.Open();
                    cmd_update_folder.ExecuteNonQuery();
                    con.Close();

                    _foldersForm.loadFolders();

                    MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

        }
    }
}
