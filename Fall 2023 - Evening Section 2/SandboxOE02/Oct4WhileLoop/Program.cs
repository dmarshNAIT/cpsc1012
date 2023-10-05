namespace Oct4WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables:
            int numSeconds;

            // prompt the user for the # of seconds:
            Console.Write("Welcome to my Countdown App.\n" +
                "How many seconds until midnight? ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            numSeconds = int.Parse(Console.ReadLine());
            Console.ResetColor();

            // loop until we get to zero:
            while (numSeconds > 0) 
            {
                // print out the # of seconds
                Console.WriteLine(numSeconds);

                // silly bonus content:
                Thread.Sleep(1000);

                // decrease by 1
                numSeconds--; // numSeconds = numSeconds - 1
            }

            // wish them happy new year!
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Happy New Year!!");
            Console.ResetColor();

        }
    }
}