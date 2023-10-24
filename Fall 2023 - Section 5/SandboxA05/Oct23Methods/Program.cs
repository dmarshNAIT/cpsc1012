namespace Oct23Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            PrintMessage();
            PrintInPink("hey this is a message I wrote.");
            Console.WriteLine("Goodbye.");
        }

        static void PrintMessage()
        {
            Console.WriteLine("Inconceivable!");
        }

        static void PrintInPink(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}

/* practice:
 * xor
 * formatting output
 * Math
 */