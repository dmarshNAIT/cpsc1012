/*
 * Purpose:         Calculate the hypotenuse of a right-angle triangle
 *                  given 2 user-provided values.
 * Author:          Dana Marsh with assistance from A04
 * Last modified:   Jan 29, 2025
 * 
 * Input:           lengths of 2 sides & the units
 * Output:          length of the hypotenuse
 */

namespace PythagoreanTheorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double shapeBase,
                 shapeHeight,   // AKA perpendicular
                 hypotenuse,
                 baseSquared,
                 heightSquared;
            string units;

            // prompt user for units
            Console.Write("Welcome to our Hypotenuse Calculator!\n\n" +
                "Please enter the units of measurement: ");
            units = Console.ReadLine();

            // prompt user for length of base
            Console.Write("Please enter the length of the base of the triangle: ");
            shapeBase = double.Parse(Console.ReadLine());

            // prompt user for height of side
            Console.Write("Please enter the height of the triangle: ");
            shapeHeight = double.Parse(Console.ReadLine());

            // calculate the hypotenuse
            // hypotenuse = square root of ( base squared + perpendicular squared )
            baseSquared = Math.Pow(shapeBase, 2);
            heightSquared = Math.Pow(shapeHeight, 2);
            hypotenuse = Math.Sqrt(baseSquared + heightSquared);
            // this is equivalent to the following statement:
            //hypotenuse = Math.Sqrt(Math.Pow(shapeBase, 2) + Math.Pow(shapeHeight, 2));

            // output results
            // "The length of the hypotenuse is 123 inches long."
            // v1: string concatenation
            Console.WriteLine("The length of the hypotenuse is " + Math.Round(hypotenuse,3) + units + " long.");
            // v2: string interpolation
            Console.WriteLine($"The length of the hypotenuse is {hypotenuse:N3}{units} long.");
        }
    }
}
