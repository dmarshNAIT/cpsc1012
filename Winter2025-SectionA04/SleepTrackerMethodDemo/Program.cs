using System.Buffers.Text;

namespace SleepTrackerMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Hold dates
            //Hold hours
            //Looping a switch (menu - based program)
            // Enter values (includes exception handling)
            // View values
            // Save values to a file
            // Read values from a file
            // Predict tonight's sleep
            //Formatting & colouring of text

            // call the DisplayMainMenu():
            DisplayMainMenu();

        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("MENU OPTIONS:\n" +
                "[e]nter values\n" +
                "[v]iew values\n" +
                "[s]ave to file\n" +
                "[l]oad from file\n" +
                "[p]redict tonight's sleep\n" +
                "[q]uit\n");
        }

    }
}
