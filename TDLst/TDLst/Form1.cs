using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace TDLst
{
    public partial class Form1 : Form
    {
        private string connecctionString = ConfigurationManager.ConnectionStrings["TDLstDataBase"].ConnectionString;
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddListTaskButton_Click(object sender, EventArgs e)
        {
            if (ListTaskField.Text != "")
            {
                DGVListOfLists.Rows.Add(ListTaskField.Text, ListTaskField.Text);
                ListTaskField.Text = string.Empty;
            }
        }

        private void AddTaskIntoGroupButton_Click(object sender, EventArgs e)
        {
            if (TaskField.Text != "")
            {
                DGVListTasks.Rows.Add(false, TaskField.Text, false);
                TaskField.Text = string.Empty;
            }


            sqlConnection = new SqlConnection(connecctionString);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = null;
            string command = string.Empty;

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);


            sqlConnection.Close();
        }
    }
}
