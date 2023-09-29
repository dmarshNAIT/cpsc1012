namespace ThursdayParties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double cake = 3467.6876;
            // version 1: concatenation using + signs
            Console.WriteLine("Last year I ate " + cake + " number of cakes.");
            // version 2: substitution parameters
            Console.WriteLine("Last year I ate {0} number of cakes.", cake);
            // version 3: string interpolation
            Console.WriteLine($"Last year I ate {cake} number of cakes.");


            double a;
            double b;
            int c;
            string d;

            double aa, bb, f, h, w;
            int cc;
            string dd;

            double aaa, // this holds the # of cakes
                bbb;    // this is the # of ingredients
            int ccc;    // this holds the size of my kitchen
            string ddd;

            Console.WriteLine("hi I'm Dana\n\n\nit is nice to meet you");

            Console.WriteLine(3456789); //int
            Console.WriteLine(3456789.123); //double

            Console.Write("here is some text ");
            Console.Write("and some more txt\n\n\n");

            double num;
            num = 4;
            num = 2 + 2 + 2 + 2;
            num = 5 * 5 * 5;
            num = Math.Pow(5, 3);

            int result = 5 / 2;
            Console.WriteLine(result); // 2
            int remainder = 5 % 2; // leftover 1

            // square root
            num = Math.Sqrt(25);
            Console.WriteLine(num);

            // rounding
            num = 567890.654687654;
            Console.WriteLine(num);
            double roundedNum = Math.Round(num);
            Console.WriteLine(roundedNum);
            roundedNum = Math.Round(num, 2);
            Console.WriteLine(roundedNum);


            string nonsense;
            nonsense = "fdslkdsfldsfkjl1287344387?!??!?!   ";
            nonsense = "4";

            string input;
            input = Console.ReadLine();

            int age;
            age = int.Parse(input);

            string ageCategory;

            if (age >= 18)
            {
                // now we check if they are a youth (18-25)
                if (age <= 25)
                {
                    Console.WriteLine("You are a youth.");
                    ageCategory = "youth";
                } // inner if block

            } // end of my outer if-block
            else
            {
                Console.WriteLine("You are a child.");
            } // end of my else-block

            // example of !=
            // first let's ask the question:
            Console.WriteLine("Do you want to continue? (Y)es or (N)o.");
            input = Console.ReadLine();
            char userResponse = char.Parse(input);
            // then, we can make a decision
            if (userResponse != 'N')
            {
                Console.WriteLine("Continue.....");
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }

            // or, we could do this instead:
            if (userResponse == 'Y') {
                Console.WriteLine("Continue...");

            }
            else
            {
                Console.WriteLine("Goodbye.");

            }



        } // end of my Main method

        // new method here

    } // end of my class
} // end of my namespace