namespace Oct4Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSeconds;

            Console.Write("Welcome to the NYE Countdown!\n" +
                "How many seconds until midnight? ");
            numSeconds = int.Parse(Console.ReadLine());

            while (numSeconds > 0)
            {
                Console.WriteLine(numSeconds);
                Thread.Sleep(1000); // bonus content, pause for 1s
                numSeconds--; // numSeconds - 1
            }

            Console.Beep(); // play an annoying sound (bonus)
            Console.WriteLine("Happy New Year!");
        }
    }
}