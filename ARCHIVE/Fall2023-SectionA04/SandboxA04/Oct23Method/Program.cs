namespace Oct23Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysTillHalloween;
            double value;

            Console.WriteLine("Hello.");

            DoNothing();

            daysTillHalloween = GetHalloweenCountdown();
            Console.WriteLine($"There are {daysTillHalloween} days till Hallowe'en.");
            // this is the same as:
            Console.WriteLine($"There are {GetHalloweenCountdown()} days till Hallowe'en.");

            value = 8;
            Console.WriteLine($"The cube of {value} is {GetThatCube(value)}.");

            Console.WriteLine("Goodbye.");
        }

        static void DoNothing()
        {
            Console.WriteLine("Nothing to see here.");
        }

        static int GetHalloweenCountdown()
        {
            return 7; // TO DO: Dana to un-hardcode this
        }

        static double GetThatCube(double num)
        {
            return num * num * num;
        }

    }
}
