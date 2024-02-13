namespace TDLst
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< Updated upstream
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmailField = new System.Windows.Forms.Label();
            this.FlnField = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.searchField = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.NicknameField = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.Label();
            this.ListTaskField = new System.Windows.Forms.TextBox();
            this.ListTaskButton = new System.Windows.Forms.Label();
            this.DGVListOfLists = new System.Windows.Forms.DataGridView();
            this.IDTaskList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTasklist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.AddListTaskButton = new System.Windows.Forms.Label();
            this.DGVListTasks = new System.Windows.Forms.DataGridView();
            this.TaskField = new System.Windows.Forms.TextBox();
            this.AddTaskIntoGroupButton = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< Updated upstream
=======
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
>>>>>>> Stashed changes
            this.CheckTaskStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImportantTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListOfLists)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< Updated upstream
=======
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.textBox2);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Controls.Add(this.EmailField);
            this.menuPanel.Controls.Add(this.FlnField);
            this.menuPanel.Controls.Add(this.buttonSearch);
            this.menuPanel.Controls.Add(this.searchField);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(416, 865);
            this.menuPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(348, 762);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox2.Location = new System.Drawing.Point(24, 759);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 39);
            this.textBox2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Location = new System.Drawing.Point(24, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 505);
            this.panel2.TabIndex = 4;
            // 
            // EmailField
            // 
            this.EmailField.AutoSize = true;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.ForeColor = System.Drawing.Color.LightBlue;
            this.EmailField.Location = new System.Drawing.Point(18, 89);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(256, 29);
            this.EmailField.TabIndex = 3;
            this.EmailField.Text = "milo&&milo@gmail.com";
            // 
            // FlnField
            // 
            this.FlnField.AutoSize = true;
            this.FlnField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlnField.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.FlnField.Location = new System.Drawing.Point(18, 54);
            this.FlnField.Name = "FlnField";
            this.FlnField.Size = new System.Drawing.Size(259, 32);
            this.FlnField.TabIndex = 2;
            this.FlnField.Text = "Крокозябра бебра";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSearch.Location = new System.Drawing.Point(353, 145);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(38, 42);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
>>>>>>> Stashed changes
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
<<<<<<< Updated upstream
            this.searchField.Location = new System.Drawing.Point(33, 116);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(311, 34);
=======
            this.searchField.Location = new System.Drawing.Point(24, 145);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(323, 39);
