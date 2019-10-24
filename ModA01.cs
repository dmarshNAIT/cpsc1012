/*  Purpose:        A menu-driven program.
 *  Process:        User is shown a menu, and can select:
 *                      1: Generate a random number
 *                      2: Generate a coloured line
 *                      3: Play a math quiz
 *                      4: Quit
 *  Input:          Main program: user enters choice.
 *                      Rand num:
 *                      Line:
 *                      Math quiz: user enters their answer.
 *  Output:         Rand num:
 *                  Line:
 *                  Math quiz: A confirmation or error message.
 *  Author:         D Marsh & A01
 *  Last mod date:  Oct 24, 2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsA01
{
    class Modularization
    {
        static void Main(string[] args)
        {
            int menuChoice;
            Console.WriteLine("Welcome to our awesome program.\n");
            DisplayMenu();
            menuChoice = GetUserInput("Please enter your choice: ");

            while (menuChoice < 1 || menuChoice > 4)
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                DisplayMenu();
                menuChoice = GetUserInput("Please enter your choice: ");
            } // end of while loop

            ProcessMenuItem(menuChoice);

            // display results
            // display the menu again

            // Math quiz: we'll need 2 random numbers
            Console.ReadLine();
        } // end of Main method

        static void DisplayMenu()
        {
            Console.WriteLine("Press 1 to generate a random number.");
            Console.WriteLine("Press 2 to display a line.");
            Console.WriteLine("Press 3 to do a math quiz.");
            Console.WriteLine("Press 4 to Quit.");
        } // end of DisplayMenu() method

        static int GetUserInput(string userMessage)
        {
            Console.WriteLine(userMessage);
            return int.Parse(Console.ReadLine());
        } // end of GetUserInput method

        static void ProcessMenuItem(int i)
        {
            switch (i)
            {
                case 1:
                    // GetRandomNumber();
                    break;
                case 2:
                    // go to coloured line method
                    break;
                case 3:
                    // go to math quiz method
                    break;
            } // end of switch
        } // end of ProcessMenuItem method



    } // end of class
} // end of namespace