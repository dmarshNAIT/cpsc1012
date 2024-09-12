/* PROGRAM NAME:    Simple Calculator application
 * AUTHOR:          Dana Marsh & section A04
 * LAST MODIFIED:   Sep 12, 2024
 * 
 * INPUT:           2 user-inputted values
 * OUTPUT:          the results of addition, subtraction, multiplication, & division
 * 
 * PURPOSE:         This application will ask the user for two numbers, 
 *                  perform 4 mathematical operations, and display the results.
 */ 

namespace Topic2SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int firstNumber, secondNumber;
            double sum, difference, product, quotient;
            string userInput;

            // get 2 values from the user
            // ask the question:
            Console.Write("Please enter first number: ");
            // get their answer:
            userInput = Console.ReadLine();
            // save their answer:
            firstNumber = int.Parse(userInput);

            // BONUS CONTENT: add a half-second pause
            Thread.Sleep(500);

            // ask the question:
            Console.Write("Please enter second number: ");
            // get their answer:
            userInput = Console.ReadLine();
            // save their answer:
            secondNumber = int.Parse(userInput);

            // calculate sum, difference, product, & quotient
            sum = firstNumber + secondNumber;
            difference = firstNumber - secondNumber;
            product = firstNumber * secondNumber;
            quotient = (double) firstNumber / secondNumber;

            // display results
            Console.WriteLine("The sum is " + sum +
                "\nThe difference is " + difference +
                "\nThe product is " + product +
                "\nThe quotient is " + quotient
                );

            // an alternate way to display our results:
            Console.WriteLine($"The sum is ${sum}\n" +
                $"The difference is {difference}\n" +
                $"The product is {product}\n" +
                $"The quotient is {quotient}");

            /* CHALLENGE: 
             * Instead of "the sum is 7"
             * I want to see:
             *              2 + 5 = 7
             *              2 - 5 = -3
             *              2 * 5 = 10
             *              2 / 5 = 0.4
             */

        }
    }
}
