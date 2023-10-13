namespace Oct13TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int numberPets = 0;
            bool isValidInput = false;

            do
            {
                Console.Write("How many pets do you have? ");

                try
                {
                    numberPets = int.Parse(Console.ReadLine());
                    if (numberPets >= 0) { isValidInput = true; }
                    else { Console.WriteLine("You need more pets."); }
                    Console.WriteLine("This is the end of the try block.");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are a disobedient human.");
                    Console.ResetColor();
                    Console.WriteLine("This is the end of the catch block.");
                }
            } while (!isValidInput);

            Console.WriteLine($"You have {numberPets} pets!\nThanks for playing.");
        }
    }
}