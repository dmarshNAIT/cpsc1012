namespace Topic2Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 1st number.");
            Console.Write("Enter your 2nd number.");
            Console.WriteLine("Here is your solution.");

            // create a variable:
            int bob = 7;
            Console.WriteLine("The value is " + bob + ".");

            double pi = 3.14;

            // here we are explicitly converting to an int, so we lose all the decimals:
            int approximatePi = (int)3.14;
            Console.WriteLine("The value of approximatePi is " + approximatePi);

            // do math
            int numberOfPeople = 10;
            int numberOfPets = 15;
            double averageNumberOfPets = numberOfPets / numberOfPeople;
            Console.WriteLine("The average number of pets per person is " + averageNumberOfPets);
            // if I divide 2 numbers and BOTH are ints: we will do integer division. that means we ALWAYS get an int.

            // here is one way to fix that problem: make one of the values into a double
            averageNumberOfPets = (double)numberOfPets / numberOfPeople;
            Console.WriteLine("The average number of pets per person is " + averageNumberOfPets);
            // another solution: change the data type of the variables

            // how to round numbers:
            double result = 2.0 / 7;
            Console.WriteLine("The result is " + result);
            double roundedResult = Math.Round(result, 4);
            Console.WriteLine("The rounded result is " + roundedResult);
        }
    }
}
