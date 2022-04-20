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
    public partial class dashboardForm : Form
    {

        OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\NIA-PIMO\\source\\repos\\FilingSystem2\\FilingSystem2\\db_filingsystem.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public dashboardForm()
        {
            InitializeComponent();
        }
        public DataTable MyFiles(string filter_by = null, string filter_value = null)
        {
            string sql = null;
            string text = "";
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
                sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfol.folder_name AS [FOLDER],
                    tfilbox.box_name AS [FILE BOX / LOCATION], usr.last_name & ', '& usr.first_name as [FILED BY], tfil.date_filed as [DATE FILED]
                    
                    FROM (((tbl_file AS tfil 
                        INNER JOIN 
                    tbl_folder AS tfol
                    ON tfil.folder_id = tfol.ID)
                        INNER JOIN
                    tbl_file_box AS tfilbox
                    ON tfilbox.ID = tfol.file_box_id)
                        INNER JOIN
                    tbl_user AS usr
                    ON tfil.filed_by = usr.ID
                    )
                        ";

            }
            else
            {
                sql = @"SELECT tfil.ID AS [ID], tfil.code AS [CODE], tfil.subject AS [SUBJECT], tfil.particulars AS [PARTICULARS], tfol.folder_name AS [FOLDER],
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
                    WHERE "+ filter_value + " LIKE '%"+ filter_by +"%'";
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
            //dgDocumentsRecords.Columns[0].HeaderText = "ID";
            //dgDocumentsRecords.Columns[1].HeaderText = "CODE";
            //dgDocumentsRecords.Columns[2].HeaderText = "SUBJECT";
            //dgDocumentsRecords.Columns[3].HeaderText = "PARTICULARS";
            //dgDocumentsRecords.Columns[4].HeaderText = "FOLDER";
            //dgDocumentsRecords.Columns[5].HeaderText = "DATE FILED";
            //dgDocumentsRecords.Columns[6].HeaderText = "FILED BY";

            dgDocumentsRecords.DataSource = MyFiles();
            dgDocumentsRecords.Refresh();
            dgDocumentsRecords.Update();
        }
        private void dashboardForm_Load(object sender, EventArgs e)
        {

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
            new foldersForm().Show();
        }

        private void btnFileBox_Click(object sender, EventArgs e)
        {
            new fileBoxForm().Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginForm().Show();
        }

        private void btnViewDocument_Click(object sender, EventArgs e)
        {
            new ViewDocument(this).Show();
            //Console.WriteLine(dgDocumentsRecords.CurrentRow.Cells[0].Value);

        }


    }
}
