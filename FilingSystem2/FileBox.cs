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
    public partial class fileBoxForm : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();
        public fileBoxForm()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();
        }

        public DataTable MyFileBoxes(string filter_value = null)
        {
            string sql = null;

            Console.WriteLine("filter val: " + filter_value);

            if (filter_value == null)
            {
                sql = @"SELECT tfilbox.ID AS [ID], tfilbox.box_name AS [Box Name], tfilbox.box_description AS [Box Description], clr.tag_color AS [Tag Color], usr.last_name &', '& usr.first_name AS [Created By]
                        FROM ((tbl_file_box AS tfilbox
                            LEFT JOIN
                        tbl_user AS usr
                        ON tfilbox.created_by = usr.ID)
                            LEFT JOIN
                        tbl_color AS clr
                        ON tfilbox.box_tag_color = clr.ID)
                        ORDER BY tfilbox.ID DESC
                        ";
            }
            else
            {
                sql = @"SELECT tfilbox.ID AS [ID], tfilbox.box_name AS [Box Name], tfilbox.box_description AS [Box Description], clr.tag_color AS [Tag Color], usr.last_name &', '& usr.first_name AS [Created By]
                        FROM ((tbl_file_box AS tfilbox
                            LEFT JOIN
                        tbl_user AS usr
                        ON tfilbox.created_by = usr.ID)
                            LEFT JOIN
                        tbl_color AS clr
                        ON tfilbox.box_tag_color = clr.ID)

                        WHERE tfilbox.ID LIKE '%" + filter_value + "%' OR tfilbox.box_name LIKE '%" + filter_value + "%' OR tfilbox.box_description LIKE '%" + filter_value + "%' OR usr.last_name &', '& usr.first_name LIKE '%" + filter_value + "%' OR clr.tag_color LIKE '%" + filter_value + "%'; ";

            }
            con.Open();
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            con.Close();
            return dt;
        }

        public void loadFileBoxes()
        {
            dgFileBox.DataSource = MyFileBoxes();
            dgFileBox.Refresh();
            dgFileBox.Update();
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

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFileBoxName.Text == "" || tbFileBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                    var user_id = loginForm.LoginInfo.UserID;

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO tbl_file_box (box_name, box_description, box_tag_color, created_by) values(@box_name,@box_description, @box_tag_color, @created_by)";
                    cmd.Parameters.AddWithValue("@box_name", tbFileBoxName.Text);
                    cmd.Parameters.AddWithValue("@box_description", tbFileBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@box_tag_color", cbTagColor.SelectedValue);
                cmd.Parameters.AddWithValue("@created_by", user_id);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    loadFileBoxes();
                    MessageBox.Show("File Box / Location Added Successfully", "Success!");

            }
        }

        private void fileBoxForm_Load(object sender, EventArgs e)
        {
            loadFileBoxes();
            CbloadColors();
        }

        private void dgFileBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new EditFileBox(this).ShowDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dgFileBox.DataSource = MyFileBoxes(textBox1.Text);
        }

        private void llColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ColorsForm().ShowDialog();
        }

        private void editSelectedFileBoxLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditFileBox(this).ShowDialog();
        }

        private void deleteSelectedFileBoxLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = dgFileBox.CurrentRow.Cells[0].Value;
            Console.WriteLine(id);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this File Box / Location?", "Delete File Box / Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_folder WHERE file_box_id = @file_box_id", con);
                cmd2.Parameters.AddWithValue("@file_box_id", id);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("You can't delete this File Box / Location because it is currently being used by a Folder. Please transfer its contents first before trying to delete again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                else
                {
                    OleDbCommand cmd_delete = new OleDbCommand();

                    cmd_delete.CommandType = CommandType.Text;
                    cmd_delete.CommandText = "DELETE * FROM tbl_file_box WHERE ID = @id";
                    cmd_delete.Parameters.AddWithValue("@id", int.Parse(id.ToString()));


                    cmd_delete.Connection = con;
                    cmd_delete.ExecuteNonQuery();
                    con.Close();

                    loadFileBoxes();
                    MessageBox.Show("File Box / Location Deleted Successfully", "Success!");
                }

            }

        }
    }
}
