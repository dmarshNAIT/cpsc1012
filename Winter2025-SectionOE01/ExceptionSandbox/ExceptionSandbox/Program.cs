namespace ExceptionSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int topNumber = 5,
            // bottomNumber = 0;

            // option 1: avoid the problem

            //if (bottomNumber == 0)
            //{
            //    Console.WriteLine("Sorry, that's not allowed.");
            //}
            //else
            //{
            //    Console.WriteLine(topNumber / bottomNumber);
            //}

            // option 2: catch the exception

            //try
            //{
            //    // the code in the try is the stuff we want to TRY to run
            //    // but it's code that MIGHT throw an exception
            //    // if anything in this block throws an exception,
            //    // we immediately stop running the try block, and run the catch block instead
            //    Console.WriteLine(topNumber / bottomNumber);
            //}
            //catch
            //{
            //    // this only runs IF something went wrong in the try
            //    Console.WriteLine("Sorry, not allowed.");
            //}

            int numberOfEntries;
            bool validInput = false; // this must be created outside of the loop, because we want to access it outside of the loop.

            do
            {
                Console.Write("How many values will you be entering? ");

                try
                {
                    numberOfEntries = int.Parse(Console.ReadLine());
                    validInput = true;
                    Console.WriteLine("Thanks! You will be entering " + numberOfEntries + " values.");
                }
                catch
                {
                    Console.WriteLine("Sorry, that's not valid.");
                }
            } while (!validInput);

            Console.WriteLine("Thanks, goodbye!");
        }
    }
}
