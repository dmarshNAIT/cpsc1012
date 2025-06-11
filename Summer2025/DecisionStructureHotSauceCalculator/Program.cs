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
            char userInput;
            bool isExtraSpicy;   //whether or not they'd like a spicy booster
            int heatLevel = 0;       //heat level

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

            // calculation
            // mild = 2, medium = 5, hot = 8
            switch (spiceDegree)
            {
                // if spiceDegree is mild:
                case "mild":
                    heatLevel = 2;
                    break;
                // if spiceDegree is medium:
                case "medium":
                    heatLevel = 5;
                    break;
                // if spiceDegree is hot:
                case "hot":
                    heatLevel = 8;
                    break;
                default:
                    // this only runs if they enter an invalid choice
                    Console.WriteLine("That was not a valid choice.");
                    break;
            }

            // do they want a booster?
            Console.Write("Would you like your sauce to be extra spice (yes/no): ");
            // save the first character of their answer:
            userInput = Console.ReadLine().Trim().ToUpper()[0];
            // assign a value to isExtraSpicy
            if (userInput == ('Y'))
            {
                isExtraSpicy = true;
            }
            else
            {
                isExtraSpicy = false;
            }

            // if they request extra spicy, +2 
            if (isExtraSpicy)
            {
                heatLevel = heatLevel + 2;
            }

            // OR:
            // heatLevel = isExtraSpicy ? heatLevel + 2 : heatLevel;

            // output
            // print the overall heat level
            Console.WriteLine("Your hot sauce has an overall heat level of " + heatLevel);
            // if they exceed their tolerance, print a warning
            if (heatLevel > spiceTolerance)
            {
                Console.WriteLine("That's too spicy for you.");
            }
        }
    }
}
