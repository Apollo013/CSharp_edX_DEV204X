using System;
using System.Collections;
using System.Collections.Generic;

namespace Module07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate three Student objects.
            var stud1 = new Student("Mary", "Murphy", new DateTime(1955, 11, 18));
            var stud2 = new Student("John", "Henry", new DateTime(1995, 11, 18));
            var stud3 = new Student("Martha", "Willaims", new DateTime(1989, 11, 18));


            // Add Grades
            stud1.Grades.Push(45.5);
            stud1.Grades.Push(50.2);
            stud1.Grades.Push(80.0);
            stud1.Grades.Push(96.1);
            stud1.Grades.Push(74.3);

            stud2.Grades.Push(85.5);
            stud2.Grades.Push(40.2);
            stud2.Grades.Push(60.0);
            stud2.Grades.Push(86.1);
            stud2.Grades.Push(94.3);

            stud3.Grades.Push(75.5);
            stud3.Grades.Push(80.2);
            stud3.Grades.Push(70.0);
            stud3.Grades.Push(66.1);
            stud3.Grades.Push(64.3);


            // Instantiate a Course object called Programming with C#.
            var course = new Course() { Name = "Programming with C#" };

            // Add your three students to this Course object. (ArrayList.Add method implemented in the 'Add(Student student)' method)
            course.Add(stud1);
            course.Add(stud2);
            course.Add(stud3);

            // List Students
            course.ListStudents();





            /***************************************************************/
            // MODULE 5 CODE
            /***************************************************************/
            // Instantiate at least one Teacher object            
            var t1 = new Teacher("Pat", "Murphy", new DateTime(1959, 11, 18)) { Salary = (decimal)50000.25 };

            // Add that Teacher object to your Course object
            course.Add(t1);

            // Instantiate a Degree object, such as Bachelor.
            var degree = new Degree() { Name = "Bachelor of Science" };

            // Add your Course object to the Degree object.
            degree.Course = course;

            // Instantiate a UProgram object called Information Technology
            var uprogram = new UProgram() { Name = "Information Technology" };

            // Add the Degree object to the UProgram object
            uprogram.Degree = degree;

            // Using Console.WriteLine statements, output the following information to the console window
            Console.WriteLine("The {0} program contains the {1} degree", uprogram.Name, uprogram.Degree.Name);
            Console.WriteLine("\nThe {0} degree contains the course {1}", degree.Name, degree.Course.Name);
            Console.WriteLine("\nThe {0} course contains {1} students(s)\n", course.Name, course.StudentCount);
        }
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1};\t DOB: {2};\t", FirstName, LastName, DateOfBirth.ToShortDateString());
        }
    }

    public class Student : Person        
    {
        public Student(string firstName, string lastName, DateTime dob) : base(firstName, lastName, dob) { }
        public Stack<double> Grades { get; set; } = new Stack<double>();
        public override string ToString() { return $"{FirstName} {LastName}"; }
    }

    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime dob) : base(firstName, lastName, dob) { }
        public decimal Salary { get; set; }
    }

    public class Course
    {
        private int teacherCount = 0;

        public string Name { get; set; }
        public ArrayList Students { get; set; } //***** ArrayList
        public Teacher[] Teachers { get; set; }
        public int StudentCount { get { return Students.Count; } }
        public int TeacherCount { get { return teacherCount; } }

        public Course()
        {
            Students = new ArrayList();
            Teachers = new Teacher[3];
        }

        public bool Add(Student student)
        {
            Students.Add(student);  //***** ArrayList.Add(object)
            return true;
        }

        public bool Add(Teacher teacher)
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

        public void ListStudents()  //***** ListStudents method
        {
            Console.WriteLine("Student List");
            Console.WriteLine("-----------------------");

            // WE WERE BIZZARLY ASKED TO CAST TO A STUDENT OBJECT ????
            foreach (object o in Students)
            {
                Student student = (Student)o;
                Console.WriteLine(student.ToString());
            }

            /*
            // SO MUCH EASIER TO DO THIS WAY
            foreach(Student student in Students)
            {
                Console.WriteLine(student.ToString());
            }
            */
            Console.WriteLine();
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
