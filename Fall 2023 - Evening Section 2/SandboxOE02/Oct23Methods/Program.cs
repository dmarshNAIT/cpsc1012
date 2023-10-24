namespace Oct23Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            CongratulateDutchie(); // here we are calling our other method
            PrintInYellow("this is my exciting message.");
            Console.WriteLine("Goodbye.");
        }

        static void CongratulateDutchie()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congrats, Dutchie! You're an awesome cat.");
            Console.ResetColor();
        }

        static void PrintInYellow(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}

/* Wish list
 * 
 * switch statement
 * something similar to assignment 3
 * while
 * exceptions
 */ 