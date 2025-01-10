using System.Reflection;

namespace Sep15ClassExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's play around with Math


            // calculate powers
            double result = 2 * 2 * 2 * 2;
            Console.WriteLine("The result is " + result);

            result = Math.Pow(2, 4); // this is the same as 2 * 2 * 2 * 2, or 2 to the power of 4
            Console.WriteLine("The result is " + result);


            // square roots
            double num = 25;
            result = Math.Sqrt(num);
            Console.WriteLine("The square root of {0} is {1}", num, result); // substitution parameters
            Console.WriteLine($"The square root of {num} is {result}"); // string interpolation


            // round
            Console.WriteLine("The value of Pi is " + Math.PI);
            Console.WriteLine("The rounded value of Pi is " + Math.Round(Math.PI));
            Console.WriteLine("The value of Pi rounded to 4 decimal places is " + Math.Round(Math.PI, 4));


            // let's create a constant
            const double GST_RATE = 0.05;



            // temp conversion application

            // welcome the user, display the prompt

            // declare variable to hold user input
            double tempF = 32; // hardcoded for now, please replace with prompt
            Console.WriteLine("The temp in F is " + tempF);


            // read input

            // convert to Celsius
            double tempC = (tempF - 32) * 5 / 9;
            Console.WriteLine("The temp in C is " + tempC);


        }
    }
}