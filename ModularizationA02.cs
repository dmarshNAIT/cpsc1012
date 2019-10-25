using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularizationA02
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int menuSelection;
            DisplayMenu();
            menuSelection = GetUserInput("Please enter your selection.");
            ProcessMenuItem(menuSelection);


            // ask user to play again?
            // otherwise, quit
            Console.ReadLine();
        }

        static void DisplayMenu() {
            Console.WriteLine($"{0,20:MENU}");
            Console.WriteLine("Enter 1 to generate a table of random nums.");
            Console.WriteLine("Enter 2 to generate a colourful line.");
            Console.WriteLine("Enter 3 to do a math quiz.");
        }

        static int GetUserInput(string userMessage)
        {
            Console.WriteLine(userMessage);
            return int.Parse(Console.ReadLine());
        }

        static void ProcessMenuItem(int selection) {
            switch (selection)
            {
                case 1:
                    // get a variable from the user
                    // ^^ replace this code
                    GenerateRandomNums(7);
                    break;
                case 2:
                    // coloured line
                    Console.WriteLine("Here's a line: ---------"); // testing
                    break;
                case 3:
                    // math quiz
                    Console.WriteLine("Do some math."); // testing
                    break;
                default:
                    Console.WriteLine("Input was invalid.");
                    break;
            } // ends switch statement
        } //ends ProcessMenuItem() method

        static void GenerateRandomNums(int randNum)
        {
            Random rnd = new Random();
            for (int i = 0; i < randNum; i++)
                Console.WriteLine(rnd.Next());
        } // end GenerateRandomNum method

    } // ends class
} // ends namespace
