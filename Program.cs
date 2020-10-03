/* Author:          Dana Marsh with input from you
 * Last mod date:   
 * Input:           
 * Output:          
 * Process:         
 * This is my sandbox and I haven't filled out my opening doc... oops.
 */

using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // introduce the program
            Console.WriteLine("Welcome to the Digital Ice Cream Truck.");

            // declare variables
            int numScoops = 0;
            //bool isFull = false;
            bool isHungry = true;

            // repeat until they are full
            while (isHungry)  // or (isFull == false) or !isFull
            {
                // here's some ice cream
                ++numScoops;
                Console.WriteLine("Here is some ice cream. Do you want more (yes/no)?");
                // ask the user if they are full   
                string userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "no")
                {
                    isHungry = false;
                } // ends my if
                else if (userResponse.ToLower() != "yes")
                {
                    Console.WriteLine("I'm sorry, Dave. I can't do that.");
                } else
                {
                    Console.WriteLine("You must really love ice cream.");
                }

            } // ends my while

            Console.WriteLine("You had {0} scoops.", numScoops);

        } // end of method
    } // end of class
} // end of namespace
