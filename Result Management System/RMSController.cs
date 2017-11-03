using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Result_Management_System
{
    class RmsController
    {
        private DatabaseConnection databaseConnection;

        public RmsController()
        {
            databaseConnection = new DatabaseConnection();
        }

        public List<Faculty> GetAllFaculties()
        {
            databaseConnection.Cmd.CommandText = "Select faculty_id, name, initial, department From Faculty";
            databaseConnection.Con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);
            databaseConnection.Con.Close();

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Faculty");
            DataTable facultiesTable = dataSet.Tables["Faculty"];

            List<Faculty> faculties = new List<Faculty>();

            foreach (DataRow dr in facultiesTable.Rows)
            {
                Faculty faculty = new Faculty(
                    Convert.ToInt32(dr["faculty_id"].ToString()),
                    dr["name"].ToString(),
                    dr["initial"].ToString(),
                    dr["department"].ToString()
                );
                faculties.Add(faculty);
            }
            return faculties;
        }

        public List<Course> GetAllCourses()
        {
            databaseConnection.Cmd.CommandText = "Select course_id, course_code From Course";
            databaseConnection.Con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);
            databaseConnection.Con.Close();

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Course");
            DataTable coursesTable = dataSet.Tables["Course"];

            List<Course> allCourses = new List<Course>();

            foreach (DataRow dr in coursesTable.Rows)
            {
                Course course = new Course(
                    Convert.ToInt32(dr["course_id"].ToString()),
                    dr["course_code"].ToString()
                );
                allCourses.Add(course);
            }
            return allCourses;
        }

        public List<Section> GetAllSections()
        {
            databaseConnection.Cmd.CommandText = "Select section_id, section_no, Faculty.initial as faculty, Course.course_code as course From Section, Faculty, Course Where Section.faculty_id = Faculty.faculty_id and Section.course_id = Course.course_id";
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

        public List<Student> GetAllStudents()
        {
            databaseConnection.Cmd.CommandText = "Select student_id, name, department From Student";
            databaseConnection.Con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.Cmd);
            databaseConnection.Con.Close();

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Student");
            DataTable studentTable = dataSet.Tables["Student"];

            List<Student> students = new List<Student>();

            foreach (DataRow dr in studentTable.Rows)
            {
                Student student = new Student(
                    Convert.ToInt32(dr["student_id"].ToString()),
                    dr["name"].ToString(),
                    dr["department"].ToString()
                );
                students.Add(student);
            }
            return students;
        }

    }
}
