/* Name:        CoffeeCalculator2000
 * Author:      Dana Marsh with assistance from section A05
 * Modified:    Sep 19, 2024
 * 
 * Input:       the diameter in cm, height in cm
 *              Possible stretch goal: # of coffee cups per day
 *              
 * Output:      volume in cubic centimeters
 *              Possible stretch goal: volume of coffee consumed over a time period
 * 
 * Purpose:     The user will input the dimensions of their coffee cup, and the program
 *              will calculate the volume of coffee.
 *              
 *              Possible stretch goal: convert cubic centimeters to another unit
 *                  1000 cm^3 = 1 L
 */ 

namespace Topic2PracticePeriod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double diameter,    // diameter in cm
                radius,         // radius in cm
                height,         // height in cm
                radiusSquared,  // radius in cm^2
                volume;         // volume in cm^3
            string userInput;
            const int CM3_TO_LITERS_CONVERSION = 1000;

            // welcome the user
            Console.WriteLine("Welcome to the CoffeeCalculator2000.\n" +
                "Let's find out how much coffee you drink.\n");

            // prompt user for their cup's radius
            Console.Write("Enter the diameter of your coffee cup, in centimeters: "); // diameter is the edge-to-edge measurement
            userInput = Console.ReadLine();
            diameter = double.Parse(userInput);
            radius = diameter / 2;

            // prompt user for their cup's height
            Console.Write("Enter the height of your coffee cup, in centimeters: ");
            height = double.Parse(Console.ReadLine());

            // calculate the volume of the cup
            // volume = pi * r ^ 2 * h
            radiusSquared = Math.Pow(radius, 2);
            // radiusSquared = Math.Pow(diameter / 2, 2); // also correct
            // radiusSquared = radius * radius; // also correct
            // if we wanted to square the value given by the user
            // radiusSquared = Math.Pow(double.Parse(Console.ReadLine()), 2);
            volume = Math.PI * radiusSquared * height;

            // display the results
            Console.WriteLine($"The volume of your coffee cup is {Math.Round(volume, 2)} cubic centimeters.");

        }
    }
}
