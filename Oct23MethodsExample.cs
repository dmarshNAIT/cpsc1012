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
            do
            {
                // DisplayMenu();
                    // 1. Play Rock Paper Scissors
                    // 2. Play NumberGuesser5000
                    // 3. Get the current time
                    // 0. Exit
                int userChoice = GetUserChoice();
                switch (userChoice)
                {
                    case 1:
                        // PlayRockPaperScissors();
                        break;
                    case 2:
                        // PlayNumberGuesser();
                        break;
                    case 3:
                        // GetCurrentTime();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid, please try again.");
                        break;
                }

            } while (userInput != 0);

        } // end of method
        static string GetInputString()
        {
            Console.Write("Enter your name: ");
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
