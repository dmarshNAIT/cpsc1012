/* Author:          Dana Marsh with input from you
 * Last mod date:   
 * Input:           
 * Output:          
 * Process:         
 * This is my sandbox and I haven't filled out my opening doc... oops.
 */

using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[10]; // indexes 0-9

        } // end of method


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
