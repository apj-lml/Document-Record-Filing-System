﻿using System;
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
    public partial class dashboardForm : Form
    {

        //OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MSI\\source\\repos\\Document-Record-Filing-System\\FilingSystem2\\db_filingsystem.accdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public dashboardForm()
        {
            InitializeComponent();
        }
        public DataTable MyFiles(string filter_by = null, string filter_value = null)
        {
            string sql = null;
            if (filter_value == "ID")
            {
                filter_value = "tfil.ID";
            }
            else if (filter_value == "code")
            {
                filter_value = "tfil.code";

            }
            else if (filter_value == "subject")
            {
                filter_value = "tfil.subject";
            }
            else if (filter_value == "particulars")
            {
                filter_value = "tfil.particulars";
            }
            else if (filter_value == "folder_name")
            {
                filter_value = "tfol.folder_name";
            }
            else if (filter_value == "box_name")
            {
                filter_value = "tfilbox.box_name";
            }
            else if (filter_value == "filed_by")
            {
                filter_value = "usr.last_name & ', '& usr.first_name";
            }
            else {
                //filter_value = "usr.last_name & ', '& usr.first_name";

            }

            Console.WriteLine("filter val: "+ filter_value);

            if (filter_by == null)
            {
                sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfil.remarks AS [REMARKS], tfol.folder_name AS [FOLDER],
                    tfilbox.box_name AS [FILE BOX / LOCATION], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED]
                    
                    FROM (((tbl_file AS tfil 
                        LEFT JOIN 
                    tbl_folder AS tfol
                    ON tfil.folder_id = tfol.ID)
                        LEFT JOIN
                    tbl_file_box AS tfilbox
                    ON tfilbox.ID = tfol.file_box_id)
                        LEFT JOIN
                    tbl_user AS usr
                    ON tfil.filed_by = usr.ID
                    )
                        ";

            }
            else
            {
                sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfil.remarks AS [REMARKS], tfol.folder_name AS [FOLDER],
                    tfilbox.box_name AS [FILE BOX / LOCATION], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED]
                    
                    FROM (((tbl_file AS tfil 
                        INNER JOIN 
                    tbl_folder AS tfol
                    ON tfil.folder_id = tfol.ID)
                        INNER JOIN
                    tbl_file_box AS tfilbox
                    ON tfilbox.ID = tfol.file_box_id
                    )
                        INNER JOIN
                    tbl_user AS usr
                    ON tfil.filed_by = usr.ID
                    )
                    WHERE " + filter_value + " LIKE '%"+ filter_by +"%'";
                //sql = $"SELECT * FROM tbl_file WHERE {test} ID LIKE '%{ filter_by }%'";

            }
            con.Open();
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            con.Close();
            return dt;
        }

        public void loadDgDocumentsRecords() {
            dgDocumentsRecords.DataSource = MyFiles();
            dgDocumentsRecords.Refresh();
            dgDocumentsRecords.Update();
        }
        private void dashboardForm_Load(object sender, EventArgs e)
        {
            var role = loginForm.LoginInfo.Role;
            var last_name = loginForm.LoginInfo.LastName;
            var first_name = loginForm.LoginInfo.FirstName;

            ll_user.Text = first_name.ToString();

            //MessageBox.Show("Welcome,"+first_name, "Hi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (role == "user")
            {
                btnUsers.Visible = false;
            }
            else {
                btnUsers.Visible = true;

            }
            //this.tbl_fileTableAdapter1.Fill(this.db_filingsystemDataSet1.tbl_file);
            loadDgDocumentsRecords();

            cbFilter.DisplayMember = "Text";
            cbFilter.ValueMember = "Value";

            List<Object> items = new List<Object>();
            items.Add (new { Text = "ID", Value = "ID" });
            items.Add(new { Text = "Code", Value = "code" });
            items.Add(new { Text = "Subject", Value = "subject" });
            items.Add(new { Text = "Particulars", Value = "particulars" });
            items.Add(new { Text = "Folder", Value = "folder" });
            items.Add(new { Text = "File Box", Value = "box_id" });
            items.Add(new { Text = "Filed By", Value = "filed_by" });
            items.Add(new { Text = "Date Filed", Value = "date_filed" });


            cbFilter.DataSource = items;


        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            var emp_id = loginForm.LoginInfo.EmpID;
            var last_name  = loginForm.LoginInfo.LastName;
            var first_name = loginForm.LoginInfo.FirstName;
            var section = loginForm.LoginInfo.Section;
            var unit = loginForm.LoginInfo.Unit;
            var role = loginForm.LoginInfo.Role;


            new addDocumentRecordForm(this).Show();

            //MessageBox.Show("Hi, "+last_name, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgDocumentsRecords.DataSource = MyFiles(tbSearch.Text, cbFilter.SelectedValue.ToString());
            Console.WriteLine(cbFilter.SelectedValue.ToString());
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {
            new foldersForm().ShowDialog();
        }

        private void btnFileBox_Click(object sender, EventArgs e)
        {
            new fileBoxForm().ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginForm().Show();
        }

        private void btnViewDocument_Click(object sender, EventArgs e)
        {
            new ViewDocument(this).ShowDialog();
            //Console.WriteLine(dgDocumentsRecords.CurrentRow.Cells[0].Value);

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new reportViewerForm().ShowDialog();  
        }

        private void btnTransferDocuments_Click(object sender, EventArgs e)
        {
            new transferDocumentRecordForm(this).ShowDialog(); 
        }

        private void tsViewDocument_Click(object sender, EventArgs e)
        {
            new EditDocument(this).ShowDialog();
        }

        private void tsDeleteDocument_Click(object sender, EventArgs e)
        {
            var id = dgDocumentsRecords.CurrentRow.Cells[0].Value;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Document / Record?", "Delete Document / Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            { 

                OleDbCommand cmd_delete_document = new OleDbCommand(@"DELETE FROM tbl_file
                                        WHERE ID = @id", con);

                cmd_delete_document.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd_delete_document.ExecuteNonQuery();
                con.Close();

                loadDgDocumentsRecords();

                MessageBox.Show("Document / Record deleted succesfully!", "Document / Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                
            }
        }

        private void ll_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
