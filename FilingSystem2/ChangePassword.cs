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
    public partial class ChangePassword : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public ChangePassword()
        {
            InitializeComponent();
            con = myConnectionString.MyConnection();
        }

        private void btnSaveChangesDocument_Click(object sender, EventArgs e)
        {
            var password = loginForm.LoginInfo.Password;
            var user_id = loginForm.LoginInfo.UserID;

            if (tbCurrentPassword.Text == password)
            {
                if(tbNewPassword.Text == tbConfirmPassword.Text)
                {

                    OleDbCommand cmd = new OleDbCommand(@"UPDATE tbl_user SET [password] = @password WHERE ID = @id", con);

                    cmd.Parameters.AddWithValue("@password", tbNewPassword.Text);
                    cmd.Parameters.AddWithValue("@id", user_id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully changed password! ", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Confirm password new password does not match! ", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                    MessageBox.Show("Current password does not match! ", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
