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
            // create 3x3 array
            int[,] mant = new int[3, 3];
            
            LoadArray(mant);
            DisplayArray(mant);

            int numTimesFound = SearchArray(mant);
            Console.WriteLine($"Your number was found {numTimesFound} times.");

        } // end of method

        static void LoadArray(int[,] myArray)
        {
            Random numGen = new Random();

            for (int rowIndex = 0; rowIndex < myArray.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < myArray.GetLength(1); colIndex++)
                {
                    myArray[rowIndex, colIndex] = numGen.Next(10);
                } // end column for-loop
            } // end row-for-loop
        } // end of LoadArray()

        static void DisplayArray(int[,] myArray)
        {
            for (int rowIndex = 0; rowIndex < myArray.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < myArray.GetLength(1); colIndex++)
                {
                    Console.Write(myArray[rowIndex, colIndex] + " ");
                } // end column for-loop
                Console.WriteLine();
            } // end row-for-loop
        } // end of DisplayArray()

        static int SearchArray(int[,] myArray)
        {
            int occurrences = 0;
            int numberToFind = GetInputInt("What number are you searching for?");

            for (int rowIndex = 0; rowIndex < myArray.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < myArray.GetLength(1); colIndex++)
                {
                    if (myArray[rowIndex, colIndex] == numberToFind)
                        occurrences++;
                } // end column for-loop
            } // end row-for-loop

            return occurrences; 

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
