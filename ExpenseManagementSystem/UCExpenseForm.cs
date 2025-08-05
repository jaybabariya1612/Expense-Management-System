using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class UCExpenseForm : UserControl
    {
        public static readonly string cs = @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        SqlConnection conn = new SqlConnection(cs);

        public UCExpenseForm()
        {
            InitializeComponent();
            DisplayCategory();
            DisplayExpenseData();
            TotalExpense();
        }



        public void TotalExpense()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "select SUM(Expense) from tbl_Expense";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    double count = (double)cmd.ExecuteScalar();
                    totalExpenseValue.Text = "₹" + count.ToString();
                }
            }
            ThisMonthExpense();
        }


        public void ThisMonthExpense()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "SELECT SUM(Expense) FROM tbl_Expense " +
                               "WHERE MONTH(date_Expense) = MONTH(GETDATE()) AND YEAR(date_Expense) = YEAR(GETDATE())";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();  // Use the same connection & command

                    thisMonthExpenseValue.Text = (result != DBNull.Value && result != null)
                        ? Convert.ToDecimal(result).ToString("c")
                        : "₹0.00";
                }
            }
            LastMonthExpense();
        }

        public void LastMonthExpense()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = @"SELECT SUM(Expense) FROM tbl_Expense
                         WHERE MONTH(date_Expense) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                         AND YEAR(date_Expense) = YEAR(DATEADD(MONTH, -1, GETDATE()))";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();

                    lastMonthExpenseValue.Text = (result != DBNull.Value && result != null)
                        ? Convert.ToDecimal(result).ToString("c")
                        : "₹0.00";
                }
            }
        }

        public void DisplayCategory()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                //string selectdata = "select Income_id,Category,Item,income,description,date_income,date_insert from tbl_income";
                string selectdata = "select Category_Name from tbl_category where Category_Type = @Category_Type and Category_Status = @Category_Status";

                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Category_Type", "Expense");
                    cmd.Parameters.AddWithValue("@Category_Status", "Active");
                    CategorycomboBox.Items.Clear();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CategorycomboBox.Items.Add(dr["Category_Name"].ToString());
                    }
                }
                conn.Close();
            }
        }

        public void clecontrol()
        {
            CategorycomboBox.SelectedIndex = -1;
            ItemTextBox.Text = "";
            ExpensetextBox.Text = "";
            DiscriptionrichTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }

        public void DisplayExpenseData()
        {
            ExpenseData EData = new ExpenseData();
            List<ExpenseData> listdata = EData.ExpenseListData();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listdata;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorycomboBox.SelectedIndex == -1 || ItemTextBox.Text == "" || ExpensetextBox.Text == "" || dateTimePicker.Text == "" || DiscriptionrichTextBox.Text == "")
                {
                    MessageBox.Show("Please Fill All the Blank Details", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(cs))
                    {
                        conn.Open();
                        string insertdata = "insert into tbl_expense(Category,Item,expense,description,date_expense,date_insert) values (@Category,@Item,@expense,@description,@date_expense,GETDATE())";

                        using (SqlCommand cmd = new SqlCommand(insertdata, conn))
                        {
                            cmd.Parameters.AddWithValue("@Category", CategorycomboBox.SelectedItem);
                            cmd.Parameters.AddWithValue("@Item", ItemTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@expense", ExpensetextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", DiscriptionrichTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_expense", dateTimePicker.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayExpenseData();
                            TotalExpense();
                            conn.Close();
                            clecontrol();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clecontrol();
        }
        private int GetId = 0;

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorycomboBox.SelectedIndex == -1 || ItemTextBox.Text == "" || ExpensetextBox.Text == "" || dateTimePicker.Text == "" || DiscriptionrichTextBox.Text == "")
                {
                    MessageBox.Show("Please Select Record", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(cs))
                    {
                        conn.Open();
                        string updatedata = "update tbl_Expense set Category=@Category,Item=@Item,Expense=@Expense,description=@description,date_Expense=@date_Expense,date_insert = GETDATE() where Expense_id = @Expense_id";

                        using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                        {
                            cmd.Parameters.AddWithValue("@Expense_id", GetId);
                            cmd.Parameters.AddWithValue("@Category", CategorycomboBox.SelectedItem);
                            cmd.Parameters.AddWithValue("@Item", ItemTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Expense", ExpensetextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", DiscriptionrichTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_Expense", dateTimePicker.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayExpenseData();
                            TotalExpense();
                            conn.Close();
                            clecontrol();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                GetId = Convert.ToInt32(row.Cells[0].Value);
                CategorycomboBox.SelectedItem = row.Cells[1].Value.ToString();
                ItemTextBox.Text = row.Cells[2].Value.ToString();
                ExpensetextBox.Text = row.Cells[3].Value.ToString();
                DiscriptionrichTextBox.Text = row.Cells[4].Value.ToString();
                dateTimePicker.Text = row.Cells[5].Value.ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorycomboBox.SelectedIndex == -1 || ItemTextBox.Text == "" || ExpensetextBox.Text == "" || dateTimePicker.Text == "" || DiscriptionrichTextBox.Text == "")
                {
                    MessageBox.Show("Please Select The Data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete ID " + GetId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(cs))
                        {
                            conn.Open();
                            string deletedata = "delete tbl_Expense where Expense_id = @id";
                            using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", GetId);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayExpenseData();
                                TotalExpense();
                                conn.Close();
                                clecontrol();
                            }
                        }

                    }
                }
                DisplayExpenseData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
