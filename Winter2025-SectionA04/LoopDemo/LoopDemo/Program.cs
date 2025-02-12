namespace LoopDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chillGuyNumber = 1;

            while(chillGuyNumber <= 10)
            {
                Console.WriteLine($"Chill guy #{chillGuyNumber}.");
                ++chillGuyNumber;
            }
            // since we know this runs exactly 10 times, this would be better set up as a for loop
            // however, for a quick introduction to loops, we'll keep it in

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Chill guy gets paid.");
            }

        }
    }
}
