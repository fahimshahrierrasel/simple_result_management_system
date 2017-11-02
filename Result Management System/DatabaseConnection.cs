using System.Data.SqlClient;

namespace Result_Management_System
{
    class DatabaseConnection
    {
        private string ConnString = @"Server=WINDOWSPROGRAMM\SQLEXPRESS; Database=RMS; Trusted_Connection=True;";
        public SqlConnection Con;
        public SqlCommand Cmd;

        public DatabaseConnection()
        {
            Con = new SqlConnection(ConnString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public void ClearCommandText()
        {
            Cmd.Parameters.Clear();
        }
    }
}
