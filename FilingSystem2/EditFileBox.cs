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
    public partial class EditFileBox : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();

        private readonly fileBoxForm _fileBoxForm;
        public EditFileBox(fileBoxForm fileboxform)
        {
            InitializeComponent();
            _fileBoxForm = fileboxform;
        }

        private void EditFileBox_Load(object sender, EventArgs e)
        {
            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("fileBoxForm"), "dgFileBox"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var box_name = dgv.CurrentRow.Cells[1].Value;
            var box_description = dgv.CurrentRow.Cells[2].Value;
            var created_by = dgv.CurrentRow.Cells[3].Value;

            tbID.Text = id.ToString();
            //tbFileBoxCode.Text = box_code.ToString();
            tbFileBoxName.Text = box_name.ToString();
            tbFileBoxDescription.Text = box_description.ToString();
            //cbFileBox.Text = file_box.ToString();
        }

        private void btnSaveChangesFileBox_Click(object sender, EventArgs e)
        {
            if (tbFileBoxName.Text == "" || tbFileBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd_update_box = new OleDbCommand(@"UPDATE tbl_file_box
                                                SET box_name = @box_name,
                                                    box_description = @box_description
                                                WHERE ID = @id", con);

                cmd_update_box.Parameters.AddWithValue("@box_name", tbFileBoxName.Text);
                cmd_update_box.Parameters.AddWithValue("@box_description", tbFileBoxDescription.Text);
                cmd_update_box.Parameters.AddWithValue("@id", tbID.Text);
                con.Open();
                cmd_update_box.ExecuteNonQuery();
                con.Close();

                _fileBoxForm.loadFileBoxes();
                MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
