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
            int menuSelection;
            do
            {
                DisplayMenu();
                menuSelection = GetInputInt("What is your choice?");
                switch (menuSelection)
                {
                    case 1:
                        PlayRockPaperScissors();
                        break;
                    case 2:
                        // PlayNumberGuesser();
                        break;
                    case 3:
                        // GetCurrentTime(); 
                        // using DateTime.Now.ToString()
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid, please try again.");
                        break;
                }

            } while (menuSelection != 0);

        } // end of method

        static void DisplayMenu()
        {
            Console.WriteLine("1.Play Rock Paper Scissors\n" +
             "2.Play NumberGuesser5000\n" +
             "3.Get the current time\n" +
             "0.Exit\n");

        } // end of DisplayMenu()

        static void PlayRockPaperScissors()
        {
            // ask the user what move they are making
            int userMove = GetInputInt("Are you (1) rock, (2) paper, or (3) scissors?");

            // randomly generate computer move
            Random numGenerator = new Random();
            int computerMove = numGenerator.Next(1, 4);

            // compare
            if (userMove == computerMove)
                Console.WriteLine("It's a tie!");
            else if (userMove == 1 && computerMove == 3 || // rock beats scissors
                    userMove == 3 && computerMove == 2 || // scissors beats paper
                    userMove == 2 && computerMove == 1) // paper beats rock

                // userMove is 1 larger than computerMove % 3 = 0 
                // userMove is 1 larger than computerMove % 3 = 2
                // userMove is 1 larger than computerMove % 3 = 1

                // else if (userMove == (computerMove % 3) + 1)

                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost.");

        }

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
