namespace Oct23Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;

            Console.WriteLine("Hello!");
            CongratulateDutchie(); // here we are calling our other method
            PrintInYellow("this is my exciting message.");
            result = CalculateSum(1, 5);
            Console.WriteLine("Our method returned the value " + result);
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

        static double CalculateSum(double firstNum, double secondNum)
        {
            double sum = firstNum + secondNum;
            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
            return sum;
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