using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;


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
            DownloadTaskData();
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

        private void DownloadTaskData()
        {
            string command = "SELECT ID, Name FROM Tasklist WHERE UserID = @idAutorithUser";
            SqlParameter[] parameters = { new SqlParameter("@idAutorithUser", SqlDbType.Int) { Value = AuthorizedUserId } };

            DataTable dataTable = ExecuteQueryWithSQLParameters(command, parameters);
            foreach (DataRow row in dataTable.Rows)
            {
                ListsGridView.Rows.Add(row["ID"], row["Name"]);
            }
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

            TasksGridView.Rows.Add(GetMaxID("SELECT MAX(ID) FROM Task") + 1, false, NewTaskNameField.Text, false);
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

            DataGridViewRow row = ListsGridView.Rows[e.RowIndex];
            object value = row.Cells[0].Value;
            SelectedIDTaskList = value.ToString();

            string command = "SELECT ID, Name, IsCompleted, IsImportant FROM Task WHERE TasklistID = @idTasklist";
            SqlParameter[] parameters = { new SqlParameter("@idTasklist", SqlDbType.Int) { Value = SelectedIDTaskList } };

            DataTable dataTable = ExecuteQueryWithSQLParameters(command, parameters);

            foreach (DataRow rows in dataTable.Rows)
            {
                TasksGridView.Rows.Add(rows["ID"], rows["IsCompleted"], rows["Name"], rows["IsImportant"]);
            }

            Image image11 = new Bitmap("Sources\\Vector11.png");
            Image image12 = new Bitmap("Sources\\Vector12.png");

            foreach (DataGridViewRow rows in TasksGridView.Rows)
            {
                if ((bool)rows.Cells["isImportantTask"].Value)
                {
                    TasksGridView.Rows[rows.Index].Cells["IsImportantPicture"].Value = image12;
                }
                else
                {
                    TasksGridView.Rows[rows.Index].Cells["IsImportantPicture"].Value = image11;
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

        private void TasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == IsImportantPicture.Index && e.RowIndex >= 0)
            {

                TasksGridView.Rows[e.RowIndex].Cells[isImportantTask.Index].Value = !(bool)TasksGridView.Rows[e.RowIndex].Cells[isImportantTask.Index].Value;

                Image NotImportant = new Bitmap("Sources\\Vector11.png");
                Image Important = new Bitmap("Sources\\Vector12.png");

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
        }


    }
}
