using System;

namespace Module06
{
    public class Student : Person
    {
        public int Points { get; set; }

        public Student(string firstName, string lastName, DateTime dob, int points)
            :base(firstName,lastName,dob)
        {
            Points = points;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Points: {0}", Points);
        }
    }
}
