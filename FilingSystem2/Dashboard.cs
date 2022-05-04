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
    public partial class dashboardForm : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public dashboardForm()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();
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
            else {
                //filter_value = "usr.last_name & ', '& usr.first_name";

            }

            Console.WriteLine("filter val: "+ filter_value);

            if (filter_by == null)
            {
                sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfil.remarks AS [REMARKS],
                    tfol.folder_name AS [FOLDER],
                    foltagclr.tag_color AS [FOLDER TAG COLOR],
                    tfilbox.box_name AS [FILE BOX / LOCATION],
                    boxtagclr.tag_color AS [FILE BOX / LOCATION TAG COLOR],
                    usr.last_name & ', '& usr.first_name as [FILED BY],
                    tfil.date_filed as [DATE FILED]
                    
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
                    tfilbox.box_name AS [FILE BOX / LOCATION], boxtagclr.tag_color AS [FILE BOX / LOCATION TAG COLOR], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED]
                    
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
                    tfilbox.box_name AS [FILE BOX / LOCATION], boxtagclr.tag_color AS [FILE BOX / LOCATION TAG COLOR], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED]
                    
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

            if (role == "User")
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
            items.Add(new { Text = "All", Value = "all" });
            items.Add(new { Text = "ID", Value = "ID" });
            items.Add(new { Text = "Code", Value = "code" });
            items.Add(new { Text = "Subject", Value = "subject" });
            items.Add(new { Text = "Particulars", Value = "particulars" });
            items.Add(new { Text = "Remarks", Value = "remarks" });
            items.Add(new { Text = "Folder", Value = "folder" });
            items.Add(new { Text = "Folder Tag Color", Value = "folder_tag_color" });
            items.Add(new { Text = "File Box / Location", Value = "box_id" });
            items.Add(new { Text = "File Box / Location Tag Color", Value = "box_tag_color" });
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
            new BulkTransferDocumentRecordForm(this).ShowDialog(); 
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
    }
}
