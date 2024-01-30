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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.EmailField = new System.Windows.Forms.Label();
            this.FlnField = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckTaskStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImportantTask = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuPanel.Controls.Add(this.EmailField);
            this.menuPanel.Controls.Add(this.FlnField);
            this.menuPanel.Controls.Add(this.buttonSearch);
            this.menuPanel.Controls.Add(this.searchField);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(370, 692);
            this.menuPanel.TabIndex = 0;
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
            this.buttonSearch.Location = new System.Drawing.Point(278, 116);
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
            this.searchField.Size = new System.Drawing.Size(251, 34);
            this.searchField.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(335, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 692);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckTaskStatus,
            this.TaskText,
            this.isImportantTask});
            this.dataGridView.Location = new System.Drawing.Point(41, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(736, 540);
            this.dataGridView.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(41, 607);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(736, 34);
            this.textBox1.TabIndex = 4;
            // 
            // CheckTaskStatus
            // 
            this.CheckTaskStatus.FillWeight = 79.24468F;
            this.CheckTaskStatus.HeaderText = "";
            this.CheckTaskStatus.MinimumWidth = 15;
            this.CheckTaskStatus.Name = "CheckTaskStatus";
            // 
            // TaskText
            // 
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label EmailField;
        private System.Windows.Forms.Label FlnField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isImportantTask;
    }
}

