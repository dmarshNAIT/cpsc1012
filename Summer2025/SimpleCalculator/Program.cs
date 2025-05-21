namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputOne,
                inputTwo,
                sum,         // result of addition
                difference,  // result of subtraction
                product;     // result of multiplication
            double quotient; // result of division
            string userInput;

            //- get & save 1st user input
            Console.Write("Please enter 1st number: ");
            inputOne = int.Parse(Console.ReadLine());

            //- get & save 2nd user input
            Console.Write("Please enter 2nd number: ");
            userInput = Console.ReadLine();
            inputTwo = int.Parse(userInput);

            //- calculate results
            sum = inputOne + inputTwo;
            difference = inputOne - inputTwo;
            product = inputOne * inputTwo;
            quotient = (double) inputOne / inputTwo;

            //- display results
            Console.WriteLine($"The sum is {sum}.\n" +
                $"The difference is {difference}.\n" +
                $"The product is {product}.\n" +
                $"The quotient is {quotient}.\n");
  
        }
    }
}
