using System;

namespace Module06
{
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
}
