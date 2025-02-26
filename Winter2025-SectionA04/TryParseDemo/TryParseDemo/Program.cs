namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0; // give age a starting value
            bool goodInput;

            do
            {
                string userInput;

                Console.Write("Please enter a #: ");
                userInput = Console.ReadLine();

                goodInput = int.TryParse(userInput, out age);
                // this line will try to parse userInput as an int
                // if successful, goodInput is now TRUE and age now has a value
                // otherwise, goodInput is now FALSE

                if (goodInput == false)
                    Console.WriteLine("INVALID INPUT!");

            } while (goodInput == false);

            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine("Goodbye!");

        }
    }
}
