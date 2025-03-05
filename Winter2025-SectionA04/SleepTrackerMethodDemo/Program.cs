/*
 * Purpose:  This program will allow a user to enter data into parallel arrays, access the values, edit the values, and read/write from/to a text file.
 * Author:   Dana Marsh
 * Modified: March 5, 2025
 */

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

            // declare variables:
            int sleepHoursThisWeek;
            string name,
                didYouSleep;

            Console.WriteLine("Hello! Welcome to the Sleep Tracker!");

            // call the DisplayMainMenu():
            DisplayMainMenu();

            // call GiveMeNumber, which RETURNs an int value
            sleepHoursThisWeek = GiveMeNumber();
            Console.WriteLine($"I slept {sleepHoursThisWeek} hours this week!");

            // call our GetUserString method a few different times, with different questions
            name = GetUserString("What is your name?");
            didYouSleep = GetUserString("Did you sleep last night?");

            Console.WriteLine("Thanks, goodbye!");

        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("MENU OPTIONS:\n" +
                "\t[e]nter values\n" +
                "\t[v]iew values\n" +
                "\t[s]ave to file\n" +
                "\t[l]oad from file\n" +
                "\t[p]redict tonight's sleep\n" +
                "\t[q]uit\n");
        }

        static int GiveMeNumber()
        {
            return 78;
        }

        // NEW CONTENT TO BE REVIEWED FRIDAY
        static string GetUserString(string question)
        {
            string userResponse;
            // ask the question
            Console.Write(question);
            // get the answer
            userResponse = Console.ReadLine();
            // return the answer
            return userResponse;
        }


    }
}
