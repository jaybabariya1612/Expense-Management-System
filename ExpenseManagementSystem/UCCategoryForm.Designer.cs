//namespace ExpenseManagementSystem
//{
//    partial class UCCategoryForm
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.ClearButton = new System.Windows.Forms.Button();
//            this.DeleteButton = new System.Windows.Forms.Button();
//            this.UpdateButton = new System.Windows.Forms.Button();
//            this.AddButton = new System.Windows.Forms.Button();
//            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
//            this.StatusLabel = new System.Windows.Forms.Label();
//            this.TypecomboBox = new System.Windows.Forms.ComboBox();
//            this.CategorytextBox = new System.Windows.Forms.TextBox();
//            this.TypeLabel = new System.Windows.Forms.Label();
//            this.CategoryLabel = new System.Windows.Forms.Label();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.CategoryListLabel = new System.Windows.Forms.Label();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
//            this.panel1.SuspendLayout();
//            this.panel2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.White;
//            this.panel1.Controls.Add(this.ClearButton);
//            this.panel1.Controls.Add(this.DeleteButton);
//            this.panel1.Controls.Add(this.UpdateButton);
//            this.panel1.Controls.Add(this.AddButton);
//            this.panel1.Controls.Add(this.StatuscomboBox);
//            this.panel1.Controls.Add(this.StatusLabel);
//            this.panel1.Controls.Add(this.TypecomboBox);
//            this.panel1.Controls.Add(this.CategorytextBox);
//            this.panel1.Controls.Add(this.TypeLabel);
//            this.panel1.Controls.Add(this.CategoryLabel);
//            this.panel1.Location = new System.Drawing.Point(22, 21);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(241, 585);
//            this.panel1.TabIndex = 0;
//            // 
//            // ClearButton
//            // 
//            this.ClearButton.Location = new System.Drawing.Point(118, 247);
//            this.ClearButton.Name = "ClearButton";
//            this.ClearButton.Size = new System.Drawing.Size(95, 45);
//            this.ClearButton.TabIndex = 6;
//            this.ClearButton.Text = "Clear";
//            this.ClearButton.UseVisualStyleBackColor = true;
//            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
//            // 
//            // DeleteButton
//            // 
//            this.DeleteButton.Location = new System.Drawing.Point(17, 247);
//            this.DeleteButton.Name = "DeleteButton";
//            this.DeleteButton.Size = new System.Drawing.Size(95, 45);
//            this.DeleteButton.TabIndex = 5;
//            this.DeleteButton.Text = "Delete";
//            this.DeleteButton.UseVisualStyleBackColor = true;
//            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
//            // 
//            // UpdateButton
//            // 
//            this.UpdateButton.Location = new System.Drawing.Point(118, 196);
//            this.UpdateButton.Name = "UpdateButton";
//            this.UpdateButton.Size = new System.Drawing.Size(95, 45);
//            this.UpdateButton.TabIndex = 4;
//            this.UpdateButton.Text = "Update";
//            this.UpdateButton.UseVisualStyleBackColor = true;
//            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
//            // 
//            // AddButton
//            // 
//            this.AddButton.Location = new System.Drawing.Point(17, 196);
//            this.AddButton.Name = "AddButton";
//            this.AddButton.Size = new System.Drawing.Size(95, 45);
//            this.AddButton.TabIndex = 0;
//            this.AddButton.Text = "Add";
//            this.AddButton.UseVisualStyleBackColor = true;
//            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
//            // 
//            // StatuscomboBox
//            // 
//            this.StatuscomboBox.FormattingEnabled = true;
//            this.StatuscomboBox.Items.AddRange(new object[] {
//            "Active",
//            "InActive"});
//            this.StatuscomboBox.Location = new System.Drawing.Point(17, 157);
//            this.StatuscomboBox.Name = "StatuscomboBox";
//            this.StatuscomboBox.Size = new System.Drawing.Size(208, 21);
//            this.StatuscomboBox.TabIndex = 2;
//            // 
//            // StatusLabel
//            // 
//            this.StatusLabel.AutoSize = true;
//            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.StatusLabel.Location = new System.Drawing.Point(12, 129);
//            this.StatusLabel.Name = "StatusLabel";
//            this.StatusLabel.Size = new System.Drawing.Size(74, 25);
//            this.StatusLabel.TabIndex = 3;
//            this.StatusLabel.Text = "Status";
//            // 
//            // TypecomboBox
//            // 
//            this.TypecomboBox.FormattingEnabled = true;
//            this.TypecomboBox.Items.AddRange(new object[] {
//            "Income",
//            "Expense"});
//            this.TypecomboBox.Location = new System.Drawing.Point(17, 95);
//            this.TypecomboBox.Name = "TypecomboBox";
//            this.TypecomboBox.Size = new System.Drawing.Size(208, 21);
//            this.TypecomboBox.TabIndex = 0;
//            // 
//            // CategorytextBox
//            // 
//            this.CategorytextBox.Location = new System.Drawing.Point(17, 39);
//            this.CategorytextBox.Name = "CategorytextBox";
//            this.CategorytextBox.Size = new System.Drawing.Size(208, 20);
//            this.CategorytextBox.TabIndex = 0;
//            // 
//            // TypeLabel
//            // 
//            this.TypeLabel.AutoSize = true;
//            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TypeLabel.Location = new System.Drawing.Point(12, 67);
//            this.TypeLabel.Name = "TypeLabel";
//            this.TypeLabel.Size = new System.Drawing.Size(61, 25);
//            this.TypeLabel.TabIndex = 1;
//            this.TypeLabel.Text = "Type";
//            // 
//            // CategoryLabel
//            // 
//            this.CategoryLabel.AutoSize = true;
//            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.CategoryLabel.Location = new System.Drawing.Point(12, 11);
//            this.CategoryLabel.Name = "CategoryLabel";
//            this.CategoryLabel.Size = new System.Drawing.Size(100, 25);
//            this.CategoryLabel.TabIndex = 0;
//            this.CategoryLabel.Text = "Category";
//            // 
//            // panel2
//            // 
//            this.panel2.BackColor = System.Drawing.Color.White;
//            this.panel2.Controls.Add(this.CategoryListLabel);
//            this.panel2.Controls.Add(this.dataGridView1);
//            this.panel2.Location = new System.Drawing.Point(302, 21);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(736, 585);
//            this.panel2.TabIndex = 1;
//            // 
//            // CategoryListLabel
//            // 
//            this.CategoryListLabel.AutoSize = true;
//            this.CategoryListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.CategoryListLabel.Location = new System.Drawing.Point(330, 2);
//            this.CategoryListLabel.Name = "CategoryListLabel";
//            this.CategoryListLabel.Size = new System.Drawing.Size(140, 25);
//            this.CategoryListLabel.TabIndex = 1;
//            this.CategoryListLabel.Text = "Category List";
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lime;
//            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
//            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
//            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowHeadersVisible = false;
//            this.dataGridView1.Size = new System.Drawing.Size(730, 414);
//            this.dataGridView1.TabIndex = 0;
//            // 
//            // contextMenuStrip1
//            // 
//            this.contextMenuStrip1.Name = "contextMenuStrip1";
//            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
//            // 
//            // UCCategoryForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.panel2);
//            this.Controls.Add(this.panel1);
//            this.Name = "UCCategoryForm";
//            this.Size = new System.Drawing.Size(1064, 624);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.panel2.ResumeLayout(false);
//            this.panel2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Panel panel2;
//        private System.Windows.Forms.Label CategoryLabel;
//        private System.Windows.Forms.Label TypeLabel;
//        private System.Windows.Forms.TextBox CategorytextBox;
//        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
//        private System.Windows.Forms.ComboBox TypecomboBox;
//        private System.Windows.Forms.ComboBox StatuscomboBox;
//        private System.Windows.Forms.Label StatusLabel;
//        private System.Windows.Forms.Button AddButton;
//        private System.Windows.Forms.Button UpdateButton;
//        private System.Windows.Forms.Button DeleteButton;
//        private System.Windows.Forms.Button ClearButton;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Label CategoryListLabel;
//    }
//}




