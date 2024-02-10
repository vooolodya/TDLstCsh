using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ServiceStack;


namespace TDLst
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["TDLstDataBase"].ConnectionString;
        private SqlConnection sqlConnection = null;
        private int idAutorithUser = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingStartData();
        }

        private void LoadingStartData()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataReader SqlDataReader = null;
            SqlDataAdapter sqlDataAdapter = null;
            string command = "SELECT * from [ListOfTasklist] WHERE idUser = @idAutorithUser";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@idAutorithUser", idAutorithUser);

            SqlDataReader = sqlCommand.ExecuteReader();

            while (SqlDataReader.Read())
            {
                DGVListOfLists.Rows.Add(SqlDataReader["IdTaskList"], SqlDataReader["NameTasklist"]);
                //NameField.Text = SqlDataReader["NameTasklist"].ToString();
            }

            sqlConnection.Close();



            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            command = "SELECT nickname, Login FROM LoginData WHERE IdUser = @idAutorithUser";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@idAutorithUser", idAutorithUser);

            SqlDataReader = sqlCommand.ExecuteReader();

            while (SqlDataReader.Read())
            {
                NicknameField.Text = Convert.ToString(SqlDataReader["Nickname"]);
                EmailField.Text = Convert.ToString(SqlDataReader["Login"]);
            }

            sqlConnection.Close();


        }

        private void AddListTaskButton_Click(object sender, EventArgs e)
        {
            if (ListTaskField.Text != "")
            {
                DGVListOfLists.Rows.Add(ListTaskField.Text, ListTaskField.Text);
                ListTaskField.Text = string.Empty;
            }

            
        }

        private int GetMaxTaskID()
        {

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string command = "SELECT MAX(idTask) FROM Tasks";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            object maxIdObject = sqlCommand.ExecuteScalar();
            int maxId = Convert.ToInt32(maxIdObject);

            sqlConnection.Close();

            return maxId;

        }

        private int GetMaxTaskListID()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string command = "SELECT MAX(IdTaskList) FROM ListOfTasklist";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            object maxIdObject = sqlCommand.ExecuteScalar();
            int maxId = Convert.ToInt32(maxIdObject);

            sqlConnection.Close();

            return maxId;

        }

        private void AddTaskIntoGroupButton_Click(object sender, EventArgs e)
        {

            if (TaskField.Text == "")
            {
                return;
            }
            DGVListTasks.Rows.Add(false, TaskField.Text, false, DGVListTasks.Rows[0].Cells[3].Value);


            DGVListTasks.Rows.Add(false, TaskField.Text, false);

            string commandText = "INSERT INTO Tasks (IdTasklist, Task, TaskState, Importance) VALUES (@IdTasklist, @Task, @TaskState, @Importance)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@IdTasklist", DGVListTasks.Rows[0].Cells[3].Value);
                    sqlCommand.Parameters.AddWithValue("@Task", TaskField.Text);
                    sqlCommand.Parameters.AddWithValue("@TaskState", 0);
                    sqlCommand.Parameters.AddWithValue("@Importance", 0);

                    sqlCommand.ExecuteNonQuery();
                }
            }

            //sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
            //SqlDataReader SqlDataReader = null;
            //SqlDataAdapter sqlDataAdapter = null;
            //string command = "UPDATE Tasks SET [number] = '" + TaskField.Text + "',[fln] = '" + auto.fln + "', [brand] = '" + auto.brand + "', ");
            //SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@idAutorithUser", idAutorithUser);

            //SqlDataReader = sqlCommand.ExecuteReader();

            //while (SqlDataReader.Read())
            //{
            //    DGVListOfLists.Rows.Add(SqlDataReader["IdTaskList"], SqlDataReader["NameTasklist"]);
            //}

            //sqlConnection.Close();


            TaskField.Text = string.Empty;
        }

        private void DGVListOfLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVListTasks.Rows.Clear();

            DataGridViewRow row = DGVListOfLists.Rows[e.RowIndex];
            object value = row.Cells[0].Value;
            string idTaskList = value.ToString();

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataReader SqlDataReader = null;
            SqlDataAdapter sqlDataAdapter = null;
            string command = "SELECT * from [Tasks] WHERE idTasklist = @idTasklist";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@idTasklist", idTaskList);

            SqlDataReader = sqlCommand.ExecuteReader();

            while (SqlDataReader.Read())
            {
                DGVListTasks.Rows.Add(SqlDataReader["TaskState"], SqlDataReader["Task"], SqlDataReader["Importance"], SqlDataReader["idTasklist"]);
            }

            sqlConnection.Close();

            ;
        }

    }
}
