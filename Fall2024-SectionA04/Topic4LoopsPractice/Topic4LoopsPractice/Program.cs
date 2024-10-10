/*
 *  TO DO: Dana write things here
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
                int numberOfMarks;
                string className; 
                double sum = 0;

                // prompt user for numberOfMarks & className
                Console.Write("\nEnter the course name: ");
                className = Console.ReadLine();
                Console.Write("How many marks will you enter: ");

                // TO DO: add input validation
                numberOfMarks = int.Parse(Console.ReadLine());

                // start loop
                for (int counter = numberOfMarks; counter > 0; counter--)
                {
                    double mark;
                    Console.Write("Please enter mark: ");

                    // TO DO: add input validation
                    mark = double.Parse(Console.ReadLine());

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
