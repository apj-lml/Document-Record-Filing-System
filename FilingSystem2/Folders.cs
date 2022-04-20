using System;
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
    public partial class foldersForm : Form
    {

        OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\\db_filingsystem.accdb");

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
                sql = @"SELECT tfol.ID AS [ID], tfol.folder_code AS [Code], tfol.folder_name AS [Folder], tfol.folder_description AS [Folder Description], tfilbox.box_name AS [File Box / Location]
                        FROM tbl_folder AS tfol
                            INNER JOIN 
                        tbl_file_box AS tfilbox
                        ON tfol.file_box_id = tfilbox.ID
                        ";

            }
            else
            {
                sql = @"SELECT tfol.ID AS [ID], tfol.folder_code AS [Code], tfol.folder_name AS [Folder], tfol.folder_description AS [Folder Description], tfilbox.box_name AS [File Box / Location],
                        FROM tbl_folder AS tfol
                            INNER JOIN 
                        tbl_file_box AS tfilbox
                        ON tfol.file_box_id = tfilbox.ID
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
        private void foldersForm_Load(object sender, EventArgs e)
        {
            dgFolder.DataSource = MyFolders();
            CbLoadBoxes();
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFolderCode.Text == "" || tbFolderName.Text == "" || tbFolderDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO tbl_folder(folder_code,folder_name, folder_description, file_box_id) values(@folder_code,@folder_name,@folder_description,@file_box_id)";
                    cmd.Parameters.AddWithValue("@folder_code", tbFolderCode.Text);
                    cmd.Parameters.AddWithValue("@folder_name", tbFolderName.Text);
                    cmd.Parameters.AddWithValue("@folder_description", tbFolderDescription.Text);
                    cmd.Parameters.AddWithValue("@file_box_id", int.Parse(cbFileBox.SelectedValue.ToString()));

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Inserted Successfully", "Success!");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new fileBoxForm().Show();
        }

        private void tbFolderCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFolderCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
