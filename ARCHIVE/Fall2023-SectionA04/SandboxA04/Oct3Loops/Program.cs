namespace Oct3Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalNum,
                currentNum,
                result = 1 ;

            Console.Write("Welcome to our Factorial Calculator!\n\n" +
                "Please enter a #: ");
            originalNum = int.Parse(Console.ReadLine());
            currentNum = originalNum;

            while ( currentNum > 1 )
            {
                result *= currentNum; // result = result * currentNum
                currentNum--;         // currentNum = currentNum - 1
            }

            Console.WriteLine($"The value of {originalNum}! is {result}.");


        }
    }
}