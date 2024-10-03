/* Name:        Cheap Deals ISP (Internet Service Provider)
 * Author:      Dana & section A04
 * Modified:    October 3, 2024
 * 
 * Inputs:      Choice from a menu, # of hours
 * Outputs:     Cost per month
 * 
 * Purpose:     To get even more awesome at decision structures.
 * 
 */
namespace Topic3PracticePeriod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char menuChoice;
            int numberOfHours;
            double expectedCost;

            // ask them for their expected number of hours
            Console.Write("Welcome to the Cheap Deals ISP!\n" +
                "How many hours of internet do you expect to use? ");
            numberOfHours = int.Parse(Console.ReadLine());

            // show the user a menu of options
            Console.Write("Would you like to see pricing for:\n" +
                "Package A, B, or C? ");
            menuChoice = char.Parse(Console.ReadLine());
            // force their choice to be uppercase:
            menuChoice = char.ToUpper(menuChoice);
            // char.ToUpper() will give us the upper-case version of whatever the user entered. e.g. 'a' will be turned into 'A'

            // option A: $9.95 per month for 10 hours, + $2/extra hour
            // option B: $13.95 per month for 20 hours, + $1/extra hour
            // option C: $19.95 per month for unlimited
            //switch (menuChoice)
            //{
            //    case 'A':
            //        expectedCost = 9.95;

            //        // if they have more than 10 hours, add $2/extra hour
            //        if (numberOfHours > 10)
            //        {
            //            expectedCost += 2 * (numberOfHours - 10);
            //        }
            //        break;

            //    case 'B':
            //        expectedCost = 13.95;

            //        // if they have more than 20 hours, add $1/extra hour
            //        if (numberOfHours > 20)
            //        {
            //            expectedCost = expectedCost + (numberOfHours - 20);
            //        }
            //        break;

            //    case 'C':
            //        expectedCost = 19.95;
            //        break;
            //    default:
            //        expectedCost = 1000;
            //        Console.WriteLine("You didn't follow instructions and now must pay way more.");
            //        break;
            //}

            if (menuChoice == 'A' && numberOfHours <= 10)
            {
                expectedCost = 9.95;
            }
            else if (menuChoice == 'A' && numberOfHours > 10)
            {
                expectedCost = 9.95 + 2 * (numberOfHours - 10);
            } else if (menuChoice == 'B' && numberOfHours <= 20)
            {
                expectedCost = 13.95;
            }
            else if (menuChoice == 'B' && numberOfHours > 20)
            {
                expectedCost = 13.95 + (numberOfHours - 20);
            } else if (menuChoice == 'C')
            {
                expectedCost = 19.95;
            }
            else
            {
                expectedCost = 1000;
            }

            Console.WriteLine($"Your expected costs are {expectedCost:c}");

            // suggest a better-value deal

        }
    }
}
