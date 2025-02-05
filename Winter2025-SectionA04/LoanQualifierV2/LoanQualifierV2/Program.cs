/*
 * Purpose: Determine if a user is qualified for a loan based on their income & work experience.
 * Author: Dana Marsh & A04
 * Date: Feb 5, 2025
 */
namespace LoanQualifierV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;
            int tenure;

            // get input
            Console.Write("Welcome!\n\nPlease enter your salary in $: ");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Please enter the # of years you've been employed: ");
            tenure = int.Parse(Console.ReadLine());

            if (salary < 30000)
            {
                Console.WriteLine("Sorry, you must make at least $30k/year.");
            }
            else if (tenure < 2)
            {
                Console.WriteLine("Sorry, you must have worked at least 2 years.");
            }
            else
            {
                Console.WriteLine("Congratulations! You qualify.");
            }

            // OR we can use a COMPOUND expression
            if (salary >= 30000 && tenure >= 2)
                Console.WriteLine("Congrats! You qualify.");
            else if (salary < 30000)
                Console.WriteLine("Sorry, you must make at least $30k/year.");
            else if (tenure < 2)
                Console.WriteLine("Sorry, you must have worked at least 2 years.");

            // if there is only ONE statement in an if/else block, 
            // technically we don't require the {} around it.
            // ⚠️ DO SO WITH CAUTION PLEASE. ⚠
        }
    }
}
