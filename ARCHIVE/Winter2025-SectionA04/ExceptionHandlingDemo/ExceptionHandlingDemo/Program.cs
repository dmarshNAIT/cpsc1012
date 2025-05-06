namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int topNumber = 5,
                bottomNumber = 0;

            // version 1: avoid the problem
            if (bottomNumber == 0)
            {
                Console.WriteLine("Sorry, you can't.");
            }
            else
            {
                Console.WriteLine(topNumber / bottomNumber);
            }

            // version 2:
            try
            {
                // we put the potentially problematic code here
                // if anything throws an Exception, we stop running the try block, and immediately start running the catch block
                Console.WriteLine(topNumber / bottomNumber);
            }
            catch
            {
                // this only runs if there was an Exception
                Console.WriteLine("Sorry, not allowed.");
            }

            /*****************************************************/

            // we create the variables we need outside the loop:
            bool isValidNumber = false; 
            // alternatively you may find the logic easier if you have isInvalid as your bool 
            // that basically just flips all the trues to false and vice versa

            do
            {
                // we create the variables we only need INSIDE the loop:
                int numberOfCups;
                Console.Write("Please enter the # of cups of coffee you had today: ");
                try
                {
                    numberOfCups = int.Parse(Console.ReadLine());
                    isValidNumber = true;
                    Console.WriteLine("You have had " + numberOfCups + " cups of coffee today.");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red; //  bonus content!
                    Console.WriteLine("Sorry, that was invalid input. Please try again.");
                    Console.ResetColor();
                }
            } while (!isValidNumber);
            // our condition could also be written as:  isValidNumber == false
            // in English, line 57 is saying:
            // keep looping as long as the condition in the () is true (i.e. isValidNumber is false)
            // stop looping when the condition in the () becomes false (i.e. isValidNumber is true)

            Console.WriteLine("Thanks, bye!");
        }
    }
}
