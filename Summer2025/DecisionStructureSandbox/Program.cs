/*
 * Purpose:  To demonstrate some silly examples of if, switch, and conditional operators.
 * Author:   Dana Marsh
 * Modified: June 3, 2025
 */
namespace DecisionStructureSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if statements are an example of CONDITIONAL EXECUTION
            int radius = 10;

            if (radius > 0)
            {
                Console.WriteLine("You have a circle with a valid radius.");
            }
            // if the condition is true, print a message. otherwise, do nothing.

            if (radius > 0)
            {
                Console.WriteLine("You have a circle with a valid radius.");
            }
            else // the condition is FALSE
            {
                Console.WriteLine("That is not a valid radius.");
            }

            // we can also nest if statements within one another

            // first, am I tired?
            // if so, I should go to bed
            // if not, I'm gonna pick an activity.
            // if movie length < time left in my day, watch a movie
            // otherwise, I'm going to play a video game
            bool isTired = false;
            int movieLength = 120, // length in minutes
                timeRemaining = 60; // time in minutes

            if (isTired)
            // alternatively if (isTired == true)
            // alternatively if (isTired != false)
            {
                Console.WriteLine("Go to bed.");
            }
            else
            {
                // see if I have time for a movie
                if (timeRemaining >= movieLength)
                {
                    Console.WriteLine("Yay, movie time!");
                }
                else
                {
                    Console.WriteLine("Yay, game time!");
                }
            }
        }
    }
}
