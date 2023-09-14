namespace SandboxA05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\nHi I'm Dana. What's your name?");
            string userInput = Console.ReadLine();
            Console.WriteLine("Nice to meet you, {0}!\n", userInput);

            // Display welcome message
            Console.WriteLine("Welcome to our super awesome calculator.");

            // Prompt user for value 1
            Console.Write("Please enter 1st number: ");
            userInput = Console.ReadLine(); // this reads input from the user
            int value1 = int.Parse(userInput); // this turns it into an int, if possible
            Console.WriteLine("You entered: " + value1);

            // Prompt user for value 2
            Console.Write("Please enter 2nd number: ");
            userInput = Console.ReadLine(); // this reads input from the user
            int value2 = int.Parse(userInput); // this turns it into an int, if possible
            Console.WriteLine("You entered: " + value2 + "\n");

            // Calculate value1 + value 2
            int sum;
            sum = value1 + value2;

            // Display value1 + value 2
            Console.WriteLine("The sum of " + value1 + " and " + value2 + " is " + sum);


            // Calculate value1 - value 2
            int diff = value1 - value2;

            // Display value1 / value 2
            Console.WriteLine("The difference between {0} and {1} is {2}.", value1, value2, diff);

            // Calculate & display the product:
            Console.WriteLine("The product of {0} and {1} is {2}.", value1, value2, value1 * value2);

            // Calculate value1 / value 2
            double quotient = (double)value1 / value2;
            // Display value1 / value 2
            Console.WriteLine("The quotient is " + quotient);



            /* Let's play around with data types */
            int myInt = 6;
            double myDouble = myInt; // implicit conversion
            Console.WriteLine("\n\nmyInt is " + myInt);
            Console.WriteLine("myDouble is " + myDouble);
            // this works: ints can be cast to doubles

            myDouble = 27;
            myInt = (int)myDouble; // explicit conversion
            Console.WriteLine("myDouble is " + myDouble);
            Console.WriteLine("myInt is " + myInt);
            // this also worked: 27 is a valid value for an int

            myDouble = 5000000000;
            myInt = (int)myDouble; // explicit conversion
            Console.WriteLine("myDouble is " + myDouble);
            Console.WriteLine("myInt is " + myInt);
            // 5billion is "too big" to be saved as an int so we see a different result

            myDouble = 3.999999999;
            myInt = (int)myDouble; // explicit conversion
            Console.WriteLine("myDouble is " + myDouble);
            Console.WriteLine("myInt is " + myInt);
            // ints cannot hold decimals so they are cut off
        }

    }
}
