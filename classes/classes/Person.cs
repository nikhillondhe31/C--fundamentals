﻿using System;

namespace classes
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine( "My name is: " + firstName + lastName);
        }
    }
}
