/* Purpose: Search an array for a user-specified number in an array full of random numbers.
 * Input: Number between 1 and 10
 * Output: Message whether the number exists in the array.
 * Process: Sequential search.
 * Author: DMarsh & A01
 * Date: Last modified Nov 6
 */

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;

            // create an array
            int[] numbers = new int[ARRAY_SIZE];

            // call LoadArray to load values into the array
            LoadArray(numbers, ARRAY_SIZE);

            // display array
            DisplayArray(numbers, ARRAY_SIZE);

            // search for a user-inputted #
            Console.WriteLine(SearchArray(numbers, ARRAY_SIZE));

            Console.ReadLine();
        } // end method

        static void LoadArray(int[] arrayName, int arraySize)
        {
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                arrayName[i] = rnd.Next(1, 11);
            } // end for
        } // end method

        static void DisplayArray(int[] arrayName, int arraySize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Element {i}: {arrayName[i]}");
            } // end for
        } // end method

        static string SearchArray(int[] arrayName, int arraySize)
        {
            Console.Write("Please enter a number between 1 and 10: ");
            int searchNumber = int.Parse(Console.ReadLine());
            string message = "Your number was not found.";

            for (int i = 0; i < arraySize; i++)
            {
                if (arrayName[i] == searchNumber)
                {
                    message = "Your number WAS found.";
                } // end if
            } // end for
            return message;
        } // end method

    } // end of class
} // end of namespace




// next steps: add input validation.
// add how many times the number was found.

