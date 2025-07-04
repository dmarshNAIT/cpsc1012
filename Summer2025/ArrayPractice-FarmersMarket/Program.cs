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
            const int MAX_SIZE = 70;                    // why? because Daniel said so.

            string[] produce = new string[MAX_SIZE];    // names of produce items
            double[] prices = new double[MAX_SIZE];     // prices of produce items
            int logicalSize = 0;                        // length or physical size of arrays

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
                        AddProduce(logicalSize++, produce, prices);
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
        /// Gets a double value from the user.
        /// </summary>
        /// <param name="question">The user prompt</param>
        /// <returns>user-inputted double</returns>
        static double GetUserDouble(string question)
        {
            double answer = 0;
            bool isValid = false;

            do
            {
                Console.Write(question);
                try
                {
                    answer = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, that's not a valid number.");
                }

            } while (isValid == false);

            return answer;
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

        /// <summary>
        /// Prompts the user to enter the name and price of a produce item.
        /// </summary>
        /// <param name="index">The logical size of the arrays</param>
        /// <param name="produce">An array containing the names of produce items</param>
        /// <param name="prices">An array containign the prices of produce items</param>
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

            producePrice = GetUserDouble("Please enter the price in $: ");
            while(producePrice <= 0)
            {
                producePrice = GetUserDouble("Price must be more than zero. Try again: ");
            }
            prices[index] = producePrice;
        }


        // TODO: method to Edit Items
        // TODO: method to Delete Items
        // TODO: (FUTURE) ability to read and write from a file
    }
}

            //Future extensions:
            //Quantity in stock?
            //Weight / diameter ?