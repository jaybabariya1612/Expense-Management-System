using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class UCIncomeForm : UserControl
    {
        public static readonly string cs =
            @"Server=den1.mssql7.gear.host;Database=sql12793698;User Id=sql12793698;Password=Wd8ij_D1V2h~;TrustServerCertificate=True";

        private int GetId = 0;

        public UCIncomeForm()
        {
            InitializeComponent();
            DisplayCategory();
            DisplayIncomeData();
            TotalIncome();
        }

        // ---------- TOTAL INCOME ----------
        public void TotalIncome()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "SELECT ISNULL(SUM(income),0) FROM tbl_income";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    double count = Convert.ToDouble(cmd.ExecuteScalar());
                    totalIncomeValue.Text = "₹" + count.ToString("N2");
                }
            }
            ThisMonthIncome();
        }

        // ---------- THIS MONTH INCOME ----------
        public void ThisMonthIncome()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "SELECT ISNULL(SUM(income),0) FROM tbl_income " +
                               "WHERE MONTH(date_income) = MONTH(GETDATE()) AND YEAR(date_income) = YEAR(GETDATE())";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    double result = Convert.ToDouble(cmd.ExecuteScalar());
                    thisMonthIncomeValue.Text = "₹" + result.ToString("N2");
                }
            }
            LastMonthIncome();
        }

        // ---------- LAST MONTH INCOME ----------
        public void LastMonthIncome()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = @"SELECT ISNULL(SUM(income),0) FROM tbl_income
                                 WHERE MONTH(date_income) = MONTH(DATEADD(MONTH, -1, GETDATE()+1))
                                 AND YEAR(date_income) = YEAR(DATEADD(MONTH, -1, GETDATE()+1))";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    double result = Convert.ToDouble(cmd.ExecuteScalar());
                    lastMonthIncomeValue.Text = "₹" + result.ToString("N2");
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
                    cmd.Parameters.AddWithValue("@Category_Type", "Income");
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

        // ---------- CLEAR INPUT FIELDS ----------
        public void ClearControls()
        {
            CategorycomboBox.SelectedIndex = -1;
            ItemTextBox.Text = "";
            IncometextBox.Text = "";
            DiscriptionrichTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }

        // ---------- DISPLAY INCOME DATA ----------
        public void DisplayIncomeData()
        {
            IncomeData IData = new IncomeData();
            List<IncomeData> listdata = IData.IncomeListData();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listdata;
        }

        // ---------- ADD RECORD ----------
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorycomboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(ItemTextBox.Text) || string.IsNullOrWhiteSpace(IncometextBox.Text) || string.IsNullOrWhiteSpace(DiscriptionrichTextBox.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string insertdata = "INSERT INTO tbl_income(Category,Item,income,description,date_income,date_insert) " +
                                        "VALUES (@Category,@Item,@income,@description,@date_income,GETDATE()+1)";

                    using (SqlCommand cmd = new SqlCommand(insertdata, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", CategorycomboBox.SelectedItem);
                        cmd.Parameters.AddWithValue("@Item", ItemTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", Convert.ToDouble(IncometextBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@description", DiscriptionrichTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_income", dateTimePicker.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayIncomeData();
                TotalIncome();
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
                    string updatedata = "UPDATE tbl_income SET Category=@Category,Item=@Item,income=@income,description=@description,date_income=@date_income,date_insert=GETDATE()+1 WHERE Income_id=@Income_id";

                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@Income_id", GetId);
                        cmd.Parameters.AddWithValue("@Category", CategorycomboBox.SelectedItem);
                        cmd.Parameters.AddWithValue("@Item", ItemTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", Convert.ToDouble(IncometextBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@description", DiscriptionrichTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_income", dateTimePicker.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayIncomeData();
                TotalIncome();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------- SELECT ROW IN GRID ----------
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                GetId = Convert.ToInt32(row.Cells[0].Value);
                CategorycomboBox.SelectedItem = row.Cells[1].Value.ToString();
                ItemTextBox.Text = row.Cells[2].Value.ToString();
                IncometextBox.Text = row.Cells[3].Value.ToString();
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
                        string deletedata = "DELETE FROM tbl_income WHERE Income_id=@id";
                        using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", GetId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayIncomeData();
                    TotalIncome();
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
