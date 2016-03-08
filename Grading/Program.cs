using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mod8Assignment
{
    class Course
    {
        readonly private int maxStudents = 40;
        readonly private int maxTeachers = 5;

        private string courseName;
        private int credits;
        private int duration;

        private List<Student> enrolledStudents;
        //private List<Teacher> teachingStaff;

        public string Name
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }
        public int Credits
        {
            get { return this.credits; }
            set { this.credits = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Course(string nm, int cr, int dur)
        {
            Name = nm;
            Credits = cr;
            Duration = dur;

            enrolledStudents = new List<Student>();
            //teachingStaff = new List<Teacher>();
        }

        public bool addStudent(Student std)
        {
            bool rtnVal = false;

            if (enrolledStudents.Count() < maxStudents)
            {
                enrolledStudents.Add(std);
                rtnVal = true;
            }
            else
            {
                // Class is full!
                Console.WriteLine("Max Students already reached, try again next year");
            }

            return rtnVal;
        }

        public void ListStudents()
        {
            Console.WriteLine("*** Student List ***");
            foreach (var std in enrolledStudents)
            {
                Console.WriteLine("Student: {0}", std.getPersonName());
            }
        }

        public void ListStudentsWithGrades()
        {
            Console.WriteLine("*** Student List with Grades ***");
            foreach (var std in enrolledStudents)
            {
                std.showStudentScores();
            }
        }

        public int NumStudents
        {
            get { return enrolledStudents.Count(); }
        }
    }
}

///////
//// Class Student
///////

namespace Mod8Assignment
{
    class Student : Person
    {
        private Stack<int> Grades;

        public Student(string fn, string ln, string dob,
        string a1 = "", string a2 = "", string city = "",
        string state = "", string zip = "", string country = "") :
        base(fn, ln, dob, a1, a2, city, state, zip, country)
        {
            Grades = new Stack<int>();

        }

        // accept a single test score
        public void setTestScore(int score)
        {
            Grades.Push(score);

        }

        // accept an array/list of scores
        public void setTestScore(int[] scores)
        {
            foreach (int i in scores)
            {
                Grades.Push(i);

            }
        }

        public void showStudentScores()
        {
            Console.Write("{0}: ", this.getPersonName());

            // quick n dirty way to traverse the scores stack
            foreach (var i in Grades)
            {
                Console.Write("{0}, ", (int)i);
            }
            Console.WriteLine();
        }
    }
}

//////////////
//// Class Person
/////////////
namespace Mod8Assignment
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string birthDate;
        private string addressOne;
        private string addressTwo;
        private string cityStr;
        private string stateStr;
        private string zipStr;
        private string countryStr;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public string AddressOne
        {
            get { return this.addressOne; }
            set { this.addressOne = value; }
        }
        public string AddressTwo
        {
            get { return this.addressTwo; }
            set { this.addressTwo = value; }
        }
        public string City
        {
            get { return this.cityStr; }
            set { this.cityStr = value; }
        }
        public string State
        {
            get { return this.stateStr; }
            set { this.stateStr = value; }
        }
        public string Zip
        {
            get { return this.zipStr; }
            set { this.zipStr = value; }
        }
        public string Country
        {
            get { return this.countryStr; }
            set { this.countryStr = value; }
        }

        public Person()
        {
            // Blank Constructor, let the client setup the details later
        }

        public Person(string fn, string ln, string dob, string a1,
        string a2, string city, string state, string zip,
        string country)
        {
            FirstName = fn;
            LastName = ln;
            BirthDate = dob;
            AddressOne = a1;
            AddressTwo = a2;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }

        public void printPersonName()
        {
            Console.WriteLine("{0}, {1}", LastName, FirstName);
        }

        public string getPersonName()
        {
            string displayString = LastName + ", " + FirstName;
            return displayString;
        }
    }
}

/////////////////
/// Main Program
////////////////
namespace Mod8Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a global Register of Students
            List<Student> studentRegister = new List<Student>();

            // Create some students and add them to the register
            studentRegister.Add(new Student("John", "Napier", "01/01/1980"));
            studentRegister.Add(new Student("Bob", "Buildier", "02/02/1980"));
            studentRegister.Add(new Student("Larry", "Lamb", "03/03/1980"));

            Course testCourse = new Course("Programming with C#", 200, 8);

            // Add each student to the course
            foreach (var student in studentRegister)
            {
                testCourse.addStudent(student);
            }

            testCourse.ListStudents();

            // Students in the Register are still the same students added to the course
            // so we can set their scores from here

            studentRegister[0].setTestScore(new int[] { 80, 70, 60, 90, 70 });
            studentRegister[1].setTestScore(new int[] { 81, 91, 91, 71, 61 });
            studentRegister[2].setTestScore(new int[] { 82, 92, 72, 62, 82 });

            testCourse.ListStudentsWithGrades();
        }
    }
}