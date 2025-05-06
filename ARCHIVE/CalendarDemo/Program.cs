namespace CalendarDemo
{
    internal class Program
    {
        static void Main()
        {
            // our "database":
            string[] months = { null, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            // our variables:
            int year,
                monthNumber;

            PrintInColour("*** Welcome to the Calendar App! ***\n\n");

            // get year & month from user:
            year = GetYear();
            PrintMonths(months);
            monthNumber = GetMonthNumber();

            // print calendar:
            PrintTitle(year, months[monthNumber]);
            PrintDaysHeader();
            PrintDaysInMonth(year, monthNumber);

            Console.WriteLine("Thanks, bye!");
        }

        #region input methods
        /// <summary>
        /// Prompts the user to enter a year from the Console.
        /// </summary>
        /// <returns>A numeric representation of the year, between 2000AD & 3000AD</returns>
        static int GetYear()
        {
            while (true)
            {
                int year = GetUserInt("Which year would you like to generate a calendar for? ");

                if (year < 2000 || year > 3000) // arbitrarily chosen limits
                    PrintError("Sorry, our calendar only supports the current millennium.\n");
                else
                    return year;
            }
        }

        /// <summary>
        /// Prompts the user to enter a month # from the Console, where 1 = January.
        /// </summary>
        /// <returns>An int between 1 (January) & 12 (December) </returns>
        static int GetMonthNumber()
        {
            while (true)
            {
                int monthNumber = GetUserInt("Which month would you like to generate a calendar for? ");

                if (monthNumber < 1 || monthNumber > 12)
                {
                    PrintError("Please enter a valid month # betwen 1 & 12.\n");
                }
                else
                {
                    return monthNumber;
                }
            }

        }

        #endregion 

        #region Date methods
        /// <summary>
        /// Returns the integer representation of the which day of the week the month began.
        /// </summary>
        /// <param name="year">The year</param>
        /// <param name="month">The month</param>
        /// <returns>0 for Sunday - 6 for Saturday, representing the first day of the month</returns>
        static int GetFirstWeekDayOfMonth(int year, int month)
        {
            DateTime firstDay = new DateTime(year, month, 1);
            return (int)firstDay.DayOfWeek;
        }

        /// <summary>
        /// Returns the # of days in the month, accounting for leap years.
        /// </summary>
        /// <param name="year">Numeric representation of year</param>
        /// <param name="monthNumber">Numeric representation of month where 1 = January</param>
        /// <returns></returns>
        static int GetDaysInMonth(int year, int monthNumber)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int daysInMonth = daysPerMonth[monthNumber];

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (isLeapYear && monthNumber == 2) { daysInMonth++; }

            return daysInMonth;
        }

        #endregion

        #region Printing Output

        /// <summary>
        /// Prints one line for each month of the year, preceded by the human-readable month # (1 for January).
        /// </summary>
        /// <param name="months">An array containing the month names</param>
        static void PrintMonths(string[] months)
        {
            for (int i = 1; i < months.Length; i++)
            {
                Console.WriteLine($"\t{i}: {months[i]}");
            }

        }

        /// <summary>
        /// Prints the month & year, centered within 35 characters.
        /// </summary>
        /// <param name="year">Numeric value of year</param>
        /// <param name="monthName">String value of month</param>
        static void PrintTitle(int year, string monthName)
        {
            string message = monthName + " " + year;
            int padding = (35 - message.Length) / 2;

            PrintInColour("\n" + message.PadLeft(padding + message.Length) + "\n");
        }

        /// <summary>
        /// Prints the days of the week, each taking up 5 chars of space with space delimiters.
        /// </summary>
        static void PrintDaysHeader()
        {
            string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string message = "";

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                message += " " + daysOfWeek[i] + " ";
            }
            Console.WriteLine(message);
        }

        /// <summary>
        /// Prints a 35-char wide calendar of the days of the month.
        /// </summary>
        /// <param name="year">Numeric representation of year</param>
        /// <param name="monthIndex">Zero-indexed numeric representation of month.</param>
        static void PrintDaysInMonth(int year, int monthIndex)
        {
            // create some helper variables:
            int dateOfMonth = 1; // we will print out the "human" date
            int monthLength = GetDaysInMonth(year, monthIndex); // we need to know how many days are in the month
            int monthStartDay = GetFirstWeekDayOfMonth(year, monthIndex); // because the month probably doesn't start on Sunday
            int blankCells = 0; // we will keep track of the number of blank cells we've created

            // figure out number of weeks in the month
            double numberWeeks = (monthStartDay + monthLength) / 7.0;
            double roundedUpNumberWeeks = Math.Ceiling(numberWeeks);

            string message = "";

            // loop by row
            // starting from the first week, loop until the last week of the month:
            for (int weekNumber = 0; weekNumber < roundedUpNumberWeeks; weekNumber++)
            {
                // starting from Sunday, loop until Saturday:
                for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
                {
                    // if the month hasn't started yet, print nothing:
                    if (blankCells < monthStartDay)
                    {
                        message += "     ";
                        blankCells++;
                    }
                    // if the month hasn't ended, print the date:
                    else if (dateOfMonth <= monthLength)
                    {
                        message += $"{dateOfMonth++} ".PadLeft(5);
                    }
                }
                message += "\n";
            }

            Console.WriteLine(message);
        }

        #endregion

        #region Reusable methods

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    string response = Console.ReadLine();
                    Console.ResetColor();
                    return int.Parse(response);
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    PrintError("Please enter a whole number. Try again.\n");
                }
            } // end of loop
        } // end of method

        /// <summary>
        /// Calls Console.Write() but in red text.
        /// </summary>
        /// <param name="message">The message to display.</param>
        static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Prints in the specified colour.
        /// </summary>
        /// <param name="message">Message to Write</param>
        /// <param name="colour">ConsoleColor of choice</param>
        static void PrintInColour(string message, ConsoleColor colour = ConsoleColor.Magenta)
        {
            Console.ForegroundColor = colour;
            Console.Write(message);
            Console.ResetColor();
        }

        #endregion

    }
}
