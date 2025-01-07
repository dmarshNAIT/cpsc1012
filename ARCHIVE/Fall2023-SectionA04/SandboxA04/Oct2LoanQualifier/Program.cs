namespace Oct2LoanQualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double salary;
            int numYears;

            Console.WriteLine("Welcome to our Super Official Loan Qualifier App.");

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary >= 30000)
            {
                Console.Write("How long have you been at your job (in years): ");
                numYears = Convert.ToInt32(Console.ReadLine());

                if(numYears >= 2)
                {
                    Console.WriteLine("Congrats! Here is a loan with a ridiculous interest rate.");
                }
                else
                {
                    Console.WriteLine("Sorry, you need to be at your current job for at least 2 years."); 
                }
            }
            else
            {
                Console.WriteLine("Sorry, you need a higher salary.");
            } // end of else-block

        }
    }
}