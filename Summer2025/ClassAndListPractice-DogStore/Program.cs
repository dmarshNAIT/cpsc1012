/*
 * A program to test our 
 */
namespace ClassAndListPractice_DogStore
{
    internal class Program
    {
        /// <summary>
        /// Entry point to the program: displays options and branches based on user choice.
        /// </summary>
        /// <param name="args">n/a</param>
        static void Main(string[] args)
        {

            List<BetterItem> items = new List<BetterItem>();
            string userChoice;

            Console.WriteLine("Hello! Welcome to Dogma.rt!\n" +
                "Where you get more Bark for your Bite.");
            ReadFromFile(items);

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
                        DisplayReceipt(items);
                        break;
                    case "a":
                        AddItem(items);
                        break;
                    case "e":
                        EditItems(items);
                        break;
                    case "d":
                        RemoveItem(items);
                        break;
                    case "q":
                        SaveToFile(items);
                        break;
                    default:
                        PrintInColour("INVALID CHOICE.", "red");
                        break;
                }

                // if they didn't choose to quit, keep looping
            } while (userChoice != "q"); // user choice isn't "q"

            Console.WriteLine("Thanks for shopping! Goodbye.");

        }

        /// <summary>
        /// Original Part A testing
        /// </summary>
        static void RunPartATest()
        {
            BetterItem item1 = new BetterItem();
            BetterItem item2 = new BetterItem("zebra print lavender scented calming care rest blanket", 20, 1, 0);
            //BetterItem item3 = new BetterItem("harness", -5, -7, 150);

            BetterItem item4 = new BetterItem("dog treats", 2, 5, 25);
            Console.WriteLine(item4.TotalCostPerItem);

            BetterItem item5 = new BetterItem("kitty litter", 25, 1, 90);
        }

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
                    PrintInColour("Sorry, that's not a valid number.", "red");
                }

            } while (isValid == false);

            return answer;
        }

        /// <summary>
        /// Gets an int value from the user.
        /// </summary>
        /// <param name="question">The user prompt</param>
        /// <returns>user-inputted int</returns>
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
                    PrintInColour("Sorry, that's not a valid number.", "red");
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

        /// <summary>
        /// Add an item to the List based on user input.
        /// </summary>
        /// <param name="items">A list containing items</param>
        static void AddItem(List<BetterItem> items)
        {
            // create a "default" object
            BetterItem item = new BetterItem();
            bool isValidInput = false;

            // ask the user for the name, price, quantity, discount
            do
            {
                try
                {
                    item.Name = GetUserString("Please enter the item name: ");
                    isValidInput = true;
                }
                catch (Exception ex)
                {
                    PrintInColour(ex.Message, "red");
                }

            } while (!isValidInput);

            isValidInput = false;
            do
            {
                try
                {
                    item.Price = GetUserDouble("Please enter the item price in $: ");
                    isValidInput = true;
                }
                catch (Exception ex)
                {
                    PrintInColour(ex.Message, "red");
                }

            } while (!isValidInput);

            isValidInput = false;
            do
            {
                try
                {
                    item.Quantity = GetUserInt("Please enter the quantity: ");
                    isValidInput = true;
                }
                catch (Exception ex)
                {
                    PrintInColour(ex.Message, "red");
                }

            } while (!isValidInput);

            isValidInput = false;
            do
            {
                try
                {
                    item.Discount = GetUserInt("Please enter the discount as a number: ");
                    isValidInput = true;
                }
                catch (Exception ex)
                {
                    PrintInColour(ex.Message, "red");
                }

            } while (!isValidInput);

            // add the object to the List
            items.Add(item);
            PrintInColour("Your item has been added.", "yellow");
        }

        /// <summary>
        /// Allow the user to choose one item from the list to be removed.
        /// </summary>
        /// <param name="items">A list containing BetterItem objects</param>
        static void RemoveItem(List<BetterItem> items)
        {
            if (items.Count < 1)
            {
                PrintInColour("There are no items to remove.", "red");
            }
            else
            {
                int indexToRemove;

                DisplayReceipt(items);
                indexToRemove = GetValidIndex(items, "Please enter the # of the item you want to remove: ");

                items.RemoveAt(indexToRemove);
                PrintInColour($"Item #{indexToRemove + 1} has been deleted.", "yellow");
            }
        }

        /// <summary>
        /// Allows the user to edit the price, quantity, or discount for an existing item.
        /// </summary>
        /// <param name="items">A list containing BetterItem objects</param>
        static void EditItems(List<BetterItem> items)
        {
            DisplayReceipt(items);

            if (items.Count > 0)
            {
                int indexToEdit = GetValidIndex(items, "Please enter the ID you want to edit: ");

                // ask the user which property they want to edit
                string userChoice = GetUserString("You can edit the\n" +
                    "\t[P]rice\n" +
                    "\t[Q]uantity\n" +
                    "\t[D]iscount rate\n" +
                    "Enter your choice: ").ToLower();

                // branch accordingly
                switch (userChoice)
                {
                    case "p":
                        // update the price
                        try
                        {
                            items[indexToEdit].Price = GetUserDouble("Please enter the new price: ");
                            PrintInColour("Successfully updated.", "yellow");
                        }
                        catch (Exception ex)
                        {
                            PrintInColour(ex.Message, "red");
                        }
                        break;
                    case "q":
                        // update the quantity
                        try
                        {
                            items[indexToEdit].Quantity = GetUserInt("Please enter the new quantity: ");
                            PrintInColour("Successfully updated.", "yellow");
                        }
                        catch (Exception ex)
                        {
                            PrintInColour(ex.Message, "red");
                        }
                        break;
                    case "d":
                        // update the discount amount
                        try
                        {
                            items[indexToEdit].Discount = GetUserInt("Please enter the new price: ");
                            PrintInColour("Successfully updated.", "yellow");
                        }
                        catch (Exception ex)
                        {
                            PrintInColour(ex.Message, "red");
                        }
                        break;
                    default:
                        PrintInColour("That wasn't an option. Returning to main menu.", "red");
                        break;
                }
            }
        }

        /// <summary>
        /// A helper method to validate that an index is within the bounds of the collection.
        /// </summary>
        /// <param name="items">A List of objects</param>
        static int GetValidIndex(List<BetterItem> items, string message)
        {
            // user will enter "real" number, we will subtract 1 to find the index
            // e.g. the first item is item #1, which has the index of 0
            int index = GetUserInt(message) - 1;
            while (index < 0 || index >= items.Count)
            {
                PrintInColour("That was not a valid number. Try again.", "red");
                index = GetUserInt(message) - 1;
            }
            return index;
        }

        /// <summary>
        /// Displays contents of the List formatted as a receipt.
        /// </summary>
        /// <param name="items">A collection of BetterItem objects</param>
        static void DisplayReceipt(List<BetterItem> items)
        {
            if (items.Count == 0)
                PrintInColour("There are no items to display.", "red");
            else
            {
                // loop through the elements in the list
                // display the properties for each

                Console.WriteLine("ID " +
                    "Name".PadRight(15) +
                    "Price ".PadLeft(10) +
                    "  # " +
                    "Discount".PadRight(15) +
                    "Total".PadLeft(10) +
                    "\n" + new string('-', 57));

                for (int i = 0; i < items.Count; i++)
                {
                    string name = items[i].Name;
                    double price = items[i].Price;
                    int quantity = items[i].Quantity;
                    int discount = items[i].Discount;
                    double totalCost = items[i].TotalCostPerItem;
                    string discountLevel = items[i].DiscountLevel;

                    Console.WriteLine($"{i + 1:00} " +
                        $"{name,-15}" +
                        $"{price,9:c}" +
                        $"{quantity,4} " +
                        $"{discount}% ({discountLevel})".PadRight(15) +
                        $"{totalCost,10:c}");
                }
            }
        }

        /// <summary>
        /// Saves the contents of the List to a CSV file.
        /// </summary>
        /// <param name="list">A List of BetterItem objects</param>
        static void SaveToFile(List<BetterItem> list)
        {
            try
            {
                // create a stream
                StreamWriter writer = new StreamWriter("../../../receipt.csv");

                // give file a header row
                writer.WriteLine("name,price,quantity,discount");

                // iterate through the list, printing each line to the file in CSV format
                for (int i = 0; i < list.Count; i++)
                {
                    string name = list[i].Name;
                    double price = list[i].Price;
                    int quantity = list[i].Quantity;
                    int discount = list[i].Discount;
                    writer.WriteLine($"{name},{price},{quantity},{discount}");
                }

                // close the stream
                writer.Close();
                PrintInColour("Successfully saved to file.", "yellow");
            }
            catch (Exception)
            {
                PrintInColour("Sorry, something went wrong saving to file.", "red");
            }
        }

        /// <summary>
        /// Reads the CSV, creates BetterItem objects, and adds them to the List.
        /// </summary>
        /// <param name="list">A collection of BetterItem objects</param>
        static void ReadFromFile(List<BetterItem> list)
        {
            try
            {
                // create the stream
                StreamReader reader = new StreamReader("../../../receipt.csv");

                // read and discard the header (line 1)
                reader.ReadLine();

                // read from file, line by line
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    string name = parts[0];
                    double price = double.Parse(parts[1]);
                    int quantity = int.Parse(parts[2]);
                    int discount = int.Parse(parts[3]);

                    // use those to create a new object
                    BetterItem item = new BetterItem(name, price, quantity, discount);

                    // add that object to the list
                    list.Add(item);
                }

                // close the stream
                reader.Close();
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintInColour($"Successfully read {list.Count} records from file.", "yellow");
                Console.ResetColor();
            }
            catch (Exception)
            {
                PrintInColour("Sorry, something went wrong reading the file.", "red");
            }

        }

        /// <summary>
        /// Because messages are more fun in colour.
        /// </summary>
        /// <param name="message">Message to print</param>
        /// <param name="colour">string representation of colour</param>
        static void PrintInColour(string message, string colour)
        {
            switch(colour.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
