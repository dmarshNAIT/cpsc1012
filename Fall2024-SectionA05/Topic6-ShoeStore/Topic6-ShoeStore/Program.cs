

namespace Topic6_ShoeStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            do
            {
                DisplayMainMenu();
                userChoice = GetValidInt();
                //HandleUserChoice(userChoice);

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
        }
    }
}


// TODO:
// Create Handler method which will branch based on the user's selection

// arrays: one for brands, one for length, one for sizes