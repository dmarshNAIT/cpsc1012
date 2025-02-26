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
            int age = 0;// starting value that will be replaced with user input
            double salary = 0, // starting value that will be replaced with user input
                gift; // this represents the NEW balance after we add/remove funds
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
            // if we adjusted our logic a bit, we could also use other conditions like:
            // while (salary <= 0)
            // while (goodInput == false)
            // while (!goodInput)
            // while (badInput)...

            // if their salary is below 5000
            // give $200
            if (salary < 5000)
            {
                gift = salary + 200;
            }
            // if their salary is above 7000
            // take $1000
            else if (salary > 7000)
            {
                gift = salary - 1000;
            }
            else
            {
                gift = salary;
            }

            // output those values, nicely aligned
            Console.WriteLine($"Age: {age}" +
                $"\nSalary: {salary}" +
                $"\nAdjusted Salary: {gift}");
            // then ask if they want to go again

            Console.WriteLine("Thanks, bye!");

            // debug
            // add second question
            // TODO scope: where should each variable be created?
        }
    }
}
