﻿using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to hold the input numbers
            double firstNumber,
                secondNumber,
                sum,                // additionResult
                difference,         // subtractionResult
                product,            // multiplicationResult
                quotient;           // divisionResult
            string userInput;

            // Get input numbers
            // first: ask the question
            Console.Write("Enter a number:");
            // second: get the answer
            userInput = Console.ReadLine();
            // third: do something with the answer
            firstNumber = double.Parse(userInput);

            // ask the user for the 2nd number
            Console.Write("Enter another number:");
            // save it into userInput
            userInput = Console.ReadLine();
            // then turn it into a # and save it into secondNumber
            secondNumber = double.Parse(userInput);

            // Calculate the results
            sum = firstNumber + secondNumber;
            difference = firstNumber - secondNumber;
            product = firstNumber * secondNumber;
            quotient = firstNumber / secondNumber;

            // Display the results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

        }

    }
}
