using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TDLst.Properties;

namespace TDLst
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["TDLstDataBase"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "SELECT ID, Login, Password FROM [User] WHERE Login = @Login AND Password = @Pass";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@Login", SqlDbType.VarChar).Value = LoginField.Text;
                    sqlCommand.Parameters.Add("@Pass", SqlDbType.VarChar).Value = PassField.Text;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        dataTable.Load(sqlDataReader);
                    }
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                Settings.Default["IDUser"] = dataTable.Rows[0]["ID"].ToString();
                Settings.Default.Save();

                WorkForm wrk = new WorkForm();
                wrk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WorkForm wrk = new WorkForm();
            wrk.Show();
            this.Hide();
        }
    }
}
