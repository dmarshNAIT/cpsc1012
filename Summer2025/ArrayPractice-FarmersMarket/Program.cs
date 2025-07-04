/**
 * This program stores the prices of produce items sold at a market.
 * 
 * 0
 */ 
using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace ArrayPractice_FarmersMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One array contains the names of the produce e.g.zucchini
            //Another array contains the price per item in CAD
            string userChoice;

            // welcome
            Console.WriteLine("Hello! Welcome to Method Mart!");

            do
            {
                // TODO: call the method to display menu
                DisplayMenu();

                // get user's input & TRANSLATE TO LOWERCASE
                userChoice = GetUserString("Please enter your choice: ").ToLower();
                // STRETCH CHALLENGE: Create a method that extracts just the first character from their answer (e.g. Quit would be treated like Q)

                switch(userChoice)
                {
                    case "v":
                        Console.WriteLine("TODO: VIEW ITEMS");
                        break;
                    case "a":
                        Console.WriteLine("TODO: ADD ITEMS");
                        break;
                    case "e":
                        Console.WriteLine("TODO: EDIT ITEMS");
                        break;
                    case "d":
                        Console.WriteLine("TODO: DELETE ITEMS");
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("INVALID CHOICE.");
                        break;
                }

                // if they didn't choose to quit, keep looping
            } while ( userChoice != "q"); // user choice isn't "q"

            Console.WriteLine("Thanks for shopping! Goodbye.");

        }

        //static string GetUserString( string question)
        //{
        //    string answer;
        //    // ask a question
        //    Console.Write(question);
        //    // read the user's answer
        //    answer = Console.ReadLine();
        //    // return user's answer
        //    return answer;
        //}

        /// <summary>
        /// Gets a string value from the user.
        /// </summary>
        /// <param name="question">The user prompt</param>
        /// <returns>user-inputted string value</returns>
        static string GetUserString(string question)
        {
            // ask a question
            Console.Write(question);
            // read the user's answer
            return Console.ReadLine();
        }

        /// <summary>
        /// Displays the menu options.
        /// </summary>
        static void DisplayMenu()
        {
            Console.WriteLine("\n-- MAIN MENU --\n" +
                "V: View Items\n" +
                "A: Add Items\n" +
                "E: Edit Items\n" +
                "D: Delete Item\n" +
                "Q: Quit\n");
        }

        // TODO: method to View Items

        // TODO: method to Add Items
        static void AddProduce(int index, string[] produce, double[] prices)
        {
            string produceName;
            double producePrice;

            produceName = GetUserString("Please enter the type of produce: ");

            while (produceName.Trim().Length == 0)
            {
                produceName = GetUserString("Produce name cannot be blank: ");
                // FUTURE IMPROVEMENT: can't be duplicate
            }

            produce[index] = produceName;



            // the user will provide the price of that item
            // we add it to the array if it's valid (must be > 0)

        }


        // TODO: method to Edit Items
        // TODO: method to Delete Items
        // TODO: (FUTURE) ability to read and write from a file
    }
}

            //Future extensions:
            //Quantity in stock?
            //Weight / diameter ?