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

            Console.WriteLine("Hello! Welcome to Method Mart!");

            do
            {
                // call the method to display menu
                DisplayMenu();

                // get user's input & TRANSLATE TO LOWERCASE
                userChoice = GetUserString("Please enter your choice: ").ToLower();
                // STRETCH CHALLENGE: Create a method that extracts just the first character from their answer (e.g. Quit would be treated like Q)

                switch (userChoice)
                {
                    case "v":
                        ViewItems(produce, prices, logicalSize);
                        break;
                    case "a":
                        AddProduce(logicalSize++, produce, prices);
                        break;
                    case "e":
                        EditItems(produce, prices, logicalSize);
                        break;
                    case "d":
                        Console.WriteLine("TODO: DELETE ITEMS");
                        break;
                    case "l":
                        logicalSize = ReadFromFile(produce, prices);
                        break;
                    case "s":
                        SaveToFile(produce, prices, logicalSize);
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("INVALID CHOICE.");
                        break;
                }

                // if they didn't choose to quit, keep looping
            } while (userChoice != "q"); // user choice isn't "q"

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

        static int GetUserInt(string question)
        {
            int answer = 0;
            bool isValid = false;

            do
            {
                Console.Write(question);
                try
                {
                    answer = int.Parse(Console.ReadLine());
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
                "L: Load Items from File\n" +
                "S: Save Items to File\n" +
                "Q: Quit\n");
        }

        /// <summary>
        /// Prints the contents of the two parallel arrays.
        /// </summary>
        /// <param name="produce">An array of produce item names</param>
        /// <param name="prices">An array containing the corresponding prices</param>
        /// <param name="logicalSize">logical size of each array</param>
        static void ViewItems(string[] produce, double[] prices, int logicalSize)
        {
            // have a warning message if the arrays are empty
            if (logicalSize <= 0)
            {
                //Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Sorry, no items to display.");
                Console.ResetColor();
            }
            else
            {
                // iterate through every element 
                // display the name of the produce
                // display the price of that produce item
                // make sure it looks nice

                // have a heading row
                Console.WriteLine("\n   ITEM              PRICE");

                for (int i = 0; i < logicalSize; i++)
                {
                    Console.WriteLine($"{i + 1:00} {produce[i],-15} {prices[i],7:c}");
                }
            }
        }

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
            while (producePrice <= 0)
            {
                producePrice = GetUserDouble("Price must be more than zero. Try again: ");
            }
            prices[index] = producePrice;
        }


        // TODO: method to Edit Items
        static void EditItems(string[] produce, double[] prices, int logicalSize)
        {
            int index;
            double newPrice;
            
            // display the elements
            ViewItems(produce, prices, logicalSize);

            // ask the user which one they want to change
            index = GetUserInt("Please enter the # of the item you wish to edit: ") - 1;
            while (index < 0 || index >= logicalSize)
            {
                index = GetUserInt("Please enter a valid #: ") - 1;
            }

            // ask them for the new price
            newPrice = GetUserDouble("Please enter the new price in $: ");
            while(newPrice <= 0)
            {
                newPrice = GetUserDouble("Not a valid price. Try again: ");
            }
            prices[index] = newPrice;

            Console.WriteLine("Successfully updated.");
        }


        // TODO: method to Delete Items
        // TODO: (FUTURE) ability to read and write from a file

        /// <summary>
        /// Saves contents of parallel arrays to a CSV file.
        /// </summary>
        /// <param name="produce">An array containing the names of produce items</param>
        /// <param name="prices">An array containign the prices of produce items</param>
        /// <param name="logicalSize">logical size of each array</param>
        static void SaveToFile(string[] produce, double[] prices, int logicalSize)
        {
            try
            {
                // create a stream
                StreamWriter writer = new StreamWriter("../../../market.csv");

                // give file a header row
                writer.WriteLine("produce,price");

                // iterate through the arrays, printing each line to the file in CSV format
                for (int i = 0; i < logicalSize; i++)
                {
                    writer.WriteLine($"{produce[i]},{prices[i]:N2}");
                }

                // close the stream
                writer.Close();
                Console.WriteLine("Successfully saved to file.");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, something went wrong saving to file.");
                Console.ResetColor();
            }
        }

        static int ReadFromFile(string[] produce, double[] prices)
        {
            int index = 0;
            try
            {
                // create the stream
                StreamReader reader = new StreamReader("../../../market.csv");

                // read and discard the header (line 1)
                reader.ReadLine();

                // read from file, line by line
                // add the name of the produce to the produce array
                // add the price of the produce to the prices array
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');
                    // we now have a 2-element array containing the name & price
                    string produceName = parts[0];
                    double producePrice = double.Parse(parts[1]);
                    // let's move the name into the name array
                    produce[index] = produceName;
                    // let's move the price into the price array
                    prices[index] = producePrice;
                    index++;
                }

                // close the stream
                reader.Close();
                Console.WriteLine("Successfully read from file.");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, something went wrong reading the file.");
                Console.ResetColor();
            }
            return index;
        }
    }
}

//Future extensions:
//Quantity in stock?
//Weight / diameter ?



// TODO: ADD XML