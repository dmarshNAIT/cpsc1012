/// <summary>
/// The purpose of the program is to demonstrate the use of Power and how to get input from the user.
/// Author: Dana Marsh
/// Last Modified Date: January 24, 2025
/// </summary

namespace UserInputExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's practice using Math.Pow
            // to calculate 2 to the power of 5
            // that means 2 * 2 * 2 * 2 * 2 = 32
            double result = Math.Pow(2, 5);
            Console.WriteLine("The result is " + result);

            int baseNumber = 2;
            int powerNumber = 5;
            result = Math.Pow(baseNumber, powerNumber);
            Console.WriteLine("The result is " + result);


            // declare variables that we need
            string userInput;
            int age;

            // ask a question:
            Console.Write("What food do you want to eat? ");
            // get the answer:
            userInput = Console.ReadLine();
            // print a message including that food name
            Console.WriteLine("Sounds like you are going to have " + userInput + " for lunch.");

            // let's ask another question, where the answer is a #
            Console.Write("How old are you in years? ");
            // read in their answer
            userInput = Console.ReadLine();
            // then turn it into a number
            age = int.Parse(userInput); // Parse will attempt to turn the string into an int
                                        // then I can print it out
            Console.WriteLine("You are " + age + " years old.");


            // let's create a double
            // then force it into an int and see what happens
            double bigNumber = 123456789012;
            int otherBigNumber = (int) bigNumber;
            Console.WriteLine("The value of otherBigNumber is " + otherBigNumber);

        }
    }
}
