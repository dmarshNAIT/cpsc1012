namespace Topic6_MethodsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;

            PrintGreeting();
            grade = ReturnFailingGrade();
            Console.WriteLine("The ghost's grade is " + grade);
            GreetUser("Dana");

        }

        static void PrintGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Happy Hallowe'en!");
            Console.ResetColor();
        }

        static char ReturnFailingGrade()
        {
            return 'F';
        }

        static void GreetUser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello, " + name);
            Console.ResetColor();
        }

    }
}
