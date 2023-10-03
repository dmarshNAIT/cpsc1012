namespace Oct2LoanQualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int salary,
                numYears;

            Console.WriteLine("Welcome to our Super Official Loan Qualifier 3000.");

            Console.Write("Please enter your income in $: ");
            salary = int.Parse(Console.ReadLine());

            if (salary >= 30000)
            {
                Console.Write("How many years have you been at your current job (whole numbers only): ");
                numYears = int.Parse(Console.ReadLine());

                if (numYears >= 2)
                {
                    Console.WriteLine("Congrats! You qualify for our loans with ridiculous interest rates!");
                }
                else
                {
                    Console.WriteLine("Sorry, you need to have 2 years of experience.");
                } // end of inner-else block

            } // end of outer if-block
            else
            {
                Console.WriteLine("Sorry, minimum salary of $30k is required.");
            } // end of outer-else block

        } // end of Main()
    } // end of class
} // end of namespace