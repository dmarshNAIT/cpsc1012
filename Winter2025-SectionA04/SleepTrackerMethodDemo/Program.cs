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
        /// <summary>
        /// Loops through the main menu and branches according to user's selection.
        /// </summary>
        /// <param name="args">Unused command-line arguments.</param>
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
                        SaveToFile(days, hours, logicalSize);
                        break;
                    case 'l':
                        logicalSize = LoadFromFile(days, hours);
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

            #region old stuff

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
            #endregion old stuff

            Console.WriteLine("Thanks, goodbye!");

        }

        /// <summary>
        /// Prints Main Manu options to the Console.
        /// </summary>
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

        /// <summary>
        /// Loops through the contents of provided arrays and prints their contents to the Console.
        /// </summary>
        /// <param name="days">An array containing the names of the days of the week.</param>
        /// <param name="values">Numeric values corresponding to each day of the week.</param>
        /// <param name="logicalSize">The # of elements in each array.</param>
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

        /// <summary>
        /// Allows the user to enter new values into a provided array.
        /// </summary>
        /// <param name="values">Numeric values corresponding to each day of the week.</param>
        /// <param name="dayNames">An array containing the names of the days of the week.</param>
        /// <returns>The # of elements added.</returns>
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

        /// <summary>
        /// Saves the contents of the parallel arrays into a CSV file.
        /// </summary>
        /// <param name="dayNames">an array of string values representing the names of the days of the week</param>
        /// <param name="values">an array of double values that represents hours per day</param>
        /// <param name="logicalSize">the # of elements in the array</param>
        static void SaveToFile(string[] dayNames, double[] values, int logicalSize)
        {
            string filename = GetUserString("Please enter a file name: ");
            // KNOWN GAP: the user could enter nonsense. We'll ignore this possibility for now.

            try
            {
                // create a stream to the file
                StreamWriter writer = new StreamWriter("../../../" + filename);
                // as written, if we use the name of an existing file, we will replace that file's contents.

                // save the header line:
                writer.WriteLine("DAY,HOURS");

                // go through the array, day by day, and add the info to the file
                for (int i = 0; i < logicalSize; i++)
                {
                    // print the name of the day of the week, the hours for that day
                    writer.WriteLine($"{dayNames[i]},{values[i]:0.0}");
                }

                // close the stream
                writer.Close();
                // if we don't, it's possible that other processes won't be able to access this file.

                Console.WriteLine("Successfully saved file.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong while saving to the file.");
            }

            /* file format: 

                DAY,HOURS 
                SUNDAY,7.0
                MONDAY,8.5
                TUESDAY,7.2
             */


        }

        /// <summary>
        /// Loads day names & values from a file into 2 parallel arrays.
        /// </summary>
        /// <param name="dayNames">an array of string values representing the names of the days of the week</param>
        /// <param name="values">an array of double values that represents hours per day</param>
        /// <returns>the # of elements added to the arrays</returns>
        static int LoadFromFile(string[] dayNames, double[] values)
        {
            int i = 0;
            // get the filename from the user
            string filename = GetUserString("Please enter a file name: ");
            // KNOWN GAP: the user could enter nonsense. We'll ignore this possibility for now.

            try
            {
                // create a stream Reader
                StreamReader reader = new StreamReader("../../../" + filename);
                reader.ReadLine(); // reading in the header

                while (reader.EndOfStream == false) // keep looping until the end of the file
                {
                    // read the file line by line
                    string line = reader.ReadLine();

                    // split up the parts
                    string[] parts = line.Split(','); // break up that line, using the comma to separate the values
                    string dayName = parts[0]; // the day name was the first "part" of the string we read
                    double hours = double.Parse(parts[1]); // the hours were the next "part" of the string we read

                    // save the day into the day array
                    dayNames[i] = dayName;

                    // save the hours value into the values array 
                    values[i] = hours;

                    i++; // increase the # of elements loaded
                }

                // close the stream
                reader.Close();

                Console.WriteLine($"Successfully loaded {i} records.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong loading this file.");
            }

            return i; // the # of elements
        }


        /// <summary>
        /// Using provided values, predicts the user's next night of sleep.
        /// </summary>
        /// <param name="values">Numeric values corresponding to each day of the week.</param>
        /// <param name="logicalSize">The # of elements in the array.</param>
        /// <returns>An integer representing the # of hours of sleep.</returns>
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

        /// <summary>
        /// A silly method that returns someone's favourite number.
        /// </summary>
        /// <returns>The number 78. Always. No matter what.</returns>
        static int GiveMeNumber()
        {
            return 78;
        }

        /// <summary>
        /// A silly method which echoes the user's input back to them.
        /// </summary>
        /// <param name="input">A user-provided value.</param>
        /// <returns>The same user-provided value.</returns>
        static int GiveMeNumber(int input) //overloaded method
        {
            return input;
        }

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted string.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>The user-inputted text.</returns>
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

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted double.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered double.</returns>
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

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted int.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered int.</returns>
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

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted char.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered char.</returns>
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
