/*
 * Purpose:     To see if a user is qualified for a loan.
 * Authors:     Dana Marsh (with assistance from OE01)
 * 
 * Input:       the user's salary, & the user's work experience
 * Output:      whether or not they qualify for a loan
 * 
 * Modified:    Feb 6, 2025
 */
namespace LoanQualifierNested
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

            // first, check if their salary is high enough.
            // if so, we then check if their experience is long enough.
            // if their experience is long enough, congrats!
            // otherwise, sorry you do not qualify
            // otherwise if they don't have experience, sorry you do not quality

            if (salary >= 30000)
            {
                // prompt user for yearsOfExperience
                Console.Write("Please enter the years you've been at your current job: ");
                yearsOfExperience = int.Parse(Console.ReadLine());

                // salary is high enough
                if (yearsOfExperience >= 2)
                {
                    Console.WriteLine("Congrats! You qualify for a loan!");
                }
                else
                {
                    Console.WriteLine("Sorry, you need more work experience.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you must make $30k/year.");
            }
        }
    }
}