//namespace ExpenseManagementSystem
//{
//    partial class UCCategoryForm
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.ClearButton = new System.Windows.Forms.Button();
//            this.DeleteButton = new System.Windows.Forms.Button();
//            this.UpdateButton = new System.Windows.Forms.Button();
//            this.AddButton = new System.Windows.Forms.Button();
//            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
//            this.StatusLabel = new System.Windows.Forms.Label();
//            this.TypecomboBox = new System.Windows.Forms.ComboBox();
//            this.CategorytextBox = new System.Windows.Forms.TextBox();
//            this.TypeLabel = new System.Windows.Forms.Label();
//            this.CategoryLabel = new System.Windows.Forms.Label();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.CategoryListLabel = new System.Windows.Forms.Label();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
//            this.panel1.SuspendLayout();
//            this.panel2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
//            this.panel1.Controls.Add(this.ClearButton);
//            this.panel1.Controls.Add(this.DeleteButton);
//            this.panel1.Controls.Add(this.UpdateButton);
//            this.panel1.Controls.Add(this.AddButton);
//            this.panel1.Controls.Add(this.StatuscomboBox);
//            this.panel1.Controls.Add(this.StatusLabel);
//            this.panel1.Controls.Add(this.TypecomboBox);
//            this.panel1.Controls.Add(this.CategorytextBox);
//            this.panel1.Controls.Add(this.TypeLabel);
//            this.panel1.Controls.Add(this.CategoryLabel);
//            this.panel1.Location = new System.Drawing.Point(22, 21);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(241, 585);
//            this.panel1.TabIndex = 0;
//            // 
//            // ClearButton
//            // 
//            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
//            this.ClearButton.FlatAppearance.BorderSize = 0;
//            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.ClearButton.ForeColor = System.Drawing.Color.White;
//            this.ClearButton.Location = new System.Drawing.Point(118, 247);
//            this.ClearButton.Name = "ClearButton";
//            this.ClearButton.Size = new System.Drawing.Size(95, 45);
//            this.ClearButton.TabIndex = 6;
//            this.ClearButton.Text = "Clear";
//            this.ClearButton.UseVisualStyleBackColor = false;
//            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
//            // 
//            // DeleteButton
//            // 
//            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
//            this.DeleteButton.FlatAppearance.BorderSize = 0;
//            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.DeleteButton.ForeColor = System.Drawing.Color.White;
//            this.DeleteButton.Location = new System.Drawing.Point(17, 247);
//            this.DeleteButton.Name = "DeleteButton";
//            this.DeleteButton.Size = new System.Drawing.Size(95, 45);
//            this.DeleteButton.TabIndex = 5;
//            this.DeleteButton.Text = "Delete";
//            this.DeleteButton.UseVisualStyleBackColor = false;
//            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
//            // 
//            // UpdateButton
//            // 
//            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
//            this.UpdateButton.FlatAppearance.BorderSize = 0;
//            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.UpdateButton.ForeColor = System.Drawing.Color.White;
//            this.UpdateButton.Location = new System.Drawing.Point(118, 196);
//            this.UpdateButton.Name = "UpdateButton";
//            this.UpdateButton.Size = new System.Drawing.Size(95, 45);
//            this.UpdateButton.TabIndex = 4;
//            this.UpdateButton.Text = "Update";
//            this.UpdateButton.UseVisualStyleBackColor = false;
//            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
//            // 
//            // AddButton
//            // 
//            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
//            this.AddButton.FlatAppearance.BorderSize = 0;
//            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.AddButton.ForeColor = System.Drawing.Color.White;
//            this.AddButton.Location = new System.Drawing.Point(17, 196);
//            this.AddButton.Name = "AddButton";
//            this.AddButton.Size = new System.Drawing.Size(95, 45);
//            this.AddButton.TabIndex = 0;
//            this.AddButton.Text = "Add";
//            this.AddButton.UseVisualStyleBackColor = false;
//            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
//            // 
//            // StatuscomboBox
//            // 
//            this.StatuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.StatuscomboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.StatuscomboBox.FormattingEnabled = true;
//            this.StatuscomboBox.Items.AddRange(new object[] {
//            "Active",
//            "InActive"});
//            this.StatuscomboBox.Location = new System.Drawing.Point(17, 157);
//            this.StatuscomboBox.Name = "StatuscomboBox";
//            this.StatuscomboBox.Size = new System.Drawing.Size(208, 23);
//            this.StatuscomboBox.TabIndex = 2;
//            // 
//            // StatusLabel
//            // 
//            this.StatusLabel.AutoSize = true;
//            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.StatusLabel.Location = new System.Drawing.Point(13, 133);
//            this.StatusLabel.Name = "StatusLabel";
//            this.StatusLabel.Size = new System.Drawing.Size(55, 21);
//            this.StatusLabel.TabIndex = 3;
//            this.StatusLabel.Text = "Status";
//            // 
//            // TypecomboBox
//            // 
//            this.TypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.TypecomboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TypecomboBox.FormattingEnabled = true;
//            this.TypecomboBox.Items.AddRange(new object[] {
//            "Income",
//            "Expense"});
//            this.TypecomboBox.Location = new System.Drawing.Point(17, 95);
//            this.TypecomboBox.Name = "TypecomboBox";
//            this.TypecomboBox.Size = new System.Drawing.Size(208, 23);
//            this.TypecomboBox.TabIndex = 0;
//            // 
//            // CategorytextBox
//            // 
//            this.CategorytextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.CategorytextBox.Location = new System.Drawing.Point(17, 39);
//            this.CategorytextBox.Name = "CategorytextBox";
//            this.CategorytextBox.Size = new System.Drawing.Size(208, 23);
//            this.CategorytextBox.TabIndex = 0;
//            // 
//            // TypeLabel
//            // 
//            this.TypeLabel.AutoSize = true;
//            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.TypeLabel.Location = new System.Drawing.Point(13, 71);
//            this.TypeLabel.Name = "TypeLabel";
//            this.TypeLabel.Size = new System.Drawing.Size(45, 21);
//            this.TypeLabel.TabIndex = 1;
//            this.TypeLabel.Text = "Type";
//            // 
//            // CategoryLabel
//            // 
//            this.CategoryLabel.AutoSize = true;
//            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
//            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.CategoryLabel.Location = new System.Drawing.Point(13, 11);
//            this.CategoryLabel.Name = "CategoryLabel";
//            this.CategoryLabel.Size = new System.Drawing.Size(91, 25);
//            this.CategoryLabel.TabIndex = 0;
//            this.CategoryLabel.Text = "Category";
//            // 
//            // panel2
//            // 
//            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
//            this.panel2.Controls.Add(this.CategoryListLabel);
//            this.panel2.Controls.Add(this.dataGridView1);
//            this.panel2.Location = new System.Drawing.Point(302, 21);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(736, 585);
//            this.panel2.TabIndex = 1;
//            // 
//            // CategoryListLabel
//            // 
//            this.CategoryListLabel.AutoSize = true;
//            this.CategoryListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
//            this.CategoryListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.CategoryListLabel.Location = new System.Drawing.Point(298, 2);
//            this.CategoryListLabel.Name = "CategoryListLabel";
//            this.CategoryListLabel.Size = new System.Drawing.Size(125, 25);
//            this.CategoryListLabel.TabIndex = 1;
//            this.CategoryListLabel.Text = "Category List";
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
//            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
//            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
//            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
//            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
//            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
//            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
//            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
//            this.dataGridView1.ColumnHeadersHeight = 40;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
//            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
//            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
//            this.dataGridView1.EnableHeadersVisualStyles = false;
//            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            this.dataGridView1.RowHeadersVisible = false;
//            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
//            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
//            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
//            this.dataGridView1.RowTemplate.Height = 35;
//            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dataGridView1.Size = new System.Drawing.Size(730, 536);
//            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
//            // 
//            // contextMenuStrip1
//            // 
//            this.contextMenuStrip1.Name = "contextMenuStrip1";
//            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
//            // 
//            // UCCategoryForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.White;
//            this.Controls.Add(this.panel2);
//            this.Controls.Add(this.panel1);
//            this.Name = "UCCategoryForm";
//            this.Size = new System.Drawing.Size(1064, 624);
//            this.Load += new System.EventHandler(this.UCCategoryForm_Load);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.panel2.ResumeLayout(false);
//            this.panel2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Panel panel2;
//        private System.Windows.Forms.Label CategoryLabel;
//        private System.Windows.Forms.Label TypeLabel;
//        private System.Windows.Forms.TextBox CategorytextBox;
//        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
//        private System.Windows.Forms.ComboBox TypecomboBox;
//        private System.Windows.Forms.ComboBox StatuscomboBox;
//        private System.Windows.Forms.Label StatusLabel;
//        private System.Windows.Forms.Button AddButton;
//        private System.Windows.Forms.Button UpdateButton;
//        private System.Windows.Forms.Button DeleteButton;
//        private System.Windows.Forms.Button ClearButton;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Label CategoryListLabel;
//    }
//}

