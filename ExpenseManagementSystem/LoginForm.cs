using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class LoginForm : Form
    {
        public static readonly string cs =
    @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        SqlConnection conn = new SqlConnection(cs);
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string username;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked) { 
                PassWordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassWordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?""{}|<>]).{8,}$";

                if (string.IsNullOrWhiteSpace(UserNameTextBox.Text) || string.IsNullOrWhiteSpace(PassWordtextBox.Text))
                {
                    MessageBox.Show("Username and Password are required.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(PassWordtextBox.Text, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include 1 uppercase, 1 lowercase, 1 number, and 1 special character.",
                                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn.Open();
                string chekqr = "SELECT username, password FROM tbl_users WHERE username = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(chekqr, conn))
                {
                    cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", PassWordtextBox.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = UserNameTextBox.Text;
                        MessageBox.Show("Login Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DashboardForm dform = new DashboardForm();
                        dform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
