namespace LogicalOperatorsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            Console.Write("Do you want to continue? Y/N: ");
            userChoice = char.Parse(Console.ReadLine());

            // the user types y OR the user types Y
            if (userChoice == 'y' || userChoice == 'Y')
            {
                Console.WriteLine("V1: The user wants to continue.");
            }

            // v2:
            // the user doesn't type N or n
            if (userChoice != 'n' && userChoice != 'N'){
                Console.WriteLine("V2: The user wants to continue.");
            }

            // v3:
            // it's not true that the user typed 'n' or 'N'
            if (!(userChoice == 'N' || userChoice == 'n')) {
                Console.WriteLine("V3: The user wants to continue.");
            }

            // v4:
            if (Char.ToUpper(userChoice) == 'Y')
            {
                Console.WriteLine("V4: The user wants to continue.");
            }
        }
    }
}
