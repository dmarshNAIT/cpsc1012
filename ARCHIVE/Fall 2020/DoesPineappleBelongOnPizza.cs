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
            // introduce program
            Console.WriteLine("Welcome to our program, where we tackle an essential Q.");

            // declare variables
            bool isValidInput;
            string userChoice; // maybe a more detailed variabe name in a longer program?

            do
            {
                // asking the user for a choice (yes/no)
                Console.WriteLine("Do you think that pineapple belongs on pizza (yes/no)?");
                userChoice = Console.ReadLine().ToLower();

                if (userChoice == "yes" || userChoice == "no")
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid response. Please try again.");
                    isValidInput = false;
                } // end if-statement
            } while (!isValidInput);

            // this do-while replaced the following original code: 
            //// asking the user for a choice (yes/no)
            //Console.WriteLine("Do you think that pineapple belongs on pizza (yes/no)?");
            //userChoice = Console.ReadLine().ToLower();

            //if (userChoice == "yes" || userChoice == "no")
            //{
            //    isValidInput = true;
            //}
            //else
            //{
            //    isValidInput = false;
            //} // end if-statement

            //while (!isValidInput) // while the input is invalid
            //{ // prompt them again
            //    Console.WriteLine("Sorry, I don't understand.\n" +
            //        "Do you think that pineapple belongs on pizza (yes/no)?");
            //    userChoice = Console.ReadLine().ToLower();
            //    isValidInput = (userChoice == "yes" || userChoice == "no") ? true : false;
            //} // end validation while loop

            switch (userChoice)
            {
                case "yes":
                    Console.WriteLine("You are right.");
                    break;
                case "no":
                    Console.WriteLine("I disagree.");
                    break;
                default:
                    Console.WriteLine("That was not a valid response.");
                    break;
            } // end switch statement on user choice


        } // end of method
    } // end of class
} // end of namespace
