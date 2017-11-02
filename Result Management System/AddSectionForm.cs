using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class AddSectionForm : Form
    {
        private RmsController rmsController;
        private List<Faculty> allFaculties;
        private List<Course> allCourses;
        public AddSectionForm()
        {
            InitializeComponent();
            rmsController = new RmsController();
            allFaculties = rmsController.GetAllFaculties();
            allCourses = rmsController.GetAllCourses();
        }

        private void CancelAddSectionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitSectionButton_Click(object sender, EventArgs e)
        {
            int courseId = allCourses[CourseComboBox.SelectedIndex].CourseId;
            int facultyId = allFaculties[FacultyComboBox.SelectedIndex].Id;
            

            if (!String.IsNullOrEmpty(SectionTextBox.Text) && courseId > 0 && facultyId > 0)
            {
                int sectionNumber = Convert.ToInt32(SectionTextBox.Text);
                
                if (AddSectionToDatabase(courseId, facultyId, sectionNumber))
                {
                    MessageBox.Show(@"Section Added", @"Success!");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Section Added Unseccessful!!", @"Error!");
                }
            }
            else
            {
                MessageBox.Show(@"Please add any necessary fields!!", @"Warning!");
            }
        }

        private void AddSectionForm_Load(object sender, EventArgs e)
        {
            foreach (Course course in allCourses)
            {
                CourseComboBox.Items.Add(course.CourseCode);
            }

            foreach (Faculty faculty in allFaculties)
            {
                FacultyComboBox.Items.Add(faculty.Name + "-" + faculty.Department);
            }

            CourseComboBox.SelectedIndex = 0;
            FacultyComboBox.SelectedIndex = 0;
        }

        private bool AddSectionToDatabase(int courseId, int facultyId, int sectionNumber)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            try
            {
                dbConnection.Cmd.CommandText =
                    "Insert into Section (section_no, faculty_id, course_id) Values(@SecNo, @FacID, @CrsID)";
                dbConnection.Cmd.Parameters.Add("@CrsID", SqlDbType.Int).Value = courseId;
                dbConnection.Cmd.Parameters.Add("@FacID", SqlDbType.Int).Value = facultyId;
                dbConnection.Cmd.Parameters.Add("@SecNo", SqlDbType.Int).Value = sectionNumber;
                dbConnection.Con.Open();
                dbConnection.Cmd.ExecuteNonQuery();

                dbConnection.ClearCommandText();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, @"Exception");
                return false;
            }
            finally
            {
                dbConnection.Con.Close();
            }
            return true;
        }


    }
}
