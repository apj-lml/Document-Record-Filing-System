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
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();
        public fileBoxForm()
        {
            InitializeComponent();
        }

        public DataTable MyFileBoxes(string filter_value = null)
        {
            string sql = null;

            Console.WriteLine("filter val: " + filter_value);

            if (filter_value == null)
            {
                sql = @"SELECT tfilbox.ID AS [ID], tfilbox.box_name AS [Box Name], tfilbox.box_description AS [Box Description], usr.last_name &', '& usr.first_name AS [Created By]
                        FROM tbl_file_box AS tfilbox
                        LEFT JOIN
                        tbl_user AS usr
                        ON tfilbox.created_by = usr.ID
                        ORDER BY tfilbox.ID ASC
                        ";
            }
            else
            {
                sql = @"SELECT tfilbox.ID AS [ID], tfilbox.box_name AS [Box Name], tfilbox.box_description AS [Box Description], usr.last_name &', '& usr.first_name AS [Created By]
                        FROM tbl_file_box AS tfilbox
                        LEFT JOIN
                        tbl_user AS usr
                        ON tfilbox.created_by = usr.ID
                        WHERE tfilbox.ID LIKE '%" + filter_value + "%' OR tfilbox.box_name LIKE '%" + filter_value + "%' OR tfilbox.box_description LIKE '%" + filter_value + "%' OR usr.last_name &', '& usr.first_name LIKE '%" + filter_value + "%' ";

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
            if (tbFileBoxName.Text == "" || tbFileBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                    var user_id = loginForm.LoginInfo.UserID;

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO tbl_file_box (box_name, box_description, created_by) values(@box_name,@box_description, @created_by)";
                    cmd.Parameters.AddWithValue("@box_name", tbFileBoxName.Text);
                    cmd.Parameters.AddWithValue("@box_description", tbFileBoxDescription.Text);
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
        }

        private void dgFileBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new EditFileBox(this).Show();
        }

        private void tbFileBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dgFileBox.DataSource = MyFileBoxes(textBox1.Text);
        }
    }
}
