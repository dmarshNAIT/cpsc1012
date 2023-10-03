namespace Oct3DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userContinue;

            do
            {
                // display menu & prompt user for their choice
                Console.WriteLine("Welcome to the 8am Tired Class Example.\n" +
                    "Please select your activity:\n" +
                    "Generate a [R]andom number\n" +
                    "Do a Math [Q]uiz");
                char userChoice = char.Parse(Console.ReadLine());

                // branch according to their choice
                switch (Char.ToUpper(userChoice)) // switch on uppercase value of userChoice
                {
                    case 'R':
                        // generate a random #
                        Console.WriteLine("Your random # is 42."); // TO-DO
                        break;
                    case 'Q':
                        // give them a Math question
                        Console.WriteLine("Math is under construction."); // TO-DO
                        break;
                    default:
                        Console.WriteLine("That is not a valid option.");
                        break;
                }

                // ask the user if they want to continue
                Console.Write("Would you like to play again? [Y]es or [N]o: ");
                userContinue = char.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (userContinue == 'Y' || userContinue == 'y');

            Console.WriteLine("Thanks for playing. Goodbye.");

        }
    }
}