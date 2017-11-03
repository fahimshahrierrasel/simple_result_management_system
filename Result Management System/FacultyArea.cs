using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class FacultyArea : Form
    {
        private string username;
        private int facultyId;
        private List<Section> sections;
        public FacultyArea(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FacultyArea_Load(object sender, EventArgs e)
        {
            SetFacultyInformation(username);
            sections = GetAllSections(facultyId);
            foreach (Section section in sections)
            {
                SectionSelectionComboBox.Items.Add($"{section.course}-{section.section_no}");
            }
            
        }

        private void GradeSubmissionButton_Click(object sender, EventArgs e)
        {
            if (SectionSelectionComboBox.SelectedIndex >= 0)
            {
                int sectioId = sections[SectionSelectionComboBox.SelectedIndex].section_id;
                ResultSubmissionForm resultSubmissionForm = new ResultSubmissionForm(sectioId);
                resultSubmissionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a section first");
            }
        }

        private void SetFacultyInformation(string username)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            try
            {
                databaseConnection.Cmd.CommandText = "Select top 1 faculty_id, name, initial, department from Faculty where initial = @Initial";
                databaseConnection.Cmd.Parameters.Add("@Initial", SqlDbType.VarChar).Value = username;

                databaseConnection.Con.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);

                databaseConnection.Con.Close();

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Faculty");
                DataTable stroageTable = dataSet.Tables["Faculty"];
                if (stroageTable.Rows.Count == 1)
                {
                    FacultyName.Text = stroageTable.Rows[0]["name"].ToString();
                    FacultyDepartment.Text = stroageTable.Rows[0]["department"].ToString();
                    facultyId = Convert.ToInt32(stroageTable.Rows[0]["faculty_id"].ToString());
                }

                databaseConnection.ClearCommandText();
                databaseConnection.Con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private List<Section> GetAllSections(int facultyId)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.Cmd.CommandText = "Select section_id, section_no, Faculty.initial as faculty, Course.course_code as course From Section, Faculty, Course Where Section.faculty_id = Faculty.faculty_id and Section.course_id = Course.course_id and Section.faculty_id = @FacultyId";
            databaseConnection.Cmd.Parameters.Add("@FacultyId", SqlDbType.Int).Value = facultyId;
            databaseConnection.Con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);
            databaseConnection.Con.Close();

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataTable sectionTable = dataSet.Tables[0];

            List<Section> allSections = new List<Section>();

            foreach (DataRow dr in sectionTable.Rows)
            {
                Section section = new Section(
                    Convert.ToInt32(dr["section_id"].ToString()),
                    Convert.ToInt32(dr["section_no"].ToString()),
                    dr["faculty"].ToString(),
                    dr["course"].ToString()
                );
                allSections.Add(section);
            }
            return allSections;
        }

    }
}
