using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class AddSectionStudentForm : Form
    {
        private RmsController rmsController;
        private List<Section> sections;
        private List<Student> allStudents;
        public AddSectionStudentForm()
        {
            InitializeComponent();
            rmsController = new RmsController();
            sections = rmsController.GetAllSections();
            allStudents = rmsController.GetAllStudents();
        }

        private void AddSectionStudentForm_Load(object sender, EventArgs e)
        {
            foreach (Section section in sections)
            {
                SectionComboBox.Items.Add(String.Format("{0}-{1}-{2}", section.section_no, section.course, section.faculty));
            }
            foreach (Student student in allStudents)
            {
                StudentComboBox.Items.Add(String.Format("{0}-{1}-{2}", student.student_id, student.name, student.department));
            }
        }

        private void SectionAddCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SectionAddButton_Click(object sender, EventArgs e)
        {
            if (SectionComboBox.SelectedIndex >= 0 && StudentComboBox.SelectedIndex >= 0)
            {
                int sectionId = sections[SectionComboBox.SelectedIndex].section_id;
                int studentId = allStudents[StudentComboBox.SelectedIndex].student_id;
                if (AddSectionStudentToDatabase(sectionId, studentId))
                {
                    MessageBox.Show(@"Setudent add to the section.", @"Success");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Student Can not be add to the section", @"Error!");
                }
            }
            else
            {
                MessageBox.Show(@"Select approtipate options", @"Warning!");
            }
            
        }

        private bool AddSectionStudentToDatabase(int sectionId, int studentId)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                databaseConnection.Cmd.CommandText =
                    "Insert into SectionStudent (student_id, section_id) Values(@StdId, @SecId)";
                databaseConnection.Cmd.Parameters.Add("@StdId", SqlDbType.Int).Value = studentId;
                databaseConnection.Cmd.Parameters.Add("@SecId", SqlDbType.Int).Value = sectionId;
                databaseConnection.Con.Open();
                databaseConnection.Cmd.ExecuteNonQuery();

                databaseConnection.ClearCommandText();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, @"Exception");
                return false;
            }
            finally
            {
                databaseConnection.Con.Close();
            }
            return true;
        }
    }
}
