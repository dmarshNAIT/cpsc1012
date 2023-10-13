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
                char userPackage = '\0';    // initialize it to an arbitrary value; will be overwritten later
                bool isValidInput = false;
                int actualHours = 0;        // initialize to zero; will be overwritten later
                double monthlyCost;         // the monthly cost in $
                const int PACKAGE_A_HOURS = 10,
                    PACKAGE_B_HOURS = 20;
                const double PACKAGE_A_COST = 9.95,
                    PACKAGE_B_COST = 13.95,
                    PACKAGE_C_COST = 19.95,
                    PACKAGE_A_HOURLY_RATE = 2,
                    PACKAGE_B_HOURLY_RATE = 1;
                string bill = "\nHere is your monthly bill:\n";

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
                            Console.WriteLine("Sorry, that's not a valid option. Please try again.\n");

                            // TO DO as bonus challenge:
                            // use Char.IsLetter() to determine whether it's a char that's a letter, or not,
                            // then we can further customize our error messages.
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
                bill += $"Package:      {userPackage,8}\n";

                isValidInput = false; // re-set
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
                bill += $"Hours:        {actualHours,8}";

                // calculate:
                // package A: $9.95 per month for 10 hours, additional hours are $2/hr
                // package B: $13.95 per month for 20 hours, additional hours are $1/hr
                // package C: $19.95 per month for unlimited hours

                // check the package to get the monthly cost
                double hourlyRate = 0,
                    hoursPerPlan = 0;
                if (userPackage == 'A')
                {
                    monthlyCost = PACKAGE_A_COST;
                    hourlyRate = PACKAGE_A_HOURLY_RATE;
                    hoursPerPlan = PACKAGE_A_HOURS;
                }
                else if (userPackage == 'B')
                {
                    monthlyCost = PACKAGE_B_COST;
                    hourlyRate = PACKAGE_B_HOURLY_RATE;
                    hoursPerPlan = PACKAGE_B_HOURS;
                }
                else // we know the package must be C because those are the only 3 valid values
                {
                    monthlyCost = PACKAGE_C_COST;
                }

                // if they are package A or B, add on the extra hours
                if ((userPackage == 'A' || userPackage == 'B') && (actualHours > hoursPerPlan))
                {
                    double extraHours = actualHours - hoursPerPlan;
                    monthlyCost += extraHours * hourlyRate;
                }

                // if they are paying more than $19.95, let them know about the unlimited plan
                if (monthlyCost > PACKAGE_C_COST)
                {
                    bill += $"\tSave {monthlyCost - PACKAGE_C_COST:c} by switching to Unlimited";
                }

                bill += $"\nMonthly cost: {monthlyCost,8:c}\n";

                // print out a bill showing total amount billed.
                // output formatting including columns
                Console.WriteLine(bill);

                // ask if they'd like to process another bill.
                Console.Write("\nDo you have another bill to generate?\n" +
                    "Enter Y to continue and any other key to exit.: ");
                userContinue = Console.ReadLine().ToUpper();
            } while (userContinue.Equals("Y"));

            Console.WriteLine("Thanks, good day or good night.");
        }
    }
}