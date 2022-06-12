﻿using System;

namespace Challenge2
{
    /*Challenge String and its methods 2
    Let’s create another console application for more practice.

    This application asks the user to input a string in the first line like
    “Enter a string here: ”.

    In the Second Line, it should ask for the character to search in the string 
    which you have entered in the first line like “Enter the character to search: ”

    On the third line, it should write the index of the first occurrence of the 
    searched character from the string.

    Now on concatenation...

    It should then ask to enter the first name and once the name is written and the 
    enter button is pressed, it should ask to enter the last name.

    It should then show your full name printed in a single line like in my case the 
    output will be "Denis Panjuta". Output can be different in your case. Try to store the 
    full name in a variable, before displaying it.*/


    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for string and capture value
            Console.Write("Enter a string here: ");
            string inputValue = Console.ReadLine();

            //ask for search paramter and store value
            Console.WriteLine("Enter a character to search: ");
            char searchValue = Console.ReadLine()[0];

            //get the index os the first instance of the parameter
            int searchIndex = inputValue.IndexOf(searchValue);

            Console.WriteLine("First instance of character {0} in string {1} is at index {2}", searchValue, inputValue, searchIndex);
            Console.Read();
        }
    }
}
