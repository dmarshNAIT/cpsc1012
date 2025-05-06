/*
 * Purpose:     To see if a user is qualified for a loan.
 * Authors:     Dana Marsh (with assistance from OE01)
 * 
 * Input:       the user's salary, & the user's work experience
 * Output:      whether or not they qualify for a loan
 * 
 * Modified:    Feb 6, 2025
 */
namespace LoanQualifierElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double salary;
            int yearsOfExperience;

            // prompt user for salary
            Console.Write("Welcome!\n\nPlease enter your salary in CAD: $");
            salary = double.Parse(Console.ReadLine());

            // prompt user for yearsOfExperience
            Console.Write("Please enter the years you've been at your current job: ");
            yearsOfExperience = int.Parse(Console.ReadLine());

            if (yearsOfExperience < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you need more work experience.");
                Console.ResetColor();
            }
            else if (salary < 30000)
            {
                // they have enough experience but NOT enough salary
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you must make $30k/year.");
                Console.ResetColor();
            }
            else
            {
                // they have enough experience AND enough salary!
                Console.ForegroundColor = ConsoleColor.Blue; // BONUS CONTENT!
                Console.WriteLine("Congrats! You qualify for a loan!");
                Console.ResetColor();
            }

            // version 2:
            if (salary >= 30000 && yearsOfExperience >= 2)
            {
                Console.WriteLine("Congrats! You qualify for a loan!");
            }
            else if (salary < 30000)
            {
                Console.WriteLine("Sorry, you must make $30k/year.");
            }
            else
            {
                Console.WriteLine("Sorry, you need more work experience.");
            }
        }
    }
}
