namespace Nov20ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's create a default superhero:
            SuperHero cpsc1012 = new SuperHero(); // create a superhero using the no-arg constructor
            SuperHero dutchie = new SuperHero("The Iron Dutchie", "wealth", "was catnapped", 2, 15, false, false, true, false);

            // call the 4 new methods we just created to access & mutate one of our objects
            Console.WriteLine($"The name of the superhero is {cpsc1012.GetName()}. " +
                $"Their super power is {cpsc1012.GetSuperPower()}. " +
                $"They have been an avenger for {cpsc1012.GetYearsAsAvenger()} years.");
            Console.WriteLine($"The name of the superhero is {dutchie.GetName()}. " +
                $"Their super power is {dutchie.GetSuperPower()}. " +
                $"They have been an avenger for {dutchie.GetYearsAsAvenger()} years.");

            cpsc1012.SetIsRetired(true);
            cpsc1012.SetUsesWeapon(true);
            cpsc1012.SetCanFly(true);
            cpsc1012.SetYearsAsAvenger(15);

            Console.WriteLine($"The name of the superhero is {cpsc1012.GetName()}. " +
                $"Their super power is {cpsc1012.GetSuperPower()}. " +
                $"They have been an avenger for {cpsc1012.GetYearsAsAvenger()} years.");

            //cpsc1012.SetYearsAsAvenger(-5); // this will throw an exception

            cpsc1012.TurnIntoAntiHero();
            cpsc1012.DisplayInfo();

            dutchie.Edit();
            dutchie.Edit();
            dutchie.DisplayInfo();

            List<SuperHero> list = new List<SuperHero>();
            list.Add(cpsc1012);
            list.Add(dutchie);
            list.Add(new SuperHero());

            Console.WriteLine("goodbye!");
        }

        static void DisplayGrid(int numColumns, int numRows)
        {

            for (int row = 0; row < numRows; row++)
            {
                // print a line of asterisks
                for (int col = 0; col < numColumns * 2 + 1; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                // print alternating asterisks & stars
                for (int col = 0; col < numColumns * 2 + 1; col++)
                {
                    // if i is an even number
                    if (col % 2 == 0)
                    {
                        // print asterisk
                        Console.Write("*");
                    }
                    else // otherwise
                    {  // print a space
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // print a line of asterisks
            for (int col = 0; col < numColumns * 2 + 1; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // TO DO: remove my repeated WriteLine calls

        }
    }
}