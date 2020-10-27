/* Author:          Dana Marsh with input from you
 * Last mod date:   
 * Input:           
 * Output:          
 * Process:         
 * This is my sandbox and I haven't filled out my opening doc... oops.
 */

using System;
using System.Net.Http.Headers;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;
            int[] myArray = new int[ARRAY_SIZE];

            LoadArray(myArray);
            DisplayArray(myArray);

            bool isFound = SearchArray(myArray);

            if (isFound)
            {
                Console.WriteLine("It's found!");
            }
            else
            {
                Console.WriteLine("Number was not found.");
            }

            // alternate ways we could have done this:
            // return the location where it is 1st found
            // return the number of times it's in the array

            Console.ReadLine();
        } // end of method

        static void LoadArray(int[] myArray)
        {
            Random keygen = new Random();
            for (int index = 0; index < myArray.Length; index++)
            {
                myArray[index] = keygen.Next(0, 11);
                // myArray[index] = GetInputInt("pls enter #");
            } // end of my for loop
        } // end of LoadArray()

        static void DisplayArray(int[] myArray)
        {
            for (int index = 0; index < myArray.Length; index++)
            {
                Console.WriteLine($"Element #{index}: {myArray[index]}");
            } // end of for loop
        } // end of DisplayArray()

        static bool SearchArray(int[] myArray)
        {
            // declare variables
            bool isFound = false;
            int numberToFind;

            // ask the user for a number
            numberToFind = GetInputInt("What number do you want to search for?");

            // loop through each element in the array
            for (int index = 0; index < myArray.Length && !isFound; index++)
            {
                // compare each element to the # we're looking for
                if (myArray[index] == numberToFind)
                    isFound = true;
            } // end for loop

            // returns true if it's found, false otherwise
            return isFound;
        } // end SearchArray()

        static string GetInputString(string prompt)
        {
            Console.Write(prompt);
            string name = Console.ReadLine();
            return name;
        } // end of GetInput()

        static int GetInputInt(string prompt)
        {
            int userInt = 0; // initial value to make VS happy
            bool isValid = false;
            do
            {
                Console.WriteLine(prompt);
                string rawInput = Console.ReadLine();
                try
                {
                    userInt = int.Parse(rawInput);
                    isValid = true;
                } // end of try-block
                catch
                {
                    Console.WriteLine("How dare you.");
                } // end of catch-block
            } while (!isValid);
            return userInt;
        } // end of GetInputInt()

    } // end of class
} // end of namespace
