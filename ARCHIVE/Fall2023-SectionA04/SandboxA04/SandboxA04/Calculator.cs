namespace SandboxA04
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! \nHi I'm still Dana");

            // display a prompt to the user
            Console.Write("Please enter your name: ");

            // read in their name
            string userInput = Console.ReadLine();
            Console.WriteLine("It's nice to meet you, {0}.\n\n", userInput);

            // Display welcome to user
            Console.WriteLine("Welcome to our calculator! Math is awesome.\n");

            // create variables to hold our user's input
            int value1;
            int value2;

            // Prompt user for value 1
            Console.Write("Please enter a number: ");
            userInput = Console.ReadLine(); // this line reads the value from the console, and saves it as a string
            value1 = int.Parse(userInput);  // this line extracts the numeric value from the string and saves it as an int
            Console.WriteLine("The 1st number is: " + value1);

            // Prompt user for value 2
            // TO DO: replace this with a prompt
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
            Console.WriteLine("The product of {0} and {1} is {2}.", value1, value2, value1 * value2);

            // Calculate quotient
            double quotient = (double) value1 / value2;
            // Display quotient
            Console.WriteLine("Quotient is " + quotient);





            /* Let's play around with data types */
            int myInt = 17;
            double myDouble = myInt;
            Console.WriteLine("myInt: " + myInt);
            Console.WriteLine("myDouble: " + myDouble);
            // this worked! 

            myDouble = 910;
            myInt = (int)myDouble;
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
            // this also worked: 910 is a "valid" value for an int

            myDouble = 5000000000;
            myInt = (int)myDouble;
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
            // 5 billion is not a valid value for an int, so some data was cut off, resulting in a completely different value

            myDouble = 3.999999;
            myInt = (int)myDouble;
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
            // ints can't have decimal places, so they were cut off (AKA truncated)
        }
    }
}