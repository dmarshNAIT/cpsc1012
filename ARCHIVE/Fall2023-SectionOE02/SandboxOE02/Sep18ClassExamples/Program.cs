/* purpose:
 * input:
 * process:
 * output:
 * author:
 * date:
 */


namespace Sep18ClassExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // let's play around with powers
            double num = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;
            Console.WriteLine(num);

            Math.Pow(2, 30);
            Console.WriteLine(num);

            // let's calculate a square root
            num = Math.Sqrt(25);
            Console.WriteLine(num);

            // rounding numbers
            num = Math.PI;
            Console.WriteLine(num);

            double roundedPi = Math.Round(num);
            Console.WriteLine(roundedPi);

            roundedPi = Math.Round(num, 5);
            Console.WriteLine(roundedPi);

            // working with constants
            const double GST_RATE = 0.05;

            // playing with strings
            string fact = "Tyrell is my favourite student.";

            Console.WriteLine(fact);            // prints "Tyrell is my favourite student."
            Console.WriteLine(fact.ToLower());  // prints "tyrell is my favourite student."
            Console.WriteLine(fact.ToUpper());  // prints "TYRELL IS MY FAVOURITE STUDENT."
            Console.WriteLine("Dana's favourite number is {roundedPi}");    // prints "Dana's favourite number is {roundedPi}"
            Console.WriteLine($"Dana's favourite number is {roundedPi}");   // prints "Dana's favourite number is 3.14159"


            //Sequence Structure example #5:

            // input: amount to represent the current balance; annual interest rate; # of years
            // calculate or process: future value = investment amount * ( 1 + monthly interest rate) to the power of (number of years * 12)
            // output: future value

            // set up the variables we need
            double currentBalance,
                annualInterest,
                monthlyInterest,
                parentheses,
                power,
                futureAmount;
            int numYears;
            string input;

            // prompt the user input the current balance, annual interest rate, and # of years
            Console.Write("Enter your current balance: $");
            input = Console.ReadLine();
            currentBalance = double.Parse(input);  // convert current balance to double

            Console.Write("Enter your annual interest rate (without the % sign): ");
            input = Console.ReadLine();
            annualInterest = double.Parse(input);   // convert annual interest rate to a double,
            monthlyInterest = annualInterest / 100 / 12; // divide by 100 (to make it a %), then divide by 12 to get monthly rate

            Console.Write("Enter the # of years: ");
            input = Console.ReadLine();
            numYears = int.Parse(input);    // convert number of years to int
                                            //numYears = Convert.ToInt32(input);

            // calculate the future value
            parentheses = 1 + monthlyInterest;
            power = Math.Pow(parentheses, numYears * 12);
            futureAmount = currentBalance * power;

            // display the results
            Console.WriteLine($"The future value of your investment is {futureAmount:c}.");

        }
    }
}