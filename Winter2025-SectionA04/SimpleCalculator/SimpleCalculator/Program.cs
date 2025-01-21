using System.Collections.Generic;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 2 variables
            int number1,
                number2,
                sum;
            string input1;

            //Get first number
            // ask the question:
            Console.Write("Enter first number: ");
            // get the answer:
            input1 = Console.ReadLine();
            // do something with the answer:
            number1 = int.Parse(input1);

            //Get second number
            Console.Write("Enter second number: ");
            input1 = Console.ReadLine();
            number2 = int.Parse(input1);

            //Perform addition
            sum = number1 + number2;
            //Output result
            Console.WriteLine("The sum is " + sum);

            // CHALLENGE: try to code the rest on your own
            //Perform subtraction
            //Output result
            //Perform multiplication
            //Output result
            //Perform division
            //Output result
        }
    }
}
