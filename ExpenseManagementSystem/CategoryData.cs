using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagementSystem
{
    internal class CategoryData
    {
        public static readonly string cs =@"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        SqlConnection conn = new SqlConnection(cs);

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryType { get; set; }

        public string CategoryStatus{ get; set; }
        public DateTime Date{ get; set; }

        public List<CategoryData> CategoryListData()
        {
            List<CategoryData> lisrdata = new List<CategoryData>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string selectdata= "select Category_Id,Category_Name,Category_Type,Category_Status,date_insert from tbl_category";
                using (SqlCommand cmd = new SqlCommand(selectdata,conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoryData Cdata = new CategoryData();
                        Cdata.CategoryID = Convert.ToInt32(reader["Category_Id"]);
                        Cdata.CategoryName = Convert.ToString(reader["Category_Name"]);
                        Cdata.CategoryType= Convert.ToString(reader["Category_Type"]);
                        Cdata.CategoryStatus = Convert.ToString(reader["Category_Status"]);
                        Cdata.Date = Convert.ToDateTime(reader["date_insert"]);
                        lisrdata.Add(Cdata);
                        
                    }
                }
            }
            return lisrdata;
        }

    }
}
