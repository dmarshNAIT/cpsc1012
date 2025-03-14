﻿/*
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

                // get the user's choice & force it to be lowercase:
                userChoice = Char.ToLower(GetUserChar("Please make your choice: "));

                // branch according to their choice
                switch (userChoice)
                {
                    case 'e':
                        logicalSize = EnterValues(hours, days);
                        break;
                    case 'v':
                        ViewContent(days, hours, logicalSize);
                        break;
                    case 's':
                        // TODO: save to file
                        break;
                    case 'l':
                        // TODO: load from file
                        break;
                    case 'p':
                        int prediction = PredictHours(hours, logicalSize);
                        Console.WriteLine($"I predict you will get {prediction} hours of sleep tonight.");
                        break;
                    case 'q':
                        // quit
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, that was not a valid choice. Try again.");
                        Console.ResetColor();
                        break;
                }

            } while (userChoice != 'q');

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
            // let's validate our inputs:
            if (logicalSize == 0)
            {
                Console.WriteLine("There is no data to display.");
            }
            /*****************DEFENSIVE CODING******************/
            else if (logicalSize < 0 || logicalSize > days.Length || logicalSize > values.Length)
            {
                Console.WriteLine("There is something wrong with the data.");
            }
            else
            {
                // loop through the arrays
                // starting at 0
                // using logicalSize to help us know when to stop
                // for each element, we will print out the values to the Console
                for (int index = 0; index < logicalSize; index++)
                {
                    string currentDay = days[index];
                    Console.WriteLine(currentDay.PadLeft(9) + ": " + values[index] + " hours");
                }
            }
        }

        static int EnterValues(double[] values, string[] dayNames)
        {
            // empty out any "old" data, first:
            Array.Clear(values);

            // ask the user how many numbers they want to enter 
            int numberOfValues = GetUserInt("How many days of values would you like to input? ");
            // if they give us a # that is too big OR too small, ask again
            while (numberOfValues < 0 || numberOfValues > values.Length)
            {
                numberOfValues = GetUserInt("Sorry, you must enter a number between 0 and 7: ");
            }

            // loop through the elements of the hours array
            // for each element, ask the user to enter the # of hours
            int i; // initialize outside of loop as we will need to access it after the loop ends
            for (i = 0; i < numberOfValues; i++)
            {
                string currentDayOfWeek = dayNames[i];
                values[i] = GetUserDouble($"How many hours of sleep did you get on {currentDayOfWeek}? ");
            }

            // return the # of elements added to the array
            return i;
        }

        static int PredictHours(double[] values, int logicalSize)
        {
            int prediction = 0;
            // to create a random number: first, create a Random object. 
            Random numberGenerator = new Random(); // this is our random number generator
            // then we will use the Next() method to generate a random int

            if (logicalSize == 0) // predict a random number between 4 & 10   
            {
                const int SMALLEST_NUMBER = 4;
                const int LARGEST_NUMBER = 10;
                // use the object to generate a new int:
                prediction = numberGenerator.Next(SMALLEST_NUMBER, LARGEST_NUMBER + 1); // an int that is AT LEAST 4 and LESS THAN 11
            }
            else
            {
                // get the smallest value from values
                int smallestNumber = (int)values.Min() - 2;
                // get the largest value from values
                int largestNumber = (int)values.Max() + 2;
                // use those to predict a new random number:
                prediction = numberGenerator.Next(smallestNumber, largestNumber + 1);
            }
            return prediction;
        }

        static int GiveMeNumber()
        {
            return 78;
        }

        static int GiveMeNumber(int input) //overloaded method
        {
            return input;
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

        static int GetUserInt(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a int
                try
                {
                    return int.Parse(Console.ReadLine());
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