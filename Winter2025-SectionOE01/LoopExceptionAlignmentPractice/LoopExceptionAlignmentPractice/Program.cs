/*
 * Purpose: Calculate Alberta's GST on as purchase.
 * Author:  Dana Marsh
 */
namespace LoopExceptionAlignmentPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double price = 0, // initialize this to make VS happy
                 gst;
            const double GST_RATE = 0.05;
            bool isValid = false;

            Console.WriteLine("Welcome!!!");

            do
            {
                Console.Write("Please enter the price: $");
                try
                {
                    price = double.Parse(Console.ReadLine());
                    // make sure the user can't enter negative values
                    if (price > 0)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Price must be a positive value.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (isValid == false);

            // calculate the GST
            gst = price * GST_RATE;

            // print out the original value & the GST, with the numbers aligned
            Console.WriteLine($"Price: {price,11:c}\n" +
                $"GST:   {gst,11:c}");
            // we used a width of $11 to support numbers up to $10,000.00
            // we used c to format both numbers as currency

        }
    }
}