namespace ExpenseManagementSystem
{
    partial class UCCategoryForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.CategorytextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.TotalCaregoryCount = new System.Windows.Forms.Label();
            this.TotalCategoriesLabel = new System.Windows.Forms.Label();
            this.activeCategoriesLabel = new System.Windows.Forms.Label();
            this.activeCategoriesCount = new System.Windows.Forms.Label();
            this.incomeCategoriesLabel = new System.Windows.Forms.Label();
            this.incomeCategoriesCount = new System.Windows.Forms.Label();
            this.expenseCategoriesLabel = new System.Windows.Forms.Label();
            this.expenseCategoriesCount = new System.Windows.Forms.Label();
            this.CategoryListLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.inputPanel);
            this.panel1.Controls.Add(this.buttonsPanel);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(300, 584);
            this.panel1.TabIndex = 0;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.StatuscomboBox);
            this.inputPanel.Controls.Add(this.StatusLabel);
            this.inputPanel.Controls.Add(this.TypecomboBox);
            this.inputPanel.Controls.Add(this.CategorytextBox);
            this.inputPanel.Controls.Add(this.TypeLabel);
            this.inputPanel.Controls.Add(this.CategoryLabel);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(10, 10);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(280, 350);
            this.inputPanel.TabIndex = 7;
            // 
            // StatuscomboBox
            // 
            this.StatuscomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatuscomboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatuscomboBox.FormattingEnabled = true;
            this.StatuscomboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.StatuscomboBox.Location = new System.Drawing.Point(20, 220);
            this.StatuscomboBox.Name = "StatuscomboBox";
            this.StatuscomboBox.Size = new System.Drawing.Size(240, 25);
            this.StatuscomboBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusLabel.Location = new System.Drawing.Point(17, 200);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(50, 20);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status";
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypecomboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Items.AddRange(new object[] {
            "Expense",
            "Income"});
            this.TypecomboBox.Location = new System.Drawing.Point(20, 150);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(240, 25);
            this.TypecomboBox.TabIndex = 2;
            // 
            // CategorytextBox
            // 
            this.CategorytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorytextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CategorytextBox.Location = new System.Drawing.Point(20, 80);
            this.CategorytextBox.Name = "CategorytextBox";
            this.CategorytextBox.Size = new System.Drawing.Size(240, 25);
            this.CategorytextBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeLabel.Location = new System.Drawing.Point(17, 130);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(41, 20);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryLabel.Location = new System.Drawing.Point(15, 20);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(91, 25);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.ClearButton);
            this.buttonsPanel.Controls.Add(this.DeleteButton);
            this.buttonsPanel.Controls.Add(this.UpdateButton);
            this.buttonsPanel.Controls.Add(this.AddButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(10, 360);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(280, 214);
            this.buttonsPanel.TabIndex = 6;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(20, 150);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(240, 40);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(20, 100);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(240, 40);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(20, 50);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(240, 40);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update Category";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(20, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(240, 40);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add New Category";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.summaryPanel);
            this.panel2.Controls.Add(this.CategoryListLabel);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(340, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(704, 584);
            this.panel2.TabIndex = 1;
            // 
            // summaryPanel
            // 
            this.summaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryPanel.BackColor = System.Drawing.Color.White;
            this.summaryPanel.Controls.Add(this.TotalCaregoryCount);
            this.summaryPanel.Controls.Add(this.TotalCategoriesLabel);
            this.summaryPanel.Controls.Add(this.activeCategoriesLabel);
            this.summaryPanel.Controls.Add(this.activeCategoriesCount);
            this.summaryPanel.Controls.Add(this.incomeCategoriesLabel);
            this.summaryPanel.Controls.Add(this.incomeCategoriesCount);
            this.summaryPanel.Controls.Add(this.expenseCategoriesLabel);
            this.summaryPanel.Controls.Add(this.expenseCategoriesCount);
            this.summaryPanel.Location = new System.Drawing.Point(20, 450);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Padding = new System.Windows.Forms.Padding(10);
            this.summaryPanel.Size = new System.Drawing.Size(664, 114);
            this.summaryPanel.TabIndex = 2;
            // 
            // TotalCaregoryCount
            // 
            this.TotalCaregoryCount.AutoSize = true;
            this.TotalCaregoryCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TotalCaregoryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.TotalCaregoryCount.Location = new System.Drawing.Point(513, 45);
            this.TotalCaregoryCount.Name = "TotalCaregoryCount";
            this.TotalCaregoryCount.Size = new System.Drawing.Size(19, 21);
            this.TotalCaregoryCount.TabIndex = 7;
            this.TotalCaregoryCount.Text = "0";
            // 
            // TotalCategoriesLabel
            // 
            this.TotalCategoriesLabel.AutoSize = true;
            this.TotalCategoriesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TotalCategoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalCategoriesLabel.Location = new System.Drawing.Point(514, 20);
            this.TotalCategoriesLabel.Name = "TotalCategoriesLabel";
            this.TotalCategoriesLabel.Size = new System.Drawing.Size(94, 15);
            this.TotalCategoriesLabel.TabIndex = 6;
            this.TotalCategoriesLabel.Text = "Total Categories:";
            // 
            // activeCategoriesLabel
            // 
            this.activeCategoriesLabel.AutoSize = true;
            this.activeCategoriesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.activeCategoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.activeCategoriesLabel.Location = new System.Drawing.Point(358, 20);
            this.activeCategoriesLabel.Name = "activeCategoriesLabel";
            this.activeCategoriesLabel.Size = new System.Drawing.Size(101, 15);
            this.activeCategoriesLabel.TabIndex = 5;
            this.activeCategoriesLabel.Text = "Active Categories:";
            // 
            // activeCategoriesCount
            // 
            this.activeCategoriesCount.AutoSize = true;
            this.activeCategoriesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.activeCategoriesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.activeCategoriesCount.Location = new System.Drawing.Point(357, 45);
            this.activeCategoriesCount.Name = "activeCategoriesCount";
            this.activeCategoriesCount.Size = new System.Drawing.Size(19, 21);
            this.activeCategoriesCount.TabIndex = 4;
            this.activeCategoriesCount.Text = "0";
            // 
            // incomeCategoriesLabel
            // 
            this.incomeCategoriesLabel.AutoSize = true;
            this.incomeCategoriesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.incomeCategoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.incomeCategoriesLabel.Location = new System.Drawing.Point(183, 20);
            this.incomeCategoriesLabel.Name = "incomeCategoriesLabel";
            this.incomeCategoriesLabel.Size = new System.Drawing.Size(109, 15);
            this.incomeCategoriesLabel.TabIndex = 3;
            this.incomeCategoriesLabel.Text = "Income Categories:";
            // 
            // incomeCategoriesCount
            // 
            this.incomeCategoriesCount.AutoSize = true;
            this.incomeCategoriesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.incomeCategoriesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.incomeCategoriesCount.Location = new System.Drawing.Point(182, 45);
            this.incomeCategoriesCount.Name = "incomeCategoriesCount";
            this.incomeCategoriesCount.Size = new System.Drawing.Size(19, 21);
            this.incomeCategoriesCount.TabIndex = 2;
            this.incomeCategoriesCount.Text = "0";
            // 
            // expenseCategoriesLabel
            // 
            this.expenseCategoriesLabel.AutoSize = true;
            this.expenseCategoriesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.expenseCategoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expenseCategoriesLabel.Location = new System.Drawing.Point(20, 20);
            this.expenseCategoriesLabel.Name = "expenseCategoriesLabel";
            this.expenseCategoriesLabel.Size = new System.Drawing.Size(111, 15);
            this.expenseCategoriesLabel.TabIndex = 1;
            this.expenseCategoriesLabel.Text = "Expense Categories:";
            // 
            // expenseCategoriesCount
            // 
            this.expenseCategoriesCount.AutoSize = true;
            this.expenseCategoriesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.expenseCategoriesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.expenseCategoriesCount.Location = new System.Drawing.Point(20, 45);
            this.expenseCategoriesCount.Name = "expenseCategoriesCount";
            this.expenseCategoriesCount.Size = new System.Drawing.Size(19, 21);
            this.expenseCategoriesCount.TabIndex = 0;
            this.expenseCategoriesCount.Text = "0";
            // 
            // CategoryListLabel
            // 
            this.CategoryListLabel.AutoSize = true;
            this.CategoryListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.CategoryListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryListLabel.Location = new System.Drawing.Point(20, 20);
            this.CategoryListLabel.Name = "CategoryListLabel";
            this.CategoryListLabel.Size = new System.Drawing.Size(125, 25);
            this.CategoryListLabel.TabIndex = 1;
            this.CategoryListLabel.Text = "Category List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UCCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCCategoryForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1064, 624);
            this.Load += new System.EventHandler(this.UCCategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox CategorytextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.ComboBox StatuscomboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CategoryListLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label activeCategoriesLabel;
        private System.Windows.Forms.Label activeCategoriesCount;
        private System.Windows.Forms.Label incomeCategoriesLabel;
        private System.Windows.Forms.Label incomeCategoriesCount;
        private System.Windows.Forms.Label expenseCategoriesLabel;
        private System.Windows.Forms.Label expenseCategoriesCount;
        private System.Windows.Forms.Label TotalCaregoryCount;
        private System.Windows.Forms.Label TotalCategoriesLabel;
    }
}