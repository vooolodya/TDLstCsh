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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CheckTaskStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImportantTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskField = new System.Windows.Forms.TextBox();
            this.AddTaskIntoGroupButton = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListOfLists)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(33, 116);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(311, 34);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.DGVListOfLists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListOfLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVListOfLists.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.DGVListOfLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListOfLists.ColumnHeadersVisible = false;
            this.DGVListOfLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTaskList,
            this.NameTasklist});
            this.DGVListOfLists.Location = new System.Drawing.Point(31, 181);
            this.DGVListOfLists.Name = "DGVListOfLists";
            this.DGVListOfLists.RowHeadersVisible = false;
            this.DGVListOfLists.RowHeadersWidth = 51;
            this.DGVListOfLists.RowTemplate.Height = 24;
            this.DGVListOfLists.Size = new System.Drawing.Size(353, 468);
            this.DGVListOfLists.TabIndex = 0;
            this.DGVListOfLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListOfLists_CellContentClick);
            // 
            // IDTaskList
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.IDTaskList.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDTaskList.HeaderText = "";
            this.IDTaskList.MaxInputLength = 32;
            this.IDTaskList.MinimumWidth = 8;
            this.IDTaskList.Name = "IDTaskList";
            this.IDTaskList.Visible = false;
            this.IDTaskList.Width = 150;
            // 
            // NameTasklist
            // 
            this.NameTasklist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CadetBlue;
            this.NameTasklist.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameTasklist.HeaderText = "";
            this.NameTasklist.MaxInputLength = 50;
            this.NameTasklist.MinimumWidth = 8;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListTasks.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVListTasks.Location = new System.Drawing.Point(49, 116);
            this.DGVListTasks.Name = "DGVListTasks";
            this.DGVListTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVListTasks.RowHeadersVisible = false;
            this.DGVListTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVListTasks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListTasks.RowTemplate.Height = 24;
            this.DGVListTasks.Size = new System.Drawing.Size(892, 533);
            this.DGVListTasks.TabIndex = 0;
            this.DGVListTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVListTasks_KeyDown);
            // 
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
            this.isImportantTask.Width = 45;
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
            this.NameField.Size = new System.Drawing.Size(139, 29);
            this.NameField.TabIndex = 7;
            this.NameField.Text = "Cgbcj pfdlfx";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.AddTaskIntoGroupButton);
            this.panel1.Controls.Add(this.DGVListTasks);
            this.panel1.Controls.Add(this.TaskField);
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 760);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1380, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn isImportantTask;
    }
}

