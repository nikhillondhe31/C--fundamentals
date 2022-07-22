using System;

namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[100];
            var random  = new Random();
            var password = new string(arr);

            for (int i = 0; i < 10; i++)
            {
                arr[i] = (char)random.Next(97, 122);
                password = new string(arr);
            }
            Console.WriteLine(password);


        }
    }
}
