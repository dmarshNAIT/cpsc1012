namespace Oct23MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string userAnswer; // probably re-name?
                               // created outside the do-while so we can access it outside the do-while

            do
            {
                // declare variables
                char userChoice;

                // display the menu
                DisplayMenu();

                // get the user's choice
                userChoice = GetValidChar("What do you choose?");

                // execute accordingly
                switch (userChoice)
                {
                    case 'G':
                        // generate random #
                        // homework: write the method header for this method
                        break;
                    case 'H':
                        // play hangman
                        // homework: write the method header for this method
                        break;
                    case 'R':
                        // play rock paper scissors
                        // homework: write the method header for this method
                        break;
                    case 'T':
                        // play tic tac toe
                        // homework: write the method header for this method
                        break;
                    default:
                        // some sort of error message
                        break;
                }

                // ask them if they'd like to play again
                Console.WriteLine("Would you like to play again? Enter Y for Yes and anything else to Exit.");
                userAnswer = Console.ReadLine();
            } while ( userAnswer.ToUpper().Equals("Y") );

            Console.WriteLine("Thanks for playing, goodbye.");
        }

        static void DisplayMenu()
        {
            // [G]enerate random #s
            // [R]ock paper scissors
            // [H]angman
            // [T]ic tac toe

            // homework: make this look cool
        }

        static char GetValidChar(string prompt)
        {
            // ask the user "prompt"
            // try to parse their answer 
            // if successful, return that value
            return 'x'; // placeholder to make Visual Studio happy
            // otherwise, loop back to the start and try again

            // homework: attempt a first draft of this method
        }

    }
}

/* Wish list
 * 
 * switch statement
 * something similar to assignment 3
 * while
 * exceptions
 */ 