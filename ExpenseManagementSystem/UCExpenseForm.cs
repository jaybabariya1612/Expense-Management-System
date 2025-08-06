using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class UCExpenseForm : UserControl
    {
        public static readonly string cs =
            @"Server=den1.mssql7.gear.host;Database=sql12793698;User Id=sql12793698;Password=Wd8ij_D1V2h~;TrustServerCertificate=True";

        private int GetId = 0;

        public UCExpenseForm()
        {
            InitializeComponent();
            DisplayCategory();
            DisplayExpenseData();
            TotalExpense();
        }

        // ---------- TOTAL EXPENSE ----------
        public void TotalExpense()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "SELECT ISNULL(SUM(expense),0) FROM tbl_expense";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    double count = Convert.ToDouble(cmd.ExecuteScalar());
                    totalExpenseValue.Text = "₹" + count.ToString("N2");
                }
            }
            ThisMonthExpense();
        }

        // ---------- THIS MONTH EXPENSE ----------
        public void ThisMonthExpense()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "SELECT ISNULL(SUM(expense),0) FROM tbl_expense " +
                               "WHERE MONTH(date_expense) = MONTH(GETDATE()) AND YEAR(date_expense) = YEAR(GETDATE())";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    double result = Convert.ToDouble(cmd.ExecuteScalar());
                    thisMonthExpenseValue.Text = "₹" + result.ToString("N2");
                }
            }
            LastMonthExpense();
        }

        // ---------- LAST MONTH EXPENSE ----------
        public void LastMonthExpense()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = @"SELECT ISNULL(SUM(expense),0) FROM tbl_expense
                                 WHERE MONTH(date_expense) = MONTH(DATEADD(MONTH, -1, GETDATE()+1))
                                 AND YEAR(date_expense) = YEAR(DATEADD(MONTH, -1, GETDATE()+1))";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    double result = Convert.ToDouble(cmd.ExecuteScalar());
                    lastMonthExpenseValue.Text = "₹" + result.ToString("N2");
                }
            }
        }

        // ---------- DISPLAY CATEGORY ----------
        public void DisplayCategory()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string selectdata = "SELECT Category_Name FROM tbl_category WHERE Category_Type = @Category_Type AND Category_Status = @Category_Status";

                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    cmd.Parameters.AddWithValue("@Category_Type", "Expense");
                    cmd.Parameters.AddWithValue("@Category_Status", "Active");
                    CategorycomboBox.Items.Clear();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CategorycomboBox.Items.Add(dr["Category_Name"].ToString());
                    }
                }
            }
        }

        // ---------- CLEAR INPUT ----------
        public void ClearControls()
        {
            CategorycomboBox.SelectedIndex = -1;
            ItemTextBox.Text = "";
            ExpensetextBox.Text = "";
            DiscriptionrichTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }

        // ---------- DISPLAY EXPENSE DATA ----------
        public void DisplayExpenseData()
        {
            ExpenseData EData = new ExpenseData();
            List<ExpenseData> listdata = EData.ExpenseListData();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listdata;
        }

        // ---------- ADD RECORD ----------
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorycomboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(ItemTextBox.Text) || string.IsNullOrWhiteSpace(ExpensetextBox.Text) || string.IsNullOrWhiteSpace(DiscriptionrichTextBox.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string insertdata = "INSERT INTO tbl_expense(Category,Item,expense,description,date_expense,date_insert) " +
                                        "VALUES (@Category,@Item,@expense,@description,@date_expense,GETDATE()+1)";

                    using (SqlCommand cmd = new SqlCommand(insertdata, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", CategorycomboBox.SelectedItem);
                        cmd.Parameters.AddWithValue("@Item", ItemTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@expense", Convert.ToDouble(ExpensetextBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@description", DiscriptionrichTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_expense", dateTimePicker.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayExpenseData();
                TotalExpense();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------- CLEAR BUTTON ----------
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        // ---------- UPDATE RECORD ----------
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetId == 0)
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string updatedata = "UPDATE tbl_expense SET Category=@Category,Item=@Item,expense=@expense,description=@description,date_expense=@date_expense,date_insert=GETDATE()+1 WHERE Expense_id=@Expense_id";

                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@Expense_id", GetId);
                        cmd.Parameters.AddWithValue("@Category", CategorycomboBox.SelectedItem);
                        cmd.Parameters.AddWithValue("@Item", ItemTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@expense", Convert.ToDouble(ExpensetextBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@description", DiscriptionrichTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_expense", dateTimePicker.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayExpenseData();
                TotalExpense();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------- SELECT ROW ----------
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

        // ---------- DELETE RECORD ----------
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetId == 0)
                {
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete ID " + GetId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(cs))
                    {
                        conn.Open();
                        string deletedata = "DELETE FROM tbl_expense WHERE Expense_id=@id";
                        using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", GetId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayExpenseData();
                    TotalExpense();
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
