using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var Array = new int[10];
            for (var i = 0; i < 10; i++)
            {
                Array[i] = i + 1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (var i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    evens.Add(Array[i]);
                } else
                {
                    odds.Add(Array[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            string result = "Evens: ";
            bool spacer = false;
            foreach (var item in evens)
            {
                if (spacer == true)
                {
                    result += ", ";
                }
                result += item;
                spacer = true;
            }
            Console.WriteLine(result);
            spacer = false;
            result = "Odds: ";
            foreach (var item in odds)
            {
                if (spacer == true)
                {
                    result += ", ";
                }
                result += item;
                spacer = true;
            }
            Console.WriteLine(result);
        }
    }
}
