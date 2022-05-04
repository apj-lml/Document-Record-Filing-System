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
    public partial class AdminUserControl : Form
    {

        private readonly dashboardForm _dashboardForm;
        public AdminUserControl(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;

            con = myConnectionString.MyConnection();
        }

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        MyConnectionString myConnectionString = new MyConnectionString();
        OleDbConnection con = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        FindControl fc = new FindControl();
        

        public DataTable MyFiles(string filter_by = null, string filter_value = null)
        {
            string sql = null;
            
            if (filter_by == null)
            {
                sql = @"SELECT * FROM tbl_user";

            }

            con.Open();
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            con.Close();
            return dt;
        }

        public void loadListOfUsers()
        {
            dgListOfUsers.DataSource = MyFiles();
            dgListOfUsers.Refresh();
            dgListOfUsers.Update();
        }
        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            loadListOfUsers();
        }

        private void editSelectedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFileDocument.Visible = false;
            btnSaveChanges.Visible = true;

            tbId.Text = dgListOfUsers.CurrentRow.Cells[0].Value.ToString();
            tbEmpId.Text = dgListOfUsers.CurrentRow.Cells[1].Value.ToString();
            tbPassword.Text = dgListOfUsers.CurrentRow.Cells[2].Value.ToString();
            tbConfirmPassword.Text = dgListOfUsers.CurrentRow.Cells[2].Value.ToString();
            tbLastName.Text = dgListOfUsers.CurrentRow.Cells[3].Value.ToString();
            tbFirstName.Text = dgListOfUsers.CurrentRow.Cells[4].Value.ToString();
            tbMiddleName.Text = dgListOfUsers.CurrentRow.Cells[5].Value.ToString();
            tbNameExtn.Text = dgListOfUsers.CurrentRow.Cells[6].Value.ToString();
            cbSection.SelectedItem = dgListOfUsers.CurrentRow.Cells[7].Value.ToString();
            cbUnit.SelectedItem = dgListOfUsers.CurrentRow.Cells[8].Value.ToString();
            cbStatus.SelectedItem = dgListOfUsers.CurrentRow.Cells[9].Value.ToString();
            cbRole.SelectedItem = dgListOfUsers.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == tbConfirmPassword.Text)
            {
                OleDbCommand cmd_update_user = new OleDbCommand(@"UPDATE tbl_user
                                                    SET emp_id = @emp_id,
                                                        [password] = @password,
                                                        last_name = @last_name,
                                                        first_name = @first_name,
                                                        middle_name = @middle_name,
                                                        name_extension = @name_extension,
                                                        user_section = @user_section,
                                                        user_unit = @user_unit,
                                                        active_status = @active_status,
                                                        role = @role
                                                    WHERE ID = @id", con);

                cmd_update_user.Parameters.AddWithValue("@emp_id", tbEmpId.Text);
                cmd_update_user.Parameters.AddWithValue("@password", tbPassword.Text);
                cmd_update_user.Parameters.AddWithValue("@last_name", tbLastName.Text);
                cmd_update_user.Parameters.AddWithValue("@first_name", tbFirstName.Text);
                cmd_update_user.Parameters.AddWithValue("@middle_name", tbMiddleName.Text);
                cmd_update_user.Parameters.AddWithValue("@name_extension", tbNameExtn.Text);
                cmd_update_user.Parameters.AddWithValue("@user_section", cbSection.SelectedItem.ToString());
                cmd_update_user.Parameters.AddWithValue("@user_unit", cbUnit.SelectedItem.ToString());
                cmd_update_user.Parameters.AddWithValue("@active_status", cbStatus.SelectedItem.ToString());
                cmd_update_user.Parameters.AddWithValue("@role", cbRole.SelectedItem.ToString());
                cmd_update_user.Parameters.AddWithValue("@id", tbId.Text);

                con.Open();
                cmd_update_user.ExecuteNonQuery();
                con.Close();

                loadListOfUsers();

                clearFields();

                btnSaveChanges.Visible = false;
                btnFileDocument.Visible = true;


                MessageBox.Show("Successfully Saved Changes", "Saved Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password and Confirm Password does not match!", "Password Does Not Match", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void clearFields()
        {
            tbId.Text = "";
            tbEmpId.Text = "";
            tbPassword.Text = "";
            tbLastName.Text = "";
            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            tbNameExtn.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            cbSection.SelectedItem = "Administrative & Finance Section";
            cbUnit.SelectedItem = "Administrative Unit";
            cbStatus.SelectedItem = "Active";
            cbRole.SelectedItem = "User";
        }

        private void btnFileDocument_Click(object sender, EventArgs e)
        {
            if (tbEmpId.Text == "" || tbLastName.Text == "" || tbFirstName.Text == "" || tbPassword.Text == "" || tbConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbConfirmPassword.Text == tbPassword.Text)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO tbl_user(emp_id, [password], last_name, first_name, middle_name, name_extension, user_section, user_unit, role)
                                            VALUES (@emp_id, @password ,@last_name, @first_name, @middle_name, @name_extension, @user_section, @user_unit, @role)";

                    cmd.Parameters.AddWithValue("@emp_id", tbEmpId.Text);
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
                    cmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
                    cmd.Parameters.AddWithValue("@middle_name", tbMiddleName.Text);
                    cmd.Parameters.AddWithValue("@name_extension", tbNameExtn.Text);
                    cmd.Parameters.AddWithValue("@user_section", cbSection.SelectedItem);
                    cmd.Parameters.AddWithValue("@user_unit", cbUnit.SelectedItem);
                    cmd.Parameters.AddWithValue("@role", cbRole.SelectedItem);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    loadListOfUsers();

                    clearFields();
                    MessageBox.Show("Document / Record Added Successfully", "Success!");
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password does not match!", "Password Does Not Match!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }




            }
        }
        private void activateDeactivateUser(string active_status = "Active")
        {
            var id = dgListOfUsers.CurrentRow.Cells[0].Value;
            Console.WriteLine(id);
            Console.WriteLine(active_status);

            OleDbCommand cmd_update_status = new OleDbCommand(@"
                                        UPDATE tbl_user
                                        SET active_status = @active_status
                                        WHERE ID = @id", con);

            cmd_update_status.Parameters.AddWithValue("@active_status", active_status);
            cmd_update_status.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd_update_status.ExecuteNonQuery();
            con.Close();

            if(active_status == "Active")
            {
                MessageBox.Show("User succesfully Activated!", "User Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("User succesfully Deactivated!", "User Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            loadListOfUsers();


        }
        private void activateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to activate this User?", "Activate User?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                activateDeactivateUser("Active");
            }
        }

        private void deactivateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to deactivate this User?", "Deactivate User?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                activateDeactivateUser("Inactive");
            }
        }
    }
}
