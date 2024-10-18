namespace Topic7_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 0;
            Random random = new Random();
            int[] fibonacci;
            const int LOWER_LIMIT = 2,
                    UPPER_LIMIT = 46;
            int randomIndex;

            do
            {
                // ask the user for how many #s from the sequence
                Console.Write("How many Fibonacci #s would you like: ");
                try
                {
                    numberOfElements = int.Parse(Console.ReadLine());
                    if (numberOfElements < LOWER_LIMIT)
                    {
                        Console.WriteLine($"Invalid: must be at least {LOWER_LIMIT}.");
                    }
                    else if (numberOfElements > UPPER_LIMIT)
                    {
                        Console.WriteLine($"Invalid: must be less than {UPPER_LIMIT + 1}.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (numberOfElements < LOWER_LIMIT || numberOfElements > UPPER_LIMIT);
            // continue looping as long as the number is NOT between LOWER_LIMIT & UPPER_LIMIT, inclusive

            // create an array
            fibonacci = new int[numberOfElements];

            // load the array with data
            for (int index = 0; index < numberOfElements; index++)
            {
                // elements 0 and 1 are hardcoded
                if (index <= 1)
                {
                    fibonacci[index] = index;
                }
                // the other elements are the previous 2 added
                else
                {
                    int prev = fibonacci[index - 1];
                    int prevPrevious = fibonacci[index - 2];
                    fibonacci[index] = prev + prevPrevious;
                }
            }

            // display the contents of the array
            // TODO: nicely aligned
            for (int index = 0; index < numberOfElements; index++)
            {
                Console.WriteLine($"Element #{index + 1, 2:00}:   { fibonacci[index],15:n0}");
            }

            // choose a random element
            // first, generate a random index
            randomIndex = random.Next(numberOfElements);
            // then, display the value at that location
            Console.WriteLine($"Today's lucky number is {fibonacci[randomIndex]}.");

            // I used numberOfElements throughout; if we wanted a more defensive approach we should use fibonnaci.Length
        }
    }
}

// TODO: check scope
