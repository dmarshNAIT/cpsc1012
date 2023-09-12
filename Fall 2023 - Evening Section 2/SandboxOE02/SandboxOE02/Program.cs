namespace SandboxOE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("hi I'm Dana. Welcome to my awesome calculator.");

            //	Read num1
            // we don't know how to read input from the user, so let's hardcode some values for now
            int num1; // this line declares (or creates) the variable
            num1 = 2; // this line assigns that variable a value
            Console.WriteLine("The first number is: " + num1);

            //	Read num2
            int num2 = 3; // this statement does the declaration & initialization in one step!
            Console.WriteLine("The 2nd number is: " + num2);

            //	Calculate sum = num1 + num2
            int sum = num1 + num2;

            //	Display sum
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

            //	Calculate difference = num1 – num2
            //	Display difference
            //	Calculate product = num1 * num2
            //	Display product

            //***** STOP HERE *****//
            //	Calculate quotient = num1 / num2
            //	Display quotient


            // TO DO: What happens if they divide by zero??

            Console.ReadLine(); // waiting for user input
        }
    }
}