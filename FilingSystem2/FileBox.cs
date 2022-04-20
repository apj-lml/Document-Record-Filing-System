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
    public partial class fileBoxForm : Form
    {
        OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\NIA-PIMO\\source\\repos\\FilingSystem2\\FilingSystem2\\db_filingsystem.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        FindControl fc = new FindControl();
        public fileBoxForm()
        {
            InitializeComponent();
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbFileBoxCode.Text == "" || tbFileBoxName.Text == "" || tbFileBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //string add_file = "insert into tbl_file(code,subject, particulars, folder_id, filed_by) values(@code,@subject,@particulars,@folder_id,@filed_by)";
                //con.Open();
                //cmd = new OleDbCommand(add_file, con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tbl_file_box(box_code, box_name, box_description) values(@box_code,@box_name,@box_description)";
                cmd.Parameters.AddWithValue("@box_code", tbFileBoxCode.Text);
                cmd.Parameters.AddWithValue("@box_name", tbFileBoxName.Text);
                cmd.Parameters.AddWithValue("@box_description", tbFileBoxDescription.Text);

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
                //dgv.Refresh();

                MessageBox.Show("Record Inserted Successfully", "Success!");

            }
        }
    }
}
