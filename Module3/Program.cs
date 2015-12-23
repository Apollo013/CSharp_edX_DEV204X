using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();
            GetProgramInformation();
            GetDegreeInformation();
            

            ValidateDate(new DateTime(2015, 11, 18));
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the student's DOB");
            string birthday = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthday);

        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }


        /******** TEACHER *********/
        static void GetTeacherInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's salary (deciaml please)");
            decimal salary = Decimal.Parse(Console.ReadLine());

            PrintTeacherDetails(firstName, lastName, salary);

        }

        static void PrintTeacherDetails(string first, string last, decimal salary)
        {
            Console.WriteLine("{0} {1} salary is: {2}", first, last, salary);
        }


        /******** COURSE *********/
        static void GetCourseInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the course name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the course code");
            string code = Console.ReadLine();

            Console.WriteLine("Enter the course cost (deciaml please)");
            decimal cost = Decimal.Parse(Console.ReadLine());

            PrintCourseDetails(name, code, cost);

        }

        static void PrintCourseDetails(string name, string code, decimal cost)
        {
            Console.WriteLine("Course {0} {1} costs: {2}", name, code, cost);
        }


        /******** PROGRAM *********/
        static void GetProgramInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the program name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the program code");
            string code = Console.ReadLine();

            Console.WriteLine("Enter the program cost (deciaml please)");
            decimal cost = Decimal.Parse(Console.ReadLine());

            PrintProgramDetails(name, code, cost);

        }

        static void PrintProgramDetails(string name, string code, decimal cost)
        {
            Console.WriteLine("Program {0} ({1}) costs: {2}", name, code, cost);
        }

        /******** DEGREE *********/
        static void GetDegreeInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the degree name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the degree level (integer please)");
            int level = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the degree points (integer please)");
            int points = Int32.Parse(Console.ReadLine());

            PrintDegreeDetails(name, level, points);

        }

        static void PrintDegreeDetails(string name, int level, int points)
        {
            Console.WriteLine("{0} ({1}) requires {2} points", name, level, points);
        }


        /******** THROW  'NotImplementedException' *********/
        public static void ValidateDate(DateTime date) {
            var ex = new NotImplementedException("NOT IMPLEMENTED YET !!!!!!");
            throw ex;
        }

    }

}
