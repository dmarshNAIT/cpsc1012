/*
 * Purpose:     To demonstrate some techniques for formatting output.
 * Author:      Dana
 * 
 * Modified:    Feb 11, 2025
 */

namespace StringFormattingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentID = 444777;
            double balance = 123.456;

            // v1: let's just print the "raw" numbers
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine();

            // v2: let's adjust the number of digits & add punctuation
            Console.WriteLine($"Student ID: {studentID:0000-0000}");
            Console.WriteLine($"Balance: {balance:$0.00}");
            Console.WriteLine();

            // v3: let's line up our numbers
            Console.WriteLine($"Student ID: {studentID,12:0000-0000}");
            Console.WriteLine($"Balance:    {balance,12:$0.00}");
            Console.WriteLine();

            // v4: let's line up on the left-side instead
            Console.WriteLine($"Student ID: {studentID,-12:0000-0000}");
            Console.WriteLine($"Balance:    {balance,-12:$0.00}");
        }
    }
}
