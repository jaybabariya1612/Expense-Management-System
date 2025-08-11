namespace ExpenseManagementSystem
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExpenseManagementSystemLabel = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ExpenseButton = new System.Windows.Forms.Button();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucDashboardForm1 = new ExpenseManagementSystem.UCDashboardForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExpenseManagementSystemLabel);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 57);
            this.panel1.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(975, 19);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 19);
            this.dateLabel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseManagementSystem.Properties.Resources.EMS_LOGO_BLUE;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ExpenseManagementSystemLabel
            // 
            this.ExpenseManagementSystemLabel.AutoSize = true;
            this.ExpenseManagementSystemLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.ExpenseManagementSystemLabel.ForeColor = System.Drawing.Color.White;
            this.ExpenseManagementSystemLabel.Location = new System.Drawing.Point(512, 9);
            this.ExpenseManagementSystemLabel.Name = "ExpenseManagementSystemLabel";
            this.ExpenseManagementSystemLabel.Size = new System.Drawing.Size(308, 30);
            this.ExpenseManagementSystemLabel.TabIndex = 4;
            this.ExpenseManagementSystemLabel.Text = "Expense Management System";
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1222, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(30, 30);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 13;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.LogOutButton);
            this.panel2.Controls.Add(this.ExpenseButton);
            this.panel2.Controls.Add(this.IncomeButton);
            this.panel2.Controls.Add(this.CategoryButton);
            this.panel2.Controls.Add(this.DashboardButton);
            this.panel2.Controls.Add(this.usernamelabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 624);
            this.panel2.TabIndex = 1;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(12, 566);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(172, 36);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ExpenseButton
            // 
            this.ExpenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ExpenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpenseButton.FlatAppearance.BorderSize = 0;
            this.ExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpenseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseButton.ForeColor = System.Drawing.Color.White;
            this.ExpenseButton.Location = new System.Drawing.Point(12, 326);
            this.ExpenseButton.Name = "ExpenseButton";
            this.ExpenseButton.Size = new System.Drawing.Size(172, 36);
            this.ExpenseButton.TabIndex = 4;
            this.ExpenseButton.Text = "Expense";
            this.ExpenseButton.UseVisualStyleBackColor = false;
            this.ExpenseButton.Click += new System.EventHandler(this.ExpenseButton_Click);
            // 
            // IncomeButton
            // 
            this.IncomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.IncomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomeButton.FlatAppearance.BorderSize = 0;
            this.IncomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeButton.ForeColor = System.Drawing.Color.White;
            this.IncomeButton.Location = new System.Drawing.Point(12, 270);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(172, 36);
            this.IncomeButton.TabIndex = 3;
            this.IncomeButton.Text = "Income";
            this.IncomeButton.UseVisualStyleBackColor = false;
            this.IncomeButton.Click += new System.EventHandler(this.IncomeButton_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.CategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryButton.FlatAppearance.BorderSize = 0;
            this.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryButton.ForeColor = System.Drawing.Color.White;
            this.CategoryButton.Location = new System.Drawing.Point(12, 214);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(172, 36);
            this.CategoryButton.TabIndex = 2;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = false;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Location = new System.Drawing.Point(12, 158);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(172, 36);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(80, 122);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 19);
            this.usernamelabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome,";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExpenseManagementSystem.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(43, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.ucDashboardForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 624);
            this.panel3.TabIndex = 2;
            // 
            // ucDashboardForm1
            // 
            this.ucDashboardForm1.BackColor = System.Drawing.Color.White;
            this.ucDashboardForm1.Location = new System.Drawing.Point(-3, 0);
            this.ucDashboardForm1.Name = "ucDashboardForm1";
            this.ucDashboardForm1.Size = new System.Drawing.Size(1064, 624);
            this.ucDashboardForm1.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ExpenseManagementSystemLabel;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ExpenseButton;
        private System.Windows.Forms.Button IncomeButton;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private UCDashboardForm ucDashboardForm1;
        private System.Windows.Forms.Label dateLabel;
    }
}
