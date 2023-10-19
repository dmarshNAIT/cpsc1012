namespace Oct18Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 7,
                MIN_NUM = 1,
                MAX_NUM = 100;
            string userResponse;

            do
            {
                bool isWinner = false;

                // create an array of ints
                int[] lottoTicket = new int[ARRAY_SIZE];

                // ask the user to provide their lotto picks
                for (int index = 0; index < lottoTicket.Length; index++)
                {
                    // prompt the user for a number
                    Console.Write("Please enter a number: ");

                    bool isInvalid = true; // or isValid = false

                    do // starts the user-input validation loop
                    {   // try/catch to make sure we can parse the number
                        try
                        {
                            // save the number into our array
                            lottoTicket[index] = int.Parse(Console.ReadLine());

                            // make sure the number is between 1 and 100
                            if (lottoTicket[index] < MIN_NUM)
                                Console.WriteLine("Must be a positive number. Try again.");
                            else if (lottoTicket[index] > MAX_NUM)
                                Console.WriteLine("Too high, please try again.");
                            else
                                isInvalid = false;    // or isValid = true;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid: please enter a #.");
                        }
                    } while (isInvalid);  // or while (!isValid)
                                          // ends the user-input validation loop

                } // end of my for-loop

                // generate a random number
                Random numGenerator = new Random();
                int winningNumber = numGenerator.Next(MIN_NUM, MAX_NUM + 1); // at least 1 & less than 101
                Console.WriteLine("The winning number is " + winningNumber);

                // loop through the user's picks, display them,
                // Your lotto numbers are: 1, 2, 3, 4, 5, 6, 7
                Console.Write("Your lotto numbers are: ");
                for (int index = 0; index < lottoTicket.Length; index++)
                {
                    Console.Write(lottoTicket[index]);

                    // for every element EXCEPT the last one, we will print a comma
                    if (index < lottoTicket.Length - 1)
                        Console.Write(", ");

                    // and determine if they are a winner
                    if (!isWinner && (lottoTicket[index] == winningNumber))
                    {
                        isWinner = true;
                    }

                } // end of display loop

                if (isWinner)
                    Console.WriteLine("\n\nCongrats! You are rich and can swim in a pile of gold coins.");
                else
                    Console.WriteLine("\n\nSorry, you did not win.");

                Console.Write("Would you like to buy another ticket?\n" +
                    "Enter Y for Yes and anything else to Exit: ");
                userResponse = Console.ReadLine();

            } while (userResponse.ToUpper().Equals("Y"));

            Console.WriteLine("Thanks for playing, goodbye.");
        }
    }
}