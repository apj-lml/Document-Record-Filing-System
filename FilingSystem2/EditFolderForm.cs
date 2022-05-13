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
    public partial class EditFolderForm : Form
    {
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();

        private readonly foldersForm _foldersForm;
        public EditFolderForm(foldersForm foldersform)
        {
            InitializeComponent();
            _foldersForm = foldersform;
            con = myConnectionString.MyConnection();

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

        private void clearFields()
        {

            tbFolderCode.Text = "";
            tbFolderName.Text = "";
            cbFileBox.SelectedIndex = 0;
            cbTagColor.SelectedIndex = 0;
            tbFolderDescription.Text = "";
        }


        private void EditFolderForm_Load(object sender, EventArgs e)
        {
            CbLoadBoxes();
            CbloadColors();
            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("foldersForm"), "dgFolder"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var folder_code = dgv.CurrentRow.Cells[1].Value;
            var folder_name = dgv.CurrentRow.Cells[2].Value;
            var folder_description = dgv.CurrentRow.Cells[3].Value;
            var file_tag_color = dgv.CurrentRow.Cells[4].Value;
            var file_box = dgv.CurrentRow.Cells[5].Value;
            var created_by = dgv.CurrentRow.Cells[6].Value;

            tbID.Text = id.ToString();
            tbFolderCode.Text = folder_code.ToString();
            tbFolderName.Text = folder_name.ToString();
            tbFolderDescription.Text = folder_description.ToString();
            cbFileBox.Text = file_box.ToString();
            cbTagColor.Text = file_tag_color.ToString();

        }

        public void CbloadColors()
        {
            string query = "SELECT * FROM tbl_color ORDER BY tag_color ASC";
            da = new OleDbDataAdapter(query, con);
            //con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Colors");

            cbTagColor.DisplayMember = "tag_color";
            cbTagColor.ValueMember = "ID";
            cbTagColor.DataSource = ds.Tables["Colors"];

        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFolderCode.Text == "" || tbFolderName.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand(@"SELECT * FROM tbl_folder WHERE folder_code = @folder_code AND ID <> @id", con);
                cmd2.Parameters.AddWithValue("@folder_code", tbFolderCode.Text);
                cmd2.Parameters.AddWithValue("@id", tbID.Text);
                con.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() == true)
                {

                    MessageBox.Show("Code suffix has already been used. Please choose another.", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                else {
                    con.Close();

                    OleDbCommand cmd_update_folder = new OleDbCommand(@"UPDATE tbl_folder
                                                SET folder_code = @folder_code,
                                                    folder_name = @folder_name,
                                                    folder_description = @folder_description,
                                                    file_box_id = @file_box_id,
                                                    folder_tag_color = @folder_tag_color
                                                WHERE ID = @id", con);

                    cmd_update_folder.Parameters.AddWithValue("@folder_code", tbFolderCode.Text.ToUpper());
                    cmd_update_folder.Parameters.AddWithValue("@folder_name", tbFolderName.Text.ToUpper());
                    cmd_update_folder.Parameters.AddWithValue("@folder_description", tbFolderDescription.Text.ToUpper());
                    cmd_update_folder.Parameters.AddWithValue("@file_box_id", cbFileBox.SelectedValue);
                    cmd_update_folder.Parameters.AddWithValue("@folder_tag_color", cbTagColor.SelectedValue);
                    cmd_update_folder.Parameters.AddWithValue("@id", tbID.Text);

                    con.Open();
                    cmd_update_folder.ExecuteNonQuery();
                    con.Close();

                    //clearFields();
                    _foldersForm.loadFolders();

                    dashboardForm dashboardform = (dashboardForm)fc.TheForm("dashboardForm");
                    
                    dashboardform.loadDgDocumentsRecords();

                    Form form = Application.OpenForms["addDocumentRecordForm"];
                    if (form != null)
                    {
                        addDocumentRecordForm adddocumentrecordform = (addDocumentRecordForm)fc.TheForm("addDocumentRecordForm");
                        adddocumentrecordform.CbLoadFolders();
                    }

                    Form form2 = Application.OpenForms["EditDocument"];
                    if (form2 != null)
                    {
                        EditDocument editdocument = (EditDocument)fc.TheForm("EditDocument");
                        editdocument.CbLoadFolders();
                    }

                    MessageBox.Show("Successfully Saved Changes", "Folder Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }


            }

        }

        private void llColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ColorsForm().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new fileBoxForm().ShowDialog();
        }


        private void cbFileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTagColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
