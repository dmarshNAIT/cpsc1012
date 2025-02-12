/*
 * Purpose:     Calculate the cost of a ticket based on the user's age.
 * Author:      Dana Marsh
 * 
 * Modified:    Feb 11, 2025
 */

namespace TicketingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int age;
            double ticketPrice;

            const double CHILD_PRICE = 0;
            const double YOUTH_PRICE = 9.8;
            const double ADULT_PRICE = 11.35;
            const double SENIOR_PRICE = 10;

            // prompt the user for their age
            Console.Write("Welcome to the ticketing counter!\nWhat is your age in years? ");
            age = int.Parse(Console.ReadLine());

            // use the age to determine the ticket price
            // 6 & under: $0 (FREE!)
            // 7-17: $9.80
            // 18-54: $11.35
            // 55+ $10
            if (age < 0)
            {
                Console.WriteLine("You cannot be negative years old!");
                ticketPrice = 1000000;
            }
            else if (age <= 6)
            {
                ticketPrice = CHILD_PRICE;
            }
            else if (age <= 17)
            {
                ticketPrice = YOUTH_PRICE;
            }
            else if (age <= 54)
            {
                ticketPrice = ADULT_PRICE;
            }
            else //if (age >= 55)
            {
                ticketPrice = SENIOR_PRICE;
            }

            // display the ticket price formatted as currency
            Console.WriteLine($"Your ticket will cost {ticketPrice:c}");

        }
    }
}
