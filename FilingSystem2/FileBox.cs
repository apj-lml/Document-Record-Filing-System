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

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();
        public fileBoxForm()
        {
            InitializeComponent();
        }

        public DataTable MyFileBoxes(string filter_by = null, string filter_value = null)
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
                sql = @"SELECT tfilbox.ID AS [ID], tfilbox.box_code AS [Code Prefix], tfilbox.box_name AS [Box Name], tfilbox.box_description AS [Box Description], usr.last_name &', '& usr.first_name AS [Created By]
                        FROM tbl_file_box AS tfilbox
                        INNER JOIN
                        tbl_user AS usr
                        ON tfilbox.created_by = usr.ID
                        ";
            }
            else
            {
                sql = @"SELECT tfilbox.box_code AS [Code Prefix], tfilbox.box_name AS [Box Name], tfilbox.box_description AS [Box Description], usr.last_name &', '& usr.first_name AS [Created By]
                        FROM tbl_file_box AS tfilbox
                        INNER JOIN
                        tbl_user AS usr
                        ON tfilbox.created_by = usr.ID
                        WHERE " + filter_value + " LIKE '%" + filter_by + "%'";

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

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFileBoxCode.Text == "" || tbFileBoxName.Text == "" || tbFileBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_file_box WHERE box_code = @box_code", con);
                cmd2.Parameters.AddWithValue("@box_code", tbFileBoxCode.Text);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("Code Prefix has already been used. Please choose another Code Prefix.", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                else
                {
                    //con.Close();

                    var emp_id = loginForm.LoginInfo.EmpID;

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO tbl_file_box(box_code, box_name, box_description, created_by) values(@box_code,@box_name,@box_description, @created_by)";
                    cmd.Parameters.AddWithValue("@box_code", tbFileBoxCode.Text);
                    cmd.Parameters.AddWithValue("@box_name", tbFileBoxName.Text);
                    cmd.Parameters.AddWithValue("@box_description", tbFileBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@created_by", emp_id);

                    cmd.Connection = con;
                    //con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    loadFileBoxes();
                    MessageBox.Show("File Box / Location Added Successfully", "Success!");

                }



            }
        }

        private void fileBoxForm_Load(object sender, EventArgs e)
        {
            loadFileBoxes();
        }

        private void dgFileBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new EditFileBox(this).Show();
        }

        private void tbFileBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFileBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
