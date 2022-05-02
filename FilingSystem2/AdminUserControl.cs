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
    public partial class AdminUserControl : Form
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();
        public DataTable MyFiles(string filter_by = null, string filter_value = null)
        {
            string sql = null;

            if (filter_by == null)
            {
                sql = @"SELECT * FROM tbl_user";

            }

            con.Open();
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            con.Close();
            return dt;
        }

        public void loadListOfUsers()
        {
            dgListOfUsers.DataSource = MyFiles();
            dgListOfUsers.Refresh();
            dgListOfUsers.Update();
        }
        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            loadListOfUsers();
        }

        private void editSelectedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFileDocument.Visible = false;
            btnSaveChanges.Visible = true;

            tbId.Text = dgListOfUsers.CurrentRow.Cells[0].Value.ToString();
            tbEmpId.Text = dgListOfUsers.CurrentRow.Cells[1].Value.ToString();
            tbPassword.Text = dgListOfUsers.CurrentRow.Cells[2].Value.ToString();
            tbLastName.Text = dgListOfUsers.CurrentRow.Cells[3].Value.ToString();
            tbFirstName.Text = dgListOfUsers.CurrentRow.Cells[4].Value.ToString();
            tbMiddleName.Text = dgListOfUsers.CurrentRow.Cells[5].Value.ToString();
            tbNameExtn.Text = dgListOfUsers.CurrentRow.Cells[6].Value.ToString();
            cbSection.SelectedText = dgListOfUsers.CurrentRow.Cells[7].Value.ToString();
            cbUnit.SelectedText = dgListOfUsers.CurrentRow.Cells[8].Value.ToString();
            tbStatus.Text = dgListOfUsers.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand(@"UPDATE tbl_user
                                                    SET emp_id = @emp_id,
                                                        last_name = @last_name,
                                                        first_name = @first_name,
                                                        middle_name = @middle_name,
                                                        name_extension = @name_extension,
                                                        section = @section,
                                                        unit = @unit
                                                    WHERE ID = @id", con);

            cmd.Parameters.AddWithValue("@emp_id", tbEmpId.Text);
            cmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
            cmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@middle_name", tbMiddleName.Text);
            cmd.Parameters.AddWithValue("@name_extension", tbNameExtn.Text);
            cmd.Parameters.AddWithValue("@section", cbSection.SelectedText);
            cmd.Parameters.AddWithValue("@unit", cbUnit.SelectedText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // dashboardForm dashboardForm = new dashboardForm();
        }
    }
}
