using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            Dispalyusername();
            StartClock();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        public void Dispalyusername()
        {
            string getusername = LoginForm.username;
            usernamelabel.Text = getusername.Substring(0,1).ToUpper() + getusername.Substring(1);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            Dispalyusername();
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm form = new LoginForm();
                form.Show();
                this.Hide();
            }
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            UCIncomeForm incomeForm = new UCIncomeForm();
            LoadFormInPanel(incomeForm);
        }

        private void LoadFormInPanel(UserControl selectedForm)
        {
            panel3.Controls.Clear();
            selectedForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(selectedForm);
            selectedForm.Show();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            UCCategoryForm categoryForm= new UCCategoryForm();
            LoadFormInPanel(categoryForm);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            UCDashboardForm dashboardForm = new UCDashboardForm();
            LoadFormInPanel(dashboardForm);
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            UCExpenseForm expenseForm = new UCExpenseForm();
            LoadFormInPanel(expenseForm);
        }

    }
}
