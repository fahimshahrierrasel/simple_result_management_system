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
    }
}
