/* This program is a Simple Calculator.
 * Author: Dana Marsh & Section A05
 * Last modified: Jan 10, 2020
 */


using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for first number
            //ask user for 2nd number
            int firstNumber = 8;
            int secondNumber = 3;

            //do calculations 
            int sum = firstNumber + secondNumber;
            int diff = firstNumber - secondNumber;
            int product = firstNumber * secondNumber;
            double quotient = firstNumber * 1.0 / secondNumber; // forcing our number to be a double

            //display results
            Console.WriteLine("The sum is " + sum + ".");
            Console.WriteLine("The difference is " + diff + ".");
            Console.WriteLine("The product is " + product + ".");
            Console.WriteLine("The quotient is " + Math.Round(quotient,3) + "."); // rounding to 3 decimal places


            /*
             * Bonus!
             * The following lines are alternate ways to display the results.
             */
            Console.WriteLine(); // just to make an empty line between our actual code and the bonus content.

            // the original way:
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum);
            // substitution parameters:
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, sum);
            // string interpolation:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");

            Console.WriteLine(); // another line spacer

            // and if we wanted to put all the equations in a single statement:
            double quotientRounded = Math.Round(quotient, 3);   // creating a new variable to hold the rounded version of quotient
            Console.WriteLine("{0} + {1} = {2}\n{0} - {1} = {3}\n{0} * {1} = {4}\n{0} / {1} = {5}", firstNumber, secondNumber, sum, diff, product, quotientRounded);


        } // end of method
    } // end of class
} // end of namespace
