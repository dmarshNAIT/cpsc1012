/*
 * This project is to demonstrate a few different types of loops and exception-handling techniques.
 * 
 */
namespace LoopsAndExceptionsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******************* LOOPS **********************/
            // let's imagine we want to print the numbers from 1 to 10.

            int number = 1;

            // here is a simple-ish example of a while loop, but it's not the best loop choice, because we are executing a specific number of times.
            while (number <= 10)
            {
                Console.WriteLine("The value is " + number);

                number = number + 1;
                //number += 1;
                // number++; // this gives the value, then adds 1
                //++number;  // this adds 1, then gives the value
            }

            // here is the same logic, using a for loop
            for (int lessBoringNumber = 1; lessBoringNumber <= 12; lessBoringNumber++)
            {
                Console.WriteLine($"The value is {lessBoringNumber}");
            }
            // for loops are GREAT when we know exactly how many times the loop will repeat

            // we could loop until the user says the magic word
            string userInput,
                magicWord = "stop";

            Console.Write("Please enter the magic word: ");
            userInput = Console.ReadLine().ToLower();

            while (userInput != magicWord)
            {
                Console.Write("Nope! That isn't it. Try again: ");
                userInput = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Hooray! You escaped the loop!");
            // while loops are perfect when we need to loop zero, 1, or many times.

            // we stay in the loop until the user guesses the secret number
            int userGuess,
                secretNumber = 42;

            do
            {
                Console.Write("I am thinking of a number between 1 & 100. Guess it: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Yay, you're a math genius.");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Sorry, that's not it. Try again (hint: the number is larger).");
                }
                else
                {
                    Console.WriteLine("Sorry, that's not it. Try again (hint: the number is smaller).");
                }

            } while (userGuess != secretNumber);

            Console.WriteLine("Yay, you escaped again!");
            // do-while loops are perfect for code that MUST EXECUTE AT LEAST ONCE, possibly many times.
        }
    }
}
