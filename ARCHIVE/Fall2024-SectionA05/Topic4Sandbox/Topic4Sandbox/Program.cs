/* This is where we will play around with new concepts related to Topic 4.
 */
namespace Topic4Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int banana1 = 45;
            double banana2 = 45.26566;
            double banana3 = 1234567.789;

            // v1: just print the numbers directly
            Console.WriteLine("Raw numbers:");
            Console.WriteLine($"1st num: {banana1}");
            Console.WriteLine($"2nd num: {banana2}");

            // v2: let's have 3 mandatory digits
            Console.WriteLine("3 mandatory digits:");
            Console.WriteLine($"1st num: {banana1:000}");
            Console.WriteLine($"2nd num: {banana2:000}");

            // v3: let's have 3 digits before and 2 digits after the decimal
            Console.WriteLine("3 digits before & 2 after:");
            Console.WriteLine($"1st num: {banana1:000.00}");
            Console.WriteLine($"2nd num: {banana2:000.00}");

            // v4: what if we want commas?
            Console.WriteLine("Now with commas:");
            Console.WriteLine($"1st num: {banana1:#,##0.00}");
            Console.WriteLine($"2nd num: {banana2:#,##0.00}");
            Console.WriteLine($"3rd num: {banana3:#,##0.00}");

            // and using the built-in currency pattern
            Console.WriteLine("Now with commas:");
            Console.WriteLine($"1st num: {banana1:c}");
            Console.WriteLine($"2nd num: {banana2:c}");
            Console.WriteLine($"3rd num: {banana3:c}");

            // v6: now with alignment
            Console.WriteLine("now with fixed with column:");
            Console.WriteLine($"1st num: {banana1,20:c}");
            Console.WriteLine($"2nd num: {banana2,20:c}");
            Console.WriteLine($"3rd num: {banana3,20:c}");

            // v7: aligned to the left
            Console.WriteLine("now with fixed width column:");
            Console.WriteLine($"1st num: {banana1,-20:c}");
            Console.WriteLine($"2nd num: {banana2,-20:c}");
            Console.WriteLine($"3rd num: {banana3,-20:c}");

            // bonus:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("this is blue!");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This has a yellow background.");

            Console.ResetColor();

            // now onto loops!
            int counter = 100;

            while (counter >= 0)
            {
                Console.WriteLine(counter);
                counter--;
            } // kind of a weird loop but we gotta start somewhere

            // this would be better done as a for loop
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
