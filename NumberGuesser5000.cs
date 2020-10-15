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
            // variables
            Random numGenerator = new Random();
            int randomNum, attempts = 0;
            bool winner = false;

            // intro
            Console.WriteLine("Welcome to our Number Guesser 5000.");

            // generate a random # (1-10)
            randomNum = numGenerator.Next(1, 11); // 1 to 10

            do
            {
                // crashes with a decimal - NEED TO TEST
                // accepts negative numbers - NEED TO TEST

                int userGuess = 0; // initial value to be overwritten
                bool validInput = false;
                do
                {
                    // ask user to guess
                    Console.Write("Guess a number 1-10: ");

                    // get their response & try to parse
                    try
                    {
                        userGuess = int.Parse(Console.ReadLine());
                        if (userGuess >= 1 && userGuess <= 10)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("That's out of range.");
                        }   // end else       
                    }
                    catch
                    {
                        Console.WriteLine("Sorry, invalid input.");
                    }
                } while (!validInput);

                // display results:
                if (userGuess == randomNum)
                {
                    Console.WriteLine("Correct!");
                    winner = true;
                } // end if-correct
                else if (userGuess > randomNum)
                {
                    Console.WriteLine("Your guess is too high. Guess again.");
                } // end if too high
                else
                {
                    Console.WriteLine("Your guess is too low. Guess again.");
                } // end else
                attempts++;

            } while (!winner);

            Console.WriteLine($"You guessed it in {attempts} guesses.");

            // bonus-challenge 1: limit their guesses to 3 --> GAME OVER
            // add another bool for gameOver, and then adjust our output messages 

            // bonus challenge 2: let them play again with a new number
            // ANOTHER do-while for everything.

        } // end of method
    } // end of class
} // end of namespace
