using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int userResponse = 0; // initial value to be overwritten later

            do
            {
                bool validInput = false;
                do
                {
                    // ask the user what is the meaning of life?
                    Console.WriteLine("What is the meaning of life?");

                    // get their response & try to parse
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        userResponse = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        validInput = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, invalid input.");
                        Console.ResetColor();
                    }

                } while (!validInput);

            } while (userResponse != 42);

            Console.WriteLine("We escaped the loop!");

        } // end of method
    } // end of class
} // end of namespace
