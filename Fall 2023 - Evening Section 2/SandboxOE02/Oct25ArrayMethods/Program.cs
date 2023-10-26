namespace Oct25ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize;

            // ask the user how many #s they want to store
            arraySize = GetValidInt("How many temperatures do you want to save: ");

            // create an array
            double[] temperatures = new double[arraySize];

            // user will provide values
            LoadArray(temperatures);

            // display values
            DisplayArray(temperatures);

        }

        static int GetValidInt(string prompt)
        {
            int userInput = 0;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's not valid.");
                }
            } while (!isValid);

            return userInput;
        }

        static double GetValidDouble(string prompt)
        {
            double userInput = 0;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                try
                {
                    userInput = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's not valid.");
                }
            } while (!isValid);

            return userInput;
        }

        static void LoadArray(double[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = GetValidDouble("Please enter temp: ");
            }
        }

        static void DisplayArray(double[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"Temp #{index + 1, 2} is {array[index], 5} degrees");
            }
        }

    }
}