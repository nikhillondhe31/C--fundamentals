using System;

namespace IternationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            string name = "John Smith";

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var item in name)
            {

                Console.WriteLine(item);

            }


            var numbers = new int[] {1,2,3, 4};

            foreach (var item in numbers)
            {
                Console.WriteLine( item);
            }

            int j = 0;

            while (j <= 10)

            {
                if ((j % 2) == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }


            Console.WriteLine("+++++++++++++++++++++++++");

            while (true)
            {
                Console.Write("Type Your Name: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine(input);
                    continue;
                }

                break;
            
            }

            do { Console.WriteLine("Mosh"); }
            while (j < 10);
        }
    }
}
