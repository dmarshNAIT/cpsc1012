namespace SandboxA05
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello, World!\nHi I'm Dana.");

            // Display welcome message
            Console.WriteLine("Welcome to our super awesome calculator.");

            // Prompt user for value 1
            // we don't know how to get input yet, so let's hardcode some values for now.

            int value1;
            value1 = 2;
            Console.WriteLine("The first number is " + value1);

            // Prompt user for value 2
            int value2;
            value2 = 3;

            // Calculate value1 + value 2
            int sum;
            sum = value1 + value2;

            // Display value1 + value 2
            Console.WriteLine("The sum of " + value1 + " and " + value2 + " is " + sum);


            // Calculate value1 - value 2
            int diff = value1 - value2;


            // Display value1 / value 2
            Console.WriteLine("The difference between {0} and {1} is {2}.", value1, value2, diff);

            // Calculate value1 * value 2
            // Display value1 * value 2


            // Calculate value1 / value 2
            double quotient = (double) value1 / value2;
            Console.WriteLine("The answer is " + quotient);

            // Display value1 / value 2

        }
    }
}
     