>>>>>>> Stashed changes
            this.searchField.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSearch.Location = new System.Drawing.Point(350, 116);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(34, 34);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // NicknameField
            // 
            this.NicknameField.AutoSize = true;
            this.NicknameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NicknameField.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.NicknameField.Location = new System.Drawing.Point(26, 21);
            this.NicknameField.Name = "NicknameField";
            this.NicknameField.Size = new System.Drawing.Size(226, 29);
            this.NicknameField.TabIndex = 2;
            this.NicknameField.Text = "Крокозябра бебра";
            // 
            // EmailField
            // 
            this.EmailField.AutoSize = true;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.ForeColor = System.Drawing.Color.LightBlue;
            this.EmailField.Location = new System.Drawing.Point(39, 65);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(203, 25);
            this.EmailField.TabIndex = 3;
            this.EmailField.Text = "milo&&milo@gmail.com";
            // 
            // ListTaskField
            // 
            this.ListTaskField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListTaskField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ListTaskField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListTaskField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListTaskField.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ListTaskField.Location = new System.Drawing.Point(33, 672);
            this.ListTaskField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListTaskField.Name = "ListTaskField";
            this.ListTaskField.Size = new System.Drawing.Size(351, 34);
            this.ListTaskField.TabIndex = 5;
            // 
            // ListTaskButton
            // 
            this.ListTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListTaskButton.AutoSize = true;
            this.ListTaskButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ListTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListTaskButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ListTaskButton.Location = new System.Drawing.Point(372, 823);
            this.ListTaskButton.Name = "ListTaskButton";
            this.ListTaskButton.Size = new System.Drawing.Size(27, 29);
            this.ListTaskButton.TabIndex = 6;
            this.ListTaskButton.Text = "+";
            // 
            // DGVListOfLists
            // 
            this.DGVListOfLists.AllowUserToAddRows = false;
            this.DGVListOfLists.AllowUserToDeleteRows = false;
            this.DGVListOfLists.AllowUserToResizeColumns = false;
            this.DGVListOfLists.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CadetBlue;
            this.DGVListOfLists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListOfLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVListOfLists.BackgroundColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListOfLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListOfLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListOfLists.ColumnHeadersVisible = false;
            this.DGVListOfLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTaskList,
            this.NameTasklist});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListOfLists.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListOfLists.Location = new System.Drawing.Point(31, 181);
            this.DGVListOfLists.Name = "DGVListOfLists";
            this.DGVListOfLists.RowHeadersVisible = false;
            this.DGVListOfLists.RowHeadersWidth = 51;
            this.DGVListOfLists.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DGVListOfLists.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.DGVListOfLists.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.CadetBlue;
            this.DGVListOfLists.RowTemplate.Height = 30;
            this.DGVListOfLists.Size = new System.Drawing.Size(353, 468);
            this.DGVListOfLists.TabIndex = 0;
            this.DGVListOfLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListOfLists_CellContentClick);
            // 
            // IDTaskList
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.IDTaskList.DefaultCellStyle = dataGridViewCellStyle3;
            this.IDTaskList.HeaderText = "";
            this.IDTaskList.MaxInputLength = 32;
            this.IDTaskList.MinimumWidth = 15;
            this.IDTaskList.Name = "IDTaskList";
            this.IDTaskList.Visible = false;
            this.IDTaskList.Width = 150;
            // 
            // NameTasklist
            // 
            this.NameTasklist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.CadetBlue;
            this.NameTasklist.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameTasklist.HeaderText = "";
            this.NameTasklist.MaxInputLength = 50;
            this.NameTasklist.MinimumWidth = 15;
            this.NameTasklist.Name = "NameTasklist";
            this.NameTasklist.ReadOnly = true;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuPanel.Controls.Add(this.AddListTaskButton);
            this.menuPanel.Controls.Add(this.DGVListOfLists);
            this.menuPanel.Controls.Add(this.ListTaskButton);
            this.menuPanel.Controls.Add(this.ListTaskField);
            this.menuPanel.Controls.Add(this.EmailField);
            this.menuPanel.Controls.Add(this.NicknameField);
            this.menuPanel.Controls.Add(this.buttonSearch);
            this.menuPanel.Controls.Add(this.searchField);
            this.menuPanel.Location = new System.Drawing.Point(1, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(410, 760);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Click += new System.EventHandler(this.menuPanel_Click);
            // 
            // AddListTaskButton
            // 
            this.AddListTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddListTaskButton.AutoSize = true;
            this.AddListTaskButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddListTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddListTaskButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddListTaskButton.Location = new System.Drawing.Point(345, 675);
            this.AddListTaskButton.Name = "AddListTaskButton";
            this.AddListTaskButton.Size = new System.Drawing.Size(27, 29);
            this.AddListTaskButton.TabIndex = 8;
            this.AddListTaskButton.Text = "+";
            this.AddListTaskButton.Click += new System.EventHandler(this.AddListTaskButton_Click);
            // 
            // DGVListTasks
            // 
            this.DGVListTasks.AllowUserToAddRows = false;
            this.DGVListTasks.AllowUserToDeleteRows = false;
            this.DGVListTasks.AllowUserToResizeColumns = false;
            this.DGVListTasks.AllowUserToResizeRows = false;
            this.DGVListTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListTasks.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.DGVListTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVListTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVListTasks.ColumnHeadersHeight = 29;
            this.DGVListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVListTasks.ColumnHeadersVisible = false;
            this.DGVListTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckTaskStatus,
            this.TaskText,
            this.isImportantTask});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListTasks.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVListTasks.Location = new System.Drawing.Point(49, 116);
            this.DGVListTasks.Name = "DGVListTasks";
            this.DGVListTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVListTasks.RowHeadersVisible = false;
            this.DGVListTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVListTasks.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVListTasks.RowTemplate.Height = 24;
            this.DGVListTasks.Size = new System.Drawing.Size(892, 533);
            this.DGVListTasks.TabIndex = 0;
            // 
            // TaskField
            // 
            this.TaskField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TaskField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskField.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TaskField.Location = new System.Drawing.Point(39, 670);
            this.TaskField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskField.Name = "TaskField";
            this.TaskField.Size = new System.Drawing.Size(902, 34);
            this.TaskField.TabIndex = 4;
            // 
            // AddTaskIntoGroupButton
            // 
            this.AddTaskIntoGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaskIntoGroupButton.AutoSize = true;
            this.AddTaskIntoGroupButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddTaskIntoGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskIntoGroupButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddTaskIntoGroupButton.Location = new System.Drawing.Point(900, 672);
            this.AddTaskIntoGroupButton.Name = "AddTaskIntoGroupButton";
            this.AddTaskIntoGroupButton.Size = new System.Drawing.Size(27, 29);
            this.AddTaskIntoGroupButton.TabIndex = 7;
            this.AddTaskIntoGroupButton.Text = "+";
            this.AddTaskIntoGroupButton.Click += new System.EventHandler(this.AddTaskIntoGroupButton_Click);
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameField.AutoSize = true;
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameField.Location = new System.Drawing.Point(56, 61);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(103, 29);
            this.NameField.TabIndex = 7;
            this.NameField.Text = "TaskList";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
