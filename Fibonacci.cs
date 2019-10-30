using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare variables
            int n, count, current, previous, previousPrevious;
            char response;

            // do loop
            do
            {
                Console.WriteLine("\nPlease enter a positive value for N.");
                n = int.Parse(Console.ReadLine());

                if (n > 0) { // loop to calculate sequence
                    count = 0;
                    current = 0;
                    previous = 1;
                    previousPrevious = 0;

                    Console.Write($"The Fibonacci sequence of {n} numbers is: ");

                    while (count < n)
                    {
                        Console.Write(current + " ");
                        previousPrevious = previous;
                        previous = current;
                        current = previous + previousPrevious;
                        count++;

                    } // end while

                } // end if
                else {
                    Console.WriteLine("ERROR: N must be positive.");
                } // end else

                Console.WriteLine("\n\nWould you like to enter another? (y/n)");
                response = char.Parse(Console.ReadLine());

            } while (response == 'Y' || response == 'y');

            Console.WriteLine("\nThanks for playing!\nPress any key to exit.");
            Console.ReadLine();

        } // eom
    } // eoc
} // eon
