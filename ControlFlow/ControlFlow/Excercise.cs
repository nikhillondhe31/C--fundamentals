using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow
{
    internal class Excercise
    {
        /*
         *1- Write a program and ask the user to enter a number. 
         *The number should be between 1 to 10.
         *If the user enters a valid number, display "Valid" on the console.
         *Otherwise, display "Invalid". (This logic is used a lot in applications where 
         *values entered into input boxes need to be validated.)
         */


        public static void CheckNumbers()
        {
            bool condition = true;
            string userInput;
            while (condition)
            {

                Console.WriteLine("Please Enter a Number between 1 and 10: ");
                userInput = Console.ReadLine();
                if (userInput == null || Int32.Parse(userInput) > 10 ||
                   Int32.Parse(userInput) < 0)
                {
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }
                else
                {
                    condition = false;
                }

            }
        }


        public static void MaxofTwo()
        {
            /*
             * 2- Write a program which 
             * takes two numbers from the console and displays the 
             * maximum of the two.
             * 
             3- Write a program and ask the user to enter the
            width and height of an image.
            Then tell if the image is landscape or portrait.
            */
            string width;
            string height;
            Console.Write("Enter width of the image: ");
            width = Console.ReadLine();

            Console.Write("Enter height of the image: ");
            height = Console.ReadLine();

            string orientation = Int64.Parse(width) > Int64.Parse(height) ? "The image is in landscape mode" : "The image is in portrait mode";

            Console.WriteLine(orientation);
            int maximum = Math.Max(Int32.Parse(width),
                Int32.Parse(height));
            Console.WriteLine(maximum);
        }


        public static void SpeedCheck()
        {
            int speedLimit, speed;
            Console.Write("Enter Speed Limit: ");
            speedLimit = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Speed of the Vehicle: ");
            speed = Int32.Parse(Console.ReadLine());

            DetermineDemeritorSuspension(speedLimit, speed);


        }

        public static void DetermineDemeritorSuspension(int speedLimit, int speed)
        {

            if (speed > speedLimit)
            {
                int demerits = (speed - speedLimit) / 5;

                if (demerits > 12 )
                {
                    Console.WriteLine("License Suspended!!");
                }
                else
                {
                    Console.WriteLine(string.Format("OverSpeeding, demerits received: {0}", demerits));
                }
            }
            else
            {
                Console.WriteLine("OK!");
            }

        }
    }
}
