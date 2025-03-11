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
            // create our arrays & objects
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            double[] hours = new double[7];
            int logicalSize = 0;
            char userChoice = '\0'; // null character

            do
            {
                // show the menu
                DisplayMainMenu();

                // get the user's choice
                userChoice = Char.ToLower(GetUserChar("Please make your choice: "));

                // branch according to their choice
                switch (userChoice)
                {
                    case 'e':
                        // TODO: enter values
                        break;
                    case 'v':
                        // TODO: view values
                        break;
                    case 's':
                        // TODO: save to file
                        break;
                    case 'l':
                        // TODO: load from file
                        break;
                    case 'p':
                        // TODO: predict tonight's sleep
                        break;
                    case 'q':
                        // quit
                        break;
                    default:
                        // TODO: invalid input
                        break;
                }

            } while (userChoice != 'q');

            //Hold hours
            //Looping a switch (menu - based program)
            // Enter values (includes exception handling)
            // View values
            // Save values to a file
            // Read values from a file
            // Predict tonight's sleep
            //Formatting & colouring of text

            #region

            //// quick test:
            //logicalSize = EnterValues(hours);
            //// arrays are a reference type: that means when we provide them to a method, that method can CHANGE the contents and we see the changes here.
            //ViewContent(days, hours, logicalSize);
            //// declare variables:
            //double sleepHoursThisWeek;
            //string name,
            //    didYouSleep;

            //Console.WriteLine("Hello! Welcome to the Sleep Tracker!");

            //// call the DisplayMainMenu():
            //DisplayMainMenu();

            //// call GiveMeNumber, which RETURNs an int value
            //sleepHoursThisWeek = GiveMeNumber();
            //Console.WriteLine($"I slept {sleepHoursThisWeek} hours this week!");

            //// call our GetUserString method a few different times, with different questions
            //name = GetUserString("What is your name?");
            //didYouSleep = GetUserString("Did you sleep last night?");
            //// each time we call GetUserString, it RETURNs a string
            //// we are saving that returned value into a variable e.g. didYouSleep

            //sleepHoursThisWeek = GetUserDouble("How many hours did you sleep? ");
            //Console.WriteLine($"You slept {sleepHoursThisWeek} hours this week!");
            #endregion

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

        static void ViewContent(string[] days, double[] values, int logicalSize)
        {
            // loop through the arrays
            // starting at 0
            // using logicalSize to help us know when to stop
            // for each element, we will print out the values to the Console
            for (int index = 0; index < logicalSize; index++)
            {
                Console.WriteLine(days[index] + ": " + values[index] + " hours");
                // TODO: add in alignment
            }

            // TODO: add in some validation to make sure that we don't have bad data that crashes the program
            // we need to check that count is valid (not too big, not too small)
        }

        static int EnterValues(double[] values)
        {
            // TODO: ask the user how many numbers they want to enter 

            // loop through ALL elements of the hours array
            // for each element, ask the user to enter the # of hours
            // return the # of elements added to the array
            int i; // initialize outside of loop as we will need to access it after the loop ends
            for (i = 0; i < values.Length; i++)
            {
                values[i] = GetUserDouble("How many hours of sleep did you get? ");
            }

            return i;
            // TODO later: add day names
        }

        static int GiveMeNumber()
        {
            return 78;
        }

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

        static double GetUserDouble(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a double
                try
                {
                    return double.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid number. Try again.");
                }
            } // end of loop
        } // end of method

        static char GetUserChar(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a char
                try
                {
                    return char.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid character. Try again.");
                }
            } // end of loop
        } // end of method


    } // end of my class
} // end of my namespace

// FRIDAY PRIORITY LIST: array things!
// for loop
// value vs reference