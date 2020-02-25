using System;

namespace A04_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare
            int numberOfValues;

            // prompt
            Console.WriteLine("How many numbers would you like to see?");
            numberOfValues = int.Parse(Console.ReadLine());

            Console.Write($"\nThe first {numberOfValues} values of the sequence are: ");

            // calculate & display
            for (int counter = 0, current = 0, prev = 1, prevPrev = 0; counter < numberOfValues; counter++)
            {
                Console.Write(current);
                if (counter < numberOfValues - 1)
                {
                    Console.Write(", ");
                } // end if
                else
                {
                    Console.WriteLine("...");
                } // end else
                prevPrev = prev;
                prev = current;
                current = prev + prevPrev;
            } // end for

            Console.WriteLine("\nThanks, bye.");
        } // end of method
    } // end of program
} // end of class
