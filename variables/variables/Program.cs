using System;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 32;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'a';
            var firstName = "Nikhil";
            var isWorking = true;


            Console.WriteLine(number);
            Console.WriteLine(character);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(count);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float pi = 3.14f;

            Console.WriteLine(pi);
        }
    }
}
