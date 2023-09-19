namespace Sep18ClassExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // let's play around with powers
            double num = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 ;
            Console.WriteLine(num);

            Math.Pow(2, 30);
            Console.WriteLine(num);

            // let's calculate a square root
            num = Math.Sqrt(25);
            Console.WriteLine(num);

            // rounding numbers
            num = Math.PI;
            Console.WriteLine(num);

            double roundedPi = Math.Round(num);
            Console.WriteLine(roundedPi);

            roundedPi = Math.Round(num, 5);
            Console.WriteLine(roundedPi);

            // working with constants
            const double GST_RATE = 0.05;
           


        }
    }
}