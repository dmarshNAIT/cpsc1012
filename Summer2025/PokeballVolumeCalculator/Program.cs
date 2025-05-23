/*
 * Purpose:     Calculate the volume of a spherical Pokeball, 
 *              given user-inputted dimensions.
 * Author:      Dana Marsh [dmarshNAIT]
 * Date:        May 22, 2025
 * 
 * Input:       Diameter of the Pokeball in centimeters
 * Output:      Volume of the Pokeball in cubic inches
 */
namespace PokeballVolumeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables (i.e. create variables)
            // input diameter cm (double)
            // radius in inches (double)
            // output volume (double)

            // prompt the user for the diameter
            // save it to the diameter variable

            // convert diameter to a radius
            // divide diameter by 2 --> radius
            // turn cm into inches --> divide by 2.54

            // calculate volume:
            // 4 / 3 * PI * radius to the power of 3

            // display results
            // make sure they look nice

            /**********************************/
            // declare variables
            const double CONVERSION_FACTOR = 2.54;
            double diameterCm,
                    radiusInches,
                    radiusCubed,
                    volume;

            Console.Write("Welcome!\n" +
                "Please enter the diameter of your Pokeball in centimeters: ");
            diameterCm = double.Parse(Console.ReadLine());

            // convert diameter to a radius
            radiusInches = diameterCm / 2 / CONVERSION_FACTOR;

            // calculate volume:
            // 4 / 3 * PI * radius to the power of 3
            volume = 4.0 / 3 * Math.PI * Math.Pow(radiusInches, 3);

            // or, we could split up the calculation:
            radiusCubed = Math.Pow(radiusInches, 3);
            volume = 4.0 / 3 * Math.PI * radiusCubed;

            // display results
            Console.WriteLine($"The volume is approximately {Math.Round(volume, 3)} cubic inches.");
            // make sure they look nice

            // or we can take advantage of built-in number formatting:
            Console.WriteLine($"The volume is approximately {volume:N3} cubic inches.");

        }
    }
}
