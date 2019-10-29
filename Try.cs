using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInputString;
            char userInputChar;

            Console.WriteLine("what is your first initial?");

            userInputString = Console.ReadLine();

            //try
            //{
            //    userInputChar = char.Parse(userInputString);
            //    Console.WriteLine($"Your initial is {userInputChar}");
            //}
            //catch
            //{
            //    Console.WriteLine("That was not a valid input.");
            //}

            bool isValidInput = char.TryParse(userInputString, out userInputChar);

            Console.WriteLine(isValidInput);

            while(!isValidInput)
            {
                Console.WriteLine("Try again.");
                userInputString = Console.ReadLine();
                isValidInput = char.TryParse(userInputString, out userInputChar);

            }

            Console.WriteLine($"Your initial is {userInputChar}");

            Console.WriteLine("Bye.");
            Console.ReadLine();
        }


    }
}
