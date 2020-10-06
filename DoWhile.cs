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
            char userChoice;

            do
            {
                char currentLetter = 'a';
                int numLetters;

                Console.WriteLine("How many letters do you want to see?");
                numLetters = int.Parse(Console.ReadLine());

                for (int counter = 0; counter < numLetters; counter++, currentLetter++)
                {
                    Console.Write(currentLetter);
                } // end for 

                Console.WriteLine("\n\nPress Q to Quit or any other letter to continue.");
                userChoice = char.Parse(Console.ReadLine());

            } while (char.ToUpper(userChoice) != 'Q');

            Console.WriteLine("Thanks for playing. Bye!");

        } // end of method
    } // end of class
} // end of namespace
