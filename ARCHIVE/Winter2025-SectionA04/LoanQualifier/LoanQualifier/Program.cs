/*
 * Purpose: To check if a user is qualified for a loan based on their salary & work experience.
 * Author: Dana Marsh with assistance from section A04
 * 
 * Last modified: Feb 5, 2025
 */
namespace LoanQualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double salary;
            int tenure;

            // get input
            Console.Write("Welcome!\n\nPlease enter your salary in $: ");
            salary = double.Parse(Console.ReadLine());

            // check if the user's salary is high enough
            if (salary >= 30000)
            {
                // their salary is high enough, now we need to check their tenure
                Console.Write("Please enter the # of years you've been employed: ");
                tenure = int.Parse(Console.ReadLine());

                if (tenure >= 2)
                {
                    Console.WriteLine("Congratulations! You qualify!");
                }
                else
                {
                    Console.WriteLine("Sorry, you haven't been working long enough.");
                }
            }
            else // this only executes if salary is NOT >= 30,000
            {
                Console.WriteLine("Sorry, your salary isn't high enough to qualify.");
            }
        }
    }
}
