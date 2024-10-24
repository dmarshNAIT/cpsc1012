
namespace Topic6_MethodsCandyFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: declare variables
            char menuChoice;

            do
            {
                // TODO: display menu
                DisplayMenu();

                // TODO: get the user's input
                menuChoice = GetValidChar();

                // TODO: call the appropriate method
                //HandleUserChoice(menuChoice);

            } while (menuChoice != '4');

            Console.WriteLine("Thank you, goodbye.");

        }

        static char GetValidChar()
        {
            char userResponse = '\0'; // null character
            bool isValid = false;

            Console.Write("Please enter a character: ");
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That is not a valid character. Please try again: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

        static void DisplayMenu()
        {
            // Main Menu
            // 1. Populate the arrays
            // 2. Display inventory
            // 3. Display total count (& recommend re-stock)
            // 4. Quit
        }

    } // end of class
} // end of namespace