<<<<<<< Updated upstream
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.AddTaskIntoGroupButton);
            this.panel1.Controls.Add(this.DGVListTasks);
            this.panel1.Controls.Add(this.TaskField);
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 760);
            this.panel1.TabIndex = 1;
            // 
=======
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(416, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 865);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(50, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cgbcj pfdlfx";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(793, 759);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(44, 756);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(790, 39);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckTaskStatus,
            this.TaskText,
            this.isImportantTask});
            this.dataGridView.Location = new System.Drawing.Point(44, 89);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(790, 642);
            this.dataGridView.TabIndex = 0;
            // 
>>>>>>> Stashed changes
            // CheckTaskStatus
            // 
            this.CheckTaskStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckTaskStatus.FillWeight = 79.24468F;
            this.CheckTaskStatus.HeaderText = "";
            this.CheckTaskStatus.MinimumWidth = 15;
            this.CheckTaskStatus.Name = "CheckTaskStatus";
            this.CheckTaskStatus.Width = 25;
            // 
            // TaskText
            // 
            this.TaskText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskText.FillWeight = 180.6483F;
            this.TaskText.HeaderText = "";
            this.TaskText.MaxInputLength = 32;
            this.TaskText.MinimumWidth = 6;
            this.TaskText.Name = "TaskText";
            // 
            // isImportantTask
            // 
            this.isImportantTask.FillWeight = 40.10695F;
            this.isImportantTask.HeaderText = "";
            this.isImportantTask.MinimumWidth = 6;
            this.isImportantTask.Name = "isImportantTask";
            this.isImportantTask.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isImportantTask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isImportantTask.Width = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(1380, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.ClientSize = new System.Drawing.Size(1287, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
>>>>>>> Stashed changes
            this.Name = "Form1";
            this.Text = "To-Do list";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListOfLists)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label NicknameField;
        private System.Windows.Forms.Label EmailField;
        private System.Windows.Forms.TextBox ListTaskField;
        private System.Windows.Forms.Label ListTaskButton;
        private System.Windows.Forms.DataGridView DGVListOfLists;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.DataGridView DGVListTasks;
        private System.Windows.Forms.TextBox TaskField;
        private System.Windows.Forms.Label AddTaskIntoGroupButton;
        private System.Windows.Forms.Label NameField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddListTaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTasklist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskText;
        private System.Windows.Forms.DataGridViewTextBoxColumn isImportantTask;
    }
}

