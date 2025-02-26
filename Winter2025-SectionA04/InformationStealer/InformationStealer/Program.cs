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
                    if (age > 0)
                    {
                        badInput = false; // because we now have GOOD input
                    }
                    else // # is negative
                    {
                        Console.WriteLine("Invalid input: please enter a positive number.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input: please enter a numeric value.");
                }
            } while (badInput == true); // keep looping as long as we have bad input

            // reset our control variable:
            badInput = true;

            do
            {
                Console.Write("Please enter your salary: $");
                try
                {
                    salary = double.Parse(Console.ReadLine());
                    if (salary > 0)
                    {
                        badInput = false; // because we now have GOOD input
                    }
                    else // # is negative
                    {
                        Console.WriteLine("Invalid input: please enter a positive number.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input: please enter a numeric value.");
                }
            } while (badInput == true); // keep looping as long as we have bad input

            // if their salary is below 5000
            // give $200
            // if their salary is above 7000
            // take $1000

            // output those values, nicely aligned
            // then ask if they want to go again

            Console.WriteLine("Thanks, bye!");

            // debug
            // add second question
            // TODO scope: where should each variable be created?
        }
    }
}
