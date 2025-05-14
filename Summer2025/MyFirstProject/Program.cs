namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a comment! it is for humans.
            // the next statement prints a message to the screen.

            /* this is also a comment
              I'm still in the comment
              the comment can go on
              and on
              and on
             */

            Console.WriteLine("it only gets easier from here!");
            Console.WriteLine("message 2");
            // Console.WriteLine prints a message then goes to the next line
            Console.Write("message 3");
            Console.Write("message 4");
            // Console.Write prints a message and stays on the same line
            // this is what we want to use for user input prompts

            Console.WriteLine("\nToday\n is\n \t\tTuesday\n.");
            // \n creates a new line
            // \t is "tab": this indents the output

            // create a variable to keep track of the number of games won
            int gamesWon;
            // we can assign a value immediately, or later on.
            // variables are named starting with a lowercase letter
            gamesWon = 3;

            double averageGoalsPerGame;
        }
    }
}
