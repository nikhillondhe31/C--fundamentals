using System;

namespace typeconversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;

            Console.WriteLine(i);


            //will result in data loss
            int j = 1000;
            byte c = (byte)j;

            Console.WriteLine(c);

            //non-compatible types

            try
            {
                string number = "1234";
                byte k = Convert.ToByte(number);
                Console.WriteLine(k);

            }
            catch (Exception ex)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }


            string str = "True";

            try
            {
                bool b1 = Convert.ToBoolean(str);
            }
            catch (Exception)
            {

                Console.WriteLine("the string could not be converted to boolean");
            }


        }
    }
}
