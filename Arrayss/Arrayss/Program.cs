using System;

namespace Arrayss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 8, 5, 6};

            Console.WriteLine(numbers.Length);

            // IndexOf()

            Console.WriteLine(Array.IndexOf(numbers, 4));

            // Clear()

            Array.Clear(numbers, 0, 2);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Copy()

            int[] another = new int[3];

            Array.Copy(numbers, another, 3);

            foreach (int i in another)
            {
                Console.WriteLine(i);
            }

            //Sort()

            Array.Sort(numbers);

            //Reverse()

            Array.Reverse(numbers);

        }
    }
}
