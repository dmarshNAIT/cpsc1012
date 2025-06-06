/*
 * Write a program using a nested if statement that checks if a user is 
 * qualified for a loan.
 * To qualify, the user must make at least $30,000/year and 
 * have been at their current job for at least 2 years.
 * Let the user know whether they are qualified, and if not, why. 
 */
namespace LoanQualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inputs: double yearlyWage, int yearsAtJob
            // outputs: a string representing whether or not they were approved

            // declare variables
            double yearlyWage;
            string outputMessage;

            // ask the user for yearly wage 
            Console.Write("Please enter your annual wage in $: ");
            yearlyWage = double.Parse(Console.ReadLine());

            // if the user's wage is 30,000 or more: they might be qualified
            if (yearlyWage >= 30000) // or 30000 <= yearlyWage
            {
                int yearsAtJob;

                // ask them for their years of work
                Console.Write("Enter the # of years at your current job: ");
                yearsAtJob = int.Parse(Console.ReadLine());

                // if they've worked long enough, yay loan
                if (yearsAtJob >= 2)
                {
                    outputMessage = "You qualify for a loan!";
                }
                else
                {
                    // otherwise, boo no loan
                    outputMessage = "Sorry, you must have 2 years of experience.";
                }
            }
            else
            {
                // otherwise, they are not
                outputMessage = "Sorry, you must have an annual wage of $30,000 to qualify.";
            }

            Console.WriteLine(outputMessage);

        }
    }
}

/*
 * TEST:
 * good salary: 50000
 * 
 * good salary, 2 years: should say "qualified"             PASS
 * 
 * good salary, 1 year: should say "not enough years"       PASS
 * 
 * low salary, 5 years: should say "not enough salary"      PASS
 * 
 * low salary, 1 year: should say "not enough salary"       PASS
 */