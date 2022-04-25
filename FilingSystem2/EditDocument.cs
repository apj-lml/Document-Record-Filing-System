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
    public partial class EditDocument : Form
    {
        //OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();

        private readonly dashboardForm _dashboardForm;
        public EditDocument(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;
        }

        public void CbLoadFolders()
        {
            string query = "SELECT * FROM tbl_folder ORDER BY folder_name ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Folders");

            cbFolder.DisplayMember = "folder_name";
            cbFolder.ValueMember = "ID";
            cbFolder.DataSource = ds.Tables["Folders"];


        }

        private void ViewDocument_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'db_filingsystemDataSet_test_1.tbl_folder' table. You can move, or remove it, as needed.
            //this.tbl_folderTableAdapter.Fill(this.db_filingsystemDataSet_test_1.tbl_folder);

            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var code = dgv.CurrentRow.Cells[1].Value;
            var subject = dgv.CurrentRow.Cells[2].Value;
            var particulars = dgv.CurrentRow.Cells[3].Value;
            var folder = dgv.CurrentRow.Cells[4].Value;
            var file_box = dgv.CurrentRow.Cells[5].Value;
            var filed_by = dgv.CurrentRow.Cells[6].Value;

            tbID.Text = id.ToString();
            tbCode.Text = code.ToString();

            CbLoadFolders();

            //cbFolder.SelectedText = folder.ToString();
            cbFolder.SelectedIndex = cbFolder.FindStringExact(folder.ToString());


            tbSubject.Text = subject.ToString();
            tbParticulars.Text = particulars.ToString();
            //tbSubject.Text = subject;

        }



        private void cbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFolder.SelectedIndex != -1)
            {
                Console.WriteLine("SELECTED ID: "+cbFolder.SelectedValue.ToString());
                string sql = "SELECT * FROM tbl_folder WHERE ID = " + cbFolder.SelectedValue.ToString() + " ORDER BY folder_name ASC" ;
                con.Open();

                cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var dateNow = DateTime.Now.ToString("Mdyy-HHmmss");
                        tbCode.Text = reader.GetString(1) + dateNow;
         

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                reader.Close();
                con.Close();
            }
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new foldersForm().Show();
        }

        private void cbFolder_Click(object sender, EventArgs e)
        {
            CbLoadFolders();
            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
            var folder = dgv.CurrentRow.Cells[4].Value;
            cbFolder.SelectedIndex = cbFolder.FindStringExact(folder.ToString());


        }

        private void btnSaveChangesDocument_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd = new OleDbCommand(@"UPDATE tbl_file
                                                    SET code = @code,
                                                        subject = @subject,
                                                        particulars = @particulars,
                                                        folder_id = @folder_id
                                                    WHERE ID = @id", con);

            cmd.Parameters.AddWithValue("@code", tbCode.Text);
            cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
            cmd.Parameters.AddWithValue("@particulars", tbParticulars.Text);
            cmd.Parameters.AddWithValue("@folder_id", cbFolder.SelectedValue);
            cmd.Parameters.AddWithValue("@id", tbID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dashboardForm dashboardForm = new dashboardForm();

            _dashboardForm.loadDgDocumentsRecords();
            //DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));


        }
    }
}
