using System;
using System.Data;

namespace Result_Management_System
{
    class SectionStudent
    {
        public int ssId { get; }
        public int student_id { get; }
        public int section_id { get; }
        public string result { get; set; }

        public SectionStudent(int ssId, int studentId, int sectionId, string result)
        {
            this.ssId = ssId;
            student_id = studentId;
            section_id = sectionId;
            this.result = result;
        }

        public bool UpdateResult()
        {

            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                databaseConnection.Cmd.CommandText =
                    "UPDATE SectionStudent SET result = @Result WHERE ss_id = @SSID";
                databaseConnection.Cmd.Parameters.Add("@Result", SqlDbType.VarChar).Value = result;
                databaseConnection.Cmd.Parameters.Add("@SSID", SqlDbType.Int).Value = ssId;
                databaseConnection.Con.Open();
                databaseConnection.Cmd.ExecuteNonQuery();
                databaseConnection.Con.Close();
                databaseConnection.ClearCommandText();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                return false;
            }
            return true;
        }
    }
}
