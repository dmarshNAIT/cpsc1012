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
            int cookiesEaten;
            // we can assign a value immediately, or later on.
            // variables are named starting with a lowercase letter
            cookiesEaten = 3;

            double averageGoalsPerGame;

            // May 15 class example:
            // let's do a simple calculation

            // data going in:
            // how many games they won
            // how many games they lost

            // data coming out:
            // what percentage of the games they've won?

            // e.g. won 4, lost 1: they've won 80% of the games

            // SEQUENCE:
            // declare variables
            // ask the user to input games won
            // ask the user to input games lost
            // calculate total # of games
            // calculate their win rate
            // display results as a percent (not decimal)

            /************* CODING TIME ************/
            // declare & assign variables
            int gamesWon = 4,
                gamesLost = 1,
                totalGames;
            double winRate;

            // calculate total # of games
            totalGames = gamesLost + gamesWon;

            // calculate their win rate
            winRate = gamesWon / totalGames;
            // this line is doing integer division: 4/5 --> 0
            winRate = gamesWon * 1.0 / totalGames;
            // fix #1: incorporate a double into the equation
            winRate = (double)gamesWon / totalGames;
            // or fix #2: cast as a double

            // display results as a percent (not decimal)
            Console.WriteLine("The average win rate is " + winRate * 100 + "%");

            // let's play around with the cast operator

            // let's try casting an int to a double
            double myDouble = (double)33;
            Console.WriteLine("myDouble is " + myDouble);

            // let's try casting a double to an int
            int myInt = (int)21.7;
            Console.WriteLine("myInt is " + myInt);
            // ints cannot store decimals, so those values are lost

            // weird things can happen when we cast to a "smaller" data type: be careful!!!
            int bigNumber = 123456789;
            byte test = (byte)bigNumber;
            Console.WriteLine(test); // test is 21
        }
    }
}
