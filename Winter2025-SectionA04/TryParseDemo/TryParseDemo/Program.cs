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

            } while (goodInput == false);

        }
    }
}
