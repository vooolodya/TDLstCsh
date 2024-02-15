using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using ServiceStack;


namespace TDLst
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["TDLstDataBase"].ConnectionString;
        private int AuthorizedUserId = 1;
        private int Lists = 1;
        private int SelectedIDTaskList = 0;

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
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewTaskNameField.Text))
            {
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

            TasksGridView.Rows.Add(false, NewTaskNameField.Text, false);
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
            string idTaskList = value.ToString();

            string command = "SELECT Name, IsCompleted, IsImportant FROM Task WHERE TasklistID = @idTasklist";
            SqlParameter[] parameters = { new SqlParameter("@idTasklist", SqlDbType.Int) { Value = idTaskList } };

            DataTable dataTable = ExecuteQueryWithSQLParameters(command, parameters);

            foreach (DataRow rows in dataTable.Rows)
            {
                TasksGridView.Rows.Add(rows["IsCompleted"], rows["Name"], rows["IsImportant"]);
            }

            NameListDisplay.Text = ListsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            int.TryParse(ListsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out Lists);
        }

    }
}
