using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace FilingSystem2
{
    public partial class addDocumentRecordForm : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();


        private readonly dashboardForm _dashboardForm;

        public addDocumentRecordForm(dashboardForm dashboardform)
        {
            _dashboardForm = dashboardform;
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

        private void addDocumentRecordForm_Load(object sender, EventArgs e)
        {
            CbLoadFolders();
            dtpDateReceived.Checked = false;
            dtpDueDate.Checked = false;
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            var user_id = loginForm.LoginInfo.UserID;
            var emp_id = loginForm.LoginInfo.EmpID;
            var last_name = loginForm.LoginInfo.LastName;
            var first_name = loginForm.LoginInfo.FirstName;
            var section = loginForm.LoginInfo.Section;
            var unit = loginForm.LoginInfo.Unit;

            if (tbCode.Text == "" || tbSubject.Text == "" || tbParticulars.Text == "" || cbFolder.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tbl_file(code, subject, particulars, remarks, folder_id, date_received, due_date, filed_by) values(@code, @subject, @particulars, @remarks, @folder_id, @date_received, @due_date, @filed_by)";
                cmd.Parameters.AddWithValue("@code", tbCode.Text.ToUpper());
                cmd.Parameters.AddWithValue("@subject", tbSubject.Text.ToUpper());
                cmd.Parameters.AddWithValue("@particulars", tbParticulars.Text.ToUpper());
                cmd.Parameters.AddWithValue("@remarks", tbRemarks.Text.ToUpper());
                cmd.Parameters.AddWithValue("@folder_id", int.Parse(cbFolder.SelectedValue.ToString()));

                if (dtpDateReceived.Checked)
                {
                    cmd.Parameters.AddWithValue("@date_received", dtpDateReceived.Value.ToString("MM/dd/yyyy"));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@date_received", DBNull.Value);
                }

                if (dtpDueDate.Checked)
                {
                    cmd.Parameters.AddWithValue("@due_date", dtpDueDate.Value.ToString("MM/dd/yyyy"));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@due_date", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@filed_by", user_id);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                _dashboardForm.loadDgDocumentsRecords();
                tbCode.Text = "";
                tbSubject.Text = string.Empty;
                tbParticulars.Text = string.Empty;
                tbRemarks.Text = string.Empty;
                cbFolder.SelectedIndex = 0;

                GenerateCode();
                dtpDateReceived.Checked = false;

                MessageBox.Show("Document / Record Added Successfully", "Success!");



            }
        }
        private void OldGenerateCode(){
            if (cbFolder.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM tbl_folder WHERE ID = " + cbFolder.SelectedValue.ToString() + " ORDER BY folder_name ASC";
                con.Open();

                cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    OleDbCommand cmd_count_files = new OleDbCommand();
                    cmd_count_files.CommandText = "SELECT COUNT(*) FROM tbl_file WHERE folder_id = " + cbFolder.SelectedValue.ToString() + "";
                    cmd_count_files.Connection = con;
                    Int32 count = (Int32)cmd_count_files.ExecuteScalar();

                    while (reader.Read())
                    {
                        count++;
                        Random rnd = new Random();
                        var dateNow = DateTime.Now.AddSeconds(0.1);
                        Console.WriteLine(dateNow);
                        tbCode.Text = dateNow.ToString("MMdyy-HHmm") + "-" + reader.GetString(1);
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
                }
            }

        public string RandomChars()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GenerateCode()
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
            }
        }
        private void cbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {

            GenerateCode();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new foldersForm().Show();
        }

        private void cbFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtpDateReceived_ValueChanged(object sender, EventArgs e)
        {
            //dtpDateReceived.Format = DateTimePickerFormat.Short;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdjustWidthComboBox_DropDown(object sender, EventArgs e)
        {
            var senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }
    }
}
