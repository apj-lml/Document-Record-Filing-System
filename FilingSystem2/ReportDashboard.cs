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
    public partial class ReportDashboard : Form
    {
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();

        public ReportDashboard()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();

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
        private void ReportDashboard_Load(object sender, EventArgs e)
        {
            CbLoadFolders();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbFolder.Enabled = false;
                cbFolder.Text = "All";
            }
            else
            {
                cbFolder.Enabled = true;
                CbLoadFolders();
            }
        }

        private void btnSaveChangesDocument_Click(object sender, EventArgs e)
        {
            if (cbFolder.Text == "All") {
                new reportViewerForm(cbFolder.Text).ShowDialog();

            }
            else
            {
                new reportViewerForm(cbFolder.SelectedValue.ToString()).ShowDialog();

            }
        }

        private void cbFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
