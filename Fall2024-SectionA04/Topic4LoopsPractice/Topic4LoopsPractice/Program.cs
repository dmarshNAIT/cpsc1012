/* Program Name:    Average Mark Calculator
 * Author Name:     Dana Marsh & section A04
 * Modified:        September 10, 2024
 * 
 * Purpose:         Calculates the average mark for a course.
 * 
 * Input:           Course name, # of marks, value of individual marks
 * Output:          Average mark for the course
 */
namespace Topic4LoopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables needed for whole program:
            string userChoice;

            // welcome 
            Console.WriteLine("Welcome!");

            // start loop
            do
            {
                // declare variables needed in loop:
                int numberOfMarks = 0;  // starting value that will be overwritten later
                string className;
                double sum = 0;
                bool isValid = false;   // right now, I don't have valid input

                // prompt user for numberOfMarks & className
                Console.Write("\nEnter the course name: ");
                className = Console.ReadLine();
                Console.Write("How many marks will you enter: ");

                while (!isValid )
                {
                    try
                    {
                        numberOfMarks = int.Parse(Console.ReadLine());
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("INVALID INPUT!\nPlease try again: ");
                    }
                }

                // start loop
                for (int counter = numberOfMarks; counter > 0; counter--)
                {
                    double mark = 0;        // starting value to make VS happy
                    Console.Write("Please enter mark: ");
                    isValid = false;

                    while (!isValid)
                    {
                        try
                        {
                            mark = double.Parse(Console.ReadLine());
                            isValid = true;
                        }
                        catch (Exception)
                        {
                            Console.Write("INVALID INPUT!\nPlease try again: ");
                        }
                    }

                    sum += mark;
                }
                // end loop

                // calculate & display average
                Console.WriteLine($"Your average mark for {className} is {sum / numberOfMarks}.");

                // ask the user if they want to go again
                Console.Write("\nWould you like to do another calculation? \nEnter C to continue or any other key to exit: ");
                userChoice = Console.ReadLine().ToUpper();

            } while (userChoice == "C");
            // end loop

            Console.WriteLine("Thanks, bye!");

        }
    }
}
