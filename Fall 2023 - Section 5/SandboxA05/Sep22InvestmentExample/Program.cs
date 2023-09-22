/* purpose:     calculate the interest on the next payment of an investment.
 * input:       the user provides: balance, annual interest rate, & # of years
 * process:     calculate future value = investment amount * (1 + monthly rate) to the power of (years * 12)
 * output:      future investment value in $
 * author:      Dana Marsh & A05
 * mod date:    Sep 22, 2023
 */

namespace Sep22InvestmentExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // strings!
            string treasure = "We the people of these United States...";
            Console.WriteLine(treasure);
            Console.WriteLine(treasure.ToLower());
            Console.WriteLine(treasure.ToUpper());
            Console.WriteLine("\n\n\n\n\n");

            /******* tackle q5 from "sequence structure programming exercises" ******/

            // welcome user
            Console.WriteLine("Welcome to our finance calculator.");

            // define variables
            double investmentAmount, 
                annualInterestRate,      // entered as a number
                baseNumber,
                futureValue;    
            int numYears,
                numMonths;
            string input;

            // prompt the user for investment amount
            Console.Write("Please enter current balance: ");
            input = Console.ReadLine();
            investmentAmount = double.Parse(input);

            // prompt the user for interest rate
            Console.Write("Please enter interest rate (as a number): ");
            input = Console.ReadLine();
            annualInterestRate = Convert.ToDouble(input);

            // prompt the user for # of years
            Console.Write("Enter the # of years: ");
            input = Console.ReadLine();
            numYears = Convert.ToInt32(input);

            // calculate
            numMonths = numYears * 12;
            baseNumber = 1 + annualInterestRate / 12 / 100;
            futureValue = investmentAmount * Math.Pow(baseNumber, numMonths);

            // display results
            Console.WriteLine($"The future value is {futureValue:c}.");

        }
    }
}