using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class ResultSubmissionForm : Form
    {
        private int sectionId;
        private List<SectionStudent> allStudents;

        private Label[] studentLabels;
        private ComboBox[] studentResult;
        private string[] grades;

        public ResultSubmissionForm(int sectioId)
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.AutoSize = true;
            this.sectionId = sectioId;
            grades = new string[] {"A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "F"};
            allStudents = GetAllSectionStudents(sectionId);
        }

        private void ResultSubmissionForm_Load(object sender, EventArgs e)
        {
            Label studentIdLabel = new Label();
            studentIdLabel.Location = new Point(5, 15);
            studentIdLabel.Text = "Student Id";
            studentIdLabel.AutoSize = true;

            Label studentResultLabel = new Label();
            studentResultLabel.Location = new Point(70, 15);
            studentResultLabel.Text = "Grade";
            studentResultLabel.AutoSize = true;
            
            this.Controls.Add(studentIdLabel);
            this.Controls.Add(studentResultLabel);

            studentLabels = new Label[allStudents.Count];
            studentResult = new ComboBox[allStudents.Count];
            int i = 0;
            int space = 0;

            foreach (SectionStudent sectionStudent in allStudents)
            {
                studentLabels[i] = new Label();
                studentResult[i] = new ComboBox();
                studentLabels[i].Name = sectionStudent.student_id.ToString();
                studentLabels[i].Text = sectionStudent.student_id.ToString();
                studentLabels[i].Width = 20;
                studentLabels[i].Location = new Point(25, 40 + space);
                
                studentResult[i].Location = new Point(65, 40 + space);
                studentResult[i].Width = 40;
                
                studentResult[i].Items.AddRange(grades);
                studentResult[i].SelectedIndex = ResultToComboBox(sectionStudent.result);
               
                this.Controls.Add(studentLabels[i]);
                this.Controls.Add(studentResult[i]);
                space += 50;
                i++;
            }
            Button submitButton = new Button();
            submitButton.Location = new Point(70, 40 + space);
            submitButton.AutoSize = true;
            submitButton.Text = "Submit";
            submitButton.Click += SubmitClickHandler;
            
            this.Controls.Add(submitButton);

        }

        private int ResultToComboBox(string result)
        {
            for (int j = 0; j < grades.Length; j++)
            {
                if (grades[j] == result)
                    return j;
            }
            return -1;
        }

        private void SubmitClickHandler(object sender, EventArgs eventArgs)
        {
            
            bool isCompleted = true;
            for (var j = 0; j < allStudents.Count; j++)
            {
                if (studentResult[j].SelectedIndex < 0)
                {
                    isCompleted = false;
                    break;
                }
            }

            int i = 0;

            if (isCompleted)
            {
                foreach (SectionStudent sectionStudent in allStudents)
                {
                    sectionStudent.result = grades[studentResult[i].SelectedIndex];
                    i++;
                }

                foreach (SectionStudent sectionStudent in allStudents)
                {
                    sectionStudent.UpdateResult();
                }

                MessageBox.Show("Grade Submission successful");
                Close();
            }
            else
            {
                MessageBox.Show("Please add all student information", "Warning");
            } 
        }

        private List<SectionStudent> GetAllSectionStudents(int sectionId)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.Cmd.CommandText = "Select ss_id, student_id, section_id, result From SectionStudent Where section_id = @SecId";
            databaseConnection.Cmd.Parameters.Add("@SecId", SqlDbType.Int).Value = sectionId;
            databaseConnection.Con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);
            databaseConnection.Con.Close();

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "SectionStudent");
            DataTable coursesTable = dataSet.Tables["SectionStudent"];

            List<SectionStudent> allCourses = new List<SectionStudent>();

            foreach (DataRow dr in coursesTable.Rows)
            {
                SectionStudent course = new SectionStudent(
                    Convert.ToInt32(dr["ss_id"].ToString()),
                    Convert.ToInt32(dr["student_id"].ToString()),
                    Convert.ToInt32(dr["section_id"].ToString()),
                    dr["result"].ToString()
                );
                allCourses.Add(course);
            }
            return allCourses;
        }
    }
}
