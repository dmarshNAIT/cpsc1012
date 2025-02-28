/*
 * Purpose:  Provided a month number, the program will display the month name.
 * Author:   Dana & OE01
 * Modified: Feb 27, 2025
 */
namespace MonthLookUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HIGH LEVEL PLAN:
            // create an array containing the names of the months
            // we will ask the user to input a number
            // in response we will show them the month name
            // ask if they want to go again

            bool userWantsToContinue = true;

            while (userWantsToContinue)
            {
                int monthNumber;
                string monthName,
                    userAnswer;

                // create the array
                string[] monthNames = { null, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                // ask the user to input a number
                Console.Write("Please enter a number: ");

                while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber < 1 || monthNumber > 12) // we cannot parse the int OR the number is 0 or less OR the number is >12
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                // show the month name
                monthName = monthNames[monthNumber]; // monthNumber is the index of the array
                Console.WriteLine($"The name of month #{monthNumber} is {monthName}.");

                // ask if they want to go again
                // if they say no, change userWantsToContinue to be FALSE
                Console.Write("Press Q to Quit or any other key to continue: ");
                userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == "Q")
                {
                    userWantsToContinue = false;
                }
            }

            Console.WriteLine("Thanks, goodbye!");

            // TODO: YOUR CHALLENGE: we will also tell them the # of days in that month
        }
    }
}
