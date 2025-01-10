/*
 * 
 *  TO DO: OPENING COMMENT BLOCK!
 * 
 */ 
namespace Topic3Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int numberOfHours;

            // ask the user how many hours of sleep they had
            Console.Write("Enter the hours of sleep you had: ");
            numberOfHours = int.Parse(Console.ReadLine());

            // if hours < 0: also a liar (or a time traveller)
            if (numberOfHours < 0)
            {
                Console.WriteLine("That's impossible.");
            }
            // if hours 0 - 4 (inclusive): you need a nap
            else if (numberOfHours <= 4)
            {
                Console.WriteLine("You might want to take a nap.");
            }
            // if hours 5-7: adequate sleep
            else if (numberOfHours <= 7)
            {
                Console.WriteLine("That is adequate.");
            }
            // if hours 8-24: great sleep/coma
            else if (numberOfHours <= 24)
            {
                Console.WriteLine("That's a great sleep/coma.");
            }
            // if hours > 24: you are a liar
            else
            {
                Console.WriteLine("That's impossible.");
            }
        }
    }
}


