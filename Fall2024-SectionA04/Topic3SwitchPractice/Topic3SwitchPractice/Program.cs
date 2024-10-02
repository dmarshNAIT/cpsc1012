/* Name:        Food Grade Calculator
 * Author:      Dana & friends
 * Modified:    Oct 2, 2024
 * 
 * Input:       A food grade from a list of options.
 * Output:      The price of that grade.
 * 
 * Purpose:     To see how switch statements work.
 */

namespace Topic3SwitchPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create variables
            char foodGrade;
            double price;

            // prompt user for a choice
            Console.Write("Our pet food is available in three grades:\n" +
                "A, B, and C. Which do you want pricing for? ");
            foodGrade = char.Parse(Console.ReadLine());
            //foodGrade = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            // assign price
            switch (foodGrade)
            {
                case 'A':
                case 'a':
                    price = 15.00;
                    break;
                case 'B':
                case 'b':
                    price = 30.00;
                    break;
                case 'C':
                case 'c':
                    price = 80.00;
                    break;
                default:
                    price = 0;
                    break;
            }

            // print results
            Console.WriteLine($"The cost of food is {price:c}.");
        }
    }
}
