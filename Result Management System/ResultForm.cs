using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            ShowStudentInfo(false);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string StrStudentId = StudentIdTextBox.Text;
            if (StrStudentId.Length > 0)
            {
                int studentId = Convert.ToInt32(StrStudentId);
                Student student = GetStudentInformation(studentId);
                if (student != null)
                {
                    StudentName.Text = student.name;
                    DepartmentName.Text = student.department;
                    ResultView.DataSource = GetAllResutTable(studentId);
                    ShowStudentInfo(true);
                }
                else
                {
                    MessageBox.Show(@"No information found", @"Warning");
                }
            }
            else
            {
                MessageBox.Show(@"Please add studnet id first", @"Warning");
            }
        }

        private void ShowStudentInfo(bool show)
        {
            NameLabel.Visible = show;
            StudentName.Visible = show;
            DepartmentLabel.Visible = show;
            DepartmentName.Visible = show;
            ResultView.Visible = show;
        }

        private Student GetStudentInformation(int studentId)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            Student student = null;
            try
            {
                databaseConnection.Cmd.CommandText = "Select top 1 student_id, name, department from Student where student_id = @ID";
                databaseConnection.Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = studentId;

                databaseConnection.Con.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);

                databaseConnection.Con.Close();

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Student");
                DataTable stroageTable = dataSet.Tables["Student"];
                if (stroageTable.Rows.Count == 1)
                {
                    student = new Student(
                        Convert.ToInt32(stroageTable.Rows[0]["student_id"].ToString()),
                        stroageTable.Rows[0]["name"].ToString(),
                        stroageTable.Rows[0]["department"].ToString()
                    );
                    
                }

                databaseConnection.ClearCommandText();
                databaseConnection.Con.Close();
                return student;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        private DataTable GetAllResutTable(int studentId)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable userDataTable = null;
            try
            {
                dbConnection.Cmd.CommandText = "Select Course.course_code as course, Section.section_no, result From SectionStudent, Course, Section Where SectionStudent.section_id = Section.section_id and Section.course_id = Course.course_id and SectionStudent.student_id = @StdId";
                dbConnection.Cmd.Parameters.Add("@StdId", SqlDbType.Int).Value = studentId;
                dbConnection.Con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(dbConnection.Cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                userDataTable = dataSet.Tables[0];
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
            finally
            {
                dbConnection.Con.Close();
            }
            return userDataTable;
        }
    }
}
