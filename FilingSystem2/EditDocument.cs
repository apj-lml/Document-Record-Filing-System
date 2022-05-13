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

        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();

        private readonly dashboardForm _dashboardForm;
        public EditDocument(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;
            con = myConnectionString.MyConnection();
        }

        public void CbLoadFolders()
        {
            int box_id = int.Parse(cbFileBox.SelectedValue.ToString());
            string query = "SELECT * FROM tbl_folder WHERE file_box_id = "+box_id+ " ORDER BY folder_name ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();

            da.Fill(ds, "Folders");

            cbFolder.DisplayMember = "folder_name";
            cbFolder.ValueMember = "ID";
            cbFolder.DataSource = ds.Tables["Folders"];

        }
        public void CbLoadBoxes()
        {
            string query = "SELECT * FROM tbl_file_box ORDER BY box_name ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Box");

            cbFileBox.DisplayMember = "box_name";
            cbFileBox.ValueMember = "ID";
            cbFileBox.DataSource = ds.Tables["Box"];

        }
        private void ViewDocument_Load(object sender, EventArgs e)
        {
            CbLoadBoxes();
            CbLoadFolders();

            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var code = dgv.CurrentRow.Cells[1].Value;
            var subject = dgv.CurrentRow.Cells[2].Value;
            var particulars = dgv.CurrentRow.Cells[3].Value;
            var remarks = dgv.CurrentRow.Cells[4].Value;
            var folder = dgv.CurrentRow.Cells[5].Value;
            var folder_tag_color = dgv.CurrentRow.Cells[6].Value;
            var file_box = dgv.CurrentRow.Cells[7].Value;
            var file_box_tag_color = dgv.CurrentRow.Cells[8].Value;
            var filed_by = dgv.CurrentRow.Cells[9].Value;
            var date_filed = dgv.CurrentRow.Cells[10].Value;
            var folder_description = dgv.CurrentRow.Cells[11].Value;
            var file_box_description = dgv.CurrentRow.Cells[12].Value;
            var date_received = dgv.CurrentRow.Cells[13].Value;


            tbID.Text = id.ToString();
            tbCode.Text = code.ToString();
            cbFolder.Text = folder.ToString();

            cbFileBox.Text = file_box.ToString();
            tbFiledBy.Text = filed_by.ToString();

            tbSubject.Text = subject.ToString();
            tbParticulars.Text = particulars.ToString();
            tbRemarks.Text = remarks.ToString();

            tbFolderTagColor.Text = folder_tag_color.ToString();
            tbFileBoxTagColor.Text = file_box_tag_color.ToString();

            tbDateFiled.Text = date_filed.ToString();

            lFolderDescription.Text = folder_description.ToString();
            lFileBoxDescription.Text = file_box_description.ToString();

            lFolderDescription.MaximumSize = new Size(296, 39);
            lFolderDescription.AutoSize = true;

            lFileBoxDescription.MaximumSize = new Size(296, 39);
            lFileBoxDescription.AutoSize = true;

            if ((string)date_received != "")
            {
                dtpDateReceived.Value = Convert.ToDateTime(date_received.ToString());
                //dtpDateReceived.Checked = true;
            }
            else
            {
                dtpDateReceived.Format = DateTimePickerFormat.Custom;
                dtpDateReceived.CustomFormat = " ";

                dtpDateReceived.Checked = false;
            }

        }
        public string RandomChars()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void CreateCode()
        {
            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));

            var code = dgv.CurrentRow.Cells[1].Value;
            tbCode.Text = code.ToString();
        }

        private void GenerateCode()
        {
            //if (cbFolder.SelectedIndex != -1)
            //{
                string sql = "SELECT * FROM tbl_folder WHERE ID = " + cbFolder.SelectedValue.ToString() + " ORDER BY folder_name ASC";
                con.Open();

                cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Random rnd = new Random();
                        var dateNow = DateTime.Now.AddSeconds(0.1);
                        Console.WriteLine(dateNow);
                        tbCode.Text = dateNow.ToString("MMdyy-HHmm") + "-" + RandomChars();
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                //Console.WriteLine(reader);
                //tbCode.Text = reader.GetString(1);
                reader.Close();
                con.Close();
            //}
        }

        private void OldCreateCode()
        {
            if (cbFolder.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM tbl_folder WHERE ID = " + cbFolder.SelectedValue.ToString() + " ORDER BY folder_name ASC";
                con.Open();

                cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Random rnd = new Random();
                        var dateNow = DateTime.Now.ToString("MMdyy-HHmmssff-") + rnd.Next(10);
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



        private void btnSaveChangesDocument_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand(@"UPDATE tbl_file
                                                    SET code = @code,
                                                        subject = @subject,
                                                        particulars = @particulars,
                                                        remarks = @remarks,
                                                        folder_id = @folder_id,
                                                        date_received = @date_received
                                                    WHERE ID = @id", con);

            cmd.Parameters.AddWithValue("@code", tbCode.Text);
            cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
            cmd.Parameters.AddWithValue("@particulars", tbParticulars.Text);
            cmd.Parameters.AddWithValue("@remarks", tbRemarks.Text);
            cmd.Parameters.AddWithValue("@folder_id", cbFolder.SelectedValue);

            if (dtpDateReceived.Checked)
            {
                cmd.Parameters.AddWithValue("@date_received", dtpDateReceived.Value.ToString("MM/dd/yyyy"));

            }
            else
            {
                cmd.Parameters.AddWithValue("@date_received", "");
            }

            cmd.Parameters.AddWithValue("@id", tbID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // dashboardForm dashboardForm = new dashboardForm();

            _dashboardForm.loadDgDocumentsRecords();
            //DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
            this.Hide();

        }


        private void cbFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbLoadFolders();
            lFolderDescription.Text = "";
            lFileBoxDescription.Text = "";

        }

        private void cbFolder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lFolderDescription.Text = "";
            lFileBoxDescription.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new fileBoxForm().ShowDialog();
        }

        private void dtpDateReceived_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateReceived.Checked)
            {
                dtpDateReceived.Format = DateTimePickerFormat.Short;

            }
            else
            {
                dtpDateReceived.Format = DateTimePickerFormat.Custom;
                dtpDateReceived.CustomFormat = " ";

                dtpDateReceived.Checked = false;
            }
        }

        private void cbFolder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GenerateCode();
            tbDateFiled.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

        }
    }
}
