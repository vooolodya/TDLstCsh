using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Collections.Generic;



namespace TDLst
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["TDLstDataBase"].ConnectionString;
        private int AuthorizedUserId = 1;
        private string SelectedIDTaskList = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DownloadUserData();
            DownloadListData();
        }

        private void DownloadUserData()
        {
            string command = "SELECT Login, Nickname FROM [User] WHERE ID = @idAutorithUser";
            SqlParameter[] parameters = { new SqlParameter("@idAutorithUser", SqlDbType.Int) { Value = AuthorizedUserId } };

            DataTable dataTable = ExecuteQueryWithSQLParameters(command, parameters);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                LoginDisplay.Text = row["Login"].ToString();
                NickNameDisplay.Text = row["Nickname"].ToString();
            }
        }

        private void DownloadListData()
        {
            ListsGridView.Rows.Add(0, "Важно");

            string command = "SELECT ID, Name FROM Tasklist WHERE UserID = @idAutorithUser";
            SqlParameter[] parameters = { new SqlParameter("@idAutorithUser", SqlDbType.Int) { Value = AuthorizedUserId } };

            DataTable dataTable = ExecuteQueryWithSQLParameters(command, parameters);
            foreach (DataRow row in dataTable.Rows)
            {
                ListsGridView.Rows.Add(row["ID"], row["Name"]);
            }

            ListsGridView.ClearSelection();
        }

        public DataTable ExecuteQueryWithSQLParameters(string commandText, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.AddRange(parameters);

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        dataTable.Load(sqlDataReader);
                    }
                }
            }

            return dataTable;
        }

        public DataTable ExecuteQuery(string commandText)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        dataTable.Load(sqlDataReader);
                    }
                }
            }

            return dataTable;
        }

        private int GetMaxID(string command)
        {
            int result = -1;

            DataTable dataTable = ExecuteQuery(command);

            if (dataTable.Rows.Count > 0)
            {
                result = Convert.ToInt32(dataTable.Rows[0][0]);
            }

            return result;
        }

        private void NewTaskListButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewTaskListButton.Text))
            {
                return;
            }

            string command = "INSERT INTO TaskList (UserID, Name) VALUES (@idUser, @NameTasklist)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idUser", SqlDbType.Int) { Value = AuthorizedUserId },
                new SqlParameter("@NameTasklist", SqlDbType.VarChar) { Value = NewTaskListNameField.Text }
            };
            ExecuteQueryWithSQLParameters(command, parameters);

            ListsGridView.Rows.Add(GetMaxID("SELECT MAX(ID) FROM TaskList") + 1, NewTaskListNameField.Text);
            NewTaskListNameField.Clear();

            DataGridViewCellEventArgs eventArgs = new DataGridViewCellEventArgs(1, ListsGridView.RowCount - 1);
            ListsGridView_CellContentClick(NewTaskButton, eventArgs);

            ListsGridView.ClearSelection();
            TasksGridView.ClearSelection();
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewTaskNameField.Text))
            {
                return;
            }

            if (SelectedIDTaskList == "0")
            {
                MessageBox.Show("Выберите список, прежде чем добавить задание!", "Внимание!");

                return;
            }

            string commandText = "INSERT INTO Task (TaskListID, Name, IsCompleted, IsImportant) VALUES (@IdTasklist, @Task, @TaskState, @Importance)";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@IdTasklist", SqlDbType.Int).Value = SelectedIDTaskList;
                    sqlCommand.Parameters.Add("@Task", SqlDbType.VarChar).Value = NewTaskNameField.Text;
                    sqlCommand.Parameters.Add("@TaskState", SqlDbType.Int).Value = 0;
                    sqlCommand.Parameters.Add("@Importance", SqlDbType.Int).Value = 0;

                    sqlCommand.ExecuteNonQuery();
                }
            }

            Image NotComplete = new Bitmap("Sources\\notDone.png");

            TasksGridView.Rows.Add(GetMaxID("SELECT MAX(ID) FROM Task") + 1, false, false, NotComplete, NewTaskNameField.Text);
            NewTaskNameField.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchButton.Text))
            {
                return;
            }
        }

        private void ListsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TasksGridView.Rows.Clear();

            if (e.ColumnIndex == NameTasklist.Index && e.RowIndex >= 0)
            {

                if (ListsGridView.Rows[e.RowIndex].Cells["IDTaskList"].Value.ToString() == "0")
                {
                    List<int> lists = new List<int>();

                    string CommandUser = "SELECT ID FROM TaskList WHERE UserID = @AuthorizedUserId";
                    SqlParameter[] ParametersUser = { new SqlParameter("@AuthorizedUserId", SqlDbType.Int) { Value = AuthorizedUserId } };

                    DataTable DataTableUser = ExecuteQueryWithSQLParameters(CommandUser, ParametersUser);

                    foreach (DataRow rows in DataTableUser.Rows)
                    {
                        lists.Add((int)rows["ID"]);
                    }

                    foreach (int ListsID in lists)
                    {
                        string Command = "SELECT ID, Name, IsCompleted, IsImportant FROM Task WHERE IsImportant = 1 AND TasklistID = @idTasklist";
                        SqlParameter[] Parameters = { new SqlParameter("@idTasklist", SqlDbType.Int) { Value = ListsID } };

                        DataTable DataTable = ExecuteQueryWithSQLParameters(Command, Parameters);

                        foreach (DataRow rows in DataTable.Rows)
                        {
                            TasksGridView.Rows.Add(rows["ID"], rows["IsCompleted"], rows["IsImportant"], "", rows["Name"]);
                        }
                    }

                }
                else
                {
                    DataGridViewRow row = ListsGridView.Rows[e.RowIndex];
                    object value = row.Cells[0].Value;
                    SelectedIDTaskList = value.ToString();

                    string command = "SELECT ID, Name, IsCompleted, IsImportant FROM Task WHERE TasklistID = @idTasklist";
                    SqlParameter[] parameters = { new SqlParameter("@idTasklist", SqlDbType.Int) { Value = SelectedIDTaskList } };

                    DataTable dataTable = ExecuteQueryWithSQLParameters(command, parameters);

                    foreach (DataRow rows in dataTable.Rows)
                    {
                        TasksGridView.Rows.Add(rows["ID"], rows["IsCompleted"], rows["IsImportant"], "", rows["Name"]);
                    }
                }

                Image NotImportant = new Bitmap("Sources\\!important.png");
                Image Important = new Bitmap("Sources\\important.png");

                foreach (DataGridViewRow rows in TasksGridView.Rows)
                {
                    if ((bool)rows.Cells["isImportantTask"].Value)
                    {
                        TasksGridView.Rows[rows.Index].Cells["IsImportantPicture"].Value = Important;
                    }
                    else
                    {
                        TasksGridView.Rows[rows.Index].Cells["IsImportantPicture"].Value = NotImportant;
                    }
                }

                Image Done = new Bitmap("Sources\\Done.png");
                Image NotComplete = new Bitmap("Sources\\notDone.png");

                foreach (DataGridViewRow rows in TasksGridView.Rows)
                {
                    if ((bool)rows.Cells["CheckTaskStatus"].Value)
                    {
                        TasksGridView.Rows[rows.Index].Cells["TaskStatePicture"].Value = Done;
                    }
                    else
                    {
                        TasksGridView.Rows[rows.Index].Cells["TaskStatePicture"].Value = NotComplete;
                    }
                }

                NameListDisplay.Text = ListsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                TasksGridView.ClearSelection();
            }

            if (e.ColumnIndex == DelList.Index && e.RowIndex >= 0)
            {
                string command = "DELETE FROM TaskList WHERE ID = @idTasklist";
                SqlParameter[] parameters = { new SqlParameter("@idTasklist", SqlDbType.Int) { Value = SelectedIDTaskList } };

                ExecuteQueryWithSQLParameters(command, parameters);

                ListsGridView.Rows.RemoveAt(e.RowIndex);
                ListsGridView.ClearSelection();
                NameListDisplay.Text = "Task task task...";
            }
        }

        private void TasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == IsImportantPicture.Index && e.RowIndex >= 0)
            {

                TasksGridView.Rows[e.RowIndex].Cells[isImportantTask.Index].Value = !(bool)TasksGridView.Rows[e.RowIndex].Cells[isImportantTask.Index].Value;

                Image NotImportant = new Bitmap("Sources\\!important.png");
                Image Important = new Bitmap("Sources\\important.png");

                if ((bool)TasksGridView.Rows[e.RowIndex].Cells[isImportantTask.Index].Value)
                {
                    TasksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Important;
                }
                else
                {
                    TasksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = NotImportant;
                }

                // Получаем новое значение чекбокса
                bool isImportant = (bool)TasksGridView.Rows[e.RowIndex].Cells[isImportantTask.Index].Value;

                // Получаем ID задачи, которому соответствует измененная ячейка
                int taskId = (int)TasksGridView.Rows[e.RowIndex].Cells["ID"].Value;

                // Обновляем запись в базе данных
                string commandText = "UPDATE Task SET IsImportant = @IsImportant WHERE ID = @TaskID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IsImportant", SqlDbType.Bit) { Value = isImportant },
                    new SqlParameter("@TaskID", SqlDbType.Int) { Value = taskId }
                };
                ExecuteQueryWithSQLParameters(commandText, parameters);
                     
                TasksGridView.ClearSelection();
            }

            if (e.ColumnIndex == TaskStatePicture.Index && e.RowIndex >= 0)
            {

                TasksGridView.Rows[e.RowIndex].Cells[CheckTaskStatus.Index].Value = !(bool)TasksGridView.Rows[e.RowIndex].Cells[CheckTaskStatus.Index].Value;

                Image Done = new Bitmap("Sources\\Done.png");
                Image NotComplete = new Bitmap("Sources\\notDone.png");

                if ((bool)TasksGridView.Rows[e.RowIndex].Cells[CheckTaskStatus.Index].Value)
                {
                    TasksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Done;
                }
                else
                {
                    TasksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = NotComplete;
                }

                // Получаем новое значение чекбокса
                bool IsCompleted = (bool)TasksGridView.Rows[e.RowIndex].Cells[CheckTaskStatus.Index].Value;

                // Получаем ID задачи, которому соответствует измененная ячейка
                int taskId = (int)TasksGridView.Rows[e.RowIndex].Cells["ID"].Value;

                // Обновляем запись в базе данных
                string commandText = "UPDATE Task SET IsCompleted = @IsCompleted WHERE ID = @TaskID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IsCompleted", SqlDbType.Bit) { Value = IsCompleted },
                    new SqlParameter("@TaskID", SqlDbType.Int) { Value = taskId }
                };
                ExecuteQueryWithSQLParameters(commandText, parameters);

                TasksGridView.ClearSelection();
            }

            if (e.ColumnIndex == DeleteButton.Index && e.RowIndex >= 0)
            {
                // Получаем ID задачи, которому соответствует измененная ячейка
                int taskId = (int)TasksGridView.Rows[e.RowIndex].Cells["ID"].Value;

                // Обновляем запись в базе данных
                string commandText = "Delete FROM Task WHERE ID = @TaskID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TaskID", SqlDbType.Int) { Value = taskId }
                };
                ExecuteQueryWithSQLParameters(commandText, parameters);

                TasksGridView.Rows.RemoveAt(e.RowIndex);
                TasksGridView.ClearSelection();
            }
        }

        private void SearchField_Click(object sender, EventArgs e)
        {
            if (SearchField.Text == "Поиск")
            {
                SearchField.Clear();
            }

            if (SearchField.Text == string.Empty && !SearchField.Focused) 
            {
                SearchField.Clear();
                SearchField.Text = "Поиск";
            }
        }
    }
}
