namespace Oct23Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.");

            DoNothing();

            int daysTillHalloween = GetHalloweenCountdown();
            Console.WriteLine($"There are {daysTillHalloween} days till Hallowe'en.");

            Console.WriteLine($"There are {GetHalloweenCountdown} days till Hallowe'en.");

            Console.WriteLine();

            Console.WriteLine("Goodbye.");
        }

        static void DoNothing()
        {
            Console.WriteLine("Nothing to see here.");
        }

        static int GetHalloweenCountdown()
        {
            return 8; // TO DO: Dana to un-hardcode this
        }

    }
}

/* what we'd like to practice:
 * loops
 * exceptions
 * Math class
 * arrays!!!
 */