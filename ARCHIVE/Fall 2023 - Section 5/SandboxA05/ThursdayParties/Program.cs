using System.Diagnostics.CodeAnalysis;

namespace ThursdayParties
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // create an array
            double[] priceList = new double[5];

            // put values in it
            for (int index = 0; index < priceList.Length; index++)
            {
                bool isValid = false;
                double price = 0;

                do
                {
                    Console.Write("Enter the price of the item: ");
                    string userInput = Console.ReadLine();
                    try
                    {
                        price = double.Parse(userInput);
                        isValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("That is not a valid price.");
                    }
                } while (isValid == false);

                priceList[index] = price;
            }

            // totalling the order
            double sum = 0;

            for (int index = 0; index < priceList.Length; index++)
            {
                sum += priceList[index];
            }

            Console.WriteLine($"Total order cost is {sum:c}");

            Console.WriteLine("Goodbye.");
        }

        static void Array(string[] args)
        {
            bool isValid = false;

            do
            {
                int myInt;
                Console.Write("Please enter a number: ");

                try
                {
                    myInt = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch // if anything in the try fails, this will run
                {
                    Console.WriteLine("Hey, that isn't a number. Try again.");
                }
            } while (!isValid);

            Console.WriteLine("Yay, you know what a number is.");
        }

        static void Main3(string[] args)
        {
            // declare variables:
            double userSavings;

            // prompt the user for their savings
            Console.Write("How much do you have saved up? ");
            userSavings = Convert.ToDouble(Console.ReadLine());

            // branch according to whether they have >= $25k
            if (userSavings >= 25000)
            {
                // check vacation days
                Console.Write("How many vacation days do you have? ");
                int vacationDays = Convert.ToInt32(Console.ReadLine());

                // if vacation days is at least 14: buy a ticket!
                if (vacationDays >= 14) { Console.WriteLine("Let's buy our ticket now!!"); }
                // otherwise: go work more
                else { Console.WriteLine("Go work some more."); }
            }
            else
            {
                // how much can you save per month?
                Console.Write("How much can you save per month? ");
                double monthlySavings = Convert.ToDouble(Console.ReadLine());
                double howMuchMoreWeNeed = 25000 - userSavings;
                double numMonths = howMuchMoreWeNeed / monthlySavings;

                // calculate how many months until they can afford the trip of their dreams
                Console.WriteLine($"You will have enough money in {numMonths} months.");
            }

        }

        static void MainV2(string[] args)
        {
            // declare variables
            char animalChoice;
            string animalSound;

            // prompt the user for an animal
            Console.WriteLine("Hello! Please choose an animal.\n" +
                "Press C for Cat\n" +
                "Press D for Dog\n" +
                "Press H for Horse\n" +
                "Press W for Cow");
            animalChoice = char.Parse(Console.ReadLine());

            // branch according to the response
            switch (animalChoice)
            {
                case 'C':
                case 'c':
                    animalSound = "Meow";
                    break; // this gets us out of the switch statement
                case 'D':
                case 'd':
                    animalSound = "Woof";
                    break;
                case 'H':
                case 'h':
                    animalSound = "Neighhhhh";
                    break;
                case 'W':
                case 'w':
                    animalSound = "Moooooo";
                    break;
                default: // if all of the previous values don't match
                    animalSound = "INVALID CHOICE. Read more carefully.";
                    break;
            }

            // this is pretty much the same as:
            if (animalChoice == 'C') { animalSound = "Meow"; }
            else if (animalChoice == 'D') { animalSound = "Woof"; }
            else if (animalChoice == 'H') { animalSound = "Neighhh"; }
            else if (animalChoice == 'W') { animalSound = "Moooo"; }
            else animalSound = "INVALID CHOICE.";


            Console.WriteLine(animalSound);

            int faveNum = 4;

            switch (faveNum)
            {
                case 4:
                    Console.WriteLine("Me too!");
                    break;
                default:
                    break;
            }




        }

        static void MainV1(string[] args)
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
            if (userResponse == 'Y')
            {
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