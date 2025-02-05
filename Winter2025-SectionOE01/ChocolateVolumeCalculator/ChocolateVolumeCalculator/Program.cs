/*
 * Name: Chocolate Volume Calculator
 * Purpose: This program prompts the user for the dimensions of their cup and then calculates the fluid volume within.
 * 
 * Author: Dana Marsh with assistance from section OE01
 * Last modified: Jan 28, 2025
 */
namespace ChocolateVolumeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            float diameter,
                height,
                radius,
                volume;
            string beverageType;

            // get input from the user
            Console.Write("Welcome to the ChocolateVolumeCalculator5000!\n\n" +
                "Please enter the diameter (in cm) of your cup: ");
            diameter = float.Parse(Console.ReadLine());

            Console.Write("Please enter the height (in cm) of your cup: ");
            height = float.Parse(Console.ReadLine());

            Console.Write("Please enter the type of beverage you are enjoying: ");
            beverageType = Console.ReadLine();

            // calculations
            radius = diameter / 2;
            volume = (float) (Math.PI * Math.Pow(radius, 2) * height);

            // output results in this format:
            // Your cup of hot chocolate is 123 cubic cm.

            // string concatenation:
            Console.WriteLine("\nYour cup of " + beverageType + " is " + Math.Round(volume, 1) + " cubic cm.");
            // string interpolation:
            Console.WriteLine($"Your cup of {beverageType} is {volume:F1} cubic cm.\n\nGood bye!");

            // Possible stretch goals: we can ask how many beverages they drink in a day/week, and tell them their annual consumption.
            // perhaps we translate from cubic cm to Liters or some other unit?
         
        }
    }
}