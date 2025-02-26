/*
 * Purpose:  Prompt user for deposits into a temporary savings account.
 * Author:   Dana & OE01
 * Modified: Feb 25, 2025
 */
namespace PiggyBankLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double depositAmount,
                   balance,
                   goalAmount; // STRETCH GOAL
            bool badInput = true; // when the program starts, we do NOT have good input yet

            do
            {
                Console.Write("Please enter the amount of your deposit: $");
                try
                {
                    depositAmount = double.Parse(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        badInput = false;
                    } else // negative #
                    {
                        Console.WriteLine("Invalid input: you cannot deposit a negative amount.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input: please enter a numeric value.");
                }
            } while (badInput); // loop as long as we have BAD input

            // validate their input
            // update the balance
            // display the deposit and the balance, lined up by cents

            // ask the user if they'd like to make another deposit

        }
    }
}
