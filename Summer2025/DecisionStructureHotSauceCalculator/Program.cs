/*
 * Purpose:     Given user-inputted values, calculate the "heat rating" of a hot sauce.
 * Author:      Dana Marsh with review by section OE01
 * Modified:    June 10, 2025
 * 
 * Input:       Customer's spice tolerance (1-10), base sauce spiciness (mild, medium, hot), 
 *              whether or not they'd like a spicy booster
 * Output:      Heat level, & a warning if the spice level is too high
 * 
*/
namespace DecisionStructureHotSauceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int spiceTolerance;  //customer's spice tolerance
            string spiceDegree;  //choice of sauce spiciness
            string userInput;
            bool isExtraSpicy;   //whether or not they'd like a spicy booster
            int heatLevel;       //heat level

            // get input from the user
            // v1:  pretend the user enters valid input
            // spice tolerance
            Console.Write("Please enter your spice tolerance from 1-10: ");
            spiceTolerance = int.Parse(Console.ReadLine());
            // future TODO: add input validation

            // which level of spice
            Console.Write("Please select your spice level: mild, medium, or hot: ");
            spiceDegree = Console.ReadLine().ToLower().Trim();
            // this forces the user's input to be lowercase, then trims any extra whitespace

            // do they want a booster?
            Console.Write("Would you like your sauce to be extra spice (yes/no): ");
            userInput = Console.ReadLine();
            // assign a value to isExtraSpicy

            // calculation
            // mild = 2, medium = 5, hot = 8
            // if they request extra spicy, +2 

            // output
            // print the overall heat level
            // if they exceed their tolerance, print a warning
        }
    }
}
