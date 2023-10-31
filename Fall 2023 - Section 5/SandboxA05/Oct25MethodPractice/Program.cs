namespace Oct25MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice; // will be needed in my loop logic, so is created outside the loop
            int[] bColumn = new int[5]; // we need to "remember" the card in later iterations
            int[] iColumn = new int[5]; // we need to "remember" the card in later iterations

            do
            {
                DisplayMenu();

                // ask the user to choose a menu option (as a char)
                userChoice = char.ToUpper(GetValidCharV2("Please enter your choice from the menu: "));
                // force it to be uppercase so that our later logic can be simplified

                // branch based on their selection
                switch (userChoice)
                {
                    case 'G':
                        // [G]enerate bingo card
                        break;
                    case 'D':
                        // [D]isplay bingo card
                        GenerateBColumn(bColumn);
                        DisplayBColumn(bColumn);
                        break;
                    case 'P':
                        // [P]lay a round of bingo
                        break;
                    case 'C':
                        // [C]hoose dabber colour
                        break;
                    case 'S':
                        // [S]how stats
                        break;
                    case 'Q': // [Q]uit
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not valid. Please try again.");
                        break;
                }
            } while (userChoice != 'Q');

            Console.WriteLine("Thanks for playing, goodbye.");
        }
        static void DisplayMenu()
        {
            // [G]enerate bingo card
            // [D]isplay bingo card
            // [P]lay a round of bingo
            // [C]hoose dabber colour
            // [S]how stats
            // [Q]uit
        }

        static char GetValidChar(string prompt)
        {
            bool isValid = false;
            char userChar = '\0';

            do
            {
                // prompt the user
                Console.Write(prompt);

                try
                {  // read in their response & try to parse it
                    userChar = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's invalid.");
                }
            } while (!isValid);  // loop back if not successful

            return userChar;
        }

        static char GetValidCharV2(string prompt)
        {
            char userChar = '\0';
            Console.Write(prompt);

            while (!char.TryParse(Console.ReadLine(), out userChar))
            {
                Console.Write("Sorry, that was not valid.\n" + prompt);
            }

            return userChar;
        }

        static void GenerateBColumn(int[] array)
        {
            Random numGenerator = new Random();

            // loop through each element in my array
            // for each element, generate a random # between 1 and 15

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = numGenerator.Next(1, 16);
            }
            // TO DO: next step would be to generalize this for all columns.
        }

        static void DisplayBColumn(int[] array)
        {
            Console.WriteLine("The B column contains:");
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
            // TO DO: clean up the code redundancy
        }
    }
}

/* practice:
 * xor
 * formatting output
 * Math
 * try parse
 * array as a param
 */