using System.Threading.Tasks;

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

            // Get input numbers
            //TODO: make this better
            firstNumber = 2;
            secondNumber = 9;

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
