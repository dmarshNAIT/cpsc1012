/*
 * Purpose:         To calculate the cost of a ticket after getting the user's age group, 
                    student status, and delivery preferences.
 * Author:          D. Marsh & section A04
 * 
 * Last Modified:   Feb 7, 2025
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


            // PROBLEM SOLVING PROCESS:

            // INPUTs:
                // int age
                // bool isStudent
                // char deliveryMethod : 'P' and 'M'
            // OUTPUT:
                // cost of the ticket

            // SEQUENCE:
                // declare variables
                // welcome
                // get user's age
                // get user's student status
                // get user's delivery preferences (print for free, mailed for a fee)
                // if their age is 12 or less, price = 0
                    // otherwise if they are 25 or less, price = 14
                    // otherwise if they are 64 or less, price = 18
                    // otherwise if they are 65+, price is 12
                // if they are a student, subtract 10% from price
                // if they requested mailed ticket, add $2, otherwise add $0
                // display results



            // TODO NEXT WEEK: we will add the ability to get MULTIPLE tickets 
            // TODO NEXT WEEK: add input validation
        }
    }
}
