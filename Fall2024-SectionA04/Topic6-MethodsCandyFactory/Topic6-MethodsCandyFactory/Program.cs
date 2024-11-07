/// <summary>
/// A program to demonstrate modularization, branching, and reading/writing from a text file.
/// </summary>
namespace Topic6_MethodsCandyFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PHYSICAL_SIZE = 13; //because Hallowe'en

            char menuChoice;
            string[] candyBucket = new string[PHYSICAL_SIZE]; // names of our candy
            int[] candyCount = new int[PHYSICAL_SIZE]; // inventory level per candy

            do
            {
                DisplayMenu();
                menuChoice = GetValidChar();
                HandleUserChoice(menuChoice, candyBucket, candyCount);

            } while (menuChoice != 'Q');

            Console.WriteLine("Thank you, goodbye.");
        }

        /// <summary>
        /// Displays the main menu options.
        /// </summary>
        static void DisplayMenu()
        {
            Console.WriteLine("MAIN MENU\n" +
                "\t1. Populate the arrays\n" +
                "\t2. Display inventory\n" +
                "\t3. Display total count\n" +
                "\t4. Read data from file\n" +
                "\t5. Save data to file\n" +
                "\t6. Edit inventory level\n" +
                "\tQ. Quit");
        }

        /// <summary>
        /// Branches according to user selection.
        /// </summary>
        /// <param name="choice">the selected menu option</param>
        /// <param name="candy">an array of candy names</param>
        /// <param name="inventory">an array of stock levels</param>
        static void HandleUserChoice(char choice, string[] candy, int[] inventory)
        {
            bool isEmpty = (candy[0] == null);

            switch (choice)
            {
                case '1':
                    PopulateArrays(candy, inventory);
                    break;
                case '2':
                    if (isEmpty)
                    {
                        Console.WriteLine("Nothing to display.");
                    }
                    else
                    {
                        DisplayInventory(candy, inventory);
                    }
                    break;
                case '3':
                    DisplayTotalInventoryCount(candy, inventory);
                    break;
                case '4':
                    ReadFromFile(candy, inventory);
                    break;
                case '5':
                    if (isEmpty)
                    {
                        Console.WriteLine("Nothing to save.");
                    }
                    else
                    {
                        SaveToFile(candy, inventory);
                    }
                    break;
                case '6':
                    if (isEmpty)
                    {
                        Console.WriteLine("Nothing to edit.");
                    }
                    else
                    {
                        EditInventory(candy, inventory);
                    }
                    break;
                case 'Q':
                    // do nothing
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    break;
            }
        }

        /// <summary>
        /// Prompt the user for values to fill the arrays.
        /// </summary>
        /// <param name="candy">an array of candy names</param>
        /// <param name="inventory">a parallel array of inventory levels</param>
        static void PopulateArrays(string[] candy, int[] inventory)
        {
            int candyTypeCount;

            Console.WriteLine("We need to know how many types of candy you will be storing.");
            candyTypeCount = GetValidInt(0, candy.Length);

            for (int index = 0; index < candyTypeCount && index < candy.Length; index++)
            {
                Console.Write("Please enter candy name: ");
                candy[index] = Console.ReadLine().Trim();

                Console.WriteLine("What is the inventory level?");
                inventory[index] = GetValidInt(0, 1000000);
            }


            // alternate approach we could have taken:
            // ask them to enter a candy name, OR enter 0 to quit
            // then they enter the inventory
            // check out the A05 Shoe Factory example if you want to see what this could look like
        }

        /// <summary>
        /// Display the inventory level in a tabular format.
        /// </summary>
        /// <param name="candy">an array of candy names</param>
        /// <param name="inventory">a parallel array of inventory levels</param>
        static void DisplayInventory(string[] candy, int[] inventory)
        {
            const int CANDY_COLUMN_WIDTH = 15;
            const int INVENTORY_COLUMN_WIDTH = 9;

            // print out the headers for the table
            Console.WriteLine("\nID     CANDY NAME     INVENTORY\n" +
                "-----------------------------");

            for (int i = 0; i < candy.Length && candy[i] != null; i++)
            { // alternate condition: String.IsNullOrEmpty(candy[i])
                Console.WriteLine($"{i + 1:00}     {candy[i],-CANDY_COLUMN_WIDTH}" +
                    $"{inventory[i],INVENTORY_COLUMN_WIDTH}");
            }

            Console.WriteLine(); // blank line after table 

            // alternatively: we could have created a separate variable which contained the LOGICAL size
        }

        /// <summary>
        /// Calculates and displays total quantity of inventory.
        /// </summary>
        /// <param name="candy">an array of candy names</param>
        /// <param name="inventory">a parallel array of inventory levels</param>
        static void DisplayTotalInventoryCount(string[] candy, int[] inventory)
        {
            const int MINIMUM_CANDY = 100;
            int totalQuantity = 0;

            for (int index = 0; index < candy.Length && candy[index] != null; index++)
            {
                totalQuantity += inventory[index];
            }

            Console.WriteLine($"In total, there are {totalQuantity:n0} pieces of candy.");

            if (totalQuantity < MINIMUM_CANDY)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("RESTOCK ALERT!");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Allows the user to modify one entry in the array.
        /// </summary>
        /// <param name="candy">an array of candy names</param>
        /// <param name="inventory">a parallel array of inventory levels</param>
        static void EditInventory(string[] candy, int[] inventory)
        {
            string userAnswer;
            do
            {
                int index;

                DisplayInventory(candy, inventory);

                Console.WriteLine("Which candy would you like to edit?");
                index = GetValidInt(1, candy.Length) - 1;

                Console.WriteLine("What is the new inventory level?");
                inventory[index] = GetValidInt(0, 1000000);

                Console.Write("Is there another you'd like to edit?\nEnter Y for yes and anything else to quit: ");
                userAnswer = Console.ReadLine().ToUpper();

            } while (userAnswer == "Y");
        }

        /// <summary>
        /// Read in candy names & inventory levels from a text file.
        /// </summary>
        /// <param name="names">an array of candy names</param>
        /// <param name="counts">a parallel array of inventory level</param>
        static void ReadFromFile(string[] names, int[] counts)
        {
            try
            {
                // create a stream
                StreamReader reader = new StreamReader("../../../inventory.txt");

                // throw away the header line
                reader.ReadLine();

                // read it in, line by line
                for (int i = 0; !reader.EndOfStream; i++)
                {
                    string line = reader.ReadLine();

                    // split up line, using that \t as delimiter
                    string[] magicArray = line.Split("\t");
                    // magicArray has 2 elements:
                    // magicArray[0] is the candy name
                    // magicArray[1] is the inventory

                    // save the name to the names array
                    names[i] = magicArray[0];
                    // save the counts to the counts array
                    counts[i] = int.Parse(magicArray[1]);

                }

                Console.WriteLine("File successfully loaded.");

                // close the stream
                reader.Close();
            }
            catch
            {
                Console.WriteLine("Error reading file.");
            }
        }

        /// <summary>
        /// Saves candy names & inventory levels to a text file.
        /// </summary>
        /// <param name="names">an array of candy names</param>
        /// <param name="counts">a parallel array of inventory level</param>
        static void SaveToFile(string[] names, int[] counts)
        {
            try
            {
                // create our StreamWriter object
                StreamWriter writer = new StreamWriter("../../../inventory.txt");

                // hardcode the header line
                writer.WriteLine("CANDY\tCOUNT");

                // for each candy:
                for (int i = 0; i < names.Length && names[i] != null; i++)
                {
                    // write to the file the candy name,
                    // then a tab
                    // then the candy inventory level
                    writer.WriteLine(names[i] + "\t" + counts[i]);
                }

                // close the stream
                writer.Close();

                Console.WriteLine("File successfully saved.");
            }
            catch
            {
                Console.WriteLine("Error saving to file.");
            }
        }

        /// <summary>
        /// Reads in a character from the Console.
        /// </summary>
        /// <returns>user-inputted character</returns>
        static char GetValidChar()
        {
            char userResponse = '\0'; // null character
            bool isValid = false;

            Console.Write("Please enter a character: ");
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That is not a valid character. Please try again: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

        /// <summary>
        /// Reads in an int from the Console.
        /// </summary>
        /// <returns>an int</returns>
        static int GetValidInt()
        {
            int userResponse = 0;
            bool isValid = false;

            Console.Write("Please enter a number: ");
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That is not a valid number. Please try again: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

        /// <summary>
        /// Reads in an int from the Console within a specified range.
        /// </summary>
        /// <param name="minNumber">smallest valid value</param>
        /// <param name="maxNumber">largest valid value</param>
        /// <returns>an int between <c>minNumber</c> and <c>maxNumber</c>, inclusive</returns>
        static int GetValidInt(int minNumber, int maxNumber)
        {
            int userResponse = 0;
            bool isValid = false;

            while (!isValid)
            {
                userResponse = GetValidInt();
                if (userResponse < minNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That number is too small.");
                    Console.ResetColor();
                }
                else if (userResponse > maxNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That number is too large.");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                }
            }
            return userResponse;
        }

    } // end of class
} // end of namespace
