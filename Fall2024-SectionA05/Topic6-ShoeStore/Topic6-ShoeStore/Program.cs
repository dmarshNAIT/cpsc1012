/*
 * Shoe Factory
 * Created by Dana Marsh & section A05
 * 
 * Purpose: To practice modularization by creating an inventory management system for a fictional shoe store.
 *          
 *          This is a menu-based program where users can choose to 
 *          A) Manually enter records
 *          B) Read records in from a file
 *          C) Display records to the screen
 *          D) Save inventory to a file
 * 
 */
using System.Runtime.Intrinsics.Arm;

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
            //} while (userChoice is not 5);  // this also works!

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

        static void HandleUserChoice(int userChoice, string[] brandz, int[] shoeLengths, int[] ukSizes, int logicalSize)
        {
            switch (userChoice)
            {
                case 1:
                    logicalSize = FillArrays(brandz, shoeLengths, ukSizes);
                    Console.WriteLine(logicalSize + " entries were added.");
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
                    logicalSize = ReadFromFile(brandz, shoeLengths, ukSizes);
                    Console.WriteLine(logicalSize + " entries were added.");
                    break;
                case 5:
                    // do nothing
                    break;
                default:
                    Console.WriteLine("That's not an option.");
                    break;
            }
        }

        static int FillArrays(string[] brandz, int[] lengths, int[] sizes)
        {
            int index = 0;
            string brandName;
            do
            {
                Console.Write("Please enter brand or type Q to exit: ");
                brandName = Console.ReadLine().ToUpper();

                if(brandName != "Q")
                {
                    brandz[index] = brandName;

                    Console.WriteLine("Please enter the length in inches.");
                    int length = GetValidInt();

                    lengths[index] = length;
                    sizes[index] = CalculateUKSize(length);

                    index++;
                }
            } while (brandName != "Q" && index < brandz.Length);

            return index; // returns the # of records
        }

        static int ReadFromFile(string[] brandz, int[] lengths, int[] sizes)
        {
            int index = 0;
            try
            {
                StreamReader reader = new StreamReader("../../../inventory.txt");
                // from the default location, we go up 3 levels and then we find inventory.txt

                reader.ReadLine(); // discard header

                // read from the stream
                for (index = 0; !reader.EndOfStream; index++)
                {
                    int lengthInInches;

                    string line = reader.ReadLine();

                    // magically split apart the brand & the length
                    string[] magicArray = line.Split("\t");
                    // magic Array will always be 2 elements long
                    // magicArray[0] will contain the brand name
                    // magicArray[1] will contain the shoe length

                    // we will put the brand name in the brandz array
                    brandz[index] = magicArray[0];

                    // we will put the shoe length in the shoe length array
                    lengthInInches = int.Parse(magicArray[1]);
                    lengths[index] = lengthInInches;

                    // put a value in the ukSizes array
                    sizes[index] = CalculateUKSize(lengthInInches);
                }

                // close the stream
                reader.Close();
                Console.WriteLine("Successfully read from file.");
            }
            catch
            {
                Console.WriteLine("Something went wrong reading the file.");
            }

            // return the # of entries read
            return index;
        }

        static int CalculateUKSize(int length)
        {
            return 3 * length - 23;
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

// TO DO: colour-code my error messages
// TO DO: add limits to user inputted ints