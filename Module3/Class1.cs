using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_Assignment
{
    class Program2
    {
        //Declaring variables for student information
        static string studentFirstName;
        static string studentLastName;
        static DateTime studentBirthdate;

        //Declaring variables for teacher information
        static string teacherFirstName;
        static string teacherLastName;
        static DateTime teacherBirthdate;

        //Declaring variables for course information
        static string courseName;
        static DateTime courseStartDate;
        static DateTime courseEndDate;

        //Declaring variables for undergraduate program information
        static string uprogramName;
        static DateTime uprogramStartDate;
        static DateTime uprogramEndDate;

        //Declaring variables for degree information
        static string degreeName;
        static DateTime degreeStartDate;
        static DateTime degreeEndDate;

        static void Main2(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("Please choose one of the follow options:");
            Console.WriteLine("1) Enter new Student Information");
            Console.WriteLine("2) Enter new Teacher Information");
            Console.WriteLine("3) Enter information on a course");
            Console.WriteLine("4) Enter information on a undergraduate program");
            Console.WriteLine("5) Enter information on a degree");

            String response = Console.ReadLine();

            try
            {
                if (response == "1")
                {
                    GetStudentInformation(false);
                }
                else if (response == "2")
                {
                    GetStudentInformation(true);
                }
                else if (response == "3")
                {
                    GetCourseInformation(0);
                }
                else if (response == "4")
                {
                    GetCourseInformation(1);
                }
                else if (response == "5")
                {
                    GetCourseInformation(2);
                }
                else
                {
                    Console.WriteLine("Response Incorrect");
                    MainMenu();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
        }

        #region Get Student Information
        static void GetStudentInformation(bool isTeacher)
        {
            string whoseInfo;
            string firstName = "";
            string lastName = "";
            DateTime birthday = new DateTime(1900, 01, 01);

            if (isTeacher)
            {
                whoseInfo = "teacher";
            }
            else
            {
                whoseInfo = "student";
            }
            //Get First Name
            try
            {
                Console.WriteLine("Enter the {0}'s first name: ", whoseInfo);
                firstName = Console.ReadLine();
            }
            catch (FormatException)
            {
                throw new FormatException("This is not an accepted format, please try again");
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("No value entered, please try again");
            }

            //Get Last name
            try
            {
                Console.WriteLine("Enter the {0}'s last name: ", whoseInfo);
                lastName = Console.ReadLine();
            }
            catch (FormatException)
            {
                throw new FormatException("This is not an accepted format, please try again");
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("No value entered, please try again");
            }

            //Get Birthday
            try
            {
                Console.WriteLine("Enter the {0}'s birthdate(yyyy/mm/dd): ", whoseInfo);
                string birthdate = Console.ReadLine();
                birthday = Convert.ToDateTime(birthdate);
            }
            catch (FormatException)
            {
                throw new FormatException("This is not an accepted format, please try again");
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("No value entered, please try again");
            }

            PrintStudentDetails(isTeacher, firstName, lastName, birthday);
        }
        #endregion

        #region Get Course, UProgram, Degree Information
        static void GetCourseInformation(int typeOfInfo)
        {
            string whoseInfo = "";
            string name = "";
            DateTime startDate = new DateTime(1900, 01, 01);
            DateTime endDate = new DateTime(1900, 01, 01);

            if (typeOfInfo == 0)
            {
                whoseInfo = "Course";
            }
            else if (typeOfInfo == 1)
            {
                whoseInfo = "Undergraduate Program";
            }
            else if (typeOfInfo == 2)
            {
                whoseInfo = "Degree";
            }
            else
            {
                Console.WriteLine("Error wrong Type Info");
                MainMenu();
            }

            //Get Name
            try
            {
                Console.WriteLine("Enter the {0}s name: ", whoseInfo);
                name = Console.ReadLine();
            }
            catch (FormatException)
            {
                throw new FormatException("This is not an accepted format, please try again");
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("No value entered, please try again");
            }

            //Get start date
            try
            {
                Console.WriteLine("Enter the {0}s start date (yyyy/mm/dd): ", whoseInfo);
                string tempStartDate = Console.ReadLine();
                startDate = Convert.ToDateTime(tempStartDate);
            }
            catch (FormatException)
            {
                throw new FormatException("This is not an accepted format, please try again");
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("No value entered, please try again");
            }

            //Get end date
            try
            {
                Console.WriteLine("Enter the {0}s end date (yyyy/mm/dd): ", whoseInfo);
                string tempEndDate = Console.ReadLine();
                endDate = Convert.ToDateTime(tempEndDate);
            }
            catch (FormatException)
            {
                throw new FormatException("This is not an accepted format, please try again");
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("No value entered, please try again");
            }

            PrintCourseDetails(typeOfInfo, name, startDate, endDate);
        }
        #endregion

        #region Print Student/Teacher Details
        static void PrintStudentDetails(bool isTeacher, string first, string last, DateTime birthday)
        {
            string whoseInfo = "";

            if (isTeacher)
            {
                whoseInfo = "Teacher";
            }
            else
            {
                whoseInfo = "student";
            }
            Console.WriteLine("Is this information for the {0} correct (y/n)? ", whoseInfo);

            try
            {
                Console.WriteLine("First Name: " + first);
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong with data on first name");
            }

            try
            {
                Console.WriteLine("Last Name: " + last);
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong with data on last name");
            }

            try
            {
                Console.WriteLine("Birthdate: " + birthday.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong with data on birthdate");
            }

            string response = Console.ReadLine();

            if (response == "y" || response == "Y")
            {
                //assign temp variables to lasting ones
                if (isTeacher)
                {
                    teacherFirstName = first;
                    teacherLastName = last;
                    teacherBirthdate = birthday;
                }
                else
                {
                    studentFirstName = first;
                    studentLastName = last;
                    studentBirthdate = birthday;
                }
                Console.WriteLine("Data saved");
                MainMenu();
            }
            else if (response == "n" || response == "N")
            {
                GetStudentInformation(isTeacher);
            }
        }
        #endregion

        #region Print Course/uProgram/Degree Details
        static void PrintCourseDetails(int typeOfInfo, string name, DateTime startDate, DateTime endDate)
        {
            string whoseInfo = "";

            if (typeOfInfo == 0)
            {
                whoseInfo = "Course";
            }
            else if (typeOfInfo == 1)
            {
                whoseInfo = "Undergraduate Program";
            }
            else if (typeOfInfo == 2)
            {
                whoseInfo = "Degree";
            }
            else
            {
                Console.WriteLine("Error wrong Type Info");
                MainMenu();
            }

            Console.WriteLine("Is this information for the {0} correct (y/n)? ", whoseInfo);

            try
            {
                Console.WriteLine("{0} name: " + name, whoseInfo);
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong with data on first name");
            }

            try
            {
                Console.WriteLine("{0} start date: " + startDate.ToString(), whoseInfo);
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong with data on last name");
            }

            try
            {
                Console.WriteLine("{0} end date: " + endDate.ToString(), whoseInfo);
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong with data on birthdate");
            }

            string response = Console.ReadLine();

            if (response == "y" || response == "Y")
            {
                //assign temp variables to lasting ones
                if (typeOfInfo == 0)
                {
                    courseName = name;
                    courseStartDate = startDate;
                    courseEndDate = endDate;
                }
                else if (typeOfInfo == 1)
                {
                    uprogramName = name;
                    uprogramStartDate = startDate;
                    uprogramEndDate = endDate;
                }
                else if (typeOfInfo == 2)
                {
                    degreeName = name;
                    degreeStartDate = startDate;
                    degreeEndDate = endDate;
                }
                else
                {
                    Console.WriteLine("Info not save, please reselect from Main menu");
                    MainMenu();
                }

                Console.WriteLine("Data saved");
                MainMenu();
            }
            else if (response == "n" || response == "N")
            {
                GetCourseInformation(typeOfInfo);
            }
        }
        #endregion
    }
}