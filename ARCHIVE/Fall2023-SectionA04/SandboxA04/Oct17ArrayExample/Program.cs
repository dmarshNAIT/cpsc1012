namespace Oct17ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;
            int numberOfShows = 0;

            // create an array that holds up to 10 strings
            string[] tvShows = new string[ARRAY_SIZE];

            // ask the user how many shows they'd like to store
            Console.Write("How many shows would you like to save: ");
            try
            {
                numberOfShows = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid. Goodbye.");
            }

            // if the number is > 10, change it to 10
            if (numberOfShows > ARRAY_SIZE)
            {
                Console.WriteLine($"Sorry, that's too many.\nWe will save your top {ARRAY_SIZE}.");
                numberOfShows = ARRAY_SIZE;
            }
            else if (numberOfShows < 0)
            {
                Console.WriteLine($"Negative number? Nope.\nWe will save your top {ARRAY_SIZE / 2}.");
                numberOfShows = ARRAY_SIZE / 2;
            }

            // fill the array with user-provided values
            for (int index = 0; index < numberOfShows; index++)
            {
                Console.Write("Please enter the show name: ");
                tvShows[index] = Console.ReadLine();
            }

            // display the contents of the array
            // loop through each element
            // print it to the screen
            // e.g. Your favourite shows are: Breaking Bad, Community, IT Crowd, Walking Dead
            string outputMessage = "\nYour favourite shows are: ";

            for (int index = 0; index < numberOfShows; index++)
            {
                outputMessage = outputMessage + tvShows[index]; // add the name of the show to our string

                if (index < numberOfShows - 1) // if it's not the last element
                {
                    outputMessage = outputMessage + ", "; // add the comma to the end of our string
                }
            }

            outputMessage = outputMessage + "\n\nThank you, goodbye.";
            Console.WriteLine(outputMessage);

        }
    }
}