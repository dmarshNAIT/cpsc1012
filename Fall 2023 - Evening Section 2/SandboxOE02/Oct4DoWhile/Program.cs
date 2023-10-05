namespace Oct4DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables:
            char userContinue;

            // welcome our user
            Console.WriteLine("Welcome!");

            do
            {
                const double KG_TO_LB = 2.205;
                const int MIN_NUMBER = 1,
                    MAX_NUMBER = 10;
                Random numGenerator = new Random();

                // display a menu of options
                Console.WriteLine("What would you like to do?\n" +
                    "[C]onvert from kg to lb\n" +
                    "Do a Math [Q]uiz");
                char userChoice = char.Parse(Console.ReadLine());

                // branch according to their response
                switch (char.ToUpper(userChoice)) // giving the uppercase version of userChoice
                {
                    case 'C':
                        // get our user input:
                        Console.Write("Please enter the mass in kg: ");
                        double kg = double.Parse(Console.ReadLine());

                        // return the converted result
                        Console.WriteLine($"That is { kg * KG_TO_LB } lb.");

                        break;
                    case 'Q':
                        // let's generate 2 random ints
                        int baseNumber = numGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
                        int power = numGenerator.Next(MIN_NUMBER, MAX_NUMBER / 2);

                        // calculate the result
                        double correctAnswer = Math.Pow(baseNumber, power);

                        // ask the user to solve the equation
                        Console.Write($"What is {baseNumber} to the power of {power} = ");
                        double userAnswer = double.Parse(Console.ReadLine());

                        // let the user know if they are correct
                        string outputMessage = (userAnswer == correctAnswer) ? "CORRECT!" : "WRONG!";
                        Console.WriteLine(outputMessage);

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID CHOICE.");
                        Console.ResetColor();
                        break;
                }

                // ask them if they'd like to play again. 
                Console.Write("\nWould you like to play again? [Y/N]: ");
                userContinue = char.Parse(Console.ReadLine());
                Console.WriteLine();

                //if so, loop back to the start
            } while (userContinue == 'Y' || userContinue == 'y');

            // goodnight!
            Console.WriteLine("Goodnight!");
        }
    }
}