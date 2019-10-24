

using System;

namespace MethodsA01
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            Console.WriteLine("Welcome to our awesome program.\n");
            DisplayMenu();
            menuChoice = GetUserInput("Please enter your choice: ");

            // validate the user's input
            // see what choice the user made, 
            // and then enter that game
            // display results
            // display the menu again

            // Math quiz: we'll need 2 random numbers
            Console.ReadLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Press 1 to generate a random number.");
            Console.WriteLine("Press 2 to display a line.");
            Console.WriteLine("Press 3 to do a math quiz.");
            Console.WriteLine("Press 4 to Quit.");
        } // end of DisplayMenu() method


    }
}
