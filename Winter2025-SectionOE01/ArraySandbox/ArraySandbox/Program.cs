/*
 * Purpose: To create a few arrays & access their elements
 */
namespace ArraySandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we can create arrays by defining the size AND providing the values:
            string[] coins = new string[6] { "penny", "nickel", "dime", "quarter", "loonie", "toonie" };
            Console.WriteLine(coins);

            // alternatively, we can just directly provide the values without specifying the size:
            int[] values = { 1, 5, 10, 25, 100, 200 };

            // we can even create arrays of ZERO elements:
            string[] mystery = { };

            // and finally, we can create an array by ONLY specifying the size
            // all the elements will hold the DEFAULT values for that data type
            string[] catNames = new string[10]; // define the size

            /****************************************************/
            // how to access ONE element from an array
            Console.WriteLine(coins[0]);
            // we can also modify the elements in an array:
            coins[0] = "gold";

            /*****************************************/
            // we are going to add a value into each element of catNames
            for (int i = 0; i < catNames.Length; i++)
            {
                // ask the user for a name
                Console.Write("Please enter the cat's name: ");
                // save the name into the array
                catNames[i] = Console.ReadLine();
                // the first iteration, i = 0, then i = 1, etc etc.
            }

            // iterate through a loop and DISPLAY its contents
            for (int i = 0; i < catNames.Length; i++)
            {
                Console.WriteLine($"Cat #{i + 1}: {catNames[i]}");
            }


            // YOUR CHALLLENGE:
            // an array of strings containing your favourite movies/snacks/teams

            Console.WriteLine("goodbye!");
        }
    }
}
// future ideas: cat names
