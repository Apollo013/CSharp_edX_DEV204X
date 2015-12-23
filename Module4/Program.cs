using System;
using System.Text;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 5 student objects
            Student stud1 = new Student() { FirstName = "Alan", LastName = "Murphy", Address1 = "some address 1", Address2 = "some add2", City = "some city", State = "some state", Country = "some country", Zip = "some zip" };
            Student stud2 = new Student() { FirstName = "Mary", LastName = "Murphy", Address1 = "some address 2", Address2 = "some add2", City = "some city", State = "some state", Country = "some country", Zip = "some zip" };
            Student stud3 = new Student() { FirstName = "Wilma", LastName = "Flintstone", Address1 = "some address 3", Address2 = "some add2", City = "some city", State = "some state", Country = "some country", Zip = "some zip" };
            Student stud4 = new Student() { FirstName = "Harvey", LastName = "Wallbanger", Address1 = "some address 4", Address2 = "some add2", City = "some city", State = "some state", Country = "some country", Zip = "some zip" };
            Student stud5 = new Student() { FirstName = "Sophie", LastName = "Dahl", Address1 = "some address 5", Address2 = "some add2", City = "some city", State = "some state", Country = "some country", Zip = "some zip" };

            // Array to hold 5 students
            Student[] students = new Student[5];

            // Add students to array
            students[0] = stud1;
            students[1] = stud2;
            students[2] = stud3;
            students[3] = stud4;
            students[4] = stud5;

            // Assign Name value in array
            students[1].LastName = "Thompson";

            // Output all students
            foreach(Student stud in students)
            {
                Console.WriteLine(stud.ToString());
            }
        }
    }

    public struct Student
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string FullName
        {
            get
            {
                string prefix = "Full Name: ";
                if ((FirstName != null && FirstName != String.Empty) && (LastName != null && LastName != String.Empty))
                {
                    return prefix + FirstName + " " + LastName;
                }
                else if ((FirstName != null && FirstName != String.Empty) && (LastName == null || LastName == String.Empty))
                {
                    return prefix + FirstName;
                }
                else
                {
                    return prefix + LastName;
                }
            }
        }
        public string FullAddress
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Address: ");

                if (Address1 != null && Address1 != String.Empty)
                {
                    sb.Append(Address1 + ", ");
                }
                if (Address2 != null && Address2 != String.Empty)
                {
                    sb.Append(Address2 + ", ");
                }
                if (City != null && City != String.Empty)
                {
                    sb.Append(City + ", ");
                }
                if (State != null && State != String.Empty)
                {
                    sb.Append(State + ", ");
                }
                if (Country != null && Country != String.Empty)
                {
                    sb.Append(Country + ", ");
                }
                if (Zip != null && Zip != String.Empty)
                {
                    sb.Append(Zip);
                }
                return sb.ToString();
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return FullName + "\n" + FullAddress + "\n";
        }
        #endregion
    }

    public struct Teacher
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string FullName
        {
            get
            {
                string prefix = "Full Name: ";
                if ((FirstName != null && FirstName != String.Empty) && (LastName != null && LastName != String.Empty))
                {
                    return prefix + FirstName + " " + LastName;
                }
                else if ((FirstName != null && FirstName != String.Empty) && (LastName == null || LastName == String.Empty))
                {
                    return prefix + FirstName;
                }
                else
                {
                    return prefix + LastName;
                }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return FullName + " Salary: " + Salary + "\n";
        }
        #endregion
    }

    public struct Course
    {
        #region Properties
        public string Name { get; set; }
        public int Points { get; set; }
        public decimal PassRate { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Course Name: " + Name + "\nPoints: " + Points + ", PassRate: " + PassRate + " %\n";
        }
        #endregion
    }

    public struct uProgram
    {
        #region Properties
        public string Name { get; set; }
        public int Points { get; set; }
        public decimal Cost { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Program Name: " + Name + "\nRequired Points: " + Points + ", Cost: " + Cost + " %\n";
        }
        #endregion
    }

}

