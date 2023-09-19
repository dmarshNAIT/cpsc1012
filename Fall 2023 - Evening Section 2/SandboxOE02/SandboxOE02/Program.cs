namespace SandboxOE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("hi I'm Dana. \nWelcome to my awesome calculator.\n\n");

            Console.WriteLine("What is your name?");
            string userInput;
            Console.ForegroundColor = ConsoleColor.Green; // bonus content: this will make our user input green
            userInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White; // and now we'll switch back to white text

            Console.WriteLine($"Nice to meet you, {userInput}.\n");

            //	Read num1
            Console.Write("Please enter 1st number: ");
            userInput = Console.ReadLine(); // this reads the input from the user
            int num1; // this line declares (or creates) the variable
            num1 = int.Parse(userInput); // this line assigns that variable a value
            Console.WriteLine("The first number is: " + num1);

            //	Read num2
            Console.Write("Please enter 2nd number: ");
            int num2 = int.Parse(Console.ReadLine()); // this is a little more advanced: we are combining 3 statements in one.
            Console.WriteLine("The 2nd number is: " + num2);

            //	Calculate sum = num1 + num2
            int sum = num1 + num2;
            //	Display sum
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

            //	Calculate difference = num1 – num2
            int diff = num1 - num2;
            //	Display difference
            Console.WriteLine("The difference between {0} and {1} is: {2}", num1, num2, diff);

            //	Calculate product = num1 * num2
            //	Display product
            Console.WriteLine($"The product of {num1} and {num2} is: {num1 * num2}");

            //	Calculate quotient = num1 / num2
            double quotient = (double)num1 / num2;
            //	Display quotient
            Console.WriteLine($"The quotient of {num1} and {num2} is: {quotient}\n\n\n");



            /* let's play around with data types */
            int myInt = 456;
            double myDouble = myInt; // implicit conversion
            Console.WriteLine("myInt: " + myInt);
            Console.WriteLine("myDouble: " + myDouble);
            // this worked: doubles are able to hold the values of ints

            myDouble = 789;
            myInt = (int)myDouble; //explicit conversion
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
            // this also works.

            myDouble = 5000000000;
            myInt = (int)myDouble; //explicit conversion
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
            // this doesn't really work: 5billion is too big to be an int.

            myDouble = 3.99999999;
            myInt = (int)myDouble; //explicit conversion
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
            // this also doesn't really work: we've lost all the decimals and have a misleading number left over.





            // TO DO in the future (we need more skills first): What happens if they divide by zero??

        }
    }
}