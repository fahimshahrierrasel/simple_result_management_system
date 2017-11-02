using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Management_System
{
    class Course
    {
        public int CourseId { get; }
        public string CourseCode { get; }

        public Course(int courseId, string courseCode)
        {
            CourseId = courseId;
            CourseCode = courseCode;
        }
    }
}
