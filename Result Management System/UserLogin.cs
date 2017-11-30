using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class UserLogin : Form
    {
        private DatabaseConnection databaseConnection;
        private string Username;
        public UserLogin()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        /// <summary>
        /// Form will close if Cancel clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        /// <summary>
        /// Form submission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show(@"Username/Password is empty", @"Warning");
                LoginButton.Enabled = true;
            }
            else
            {
                string loginType = IsLoginCorrect(username, password);
                if (loginType.Equals("Admin"))
                {
                    AdminArea adminArea = new AdminArea();
                    adminArea.Show();
                    Close();
                }
                else if (loginType.Equals("Faculty"))
                {
                    FacultyArea facultyArea = new FacultyArea(Username);
                    facultyArea.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Username/Password is not correct", @"Warning!");
                    LoginButton.Enabled = true;
                }       
            }  
        }

        private string IsLoginCorrect(string username, string password)
        {
            string loginType = "None";
            try
            {
                databaseConnection.Cmd.CommandText = "Select top 1 type, username from RMUser where username = @UserName and pass = @Password";
                databaseConnection.Cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username;
                databaseConnection.Cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

                databaseConnection.Con.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);

                databaseConnection.Con.Close();

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "RMUser");
                DataTable stroageTable = dataSet.Tables["RMUser"];
                if (stroageTable.Rows.Count == 1)
                {
                    loginType = stroageTable.Rows[0]["type"].ToString();
                    Username = stroageTable.Rows[0]["username"].ToString();
                }
                
                databaseConnection.ClearCommandText();
                databaseConnection.Con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return loginType;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
