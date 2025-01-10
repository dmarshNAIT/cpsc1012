namespace Oct23Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            PrintMessage();
            PrintInPink("hey this is a message I wrote.");
            Console.WriteLine($"I predict tomorrow's weather is {PredictWeather()} degrees.");
            Console.WriteLine($"I predict tomorrow's weather is {PredictWeather("winter")} degrees");

            Console.WriteLine("Goodbye.");
        }

        static void PrintMessage()
        {
            Console.WriteLine("Inconceivable!");
        }

        static void PrintInPink(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static int PredictWeather()
        {
            Random numGenerator = new Random();
            return numGenerator.Next(-40, 36);
        }

        static int PredictWeather(string season)
        {
            Random numGenerator = new Random();
            int randomNum;

            switch (season)
            {
                case "summer":
                    randomNum = numGenerator.Next(10, 41);
                    break;
                case "spring":
                case "fall":
                    randomNum = numGenerator.Next(-5, 21);
                    break;
                case "winter":
                    randomNum = numGenerator.Next(-40, 6);
                    break;
                default:
                    randomNum = 0; // lazy way out: if they pass in any other string, we still need to return a value
                    break;
            }

            return randomNum;
        }


    }
}

