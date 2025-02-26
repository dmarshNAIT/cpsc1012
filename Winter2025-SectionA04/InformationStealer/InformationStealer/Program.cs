/*
 * Purpose:  Prompt the user for personal details & 
 *           output the results in a formatted way.
 * Author:   Dana & A04
 * Modified: Feb 25, 2025
 */
namespace InformationStealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables:
            int age;
            double salary;
            bool restartLoop,
                badInput = true;

            // ask the user for their age & salary
            do
            {
                Console.Write("Please enter your age: ");
                try
                {
                    age = int.Parse(Console.ReadLine());
                    badInput = true;
                }
                catch
                {
                    Console.WriteLine("Incorrect, please enter a digit.");
                }
            } while (badInput == true);


            // if their salary is below 5000
            // donate $200
            // if their salary is above 7000
            // take $1000

            // output those values, nicely aligned
            // then ask if they want to go again

            // debug
            // add second question
            Console.WriteLine("Thanks, bye!");
        }
    }
}
