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

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));

        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();


        private readonly dashboardForm _dashboardForm;
        public UserProfile(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;
            con = myConnectionString.MyConnection();
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
            var id = loginForm.LoginInfo.UserID;

            tbEmpId.Text = emp_id;
            tbLastName.Text = last_name;
            tbFirstName.Text = first_name;
            tbMiddleName.Text = middle_name;
            tbNameExtn.Text = name_extn;

            cbSection.SelectedItem = section;
            cbUnit.SelectedItem = unit;


            tbStatus.Text = status;
            tbId.Text = id.ToString();

            //Console.WriteLine(cbSection.SelectedItem.ToString());

        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd_update_user = new OleDbCommand(@"UPDATE tbl_user SET emp_id = @emp_id, last_name = @last_name, first_name = @first_name, middle_name = @middle_name, name_extension = @name_extension, user_section = @mysection, user_unit = @myunit WHERE ID = @id", con);

            cmd_update_user.Parameters.AddWithValue("@emp_id", tbEmpId.Text);
            cmd_update_user.Parameters.AddWithValue("@last_name", tbLastName.Text);
            cmd_update_user.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            cmd_update_user.Parameters.AddWithValue("@middle_name", tbMiddleName.Text);
            cmd_update_user.Parameters.AddWithValue("@name_extension", tbNameExtn.Text);
            cmd_update_user.Parameters.AddWithValue("@mysection", cbSection.SelectedItem.ToString());
            cmd_update_user.Parameters.AddWithValue("@myunit", cbUnit.SelectedItem.ToString());
            cmd_update_user.Parameters.AddWithValue("@id", tbId.Text);



            con.Open();
            cmd_update_user.ExecuteNonQuery();
            con.Close();

            LinkLabel ll_user = ((LinkLabel)fc.Ctrl(fc.TheForm("dashboardForm"), "ll_user"));
            ll_user.Text = tbFirstName.Text;
            loginForm.LoginInfo.LastName = tbLastName.Text;
            loginForm.LoginInfo.FirstName = tbFirstName.Text;
            loginForm.LoginInfo.Middlename = tbMiddleName.Text;
            loginForm.LoginInfo.NameExtension = tbNameExtn.Text;
            loginForm.LoginInfo.EmpID = tbEmpId.Text;
            loginForm.LoginInfo.Section = cbSection.SelectedItem.ToString();
            loginForm.LoginInfo.Unit = cbUnit.SelectedItem.ToString();


            MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
