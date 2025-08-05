namespace ExpenseManagementSystem
{
    partial class UCExpenseForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.totalExpenseValue = new System.Windows.Forms.Label();
            this.thisMonthExpenseLabel = new System.Windows.Forms.Label();
            this.thisMonthExpenseValue = new System.Windows.Forms.Label();
            this.lastMonthExpenseValue = new System.Windows.Forms.Label();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.lastMonthExpenseLabel = new System.Windows.Forms.Label();
            this.ExpenseHeadinglabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DiscriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.ExpensetextBox = new System.Windows.Forms.TextBox();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Discriptionlabel = new System.Windows.Forms.Label();
            this.Itemlabel = new System.Windows.Forms.Label();
            this.Expenselabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.summaryPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.totalExpenseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalExpenseLabel.Location = new System.Drawing.Point(300, 15);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(39, 15);
            this.totalExpenseLabel.TabIndex = 5;
            this.totalExpenseLabel.Text = "Total: ";
            // 
            // totalExpenseValue
            // 
            this.totalExpenseValue.AutoSize = true;
            this.totalExpenseValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.totalExpenseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.totalExpenseValue.Location = new System.Drawing.Point(340, 15);
            this.totalExpenseValue.Name = "totalExpenseValue";
            this.totalExpenseValue.Size = new System.Drawing.Size(38, 15);
            this.totalExpenseValue.TabIndex = 4;
            this.totalExpenseValue.Text = "$0.00";
            // 
            // thisMonthExpenseLabel
            // 
            this.thisMonthExpenseLabel.AutoSize = true;
            this.thisMonthExpenseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.thisMonthExpenseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thisMonthExpenseLabel.Location = new System.Drawing.Point(150, 15);
            this.thisMonthExpenseLabel.Name = "thisMonthExpenseLabel";
            this.thisMonthExpenseLabel.Size = new System.Drawing.Size(74, 15);
            this.thisMonthExpenseLabel.TabIndex = 3;
            this.thisMonthExpenseLabel.Text = "This Month: ";
            // 
            // thisMonthExpenseValue
            // 
            this.thisMonthExpenseValue.AutoSize = true;
            this.thisMonthExpenseValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.thisMonthExpenseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.thisMonthExpenseValue.Location = new System.Drawing.Point(220, 15);
            this.thisMonthExpenseValue.Name = "thisMonthExpenseValue";
            this.thisMonthExpenseValue.Size = new System.Drawing.Size(38, 15);
            this.thisMonthExpenseValue.TabIndex = 2;
            this.thisMonthExpenseValue.Text = "$0.00";
            // 
            // lastMonthExpenseValue
            // 
            this.lastMonthExpenseValue.AutoSize = true;
            this.lastMonthExpenseValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lastMonthExpenseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lastMonthExpenseValue.Location = new System.Drawing.Point(80, 15);
            this.lastMonthExpenseValue.Name = "lastMonthExpenseValue";
            this.lastMonthExpenseValue.Size = new System.Drawing.Size(38, 15);
            this.lastMonthExpenseValue.TabIndex = 0;
            this.lastMonthExpenseValue.Text = "$0.00";
            // 
            // summaryPanel
            // 
            this.summaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.summaryPanel.Controls.Add(this.totalExpenseLabel);
            this.summaryPanel.Controls.Add(this.totalExpenseValue);
            this.summaryPanel.Controls.Add(this.thisMonthExpenseLabel);
            this.summaryPanel.Controls.Add(this.thisMonthExpenseValue);
            this.summaryPanel.Controls.Add(this.lastMonthExpenseLabel);
            this.summaryPanel.Controls.Add(this.lastMonthExpenseValue);
            this.summaryPanel.Location = new System.Drawing.Point(603, 14);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Padding = new System.Windows.Forms.Padding(10);
            this.summaryPanel.Size = new System.Drawing.Size(444, 50);
            this.summaryPanel.TabIndex = 7;
            // 
            // lastMonthExpenseLabel
            // 
            this.lastMonthExpenseLabel.AutoSize = true;
            this.lastMonthExpenseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lastMonthExpenseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastMonthExpenseLabel.Location = new System.Drawing.Point(10, 15);
            this.lastMonthExpenseLabel.Name = "lastMonthExpenseLabel";
            this.lastMonthExpenseLabel.Size = new System.Drawing.Size(73, 15);
            this.lastMonthExpenseLabel.TabIndex = 1;
            this.lastMonthExpenseLabel.Text = "Last Month: ";
            // 
            // ExpenseHeadinglabel
            // 
            this.ExpenseHeadinglabel.AutoSize = true;
            this.ExpenseHeadinglabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.ExpenseHeadinglabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExpenseHeadinglabel.Location = new System.Drawing.Point(18, 14);
            this.ExpenseHeadinglabel.Name = "ExpenseHeadinglabel";
            this.ExpenseHeadinglabel.Size = new System.Drawing.Size(232, 30);
            this.ExpenseHeadinglabel.TabIndex = 6;
            this.ExpenseHeadinglabel.Text = "Expense Management";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePicker.Location = new System.Drawing.Point(150, 120);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(350, 24);
            this.dateTimePicker.TabIndex = 4;
            // 
            // DiscriptionrichTextBox
            // 
            this.DiscriptionrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscriptionrichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscriptionrichTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.DiscriptionrichTextBox.Location = new System.Drawing.Point(550, 30);
            this.DiscriptionrichTextBox.Name = "DiscriptionrichTextBox";
            this.DiscriptionrichTextBox.Size = new System.Drawing.Size(440, 150);
            this.DiscriptionrichTextBox.TabIndex = 5;
            this.DiscriptionrichTextBox.Text = "";
            // 
            // ExpensetextBox
            // 
            this.ExpensetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpensetextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ExpensetextBox.Location = new System.Drawing.Point(150, 90);
            this.ExpensetextBox.Name = "ExpensetextBox";
            this.ExpensetextBox.Size = new System.Drawing.Size(350, 24);
            this.ExpensetextBox.TabIndex = 3;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ItemTextBox.Location = new System.Drawing.Point(150, 60);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(350, 24);
            this.ItemTextBox.TabIndex = 2;
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorycomboBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Location = new System.Drawing.Point(150, 30);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(350, 25);
            this.CategorycomboBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(60, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 40);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add New Income";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Discriptionlabel
            // 
            this.Discriptionlabel.AutoSize = true;
            this.Discriptionlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Discriptionlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Discriptionlabel.Location = new System.Drawing.Point(550, 10);
            this.Discriptionlabel.Name = "Discriptionlabel";
            this.Discriptionlabel.Size = new System.Drawing.Size(84, 19);
            this.Discriptionlabel.TabIndex = 7;
            this.Discriptionlabel.Text = "Description:";
            // 
            // Itemlabel
            // 
            this.Itemlabel.AutoSize = true;
            this.Itemlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Itemlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Itemlabel.Location = new System.Drawing.Point(20, 60);
            this.Itemlabel.Name = "Itemlabel";
            this.Itemlabel.Size = new System.Drawing.Size(40, 19);
            this.Itemlabel.TabIndex = 6;
            this.Itemlabel.Text = "Item:";
            // 
            // Expenselabel
            // 
            this.Expenselabel.AutoSize = true;
            this.Expenselabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Expenselabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Expenselabel.Location = new System.Drawing.Point(20, 90);
            this.Expenselabel.Name = "Expenselabel";
            this.Expenselabel.Size = new System.Drawing.Size(62, 19);
            this.Expenselabel.TabIndex = 5;
            this.Expenselabel.Text = "Expense:";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Datelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Datelabel.Location = new System.Drawing.Point(20, 120);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(41, 19);
            this.Datelabel.TabIndex = 4;
            this.Datelabel.Text = "Date:";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Categorylabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Categorylabel.Location = new System.Drawing.Point(20, 30);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(69, 19);
            this.Categorylabel.TabIndex = 3;
            this.Categorylabel.Text = "Category:";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(840, 15);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 40);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(580, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 40);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(320, 15);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(150, 40);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update Record";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.ClearButton);
            this.buttonsPanel.Controls.Add(this.DeleteButton);
            this.buttonsPanel.Controls.Add(this.UpdateButton);
            this.buttonsPanel.Controls.Add(this.AddButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(10, 220);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1004, 70);
            this.buttonsPanel.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.buttonsPanel);
            this.panel2.Controls.Add(this.inputPanel);
            this.panel2.Location = new System.Drawing.Point(23, 310);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1024, 300);
            this.panel2.TabIndex = 5;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.dateTimePicker);
            this.inputPanel.Controls.Add(this.DiscriptionrichTextBox);
            this.inputPanel.Controls.Add(this.ExpensetextBox);
            this.inputPanel.Controls.Add(this.ItemTextBox);
            this.inputPanel.Controls.Add(this.CategorycomboBox);
            this.inputPanel.Controls.Add(this.Discriptionlabel);
            this.inputPanel.Controls.Add(this.Itemlabel);
            this.inputPanel.Controls.Add(this.Expenselabel);
            this.inputPanel.Controls.Add(this.Datelabel);
            this.inputPanel.Controls.Add(this.Categorylabel);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(10, 10);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1004, 200);
            this.inputPanel.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(23, 74);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1024, 224);
            this.panel1.TabIndex = 4;
            // 
            // UCExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.ExpenseHeadinglabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCExpenseForm";
            this.Size = new System.Drawing.Size(1064, 624);
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label totalExpenseValue;
        private System.Windows.Forms.Label thisMonthExpenseLabel;
        private System.Windows.Forms.Label thisMonthExpenseValue;
        private System.Windows.Forms.Label lastMonthExpenseValue;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lastMonthExpenseLabel;
        private System.Windows.Forms.Label ExpenseHeadinglabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox DiscriptionrichTextBox;
        private System.Windows.Forms.TextBox ExpensetextBox;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Discriptionlabel;
        private System.Windows.Forms.Label Itemlabel;
        private System.Windows.Forms.Label Expenselabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}
