/* purpose: To demonstrate input validation, looping, and decision structures.
 * input:   The letter of the service package, and # of hours
 * process: prompt the user for input, calculate the total bill, and display. 
 *          ask the user if they'd like to repeat.
 * output:  The total amount billed.
 * 
 * author: Dana Marsh with help from A05
 * modified date: Oct 13, 2023
 */

namespace Oct13MoreValidationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userContinue;

            do
            {
                // declare variables:
                char userPackage = '\0'; // initialize it to an arbitrary value; will be overwritten later
                bool isValidInput = false;
                int actualHours = 0; // initialize to zero; will be overwritten later

                do
                {
                    // prompt the user for letter of their service package
                    Console.Write("Welcome to the turtleISP bill provider.\n" +
                        "Please enter your service package (A, B, or C): ");
                    try // input validation
                    {
                        userPackage = Char.ToUpper(char.Parse(Console.ReadLine()));
                        if (userPackage != 'A' && userPackage != 'B' && userPackage != 'C')
                        {
                            Console.WriteLine("Sorry, that's not a valid letter. Please try again.\n");
                        }
                        else
                        {
                            isValidInput = true;
                        }
                    } // end of try-block
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry, that's not a valid entry. Please enter a single letter.\n");
                    }
                } while (!isValidInput);
                Console.WriteLine("You have chosen package " + userPackage);

                isValidInput = false;
                do
                {
                    // prompt the user for the # of hours
                    Console.Write("How many hours did you have this month? ");
                    try // input validation
                    {
                        actualHours = int.Parse(Console.ReadLine());
                        if (actualHours < 0)
                        {
                            Console.WriteLine("Sorry, that's not a valid #. Please try again.\n");
                        }
                        else
                        {
                            isValidInput = true;
                        }
                    } // end of try-block
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry, that's not a valid entry. Please enter a number without decimals.\n");
                    }
                } while (!isValidInput);

                Console.WriteLine($"You have entered {actualHours} hours.");

                // calculate:
                // package A: $9.95 per month for 10 hours, additional hours are $2/hr
                // package B: $13.95 per month for 20 hours, additional hours are $1/hr
                // package C: $19.95 per month for unlimited hours

                // print out a bill showing total amount billed.
                // output formatting including columns

                // if they are paying more than $19.95, let them know about the unlimited plan

                // ask if they'd like to process another bill.
                Console.Write("Do you have another bill to generate?\n" +
                    "Enter Y to continue and any other key to exit.: ");
                userContinue = Console.ReadLine().ToUpper();
            } while ( userContinue.Equals("Y") );

            Console.WriteLine("Thanks, good night.");
        }
    }
}