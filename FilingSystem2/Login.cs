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
    public partial class loginForm : Form
    {

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public loginForm()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();
        }

        public static class LoginInfo
        {
            public static int UserID;
            public static string EmpID;
            public static string Password;
            public static string LastName;
            public static string FirstName;
            public static string Middlename;
            public static string NameExtension;
            public static string Section;
            public static string Unit;
            public static string Role;
            public static string Status;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            Console.WriteLine(tbUser.Text);
            Console.WriteLine(tbPassword.Text);
            string login = "SELECT * FROM tbl_user WHERE emp_id = '" + tbUser.Text + "' AND [password] = '" + tbPassword.Text + "' AND active_status = 'Active';";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                LoginInfo.UserID = int.Parse(reader["ID"].ToString());
                LoginInfo.EmpID = reader["emp_id"].ToString();
                LoginInfo.Password = reader["password"].ToString();
                LoginInfo.LastName = reader["last_name"].ToString();
                LoginInfo.FirstName = reader["first_name"].ToString();
                LoginInfo.Middlename = reader["middle_name"].ToString();
                LoginInfo.NameExtension = reader["name_extension"].ToString();
                LoginInfo.Section = reader["user_section"].ToString();
                LoginInfo.Unit = reader["user_unit"].ToString();
                LoginInfo.Role = reader["role"].ToString();
                LoginInfo.Status = reader["active_status"].ToString();

                //LoginInfo.UserInfo = reader.GetString(0);
                this.Hide();

                new dashboardForm().Show();

                con.Close();
            }
            else
            {
                con.Close();
                MessageBox.Show("Invalid Username/Password or Account Deactivated", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.Focus(); this.Show();
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
