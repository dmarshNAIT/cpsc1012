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
                while (userResponse != '1' && userResponse != '2')
                {
                    PrintMessageInColour("That was not a valid input.", ConsoleColor.Red);
                    userResponse = GetUserResponse("Your selection:");
                }
                ProcessMenuItem(userResponse);
                userResponse = GetUserResponse("\nWant to play again? (y/n)");
            } while (userResponse == 'Y');

            Console.WriteLine("\nThanks for playing. Byeeee.");
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
            }
        }

        static void GenerateRandomNumber()
        {
            Random rand = new Random();
            PrintMessageInColour(rand.Next().ToString(), ConsoleColor.Green);
        }

        static void PrintALine()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("".PadRight(Console.WindowWidth));
            Console.ResetColor();
        }

        static void PrintMessageInColour(string inputMessage, ConsoleColor messageColour)
        {
            Console.ForegroundColor = messageColour;
            Console.WriteLine(inputMessage);
            Console.ResetColor();
        }
    }
}