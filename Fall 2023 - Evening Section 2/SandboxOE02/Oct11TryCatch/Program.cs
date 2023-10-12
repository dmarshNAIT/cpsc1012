namespace Oct11TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int userAge;
            bool isValidInput = false;

            do
            {
                // ask the user for their age
                Console.Write("Enter your age in years: ");

                try
                {
                    // read in their response and TRY to parse it
                    userAge = int.Parse(Console.ReadLine());
                    // check to see if it's a valid age
                    if (userAge >= 0 && userAge <= 150)
                    {
                        isValidInput = true;
                    }
                     else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, that's not a valid age for humans.");
                        Console.ResetColor();
                    }

                    Console.WriteLine("This is the end of the try block.");
                }
                catch
                {
                    // if the parse fails, return a nice error message
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, that's not a #.");
                    Console.ResetColor();
                } // end of catch block
            } while (!isValidInput);

            Console.WriteLine("Goodbye.");
        } // end of Main()
    }
}