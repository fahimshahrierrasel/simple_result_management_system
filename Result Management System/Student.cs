namespace Result_Management_System
{
    class Student
    {
        public int student_id { get; }
        public string name { get; }
        public string department { get; }

        public Student(int studentId, string name, string department)
        {
            student_id = studentId;
            this.name = name;
            this.department = department;
        }
    }
}
