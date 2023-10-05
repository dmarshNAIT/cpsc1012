namespace Oct4DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice,
                userContinue;

            Console.WriteLine("Welcome!");

            do
            {
                Console.WriteLine("Please make your selection:\n" +
                    "Display [R]andom Number\n" +
                    "Do a Math [Q]uiz\n");
                userChoice = char.Parse(Console.ReadLine());

                switch (char.ToUpper(userChoice))  // force it to be uppercase
                {
                    case 'R':
                        Console.WriteLine("Your random # is 42.");
                        break;
                    case 'Q':
                        Console.WriteLine("Math quiz is under construction.");
                        break;
                    default:
                        Console.WriteLine("That was not an option. Try again.");
                        break;
                }

                Console.Write("Would you like to continue: [Y]es or [N]o: ");
                userContinue = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (userContinue == 'Y' || userContinue == 'y');

            Console.WriteLine("Goodbye, enjoy fall break.");

        }
    }
}