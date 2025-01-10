/* Game to play Connect 4, using the ConnectFour class.
 * This was written in one sitting and only briefly tested, so please let me know if you find any bugs!
 * Thanks, and enjoy!
 */


using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            char playAgain;
            do
            {
                // generate a board:
                ConnectFour game = new ConnectFour();
                game.PlayGame();

                playAgain = GetUserChar("Want to play another round? (y/n)");

            } while (char.ToLower(playAgain) == 'y');

            Console.Write("Thanks for playing!");
            Console.ReadLine();

        } // end method

        public static char GetUserChar(string prompt)
        {
            char userInput;
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (!char.TryParse(Console.ReadLine(), out userInput))
            {
                Console.ResetColor();
                Console.WriteLine($"Sorry, invalid. Please try again.\n{prompt}");
                Console.ForegroundColor = ConsoleColor.Cyan;
            } // end while
            Console.ResetColor();
            return userInput;
        } // end method

        public static int GetUserInt(string prompt)
        {
            int userInput;
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.ResetColor();
                Console.WriteLine($"Sorry, invalid. Please try again.\n{prompt}");
                Console.ForegroundColor = ConsoleColor.Cyan;
            } // end while
            Console.ResetColor();
            return userInput;
        } // end method

        public static ConsoleColor GetUserColour()
        {
            ConsoleColor chosenColor;
            char userResponse = GetUserChar("Would you like to play with [R]ed, [B]lue, or [C]yan?");
            switch (char.ToUpper(userResponse))
            {
                case 'R':
                    chosenColor = ConsoleColor.Red;
                    break;
                case 'B':
                    chosenColor = ConsoleColor.Blue;
                    break;
                case 'C':
                    chosenColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.WriteLine("That wasn't an option. I'll pick for you.");
                    chosenColor = ConsoleColor.Magenta;
                    break;
            } // end switch
            return chosenColor;
        } // end method

        public static void WriteInColour(string message, ConsoleColor colour, bool writeLine = false)
        {
            Console.ForegroundColor = colour;
            Console.Write(message);
            Console.ResetColor();
            if (writeLine)
                Console.WriteLine();
        } // end method

    } // end program
} // end class
