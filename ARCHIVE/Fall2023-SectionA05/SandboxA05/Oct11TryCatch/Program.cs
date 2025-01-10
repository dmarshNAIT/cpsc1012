namespace Oct11TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int birthday;
            bool isValidInput = false;

            do
            {
                // ask user what day of the month their birthday is
                Console.Write("What day of the month is your bday: ");

                try
                {
                    birthday = int.Parse(Console.ReadLine());
                    if (birthday > 0 && birthday <= 31)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid #.");
                    }
                }
                catch
                {
                    // if it's not valid, say "invalid"
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a #.");
                } // end of catch
                Console.ResetColor();

            } while (!isValidInput);

            // if it's valid, say "cool" in a fun colour
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cool!");

            Console.ResetColor();
            Console.WriteLine("We made it to the end!");

        } // end of Main() method
    }
}