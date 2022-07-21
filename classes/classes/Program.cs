using System;
using classes.Math;
using classes.Points;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "John";
            person.lastName = "Doe";

            person.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);

            Console.WriteLine(result);

            Class1 class1 = new Class1();
            Class1.Example();
        }
    }
}
