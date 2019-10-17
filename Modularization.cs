using System;

namespace A01_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            char userResponse;
            do
            {
                Console.WriteLine();
                DisplayMenu();
                userResponse = GetUserResponse("Your selection:");
                ProcessMenuItem(userResponse);
                userResponse = GetUserResponse("\nWant to play again?");
            } while (userResponse == 'Y');

            Console.WriteLine("Thanks for playing. Byeeee.");
            Console.ReadLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Press 1 for random number generation.");
            Console.WriteLine("Press 2 to print a line.");
        }

        static char GetUserResponse(string userMessage)
        {
            char userResponse;
            Console.Write(userMessage + " ");
            Console.ForegroundColor = ConsoleColor.Blue;
            userResponse = Char.ToUpper(char.Parse(Console.ReadLine()));
            Console.ResetColor();
            return userResponse;
        }

        static void ProcessMenuItem(char menuItem)
        {
            switch (menuItem)
            {
                case '1':
                    GenerateRandomNumber();
                    break;
                case '2':
                    PrintALine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was not a valid input.");
                    Console.ResetColor();
                    break;
            }
        }

        static void GenerateRandomNumber()
        {
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(rand.Next());
            Console.ResetColor();
        }

        static void PrintALine() {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("".PadRight(Console.WindowWidth));
            Console.ResetColor();
        }
    }
}
