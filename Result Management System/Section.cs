namespace Result_Management_System
{
    class Section
    {
        public int section_id { get; }
        public int section_no { get; }
        public string faculty { get; }
        public string course { get; }

        public Section(int sectionId, int sectionNo, string faculty, string course)
        {
            section_id = sectionId;
            section_no = sectionNo;
            this.faculty = faculty;
            this.course = course;
        }
    }
}
