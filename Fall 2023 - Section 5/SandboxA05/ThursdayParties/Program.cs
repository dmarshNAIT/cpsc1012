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

            if (age >= 18)
            {
                Console.WriteLine("You are a grown up!");
            } // end of my if-block
            else
            {
                Console.WriteLine("You are a child.");
            } // end of my else-block
            

        } // end of my Main method

        // new method here

    } // end of my class
} // end of my namespace