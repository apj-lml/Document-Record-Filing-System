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
    public partial class BulkTransferDocumentRecordForm : Form
    {

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        private readonly dashboardForm _dashboardForm;

        public BulkTransferDocumentRecordForm(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;
            con = myConnectionString.MyConnection();
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

        public string RandomChars()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {

            string new_code = "";

            if (cbFolderFrom.SelectedValue.ToString() == cbFolderTo.SelectedValue.ToString())
            {
                MessageBox.Show("You can not transfer Documents / Records in the same folder!", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string sql = "SELECT * FROM tbl_folder WHERE ID = " + cbFolderTo.SelectedValue.ToString() + "; ";
                con.Open();


                OleDbCommand cmd_get_code = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd_get_code.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string sql_get_files = "SELECT * FROM tbl_file WHERE folder_id = " + cbFolderFrom.SelectedValue.ToString() + " ORDER BY date_filed ASC";
                        OleDbCommand cmd_get_files = new OleDbCommand(sql_get_files, con);
                        OleDbDataReader reader2 = cmd_get_files.ExecuteReader();
                                    
                        if (reader2.HasRows)
                        {
                            DateTime now = DateTime.Now;

                            while (reader2.Read())
                            {
                                MessageBox.Show(RandomChars());

                                new_code = reader.GetString(1);
                                int folder_id = reader.GetInt32(0);
                                int id = reader2.GetInt32(0);

                                OleDbCommand cmd_update_files_folder = new OleDbCommand(@"UPDATE tbl_file
                                            SET code = @code, folder_id = @folder_id, date_filed = @date_filed
                                            WHERE ID = @id", con);

                                cmd_update_files_folder.Parameters.AddWithValue("@code", now.ToString("MMdyy-HHmm")+ "-" + RandomChars());
                                cmd_update_files_folder.Parameters.AddWithValue("@folder_id", folder_id);
                                cmd_update_files_folder.Parameters.AddWithValue("@date_filed", now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                                cmd_update_files_folder.Parameters.AddWithValue("@id", id);
                                cmd_update_files_folder.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found in tbl_file.");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No rows found in tbl_folder.");
                }

                reader.Close();
                con.Close();

                _dashboardForm.loadDgDocumentsRecords();

                this.Hide();
                MessageBox.Show("Documents / Records transferred successfully!", "Transfer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
