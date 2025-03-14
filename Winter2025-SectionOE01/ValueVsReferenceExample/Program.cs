namespace ValueVsReferenceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cmOfSnow = 10; // simple data types are passed by VALUE
            ChangeNumber(cmOfSnow); // passing a copy of the value (10)
            Console.WriteLine(cmOfSnow); // cmOfSnow is still 10

            double[] temperatures = { -10, 0, -20 }; // arrays are REFERENCE type
            ChangeElement(temperatures); // we're passing a reference to the array
            Console.WriteLine(temperatures[0]); // now the element is 100

        }

        static void ChangeNumber(double number)
        {
            // this is a completely separate variable
            number = 100;
        }

        // overloaded method: same name, different params:
        static void ChangeNumber(int number)
        {
            number = 100;
        }

        static void ChangeElement(double[] numbers)
        {
            numbers[0] = 100;
        }
    }
}
