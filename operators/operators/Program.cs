using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a/b);
            Console.WriteLine((float)a / (float)b);

            //operation precedence
            Console.WriteLine((a + b) * 10);

            //comparison operators

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);

            //logical operators
            Console.WriteLine(a < b && a != b);
            Console.WriteLine(a < b || a != b);

            //single lin comments

            /* multiple line comments
             * comment 1
             * comment 2
             * comment 3 */

        }
    }
}
