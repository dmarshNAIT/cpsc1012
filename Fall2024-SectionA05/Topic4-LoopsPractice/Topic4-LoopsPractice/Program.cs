/* Program Name:    Factorial Calculator
 * Author Name:     Dana Marsh & section A05
 * Modified:        September 10, 2024
 * 
 * Purpose:         Calculate a factorial from a user-provided value. 
 *                  Loop until user chooses to exit.
 *                  
 * Input:           User-provided number.
 * Output:          The factorial (n!) of the provided value.
 */

namespace Topic4_LoopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string userAnswer;

            do
            {
                // declare variables
                int number, factorial = 1;

                // prompt the user for a number
                Console.Write("Please enter a number: ");
                number = int.Parse(Console.ReadLine());

                // future improvement: limit to 12 or smaller
                // because 13! is larger than 2.17 billion

                // start loop
                for (int counter = number; counter > 1; counter--)
                {
                    factorial = factorial * counter;
                }
                // end the loop

                // display results
                Console.WriteLine($"{number}! is equal to {factorial}.");

                // ask the user if they want to go again
                Console.Write("Would you like to calculate another? Y/N: ");
                userAnswer = Console.ReadLine().ToUpper();

            } while (userAnswer == "Y");

            Console.WriteLine("Thanks, bye!");
        }
    }
}
