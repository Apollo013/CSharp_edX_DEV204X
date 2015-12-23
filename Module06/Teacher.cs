using System;

namespace Module06
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        public Teacher(string firstName, string lastName, DateTime dob, decimal salary)
            : base(firstName, lastName, dob)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Salary: {0}",Salary);
        }
    }
}
