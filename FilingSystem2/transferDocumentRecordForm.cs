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
            string dateNow = "";
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
                        Random rnd = new Random();
                        string sql_get_files = "SELECT * FROM tbl_file WHERE folder_id = " + cbFolderFrom.SelectedValue.ToString() + " ";
                                   // con.Open();

                                    OleDbCommand cmd_get_files = new OleDbCommand(sql_get_files, con);
                                    OleDbDataReader reader2 = cmd_get_files.ExecuteReader();
                                    
                                    if (reader2.HasRows)
                                    {
                                        while (reader2.Read())
                                        {
                                            dateNow = DateTime.Now.ToString("Mdyy-HHmmssFF");
                                            new_code = reader.GetString(1);
                                            int folder_id = reader.GetInt32(0);
                                            int id = reader2.GetInt32(0);
                                //Console.WriteLine(new_code + DateTime.Now.ToString("Mdyy-HHmmssff-")+rnd.Next(10));

                                OleDbCommand cmd_update_files_folder = new OleDbCommand(@"UPDATE tbl_file
                                                        SET code = @code, folder_id = @folder_id
                                                        WHERE ID = @id", con);

                                            cmd_update_files_folder.Parameters.AddWithValue("@code", new_code + DateTime.Now.ToString("Mdyy-HHmmssff-")+rnd.Next(10));
                                            cmd_update_files_folder.Parameters.AddWithValue("@folder_id", folder_id);
                                            cmd_update_files_folder.Parameters.AddWithValue("@id", id);
                                            //con.Open();
                                            cmd_update_files_folder.ExecuteNonQuery();

                            }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No rows found in tbl_file.");
                                    }

                                 //   reader.Close();
                                   // con.Close();


                    }
                }
                else
                {
                    Console.WriteLine("No rows found in tbl_folder.");
                    //MessageBox.Show("No files to transfer in this folder!", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
                con.Close();

                _dashboardForm.loadDgDocumentsRecords();


                //  MessageBox.Show("Documents / Records transferred successfully!", "Transfer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
