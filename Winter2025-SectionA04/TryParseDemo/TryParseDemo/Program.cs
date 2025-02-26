namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goodInput;

            do
            {
                string userInput;
                int age;

                Console.Write("Please enter a #: ");
                userInput = Console.ReadLine();

                goodInput = int.TryParse(userInput, out age);
                // this line will try to parse userInput as an int
                // if successful, goodInput is now TRUE and age now has a value
                // otherwise, goodInput is now FALSE

            } while (goodInput == false);

        }
    }
}
