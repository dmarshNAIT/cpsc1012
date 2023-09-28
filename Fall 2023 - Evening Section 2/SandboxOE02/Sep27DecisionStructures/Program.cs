namespace Sep27DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string userInput;
            int mark;
            char letterGrade;

            // prompt the user to enter their mark (as a whole #)
            Console.Write("Please enter your mark (as a whole #): ");
            userInput = Console.ReadLine();
            mark = int.Parse(userInput); // is a little faster
            mark = Convert.ToInt32(userInput); // is better at dealing with blank strings

            // if their mark is above 80, congrats!
            if (mark > 80)
            {
                Console.WriteLine("Congratulations!");
            }
            // if their mark is below 50:
            else if (mark < 50)
            {
                Console.WriteLine("Maybe you would like to schedule an office hour."); ;
            }
            // otherwise, tell them to keep up the good work.
            else
            {
                Console.WriteLine("Keep up the good work!");
            }


            // let's assign letter grades
            // if mark is at least 80: A
            if (mark >= 80)
            { letterGrade = 'A'; }
            // if mark is at least 70: B
            else if (mark >= 70)
            { letterGrade = 'B'; }
            // if mark is at least 60: C
            else if (mark >= 60)
            { letterGrade = 'C'; }
            // if mark is at least 50: D
            else if (mark >= 50)
            {letterGrade = 'D'; }
            // otherwise, F
            else { letterGrade = 'F'; }

            Console.WriteLine($"Your letter grade is {letterGrade}.");

            Console.WriteLine("Goodbye.");

        }
    }
}