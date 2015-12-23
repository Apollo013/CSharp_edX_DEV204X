using System;

namespace DEV204x
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            DateTime Birthdate;
            string AddressLine1;
            string AddressLine2;
            string City;
            string State;
            string Zip;
            string Country;

            FirstName = "Paul";
            LastName = "Millar";
            Birthdate = new DateTime(1971,07,21);
            AddressLine1 = "Address Line 1";
            AddressLine2 = "Address Line 1";
            City = "Some City";
            State = "Some State";
            Zip = "Some Zip";
            Country = "Some Country";

            Console.WriteLine("Full Name: {0}", FirstName + " " + LastName);
            Console.WriteLine("DOB: {0}", Birthdate);
            Console.WriteLine("Address 1:{0}", AddressLine1);
            Console.WriteLine("Address 2: {0}", AddressLine2);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("State: {0}", State);
            Console.WriteLine("Zip: {0}", Zip);
            Console.WriteLine("Country: {0}", Country);
            Console.ReadKey();

        }
    }
}
