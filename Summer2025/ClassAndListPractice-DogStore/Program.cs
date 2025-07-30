using System.Diagnostics;

namespace ClassAndListPractice_DogStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: create our main method loop & branching
            string userChoice;

            Console.WriteLine("Hello! Welcome to Dogma.rt!\n" +
                "Where you get more Bark for your Bite.");

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
                        // TODO: view receipt
                        break;
                    case "a":
                        // TODO: add item
                        break;
                    case "e":
                        // TODO: edit item
                        break;
                    case "d":
                         // TODO: delete an item
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


            // start the program
            // create the list
            // read from file

            // show menu
            // get user input

            // branch:
            // add
            // remove
            // edit
            // view
            // quit

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

        // TODO: create a method to read from file

        // TODO: create a method to write to a file

        // TODO: create a method to add to the receipt

        // TODO: create a method to remove an item

        // TODO: create a method to edit items in list (can change price, quantity, discount)

        // TODO: create a method to view the receipt


        static void SaveToFile(List<BetterItem> list)
        {
            try 
            {
                // create a stream
                StreamWriter writer = new StreamWriter("../../../receipt.csv");

                // give file a header row
                writer.WriteLine("TODO");

                // iterate through the list, printing each line to the file in CSV format
                for (int i = 0; i < list.Count; i++)
                {
                    // TODO
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


        static int ReadFromFile(List<BetterItem> list)
        {
            int index = 0;
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
                  
                    // TODO
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
 