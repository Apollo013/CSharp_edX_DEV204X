namespace Module06
{
    public class Course
    {
        private int studentCount = 0;
        private int teacherCount = 0;

        public string Name { get; set; }
        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }
        public int RequiredPoints { get; set; }

        public int StudentCount { get { return studentCount; } }
        public int TeacherCount { get { return teacherCount; } }

        public Course(int studentQuantity, int teacherQuantity)
        {
            Students = new Student[studentQuantity];
            Teachers = new Teacher[teacherQuantity];
        }

        public bool AddStudent(Student student)
        {
            if (studentCount < Students.Length)
            {
                Students[studentCount] = student;
                studentCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddTeacher(Teacher teacher)
        {
            if (teacherCount < Teachers.Length)
            {
                Teachers[teacherCount] = teacher;
                teacherCount++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
