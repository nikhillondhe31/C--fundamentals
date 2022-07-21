using System;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mosh";
            string lastName = "Smosh";
            String firstName2 = "Jason";

            string fullName = firstName + " " + lastName;
            
            string fullName2 = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(fullName2);

            string[] names = new string[] { firstName, lastName };
            string values = string.Join(",", names);

            Console.WriteLine(values);

            var text = "Hi John\nLook into the following path \nc: \\folder";
            Console.WriteLine(text);

            var verbatimText = @"Hi John
Look into the following path
c:\folders";
            Console.WriteLine(verbatimText);
        }
    }
}
