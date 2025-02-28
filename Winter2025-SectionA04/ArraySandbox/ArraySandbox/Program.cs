/* 
 * Purpose: To learn about and apply methods related to arrays.
 */
namespace ArraySandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 0;

            int[] ages = new int[22];
            // this creates a new array that can hold 22 int values

            double[] salaries = new double[22];

            // alternatively, we can create an array AND give it starting values:
            string[] candies = {"Kit Kat", "Reese's Peanut Butter Cups", "Aero"};

            Console.WriteLine();

            // physical size: the actual size of the array
            // AKA how many elements it CAN contain
            // AKA the length
            // AKA the # inside the [] e.g. 
            // int[] ages = new int[22];
            // physical size = 22

            // logical size: 
            // how many of those compartments have actual values inside them
            // e.g. inputted the age of 3 people
            // logical size = 3



            // BONUS CONTENT: arrays in arrays in arrays
            int[] arrayA = new int[2];
            int[] arrayB = new int[2];
            int[] arrayC = new int[2];

            int[][] middleArray = { arrayA, arrayB, arrayC };

            int[][][] lastArray = { middleArray };

        }
    }
}
