namespace DrawingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DrawBox();

            //Console.WriteLine("now version 2:");

            //// we will hardcode this for v1; a more realistic implementation would prompt the user to provide these
            //DrawBox(10, 5);

            //Console.WriteLine("and now a tiny box:");

            //DrawBox(4, 3);

            //DrawBox(2, 1);

            DrawCalendar();

        }

        /// <summary>
        /// Draws a box that is 10 characters wide & 5 characters tall.
        /// </summary>
        static void DrawBox()
        {
            // draw a box made of *
            // it will be 10 char wide & 5 char tall
            String horizontalLine = new String('*', 10);

            // draw a line of 10 *s
            Console.WriteLine(horizontalLine);

            // in a loop, 3x:
            for (int row = 0; row < 3; row++)
            {
                // draw a star, then a bunch of spaces, then a star.
                for (int column = 0; column < 10; column++)
                {
                    if (column == 0 || column == 9)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }

            // draw a line of 10 *s
            Console.WriteLine(horizontalLine);

        }

        /// <summary>
        /// Draws a box of user-specified dimensions.
        /// </summary>
        /// <param name="width">The # of characters wide</param>
        /// <param name="height">The # of characters tall</param>
        static void DrawBox(int width, int height)
        {
            if (width < 2 || height < 2)
            {
                Console.WriteLine("Sorry, that's too tiny.");
            }
            else
            {
                string horizontalLine = new String('*', width);

                // draw the first line:
                Console.WriteLine(horizontalLine);

                // draw the middle lines:
                for (int row = 0; row < height - 2; row++)
                {
                    // draw a star, then a bunch of spaces, then a star.
                    for (int column = 0; column < width; column++)
                    {
                        if (column == 0 || column == (width - 1))
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                    Console.WriteLine();
                }

                // draw the last line:
                Console.WriteLine(horizontalLine);
            }
        }

        static void DrawCalendar()
        {
            string[] dayNames = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int numberOfWeeks = 6; // TODO: calculate this
            int firstWeekDayOfMonth = 6;// TODO: calculate this

            int blankCells = 0;     // we are keeping track of how many "empty" cells we've created
            int currentDayOfMonth = 1;     // we are keeping track of the current date we are printing

            // first we write out the names of the days of the week
            for (int i = 0; i < dayNames.Length; i++)
            {
                Console.Write(' ' + dayNames[i] + ' ');
            }

            Console.WriteLine();

            // then, let's loop through the month, week by week
            for (int weekNumber = 0; weekNumber < numberOfWeeks; weekNumber++)
            {
                // day by day, print out the days of the month
                for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
                {
                    // if the month hasn't started yet
                    // print a space
                    if (blankCells < firstWeekDayOfMonth)
                    {
                        Console.Write("     ");
                        blankCells++;
                    }

                    // otherwise
                    // print the day of the month
                    else if (currentDayOfMonth <= 31) // TODO: un-hardcode
                    {
                        Console.Write($"{currentDayOfMonth}  ".PadLeft(5));
                        currentDayOfMonth++;
                    }
                }
                Console.WriteLine();

            }

        }

    }

}





