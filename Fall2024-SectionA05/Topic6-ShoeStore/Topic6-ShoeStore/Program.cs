
//TODO: DOCUMENTATION

namespace Topic6_ShoeStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            const int PHYSICAL_SIZE = 50;
            string[] brandz = new string[PHYSICAL_SIZE];
            int[] shoeLengths = new int[PHYSICAL_SIZE];
            int[] ukSizes = new int[PHYSICAL_SIZE];
            int logicalSize = 0;

            do
            {
                DisplayMainMenu();
                userChoice = GetValidInt();
                HandleUserChoice(userChoice, brandz, shoeLengths, ukSizes, logicalSize);

            } while (userChoice != 5);
            // userChoice is not 5
            // ^ will also work

            Console.WriteLine("Thanks, goodbye!");
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("MAIN MENU\n" +
                "\t1. Fill Arrays\n" +
                "\t2. Display Arrays\n" +
                "\t3. Save to File\n" +
                "\t4. Import from File\n" +
                "\t5. Quit\n");
        }

        static void HandleUserChoice(int userChoice)
        {// TODO: update our parameters
            switch (userChoice)
            {
                case 1:
                    logicalSize = FillArrays(brandz, shoeLengths, ukSizes, logicalSize);
                    // TODO: create this method
                    // uk size = 3 * length - 23
                    // this method will use a sentinel value
                    Console.WriteLine("filling arrays");
                    break;
                case 2:
                    //DisplayArrays();
                    Console.WriteLine("displaying arrays");
                    break;
                case 3:
                    //SaveToFile();
                    Console.WriteLine("saving");
                    break;
                case 4:
                    //ReadFromFile();
                    Console.WriteLine("loading");
                    break;
                case 5:
                    // do nothing
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    break;
            }
        }

        static int GetValidInt()
        {
            int inputValue = 0;
            bool isValid = false;
            do
            {
                Console.Write("Please enter a number: ");
                try
                {
                    inputValue = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid. Please try again.");
                    Console.ResetColor();
                }
            } while (!isValid);

            return inputValue;
        } // end of the method
    } // end of the clas
}


// TODO:
// arrays: one for brands, one for length, one for sizes