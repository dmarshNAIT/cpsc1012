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
                userChoice = GetValidChar("What do you choose? ");

                // execute accordingly
                switch (userChoice)
                {
                    case 'G':
                        // generate random #
                        int myNum = CreateRandomNumber();
                        break;
                    case 'H':
                        PlayHangman();
                        break;
                    case 'R':
                        PlayRockPaperScissors();
                        break;
                    case 'T':
                        PlayTicTacToe();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, that's not a valid option.");
                        Console.ResetColor();
                        break;
                }
                Environment.Exit(0);

                // ask them if they'd like to play again
                Console.WriteLine("Would you like to play again? Enter Y for Yes and anything else to Exit.");
                userAnswer = Console.ReadLine();
            } while (userAnswer.ToUpper().Equals("Y"));

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
            char userChar = '\0'; // null character
            bool isValid = false;

            do
            {
                // prompt the user
                Console.Write(prompt);

                // try to parse their answer 
                try
                {
                    userChar = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's not valid.");
                }
                // instead of a try catch, another approach to avoid the problem would be to check the length of the string returned by ReadLine(), and only parse it if the length == 1
            } while (!isValid);

            return userChar;  // if successful, return that value
        }

        static int CreateRandomNumber()
        {
            return 0; // placeholder to make VS happy
        }

        static void PlayHangman()
        {

        }

        static void PlayRockPaperScissors()
        {

        }

        static void PlayTicTacToe()
        {

        }


    }
}

/* Wish list
 * 
 * switch statement
 * something similar to assignment 3
 * while
 * exceptions
 * array containing decimal/double values
 */ 