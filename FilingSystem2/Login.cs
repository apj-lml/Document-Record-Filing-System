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
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MSI\\source\\repos\\Document-Record-Filing-System\\FilingSystem2\\db_filingsystem.accdb");
        //OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_filingsystem.accdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\db_filingsystem.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public loginForm()
        {
            InitializeComponent();
        }

        public static class LoginInfo
        {
            public static int UserID;
            public static string EmpID;
            public static string LastName;
            public static string FirstName;
            public static string Middlename;
            public static string NameExtension;
            public static string Section;
            public static string Unit;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_user WHERE emp_id = '" + tbUser.Text + "' AND password = '" + tbPassword.Text + "';";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {

                LoginInfo.UserID = int.Parse(reader["ID"].ToString());
                LoginInfo.EmpID = reader["emp_id"].ToString();
                LoginInfo.LastName = reader["last_name"].ToString();
                LoginInfo.FirstName = reader["first_name"].ToString();
                LoginInfo.Middlename = reader["middle_name"].ToString();
                LoginInfo.NameExtension = reader["name_extension"].ToString();
                LoginInfo.Section = reader["section"].ToString();
                LoginInfo.Unit = reader["unit"].ToString();

                //LoginInfo.UserInfo = reader.GetString(0);
                new dashboardForm().Show();

                this.Hide();
                con.Close();
            }
            else
            {
                con.Close();
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
