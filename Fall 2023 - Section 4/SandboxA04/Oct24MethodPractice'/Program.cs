namespace Oct24MethodPractice_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice;
            string[] tvShows = new string[5];
            int numberShows = 0;

            do
            {

                // display menu
                DisplayMenu();

                // ask the user to choose an option
                //userChoice = GetValidChar();
                //Console.WriteLine("You picked " + userChoice);

                userChoice = GetValidChar("Please make your choice: ");
                Console.WriteLine("You picked " + userChoice);

                // branch based on their selection
                switch (char.ToUpper(userChoice))
                {
                    case 'E':
                        numberShows = EnterFavouriteShows(tvShows);
                        break;
                    case 'S':
                        DisplayFavouriteShows(tvShows, numberShows); 
                        break;
                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }

                // ask if they want to play again
                Console.Write("play again? y for yes, anything else for no: ");

            } while (Console.ReadLine().ToUpper().Equals("Y"));
            Console.WriteLine("Thanks for playing.");
        }


        static void DisplayMenu()
        {
            Console.Write("Welcome to our Ridiculous App!\n" +
                "\tCalculate the length of a [H]ypotenuse\n" +
                "\tReturn today's [D]ate\n" +
                "\t[E]nter your favourite shows\n" +
                "\t[S]how your watchlist\n" +
                "\tChoose what to [W]atch tonight\n" +
                "Please make your choice: ");
        }

        static char GetValidChar()
        {
            bool isValid = false;
            char userChoice = '\0'; // null char

            do
            {
                try
                {
                    userChoice = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.Write("Please try again: ");
                }
            } while (!isValid);

            return userChoice;
        }

        static char GetValidChar(string prompt)
        {
            // do the same thing, but using TryParse
            char userChoice = '\0'; // null char

            while (!char.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.Write("That's not valid. Please try again.\n" + prompt);
            }

            return userChoice;
        }

        static int EnterFavouriteShows(string[] array)
        {
            int index = 0;

            for (bool userContinue = true; index < array.Length && userContinue; index++)
            {
                // ask the user to enter a show
                Console.Write("Please enter a show: ");
                array[index] = Console.ReadLine();   // each show will be saved into an array

                // after each show, ask them if they want to continue?
                if (index < array.Length - 1)
                {
                    Console.Write("Do you have another show to enter? Y for Yes, anything else for No: ");

                    // v1:
                    //if (Console.ReadLine().ToUpper().Equals("Y"))
                    //    userContinue = true;
                    //else
                    //    userContinue = false;

                    // v2:
                    //if (!Console.ReadLine().ToUpper().Equals("Y"))
                    //    userContinue = false;

                    // v3:
                    userContinue = (Console.ReadLine().ToUpper().Equals("Y"));
                }
               
            }
            return index;
        }

        static void DisplayFavouriteShows(string[] tvShows, int numberOfShows)
        {
            for (int index = 0; index < numberOfShows; index++)
            {
                Console.WriteLine(tvShows[index]);
            }
        }

    }
}


/* what we'd like to practice:
 * loops
 * exceptions
 * Math class
 * arrays!!!
 */