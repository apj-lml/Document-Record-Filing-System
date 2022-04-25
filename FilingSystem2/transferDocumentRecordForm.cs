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
    public partial class transferDocumentRecordForm : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        private readonly dashboardForm _dashboardForm;

        public transferDocumentRecordForm(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;
        }

        public void CbLoadFoldersFrom()
        {
            string query = "SELECT * FROM tbl_folder ORDER BY folder_name ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Folders");

            cbFolderFrom.DisplayMember = "folder_name";
            cbFolderFrom.ValueMember = "ID";
            cbFolderFrom.DataSource = ds.Tables["Folders"];

        }
        public void CbLoadFoldersTo()
        {
            string query = "SELECT * FROM tbl_folder ORDER BY folder_name ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Folders");

            cbFolderTo.DisplayMember = "folder_name";
            cbFolderTo.ValueMember = "ID";
            cbFolderTo.DataSource = ds.Tables["Folders"];


        }
        private void transferDocumentRecordForm_Load(object sender, EventArgs e)
        {
            CbLoadFoldersFrom();
            CbLoadFoldersTo();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new foldersForm().ShowDialog(); 
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if(cbFolderFrom.SelectedValue.ToString() == cbFolderTo.SelectedValue.ToString())
            {
                MessageBox.Show("You can not transfer Documents / Records in the same folder!", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd_update_files_folder = new OleDbCommand(@"UPDATE tbl_file
                                            SET folder_id = @folder_id
                                            WHERE folder_id = @folder_id_where", con);

                cmd_update_files_folder.Parameters.AddWithValue("@folder_id", cbFolderTo.SelectedValue);
                cmd_update_files_folder.Parameters.AddWithValue("@folder_id_where", cbFolderFrom.SelectedValue);
                con.Open();
                cmd_update_files_folder.ExecuteNonQuery();
                con.Close();


                _dashboardForm.loadDgDocumentsRecords();


                MessageBox.Show("Documents / Records transferred successfully!", "Transfer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
