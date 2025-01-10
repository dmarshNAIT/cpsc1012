namespace Oct4FormattingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 578;
            double myDouble = 6154.897;

            // just the "raw" numbers, no formatting:
            Console.WriteLine($"int: {myInt} double: {myDouble}");

            // adjust the number of digits before the decimal
            Console.WriteLine($"int: {myInt:00000} double: {myDouble:00000}");

            // adjust the number of digits after the decimal
            Console.WriteLine($"int: {myInt:00000.00} double: {myDouble:00000.00}");

            // add "optional" placeholders
            Console.WriteLine($"int: {myInt:##,###.##} double: {myDouble:##,###.##}");
            Console.WriteLine($"int: {myInt:#,#.##} double: {myDouble:#,#.##}");

            // now let's add in columns
            Console.WriteLine($"GST:   {myInt, 12:#,#.##} Total: {myDouble, 12:#,#.##}\n" +
                $"Total: {myDouble, 12:#,#.##} GST:   {myInt, 12:#,#.##}");
            // and if we want to align on the left side instead, make that width negative:
            Console.WriteLine($"GST:   {myInt,-12:#,#.##} Total: {myDouble,-7:#,#.##}\n" +
                $"Total: {myDouble,-12:#,#.##} GST:   {myInt,-7:#,#.##}");

            // just for fun
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("hi this is a beautiful colour combo");
            Console.ResetColor();
        }
    }
}