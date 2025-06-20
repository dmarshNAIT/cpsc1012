/**
 * Purpose: To demonstrate the creation and a few applications of arrays.
 */
namespace ArraySandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's imagine we want to capture the possible toppings of a burger
            string topping1 = "pineapple";
            string topping2 = "feta";

            // let's create an array containing all the possible toppings
            // we can create an array just by specifying the size:
            string[] toppings = new string[100];
            // we can create an array by specifying the size AND the starting values:
            string[] oldDays = new string[7] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            // or without the size:
            string[] oldDays2 = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

            // we can create an array by ONLY specifying the starting values
            string[] days = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT", "OFF" };

            // we can create arrays of any of the data types we've seen so far:
            int[] prices = new int[5];
            bool[] answers = new bool[10];

            // let's print out ONE value from an array
            // let's print out the element at index 7
            Console.WriteLine(days[7]);

            // let's print out ALL the elements
            Console.WriteLine(days[0]);
            Console.WriteLine(days[1]);
            Console.WriteLine(days[2]);
            Console.WriteLine(days[3]);
            Console.WriteLine(days[4]);
            Console.WriteLine(days[5]);
            Console.WriteLine(days[6]);
            Console.WriteLine(days[7]);

            //Console.WriteLine(days[8]); // this won't work, there is no index 8 


            // that's repetitive. let's use a loop instead!
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            // let's iterate over a PARTIALLY filled array
            toppings[0] = "pineapple";
            toppings[1] = "feta";
            int logicalSize = 2; // for C# arrays, this must be tracked manually.

            for (int i = 0; i < logicalSize; i++)
            {
                Console.WriteLine(toppings[i]);
            }


            //pineapple
            //feta
            //lettuce tomato onion
            // pickles
            // pepperoni
            //lettuce
            //banana peppers
            //egg


        }
    }
}
