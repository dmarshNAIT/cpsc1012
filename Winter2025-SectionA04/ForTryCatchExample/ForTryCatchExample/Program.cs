namespace ForTryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // marks calculator:
            double sum = 0,
                averageMark;

            // use a for loop to get input from a user
            for (int counter = 1; counter <= 3; counter++)
            {
                double mark = 0; // initialize this; we will overwrite this value later
                bool invalidInput = true;
                do
                {
                    Console.Write($"Please enter mark #{counter}: ");
                    try
                    {
                        mark = double.Parse(Console.ReadLine());
                        invalidInput = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("That is invalid input.");
                        Console.WriteLine(ex.Message);
                    }
                } while (invalidInput);

                sum = sum + mark;
            }

            averageMark = sum / 3;

            Console.WriteLine("Your average mark is: " + averageMark);
        }
    }
}
