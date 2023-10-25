namespace Oct25MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            DisplayMenu();

            // ask the user to choose a menu option (as a char)
            userChoice = GetValidChar("Please make your choice: ");

           // branch based on their selection
           // ask if they'd like to play again
        }
        static void DisplayMenu()   {
            // [G]enerate bingo card
            // [D]isplay bingo card
            // [P]lay a round of bingo
            // [C]hoose dabber colour
            // [S]how stats
        }
        static char GetValidChar(string prompt){
            bool isValid = false;
            char userChar = '\0';

            do
            {
                // prompt the user
                Console.WriteLine(prompt);

                try
                {  // read in their response & try to parse it
                    userChar = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's invalid.");
                }
            } while ( !isValid );  // loop back if not successful
            return userChar;
        }
    }
}

/* practice:
 * xor
 * formatting output
 * Math
 * try parse
 * array as a param
 */