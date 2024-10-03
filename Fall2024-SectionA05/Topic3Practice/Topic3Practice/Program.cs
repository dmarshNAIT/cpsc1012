/* Name:     Math Quiz
 * Author:   Dana & friends
 * Modified: Oct 3, 2024
 * 
 * Input:    Menu choice, answer to math equation
 * Output:   Result of the quiz
 * 
 * Purpose:  Getting more comfortable using switch statements.
 */
namespace Topic3Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            Random numberGenerator = new Random();
            const int MAX_NUMBER = 50;
            int firstRandomNumber = numberGenerator.Next(MAX_NUMBER),
                secondRandomNumber = numberGenerator.Next(MAX_NUMBER),
                userAnswer;
            char menuChoice;
            string outputMessage;

            // show our user a main menu
            Console.Write("Welcome to our Math Quiz!\n" +
                "Enter + to do addition.\n" +
                "Enter - to do subtraction.\n" +
                "What is your choice? ");

            // ask the user to make a choice
            menuChoice = char.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case '+':
                    // show them an equation
                    Console.Write($"{firstRandomNumber} + {secondRandomNumber} = ");
                    // ask them what the sum is
                    userAnswer = int.Parse(Console.ReadLine());
                    // tell them if they are correct
                    outputMessage = (firstRandomNumber + secondRandomNumber == userAnswer) ? "Correct!" : "Sorry, that's wrong.";
                    break;
                case '-':
                    // show them an equation
                    Console.Write($"{firstRandomNumber} - {secondRandomNumber} = ");
                    // ask them what the difference is
                    userAnswer = int.Parse(Console.ReadLine());
                    // tell them if they are correct
                    outputMessage = (firstRandomNumber - secondRandomNumber == userAnswer) ? "Correct!" : "Sorry, that's wrong.";
                    break;
                default:
                    outputMessage = "That's not a valid choice. Goodbye.";
                    break;
            }

            Console.WriteLine(outputMessage);


            // TO DO: debug


            // CHALLENGE: Add options for multiplication, division, or any other math you can think of.


            // SUFFIX practice:
            // double myDouble = 7;
            // float myFloat = 7.123456789f;

        }
    }
}
