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
    public partial class EditFileBox : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        private readonly fileBoxForm _fileBoxForm;
        public EditFileBox(fileBoxForm fileboxform)
        {
            InitializeComponent();
            _fileBoxForm = fileboxform;
            con = myConnectionString.MyConnection();
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

        private void EditFileBox_Load(object sender, EventArgs e)
        {
            CbloadColors();
            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("fileBoxForm"), "dgFileBox"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var box_name = dgv.CurrentRow.Cells[1].Value;
            var box_description = dgv.CurrentRow.Cells[2].Value;
            var tag_color = dgv.CurrentRow.Cells[3].Value;

            tbID.Text = id.ToString();
            //tbFileBoxCode.Text = box_code.ToString();
            tbFileBoxName.Text = box_name.ToString();
            tbFileBoxDescription.Text = box_description.ToString();
            cbTagColor.Text = tag_color.ToString();
            //cbFileBox.Text = file_box.ToString();
        }

        private void btnSaveChangesFileBox_Click(object sender, EventArgs e)
        {
            if (tbFileBoxName.Text == "" || tbFileBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_file_box WHERE box_name = @my_box_name", con);
                cmd2.Parameters.AddWithValue("@my_box_name", tbFileBoxName.Text.ToUpper());
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("File Box / Location name already exists. Please choose another.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();

                }
                else
                {
                    OleDbCommand cmd_update_box = new OleDbCommand(@"UPDATE tbl_file_box
                                                SET box_name = @box_name,
                                                    box_description = @box_description,
                                                    box_tag_color = @box_tag_color
                                                WHERE ID = @id", con);

                    cmd_update_box.Parameters.AddWithValue("@box_name", tbFileBoxName.Text.ToUpper());
                    cmd_update_box.Parameters.AddWithValue("@box_description", tbFileBoxDescription.Text.ToUpper());
                    cmd_update_box.Parameters.AddWithValue("@box_tag_color", cbTagColor.SelectedValue);
                    cmd_update_box.Parameters.AddWithValue("@id", tbID.Text);
                    //con.Open();
                    cmd_update_box.ExecuteNonQuery();
                    con.Close();

                    _fileBoxForm.loadFileBoxes();
                    //DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
                    dashboardForm dashboardform;
                    dashboardform = (dashboardForm)fc.TheForm("dashboardForm");
                    dashboardform.loadDgDocumentsRecords();
                    this.Hide();

                    Form form = Application.OpenForms["foldersForm"];
                    if (form != null)
                    {
                        foldersForm foldersform = (foldersForm)fc.TheForm("foldersForm");
                        foldersform.CbLoadBoxes();
                    }

                    MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
