using System;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Nikhil Londhe ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("To Upper: '{0}'", fullName.ToUpper());
            
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);


            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid!");
            }

            var str = "25";

            var age = Convert.ToByte(str);

            Console.WriteLine(age);

            float price = 29.96f;

            Console.WriteLine(price.ToString("C"));
        }
    }
}
