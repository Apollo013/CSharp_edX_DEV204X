using System;

namespace Module06
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) Instantiate three Student objects.
            var stud1 = new Student( "Mary" , "Murphy", new DateTime(1955, 11, 18),30 );
            var stud2 = new Student( "John", "Henry", new DateTime(1995, 11, 18), 25);
            var stud3 = new Student( "Martha", "Willaims", new DateTime(1989, 11, 18), 30);

            // (2) Instantiate a Course object called Programming with C#.
            var course = new Course(3,1) { Name = "Programming with C#", RequiredPoints = 5 };

            // (3) Add your three students to this Course object.
            course.AddStudent(stud1);
            course.AddStudent(stud2);
            course.AddStudent(stud3);

            // (4) Instantiate at least one Teacher object
            var t1 = new Teacher( "Pat", "Murphy", new DateTime(1955, 11, 18), (decimal)50000.25 );

            // (5) Add that Teacher object to your Course object
            course.AddTeacher(t1);

            // (6) Instantiate a Degree object, such as Bachelor.
            var degree = new Degree() { Name = "Bachelor of Science", RequiredPoints = 50 };

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

            // ADDITIONAL
            Console.WriteLine("Students in course");
            foreach(Student stud in course.Students)
            {
                Console.WriteLine(stud.ToString());
            }

            Console.WriteLine("\nTeachers in course");
            foreach (Teacher t in course.Teachers)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
