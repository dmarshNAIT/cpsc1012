namespace SandboxA04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! \nHi I'm still Dana");

            // Display welcome to user
            Console.WriteLine("Welcome to our calculator! Math is awesome.\n");

            // create variables to hold our user's input
            int value1;
            int value2;

            // Prompt user for value 1
            value1 = 2;
            // we haven't learned how to read input from the user yet :(
            // so this will be our temporary workaround.
            Console.WriteLine("The 1st number is: " + value1);

            // Prompt user for value 2
            value2 = 3;
            Console.WriteLine("The 2nd number is: " + value2);

            // Calculate sum
            int sum;
            sum = value1 + value2;

            // Display sum
            Console.WriteLine("The sum of " + value1 + " and " + value2 + " is " + sum + ".");

            // Calculate difference
            int diff = value1 - value2;

            // Display difference
            Console.WriteLine("The difference between {0} and {1} is {2}.", value1, value2, diff);

            // Calculate product
            // Display product
            Console.WriteLine("The product of {0} and {1} is {2}.", value1, value2, value1*value2);

            // Calculate quotient
            double quotient = (double) value1 / value2;

            // Display quotient
            Console.WriteLine("Quotient is " + quotient);

        }
    }
}