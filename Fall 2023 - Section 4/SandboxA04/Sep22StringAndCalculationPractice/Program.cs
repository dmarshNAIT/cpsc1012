/* purpose: calculate the length of a hypotenuse
 * input:   2 numbers representing the lengths of the sides of the triangle
 * process: use the Pythagorean Theorem to calculate
 * output:  the length of the hypotenuse
 * author:  Dana Marsh & A04
 * date:    Sep 22, 2023
 */

namespace Sep22StringAndCalculationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // strings!
            string fish = "Mario2";
            Console.WriteLine(fish);
            Console.WriteLine(fish.ToLower());
            Console.WriteLine(fish.ToUpper());

            /********** program to calculate hypotenuse *********/

            // define the variables
            double sideA,   // length of side A
                sideB,      // length of side B
                aSquared,   // square of side A
                bSquared,   // square of Side B
                sum,        // aSquared + bSquared
                hypotenuse;
            string input;   // capture input from the Console

            // welcome the user
            Console.WriteLine("Welcome to our awesome triangle calculator.");

            // prompt the user for value a
            Console.Write("Enter the 1st side: ");
            input = Console.ReadLine();
            sideA = double.Parse(input);

            // prompt the user for value b
            Console.Write("Enter the 2nd side: ");
            input = Console.ReadLine();
            sideB = Convert.ToDouble(input);

            // calculate and give back the result
            aSquared = sideA * sideA;
            bSquared = sideB * sideB;
            sum = aSquared + bSquared;
            hypotenuse = Math.Sqrt(sum);
            Console.WriteLine($"The long side of the triangle is {hypotenuse}");
        }
    }
}