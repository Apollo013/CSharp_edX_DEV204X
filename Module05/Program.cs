using System;

namespace Module05
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) Instantiate three Student objects.
            var stud1 = new Student() { FirstName = "Mary" , LastName="Murphy", DOB = new DateTime(1955, 11, 18) };
            var stud2 = new Student() { FirstName = "John", LastName = "Henry", DOB = new DateTime(1995, 11, 18) };
            var stud3 = new Student() { FirstName = "Martha", LastName = "Willaims", DOB = new DateTime(1989, 11, 18) };

            // (2) Instantiate a Course object called Programming with C#.
            var course = new Course() { Name = "Programming with C#" };

            // (3) Add your three students to this Course object.
            course.AddStudent(stud1);
            course.AddStudent(stud2);
            course.AddStudent(stud3);

            // (4) Instantiate at least one Teacher object
            var t1 = new Teacher() { FirstName = "Pat", LastName = "Murphy", Salary = (decimal)50000.25 };

            // (5) Add that Teacher object to your Course object
            course.AddTeacher(t1);

            // (6) Instantiate a Degree object, such as Bachelor.
            var degree = new Degree() { Name = "Bachelor of Science" };

            // (7) Add your Course object to the Degree object.
            degree.Course = course;

            // (8) Instantiate a UProgram object called Information Technology
            var uprogram = new UProgram() { Name = "Information Technology" };

            // (9) Add the Degree object to the UProgram object
            uprogram.Degree = degree;

            // (10) Using Console.WriteLine statements, output the following information to the console window
            Console.WriteLine("The {0} program contains the {1} degree", uprogram.Name, uprogram.Degree.Name);
            Console.WriteLine("\nThe {0} degree contains the course {1}", degree.Name, degree.Course.Name);
            Console.WriteLine("\nThe {0} course contains {1} students(s)\n", course.Name, course.StudentCount);

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }

    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }

    public class Course
    {
        private int studentCount = 0;
        private int teacherCount = 0;

        public string Name { get; set; }
        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }
        public int StudentCount { get { return studentCount; } }
        public int TeacherCount { get { return teacherCount; } }

        public Course() {
            Students = new Student[3];
            Teachers = new Teacher[3];
        }

        public bool AddStudent(Student student)
        {
            if(studentCount < Students.Length)
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

    public class Degree
    {
        public string Name { get; set; }
        public Course Course { get; set; } 
    }

    public class UProgram
    {
        public string Name { get; set; }
        public Degree Degree { get; set; }
    }

}
