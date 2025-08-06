using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ExpenseManagementSystem
{
    public partial class UCDashboardForm : UserControl
    {
        //public static readonly string cs =
        //    @"Data Source=DESKTOP-2A8TSD7;Initial Catalog=Jay_Test;User ID=developer;Password=Destiny123*;";
        public static readonly string cs =
@"Server=den1.mssql7.gear.host;Database=sql12793698;User Id=sql12793698;Password=Wd8ij_D1V2h~;TrustServerCertificate=True";

        public UCDashboardForm()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            StartClock();
            TodayIncome();
            TodayExpense();


        }

        private void StartClock()
        {
            dateLabel.Text = DateTime.Now.ToString("MMMM d, yyyy hh:mm:ss tt");

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("MMMM d, yyyy hh:mm:ss tt");
        }

        public void TodayIncome()
        {
            string query = "SELECT SUM(income) FROM tbl_income WHERE CONVERT(Date, date_income) = @date_in";
            object result = ExecuteScalar(query, new SqlParameter("@date_in", DateTime.Today));

            todayIncomeValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            YesterdayIncome();
        }


        public void TodayExpense()
        {
            string query = "SELECT SUM(Expense) FROM tbl_Expense WHERE CONVERT(Date, date_Expense) = @date_in";
            object result = ExecuteScalar(query, new SqlParameter("@date_in", DateTime.Today));

            todayExpenseValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            YesterdayExpense();
        }

        public void YesterdayIncome()
        {
            string query = "SELECT SUM(income) FROM tbl_income WHERE CONVERT(Date, date_income) = DATEADD(day, -1, CAST(GETDATE()+1 AS DATE))";
            object result = ExecuteScalar(query);

            yesterdayIncomeValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            ThisMonthIncome();
        }
        public void YesterdayExpense()
        {
            string query = "SELECT SUM(Expense) FROM tbl_Expense WHERE CONVERT(Date, date_Expense) = DATEADD(day, -1, CAST(GETDATE()+1 AS DATE))";
            object result = ExecuteScalar(query);

            yesterdayExpenseValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            ThisMonthExpense();
        }

        public void ThisMonthIncome()
        {
            string query = "SELECT SUM(income) FROM tbl_income " +
                           "WHERE MONTH(date_income) = MONTH(GETDATE()) AND YEAR(date_income) = YEAR(GETDATE())";
            object result = ExecuteScalar(query);

            monthlyIncomeValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            ThisYearIncome();
        }
        public void ThisMonthExpense()
        {
            string query = "SELECT SUM(Expense) FROM tbl_Expense " +
                           "WHERE MONTH(date_Expense) = MONTH(GETDATE()) AND YEAR(date_Expense) = YEAR(GETDATE())";
            object result = ExecuteScalar(query);

            monthlyExpenseValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            ThisYearExpense();
        }

        public void ThisYearIncome()
        {
            string query = "SELECT SUM(income) FROM tbl_income WHERE YEAR(date_income) = YEAR(GETDATE())";
            object result = ExecuteScalar(query);

            yearlyIncomeValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
            LoadDailyIncomeChart();
        }
        public void ThisYearExpense()
        {
            string query = "SELECT SUM(Expense) FROM tbl_Expense WHERE YEAR(date_Expense) = YEAR(GETDATE())";
            object result = ExecuteScalar(query);

            yearlyExpenseValue.Text = (result != DBNull.Value && result != null)
                ? Convert.ToDecimal(result).ToString("c")
                : "₹0.00";
        }
 // Add this

public void LoadDailyIncomeChart()
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            string query = @"SELECT CONVERT(Date, date_income) AS IncomeDate, SUM(income) AS TotalIncome
                         FROM tbl_income
                         WHERE date_income >= DATEADD(DAY, -6, CAST(GETDATE()+1 AS DATE))
                         GROUP BY CONVERT(Date, date_income)
                         ORDER BY IncomeDate";

                SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

            incomeChart.Series.Clear();
            Series series = new Series("Daily Income");
            series.ChartType = SeriesChartType.Column; 

            while (reader.Read())
            {
                DateTime date = Convert.ToDateTime(reader["IncomeDate"]);
                decimal totalIncome = Convert.ToDecimal(reader["TotalIncome"]);
                series.Points.AddXY(date.ToString("MMM d"), totalIncome);
            }

            incomeChart.Series.Add(series);
            incomeChart.Titles.Clear();
            incomeChart.Titles.Add("Income of Last 7 Days");
        }
            LoadDailyExpenseChart();
    }
        public void LoadDailyExpenseChart()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = @"SELECT CONVERT(Date, date_Expense) AS ExpenseDate, SUM(Expense) AS TotalExpense
                         FROM tbl_Expense
                         WHERE date_Expense >= DATEADD(DAY, -6, CAST(GETDATE()+1 AS DATE))
                         GROUP BY CONVERT(Date, date_Expense)
                         ORDER BY ExpenseDate";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ExpenseChart.Series.Clear();
                Series series = new Series("Daily Expense");
                series.ChartType = SeriesChartType.Column;

                while (reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["ExpenseDate"]);
                    decimal totalExpense = Convert.ToDecimal(reader["TotalExpense"]);
                    series.Points.AddXY(date.ToString("MMM d"), totalExpense);
                }

                ExpenseChart.Series.Add(series);
                ExpenseChart.Titles.Clear();
                ExpenseChart.Titles.Add("Expense of Last 7 Days");
            }
        }


        // Reusable method for single-value queries
        private object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
        }

    }
}
