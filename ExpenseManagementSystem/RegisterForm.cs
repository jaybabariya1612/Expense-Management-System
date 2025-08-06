using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class RegisterForm : Form
    {
        public static readonly string cs =
     @"Server=den1.mssql7.gear.host;Database=sql12793698;User Id=sql12793698;Password=Wd8ij_D1V2h~;TrustServerCertificate=True";


        //public static readonly string cs = @"server=sql12.freesqldatabase.com;port=3306;database=sql12793698;user=sql12793698;password=trQQblyzEV;";

        //public static readonly string cs =
        //    @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        SqlConnection conn = new SqlConnection(cs);
        //SqlConnection conn = new SqlConnection(cs);

        public bool CheckConnection()
        {
            return(conn.State == ConnectionState.Closed)?true:false;
        }
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }



        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PassWordTextbox.UseSystemPasswordChar = false;
                ConfirmPassWordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                PassWordTextbox.UseSystemPasswordChar = true;
                ConfirmPassWordTextbox.UseSystemPasswordChar = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            if (UserNameTextBox.Text == "" || PassWordTextbox.Text == "" || ConfirmPassWordTextbox.Text == "")
            {
                MessageBox.Show("Please Fill All Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    string selectuser = "SELECT username FROM tbl_Users WHERE username = @username";
                    using (SqlCommand cmd = new SqlCommand(selectuser, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count != 0)
                        {
                            string tempusername = UserNameTextBox.Text.Substring(0, 1).ToUpper() + UserNameTextBox.Text.Substring(1);
                            MessageBox.Show(tempusername + " is already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (PassWordTextbox.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid Password...! At least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!Regex.IsMatch(PassWordTextbox.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?""{}|<>]).{8,}$"))
                        {
                            MessageBox.Show("Password must include at least 1 uppercase, 1 lowercase, 1 number, and 1 special character.",
                                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (PassWordTextbox.Text != ConfirmPassWordTextbox.Text)
                        {
                            MessageBox.Show("Invalid Password...! Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertqr = "INSERT INTO tbl_Users(username,password,date_create) VALUES(@username,@password,GETDATE()+2)";
                            using (SqlCommand cmd1 = new SqlCommand(insertqr, conn))
                            {
                                cmd1.Parameters.AddWithValue("@username", UserNameTextBox.Text.Trim());
                                cmd1.Parameters.AddWithValue("@password", PassWordTextbox.Text.Trim());
                                cmd1.ExecuteNonQuery();

                                MessageBox.Show("Registration Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Hide();
                            }
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
}
