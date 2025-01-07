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
            string userInput,
                    outputMessage;
            const int CONVERSION_FACTOR = 4;
            // const double OTHER_CONVERSION_FACTOR = 4.0 / 3;

            // prompt user for the cat's age
            Console.Write("Welcome to CatCalculator5000!\n\nPlease enter the cat's age: ");
            catAge = int.Parse(Console.ReadLine());

            // calculate the cat's equivalent human age
            // if the cat's age is < 0, show an error message
            if (catAge < 0)
            {
                outputMessage = "ERROR: Invalid age.";
            }
            // if the cat's age is 0, their human age is 0
            else if (catAge == 0)
            {
                humanAge = 0;
                outputMessage = $"In human years, your cat is {humanAge}.";
            }
            // if the cat is 1 year old, their human age is 15
            else if (catAge == 1)
            {
                humanAge = 15;
                //Console.WriteLine($"In human years, your cat is {humanAge}.");
                outputMessage = "In human years, your cat is " + humanAge + ".";
            }
            // if the cat is 2 years old, their human age is 24
            else if (catAge == 2)
            {
                humanAge = 24;
                outputMessage = $"In human years, your cat is {humanAge}.";
            }
            // if the cat is 3 or older, their human age is (age-2)*4+24
            else
            {
                // The first year of your cat’s life is considered the equivalent of 15 human years. The second year adds nine more human years, so 2 cat years are approximately 24 human years. After this, each additional human year is four ‘cat years’ i.e., age 3 will be 28 human years. 
                humanAge = 24 + (catAge - 2) * CONVERSION_FACTOR;
                outputMessage = $"In human years, your cat is {humanAge}.";
            }
            // e.g. if the cat is 3 --> in human years 28
            // e.g. if the cat is 10 --> in human years 56

            Console.WriteLine(outputMessage);

            // TEST:
            // negative number
            // age of 0
            // age of 1
            // age of 2
            // age of 3
            // age of 10

            // prompt user for diameter: Q&A
            Console.Write("Please enter the diameter of your cat's yarn ball: ");
            userInput = Console.ReadLine();
            ballDiameter = double.Parse(userInput);

            // calculate the yarn ball volume
            // volume of a sphere (ball) = 4/3 * pi * r^3
            ballRadius = ballDiameter / 2;
            radiusCubed = Math.Pow(ballRadius, 3);
            ballVolume = 4 / 3.0 * Math.PI * radiusCubed;

            // display results
            Console.WriteLine($"Your cat's yarn ball is {Math.Round(ballVolume, 3)} cubic centimeters.");

        

        }
    }
}
