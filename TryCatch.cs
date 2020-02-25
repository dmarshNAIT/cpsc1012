using System;

namespace A04_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool validInput = false;

            do
            {
                try
                {
                    Console.Write("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                    validInput = true;
                    Console.WriteLine($"Your age is {age}.");
                } // end try
                catch
                {
                    Console.WriteLine("Sorry, invalid.");
                } // end catch

            } while (!validInput);

            Console.WriteLine("We got to the end!");

        } // end method
    } // end class
} // end namespace
