/*  NAME:           Simple Calculator application
 *  AUTHOR:         Dana Marsh & section A05
 *  LAST MODIFIED:  Sep 16, 2024
 * 
 *  INPUT:          2 numeric inputs
 *  OUTPUT:         the result of adding, subtracting, multiplying, 
 *                  and dividing those numbers
 *  
 *  PURPOSE:        Prompt user for 2 numbers, perform calculations,
 *                  then display results.
 */

namespace Topic2SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int firstInput, secondInput;
            double sum, difference, product, quotient;
            string inputValue;

            // get input from the user
            // ask a Q:
            Console.Write("Please enter your first number: ");
            // get their answer:
            inputValue = Console.ReadLine();
            // do something with their answer:
            firstInput = int.Parse(inputValue);

            // ask a Q:
            Console.Write("Please enter your second number: ");
            // get their answer & save it:
            secondInput = int.Parse(Console.ReadLine());

            // perform calculations
            sum = firstInput + secondInput;
            difference = firstInput - secondInput;
            product = firstInput * secondInput;
            quotient = (double) firstInput / secondInput;

            // display results
            Console.WriteLine("The sum is " + sum
                + "\nThe difference is " + difference
                + "\nThe product is " + product 
                + "\nThe quotient is " + Math.Round(quotient, 3));

            // v2:
            Console.WriteLine(firstInput + " + " + secondInput + " = " + sum);

            // v3: (string interpolation)
            Console.WriteLine($"{firstInput} + {secondInput} = {sum}");

            // v4: (substitution parameters)
            Console.WriteLine("{0} + {1} = {2}", firstInput, secondInput, sum);

            // v5: (string interpolation without extra variables)
            Console.WriteLine($"{firstInput} + {secondInput} = {firstInput + secondInput}");

            // CHALLENGE:
            // complete the CW to show all 4 equations, in any style
            // e.g. using +
            // or using {0} substitution params
            // or using {firstInput} string interpolation

            // FUTURE IMPROVEMENT:
            // ROUND quotient to a reasonable # of digits
        }
    }
}
