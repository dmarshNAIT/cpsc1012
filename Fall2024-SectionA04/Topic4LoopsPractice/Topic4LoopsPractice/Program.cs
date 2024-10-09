/*
 *  TO DO: Dana write things here
 */
namespace Topic4LoopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int numberOfMarks;
            string className; // TO DO: scope
            double sum = 0;

            // welcome 
            Console.WriteLine("Welcome!");

            // prompt user for numberOfMarks & className
            Console.Write("Enter the course name: ");
            className = Console.ReadLine();
            Console.Write("How many marks will you enter: ");
            numberOfMarks = int.Parse(Console.ReadLine());

            // start loop
            for (int counter = numberOfMarks; counter > 0; counter--)
            {
                double mark;
                Console.Write("Please enter mark: ");
                mark = double.Parse(Console.ReadLine());
                sum += mark;
            }
            // prompt the user for each mark
            // end loop

            // calculate average
            // display average
            Console.WriteLine($"Your average mark for {className} is {sum/numberOfMarks}.");

            // ask the user if they want to go again

        }
    }
}
