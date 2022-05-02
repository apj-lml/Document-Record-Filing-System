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
    public partial class UserProfile : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public UserProfile()
        {
            InitializeComponent();
        }

        private void llChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ChangePassword().ShowDialog();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            var role = loginForm.LoginInfo.Role;
            var last_name = loginForm.LoginInfo.LastName;
            var first_name = loginForm.LoginInfo.FirstName;
            var middle_name = loginForm.LoginInfo.Middlename;
            var name_extn = loginForm.LoginInfo.NameExtension;
            var emp_id = loginForm.LoginInfo.EmpID;
            var section = loginForm.LoginInfo.Section;
            var unit = loginForm.LoginInfo.Unit;
            var status = loginForm.LoginInfo.Status;

            tbEmpId.Text = emp_id;
            tbLastName.Text = last_name;
            tbFirstName.Text = first_name;
            tbMiddleName.Text = middle_name;
            tbNameExtn.Text = name_extn;
            cbSection.SelectedText = section;
            cbUnit.SelectedText = unit;
            tbStatus.Text = status;
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
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
            dashboardForm dashboardForm = new dashboardForm();
        }
    }
}
