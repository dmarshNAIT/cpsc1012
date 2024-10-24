

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

            } while (menuChoice != '4');

            Console.WriteLine("Thank you, goodbye.");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("MAIN MENU\n" +
                "\t1. Populate the arrays\n" +
                "\t2. Display inventory\n" +
                "\t3. Display total count\n" +
                "\t4. Quit\n");
        }

        static void HandleUserChoice(char choice, string[] candy, int[] inventory)
        {
            switch (choice)
            {
                case '1':
                    PopulateArrays(candy, inventory);
                    break;
                case '2':
                    DisplayInventory();
                    break;
                case '3':
                    DisplayTotalInventoryCount();
                    break;
                case '4':
                    // do nothing
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    break;
            }
        }

        static void PopulateArrays(string[] candy, int[] inventory)
        {
            Console.WriteLine("put things in arrays now");
            //TODO: complete method

            // OPTION A:
            // ask the user how many types of candy they have
            // loop through, ask them for each candy name & inventory level

            // YOUR CHALLENGE: code this!

            // alternate approach we could have taken:
            // ask them to enter a candy name, OR enter 0 to quit
            // then they enter the inventory
        }

        static void DisplayInventory()
        {
            Console.WriteLine("we are displaying inventory!");
            //TODO: complete method
        }

        static void DisplayTotalInventoryCount()
        {
            Console.WriteLine("we are in the display total inventory method!");
            //TODO: complete method
            // TODO: suggest re-stock if inventory levels are low
        }

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

    } // end of class
} // end of namespace