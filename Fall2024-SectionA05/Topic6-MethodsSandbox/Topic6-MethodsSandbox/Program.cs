using System.Net.Mail;

namespace Topic6_MethodsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeUser();
            int[] myValues = GetWinningLotteryNumbers();

            int total = GetSumOfNumbers(myValues);
            Console.WriteLine("The total is " + total);
        }

        // void method w/ no params
        static void WelcomeUser()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello, fellow vampire.");
            Console.ResetColor();
        }

        // method w/ no params that returns something
        static int[] GetWinningLotteryNumbers()
        {
            int[] winningNumbers = { 47, 8, 23, 30, 32, 33, 49};
            return winningNumbers;
        }

        // method w/ params
        static int GetSumOfNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
}
