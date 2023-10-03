namespace Oct2LoanQualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double salary;
            int years;

            Console.WriteLine("Welcome to our Excellent Loan Advisor Program.");

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary >= 30000)
            {
                Console.Write("Please enter # of years as a whole number: ");
                years = Convert.ToInt32(Console.ReadLine());

                if (years >= 2)
                {
                    Console.WriteLine("Congrats! You are qualified!");
                }
                else
                {
                    Console.WriteLine("Sorry, you need more experience.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you need a higher income.");
            } // end of outer else

        }
    }
}