namespace UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create variables
            string username,
                userInput;

            int userAge;

            // ask a question
            Console.Write("What is your name? ");

            // read in their answer, AND SAVE IT
            username = Console.ReadLine();

            // print out a welcome
            // v1: string concatenation
            Console.WriteLine("Welcome, " + username);
            // v1: string interpolation
            Console.WriteLine($"Welcome, {username}");

            // ask another question
            Console.Write("How old are you? ");

            // save the answer
            userInput = Console.ReadLine();
            userAge = int.Parse(userInput);

            // or, combined:
            // userAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"You are {userAge} years old.");

        }
    }
}
