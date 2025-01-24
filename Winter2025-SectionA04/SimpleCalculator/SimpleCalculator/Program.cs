/// <summary>
/// This program accepts two numbers from the user, performs 4 arithmetic calculations, then displays the results.
/// Author: Dana Marsh
/// Last Modified Date: January 24, 2025
/// </summary

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create variables
            int number1,
                number2,
                sum,            // result of addition
                difference,     // result of subtraction
                product,        // result of multiplication
                divisionResult, // result of integer division
                remainder;
            double quotient; // decimal result of division
            string input;

            //Get first number
            // ask the question:
            Console.Write("Enter first number: ");
            // get the answer:
            input = Console.ReadLine();
            // do something with the answer:
            number1 = int.Parse(input);

            //Get second number
            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            number2 = int.Parse(input);

            //Perform addition
            sum = number1 + number2;
            //Output result
            Console.WriteLine("The sum is " + sum);

            // CHALLENGE: try to code the rest on your own
            //Perform subtraction
            difference = number1 - number2;
            //Output result
            Console.WriteLine("The difference is " + difference);

            //Perform multiplication
            product = number1 * number2;
            //Output result
            Console.WriteLine("The product is " + product);

            //Perform division & output result
            // version 1: decimal results
            quotient = (double) number1 / number2;
            Console.WriteLine("The quotient is " + quotient);

            // version 2: integer division
            divisionResult = number1 / number2;
            remainder = number1 % number2;
            Console.WriteLine("The result of division is " + divisionResult + 
                " with a remainder of " + remainder);
        }
    }
}
