/*
 * 
 * TODO: FILL THIS OUT
 * 
 * 
 */
namespace Topic3Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int numberOfGlasses;

            // prompt the user for the # of glasses
            Console.Write("Please enter the # of glasses of water you had today: ");
            numberOfGlasses = int.Parse(Console.ReadLine());

            // < 0 --> stop crying
            if (numberOfGlasses < 0)
            {
                Console.WriteLine("Stop crying, you're in the negative.");
            }
            // 0-2 --> drink more
            else if (numberOfGlasses <= 2)
            {
                Console.WriteLine("You need to drink more water.");
            }
            // 3-7 --> you're on track
            else if (numberOfGlasses <= 7)
            {
                Console.WriteLine("You're on track!");
            }
            // 8-14 --> you're hydrated
            else if (numberOfGlasses <= 14)
            {
                Console.WriteLine("You're hydrated enough.");
            }
            // 15+ --> too hydrated
            else
            {
                Console.WriteLine("That's way too much water.");
            }





            // if the user drinks 8+ glasses: congratulate
            if (numberOfGlasses >= 8)
            {
                Console.WriteLine("YAY! You are hydrated.");
            }

            // if the user drinks <2 glasses: suggest more
            if (numberOfGlasses < 2)
            {
                Console.WriteLine("Go drink water now.");
            }



            // suffix practice
            double myDouble = 1.2;
            float myFloat = -1.2f;

            short myShort = 1;

        }
    }
}
