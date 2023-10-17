namespace Oct17ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;
            int userInput = 0; // this holds the # of shows

            // create an array that holds up to 10 strings
            string[] tvShows = new string[ARRAY_SIZE];

            // ask the user how many shows they'd like to store
            Console.Write("How many shows would you like to save: ");
            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid. Goodbye.");
            }

            // if the number is > 10, change it to 10
            if (userInput > ARRAY_SIZE)
            {
                Console.WriteLine($"Sorry, that's too many.\nWe will save your top {ARRAY_SIZE}.");
                userInput = ARRAY_SIZE;
            }
            else if (userInput < 0)
            {
                Console.WriteLine($"Negative number? Nope.\nWe will save your top {ARRAY_SIZE/2}.");
                userInput = ARRAY_SIZE/2;
            }

            // fill the array with user-provided values
            for (int index = 0; index < userInput; index++)
            {
                Console.Write("Please enter the show name: ");
                tvShows[index] = Console.ReadLine();
            }

            // display the contents of the array

        }
    }
}