using System.Diagnostics;

namespace ClassAndListPractice_DogStore
{
    internal class Program
    {
        // TODO: Add missing documentation
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
                        Console.WriteLine("INVALID CHOICE.");
                        break;
                }

                // if they didn't choose to quit, keep looping
            } while (userChoice != "q"); // user choice isn't "q"

            Console.WriteLine("Thanks for shopping! Goodbye.");

        }

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
                    Console.WriteLine("Sorry, that's not a valid number.");
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
                    Console.WriteLine(ex.Message);
                }

            } while ( !isValidInput);

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
                    Console.WriteLine(ex.Message);
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
                    Console.WriteLine(ex.Message);
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
                    Console.WriteLine(ex.Message);
                }

            } while (!isValidInput);

            // add the object to the List
            items.Add(item);
            Console.WriteLine("Your item has been added.");
        }

        static void RemoveItem(List<BetterItem> items)
        {
            if ( items.Count < 1)
                Console.WriteLine("There are no items to remove.");
            else
            {
                int indexToRemove;
                
                DisplayReceipt(items);
                indexToRemove = GetUserInt("Please enter the ID you want to remove: ") - 1;
                while (indexToRemove < 0 || indexToRemove >= items.Count)
                {
                    Console.WriteLine("That was not a valid number. Try again.");
                    indexToRemove = GetUserInt("Please enter the ID you want to remove: ") - 1;
                }

                items.RemoveAt(indexToRemove);
                Console.WriteLine($"Item #{indexToRemove + 1} has been deleted.");
            }
        }

        // TODO: create a method to edit items in list (can change price, quantity, discount)
        static void EditItems(List<BetterItem> items)
        {
            string userChoice;
            int indexToEdit;

            DisplayReceipt(items);

            indexToEdit = GetUserInt("Please enter the ID you want to edit: ") - 1;
            while (indexToEdit < 0 || indexToEdit >= items.Count)
            {
                Console.WriteLine("That was not a valid number. Try again.");
                indexToEdit = GetUserInt("Please enter the ID you want to edit: ") - 1;
            } // TODO: make this a helper method since the same code is used in 2 places

            // ask the user which property they want to edit
            userChoice = GetUserString("You can edit the\n" +
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
                        Console.WriteLine("Successfully updated.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "q":
                    // update the quantity
                    try
                    {
                        items[indexToEdit].Quantity = GetUserInt("Please enter the new quantity: ");
                        Console.WriteLine("Successfully updated.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "d":
                    // update the discount amount
                    try
                    {
                        items[indexToEdit].Discount = GetUserInt("Please enter the new price: ");
                        Console.WriteLine("Successfully updated.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("That wasn't an option. Returning to main menu.");
                    break;
            }
        }

        static void DisplayReceipt(List<BetterItem> items)
        {
            if (items.Count == 0)
                Console.WriteLine("There are no items to display.");
            else
            {
                // loop through the elements in the list
                // display the properties for each

                Console.WriteLine("ID Name               Price    # Discount           " +
                    "Total");

                for (int i = 0; i < items.Count; i++)
                {
                    string name = items[i].Name;
                    double price = items[i].Price;
                    int quantity = items[i].Quantity;
                    int discount = items[i].Discount;
                    double totalCost = items[i].TotalCostPerItem;
                    string discountLevel = items[i].DiscountLevel;

                    Console.WriteLine($"{i + 1:00} {name,-15}{price,9:c} {quantity,4}{discount,4}%" +
                        $"{discountLevel,10}{totalCost,10:c}");
                }
            }
        }


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
                Console.WriteLine("Successfully saved to file.");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, something went wrong saving to file.");
                Console.ResetColor();
            }
        }


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
                Console.WriteLine("Successfully read from file.");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, something went wrong reading the file.");
                Console.ResetColor();
            }

        }
    }
}
 