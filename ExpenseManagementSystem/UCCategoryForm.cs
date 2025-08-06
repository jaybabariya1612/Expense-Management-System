using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class UCCategoryForm : UserControl
    {
        public static readonly string cs =
     @"Server=den1.mssql7.gear.host;Database=sql12793698;User Id=sql12793698;Password=Wd8ij_D1V2h~;TrustServerCertificate=True";

        //public static readonly string cs = @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        //MySqlConnection conn = new MySqlConnection(cs);
        //SqlConnection conn = new SqlConnection(cs);
        public UCCategoryForm()
        {
            InitializeComponent();
            ExpenseCategoryCount();
            IncomeCategoryCount();
            ActiveCategoryCount();
            TotalCategoryCount();
        }

        public void ExpenseCategoryCount()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "select COUNT(Category_Name)  from tbl_Category where Category_type = 'Expense'";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    expenseCategoriesCount.Text = count.ToString();
                }
            }
        }

        public void IncomeCategoryCount()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "select COUNT(Category_Name)  from tbl_Category where Category_type = 'Income'";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    incomeCategoriesCount.Text = count.ToString();
                }
            }
        }
        public void ActiveCategoryCount()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "select COUNT(Category_Name)  from tbl_Category where Category_Status= 'Active'";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    activeCategoriesCount.Text = count.ToString();
                }
            }
        }

        public void TotalCategoryCount()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string selectdata = "select COUNT(category_id) from tbl_Category";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    TotalCaregoryCount.Text = count.ToString();
                }
            }
        }



        public void DisplayCategoryData()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listdata = cData.CategoryListData();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listdata;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorytextBox.Text == "" || TypecomboBox.SelectedIndex == -1 || StatuscomboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill All the Blank Details", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(cs))
                    {
                        conn.Open();
                        string insertdata = "insert into tbl_Category(Category_Name,Category_Type,Category_Status,date_insert) values(@Category_Name,@Category_Type,@Category_Status,GETDATE()+1)";
                        using (SqlCommand cmd = new SqlCommand(insertdata, conn))
                        {
                            cmd.Parameters.AddWithValue("@Category_Name",CategorytextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Category_Type",TypecomboBox.SelectedItem);
                            cmd.Parameters.AddWithValue("@Category_Status", StatuscomboBox.SelectedItem);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayCategoryData();
                            ExpenseCategoryCount();
                            IncomeCategoryCount();
                            ActiveCategoryCount();
                            TotalCategoryCount();

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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorytextBox.Text == "" || TypecomboBox.SelectedIndex == -1 || StatuscomboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill All the Blank Details", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to update ID" + GetId +"?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(cs))
                        {
                            conn.Open();
                            string updatedata = "update tbl_category set Category_Name =@Category_Name,Category_Type =@Category_Type,Category_Status = @Category_Status,date_insert= GETDATE()+1 where Category_id = @id";
                            using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", GetId);
                                cmd.Parameters.AddWithValue("@Category_Name", CategorytextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@Category_Type", TypecomboBox.SelectedItem);
                                cmd.Parameters.AddWithValue("@Category_Status", StatuscomboBox.SelectedItem);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayCategoryData();
                                ExpenseCategoryCount();
                                IncomeCategoryCount();
                                ActiveCategoryCount();
                                TotalCategoryCount();

                                conn.Close();
                                clecontrol();
                            }
                        }

                    }
                }
                DisplayCategoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorytextBox.Text == "" || TypecomboBox.SelectedIndex == -1 || StatuscomboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill All the Blank Details", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete ID" + GetId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(cs))
                        {
                            conn.Open();
                            string deletedata = "delete tbl_Category where Category_Id = @id";
                            using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", GetId);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayCategoryData();
                                ExpenseCategoryCount();
                                IncomeCategoryCount();
                                ActiveCategoryCount();
                                TotalCategoryCount();

                                conn.Close();
                                clecontrol();
                            }
                        }

                    }
                }
                DisplayCategoryData();
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

        public void clecontrol()
        {
            CategorytextBox.Text = "";
            StatuscomboBox.SelectedIndex = -1;
            TypecomboBox.SelectedIndex = -1;
        }

        private int GetId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                GetId = Convert.ToInt32(row.Cells[0].Value);
                CategorytextBox.Text = row.Cells[1].Value.ToString();
                TypecomboBox.SelectedItem = row.Cells[2].Value.ToString();
                StatuscomboBox.SelectedItem = row.Cells[3].Value.ToString();
            }
        }


        private void UCCategoryForm_Load(object sender, EventArgs e)
        {
            DisplayCategoryData();
        }

    }
}
