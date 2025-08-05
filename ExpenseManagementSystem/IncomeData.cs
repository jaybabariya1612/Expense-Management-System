using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagementSystem
{
    internal class IncomeData
    {
        public static readonly string cs = @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        SqlConnection conn = new SqlConnection(cs);

        public int Income_id { get; set; }

        public string Category { get; set; }

        public string Item { get; set; }

        public string income { get; set; }
        public string description { get; set; }
        public DateTime date_income { get; set; }
        public DateTime date_insert { get; set; }

        public List<IncomeData> IncomeListData()
        {
            List<IncomeData> listdata = new List<IncomeData>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string selectdata = "select Income_id,Category,Item,income,description,date_income,date_insert from tbl_income";
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData Idata = new IncomeData();
                        Idata.Income_id = Convert.ToInt32(reader["Income_id"]);
                        Idata.Category = Convert.ToString(reader["Category"]);
                        Idata.Item = Convert.ToString(reader["Item"]);
                        Idata.income = Convert.ToString(reader["income"]);
                        Idata.description = Convert.ToString(reader["description"]);
                        Idata.date_income = Convert.ToDateTime(reader["date_income"]);
                        Idata.date_insert = Convert.ToDateTime(reader["date_insert"]);
                        listdata.Add(Idata);

                    }
                }
            }
            return listdata;
        }

    }
}
