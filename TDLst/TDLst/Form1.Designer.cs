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
            this.SearchField = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NickNameDisplay = new System.Windows.Forms.Label();
            this.LoginDisplay = new System.Windows.Forms.Label();
            this.NewTaskListNameField = new System.Windows.Forms.TextBox();
            this.ListTaskButton = new System.Windows.Forms.Label();
            this.ListsGridView = new System.Windows.Forms.DataGridView();
            this.IDTaskList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTasklist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.NewTaskListButton = new System.Windows.Forms.Label();
            this.TasksGridView = new System.Windows.Forms.DataGridView();
            this.NewTaskNameField = new System.Windows.Forms.TextBox();
            this.NewTaskButton = new System.Windows.Forms.Label();
            this.NameListDisplay = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CheckTaskStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImportantTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListsGridView)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.Location = new System.Drawing.Point(33, 116);
            this.SearchField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(311, 34);
            this.SearchField.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(350, 116);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(34, 34);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NickNameDisplay
            // 
            this.NickNameDisplay.AutoSize = true;
            this.NickNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NickNameDisplay.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.NickNameDisplay.Location = new System.Drawing.Point(26, 21);
            this.NickNameDisplay.Name = "NickNameDisplay";
            this.NickNameDisplay.Size = new System.Drawing.Size(226, 29);
            this.NickNameDisplay.TabIndex = 2;
            this.NickNameDisplay.Text = "Крокозябра бебра";
            // 
            // LoginDisplay
            // 
            this.LoginDisplay.AutoSize = true;
            this.LoginDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginDisplay.ForeColor = System.Drawing.Color.LightBlue;
            this.LoginDisplay.Location = new System.Drawing.Point(39, 65);
            this.LoginDisplay.Name = "LoginDisplay";
            this.LoginDisplay.Size = new System.Drawing.Size(203, 25);
            this.LoginDisplay.TabIndex = 3;
            this.LoginDisplay.Text = "milo&&milo@gmail.com";
            // 
            // NewTaskListNameField
            // 
            this.NewTaskListNameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewTaskListNameField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NewTaskListNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewTaskListNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTaskListNameField.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewTaskListNameField.Location = new System.Drawing.Point(33, 672);
            this.NewTaskListNameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTaskListNameField.Name = "NewTaskListNameField";
            this.NewTaskListNameField.Size = new System.Drawing.Size(351, 34);
            this.NewTaskListNameField.TabIndex = 5;
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
            // ListsGridView
            // 
            this.ListsGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ListsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListsGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.ListsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListsGridView.ColumnHeadersVisible = false;
            this.ListsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTaskList,
            this.NameTasklist});
            this.ListsGridView.Location = new System.Drawing.Point(31, 181);
            this.ListsGridView.Name = "ListsGridView";
            this.ListsGridView.RowHeadersVisible = false;
            this.ListsGridView.RowHeadersWidth = 51;
            this.ListsGridView.RowTemplate.Height = 24;
            this.ListsGridView.Size = new System.Drawing.Size(353, 468);
            this.ListsGridView.TabIndex = 0;
            this.ListsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsGridView_CellContentClick);
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
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MenuPanel.Controls.Add(this.NewTaskListButton);
            this.MenuPanel.Controls.Add(this.ListsGridView);
            this.MenuPanel.Controls.Add(this.ListTaskButton);
            this.MenuPanel.Controls.Add(this.NewTaskListNameField);
            this.MenuPanel.Controls.Add(this.LoginDisplay);
            this.MenuPanel.Controls.Add(this.NickNameDisplay);
            this.MenuPanel.Controls.Add(this.SearchButton);
            this.MenuPanel.Controls.Add(this.SearchField);
            this.MenuPanel.Location = new System.Drawing.Point(1, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(410, 760);
            this.MenuPanel.TabIndex = 0;
            // 
            // NewTaskListButton
            // 
            this.NewTaskListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTaskListButton.AutoSize = true;
            this.NewTaskListButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NewTaskListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTaskListButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewTaskListButton.Location = new System.Drawing.Point(345, 675);
            this.NewTaskListButton.Name = "NewTaskListButton";
            this.NewTaskListButton.Size = new System.Drawing.Size(27, 29);
            this.NewTaskListButton.TabIndex = 8;
            this.NewTaskListButton.Text = "+";
            this.NewTaskListButton.Click += new System.EventHandler(this.NewTaskListButton_Click);
            // 
            // TasksGridView
            // 
            this.TasksGridView.AllowUserToAddRows = false;
            this.TasksGridView.AllowUserToDeleteRows = false;
            this.TasksGridView.AllowUserToResizeColumns = false;
            this.TasksGridView.AllowUserToResizeRows = false;
            this.TasksGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.TasksGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TasksGridView.ColumnHeadersHeight = 29;
            this.TasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TasksGridView.ColumnHeadersVisible = false;
            this.TasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.TasksGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.TasksGridView.Location = new System.Drawing.Point(49, 116);
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TasksGridView.RowHeadersVisible = false;
            this.TasksGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TasksGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TasksGridView.RowTemplate.Height = 24;
            this.TasksGridView.Size = new System.Drawing.Size(892, 533);
            this.TasksGridView.TabIndex = 0;
            // 
            // NewTaskNameField
            // 
            this.NewTaskNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTaskNameField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NewTaskNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewTaskNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTaskNameField.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewTaskNameField.Location = new System.Drawing.Point(39, 670);
            this.NewTaskNameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTaskNameField.Name = "NewTaskNameField";
            this.NewTaskNameField.Size = new System.Drawing.Size(902, 34);
            this.NewTaskNameField.TabIndex = 4;
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTaskButton.AutoSize = true;
            this.NewTaskButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NewTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTaskButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewTaskButton.Location = new System.Drawing.Point(900, 672);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(27, 29);
            this.NewTaskButton.TabIndex = 7;
            this.NewTaskButton.Text = "+";
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // NameListDisplay
            // 
            this.NameListDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameListDisplay.AutoSize = true;
            this.NameListDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameListDisplay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameListDisplay.Location = new System.Drawing.Point(56, 61);
            this.NameListDisplay.Name = "NameListDisplay";
            this.NameListDisplay.Size = new System.Drawing.Size(139, 29);
            this.NameListDisplay.TabIndex = 7;
            this.NameListDisplay.Text = "Cgbcj pfdlfx";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.MainPanel.Controls.Add(this.NameListDisplay);
            this.MainPanel.Controls.Add(this.NewTaskButton);
            this.MainPanel.Controls.Add(this.TasksGridView);
            this.MainPanel.Controls.Add(this.NewTaskNameField);
            this.MainPanel.Location = new System.Drawing.Point(408, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(974, 760);
            this.MainPanel.TabIndex = 1;
            // 
            // CheckTaskStatus
            // 
            this.CheckTaskStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckTaskStatus.FillWeight = 79.24468F;
            this.CheckTaskStatus.HeaderText = "";
            this.CheckTaskStatus.MinimumWidth = 15;
            this.CheckTaskStatus.Name = "CheckTaskStatus";
            this.CheckTaskStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1380, 756);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuPanel);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "To-Do list";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListsGridView)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label NickNameDisplay;
        private System.Windows.Forms.Label LoginDisplay;
        private System.Windows.Forms.TextBox NewTaskListNameField;
        private System.Windows.Forms.Label ListTaskButton;
        private System.Windows.Forms.DataGridView ListsGridView;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.DataGridView TasksGridView;
        private System.Windows.Forms.TextBox NewTaskNameField;
        private System.Windows.Forms.Label NewTaskButton;
        private System.Windows.Forms.Label NameListDisplay;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label NewTaskListButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTasklist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isImportantTask;
    }
}

