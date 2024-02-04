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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.dGVListLists = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.Label();
            this.FlnField = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskField = new System.Windows.Forms.TextBox();
            this.dGVListTasks = new System.Windows.Forms.DataGridView();
            this.CheckTaskStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImportantTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListLists)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuPanel.Controls.Add(this.dGVListLists);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.textBox2);
            this.menuPanel.Controls.Add(this.EmailField);
            this.menuPanel.Controls.Add(this.FlnField);
            this.menuPanel.Controls.Add(this.buttonSearch);
            this.menuPanel.Controls.Add(this.searchField);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(370, 692);
            this.menuPanel.TabIndex = 0;
            // 
            // dGVListLists
            // 
            this.dGVListLists.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dGVListLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListLists.Location = new System.Drawing.Point(21, 181);
            this.dGVListLists.Name = "dGVListLists";
            this.dGVListLists.RowHeadersWidth = 51;
            this.dGVListLists.RowTemplate.Height = 24;
            this.dGVListLists.Size = new System.Drawing.Size(327, 404);
            this.dGVListLists.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(309, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox2.Location = new System.Drawing.Point(21, 607);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 34);
            this.textBox2.TabIndex = 5;
            // 
            // EmailField
            // 
            this.EmailField.AutoSize = true;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.ForeColor = System.Drawing.Color.LightBlue;
            this.EmailField.Location = new System.Drawing.Point(16, 71);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(203, 25);
            this.EmailField.TabIndex = 3;
            this.EmailField.Text = "milo&&milo@gmail.com";
            // 
            // FlnField
            // 
            this.FlnField.AutoSize = true;
            this.FlnField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlnField.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.FlnField.Location = new System.Drawing.Point(16, 43);
            this.FlnField.Name = "FlnField";
            this.FlnField.Size = new System.Drawing.Size(226, 29);
            this.FlnField.TabIndex = 2;
            this.FlnField.Text = "Крокозябра бебра";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSearch.Location = new System.Drawing.Point(314, 116);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(34, 34);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(21, 116);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(287, 34);
            this.searchField.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.taskField);
            this.panel1.Controls.Add(this.dGVListTasks);
            this.panel1.Location = new System.Drawing.Point(370, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 692);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(44, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
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
            this.label2.Location = new System.Drawing.Point(705, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // taskField
            // 
            this.taskField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskField.BackColor = System.Drawing.Color.PaleTurquoise;
            this.taskField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskField.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.taskField.Location = new System.Drawing.Point(39, 605);
            this.taskField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskField.Name = "taskField";
            this.taskField.Size = new System.Drawing.Size(702, 34);
            this.taskField.TabIndex = 4;
            // 
            // dGVListTasks
            // 
            this.dGVListTasks.AllowUserToAddRows = false;
            this.dGVListTasks.AllowUserToDeleteRows = false;
            this.dGVListTasks.AllowUserToResizeColumns = false;
            this.dGVListTasks.AllowUserToResizeRows = false;
            this.dGVListTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVListTasks.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dGVListTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVListTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVListTasks.ColumnHeadersHeight = 29;
            this.dGVListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVListTasks.ColumnHeadersVisible = false;
            this.dGVListTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckTaskStatus,
            this.TaskText,
            this.isImportantTask});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVListTasks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVListTasks.Location = new System.Drawing.Point(39, 71);
            this.dGVListTasks.Name = "dGVListTasks";
            this.dGVListTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dGVListTasks.RowHeadersVisible = false;
            this.dGVListTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dGVListTasks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVListTasks.RowTemplate.Height = 24;
            this.dGVListTasks.Size = new System.Drawing.Size(702, 514);
            this.dGVListTasks.TabIndex = 0;
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
            this.isImportantTask.Text = "вяравяа";
            this.isImportantTask.UseColumnTextForButtonValue = true;
            this.isImportantTask.Width = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "To-Do list";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListLists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label EmailField;
        private System.Windows.Forms.Label FlnField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVListTasks;
        private System.Windows.Forms.TextBox taskField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVListLists;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskText;
        private System.Windows.Forms.DataGridViewButtonColumn isImportantTask;
    }
}

