namespace Sep15ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's play around with the Math class
            double result;

            // first, calculating powers
            result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;
            Console.WriteLine("Answer: " + result);

            result = Math.Pow(2, 30);
            Console.WriteLine("Answer: " + result);

            // calculating square roots
            result = Math.Sqrt(4);
            Console.WriteLine("Root: " + result);

            // BONUS CONTENT: Skip the next few lines if you're not interested in calculating other type of roots        
            result = Math.Pow(4, 1.0/2); // we use Math.Pow, where the first number is the number we want the root of, & the 2nd number is 1 / the root number. 
            Console.WriteLine("Root: " + result);
            result = Math.Pow(64, 1.0 / 3); // cube root of 64 = 4 because 4*4*4 = 64
            Console.WriteLine("Root: " + Math.Round(result, 5));

            // rounding
            result = Math.PI;
            Console.WriteLine("Pi: " + result);

            // let's round it to the nearest integer
            result = Math.Round(Math.PI);
            Console.WriteLine("Rounded: " + result);

            // let's round it to 2 decimal places
            result = Math.Round(Math.PI, 2);
            Console.WriteLine("Rounded to 2 digits: " + result);


            // creating a constant
            const double GST_RATE = 0.05;




            /******************************* let's write the pseudocode for our temp conversion app *******************************/

            // print a welcome message

            // ask the user to input a temp in F
            double tempF = 32; // hardcoded for v1; please replace with a user prompt



            Console.WriteLine("Temp in F: " + tempF);


            // read the value from the console & save into a variable

            // calculate the temp in C
            double tempC = (tempF - 32) * 5 / 9;

            // display the result
            Console.WriteLine("Temp in Celsius: " + tempC);


        }
    }
}