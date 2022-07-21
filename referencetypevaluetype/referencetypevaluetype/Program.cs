using System;

namespace referencetypevaluetype
{
    internal class Program
    {

        public class Person
        {
            public int Age;
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;

            b++;

            Console.WriteLine(String.Format("a: {0}, b:{1}", a, b));

            //reference type

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = arr1;

            arr2[0] = 0;
            Console.WriteLine(arr1[0]);

            int number = 10;
            Increment(number);
            Console.WriteLine(number);

            Person person = new Person();
            person.Age = 10;
            MakeOld(person);
            Console.WriteLine(person.Age);


        }
    }
}
