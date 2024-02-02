using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FilingSystem2
{
    public partial class dashboardForm : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //private const int totalRecords = 43;
        //private const int pageSize = 10;

        public dashboardForm()
        {
            Thread t = new Thread(new ThreadStart(StartSplash));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            con = myConnectionString.MyConnection();
        }

        public void StartSplash()
        {
            Application.Run(new SplashScreen());
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
            else if (filter_value == "remarks")
            {
                filter_value = "tfil.remarks";
            }
            else if (filter_value == "folder_name")
            {
                filter_value = "tfol.folder_name";
            }
            else if (filter_value == "folder_tag_color")
            {
                filter_value = "foltagclr.tag_color";
            }
            else if (filter_value == "box_name")
            {
                filter_value = "tfilbox.box_name";
            }
            else if (filter_value == "box_tag_color")
            {
                filter_value = "boxtagclr.tag_color";
            }
            else if (filter_value == "filed_by")
            {
                filter_value = "usr.last_name & ', '& usr.first_name";
            }
            else if (filter_value == "date_filed")
            {
                filter_value = "tfil.date_filed";
            }
            else if (filter_value == "date_received")
            {
                filter_value = "tfil.date_received";
            }
            else {
                //filter_value = "usr.last_name & ', '& usr.first_name";

            }


            if (filter_by == null || filter_by == "")
            {
                sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfil.remarks AS [REMARKS],
                    tfol.folder_name AS [FOLDER],
                    foltagclr.tag_color AS [FOLDER TAG COLOR],
                    tfilbox.box_name AS [FILE BOX / LOCATION],
                    boxtagclr.tag_color AS [FILE BOX / LOCATION TAG COLOR],
                    usr.last_name & ', '& usr.first_name as [FILED BY],
                    tfil.date_filed as [DATE FILED],
                    tfol.folder_description AS [FOLDER DESCRIPTION],
                    tfilbox.box_description AS [FILE BOX / LOCATION DESCRIPTION],
                    tfil.date_received as [DATE RECEIVED],
                    tfil.due_date as [DUE DATE]
                    
                                FROM (((((tbl_file AS tfil 
                                    LEFT JOIN 
                                tbl_folder AS tfol
                                ON tfil.folder_id = tfol.ID
                                )
                                    LEFT JOIN
                                tbl_file_box AS tfilbox
                                ON tfilbox.ID = tfol.file_box_id
                                )
                                    LEFT JOIN
                                tbl_user AS usr
                                ON tfil.filed_by = usr.ID
                                )
                                    LEFT JOIN
                                tbl_color AS foltagclr
                                ON tfol.folder_tag_color = foltagclr.ID
                                )
                                    LEFT JOIN
                                tbl_color AS boxtagclr
                                ON tfilbox.box_tag_color = boxtagclr.ID
                                )

                          ORDER BY tfil.ID DESC
                        ";

            }
            else
            {
                if (filter_value != "all")
                {
                    sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfil.remarks AS [REMARKS], tfol.folder_name AS [FOLDER], foltagclr.tag_color AS [FOLDER TAG COLOR],
                    tfilbox.box_name AS [FILE BOX / LOCATION], boxtagclr.tag_color AS [FILE BOX / LOCATION TAG COLOR], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED],
                    tfol.folder_description AS [FOLDER DESCRIPTION],
                    tfilbox.box_description AS [FILE BOX / LOCATION DESCRIPTION],
                    tfil.date_received as [DATE RECEIVED],
                    tfil.due_date as [DUE DATE]
                    
                    FROM (((((tbl_file AS tfil 
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
                        LEFT JOIN
                    tbl_color AS foltagclr
                    ON tfol.folder_tag_color = foltagclr.ID
                    )
                        LEFT JOIN
                    tbl_color AS boxtagclr
                    ON tfilbox.box_tag_color = boxtagclr.ID
                    )
                    WHERE " + filter_value + " LIKE '%" + filter_by + "%'";
                }
                else
                {
                    sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfil.remarks AS [REMARKS], tfol.folder_name AS [FOLDER], foltagclr.tag_color AS [FOLDER TAG COLOR],
                    tfilbox.box_name AS [FILE BOX / LOCATION], boxtagclr.tag_color AS [FILE BOX / LOCATION TAG COLOR], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED],
                    tfol.folder_description AS [FOLDER DESCRIPTION],
                    tfilbox.box_description AS [FILE BOX / LOCATION DESCRIPTION],
                    tfil.date_received as [DATE RECEIVED],
                    tfil.due_date as [DUE DATE]
                    
                    FROM (((((tbl_file AS tfil 
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
                        LEFT JOIN
                    tbl_color AS foltagclr
                    ON tfol.folder_tag_color = foltagclr.ID
                    )
                        LEFT JOIN
                    tbl_color AS boxtagclr
                    ON tfilbox.box_tag_color = boxtagclr.ID
                    )
                    WHERE tfil.ID LIKE '%" + filter_by + "%' OR tfil.code LIKE '%" + filter_by + "%' OR tfil.subject LIKE '%" + filter_by + "%'  OR tfil.particulars LIKE '%" + filter_by + "%' OR tfil.remarks LIKE '%" + filter_by + "%' OR tfol.folder_name LIKE '%" + filter_by + "%' OR foltagclr.tag_color LIKE '%" + filter_by + "%' OR tfilbox.box_name LIKE '%" + filter_by + "%' OR boxtagclr.tag_color LIKE '%" + filter_by + "%' OR usr.last_name & ', '& usr.first_name LIKE '%" + filter_by + "%' OR tfil.date_filed LIKE '%" + filter_by + "%' ";
                }

                //sql = $"SELECT * FROM tbl_file WHERE {test} ID LIKE '%{ filter_by }%'";

            }
            con.Open();
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            //DataTable dt = OleDbCommand.ExecuteDt("select * from test order by col");
            


            con.Close();
            return dt;
        }

        public void loadDgDocumentsRecords() {
            dgDocumentsRecords.PageSize = 40;
            dgDocumentsRecords.SetPagedDataSource(MyFiles(), bindingNavigator1);

            if (dgDocumentsRecords.Columns.Contains("FOLDER DESCRIPTION") == true)
            {
                dgDocumentsRecords.Columns["FOLDER DESCRIPTION"].Visible = false;
                dgDocumentsRecords.Columns["FILE BOX / LOCATION DESCRIPTION"].Visible = false;
                dgDocumentsRecords.Columns["FILE BOX / LOCATION TAG COLOR"].Visible = false;
                dgDocumentsRecords.Columns["DATE RECEIVED"].Visible = false;
                dgDocumentsRecords.Columns["DUE DATE"].Visible = false;
                dgDocumentsRecords.Columns["FILED BY"].Visible = false;
                dgDocumentsRecords.Columns["REMARKS"].Visible = false;

                DataGridViewColumn column_id = dgDocumentsRecords.Columns[0];
                DataGridViewColumn column_code = dgDocumentsRecords.Columns[1];
                DataGridViewColumn column_subject = dgDocumentsRecords.Columns[2];
                DataGridViewColumn column_particulars = dgDocumentsRecords.Columns[3];

                column_id.Width = 30;
                column_code.Width = 115;
                column_subject.Width = 275;
                column_particulars.Width = 200;

                tsDeleteDocument.Enabled = true;
                tsViewDocument.Enabled = true;

            }
            else
            {
                tsDeleteDocument.Enabled = false;
                tsViewDocument.Enabled = false;
            }
           
            dgDocumentsRecords.Refresh();
            dgDocumentsRecords.Update();

        }

        private void SetFontAndColors()
        {
            this.dgDocumentsRecords.DefaultCellStyle.Font = new Font("Cambria",  9);
            this.dgDocumentsRecords.DefaultCellStyle.ForeColor = Color.Black;
            this.dgDocumentsRecords.DefaultCellStyle.BackColor = Color.White;
            this.dgDocumentsRecords.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgDocumentsRecords.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#0F1D42");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F5:
                    loadDgDocumentsRecords();

                    bHandled = true;
                    break;
                default: return base.ProcessCmdKey(ref msg, keyData);
            }
            return bHandled;
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            //this.dgDocumentsRecords.DefaultCellStyle.Font = new Font("Cambria", 9);
            SetFontAndColors();

            var role = loginForm.LoginInfo.Role;
            var last_name = loginForm.LoginInfo.LastName;
            var first_name = loginForm.LoginInfo.FirstName;

            ll_user.Text = first_name.ToString();
            loadDgDocumentsRecords();


            if (role == "User")
            {
                btnUsers.Visible = false;
            }
            else {
                btnUsers.Visible = true;

            }
            //this.tbl_fileTableAdapter1.Fill(this.db_filingsystemDataSet1.tbl_file);

            cbFilter.DisplayMember = "Text";
            cbFilter.ValueMember = "Value";

            List<Object> items = new List<Object>();
            items.Add(new { Text = "All", Value = "all" });
            items.Add(new { Text = "ID", Value = "ID" });
            items.Add(new { Text = "Code", Value = "code" });
            items.Add(new { Text = "Subject", Value = "subject" });
            items.Add(new { Text = "Particulars", Value = "particulars" });
            items.Add(new { Text = "Remarks", Value = "remarks" });
            items.Add(new { Text = "Folder", Value = "folder_name" });
            items.Add(new { Text = "Folder Tag Color", Value = "folder_tag_color" });
            items.Add(new { Text = "File Box / Location", Value = "box_name" });
            items.Add(new { Text = "File Box / Location Tag Color", Value = "box_tag_color" });
            items.Add(new { Text = "Filed By", Value = "filed_by" });
            //items.Add(new { Text = "Date Filed", Value = "date_filed" });
            //items.Add(new { Text = "Date Received", Value = "date_received" });


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

            new addDocumentRecordForm(this).ShowDialog();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbSearch.Text == "")
            {
                dgDocumentsRecords.SetPagedDataSource(MyFiles(), bindingNavigator1);
            }
            else
            {
                dgDocumentsRecords.DataSource = MyFiles(tbSearch.Text, cbFilter.SelectedValue.ToString());
            }
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
            if(dgDocumentsRecords.SelectedRows.Count > 0)
            {
                new ViewDocument(this).ShowDialog();
            }

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new ReportDashboard().ShowDialog();  
        }

        private void btnTransferDocuments_Click(object sender, EventArgs e)
        {
            new BulkTransferDocumentRecordForm(this).ShowDialog(); 
        }

        private void tsViewDocument_Click(object sender, EventArgs e)
        {
            new EditDocument(this).ShowDialog();
        }

        private void tsDeleteDocument_Click(object sender, EventArgs e)
        {
            if (dgDocumentsRecords.Rows.Count > 0) {
                var id = dgDocumentsRecords.CurrentRow.Cells[0].Value;
                var created_by = dgDocumentsRecords.CurrentRow.Cells[9].Value;
                var last_name = loginForm.LoginInfo.LastName.ToString();
                var first_name = loginForm.LoginInfo.FirstName.ToString();
                var full_name = last_name +", "+first_name;

                if (created_by.ToString() == full_name) {

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
                else
                {
                    MessageBox.Show("You can't delete this Document / Record because it is not created by you.", "Document / Record Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("No Document / File is selected!", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void ll_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserProfile(this).ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new AdminUserControl(this).ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDgDocumentsRecords();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new addDocumentRecordForm(this).ShowDialog();
        }

        private void dgDocumentsRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
