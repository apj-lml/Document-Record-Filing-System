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
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\NIA-PIMO\\source\\repos\\FilingSystem2\\FilingSystem2\\db_filingsystem.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        public foldersForm()
        {
            InitializeComponent();
        }

        private void foldersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_filingsystemDataSet_test_1.tbl_file_box' table. You can move, or remove it, as needed.
            this.tbl_file_boxTableAdapter.Fill(this.db_filingsystemDataSet_test_1.tbl_file_box);

            // TODO: This line of code loads data into the 'db_filingsystemDataSet_test_1.tbl_file_box' table. You can move, or remove it, as needed.
            this.tbl_file_boxTableAdapter.Fill(this.db_filingsystemDataSet_test_1.tbl_file_box);

        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFolderCode.Text == "" || tbFolderName.Text == "" || tbFolderDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //con.Open();
                //string folder = "SELECT * FROM tbl_folder WHERE folder_code = '" + tbFolderCode.Text + "'";
                //cmd = new OleDbCommand(folder, con);
                //OleDbDataReader reader = cmd.ExecuteReader();
                //con.Close();

                //if (reader.Read() == true)
                //{
                //    MessageBox.Show("You have already used this code prefix. Please Try Again.", "Duplicate Code Prefix!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
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

                    //DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
                    //dgv.Refresh();

                    MessageBox.Show("Record Inserted Successfully", "Success!");
                //}


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
