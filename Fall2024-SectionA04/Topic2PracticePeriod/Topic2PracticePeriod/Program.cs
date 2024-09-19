/* Name:        CatCalculator
 * Author:      Dana Marsh + section A04
 * Modified:    Sep 19, 2024
 * 
 * Input:       diameter of the yarn ball, age of the cat
 * Output:      volume of the yarn ball, the cat's human age
 * 
 * Purpose:     Calculate the volume of a yarn ball for our cat, given the ball's diameter.
 *              Calculate the human age of the cat.
 */ 
namespace Topic2PracticePeriod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables & their data types
            int catAge, humanAge;
            double ballDiameter,   // in centimeters
                    ballRadius,    // in centimeters
                    radiusCubed,
                    ballVolume;
            string userInput;
            const int CONVERSION_FACTOR = 4;
            // const double OTHER_CONVERSION_FACTOR = 4.0 / 3;

            // prompt user for the cat's age
            Console.Write("Welcome to CatCalculator5000!\n\nPlease enter the cat's age: ");
            catAge = int.Parse(Console.ReadLine());

            // prompt user for diameter: Q&A
            Console.Write("Please enter the diameter of your cat's yarn ball: ");
            userInput = Console.ReadLine();
            ballDiameter = double.Parse(userInput);

            // calculate the cat's equivalent human age
            humanAge = catAge * CONVERSION_FACTOR; // SEE FUTURE CHALLENGE BELOW

            // calculate the yarn ball volume
            // volume of a sphere (ball) = 4/3 * pi * r^3
            ballRadius = ballDiameter / 2;
            radiusCubed = Math.Pow(ballRadius, 3);
            ballVolume = 4 / 3.0 * Math.PI * radiusCubed;

            // display results
            Console.WriteLine($"\nYour cat's age in human years is {humanAge}.\n" +
                $"Your cat's yarn ball is {Math.Round(ballVolume, 3)} cubic centimeters.");


            // FUTURE CHALLENGE (once we learn how to make decisions):
            // The first year of your cat’s life is considered the equivalent of 15 human years. The second year adds nine more human years, so 2 cat years are approximately 24 human years. After this, each additional human year is four ‘cat years’ i.e., age 3 will be 28 human years. 

        }
    }
}
