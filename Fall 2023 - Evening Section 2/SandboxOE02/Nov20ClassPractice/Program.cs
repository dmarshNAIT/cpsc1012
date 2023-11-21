﻿namespace Nov20ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's create a default superhero:
            SuperHero cpsc1012 = new SuperHero(); // create a superhero using the no-arg constructor
            SuperHero dutchie = new SuperHero("The Iron Dutchie", "wealth", "was catnapped", 2, 15, false, false, true, false);

            // call the 4 new methods we just created to access & mutate one of our objects

            Console.WriteLine("goodbye!");
        }

        static void DisplayGrid(int numColumns, int numRows)
        {

            for (int row = 0; row < numRows; row++)
            {
                // print a line of asterisks
                for (int col = 0; col < numColumns * 2 + 1; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                // print alternating asterisks & stars
                for (int col = 0; col < numColumns * 2 + 1; col++)
                {
                    // if i is an even number
                    if (col % 2 == 0)
                    {
                        // print asterisk
                        Console.Write("*");
                    }
                    else // otherwise
                    {  // print a space
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // print a line of asterisks
            for (int col = 0; col < numColumns * 2 + 1; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // TO DO: remove my repeated WriteLine calls

        }
    }
}