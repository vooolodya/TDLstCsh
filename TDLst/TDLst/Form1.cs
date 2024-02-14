using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ServiceStack;
using System.Data;
using System.Data.SqlClient;


namespace TDLst
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["TDLstDataBase"].ConnectionString;
        private SqlConnection sqlConnection = null;
        private int idAutorithUser = 1;
        private int idVwrTaskList = 2;

        public DataTable ExecuteQueryWithParameters(string commandText, SqlParameter[] parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.AddRange(parameters);

                    using (SqlDataReader SqlDataReader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(SqlDataReader);

                        return dataTable;
                    }
                }
            }
        }

        private void LoadingListsData()
        {

            string command = "SELECT IdTaskList, NameTasklist FROM ListOfTasklist WHERE idUser = @idAutorithUser";
            SqlParameter[] parameters = { new SqlParameter("@idAutorithUser", SqlDbType.Int) { Value = idAutorithUser } };

            DataTable dataTable = ExecuteQueryWithParameters(command, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                DGVListOfLists.Rows.Add(row["IdTaskList"], row["NameTasklist"]);
            }


        }

        private void LoadingUserData()
        {
            string command = "SELECT nickname, Login FROM LoginData WHERE IdUser = @idAutorithUser";
            SqlParameter[] parameters = { new SqlParameter("@idAutorithUser", SqlDbType.Int) { Value = idAutorithUser } };

            DataTable dataTable = ExecuteQueryWithParameters(command, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                NicknameField.Text = row["Nickname"].ToString();
                EmailField.Text = row["Login"].ToString();
            }


        }




        private void AddListTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ListTaskField.Text))
            {
                return;
            }


            string commandText = "INSERT INTO ListOfTasklist (idUser, NameTasklist) VALUES (@idUser, @NameTasklist)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@idUser", SqlDbType.Int).Value = idAutorithUser;
                    sqlCommand.Parameters.Add("@NameTasklist", SqlDbType.VarChar).Value = ListTaskField.Text;

                    sqlCommand.ExecuteNonQuery();
                }
            }
            

            DGVListOfLists.Rows.Add(false, ListTaskField.Text, false, idVwrTaskList);
            ListTaskField.Text = string.Empty;

        }

        private void AddTaskIntoGroupButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TaskField.Text))
            {
                return;
            }

            string commandText = "INSERT INTO Tasks (IdTasklist, Task, TaskState, Importance) VALUES (@IdTasklist, @Task, @TaskState, @Importance)";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@IdTasklist", SqlDbType.Int).Value = idVwrTaskList;
                    sqlCommand.Parameters.Add("@Task", SqlDbType.VarChar).Value = TaskField.Text;
                    sqlCommand.Parameters.Add("@TaskState", SqlDbType.Int).Value = 0;
                    sqlCommand.Parameters.Add("@Importance", SqlDbType.Int).Value = 0;

                    sqlCommand.ExecuteNonQuery();
                }
            }
            
            DGVListTasks.Rows.Add(false, TaskField.Text, false, idVwrTaskList);
            TaskField.Text = string.Empty;
        }

        private void DGVListOfLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVListTasks.Rows.Clear();

            DataGridViewRow row = DGVListOfLists.Rows[e.RowIndex];
            object value = row.Cells[0].Value;
            string idTaskList = value.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string command = "SELECT TaskState, Task, Importance FROM Tasks WHERE idTasklist = @idTasklist";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@idTasklist", idTaskList);

                    using (SqlDataReader SqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (SqlDataReader.Read())
                        {
                            DGVListTasks.Rows.Add(SqlDataReader["TaskState"], SqlDataReader["Task"], SqlDataReader["Importance"]);
                        }
                    }
                }
            }

        }

        private void DGVListTasks_KeyDown(object sender, KeyEventArgs e)
        {

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingUserData();
            LoadingListsData();
        }
    }
}
