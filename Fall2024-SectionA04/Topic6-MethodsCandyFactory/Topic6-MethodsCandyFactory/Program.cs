//TODO: DOCUMENTATION
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
            int candyTypeCount;

            Console.WriteLine("We need to know how many types of candy you will be storing.");
            candyTypeCount = GetValidInt();

            for (int index = 0; index < candyTypeCount; index++)
            {
                Console.Write("Please enter candy name: ");
                candy[index] = Console.ReadLine();

                Console.WriteLine("What is the inventory level?");
                inventory[index] = GetValidInt();
            }


            // alternate approach we could have taken:
            // ask them to enter a candy name, OR enter 0 to quit
            // then they enter the inventory
            // check out the A05 Shoe Factory example if you want to see what this could look like
        }

        static void DisplayInventory(string[] candy, int[] inventory)
        {

            // loop until we hit a null value
            // YOUR CHALLENGE: code this method

            // alternatively: we could have created a separate variable which contained the LOGICAL size

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

    } // end of class
} // end of namespace

// TODO: add a method later that lets us add to an existing array
// TODO: add file functionality?
// TODO: add some kind of chart/viz