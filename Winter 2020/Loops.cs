/*  Purpose:        Program to determine a user's average score based on user-inputted marks.
    Process:        1. Ask the user how many marks they are entering, then prompt for each mark.
                    2. Display average mark.
                    3. Ask the user if they have another average to calculate, and if so, loop back to start.
    Input:          The number of marks the user wishes to enter, and each mark.
    Output:         The user's average score.
    Author:         Dana Marsh
    Last modified:  Feb 12, 2020
*/

using System;

namespace A05_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare
            char response;          // to capture user's response

            do
            {
                // declare:
                int countOfEntries;     // user input
                double averageMark;     // output
                double sum = 0;         // running total
                
                // prompt
                Console.WriteLine("how many marks are you entering?");
                countOfEntries = int.Parse(Console.ReadLine());

                // process
                for (int counter = 1; counter <= countOfEntries; counter++) {
                    Console.WriteLine("Please enter mark #" + counter + ":");
                    double mark = double.Parse(Console.ReadLine());
                    sum += mark;
                } // end for

                averageMark = sum / countOfEntries;

                // display
                Console.WriteLine("Your average mark is " + averageMark);

                Console.WriteLine("Do you have another student's marks to input? (y/n)");
                response = char.Parse(Console.ReadLine());

            } while (response == 'y');

            Console.WriteLine("Thanks for playing!");

        } // end of method
    } // end of class
} // end of namespace
