namespace Oct24MethodPractice_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            // display menu
            DisplayMenu();

            // ask the user to choose an option
            //userChoice = GetValidChar();
            //Console.WriteLine("You picked " + userChoice);

            userChoice = GetValidChar("Please make your choice: ");
            Console.WriteLine("You picked " + userChoice);

            // branch based on their selection
            // ask if they want to play again
        }

        static void DisplayMenu()
        {
            Console.Write("Welcome to our Ridiculous App!\n" +
                "\tCalculate the length of a [H]ypotenuse\n" +
                "\tReturn today's [D]ate\n" +
                "\t[E]nter your favourite shows\n" +
                "\tChoose what to [W]atch tonight\n" +
                "Please make your choice: ");
        }

        static char GetValidChar()
        {
            bool isValid = false;
            char userChoice = '\0'; // null char

            do
            {
                try
                {
                    userChoice = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.Write("Please try again: ");
                }
            } while (!isValid);

            return userChoice;
        }

        static char GetValidChar(string prompt)
        {
            // do the same thing, but using TryParse
            char userChoice = '\0'; // null char

            while (!char.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.Write("That's not valid. Please try again.\n" + prompt);
            }

            return userChoice;
        }
    }
}


/* what we'd like to practice:
 * loops
 * exceptions
 * Math class
 * arrays!!!
 */