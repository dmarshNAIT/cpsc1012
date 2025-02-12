/*
 * Purpose:         To calculate the cost of a ticket after getting the user's age group, 
                    student status, and delivery preferences.
 * Author:          D. Marsh & section A04
 * 
 * Last Modified:   Feb 12, 2025
 */
using System.ComponentModel;

namespace TicketingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to calculate the cost of a ticket.
            // Students get a 10% discount.

            // Children(12 and under): free
            // Youth(13 - 25): $14
            // Adults(26 - 64): $18
            // Senior(65 +): $12

            // User can print their ticket for free, or have it mailed for a fee of $2.

            // NOTE:
            // We are writing this code before we've learned how to deal with bad input, so for simplicity let's assume good input.


            // PROBLEM SOLVING PROCESS:

            // INPUTs:
            // int age
            // bool isStudent
            // char deliveryMethod : 'P' and 'M'
            // OUTPUT:
            // cost of the ticket

            // SEQUENCE:
            // declare variables
            int age;
            bool isStudent = false; //initialize
            char deliveryMethod; // allowable values are 'P' and 'M'
            double ticketPrice;
            string userAnswer;

            const double CHILD_PRICE = 0,
                YOUTH_PRICE = 14,
                ADULT_PRICE = 18,
                SENIOR_PRICE = 12;
            // all 4 constants are "sharing" the words const & double
            // we separate each constant with a comma
            // but keep each constant on its own line

            // welcome
            Console.WriteLine("Welcome to our Ticketing System!\n");

            // get user's age
            Console.Write("Please enter your age in years: ");
            age = int.Parse(Console.ReadLine());

            // get user's student status
            Console.Write("Are you a student? Yes/No: ");
            userAnswer = Console.ReadLine().ToUpper();
            // the user's answer will be saved as ALL CAPITALS
            // this makes our logic a little easier when we're checking what they entered
            if (userAnswer == "Y" || userAnswer == "YES")
            {
                isStudent = true;
            }

            // get user's delivery preferences (print for free, mailed for a fee)
            Console.Write("Would you like to [P]rint your ticket for free, or have it [M]ailed for $2? P/M: ");
            userAnswer = Console.ReadLine().ToUpper();
            deliveryMethod = char.Parse(userAnswer);

            // if their age is 12 or less, price = 0
            // otherwise if they are 25 or less, price = 14
            // otherwise if they are 64 or less, price = 18
            // otherwise if they are 65+, price is 12
            if (age <= 12)
            {
                ticketPrice = CHILD_PRICE;
            }
            else if (age <= 25)
            {
                ticketPrice = YOUTH_PRICE;
            }
            else if (age <= 64)
            {
                ticketPrice = ADULT_PRICE;
            }
            else
            {
                ticketPrice = SENIOR_PRICE;
            }
            // this could have been done as a switch using the new syntax, or as a series of nested conditional operators

            // if they are a student, subtract 10% from price
            //if (isStudent)
            //    ticketPrice = ticketPrice * .90;
            // using conditional operator:
            ticketPrice = isStudent ? ticketPrice * .90 : ticketPrice;

            // if they requested mailed ticket, add $2, otherwise add $0
            switch (deliveryMethod)
            {
                case 'P':
                    Console.WriteLine("You have chosen to print your ticket.");
                    break;
                case 'M':
                    ticketPrice += 2;
                    Console.WriteLine("You have chosen to have your ticket mailed.");
                    break;
                default:
                    Console.WriteLine("That wasn't a valid choice.");
                    break;
            }

            // display results
            // Your ticket will cost $14.00
            // Your ticket will cost $12.60 (student discount)
            Console.Write($"Your ticket will cost {ticketPrice:c}");

            if (isStudent)
                Console.Write(" (student discount)");

            Console.WriteLine("\n\nThanks! Have a nice day!");

            // TODO NEXT WEEK: we will add the ability to get MULTIPLE tickets 
            // TODO NEXT WEEK: add input validation
        }
    }
}
