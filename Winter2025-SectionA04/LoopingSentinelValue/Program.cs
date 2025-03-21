/*
 * Demo of using sentinel-controlled loops.
 * 
 * Mar 21, 2025
 */ 
namespace LoopingSentinelValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an array:
            int[] calories = new int[7];
            int logicalSize = 0;
            bool userWantsToContinue = true;

            // loop through the array and add values:
            // start at index 0
            // go until the end of the array OR until the user asks to quit
            // ask the user to enter a value
            // if they enter a "real" value: save it and update logicalSize
            // if they enter a "bad" value: complain
            // if they enter our sentinel value: we want to exit the loop
            for (logicalSize = 0 ; logicalSize < calories.Length && userWantsToContinue; )
            {
                int enteredValue = GetUserInt("Please enter the # of calories consumed or enter -9 to exit: ");
                // validate input before going any further:
                while (enteredValue < 0 && enteredValue != -9)
                {
                    // bad input!!
                    Console.WriteLine("Please enter a valid value.");
                    enteredValue = GetUserInt("Please enter the # of calories consumed or enter -9 to exit: ");
                }

                // by this point, we know we have a valid number, so we can branch accordingly
                if (enteredValue == -9)
                {
                    userWantsToContinue = false;
                }
                else
                {
                    calories[logicalSize] = enteredValue; // add the value into the current element of the array
                    logicalSize++;
                }
            }
         

            Console.WriteLine("Bye!");

        }

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
    }
}
