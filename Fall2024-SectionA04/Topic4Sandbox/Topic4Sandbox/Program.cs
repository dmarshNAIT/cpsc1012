/* This is us playing around with formatting & loops.
 */
namespace Topic4Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int banana = 69;
            double catnip = 369.5;
            double noone = 1234567.890123;

            // v1: just print the raw values
            Console.WriteLine("v1: raw values");
            Console.WriteLine($"1st num: {banana}");
            Console.WriteLine($"2nd num: {catnip}");
            Console.WriteLine($"3rd num: {noone}");

            // v2: let's use a format string
            Console.WriteLine("v2: 4 digits");
            Console.WriteLine($"1st num: {banana:0000}");
            Console.WriteLine($"2nd num: {catnip:0000}");
            Console.WriteLine($"3rd num: {noone:0000}");

            // v3: 4 digits before & 2 after the decimal
            Console.WriteLine("v3: + 2 digits after");
            Console.WriteLine($"1st num: {banana:0000.00}");
            Console.WriteLine($"2nd num: {catnip:0000.00}");
            Console.WriteLine($"3rd num: {noone:0000.00}");

            // v4: now with commas
            Console.WriteLine("v4: commas");
            Console.WriteLine($"1st num: {banana:0,000.00}");
            Console.WriteLine($"2nd num: {catnip:0,000.00}");
            Console.WriteLine($"3rd num: {noone:0,000.00}");

            // v5: using optional digit
            Console.WriteLine("v5: optional digits");
            Console.WriteLine($"1st num: {banana:#,##0.00}");
            Console.WriteLine($"2nd num: {catnip:#,##0.00}");
            Console.WriteLine($"3rd num: {noone:#,##0.00}");

            // v6: using pre-made format strings
            Console.WriteLine("v6: currency");
            Console.WriteLine($"1st num: {banana:c}");
            Console.WriteLine($"2nd num: {catnip:c}");
            Console.WriteLine($"3rd num: {noone:c}");

            // v7: now with a fixed-width column
            Console.WriteLine("v7: columns");
            Console.WriteLine($"1st num: {banana,20:c}");
            Console.WriteLine($"2nd num: {catnip,20:c}");
            Console.WriteLine($"3rd num: {noone,20:c}");

            // bonus content:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Magenta!");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("With background!");
            Console.ResetColor();

            // now time for loops:
            int timer = 100;
            while (timer >= 0)
            {
                Console.WriteLine(timer);
                timer--;
            }
            // this is a silly example

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }






            /* silliness
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 900);
            Console.Beep(783, 300);
            Console.Beep(880, 300);
            Console.Beep(783, 1200);
            Console.Beep(523, 150);
            Console.Beep(587, 150);
            Console.Beep(698, 150);
            Console.Beep(587, 150);
            Console.Beep(880, 450);
            Console.Beep(880, 450);
            Console.Beep(783, 1200);
            Console.Beep(523, 150);
            Console.Beep(587, 150);
            Console.Beep(698, 150);
            Console.Beep(587, 150);
            Console.Beep(783, 450);
            Console.Beep(783, 450);
            Console.Beep(698, 450);
            Console.Beep(659, 150);
            Console.Beep(587, 300);
            Console.Beep(523, 150);
            Console.Beep(587, 150);
            Console.Beep(698, 150);
            Console.Beep(587, 150);
            Console.Beep(698, 600);
            Console.Beep(783, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 125);
            Console.Beep(523, 600);
            Console.Beep(523, 300);
            Console.Beep(783, 600);
            Console.Beep(698, 1200);
            */
        }
    }
}
