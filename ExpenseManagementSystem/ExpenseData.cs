using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagementSystem
{
    internal class ExpenseData
    {
        public static readonly string cs = @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        SqlConnection conn = new SqlConnection(cs);

        public int Expense_id { get; set; }

        public string Category { get; set; }

        public string Item { get; set; }

        public string Expense { get; set; }
        public string description { get; set; }
        public DateTime date_Expense { get; set; }
        public DateTime date_insert { get; set; }

        public List<ExpenseData> ExpenseListData()
        {
            List<ExpenseData> listdata = new List<ExpenseData>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string selectdata = "select Expense_id,Category,Item,Expense,description,date_Expense,date_insert from tbl_Expense";
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpenseData Edata = new ExpenseData();
                        Edata.Expense_id = Convert.ToInt32(reader["Expense_id"]);
                        Edata.Category = Convert.ToString(reader["Category"]);
                        Edata.Item = Convert.ToString(reader["Item"]);
                        Edata.Expense = Convert.ToString(reader["Expense"]);
                        Edata.description = Convert.ToString(reader["description"]);
                        Edata.date_Expense = Convert.ToDateTime(reader["date_Expense"]);
                        Edata.date_insert = Convert.ToDateTime(reader["date_insert"]);
                        listdata.Add(Edata);

                    }
                }
            }
            return listdata;
        }

    }
}
