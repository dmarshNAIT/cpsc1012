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
            double balance = 0,
                   goalAmount; // STRETCH GOAL
            string userAnswer;

            // TODO: CHALLENGE
            // when the program first starts, ask the user for their goal
            // every time we make a deposit, we will display the amount remaining towards the goal

            do
            {
                double depositAmount = 0;
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
                        }
                        else // negative #
                        {
                            Console.WriteLine("Invalid input: you cannot deposit a negative amount.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input: please enter a numeric value.");
                    }
                } while (badInput); // loop as long as we have BAD input

                // update the balance
                balance = balance + depositAmount;

                // display the deposit and the balance, lined up by cents
                Console.WriteLine($"Deposit: {depositAmount,10:c}" +
                    $"\nBalance: {balance,10:c}");

                // ask the user if they'd like to make another deposit
                Console.Write("Would you like to make another deposit? y/n: ");
                userAnswer = Console.ReadLine().ToLower();

                // check scope
            } while (userAnswer == "y");
            Console.WriteLine("Thank you, goodbye.");
        }
    }
}
