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
    public partial class ColorsForm : Form
    {

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));

        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();
        public ColorsForm()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();
        }

        public DataTable MyColors(string filter_by = null, string filter_value = null)
        {
            string sql = null;


            if (filter_by == null)
            {
                sql = @"SELECT ID, tag_color AS Color FROM tbl_color ORDER BY ID DESC";

            }

            con.Open();
            OleDbCommand cmd_select_folders = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd_select_folders.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            con.Close();
            return dt;
        }

        public void loadColors()
        {
            dgColors.DataSource = MyColors();
            dgColors.Refresh();
            dgColors.Update();
        }

        private void ColorsForm_Load(object sender, EventArgs e)
        {
            loadColors();
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if(tbColor.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(tbColor.Text.ToUpper());
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_color WHERE tag_color = @my_tag_color", con);
                cmd2.Parameters.AddWithValue("@my_tag_color", tbColor.Text.ToUpper());
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {
                    MessageBox.Show("Color already exists!", "Duplicate Color", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();

                }
                else
                {
                    OleDbCommand cmd_update_folder = new OleDbCommand(@"INSERT INTO tbl_color (tag_color) VALUES (@color)", con);

                    cmd_update_folder.Parameters.AddWithValue("@color", tbColor.Text.ToUpper());

                    cmd_update_folder.ExecuteNonQuery();
                    con.Close();

                    tbColor.Text = "";
                    Form form = Application.OpenForms["foldersForm"];
                    if (form != null)
                    {
                        foldersForm foldersform = (foldersForm)fc.TheForm("foldersForm");
                        foldersform.CbloadColors();
                    }
                    Form form2 = Application.OpenForms["fileBoxForm"];
                    if (form2 != null)
                    {
                        fileBoxForm fileboxform = (fileBoxForm)fc.TheForm("fileBoxForm");
                        fileboxform.CbloadColors();
                    }
                    Form form3 = Application.OpenForms["EditFolderForm"];
                    if (form3 != null)
                    {
                        EditFolderForm editfolderform = (EditFolderForm)fc.TheForm("EditFolderForm");
                        editfolderform.CbloadColors();
                    }
                    MessageBox.Show("Successfully added color!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadColors();
                }
            }
        }

        private void editSelectedColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = dgColors.CurrentRow.Cells[0].Value;
            var color = dgColors.CurrentRow.Cells[1].Value;

            tbColor.Text = color.ToString();
            btnAddColor.Visible = false;
            btnSave.Visible = true;
            llAdd.Visible = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbColor.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var id = dgColors.CurrentRow.Cells[0].Value;

                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_color WHERE tag_color = @my_tag_color", con);
                cmd2.Parameters.AddWithValue("@my_tag_color", tbColor.Text.ToUpper());
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {
                    MessageBox.Show("Color already exists!", "Duplicate Color", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                }
                else {

                    OleDbCommand cmd_update = new OleDbCommand(@"UPDATE tbl_color SET tag_color = @color WHERE ID = @color_id", con);

                    cmd_update.Parameters.AddWithValue("@color", tbColor.Text.ToUpper());
                    cmd_update.Parameters.AddWithValue("@color_id", int.Parse(id.ToString()));


                    //cmd.Parameters.AddWithValue("@id", tbID.Text);
                    //con.Open();
                    cmd_update.ExecuteNonQuery();
                    con.Close();

                    tbColor.Text = "";
                    loadColors();

                    btnAddColor.Visible = true;
                    btnSave.Visible = false;
                    llAdd.Visible = false;

                    Form form = Application.OpenForms["foldersForm"];
                    if (form != null)
                    {
                        foldersForm foldersform = (foldersForm)fc.TheForm("foldersForm");
                        foldersform.CbloadColors();
                    }
                    Form form2 = Application.OpenForms["fileBoxForm"];
                    if (form2 != null)
                    {
                        fileBoxForm fileboxform = (fileBoxForm)fc.TheForm("fileBoxForm");
                        fileboxform.CbloadColors();
                    }
                    Form form3 = Application.OpenForms["EditFolderForm"];
                    if (form3 != null)
                    {
                        EditFolderForm editfolderform = (EditFolderForm)fc.TheForm("EditFolderForm");
                        editfolderform.CbloadColors();
                    }

                    MessageBox.Show("Saved Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void deleteSelectedColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = dgColors.CurrentRow.Cells[0].Value;



            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Tag Color?", "Delete Tag Color?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_folder WHERE folder_tag_color = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("You can't delete this Tag Color because it is currently used in a folder. ", "Deleting Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();

                }
                else
                {

                    OleDbCommand cmd3 = new OleDbCommand(@"SELECT * FROM tbl_file_box WHERE box_tag_color = @id", con);
                    cmd3.Parameters.AddWithValue("@id", id);
                    //con.Open();
                    OleDbDataReader reader3 = cmd3.ExecuteReader();

                    if (reader3.Read() == true)
                    {

                        MessageBox.Show("You can't delete this Tag Color because it is currently used in a Box / Location. ", "Deleting Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();

                    }
                    else
                    {

                        OleDbCommand cmd_delete = new OleDbCommand(@"DELETE FROM tbl_color
                                        WHERE ID = @id", con);

                        cmd_delete.Parameters.AddWithValue("@id", id);
                        //con.Open();
                        cmd_delete.ExecuteNonQuery();
                        con.Close();

                        loadColors();
                        Form form = Application.OpenForms["foldersForm"];
                        if (form != null)
                        {
                            foldersForm foldersform = (foldersForm)fc.TheForm("foldersForm");
                            foldersform.CbloadColors();
                        }
                        Form form2 = Application.OpenForms["fileBoxForm"];
                        if (form2 != null)
                        {
                            fileBoxForm fileboxform = (fileBoxForm)fc.TheForm("fileBoxForm");
                            fileboxform.CbloadColors();
                        }
                        Form form3 = Application.OpenForms["EditFolderForm"];
                        if (form3 != null)
                        {
                            EditFolderForm editfolderform = (EditFolderForm)fc.TheForm("EditFolderForm");
                            editfolderform.CbloadColors();
                        }
                        MessageBox.Show("Deleted succesfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }






            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbColor.Text = "";
            btnAddColor.Visible = true;
            btnSave.Visible = false;
            llAdd.Visible = false;
        }
    }
}
